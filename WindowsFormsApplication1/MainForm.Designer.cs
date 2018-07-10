namespace WindowsFormsApplication1
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.BgWorker = new System.ComponentModel.BackgroundWorker();
            this.StartButton = new System.Windows.Forms.Button();
            this.FolderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.FilenameLabel = new System.Windows.Forms.Label();
            this.InputEncodingDropdown = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.FileTypeTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.OutputEncodingDropdown = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ScanSubfolderCheckbox = new System.Windows.Forms.CheckBox();
            this.saveOutputDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LanguageCodesLinkLabel = new System.Windows.Forms.LinkLabel();
            this.MaxRetriesPerRequestTextbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.DurationLengthTextbox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.MaxCharsPerRequestTextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.OutputTextLanguageBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.InputTextLanguageBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.openPrivateKeyDialog = new System.Windows.Forms.OpenFileDialog();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BgWorker
            // 
            this.BgWorker.WorkerSupportsCancellation = true;
            this.BgWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BgWorkerClean_DoWork);
            this.BgWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BgWorker_RunWorkerCompleted);
            // 
            // StartButton
            // 
            this.StartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartButton.Location = new System.Drawing.Point(497, 303);
            this.StartButton.Margin = new System.Windows.Forms.Padding(4);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(203, 39);
            this.StartButton.TabIndex = 3;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // FolderBrowser
            // 
            this.FolderBrowser.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.FolderBrowser.ShowNewFolderButton = false;
            // 
            // FilenameLabel
            // 
            this.FilenameLabel.AutoEllipsis = true;
            this.FilenameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FilenameLabel.Location = new System.Drawing.Point(13, 412);
            this.FilenameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FilenameLabel.Name = "FilenameLabel";
            this.FilenameLabel.Size = new System.Drawing.Size(756, 27);
            this.FilenameLabel.TabIndex = 6;
            this.FilenameLabel.Text = "Waiting to process texts...";
            this.FilenameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // InputEncodingDropdown
            // 
            this.InputEncodingDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.InputEncodingDropdown.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputEncodingDropdown.FormattingEnabled = true;
            this.InputEncodingDropdown.Location = new System.Drawing.Point(8, 65);
            this.InputEncodingDropdown.Margin = new System.Windows.Forms.Padding(4);
            this.InputEncodingDropdown.Name = "InputEncodingDropdown";
            this.InputEncodingDropdown.Size = new System.Drawing.Size(329, 27);
            this.InputEncodingDropdown.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 43);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "Input File Encoding:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.FileTypeTextbox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.OutputEncodingDropdown);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.InputEncodingDropdown);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(422, 13);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(347, 257);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Encoding Selection";
            // 
            // FileTypeTextbox
            // 
            this.FileTypeTextbox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileTypeTextbox.Location = new System.Drawing.Point(125, 191);
            this.FileTypeTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.FileTypeTextbox.Name = "FileTypeTextbox";
            this.FileTypeTextbox.Size = new System.Drawing.Size(132, 31);
            this.FileTypeTextbox.TabIndex = 16;
            this.FileTypeTextbox.Text = "*.txt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 197);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 18);
            this.label2.TabIndex = 15;
            this.label2.Text = "Input File Type:";
            // 
            // OutputEncodingDropdown
            // 
            this.OutputEncodingDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OutputEncodingDropdown.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputEncodingDropdown.FormattingEnabled = true;
            this.OutputEncodingDropdown.Location = new System.Drawing.Point(7, 133);
            this.OutputEncodingDropdown.Margin = new System.Windows.Forms.Padding(4);
            this.OutputEncodingDropdown.Name = "OutputEncodingDropdown";
            this.OutputEncodingDropdown.Size = new System.Drawing.Size(329, 27);
            this.OutputEncodingDropdown.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 111);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "Output File Encoding:";
            // 
            // ScanSubfolderCheckbox
            // 
            this.ScanSubfolderCheckbox.AutoSize = true;
            this.ScanSubfolderCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScanSubfolderCheckbox.Location = new System.Drawing.Point(519, 354);
            this.ScanSubfolderCheckbox.Margin = new System.Windows.Forms.Padding(4);
            this.ScanSubfolderCheckbox.Name = "ScanSubfolderCheckbox";
            this.ScanSubfolderCheckbox.Size = new System.Drawing.Size(154, 24);
            this.ScanSubfolderCheckbox.TabIndex = 13;
            this.ScanSubfolderCheckbox.Text = "Scan Subfolders";
            this.ScanSubfolderCheckbox.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LanguageCodesLinkLabel);
            this.groupBox1.Controls.Add(this.MaxRetriesPerRequestTextbox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.DurationLengthTextbox);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.MaxCharsPerRequestTextbox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.OutputTextLanguageBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.InputTextLanguageBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(23, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(374, 386);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Translation Options";
            // 
            // LanguageCodesLinkLabel
            // 
            this.LanguageCodesLinkLabel.AutoSize = true;
            this.LanguageCodesLinkLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LanguageCodesLinkLabel.LinkArea = new System.Windows.Forms.LinkArea(0, 99);
            this.LanguageCodesLinkLabel.Location = new System.Drawing.Point(64, 184);
            this.LanguageCodesLinkLabel.Name = "LanguageCodesLinkLabel";
            this.LanguageCodesLinkLabel.Size = new System.Drawing.Size(241, 24);
            this.LanguageCodesLinkLabel.TabIndex = 24;
            this.LanguageCodesLinkLabel.TabStop = true;
            this.LanguageCodesLinkLabel.Text = "List of Google Language Codes";
            this.LanguageCodesLinkLabel.UseCompatibleTextRendering = true;
            this.LanguageCodesLinkLabel.Click += new System.EventHandler(this.LanguageCodesLinkLabel_Click);
            // 
            // MaxRetriesPerRequestTextbox
            // 
            this.MaxRetriesPerRequestTextbox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaxRetriesPerRequestTextbox.Location = new System.Drawing.Point(273, 336);
            this.MaxRetriesPerRequestTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.MaxRetriesPerRequestTextbox.Name = "MaxRetriesPerRequestTextbox";
            this.MaxRetriesPerRequestTextbox.Size = new System.Drawing.Size(93, 31);
            this.MaxRetriesPerRequestTextbox.TabIndex = 23;
            this.MaxRetriesPerRequestTextbox.Text = "5";
            this.MaxRetriesPerRequestTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.MaxRetriesPerRequestTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 342);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(177, 18);
            this.label7.TabIndex = 22;
            this.label7.Text = "Max Retries Per Request:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(5, 225);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(322, 18);
            this.label9.TabIndex = 21;
            this.label9.Text = "Request Parameters (Defaults Recommended):";
            // 
            // DurationLengthTextbox
            // 
            this.DurationLengthTextbox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DurationLengthTextbox.Location = new System.Drawing.Point(273, 258);
            this.DurationLengthTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.DurationLengthTextbox.Name = "DurationLengthTextbox";
            this.DurationLengthTextbox.Size = new System.Drawing.Size(93, 31);
            this.DurationLengthTextbox.TabIndex = 20;
            this.DurationLengthTextbox.Text = "100";
            this.DurationLengthTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.DurationLengthTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(8, 264);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(227, 18);
            this.label8.TabIndex = 19;
            this.label8.Text = "Rate Limit Sleep Time (seconds):";
            // 
            // MaxCharsPerRequestTextbox
            // 
            this.MaxCharsPerRequestTextbox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaxCharsPerRequestTextbox.Location = new System.Drawing.Point(273, 297);
            this.MaxCharsPerRequestTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.MaxCharsPerRequestTextbox.Name = "MaxCharsPerRequestTextbox";
            this.MaxCharsPerRequestTextbox.Size = new System.Drawing.Size(93, 31);
            this.MaxCharsPerRequestTextbox.TabIndex = 16;
            this.MaxCharsPerRequestTextbox.Text = "5000";
            this.MaxCharsPerRequestTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.MaxCharsPerRequestTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 303);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 18);
            this.label3.TabIndex = 15;
            this.label3.Text = "Max Characters Per Request:";
            // 
            // OutputTextLanguageBox
            // 
            this.OutputTextLanguageBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OutputTextLanguageBox.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputTextLanguageBox.FormattingEnabled = true;
            this.OutputTextLanguageBox.Location = new System.Drawing.Point(9, 133);
            this.OutputTextLanguageBox.Margin = new System.Windows.Forms.Padding(4);
            this.OutputTextLanguageBox.Name = "OutputTextLanguageBox";
            this.OutputTextLanguageBox.Size = new System.Drawing.Size(358, 27);
            this.OutputTextLanguageBox.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 111);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "Output Text Language:";
            // 
            // InputTextLanguageBox
            // 
            this.InputTextLanguageBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.InputTextLanguageBox.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputTextLanguageBox.FormattingEnabled = true;
            this.InputTextLanguageBox.Location = new System.Drawing.Point(9, 65);
            this.InputTextLanguageBox.Margin = new System.Windows.Forms.Padding(4);
            this.InputTextLanguageBox.Name = "InputTextLanguageBox";
            this.InputTextLanguageBox.Size = new System.Drawing.Size(358, 27);
            this.InputTextLanguageBox.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(5, 43);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "Input Text Language:";
            // 
            // openPrivateKeyDialog
            // 
            this.openPrivateKeyDialog.FileName = "GoogleTranslatePrivateKey.json";
            this.openPrivateKeyDialog.Filter = "JSON Key|*.json";
            this.openPrivateKeyDialog.ShowReadOnly = true;
            this.openPrivateKeyDialog.Title = "Please locate your Google Translate API Private Key File";
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoEllipsis = true;
            this.StatusLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StatusLabel.Location = new System.Drawing.Point(13, 444);
            this.StatusLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(756, 27);
            this.StatusLabel.TabIndex = 21;
            this.StatusLabel.Text = "Status: Nothing to report.";
            this.StatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(782, 478);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.FilenameLabel);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.ScanSubfolderCheckbox);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 525);
            this.MinimumSize = new System.Drawing.Size(800, 525);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transmogrifier";
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker BgWorker;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.FolderBrowserDialog FolderBrowser;
        private System.Windows.Forms.Label FilenameLabel;
        private System.Windows.Forms.ComboBox InputEncodingDropdown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.FolderBrowserDialog saveOutputDialog;
        private System.Windows.Forms.ComboBox OutputEncodingDropdown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ScanSubfolderCheckbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FileTypeTextbox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox MaxCharsPerRequestTextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox OutputTextLanguageBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox InputTextLanguageBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.OpenFileDialog openPrivateKeyDialog;
        private System.Windows.Forms.TextBox DurationLengthTextbox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox MaxRetriesPerRequestTextbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.LinkLabel LanguageCodesLinkLabel;
        private System.Windows.Forms.Label StatusLabel;
    }
}

