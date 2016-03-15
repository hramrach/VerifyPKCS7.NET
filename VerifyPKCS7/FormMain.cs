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

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            openFileDialog.FileName = comboFile.Text;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                openFileDialog.OpenFile();
                
                comboFile.Items.Remove(openFileDialog.FileName);
                comboFile.Items.Insert(0, openFileDialog.FileName);

                if (Properties.Settings.Default.MRUList == null)
                    Properties.Settings.Default.MRUList = new System.Collections.Specialized.StringCollection { };
                Properties.Settings.Default.MRUList.Clear();
                
                foreach (string i in comboFile.Items)
                    Properties.Settings.Default.MRUList.Add(i);
                Properties.Settings.Default.Save();
                comboFile.Text = openFileDialog.FileName;
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            comboFile.Items.Clear();
            foreach (string i in Properties.Settings.Default.MRUList)
                comboFile.Items.Add(i);
        }
    }
}
