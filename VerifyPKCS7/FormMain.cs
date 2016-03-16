using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VerifyPKCS7
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private bool checkfile(string fpath)
        {
            if (System.IO.File.Exists(fpath))
            {
                try
                {
                    System.IO.File.OpenRead(fpath);
                    return true;
                }
                catch (Exception)
                {
                }
            }
            return false;
        }

        private void updatecombo(ComboBox cb,
            System.Collections.Specialized.StringCollection strs,
            string t)
        {
            if (cb.Items.IndexOf(t) != 0)
            {
                // should save selection and cursor position here
                int ss = cb.SelectionStart;
                int sl = cb.SelectionLength;

                cb.Items.Remove(t);
                cb.Items.Insert(0, t);
                cb.Select(ss, sl);

                strs.Clear();

                foreach (string i in cb.Items)
                    strs.Add(i);

                Properties.Settings.Default.Save();
            }

            if (!cb.Text.Equals(t))
                cb.Text = t;
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            openFileDialog.FileName = comboFile.Text;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
                updatecombo(comboFile, Properties.Settings.Default.MRUList, openFileDialog.FileName);
        }

        private void loadcombo(ComboBox cb, StringCollection strs, string text)
        {
            /* 
            There is possibility of data binding between control propertias and settings. However,
                * you cannot store combobox items as string collection setting because the items are generic collection
                * you can bind the text property to a setting but saving preferences in textchanged handler saves old value
                * updating the bound preference causes cursor position reset in the combobox
            So doing this by hand makes sense at least for combo boxes.
            */
            //cb.Items.Clear();
            foreach (string i in strs)
                cb.Items.Add(i);
            cb.Text = text;
            if (text.Length > 0) cb.SelectionStart = text.Length;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            Properties.Settings settings = Properties.Settings.Default;
            if (settings.MRUList == null)
                settings.MRUList = new StringCollection { };
            if (settings.EXTList == null)
                settings.EXTList = new StringCollection { };

            /* mind order - textchanged methods are chained */
            loadcombo(comboExt, settings.EXTList, settings.EXT);
            loadcombo(comboFile, settings.MRUList, settings.MRU);                       
        }


        private string addext()
        {
            return String.Concat(comboFile.Text, ".", comboExt.Text);
        }

        private string replaceext()
        {

            string[] strs = comboFile.Text.Split('.');
            if (strs.Length > 1)
            {
                return String.Concat(String.Join(".", strs.Take(strs.Length - 1)), ".", comboExt.Text);
            }
            return "";
        }

        private void labelcolor(Label l, bool color)
        {
            if (color)
                l.ForeColor = Color.Green;
            else
                l.ForeColor = Color.Red;
        }

        private void comboExt_TextChanged(object sender, EventArgs e)
        {
            string f;
            bool valid = false;
            if (comboExt.Text.Length > 0)
            {
                f = addext();
                if (!checkfile(f))
                    f = replaceext();

                SignatureFile.Text = f;
                valid = checkfile(f);
            }
            else
                SignatureFile.Text = "";

            labelcolor(SignatureFile, valid);
            if (valid)
                updatecombo(comboExt, Properties.Settings.Default.EXTList, comboExt.Text);
            if (!Properties.Settings.Default.EXT.Equals(comboExt.Text))
            {
                Properties.Settings.Default.EXT = comboExt.Text;
                Properties.Settings.Default.Save();
            }
        }

        private void comboFile_TextChanged(object sender, EventArgs e)
        {
            bool valid = checkfile(comboFile.Text);

            labelcolor(labelFile, valid);
            if (valid)
                updatecombo(comboFile, Properties.Settings.Default.MRUList, comboFile.Text);
            if (!Properties.Settings.Default.MRU.Equals(comboFile.Text))
            {
                Properties.Settings.Default.MRU = comboFile.Text;
                Properties.Settings.Default.Save();
            }
            comboExt_TextChanged(sender, e);
        }
    }
}
