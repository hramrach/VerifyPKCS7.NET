using System;
using System.Collections.Generic;
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
                cb.Items.Remove(t);
                cb.Items.Insert(0, t);

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

        private void FormMain_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.MRUList == null)
                Properties.Settings.Default.MRUList = new System.Collections.Specialized.StringCollection { };
            if (Properties.Settings.Default.EXTList == null)
                Properties.Settings.Default.EXTList = new System.Collections.Specialized.StringCollection { };
            //comboFile.Items.Clear();
            foreach (string i in Properties.Settings.Default.MRUList)
                comboFile.Items.Add(i);
            //comboExt.Items.Clear();
            foreach (string i in Properties.Settings.Default.EXTList)
                comboExt.Items.Add(i);
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
            string f = addext();
            bool valid;
            if (!checkfile(f))
                f = replaceext();

            SignatureFile.Text = f;
            valid = checkfile(f);
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
