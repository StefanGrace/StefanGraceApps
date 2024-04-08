namespace DateListGenerator
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
            this.label_dateOrder = new System.Windows.Forms.Label();
            this.label_monthFormat = new System.Windows.Forms.Label();
            this.label_yearFormat = new System.Windows.Forms.Label();
            this.label_dayFormat = new System.Windows.Forms.Label();
            this.label_dateSep = new System.Windows.Forms.Label();
            this.label_weekday = new System.Windows.Forms.Label();
            this.label_weekdayFormat = new System.Windows.Forms.Label();
            this.label_weekdaySep = new System.Windows.Forms.Label();
            this.checkBox_commaAfterDay = new System.Windows.Forms.CheckBox();
            this.comboBox_separator = new System.Windows.Forms.ComboBox();
            this.comboBox_dayFormat = new System.Windows.Forms.ComboBox();
            this.comboBox_monthFormat = new System.Windows.Forms.ComboBox();
            this.comboBox_yearFormat = new System.Windows.Forms.ComboBox();
            this.comboBox_dateOrder = new System.Windows.Forms.ComboBox();
            this.comboBox_weekday = new System.Windows.Forms.ComboBox();
            this.comboBox_weekdayFormat = new System.Windows.Forms.ComboBox();
            this.comboBox_weekdaySep = new System.Windows.Forms.ComboBox();
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_ok = new System.Windows.Forms.Button();
            this.label_sample = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_dateOrder
            // 
            this.label_dateOrder.AutoSize = true;
            this.label_dateOrder.Location = new System.Drawing.Point(16, 16);
            this.label_dateOrder.Name = "label_dateOrder";
            this.label_dateOrder.Size = new System.Drawing.Size(60, 13);
            this.label_dateOrder.TabIndex = 0;
            this.label_dateOrder.Text = "Date order:";
            // 
            // label_monthFormat
            // 
            this.label_monthFormat.AutoSize = true;
            this.label_monthFormat.Location = new System.Drawing.Point(16, 70);
            this.label_monthFormat.Name = "label_monthFormat";
            this.label_monthFormat.Size = new System.Drawing.Size(72, 13);
            this.label_monthFormat.TabIndex = 0;
            this.label_monthFormat.Text = "Month format:";
            // 
            // label_yearFormat
            // 
            this.label_yearFormat.AutoSize = true;
            this.label_yearFormat.Location = new System.Drawing.Point(16, 43);
            this.label_yearFormat.Name = "label_yearFormat";
            this.label_yearFormat.Size = new System.Drawing.Size(64, 13);
            this.label_yearFormat.TabIndex = 0;
            this.label_yearFormat.Text = "Year format:";
            // 
            // label_dayFormat
            // 
            this.label_dayFormat.AutoSize = true;
            this.label_dayFormat.Location = new System.Drawing.Point(16, 97);
            this.label_dayFormat.Name = "label_dayFormat";
            this.label_dayFormat.Size = new System.Drawing.Size(61, 13);
            this.label_dayFormat.TabIndex = 0;
            this.label_dayFormat.Text = "Day format:";
            // 
            // label_dateSep
            // 
            this.label_dateSep.AutoSize = true;
            this.label_dateSep.Location = new System.Drawing.Point(16, 124);
            this.label_dateSep.Name = "label_dateSep";
            this.label_dateSep.Size = new System.Drawing.Size(80, 13);
            this.label_dateSep.TabIndex = 0;
            this.label_dateSep.Text = "Date seperator:";
            // 
            // label_weekday
            // 
            this.label_weekday.AutoSize = true;
            this.label_weekday.Location = new System.Drawing.Point(16, 151);
            this.label_weekday.Name = "label_weekday";
            this.label_weekday.Size = new System.Drawing.Size(89, 13);
            this.label_weekday.TabIndex = 0;
            this.label_weekday.Text = "Incude weekday:";
            // 
            // label_weekdayFormat
            // 
            this.label_weekdayFormat.AutoSize = true;
            this.label_weekdayFormat.Location = new System.Drawing.Point(17, 178);
            this.label_weekdayFormat.Name = "label_weekdayFormat";
            this.label_weekdayFormat.Size = new System.Drawing.Size(88, 13);
            this.label_weekdayFormat.TabIndex = 0;
            this.label_weekdayFormat.Text = "Weekday format:";
            // 
            // label_weekdaySep
            // 
            this.label_weekdaySep.AutoSize = true;
            this.label_weekdaySep.Location = new System.Drawing.Point(17, 205);
            this.label_weekdaySep.Name = "label_weekdaySep";
            this.label_weekdaySep.Size = new System.Drawing.Size(103, 13);
            this.label_weekdaySep.TabIndex = 0;
            this.label_weekdaySep.Text = "Weekday seperator:";
            // 
            // checkBox_commaAfterDay
            // 
            this.checkBox_commaAfterDay.AutoSize = true;
            this.checkBox_commaAfterDay.Enabled = false;
            this.checkBox_commaAfterDay.Location = new System.Drawing.Point(124, 236);
            this.checkBox_commaAfterDay.Name = "checkBox_commaAfterDay";
            this.checkBox_commaAfterDay.Size = new System.Drawing.Size(169, 17);
            this.checkBox_commaAfterDay.TabIndex = 8;
            this.checkBox_commaAfterDay.Text = "Include a comma after the day";
            this.checkBox_commaAfterDay.UseVisualStyleBackColor = true;
            this.checkBox_commaAfterDay.CheckedChanged += new System.EventHandler(this.checkBox_commaAfterDay_CheckedChanged);
            // 
            // comboBox_separator
            // 
            this.comboBox_separator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_separator.FormattingEnabled = true;
            this.comboBox_separator.Items.AddRange(new object[] {
            "Slash (/)",
            "Dot (.)",
            "Hyphen (-)",
            "Space ( )"});
            this.comboBox_separator.Location = new System.Drawing.Point(124, 121);
            this.comboBox_separator.Name = "comboBox_separator";
            this.comboBox_separator.Size = new System.Drawing.Size(185, 21);
            this.comboBox_separator.TabIndex = 4;
            this.comboBox_separator.SelectedIndexChanged += new System.EventHandler(this.comboBox_separator_SelectedIndexChanged);
            // 
            // comboBox_dayFormat
            // 
            this.comboBox_dayFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_dayFormat.FormattingEnabled = true;
            this.comboBox_dayFormat.Items.AddRange(new object[] {
            "Without leading-zero",
            "With leading-zero",
            "Ordinal"});
            this.comboBox_dayFormat.Location = new System.Drawing.Point(124, 94);
            this.comboBox_dayFormat.Name = "comboBox_dayFormat";
            this.comboBox_dayFormat.Size = new System.Drawing.Size(185, 21);
            this.comboBox_dayFormat.TabIndex = 3;
            this.comboBox_dayFormat.SelectedIndexChanged += new System.EventHandler(this.comboBox_dayFormat_SelectedIndexChanged);
            // 
            // comboBox_monthFormat
            // 
            this.comboBox_monthFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_monthFormat.FormattingEnabled = true;
            this.comboBox_monthFormat.Items.AddRange(new object[] {
            "Numerical without leading-zero",
            "Numerical with leading-zero",
            "Worded 3-letter",
            "Worded full"});
            this.comboBox_monthFormat.Location = new System.Drawing.Point(124, 67);
            this.comboBox_monthFormat.Name = "comboBox_monthFormat";
            this.comboBox_monthFormat.Size = new System.Drawing.Size(185, 21);
            this.comboBox_monthFormat.TabIndex = 2;
            this.comboBox_monthFormat.SelectedIndexChanged += new System.EventHandler(this.comboBox_monthFormat_SelectedIndexChanged);
            // 
            // comboBox_yearFormat
            // 
            this.comboBox_yearFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_yearFormat.FormattingEnabled = true;
            this.comboBox_yearFormat.Items.AddRange(new object[] {
            "4-digit",
            "2-digit"});
            this.comboBox_yearFormat.Location = new System.Drawing.Point(124, 40);
            this.comboBox_yearFormat.Name = "comboBox_yearFormat";
            this.comboBox_yearFormat.Size = new System.Drawing.Size(185, 21);
            this.comboBox_yearFormat.TabIndex = 1;
            this.comboBox_yearFormat.SelectedIndexChanged += new System.EventHandler(this.comboBox_yearFormat_SelectedIndexChanged);
            // 
            // comboBox_dateOrder
            // 
            this.comboBox_dateOrder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_dateOrder.FormattingEnabled = true;
            this.comboBox_dateOrder.Items.AddRange(new object[] {
            "Year-Month-Day",
            "Day-Month-Year",
            "Month-Day-Year"});
            this.comboBox_dateOrder.Location = new System.Drawing.Point(124, 13);
            this.comboBox_dateOrder.Name = "comboBox_dateOrder";
            this.comboBox_dateOrder.Size = new System.Drawing.Size(185, 21);
            this.comboBox_dateOrder.TabIndex = 0;
            this.comboBox_dateOrder.SelectedIndexChanged += new System.EventHandler(this.comboBox_dateOrder_SelectedIndexChanged);
            // 
            // comboBox_weekday
            // 
            this.comboBox_weekday.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_weekday.FormattingEnabled = true;
            this.comboBox_weekday.Items.AddRange(new object[] {
            "No",
            "Before date",
            "After date"});
            this.comboBox_weekday.Location = new System.Drawing.Point(124, 148);
            this.comboBox_weekday.Name = "comboBox_weekday";
            this.comboBox_weekday.Size = new System.Drawing.Size(185, 21);
            this.comboBox_weekday.TabIndex = 5;
            this.comboBox_weekday.SelectedIndexChanged += new System.EventHandler(this.comboBox_weekday_SelectedIndexChanged);
            // 
            // comboBox_weekdayFormat
            // 
            this.comboBox_weekdayFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_weekdayFormat.FormattingEnabled = true;
            this.comboBox_weekdayFormat.Items.AddRange(new object[] {
            "3-letter",
            "Full"});
            this.comboBox_weekdayFormat.Location = new System.Drawing.Point(124, 175);
            this.comboBox_weekdayFormat.Name = "comboBox_weekdayFormat";
            this.comboBox_weekdayFormat.Size = new System.Drawing.Size(185, 21);
            this.comboBox_weekdayFormat.TabIndex = 6;
            this.comboBox_weekdayFormat.SelectedIndexChanged += new System.EventHandler(this.comboBox_weekdayFormat_SelectedIndexChanged);
            // 
            // comboBox_weekdaySep
            // 
            this.comboBox_weekdaySep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_weekdaySep.FormattingEnabled = true;
            this.comboBox_weekdaySep.Items.AddRange(new object[] {
            "Space ( )",
            "Comma space (, )",
            "Hyphen (-)",
            "Underscore (_)"});
            this.comboBox_weekdaySep.Location = new System.Drawing.Point(124, 202);
            this.comboBox_weekdaySep.Name = "comboBox_weekdaySep";
            this.comboBox_weekdaySep.Size = new System.Drawing.Size(185, 21);
            this.comboBox_weekdaySep.TabIndex = 7;
            this.comboBox_weekdaySep.SelectedIndexChanged += new System.EventHandler(this.comboBox_weekdaySep_SelectedIndexChanged);
            // 
            // button_cancel
            // 
            this.button_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_cancel.Location = new System.Drawing.Point(235, 286);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(75, 23);
            this.button_cancel.TabIndex = 10;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            // 
            // button_ok
            // 
            this.button_ok.Location = new System.Drawing.Point(154, 286);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(75, 23);
            this.button_ok.TabIndex = 9;
            this.button_ok.Text = "OK";
            this.button_ok.UseVisualStyleBackColor = true;
            this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
            // 
            // label_sample
            // 
            this.label_sample.AutoSize = true;
            this.label_sample.Location = new System.Drawing.Point(17, 262);
            this.label_sample.Name = "label_sample";
            this.label_sample.Size = new System.Drawing.Size(48, 13);
            this.label_sample.TabIndex = 11;
            this.label_sample.Text = "Sample: ";
            // 
            // DateFormatForm
            // 
            this.AcceptButton = this.button_ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button_cancel;
            this.ClientSize = new System.Drawing.Size(322, 321);
            this.Controls.Add(this.label_sample);
            this.Controls.Add(this.button_ok);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.checkBox_commaAfterDay);
            this.Controls.Add(this.comboBox_weekdaySep);
            this.Controls.Add(this.comboBox_weekdayFormat);
            this.Controls.Add(this.comboBox_weekday);
            this.Controls.Add(this.comboBox_separator);
            this.Controls.Add(this.comboBox_dayFormat);
            this.Controls.Add(this.comboBox_monthFormat);
            this.Controls.Add(this.comboBox_yearFormat);
            this.Controls.Add(this.comboBox_dateOrder);
            this.Controls.Add(this.label_yearFormat);
            this.Controls.Add(this.label_weekdaySep);
            this.Controls.Add(this.label_weekdayFormat);
            this.Controls.Add(this.label_weekday);
            this.Controls.Add(this.label_dateSep);
            this.Controls.Add(this.label_dayFormat);
            this.Controls.Add(this.label_monthFormat);
            this.Controls.Add(this.label_dateOrder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DateFormatForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Date Format";
            this.Load += new System.EventHandler(this.DateFormatForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_dateOrder;
        private System.Windows.Forms.Label label_monthFormat;
        private System.Windows.Forms.Label label_yearFormat;
        private System.Windows.Forms.Label label_dayFormat;
        private System.Windows.Forms.Label label_dateSep;
        private System.Windows.Forms.Label label_weekday;
        private System.Windows.Forms.Label label_weekdayFormat;
        private System.Windows.Forms.Label label_weekdaySep;
        private System.Windows.Forms.CheckBox checkBox_commaAfterDay;
        private System.Windows.Forms.ComboBox comboBox_separator;
        private System.Windows.Forms.ComboBox comboBox_dayFormat;
        private System.Windows.Forms.ComboBox comboBox_monthFormat;
        private System.Windows.Forms.ComboBox comboBox_yearFormat;
        private System.Windows.Forms.ComboBox comboBox_dateOrder;
        private System.Windows.Forms.ComboBox comboBox_weekday;
        private System.Windows.Forms.ComboBox comboBox_weekdayFormat;
        private System.Windows.Forms.ComboBox comboBox_weekdaySep;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Button button_ok;
        private System.Windows.Forms.Label label_sample;
    }
}