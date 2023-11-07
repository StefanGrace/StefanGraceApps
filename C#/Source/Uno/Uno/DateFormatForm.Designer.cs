namespace Uno
{
    partial class DateFormatForm
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
            this.components = new System.ComponentModel.Container();
            this.systemRadioButton = new System.Windows.Forms.RadioButton();
            this.DateTimeLabel = new System.Windows.Forms.Label();
            this.customRadioButton = new System.Windows.Forms.RadioButton();
            this.dateOrderGroupBox = new System.Windows.Forms.GroupBox();
            this.dmyRadioButton = new System.Windows.Forms.RadioButton();
            this.mdyRadioButton = new System.Windows.Forms.RadioButton();
            this.ymdRadioButton = new System.Windows.Forms.RadioButton();
            this.CostomGroupBox = new System.Windows.Forms.GroupBox();
            this.showGroupBox = new System.Windows.Forms.GroupBox();
            this.showTimeCheckBox = new System.Windows.Forms.CheckBox();
            this.showSecondsCheckBox = new System.Windows.Forms.CheckBox();
            this.showYearCheckBox = new System.Windows.Forms.CheckBox();
            this.timeFormatGroupBox = new System.Windows.Forms.GroupBox();
            this._24hourRadioButton = new System.Windows.Forms.RadioButton();
            this._12hourRadioButton = new System.Windows.Forms.RadioButton();
            this.yearFormatGroupBox = new System.Windows.Forms.GroupBox();
            this.fourDigitRadioButton = new System.Windows.Forms.RadioButton();
            this.twoDigitRadioButton = new System.Windows.Forms.RadioButton();
            this.monthFormatGroupBox = new System.Windows.Forms.GroupBox();
            this.monthWordRadioButton = new System.Windows.Forms.RadioButton();
            this.monthNumberRadioButton = new System.Windows.Forms.RadioButton();
            this.dateTimeOrderGroupBox = new System.Windows.Forms.GroupBox();
            this.tdRadioButton = new System.Windows.Forms.RadioButton();
            this.dtRadioButton = new System.Windows.Forms.RadioButton();
            this.dateSeperatorGroupBox = new System.Windows.Forms.GroupBox();
            this.dotRadioButton = new System.Windows.Forms.RadioButton();
            this.slashRadioButton = new System.Windows.Forms.RadioButton();
            this.hyphenRadioButton = new System.Windows.Forms.RadioButton();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dateOrderGroupBox.SuspendLayout();
            this.CostomGroupBox.SuspendLayout();
            this.showGroupBox.SuspendLayout();
            this.timeFormatGroupBox.SuspendLayout();
            this.yearFormatGroupBox.SuspendLayout();
            this.monthFormatGroupBox.SuspendLayout();
            this.dateTimeOrderGroupBox.SuspendLayout();
            this.dateSeperatorGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // systemRadioButton
            // 
            this.systemRadioButton.AutoSize = true;
            this.systemRadioButton.Checked = true;
            this.systemRadioButton.Location = new System.Drawing.Point(12, 12);
            this.systemRadioButton.Name = "systemRadioButton";
            this.systemRadioButton.Size = new System.Drawing.Size(59, 17);
            this.systemRadioButton.TabIndex = 0;
            this.systemRadioButton.TabStop = true;
            this.systemRadioButton.Text = "System";
            this.systemRadioButton.UseVisualStyleBackColor = true;
            this.systemRadioButton.CheckedChanged += new System.EventHandler(this.systemRadioButton_CheckedChanged);
            // 
            // DateTimeLabel
            // 
            this.DateTimeLabel.AutoSize = true;
            this.DateTimeLabel.Location = new System.Drawing.Point(145, 12);
            this.DateTimeLabel.Name = "DateTimeLabel";
            this.DateTimeLabel.Size = new System.Drawing.Size(48, 13);
            this.DateTimeLabel.TabIndex = 1;
            this.DateTimeLabel.Text = "Sample: ";
            this.DateTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // customRadioButton
            // 
            this.customRadioButton.AutoSize = true;
            this.customRadioButton.Location = new System.Drawing.Point(12, 36);
            this.customRadioButton.Name = "customRadioButton";
            this.customRadioButton.Size = new System.Drawing.Size(60, 17);
            this.customRadioButton.TabIndex = 1;
            this.customRadioButton.TabStop = true;
            this.customRadioButton.Text = "Costom";
            this.customRadioButton.UseVisualStyleBackColor = true;
            this.customRadioButton.CheckedChanged += new System.EventHandler(this.customRadioButton_CheckedChanged);
            // 
            // dateOrderGroupBox
            // 
            this.dateOrderGroupBox.Controls.Add(this.dmyRadioButton);
            this.dateOrderGroupBox.Controls.Add(this.mdyRadioButton);
            this.dateOrderGroupBox.Controls.Add(this.ymdRadioButton);
            this.dateOrderGroupBox.Location = new System.Drawing.Point(6, 19);
            this.dateOrderGroupBox.Name = "dateOrderGroupBox";
            this.dateOrderGroupBox.Size = new System.Drawing.Size(81, 93);
            this.dateOrderGroupBox.TabIndex = 0;
            this.dateOrderGroupBox.TabStop = false;
            this.dateOrderGroupBox.Text = "Date Order";
            // 
            // dmyRadioButton
            // 
            this.dmyRadioButton.AutoSize = true;
            this.dmyRadioButton.Location = new System.Drawing.Point(1, 66);
            this.dmyRadioButton.Name = "dmyRadioButton";
            this.dmyRadioButton.Size = new System.Drawing.Size(49, 17);
            this.dmyRadioButton.TabIndex = 4;
            this.dmyRadioButton.TabStop = true;
            this.dmyRadioButton.Text = "DMY";
            this.dmyRadioButton.UseVisualStyleBackColor = true;
            this.dmyRadioButton.CheckedChanged += new System.EventHandler(this.dmyRadioButton_CheckedChanged);
            // 
            // mdyRadioButton
            // 
            this.mdyRadioButton.AutoSize = true;
            this.mdyRadioButton.Location = new System.Drawing.Point(1, 43);
            this.mdyRadioButton.Name = "mdyRadioButton";
            this.mdyRadioButton.Size = new System.Drawing.Size(49, 17);
            this.mdyRadioButton.TabIndex = 3;
            this.mdyRadioButton.TabStop = true;
            this.mdyRadioButton.Text = "MDY";
            this.mdyRadioButton.UseVisualStyleBackColor = true;
            this.mdyRadioButton.CheckedChanged += new System.EventHandler(this.mdyRadioButton_CheckedChanged);
            // 
            // ymdRadioButton
            // 
            this.ymdRadioButton.AutoSize = true;
            this.ymdRadioButton.Checked = true;
            this.ymdRadioButton.Location = new System.Drawing.Point(1, 20);
            this.ymdRadioButton.Name = "ymdRadioButton";
            this.ymdRadioButton.Size = new System.Drawing.Size(49, 17);
            this.ymdRadioButton.TabIndex = 2;
            this.ymdRadioButton.TabStop = true;
            this.ymdRadioButton.Text = "YMD";
            this.ymdRadioButton.UseVisualStyleBackColor = true;
            this.ymdRadioButton.CheckedChanged += new System.EventHandler(this.ymdRadioButton_CheckedChanged);
            // 
            // CostomGroupBox
            // 
            this.CostomGroupBox.Controls.Add(this.showGroupBox);
            this.CostomGroupBox.Controls.Add(this.timeFormatGroupBox);
            this.CostomGroupBox.Controls.Add(this.yearFormatGroupBox);
            this.CostomGroupBox.Controls.Add(this.monthFormatGroupBox);
            this.CostomGroupBox.Controls.Add(this.dateTimeOrderGroupBox);
            this.CostomGroupBox.Controls.Add(this.dateSeperatorGroupBox);
            this.CostomGroupBox.Controls.Add(this.dateOrderGroupBox);
            this.CostomGroupBox.Location = new System.Drawing.Point(12, 59);
            this.CostomGroupBox.Name = "CostomGroupBox";
            this.CostomGroupBox.Size = new System.Drawing.Size(401, 201);
            this.CostomGroupBox.TabIndex = 4;
            this.CostomGroupBox.TabStop = false;
            // 
            // showGroupBox
            // 
            this.showGroupBox.Controls.Add(this.showTimeCheckBox);
            this.showGroupBox.Controls.Add(this.showSecondsCheckBox);
            this.showGroupBox.Controls.Add(this.showYearCheckBox);
            this.showGroupBox.Location = new System.Drawing.Point(302, 19);
            this.showGroupBox.Name = "showGroupBox";
            this.showGroupBox.Size = new System.Drawing.Size(84, 93);
            this.showGroupBox.TabIndex = 0;
            this.showGroupBox.TabStop = false;
            this.showGroupBox.Text = "Show";
            // 
            // showTimeCheckBox
            // 
            this.showTimeCheckBox.AutoSize = true;
            this.showTimeCheckBox.Checked = true;
            this.showTimeCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showTimeCheckBox.Location = new System.Drawing.Point(6, 42);
            this.showTimeCheckBox.Name = "showTimeCheckBox";
            this.showTimeCheckBox.Size = new System.Drawing.Size(49, 17);
            this.showTimeCheckBox.TabIndex = 16;
            this.showTimeCheckBox.Text = "Time";
            this.showTimeCheckBox.UseVisualStyleBackColor = true;
            this.showTimeCheckBox.CheckedChanged += new System.EventHandler(this.showTimeCheckBox_CheckedChanged);
            // 
            // showSecondsCheckBox
            // 
            this.showSecondsCheckBox.AutoSize = true;
            this.showSecondsCheckBox.Checked = true;
            this.showSecondsCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showSecondsCheckBox.Location = new System.Drawing.Point(6, 65);
            this.showSecondsCheckBox.Name = "showSecondsCheckBox";
            this.showSecondsCheckBox.Size = new System.Drawing.Size(68, 17);
            this.showSecondsCheckBox.TabIndex = 17;
            this.showSecondsCheckBox.Text = "Seconds";
            this.showSecondsCheckBox.UseVisualStyleBackColor = true;
            this.showSecondsCheckBox.CheckedChanged += new System.EventHandler(this.showSecondsCheckBox_CheckedChanged);
            // 
            // showYearCheckBox
            // 
            this.showYearCheckBox.AutoSize = true;
            this.showYearCheckBox.Checked = true;
            this.showYearCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showYearCheckBox.Location = new System.Drawing.Point(6, 20);
            this.showYearCheckBox.Name = "showYearCheckBox";
            this.showYearCheckBox.Size = new System.Drawing.Size(48, 17);
            this.showYearCheckBox.TabIndex = 15;
            this.showYearCheckBox.Text = "Year";
            this.showYearCheckBox.UseVisualStyleBackColor = true;
            this.showYearCheckBox.CheckedChanged += new System.EventHandler(this.showYearCheckBox_CheckedChanged);
            // 
            // timeFormatGroupBox
            // 
            this.timeFormatGroupBox.Controls.Add(this._24hourRadioButton);
            this.timeFormatGroupBox.Controls.Add(this._12hourRadioButton);
            this.timeFormatGroupBox.Location = new System.Drawing.Point(220, 119);
            this.timeFormatGroupBox.Name = "timeFormatGroupBox";
            this.timeFormatGroupBox.Size = new System.Drawing.Size(87, 72);
            this.timeFormatGroupBox.TabIndex = 0;
            this.timeFormatGroupBox.TabStop = false;
            this.timeFormatGroupBox.Text = "Time Format";
            // 
            // _24hourRadioButton
            // 
            this._24hourRadioButton.AutoSize = true;
            this._24hourRadioButton.Checked = true;
            this._24hourRadioButton.Location = new System.Drawing.Point(7, 44);
            this._24hourRadioButton.Name = "_24hourRadioButton";
            this._24hourRadioButton.Size = new System.Drawing.Size(61, 17);
            this._24hourRadioButton.TabIndex = 14;
            this._24hourRadioButton.TabStop = true;
            this._24hourRadioButton.Text = "24 hour";
            this._24hourRadioButton.UseVisualStyleBackColor = true;
            this._24hourRadioButton.CheckedChanged += new System.EventHandler(this._24hourRadioButton_CheckedChanged);
            // 
            // _12hourRadioButton
            // 
            this._12hourRadioButton.AutoSize = true;
            this._12hourRadioButton.Location = new System.Drawing.Point(7, 20);
            this._12hourRadioButton.Name = "_12hourRadioButton";
            this._12hourRadioButton.Size = new System.Drawing.Size(61, 17);
            this._12hourRadioButton.TabIndex = 13;
            this._12hourRadioButton.TabStop = true;
            this._12hourRadioButton.Text = "12 hour";
            this._12hourRadioButton.UseVisualStyleBackColor = true;
            this._12hourRadioButton.CheckedChanged += new System.EventHandler(this._12hourRadioButton_CheckedChanged);
            // 
            // yearFormatGroupBox
            // 
            this.yearFormatGroupBox.Controls.Add(this.fourDigitRadioButton);
            this.yearFormatGroupBox.Controls.Add(this.twoDigitRadioButton);
            this.yearFormatGroupBox.Location = new System.Drawing.Point(118, 119);
            this.yearFormatGroupBox.Name = "yearFormatGroupBox";
            this.yearFormatGroupBox.Size = new System.Drawing.Size(95, 72);
            this.yearFormatGroupBox.TabIndex = 0;
            this.yearFormatGroupBox.TabStop = false;
            this.yearFormatGroupBox.Text = "Year Format";
            // 
            // fourDigitRadioButton
            // 
            this.fourDigitRadioButton.AutoSize = true;
            this.fourDigitRadioButton.Checked = true;
            this.fourDigitRadioButton.Location = new System.Drawing.Point(7, 44);
            this.fourDigitRadioButton.Name = "fourDigitRadioButton";
            this.fourDigitRadioButton.Size = new System.Drawing.Size(53, 17);
            this.fourDigitRadioButton.TabIndex = 11;
            this.fourDigitRadioButton.TabStop = true;
            this.fourDigitRadioButton.Text = "4 digit";
            this.fourDigitRadioButton.UseVisualStyleBackColor = true;
            this.fourDigitRadioButton.CheckedChanged += new System.EventHandler(this.fourDigitRadioButton_CheckedChanged);
            // 
            // twoDigitRadioButton
            // 
            this.twoDigitRadioButton.AutoSize = true;
            this.twoDigitRadioButton.Location = new System.Drawing.Point(7, 20);
            this.twoDigitRadioButton.Name = "twoDigitRadioButton";
            this.twoDigitRadioButton.Size = new System.Drawing.Size(53, 17);
            this.twoDigitRadioButton.TabIndex = 10;
            this.twoDigitRadioButton.TabStop = true;
            this.twoDigitRadioButton.Text = "2 digit";
            this.twoDigitRadioButton.UseVisualStyleBackColor = true;
            this.twoDigitRadioButton.CheckedChanged += new System.EventHandler(this.twoDigitRadioButton_CheckedChanged);
            // 
            // monthFormatGroupBox
            // 
            this.monthFormatGroupBox.Controls.Add(this.monthWordRadioButton);
            this.monthFormatGroupBox.Controls.Add(this.monthNumberRadioButton);
            this.monthFormatGroupBox.Location = new System.Drawing.Point(202, 19);
            this.monthFormatGroupBox.Name = "monthFormatGroupBox";
            this.monthFormatGroupBox.Size = new System.Drawing.Size(93, 93);
            this.monthFormatGroupBox.TabIndex = 0;
            this.monthFormatGroupBox.TabStop = false;
            this.monthFormatGroupBox.Text = "Month Format";
            // 
            // monthWordRadioButton
            // 
            this.monthWordRadioButton.AutoSize = true;
            this.monthWordRadioButton.Location = new System.Drawing.Point(7, 41);
            this.monthWordRadioButton.Name = "monthWordRadioButton";
            this.monthWordRadioButton.Size = new System.Drawing.Size(51, 17);
            this.monthWordRadioButton.TabIndex = 12;
            this.monthWordRadioButton.TabStop = true;
            this.monthWordRadioButton.Text = "Word";
            this.monthWordRadioButton.UseVisualStyleBackColor = true;
            this.monthWordRadioButton.CheckedChanged += new System.EventHandler(this.monthWordRadioButton_CheckedChanged);
            // 
            // monthNumberRadioButton
            // 
            this.monthNumberRadioButton.AutoSize = true;
            this.monthNumberRadioButton.Checked = true;
            this.monthNumberRadioButton.Location = new System.Drawing.Point(7, 20);
            this.monthNumberRadioButton.Name = "monthNumberRadioButton";
            this.monthNumberRadioButton.Size = new System.Drawing.Size(62, 17);
            this.monthNumberRadioButton.TabIndex = 12;
            this.monthNumberRadioButton.TabStop = true;
            this.monthNumberRadioButton.Text = "Number";
            this.monthNumberRadioButton.UseVisualStyleBackColor = true;
            this.monthNumberRadioButton.CheckedChanged += new System.EventHandler(this.monthNumberRadioButton_CheckedChanged);
            // 
            // dateTimeOrderGroupBox
            // 
            this.dateTimeOrderGroupBox.Controls.Add(this.tdRadioButton);
            this.dateTimeOrderGroupBox.Controls.Add(this.dtRadioButton);
            this.dateTimeOrderGroupBox.Location = new System.Drawing.Point(6, 119);
            this.dateTimeOrderGroupBox.Name = "dateTimeOrderGroupBox";
            this.dateTimeOrderGroupBox.Size = new System.Drawing.Size(105, 73);
            this.dateTimeOrderGroupBox.TabIndex = 0;
            this.dateTimeOrderGroupBox.TabStop = false;
            this.dateTimeOrderGroupBox.Text = "Date Time Order";
            // 
            // tdRadioButton
            // 
            this.tdRadioButton.AutoSize = true;
            this.tdRadioButton.Location = new System.Drawing.Point(7, 44);
            this.tdRadioButton.Name = "tdRadioButton";
            this.tdRadioButton.Size = new System.Drawing.Size(74, 17);
            this.tdRadioButton.TabIndex = 6;
            this.tdRadioButton.TabStop = true;
            this.tdRadioButton.Text = "Time Date";
            this.tdRadioButton.UseVisualStyleBackColor = true;
            this.tdRadioButton.CheckedChanged += new System.EventHandler(this.tdRadioButton_CheckedChanged);
            // 
            // dtRadioButton
            // 
            this.dtRadioButton.AutoSize = true;
            this.dtRadioButton.Checked = true;
            this.dtRadioButton.Location = new System.Drawing.Point(7, 20);
            this.dtRadioButton.Name = "dtRadioButton";
            this.dtRadioButton.Size = new System.Drawing.Size(74, 17);
            this.dtRadioButton.TabIndex = 5;
            this.dtRadioButton.TabStop = true;
            this.dtRadioButton.Text = "Date Time";
            this.dtRadioButton.UseVisualStyleBackColor = true;
            this.dtRadioButton.CheckedChanged += new System.EventHandler(this.dtRadioButton_CheckedChanged);
            // 
            // dateSeperatorGroupBox
            // 
            this.dateSeperatorGroupBox.Controls.Add(this.dotRadioButton);
            this.dateSeperatorGroupBox.Controls.Add(this.slashRadioButton);
            this.dateSeperatorGroupBox.Controls.Add(this.hyphenRadioButton);
            this.dateSeperatorGroupBox.Location = new System.Drawing.Point(93, 19);
            this.dateSeperatorGroupBox.Name = "dateSeperatorGroupBox";
            this.dateSeperatorGroupBox.Size = new System.Drawing.Size(103, 93);
            this.dateSeperatorGroupBox.TabIndex = 0;
            this.dateSeperatorGroupBox.TabStop = false;
            this.dateSeperatorGroupBox.Text = "Date Seperator";
            // 
            // dotRadioButton
            // 
            this.dotRadioButton.AutoSize = true;
            this.dotRadioButton.Location = new System.Drawing.Point(7, 67);
            this.dotRadioButton.Name = "dotRadioButton";
            this.dotRadioButton.Size = new System.Drawing.Size(28, 17);
            this.dotRadioButton.TabIndex = 9;
            this.dotRadioButton.TabStop = true;
            this.dotRadioButton.Text = ".";
            this.dotRadioButton.UseVisualStyleBackColor = true;
            this.dotRadioButton.CheckedChanged += new System.EventHandler(this.dotRadioButton_CheckedChanged);
            // 
            // slashRadioButton
            // 
            this.slashRadioButton.AutoSize = true;
            this.slashRadioButton.Location = new System.Drawing.Point(7, 44);
            this.slashRadioButton.Name = "slashRadioButton";
            this.slashRadioButton.Size = new System.Drawing.Size(30, 17);
            this.slashRadioButton.TabIndex = 8;
            this.slashRadioButton.TabStop = true;
            this.slashRadioButton.Text = "/";
            this.slashRadioButton.UseVisualStyleBackColor = true;
            this.slashRadioButton.CheckedChanged += new System.EventHandler(this.slashRadioButton_CheckedChanged);
            // 
            // hyphenRadioButton
            // 
            this.hyphenRadioButton.AutoSize = true;
            this.hyphenRadioButton.Checked = true;
            this.hyphenRadioButton.Location = new System.Drawing.Point(7, 20);
            this.hyphenRadioButton.Name = "hyphenRadioButton";
            this.hyphenRadioButton.Size = new System.Drawing.Size(28, 17);
            this.hyphenRadioButton.TabIndex = 7;
            this.hyphenRadioButton.TabStop = true;
            this.hyphenRadioButton.Text = "-";
            this.hyphenRadioButton.UseVisualStyleBackColor = true;
            this.hyphenRadioButton.CheckedChanged += new System.EventHandler(this.hyphenRadioButton_CheckedChanged);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(257, 266);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 18;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(338, 266);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 19;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // DateFormatForm
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(426, 297);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.CostomGroupBox);
            this.Controls.Add(this.customRadioButton);
            this.Controls.Add(this.DateTimeLabel);
            this.Controls.Add(this.systemRadioButton);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(442, 336);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(442, 336);
            this.Name = "DateFormatForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customize Date Format ";
            this.Load += new System.EventHandler(this.DateFormatForm_Load);
            this.dateOrderGroupBox.ResumeLayout(false);
            this.dateOrderGroupBox.PerformLayout();
            this.CostomGroupBox.ResumeLayout(false);
            this.showGroupBox.ResumeLayout(false);
            this.showGroupBox.PerformLayout();
            this.timeFormatGroupBox.ResumeLayout(false);
            this.timeFormatGroupBox.PerformLayout();
            this.yearFormatGroupBox.ResumeLayout(false);
            this.yearFormatGroupBox.PerformLayout();
            this.monthFormatGroupBox.ResumeLayout(false);
            this.monthFormatGroupBox.PerformLayout();
            this.dateTimeOrderGroupBox.ResumeLayout(false);
            this.dateTimeOrderGroupBox.PerformLayout();
            this.dateSeperatorGroupBox.ResumeLayout(false);
            this.dateSeperatorGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton systemRadioButton;
        private System.Windows.Forms.Label DateTimeLabel;
        private System.Windows.Forms.RadioButton customRadioButton;
        private System.Windows.Forms.GroupBox dateOrderGroupBox;
        private System.Windows.Forms.RadioButton dmyRadioButton;
        private System.Windows.Forms.RadioButton mdyRadioButton;
        private System.Windows.Forms.RadioButton ymdRadioButton;
        private System.Windows.Forms.GroupBox CostomGroupBox;
        private System.Windows.Forms.GroupBox monthFormatGroupBox;
        private System.Windows.Forms.RadioButton monthWordRadioButton;
        private System.Windows.Forms.RadioButton monthNumberRadioButton;
        private System.Windows.Forms.GroupBox dateTimeOrderGroupBox;
        private System.Windows.Forms.RadioButton tdRadioButton;
        private System.Windows.Forms.RadioButton dtRadioButton;
        private System.Windows.Forms.GroupBox dateSeperatorGroupBox;
        private System.Windows.Forms.RadioButton dotRadioButton;
        private System.Windows.Forms.RadioButton slashRadioButton;
        private System.Windows.Forms.RadioButton hyphenRadioButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.GroupBox showGroupBox;
        private System.Windows.Forms.CheckBox showSecondsCheckBox;
        private System.Windows.Forms.CheckBox showYearCheckBox;
        private System.Windows.Forms.GroupBox timeFormatGroupBox;
        private System.Windows.Forms.RadioButton _24hourRadioButton;
        private System.Windows.Forms.RadioButton _12hourRadioButton;
        private System.Windows.Forms.GroupBox yearFormatGroupBox;
        private System.Windows.Forms.RadioButton fourDigitRadioButton;
        private System.Windows.Forms.RadioButton twoDigitRadioButton;
        private System.Windows.Forms.CheckBox showTimeCheckBox;
        private System.Windows.Forms.Timer timer1;
    }
}