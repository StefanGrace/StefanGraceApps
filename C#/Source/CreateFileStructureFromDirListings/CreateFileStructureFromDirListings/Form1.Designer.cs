namespace CreateFileStructureFromDirListings
{
    partial class Form1
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
            this.textBox_dirListingPath = new System.Windows.Forms.TextBox();
            this.label_dirListingPath = new System.Windows.Forms.Label();
            this.button_Create = new System.Windows.Forms.Button();
            this.label_fsPath = new System.Windows.Forms.Label();
            this.textBox_fsPath = new System.Windows.Forms.TextBox();
            this.checkBox_includeFiles = new System.Windows.Forms.CheckBox();
            this.checkBox_addFileSizeToName = new System.Windows.Forms.CheckBox();
            this.radioButton_fileSizeBeforeName = new System.Windows.Forms.RadioButton();
            this.radioButton_fileSizeAfterName = new System.Windows.Forms.RadioButton();
            this.groupBox_fileSize = new System.Windows.Forms.GroupBox();
            this.label_sizeUnit = new System.Windows.Forms.Label();
            this.comboBox_sizeUnit = new System.Windows.Forms.ComboBox();
            this.comboBox_invalidCharReplacement = new System.Windows.Forms.ComboBox();
            this.label_invalidCharReplacement = new System.Windows.Forms.Label();
            this.button_about = new System.Windows.Forms.Button();
            this.label_loading = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.label_progressPercent = new System.Windows.Forms.Label();
            this.label_inputSizeUnit = new System.Windows.Forms.Label();
            this.comboBox_inputSizeUnit = new System.Windows.Forms.ComboBox();
            this.comboBox_inputTextEncoding = new System.Windows.Forms.ComboBox();
            this.label_inputEncoding = new System.Windows.Forms.Label();
            this.label_otherEncoding = new System.Windows.Forms.Label();
            this.button_changeEncoding = new System.Windows.Forms.Button();
            this.groupBox_fileSize.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_dirListingPath
            // 
            this.textBox_dirListingPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_dirListingPath.Location = new System.Drawing.Point(15, 25);
            this.textBox_dirListingPath.Name = "textBox_dirListingPath";
            this.textBox_dirListingPath.Size = new System.Drawing.Size(657, 20);
            this.textBox_dirListingPath.TabIndex = 0;
            // 
            // label_dirListingPath
            // 
            this.label_dirListingPath.AutoSize = true;
            this.label_dirListingPath.Location = new System.Drawing.Point(12, 9);
            this.label_dirListingPath.Name = "label_dirListingPath";
            this.label_dirListingPath.Size = new System.Drawing.Size(95, 13);
            this.label_dirListingPath.TabIndex = 1;
            this.label_dirListingPath.Text = "Path of dir listings: ";
            // 
            // button_Create
            // 
            this.button_Create.Location = new System.Drawing.Point(597, 226);
            this.button_Create.Name = "button_Create";
            this.button_Create.Size = new System.Drawing.Size(75, 23);
            this.button_Create.TabIndex = 9;
            this.button_Create.Text = "Create";
            this.button_Create.UseVisualStyleBackColor = true;
            this.button_Create.Click += new System.EventHandler(this.button_Create_Click);
            // 
            // label_fsPath
            // 
            this.label_fsPath.AutoSize = true;
            this.label_fsPath.Location = new System.Drawing.Point(12, 58);
            this.label_fsPath.Name = "label_fsPath";
            this.label_fsPath.Size = new System.Drawing.Size(137, 13);
            this.label_fsPath.TabIndex = 1;
            this.label_fsPath.Text = "Path of output file structure:";
            // 
            // textBox_fsPath
            // 
            this.textBox_fsPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_fsPath.Location = new System.Drawing.Point(15, 74);
            this.textBox_fsPath.Name = "textBox_fsPath";
            this.textBox_fsPath.Size = new System.Drawing.Size(657, 20);
            this.textBox_fsPath.TabIndex = 1;
            // 
            // checkBox_includeFiles
            // 
            this.checkBox_includeFiles.AutoSize = true;
            this.checkBox_includeFiles.Checked = true;
            this.checkBox_includeFiles.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_includeFiles.Location = new System.Drawing.Point(15, 114);
            this.checkBox_includeFiles.Name = "checkBox_includeFiles";
            this.checkBox_includeFiles.Size = new System.Drawing.Size(82, 17);
            this.checkBox_includeFiles.TabIndex = 2;
            this.checkBox_includeFiles.Text = "Include files";
            this.checkBox_includeFiles.UseVisualStyleBackColor = true;
            this.checkBox_includeFiles.CheckedChanged += new System.EventHandler(this.checkBox_includeFiles_CheckedChanged);
            // 
            // checkBox_addFileSizeToName
            // 
            this.checkBox_addFileSizeToName.AutoSize = true;
            this.checkBox_addFileSizeToName.Location = new System.Drawing.Point(6, 9);
            this.checkBox_addFileSizeToName.Name = "checkBox_addFileSizeToName";
            this.checkBox_addFileSizeToName.Size = new System.Drawing.Size(126, 17);
            this.checkBox_addFileSizeToName.TabIndex = 4;
            this.checkBox_addFileSizeToName.Text = "Add size to file name:";
            this.checkBox_addFileSizeToName.UseVisualStyleBackColor = true;
            this.checkBox_addFileSizeToName.CheckedChanged += new System.EventHandler(this.checkBox_addFileSizeToName_CheckedChanged);
            // 
            // radioButton_fileSizeBeforeName
            // 
            this.radioButton_fileSizeBeforeName.AutoSize = true;
            this.radioButton_fileSizeBeforeName.Enabled = false;
            this.radioButton_fileSizeBeforeName.Location = new System.Drawing.Point(6, 32);
            this.radioButton_fileSizeBeforeName.Name = "radioButton_fileSizeBeforeName";
            this.radioButton_fileSizeBeforeName.Size = new System.Drawing.Size(47, 17);
            this.radioButton_fileSizeBeforeName.TabIndex = 5;
            this.radioButton_fileSizeBeforeName.Text = "Start";
            this.radioButton_fileSizeBeforeName.UseVisualStyleBackColor = true;
            this.radioButton_fileSizeBeforeName.CheckedChanged += new System.EventHandler(this.radioButton_fileSizeBeforeName_CheckedChanged);
            // 
            // radioButton_fileSizeAfterName
            // 
            this.radioButton_fileSizeAfterName.AutoSize = true;
            this.radioButton_fileSizeAfterName.Checked = true;
            this.radioButton_fileSizeAfterName.Enabled = false;
            this.radioButton_fileSizeAfterName.Location = new System.Drawing.Point(6, 55);
            this.radioButton_fileSizeAfterName.Name = "radioButton_fileSizeAfterName";
            this.radioButton_fileSizeAfterName.Size = new System.Drawing.Size(44, 17);
            this.radioButton_fileSizeAfterName.TabIndex = 5;
            this.radioButton_fileSizeAfterName.TabStop = true;
            this.radioButton_fileSizeAfterName.Text = "End";
            this.radioButton_fileSizeAfterName.UseVisualStyleBackColor = true;
            this.radioButton_fileSizeAfterName.CheckedChanged += new System.EventHandler(this.radioButton_fileSizeAfterName_CheckedChanged);
            // 
            // groupBox_fileSize
            // 
            this.groupBox_fileSize.Controls.Add(this.checkBox_addFileSizeToName);
            this.groupBox_fileSize.Controls.Add(this.label_sizeUnit);
            this.groupBox_fileSize.Controls.Add(this.radioButton_fileSizeBeforeName);
            this.groupBox_fileSize.Controls.Add(this.radioButton_fileSizeAfterName);
            this.groupBox_fileSize.Controls.Add(this.comboBox_sizeUnit);
            this.groupBox_fileSize.Location = new System.Drawing.Point(103, 100);
            this.groupBox_fileSize.Name = "groupBox_fileSize";
            this.groupBox_fileSize.Size = new System.Drawing.Size(146, 136);
            this.groupBox_fileSize.TabIndex = 6;
            this.groupBox_fileSize.TabStop = false;
            // 
            // label_sizeUnit
            // 
            this.label_sizeUnit.AutoSize = true;
            this.label_sizeUnit.Enabled = false;
            this.label_sizeUnit.Location = new System.Drawing.Point(6, 84);
            this.label_sizeUnit.Name = "label_sizeUnit";
            this.label_sizeUnit.Size = new System.Drawing.Size(50, 13);
            this.label_sizeUnit.TabIndex = 9;
            this.label_sizeUnit.Text = "Size unit:";
            // 
            // comboBox_sizeUnit
            // 
            this.comboBox_sizeUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_sizeUnit.Enabled = false;
            this.comboBox_sizeUnit.FormattingEnabled = true;
            this.comboBox_sizeUnit.Items.AddRange(new object[] {
            "bytes",
            "kB",
            "KiB"});
            this.comboBox_sizeUnit.Location = new System.Drawing.Point(5, 103);
            this.comboBox_sizeUnit.Name = "comboBox_sizeUnit";
            this.comboBox_sizeUnit.Size = new System.Drawing.Size(98, 21);
            this.comboBox_sizeUnit.TabIndex = 8;
            this.comboBox_sizeUnit.SelectedIndexChanged += new System.EventHandler(this.comboBox_sizeUnit_SelectedIndexChanged);
            // 
            // comboBox_invalidCharReplacement
            // 
            this.comboBox_invalidCharReplacement.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_invalidCharReplacement.FormattingEnabled = true;
            this.comboBox_invalidCharReplacement.Items.AddRange(new object[] {
            "#",
            "!",
            "$",
            "~",
            "_"});
            this.comboBox_invalidCharReplacement.Location = new System.Drawing.Point(258, 134);
            this.comboBox_invalidCharReplacement.Name = "comboBox_invalidCharReplacement";
            this.comboBox_invalidCharReplacement.Size = new System.Drawing.Size(98, 21);
            this.comboBox_invalidCharReplacement.TabIndex = 8;
            this.comboBox_invalidCharReplacement.SelectedIndexChanged += new System.EventHandler(this.comboBox_invalidCharReplacement_SelectedIndexChanged);
            // 
            // label_invalidCharReplacement
            // 
            this.label_invalidCharReplacement.AutoSize = true;
            this.label_invalidCharReplacement.Location = new System.Drawing.Point(255, 105);
            this.label_invalidCharReplacement.Name = "label_invalidCharReplacement";
            this.label_invalidCharReplacement.Size = new System.Drawing.Size(82, 26);
            this.label_invalidCharReplacement.TabIndex = 9;
            this.label_invalidCharReplacement.Text = "Replace invalid\r\ncharacters with:";
            // 
            // button_about
            // 
            this.button_about.Location = new System.Drawing.Point(516, 226);
            this.button_about.Name = "button_about";
            this.button_about.Size = new System.Drawing.Size(75, 23);
            this.button_about.TabIndex = 10;
            this.button_about.Text = "About...";
            this.button_about.UseVisualStyleBackColor = true;
            this.button_about.Click += new System.EventHandler(this.button_about_Click);
            // 
            // label_loading
            // 
            this.label_loading.AutoSize = true;
            this.label_loading.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_loading.Location = new System.Drawing.Point(255, 204);
            this.label_loading.Name = "label_loading";
            this.label_loading.Size = new System.Drawing.Size(246, 15);
            this.label_loading.TabIndex = 11;
            this.label_loading.Text = "Creating file structure... please wait...";
            this.label_loading.Visible = false;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(258, 226);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(211, 23);
            this.progressBar.TabIndex = 12;
            this.progressBar.Visible = false;
            // 
            // label_progressPercent
            // 
            this.label_progressPercent.AutoSize = true;
            this.label_progressPercent.Location = new System.Drawing.Point(475, 231);
            this.label_progressPercent.Name = "label_progressPercent";
            this.label_progressPercent.Size = new System.Drawing.Size(21, 13);
            this.label_progressPercent.TabIndex = 13;
            this.label_progressPercent.Text = "0%";
            this.label_progressPercent.Visible = false;
            // 
            // label_inputSizeUnit
            // 
            this.label_inputSizeUnit.AutoSize = true;
            this.label_inputSizeUnit.Location = new System.Drawing.Point(513, 105);
            this.label_inputSizeUnit.Name = "label_inputSizeUnit";
            this.label_inputSizeUnit.Size = new System.Drawing.Size(141, 13);
            this.label_inputSizeUnit.TabIndex = 14;
            this.label_inputSizeUnit.Text = "Input dir listing size unti type:";
            // 
            // comboBox_inputSizeUnit
            // 
            this.comboBox_inputSizeUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_inputSizeUnit.FormattingEnabled = true;
            this.comboBox_inputSizeUnit.Items.AddRange(new object[] {
            "Decimal (1 KB = 1000 B)",
            "Binary (1 KB = 1024 B)"});
            this.comboBox_inputSizeUnit.Location = new System.Drawing.Point(516, 121);
            this.comboBox_inputSizeUnit.Name = "comboBox_inputSizeUnit";
            this.comboBox_inputSizeUnit.Size = new System.Drawing.Size(156, 21);
            this.comboBox_inputSizeUnit.TabIndex = 8;
            this.comboBox_inputSizeUnit.SelectedIndexChanged += new System.EventHandler(this.comboBox_inputSizeUnit_SelectedIndexChanged);
            // 
            // comboBox_inputTextEncoding
            // 
            this.comboBox_inputTextEncoding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_inputTextEncoding.FormattingEnabled = true;
            this.comboBox_inputTextEncoding.Items.AddRange(new object[] {
            "ASCII",
            "ANSI",
            "Windows-1252",
            "UTF-8",
            "UTF-16 LE",
            "UTF-16 BE",
            "UTF-32 LE",
            "UTF-32 BE",
            "Other..."});
            this.comboBox_inputTextEncoding.Location = new System.Drawing.Point(516, 161);
            this.comboBox_inputTextEncoding.Name = "comboBox_inputTextEncoding";
            this.comboBox_inputTextEncoding.Size = new System.Drawing.Size(156, 21);
            this.comboBox_inputTextEncoding.TabIndex = 8;
            this.comboBox_inputTextEncoding.SelectedIndexChanged += new System.EventHandler(this.comboBox_inputTextEncoding_SelectedIndexChanged);
            // 
            // label_inputEncoding
            // 
            this.label_inputEncoding.AutoSize = true;
            this.label_inputEncoding.Location = new System.Drawing.Point(513, 145);
            this.label_inputEncoding.Name = "label_inputEncoding";
            this.label_inputEncoding.Size = new System.Drawing.Size(144, 13);
            this.label_inputEncoding.TabIndex = 14;
            this.label_inputEncoding.Text = "Input dir listing text encoding:";
            // 
            // label_otherEncoding
            // 
            this.label_otherEncoding.AutoSize = true;
            this.label_otherEncoding.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_otherEncoding.Location = new System.Drawing.Point(516, 189);
            this.label_otherEncoding.Name = "label_otherEncoding";
            this.label_otherEncoding.Size = new System.Drawing.Size(94, 13);
            this.label_otherEncoding.TabIndex = 15;
            this.label_otherEncoding.Text = "Other encoding";
            // 
            // button_changeEncoding
            // 
            this.button_changeEncoding.Location = new System.Drawing.Point(435, 160);
            this.button_changeEncoding.Name = "button_changeEncoding";
            this.button_changeEncoding.Size = new System.Drawing.Size(75, 23);
            this.button_changeEncoding.TabIndex = 16;
            this.button_changeEncoding.Text = "Change...";
            this.button_changeEncoding.UseVisualStyleBackColor = true;
            this.button_changeEncoding.Visible = false;
            this.button_changeEncoding.Click += new System.EventHandler(this.button_changeEncoding_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.button_Create;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 261);
            this.Controls.Add(this.button_changeEncoding);
            this.Controls.Add(this.label_otherEncoding);
            this.Controls.Add(this.label_inputEncoding);
            this.Controls.Add(this.label_inputSizeUnit);
            this.Controls.Add(this.label_progressPercent);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.label_loading);
            this.Controls.Add(this.button_about);
            this.Controls.Add(this.label_invalidCharReplacement);
            this.Controls.Add(this.comboBox_inputTextEncoding);
            this.Controls.Add(this.comboBox_inputSizeUnit);
            this.Controls.Add(this.comboBox_invalidCharReplacement);
            this.Controls.Add(this.groupBox_fileSize);
            this.Controls.Add(this.checkBox_includeFiles);
            this.Controls.Add(this.button_Create);
            this.Controls.Add(this.label_fsPath);
            this.Controls.Add(this.label_dirListingPath);
            this.Controls.Add(this.textBox_fsPath);
            this.Controls.Add(this.textBox_dirListingPath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File Structure Creator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox_fileSize.ResumeLayout(false);
            this.groupBox_fileSize.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_dirListingPath;
        private System.Windows.Forms.Label label_dirListingPath;
        private System.Windows.Forms.Button button_Create;
        private System.Windows.Forms.Label label_fsPath;
        private System.Windows.Forms.TextBox textBox_fsPath;
        private System.Windows.Forms.CheckBox checkBox_includeFiles;
        private System.Windows.Forms.CheckBox checkBox_addFileSizeToName;
        private System.Windows.Forms.RadioButton radioButton_fileSizeBeforeName;
        private System.Windows.Forms.RadioButton radioButton_fileSizeAfterName;
        private System.Windows.Forms.GroupBox groupBox_fileSize;
        private System.Windows.Forms.ComboBox comboBox_sizeUnit;
        private System.Windows.Forms.Label label_sizeUnit;
        private System.Windows.Forms.ComboBox comboBox_invalidCharReplacement;
        private System.Windows.Forms.Label label_invalidCharReplacement;
        private System.Windows.Forms.Button button_about;
        private System.Windows.Forms.Label label_loading;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label label_progressPercent;
        private System.Windows.Forms.Label label_inputSizeUnit;
        private System.Windows.Forms.ComboBox comboBox_inputSizeUnit;
        private System.Windows.Forms.ComboBox comboBox_inputTextEncoding;
        private System.Windows.Forms.Label label_inputEncoding;
        private System.Windows.Forms.Label label_otherEncoding;
        private System.Windows.Forms.Button button_changeEncoding;
    }
}

