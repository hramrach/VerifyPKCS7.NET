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
            this.labelFile = new System.Windows.Forms.Label();
            this.panelBottom = new System.Windows.Forms.TableLayoutPanel();
            this.buttonDismiss = new System.Windows.Forms.Button();
            this.pictureKey = new System.Windows.Forms.PictureBox();
            this.GroupSig = new System.Windows.Forms.GroupBox();
            this.panelSig = new System.Windows.Forms.TableLayoutPanel();
            this.panelSigExt = new System.Windows.Forms.TableLayoutPanel();
            this.labelSigExt = new System.Windows.Forms.Label();
            this.comboExt = new System.Windows.Forms.ComboBox();
            this.panelSigFormat = new System.Windows.Forms.TableLayoutPanel();
            this.panelRadioSigFormat = new System.Windows.Forms.TableLayoutPanel();
            this.radioSigFormatDer = new System.Windows.Forms.RadioButton();
            this.radioSigFormatBlah = new System.Windows.Forms.RadioButton();
            this.labelSigFormat = new System.Windows.Forms.Label();
            this.checkDetached = new System.Windows.Forms.CheckBox();
            this.SignatureFile = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.panelMain.SuspendLayout();
            this.panelFile.SuspendLayout();
            this.panelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureKey)).BeginInit();
            this.GroupSig.SuspendLayout();
            this.panelSig.SuspendLayout();
            this.panelSigExt.SuspendLayout();
            this.panelSigFormat.SuspendLayout();
            this.panelRadioSigFormat.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMain.ColumnCount = 1;
            this.panelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelMain.Controls.Add(this.result, 0, 2);
            this.panelMain.Controls.Add(this.panelFile, 0, 0);
            this.panelMain.Controls.Add(this.panelBottom, 0, 3);
            this.panelMain.Controls.Add(this.GroupSig, 0, 1);
            this.panelMain.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.RowCount = 4;
            this.panelMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panelMain.Size = new System.Drawing.Size(436, 417);
            this.panelMain.TabIndex = 0;
            // 
            // result
            // 
            this.result.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.result.Cursor = System.Windows.Forms.Cursors.Default;
            this.result.Dock = System.Windows.Forms.DockStyle.Fill;
            this.result.HideSelection = false;
            this.result.Location = new System.Drawing.Point(3, 129);
            this.result.Name = "result";
            this.result.ReadOnly = true;
            this.result.Size = new System.Drawing.Size(430, 250);
            this.result.TabIndex = 13;
            this.result.Text = resources.GetString("result.Text");
            this.result.WordWrap = false;
            // 
            // panelFile
            // 
            this.panelFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panelFile.AutoSize = true;
            this.panelFile.ColumnCount = 3;
            this.panelFile.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.panelFile.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelFile.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.panelFile.Controls.Add(this.comboFile, 1, 0);
            this.panelFile.Controls.Add(this.buttonBrowse, 2, 0);
            this.panelFile.Controls.Add(this.labelFile, 0, 0);
            this.panelFile.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.panelFile.Location = new System.Drawing.Point(3, 3);
            this.panelFile.Name = "panelFile";
            this.panelFile.RowCount = 1;
            this.panelFile.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelFile.Size = new System.Drawing.Size(430, 29);
            this.panelFile.TabIndex = 0;
            // 
            // comboFile
            // 
            this.comboFile.AllowDrop = true;
            this.comboFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboFile.FormattingEnabled = true;
            this.comboFile.Location = new System.Drawing.Point(32, 4);
            this.comboFile.Name = "comboFile";
            this.comboFile.Size = new System.Drawing.Size(314, 21);
            this.comboFile.TabIndex = 2;
            this.comboFile.Text = "file";
            this.comboFile.TextChanged += new System.EventHandler(this.comboFile_TextChanged);
            this.comboFile.DragDrop += new System.Windows.Forms.DragEventHandler(this.comboFile_DragDrop);
            this.comboFile.DragEnter += new System.Windows.Forms.DragEventHandler(this.comboFile_DragEnter);
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonBrowse.Location = new System.Drawing.Point(352, 3);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowse.TabIndex = 3;
            this.buttonBrowse.Text = "&Browse...";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // labelFile
            // 
            this.labelFile.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelFile.AutoSize = true;
            this.labelFile.Location = new System.Drawing.Point(3, 8);
            this.labelFile.Name = "labelFile";
            this.labelFile.Size = new System.Drawing.Size(23, 13);
            this.labelFile.TabIndex = 1;
            this.labelFile.Text = "&File";
            this.labelFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelBottom
            // 
            this.panelBottom.AutoSize = true;
            this.panelBottom.ColumnCount = 3;
            this.panelBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33389F));
            this.panelBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66611F));
            this.panelBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.panelBottom.Controls.Add(this.buttonDismiss, 2, 0);
            this.panelBottom.Controls.Add(this.pictureKey, 0, 0);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBottom.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.panelBottom.Location = new System.Drawing.Point(3, 385);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.RowCount = 1;
            this.panelBottom.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelBottom.Size = new System.Drawing.Size(430, 29);
            this.panelBottom.TabIndex = 3;
            // 
            // buttonDismiss
            // 
            this.buttonDismiss.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonDismiss.AutoSize = true;
            this.buttonDismiss.Location = new System.Drawing.Point(290, 3);
            this.buttonDismiss.Name = "buttonDismiss";
            this.buttonDismiss.Size = new System.Drawing.Size(137, 23);
            this.buttonDismiss.TabIndex = 14;
            this.buttonDismiss.Text = "OK";
            this.buttonDismiss.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonDismiss.UseVisualStyleBackColor = true;
            // 
            // pictureKey
            // 
            this.pictureKey.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureKey.Image = global::VerifyPKCS7.Properties.Resources.Goldkey;
            this.pictureKey.InitialImage = global::VerifyPKCS7.Properties.Resources.Goldkey;
            this.pictureKey.Location = new System.Drawing.Point(3, 3);
            this.pictureKey.Name = "pictureKey";
            this.pictureKey.Size = new System.Drawing.Size(89, 23);
            this.pictureKey.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureKey.TabIndex = 1;
            this.pictureKey.TabStop = false;
            // 
            // GroupSig
            // 
            this.GroupSig.AutoSize = true;
            this.GroupSig.Controls.Add(this.panelSig);
            this.GroupSig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupSig.Location = new System.Drawing.Point(3, 38);
            this.GroupSig.Name = "GroupSig";
            this.GroupSig.Size = new System.Drawing.Size(430, 85);
            this.GroupSig.TabIndex = 4;
            this.GroupSig.TabStop = false;
            this.GroupSig.Text = "&Signature";
            // 
            // panelSig
            // 
            this.panelSig.AutoSize = true;
            this.panelSig.ColumnCount = 3;
            this.panelSig.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.panelSig.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.panelSig.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelSig.Controls.Add(this.panelSigExt, 1, 0);
            this.panelSig.Controls.Add(this.panelSigFormat, 0, 1);
            this.panelSig.Controls.Add(this.checkDetached, 0, 0);
            this.panelSig.Controls.Add(this.SignatureFile, 2, 0);
            this.panelSig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSig.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.panelSig.Location = new System.Drawing.Point(3, 16);
            this.panelSig.Name = "panelSig";
            this.panelSig.RowCount = 2;
            this.panelSig.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelSig.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelSig.Size = new System.Drawing.Size(424, 66);
            this.panelSig.TabIndex = 0;
            // 
            // panelSigExt
            // 
            this.panelSigExt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSigExt.AutoSize = true;
            this.panelSigExt.ColumnCount = 2;
            this.panelSigExt.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelSigExt.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelSigExt.Controls.Add(this.labelSigExt, 0, 0);
            this.panelSigExt.Controls.Add(this.comboExt, 1, 0);
            this.panelSigExt.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.panelSigExt.Location = new System.Drawing.Point(97, 3);
            this.panelSigExt.Name = "panelSigExt";
            this.panelSigExt.RowCount = 1;
            this.panelSigExt.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelSigExt.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.panelSigExt.Size = new System.Drawing.Size(156, 27);
            this.panelSigExt.TabIndex = 1;
            // 
            // labelSigExt
            // 
            this.labelSigExt.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelSigExt.AutoSize = true;
            this.labelSigExt.Location = new System.Drawing.Point(3, 7);
            this.labelSigExt.Name = "labelSigExt";
            this.labelSigExt.Size = new System.Drawing.Size(72, 13);
            this.labelSigExt.TabIndex = 6;
            this.labelSigExt.Text = "File &Extension";
            this.labelSigExt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboExt
            // 
            this.comboExt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboExt.Location = new System.Drawing.Point(81, 3);
            this.comboExt.Name = "comboExt";
            this.comboExt.Size = new System.Drawing.Size(72, 21);
            this.comboExt.TabIndex = 7;
            this.comboExt.Text = "ext";
            this.comboExt.TextChanged += new System.EventHandler(this.comboExt_TextChanged);
            // 
            // panelSigFormat
            // 
            this.panelSigFormat.AutoSize = true;
            this.panelSigFormat.ColumnCount = 3;
            this.panelSig.SetColumnSpan(this.panelSigFormat, 3);
            this.panelSigFormat.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.panelSigFormat.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.panelSigFormat.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelSigFormat.Controls.Add(this.panelRadioSigFormat, 1, 0);
            this.panelSigFormat.Controls.Add(this.labelSigFormat, 0, 0);
            this.panelSigFormat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSigFormat.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.panelSigFormat.Location = new System.Drawing.Point(0, 33);
            this.panelSigFormat.Margin = new System.Windows.Forms.Padding(0);
            this.panelSigFormat.Name = "panelSigFormat";
            this.panelSigFormat.RowCount = 1;
            this.panelSigFormat.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelSigFormat.Size = new System.Drawing.Size(424, 33);
            this.panelSigFormat.TabIndex = 2;
            // 
            // panelRadioSigFormat
            // 
            this.panelRadioSigFormat.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.panelRadioSigFormat.AutoSize = true;
            this.panelRadioSigFormat.ColumnCount = 2;
            this.panelRadioSigFormat.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.panelRadioSigFormat.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.panelRadioSigFormat.Controls.Add(this.radioSigFormatDer, 0, 0);
            this.panelRadioSigFormat.Controls.Add(this.radioSigFormatBlah, 1, 0);
            this.panelRadioSigFormat.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.panelRadioSigFormat.Location = new System.Drawing.Point(45, 5);
            this.panelRadioSigFormat.Margin = new System.Windows.Forms.Padding(0);
            this.panelRadioSigFormat.Name = "panelRadioSigFormat";
            this.panelRadioSigFormat.RowCount = 1;
            this.panelRadioSigFormat.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelRadioSigFormat.Size = new System.Drawing.Size(106, 23);
            this.panelRadioSigFormat.TabIndex = 1;
            // 
            // radioSigFormatDer
            // 
            this.radioSigFormatDer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.radioSigFormatDer.AutoSize = true;
            this.radioSigFormatDer.Location = new System.Drawing.Point(3, 3);
            this.radioSigFormatDer.Name = "radioSigFormatDer";
            this.radioSigFormatDer.Size = new System.Drawing.Size(48, 17);
            this.radioSigFormatDer.TabIndex = 8;
            this.radioSigFormatDer.TabStop = true;
            this.radioSigFormatDer.Text = "&DER";
            this.radioSigFormatDer.UseVisualStyleBackColor = true;
            // 
            // radioSigFormatBlah
            // 
            this.radioSigFormatBlah.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.radioSigFormatBlah.AutoSize = true;
            this.radioSigFormatBlah.Location = new System.Drawing.Point(57, 3);
            this.radioSigFormatBlah.Name = "radioSigFormatBlah";
            this.radioSigFormatBlah.Size = new System.Drawing.Size(46, 17);
            this.radioSigFormatBlah.TabIndex = 9;
            this.radioSigFormatBlah.TabStop = true;
            this.radioSigFormatBlah.Text = "Blah";
            this.radioSigFormatBlah.UseVisualStyleBackColor = true;
            // 
            // labelSigFormat
            // 
            this.labelSigFormat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSigFormat.AutoSize = true;
            this.labelSigFormat.Location = new System.Drawing.Point(3, 10);
            this.labelSigFormat.Name = "labelSigFormat";
            this.labelSigFormat.Size = new System.Drawing.Size(39, 13);
            this.labelSigFormat.TabIndex = 0;
            this.labelSigFormat.Text = "Format";
            this.labelSigFormat.UseMnemonic = false;
            // 
            // checkDetached
            // 
            this.checkDetached.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.checkDetached.AutoSize = true;
            this.checkDetached.Checked = global::VerifyPKCS7.Properties.Settings.Default.detached;
            this.checkDetached.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkDetached.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::VerifyPKCS7.Properties.Settings.Default, "detached", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkDetached.Location = new System.Drawing.Point(3, 8);
            this.checkDetached.Name = "checkDetached";
            this.checkDetached.Size = new System.Drawing.Size(88, 17);
            this.checkDetached.TabIndex = 5;
            this.checkDetached.Text = "Separate File";
            this.checkDetached.UseVisualStyleBackColor = true;
            this.checkDetached.CheckedChanged += new System.EventHandler(this.checkDetached_CheckedChanged);
            // 
            // SignatureFile
            // 
            this.SignatureFile.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SignatureFile.AutoEllipsis = true;
            this.SignatureFile.AutoSize = true;
            this.SignatureFile.Location = new System.Drawing.Point(259, 10);
            this.SignatureFile.Name = "SignatureFile";
            this.SignatureFile.Size = new System.Drawing.Size(68, 13);
            this.SignatureFile.TabIndex = 3;
            this.SignatureFile.Text = "SignatureFile";
            this.SignatureFile.UseMnemonic = false;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // FormMain
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(436, 417);
            this.Controls.Add(this.panelMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Text = "Verify PKCS#7 Signature";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.comboFile_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.comboFile_DragEnter);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.panelFile.ResumeLayout(false);
            this.panelFile.PerformLayout();
            this.panelBottom.ResumeLayout(false);
            this.panelBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureKey)).EndInit();
            this.GroupSig.ResumeLayout(false);
            this.GroupSig.PerformLayout();
            this.panelSig.ResumeLayout(false);
            this.panelSig.PerformLayout();
            this.panelSigExt.ResumeLayout(false);
            this.panelSigExt.PerformLayout();
            this.panelSigFormat.ResumeLayout(false);
            this.panelSigFormat.PerformLayout();
            this.panelRadioSigFormat.ResumeLayout(false);
            this.panelRadioSigFormat.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel panelMain;
        private System.Windows.Forms.TableLayoutPanel panelFile;
        private System.Windows.Forms.Label labelFile;
        private System.Windows.Forms.ComboBox comboFile;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.TableLayoutPanel panelSigExt;
        private System.Windows.Forms.Label labelSigExt;
        private System.Windows.Forms.ComboBox comboExt;
        private System.Windows.Forms.TableLayoutPanel panelSigFormat;
        private System.Windows.Forms.Label labelSigFormat;
        private System.Windows.Forms.TableLayoutPanel panelRadioSigFormat;
        private System.Windows.Forms.RadioButton radioSigFormatDer;
        private System.Windows.Forms.RadioButton radioSigFormatBlah;
        private System.Windows.Forms.TableLayoutPanel panelBottom;
        private System.Windows.Forms.Button buttonDismiss;
        private System.Windows.Forms.PictureBox pictureKey;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.GroupBox GroupSig;
        private System.Windows.Forms.TableLayoutPanel panelSig;
        private System.Windows.Forms.CheckBox checkDetached;
        private System.Windows.Forms.Label SignatureFile;
        private System.Windows.Forms.RichTextBox result;
    }
}

