namespace VerifyPKCS7
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelMain = new System.Windows.Forms.TableLayoutPanel();
            this.result = new System.Windows.Forms.RichTextBox();
            this.panelFile = new System.Windows.Forms.TableLayoutPanel();
            this.comboFile = new System.Windows.Forms.ComboBox();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.labelFile = new LabelBorder.LabelBorder();
            this.panelBottom = new System.Windows.Forms.TableLayoutPanel();
            this.buttonDismiss = new System.Windows.Forms.Button();
            this.pictureKey = new System.Windows.Forms.PictureBox();
            this.GroupSig = new System.Windows.Forms.GroupBox();
            this.panelSig = new System.Windows.Forms.TableLayoutPanel();
            this.panelSigExt = new System.Windows.Forms.TableLayoutPanel();
            this.labelSigExt = new System.Windows.Forms.Label();
            this.comboExt = new System.Windows.Forms.ComboBox();
            this.SignatureFile = new LabelBorder.LabelBorder();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.checkDetached = new System.Windows.Forms.CheckBox();
            this.panelMain.SuspendLayout();
            this.panelFile.SuspendLayout();
            this.panelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureKey)).BeginInit();
            this.GroupSig.SuspendLayout();
            this.panelSig.SuspendLayout();
            this.panelSigExt.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            resources.ApplyResources(this.panelMain, "panelMain");
            this.panelMain.Controls.Add(this.result, 0, 2);
            this.panelMain.Controls.Add(this.panelFile, 0, 0);
            this.panelMain.Controls.Add(this.panelBottom, 0, 3);
            this.panelMain.Controls.Add(this.GroupSig, 0, 1);
            this.panelMain.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.panelMain.Name = "panelMain";
            // 
            // result
            // 
            this.result.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.result.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.result, "result");
            this.result.HideSelection = false;
            this.result.Name = "result";
            this.result.ReadOnly = true;
            // 
            // panelFile
            // 
            resources.ApplyResources(this.panelFile, "panelFile");
            this.panelFile.Controls.Add(this.comboFile, 1, 0);
            this.panelFile.Controls.Add(this.buttonBrowse, 2, 0);
            this.panelFile.Controls.Add(this.labelFile, 0, 0);
            this.panelFile.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.panelFile.Name = "panelFile";
            // 
            // comboFile
            // 
            this.comboFile.AllowDrop = true;
            resources.ApplyResources(this.comboFile, "comboFile");
            this.comboFile.FormattingEnabled = true;
            this.comboFile.Name = "comboFile";
            this.comboFile.TextChanged += new System.EventHandler(this.comboFile_TextChanged);
            this.comboFile.DragDrop += new System.Windows.Forms.DragEventHandler(this.comboFile_DragDrop);
            this.comboFile.DragEnter += new System.Windows.Forms.DragEventHandler(this.comboFile_DragEnter);
            // 
            // buttonBrowse
            // 
            resources.ApplyResources(this.buttonBrowse, "buttonBrowse");
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // labelFile
            // 
            resources.ApplyResources(this.labelFile, "labelFile");
            this.labelFile.BorderColor = System.Drawing.SystemColors.ControlText;
            this.labelFile.Name = "labelFile";
            // 
            // panelBottom
            // 
            resources.ApplyResources(this.panelBottom, "panelBottom");
            this.panelBottom.Controls.Add(this.buttonDismiss, 2, 0);
            this.panelBottom.Controls.Add(this.pictureKey, 0, 0);
            this.panelBottom.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.panelBottom.Name = "panelBottom";
            // 
            // buttonDismiss
            // 
            resources.ApplyResources(this.buttonDismiss, "buttonDismiss");
            this.buttonDismiss.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonDismiss.Name = "buttonDismiss";
            this.buttonDismiss.UseVisualStyleBackColor = true;
            this.buttonDismiss.Click += new System.EventHandler(this.buttonDismiss_Click);
            // 
            // pictureKey
            // 
            resources.ApplyResources(this.pictureKey, "pictureKey");
            this.pictureKey.Image = global::VerifyPKCS7.Properties.Resources.Goldkey;
            this.pictureKey.InitialImage = global::VerifyPKCS7.Properties.Resources.Goldkey;
            this.pictureKey.Name = "pictureKey";
            this.pictureKey.TabStop = false;
            this.pictureKey.Click += new System.EventHandler(this.pictureKey_Click);
            // 
            // GroupSig
            // 
            resources.ApplyResources(this.GroupSig, "GroupSig");
            this.GroupSig.Controls.Add(this.panelSig);
            this.GroupSig.Name = "GroupSig";
            this.GroupSig.TabStop = false;
            // 
            // panelSig
            // 
            resources.ApplyResources(this.panelSig, "panelSig");
            this.panelSig.Controls.Add(this.panelSigExt, 1, 0);
            this.panelSig.Controls.Add(this.checkDetached, 0, 0);
            this.panelSig.Controls.Add(this.SignatureFile, 2, 0);
            this.panelSig.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.panelSig.Name = "panelSig";
            // 
            // panelSigExt
            // 
            resources.ApplyResources(this.panelSigExt, "panelSigExt");
            this.panelSigExt.Controls.Add(this.labelSigExt, 0, 0);
            this.panelSigExt.Controls.Add(this.comboExt, 1, 0);
            this.panelSigExt.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.panelSigExt.Name = "panelSigExt";
            // 
            // labelSigExt
            // 
            resources.ApplyResources(this.labelSigExt, "labelSigExt");
            this.labelSigExt.Name = "labelSigExt";
            // 
            // comboExt
            // 
            resources.ApplyResources(this.comboExt, "comboExt");
            this.comboExt.Name = "comboExt";
            this.comboExt.TextChanged += new System.EventHandler(this.comboExt_TextChanged);
            // 
            // SignatureFile
            // 
            resources.ApplyResources(this.SignatureFile, "SignatureFile");
            this.SignatureFile.AutoEllipsis = true;
            this.SignatureFile.BorderColor = System.Drawing.SystemColors.ControlText;
            this.SignatureFile.Name = "SignatureFile";
            this.SignatureFile.UseMnemonic = false;
            // 
            // checkDetached
            // 
            resources.ApplyResources(this.checkDetached, "checkDetached");
            this.checkDetached.Checked = global::VerifyPKCS7.Properties.Settings.Default.detached;
            this.checkDetached.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkDetached.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::VerifyPKCS7.Properties.Settings.Default, "detached", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkDetached.Name = "checkDetached";
            this.checkDetached.UseVisualStyleBackColor = true;
            this.checkDetached.CheckedChanged += new System.EventHandler(this.checkDetached_CheckedChanged);
            // 
            // FormMain
            // 
            this.AcceptButton = this.buttonDismiss;
            this.AllowDrop = true;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonDismiss;
            this.ClientSize = global::VerifyPKCS7.Properties.Settings.Default.WindowSize;
            this.Controls.Add(this.panelMain);
            this.DataBindings.Add(new System.Windows.Forms.Binding("ClientSize", global::VerifyPKCS7.Properties.Settings.Default, "WindowSize", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.HelpButton = true;
            this.Name = "FormMain";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.FormMain_HelpButtonClicked);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ClientSizeChanged += new System.EventHandler(this.FormMain_ClientSizeChanged);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.comboFile_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.comboFile_DragEnter);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.panelFile.ResumeLayout(false);
            this.panelFile.PerformLayout();
            this.panelBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureKey)).EndInit();
            this.GroupSig.ResumeLayout(false);
            this.GroupSig.PerformLayout();
            this.panelSig.ResumeLayout(false);
            this.panelSig.PerformLayout();
            this.panelSigExt.ResumeLayout(false);
            this.panelSigExt.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel panelMain;
        private System.Windows.Forms.TableLayoutPanel panelFile;
        private System.Windows.Forms.ComboBox comboFile;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.TableLayoutPanel panelSigExt;
        private System.Windows.Forms.Label labelSigExt;
        private System.Windows.Forms.ComboBox comboExt;
        private System.Windows.Forms.TableLayoutPanel panelBottom;
        private System.Windows.Forms.Button buttonDismiss;
        private System.Windows.Forms.PictureBox pictureKey;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.GroupBox GroupSig;
        private System.Windows.Forms.TableLayoutPanel panelSig;
        private System.Windows.Forms.CheckBox checkDetached;
        private System.Windows.Forms.RichTextBox result;
        private LabelBorder.LabelBorder labelFile;
        private LabelBorder.LabelBorder SignatureFile;
    }
}

