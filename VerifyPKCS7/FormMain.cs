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
using System.Security.Cryptography.Pkcs;


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
                    System.IO.FileStream fs = System.IO.File.OpenRead(fpath);
                    fs.Close();
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

        private void labelcolor(LabelBorder.LabelBorder l, bool color)
        {
            if (color)
                l.BorderColor = Color.Green;
            else
                l.BorderColor = Color.Red;
        }

        private void labelclear(LabelBorder.LabelBorder l)
        {
            l.BorderColor = l.BackColor;
        }

        private void checkreset()
        {
            result.Text = "";
            pictureKey.Image = Properties.Resources.Goldkey;
            labelclear(SignatureFile);
        }

        private void result_append(string str)
        {
            result.Text = String.Concat(str, "\n", result.Text);
        }

        private void sigcheck()
        {
            uint MaxMsg = Properties.Settings.Default.MaxMsg;
            uint MaxSig = Properties.Settings.Default.MaxSig;
            string mfpath = comboFile.Text;
            string sfpath = SignatureFile.Text;
            System.IO.FileStream mfs, sfs;
            uint msglen, siglen;
            byte[] msg;
            byte[] sig = null;

            try
            {
                mfs = System.IO.File.OpenRead(mfpath);
                msglen = (uint)mfs.Length;
            }
            catch (Exception)
            {
                return;
            }
            if (msglen > MaxMsg)
            {
                result_append(String.Format("File {0} longer than {1} bytes.", mfpath, MaxMsg));
                return;
            }
            msg = new byte[msglen];
            mfs.Read(msg, 0, (int)msglen);
            if (sfpath.Length > 0)
            {
                try
                {
                    sfs = System.IO.File.OpenRead(sfpath);
                    siglen = (uint)sfs.Length;
                }
                catch (Exception)
                {
                    return;
                }
                if (siglen > MaxSig)
                {
                    result_append(String.Format("File {0} longer than {1} bytes.", sfpath, MaxSig));
                    return;
                }
                sig = new byte[siglen];
                sfs.Read(sig, 0, (int)siglen);

            }
            bool detached = (sig != null);
            
            try
            {
                ContentInfo cmsg = new ContentInfo(msg);
                SignedCms cms = new SignedCms(cmsg, detached);
                if (detached)
                    cms.Decode(sig);                
                result_append("Message decoded");
                cms.CheckHash();
                result_append("Hash checked");
                cms.CheckSignature(true);
                result_append("Signature checked");
                foreach (SignerInfo si in cms.SignerInfos)
                {
                    result.Text = String.Concat(
                        result.Text,
                        String.Format("Serial: {3}\nDigest Algorithm: {6}\nIssuer: {4}\nValid after: {2}\nValid until: {1}\nSubject: {5}\nFingerprint: {0}\n\n",
                            si.Certificate.Thumbprint,
                            si.Certificate.NotAfter,
                            si.Certificate.NotBefore,
                            si.Certificate.SerialNumber,
                            si.Certificate.Issuer,
                            si.Certificate.Subject,
                            String.Format("{0} ({1})", si.DigestAlgorithm.FriendlyName, si.DigestAlgorithm.Value)
                            )
                        );
                }
                cms.CheckSignature(false);
                result_append("Signature certificate validated");
            }
            catch (Exception e)
            {
                result_append(String.Format("{0:X}: {1}", e.HResult, e.Message));
                return;
            }
            pictureKey.Image = Properties.Resources.Greenkey;
        }

        private void comboExt_TextChanged(object sender, EventArgs e)
        {
            string f;
            bool valid = false;
            checkreset();
            if ((comboExt.Text.Length > 0) && panelSigExt.Enabled)
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
            sigcheck();
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

        private void checkDetached_CheckedChanged(object sender, EventArgs e)
        {
            panelSigExt.Enabled = checkDetached.Checked;
            comboExt_TextChanged(sender, e);
        }

        private void comboFile_DragDrop(object sender, DragEventArgs e)
        {
            string f = comboFile.Text;
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false))
                f = ((string[])e.Data.GetData(DataFormats.FileDrop, false))[0];
            else if (e.Data.GetDataPresent(DataFormats.StringFormat, true))
                f = e.Data.GetData(DataFormats.StringFormat, true).ToString();
            updatecombo(comboFile, Properties.Settings.Default.MRUList, f);
        }

        private void comboFile_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false))
                e.Effect = DragDropEffects.Link;
            else if (e.Data.GetDataPresent(DataFormats.StringFormat, true))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void buttonDismiss_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
