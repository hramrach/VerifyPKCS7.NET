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
            this.panelFile = new System.Windows.Forms.TableLayoutPanel();
            this.labelFile = new System.Windows.Forms.Label();
            this.comboFile = new System.Windows.Forms.ComboBox();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.panelBottom = new System.Windows.Forms.TableLayoutPanel();
            this.buttonDismiss = new System.Windows.Forms.Button();
            this.panelScroll = new System.Windows.Forms.Panel();
            this.result = new System.Windows.Forms.Label();
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
            this.pictureKey = new System.Windows.Forms.PictureBox();
            this.panelMain.SuspendLayout();
            this.panelFile.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.panelScroll.SuspendLayout();
            this.GroupSig.SuspendLayout();
            this.panelSig.SuspendLayout();
            this.panelSigExt.SuspendLayout();
            this.panelSigFormat.SuspendLayout();
            this.panelRadioSigFormat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureKey)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMain.ColumnCount = 1;
            this.panelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelMain.Controls.Add(this.panelFile, 0, 0);
            this.panelMain.Controls.Add(this.panelBottom, 0, 4);
            this.panelMain.Controls.Add(this.panelScroll, 0, 3);
            this.panelMain.Controls.Add(this.GroupSig, 0, 2);
            this.panelMain.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.RowCount = 5;
            this.panelMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.panelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panelMain.Size = new System.Drawing.Size(436, 417);
            this.panelMain.TabIndex = 0;
            // 
            // panelFile
            // 
            this.panelFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panelFile.AutoSize = true;
            this.panelFile.ColumnCount = 3;
            this.panelFile.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.panelFile.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelFile.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.panelFile.Controls.Add(this.labelFile, 0, 0);
            this.panelFile.Controls.Add(this.comboFile, 1, 0);
            this.panelFile.Controls.Add(this.buttonBrowse, 2, 0);
            this.panelFile.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.panelFile.Location = new System.Drawing.Point(3, 3);
            this.panelFile.Name = "panelFile";
            this.panelFile.RowCount = 1;
            this.panelFile.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelFile.Size = new System.Drawing.Size(430, 29);
            this.panelFile.TabIndex = 0;
            // 
            // labelFile
            // 
            this.labelFile.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelFile.AutoSize = true;
            this.labelFile.Location = new System.Drawing.Point(3, 8);
            this.labelFile.Name = "labelFile";
            this.labelFile.Size = new System.Drawing.Size(23, 13);
            this.labelFile.TabIndex = 0;
            this.labelFile.Text = "File";
            this.labelFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboFile
            // 
            this.comboFile.AllowDrop = true;
            this.comboFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboFile.FormattingEnabled = true;
            this.comboFile.Location = new System.Drawing.Point(32, 4);
            this.comboFile.Name = "comboFile";
            this.comboFile.Size = new System.Drawing.Size(314, 21);
            this.comboFile.TabIndex = 1;
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonBrowse.Location = new System.Drawing.Point(352, 3);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowse.TabIndex = 2;
            this.buttonBrowse.Text = "Browse...";
            this.buttonBrowse.UseVisualStyleBackColor = true;
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
            this.buttonDismiss.TabIndex = 0;
            this.buttonDismiss.Text = "OK";
            this.buttonDismiss.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonDismiss.UseVisualStyleBackColor = true;
            // 
            // panelScroll
            // 
            this.panelScroll.AutoScroll = true;
            this.panelScroll.Controls.Add(this.result);
            this.panelScroll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelScroll.Location = new System.Drawing.Point(3, 138);
            this.panelScroll.Name = "panelScroll";
            this.panelScroll.Size = new System.Drawing.Size(430, 241);
            this.panelScroll.TabIndex = 4;
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.CausesValidation = false;
            this.result.Location = new System.Drawing.Point(3, 3);
            this.result.Margin = new System.Windows.Forms.Padding(3);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(682, 403);
            this.result.TabIndex = 128;
            this.result.Text = resources.GetString("result.Text");
            // 
            // GroupSig
            // 
            this.GroupSig.AutoSize = true;
            this.GroupSig.Controls.Add(this.panelSig);
            this.GroupSig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupSig.Location = new System.Drawing.Point(3, 38);
            this.GroupSig.Name = "GroupSig";
            this.GroupSig.Size = new System.Drawing.Size(430, 94);
            this.GroupSig.TabIndex = 5;
            this.GroupSig.TabStop = false;
            this.GroupSig.Text = "Signature";
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
            this.panelSig.Size = new System.Drawing.Size(424, 75);
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
            this.panelSigExt.Location = new System.Drawing.Point(97, 5);
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
            this.labelSigExt.TabIndex = 0;
            this.labelSigExt.Text = "File Extension";
            this.labelSigExt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboExt
            // 
            this.comboExt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboExt.AutoCompleteCustomSource.AddRange(new string[] {
            "ep1",
            "ep2",
            "sig"});
            this.comboExt.FormattingEnabled = true;
            this.comboExt.Location = new System.Drawing.Point(81, 3);
            this.comboExt.Name = "comboExt";
            this.comboExt.Size = new System.Drawing.Size(72, 21);
            this.comboExt.TabIndex = 1;
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
            this.panelSigFormat.Location = new System.Drawing.Point(0, 37);
            this.panelSigFormat.Margin = new System.Windows.Forms.Padding(0);
            this.panelSigFormat.Name = "panelSigFormat";
            this.panelSigFormat.RowCount = 1;
            this.panelSigFormat.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelSigFormat.Size = new System.Drawing.Size(424, 38);
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
            this.panelRadioSigFormat.Location = new System.Drawing.Point(45, 7);
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
            this.radioSigFormatDer.TabIndex = 0;
            this.radioSigFormatDer.TabStop = true;
            this.radioSigFormatDer.Text = "DER";
            this.radioSigFormatDer.UseVisualStyleBackColor = true;
            // 
            // radioSigFormatBlah
            // 
            this.radioSigFormatBlah.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.radioSigFormatBlah.AutoSize = true;
            this.radioSigFormatBlah.Location = new System.Drawing.Point(57, 3);
            this.radioSigFormatBlah.Name = "radioSigFormatBlah";
            this.radioSigFormatBlah.Size = new System.Drawing.Size(46, 17);
            this.radioSigFormatBlah.TabIndex = 1;
            this.radioSigFormatBlah.TabStop = true;
            this.radioSigFormatBlah.Text = "Blah";
            this.radioSigFormatBlah.UseVisualStyleBackColor = true;
            // 
            // labelSigFormat
            // 
            this.labelSigFormat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSigFormat.AutoSize = true;
            this.labelSigFormat.Location = new System.Drawing.Point(3, 12);
            this.labelSigFormat.Name = "labelSigFormat";
            this.labelSigFormat.Size = new System.Drawing.Size(39, 13);
            this.labelSigFormat.TabIndex = 0;
            this.labelSigFormat.Text = "Format";
            // 
            // checkDetached
            // 
            this.checkDetached.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.checkDetached.AutoSize = true;
            this.checkDetached.Location = new System.Drawing.Point(3, 10);
            this.checkDetached.Name = "checkDetached";
            this.checkDetached.Size = new System.Drawing.Size(88, 17);
            this.checkDetached.TabIndex = 2;
            this.checkDetached.Text = "Separate File";
            this.checkDetached.UseVisualStyleBackColor = true;
            // 
            // SignatureFile
            // 
            this.SignatureFile.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SignatureFile.AutoEllipsis = true;
            this.SignatureFile.AutoSize = true;
            this.SignatureFile.Location = new System.Drawing.Point(259, 12);
            this.SignatureFile.Name = "SignatureFile";
            this.SignatureFile.Size = new System.Drawing.Size(68, 13);
            this.SignatureFile.TabIndex = 3;
            this.SignatureFile.Text = "SignatureFile";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // pictureKey
            // 
            this.pictureKey.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureKey.Image = global::VerifyPKCS7.Properties.Resources.Goldkey;
            this.pictureKey.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureKey.InitialImage")));
            this.pictureKey.Location = new System.Drawing.Point(3, 3);
            this.pictureKey.Name = "pictureKey";
            this.pictureKey.Size = new System.Drawing.Size(89, 23);
            this.pictureKey.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureKey.TabIndex = 1;
            this.pictureKey.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(436, 417);
            this.Controls.Add(this.panelMain);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.panelFile.ResumeLayout(false);
            this.panelFile.PerformLayout();
            this.panelBottom.ResumeLayout(false);
            this.panelBottom.PerformLayout();
            this.panelScroll.ResumeLayout(false);
            this.panelScroll.PerformLayout();
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureKey)).EndInit();
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
        private System.Windows.Forms.Panel panelScroll;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.GroupBox GroupSig;
        private System.Windows.Forms.TableLayoutPanel panelSig;
        private System.Windows.Forms.CheckBox checkDetached;
        private System.Windows.Forms.Label SignatureFile;
    }
}

