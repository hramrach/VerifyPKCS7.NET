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
                try
                {
                    openFileDialog.OpenFile();
                    comboFile.Text = openFileDialog.FileName;
                }
                catch (Exception)
                {

                }
        }
    }
}
