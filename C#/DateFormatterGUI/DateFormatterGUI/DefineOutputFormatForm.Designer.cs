namespace DateFormatter
{
    partial class DefineOutputFormatForm
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
            this.comboBox_dateOrder = new System.Windows.Forms.ComboBox();
            this.label_dateOrder = new System.Windows.Forms.Label();
            this.comboBox_yearFormat = new System.Windows.Forms.ComboBox();
            this.label_yearFormat = new System.Windows.Forms.Label();
            this.comboBox_monthFormat = new System.Windows.Forms.ComboBox();
            this.comboBox_dayFormat = new System.Windows.Forms.ComboBox();
            this.comboBox_separator = new System.Windows.Forms.ComboBox();
            this.label_monthFormat = new System.Windows.Forms.Label();
            this.label_dayFormat = new System.Windows.Forms.Label();
            this.label_separator = new System.Windows.Forms.Label();
            this.button_ok = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.checkBox_commaAfterDay = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // comboBox_dateOrder
            // 
            this.comboBox_dateOrder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_dateOrder.FormattingEnabled = true;
            this.comboBox_dateOrder.Items.AddRange(new object[] {
            "(please select)",
            "Year-Month-Day",
            "Day-Month-Year",
            "Month-Day-Year"});
            this.comboBox_dateOrder.Location = new System.Drawing.Point(90, 16);
            this.comboBox_dateOrder.Name = "comboBox_dateOrder";
            this.comboBox_dateOrder.Size = new System.Drawing.Size(200, 21);
            this.comboBox_dateOrder.TabIndex = 0;
            this.comboBox_dateOrder.SelectedIndexChanged += new System.EventHandler(this.comboBox_dateOrder_SelectedIndexChanged);
            // 
            // label_dateOrder
            // 
            this.label_dateOrder.AutoSize = true;
            this.label_dateOrder.Location = new System.Drawing.Point(13, 19);
            this.label_dateOrder.Name = "label_dateOrder";
            this.label_dateOrder.Size = new System.Drawing.Size(60, 13);
            this.label_dateOrder.TabIndex = 1;
            this.label_dateOrder.Text = "Date order:";
            // 
            // comboBox_yearFormat
            // 
            this.comboBox_yearFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_yearFormat.FormattingEnabled = true;
            this.comboBox_yearFormat.Items.AddRange(new object[] {
            "(please select)",
            "2-digit e.g. \"23\"",
            "4-digit e.g. \"2023\""});
            this.comboBox_yearFormat.Location = new System.Drawing.Point(90, 43);
            this.comboBox_yearFormat.Name = "comboBox_yearFormat";
            this.comboBox_yearFormat.Size = new System.Drawing.Size(200, 21);
            this.comboBox_yearFormat.TabIndex = 0;
            // 
            // label_yearFormat
            // 
            this.label_yearFormat.AutoSize = true;
            this.label_yearFormat.Location = new System.Drawing.Point(13, 46);
            this.label_yearFormat.Name = "label_yearFormat";
            this.label_yearFormat.Size = new System.Drawing.Size(64, 13);
            this.label_yearFormat.TabIndex = 1;
            this.label_yearFormat.Text = "Year format:";
            // 
            // comboBox_monthFormat
            // 
            this.comboBox_monthFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_monthFormat.FormattingEnabled = true;
            this.comboBox_monthFormat.Items.AddRange(new object[] {
            "(please select)",
            "Numerical without leading-zero e.g. \"8\"",
            "Numerical with leading-zero e.g. \"08\"",
            "Worded 3-letter e.g. \"Aug\"",
            "Worded full e.g. \"August\""});
            this.comboBox_monthFormat.Location = new System.Drawing.Point(90, 70);
            this.comboBox_monthFormat.Name = "comboBox_monthFormat";
            this.comboBox_monthFormat.Size = new System.Drawing.Size(200, 21);
            this.comboBox_monthFormat.TabIndex = 0;
            this.comboBox_monthFormat.SelectedIndexChanged += new System.EventHandler(this.comboBox_monthFormat_SelectedIndexChanged);
            // 
            // comboBox_dayFormat
            // 
            this.comboBox_dayFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_dayFormat.FormattingEnabled = true;
            this.comboBox_dayFormat.Items.AddRange(new object[] {
            "(please select)",
            "Without leading-zero e.g. \"5\"",
            "With leading-zero e.g. \"05\"",
            "Ordinanl e.g. \"5th\""});
            this.comboBox_dayFormat.Location = new System.Drawing.Point(90, 97);
            this.comboBox_dayFormat.Name = "comboBox_dayFormat";
            this.comboBox_dayFormat.Size = new System.Drawing.Size(200, 21);
            this.comboBox_dayFormat.TabIndex = 0;
            // 
            // comboBox_separator
            // 
            this.comboBox_separator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_separator.FormattingEnabled = true;
            this.comboBox_separator.Items.AddRange(new object[] {
            "(please select)",
            "Slash (/)",
            "Dot (.)",
            "Hyphen (-)",
            "Space ( )",
            "Underscore (_)",
            "None ()"});
            this.comboBox_separator.Location = new System.Drawing.Point(90, 124);
            this.comboBox_separator.Name = "comboBox_separator";
            this.comboBox_separator.Size = new System.Drawing.Size(200, 21);
            this.comboBox_separator.TabIndex = 0;
            this.comboBox_separator.SelectedIndexChanged += new System.EventHandler(this.comboBox_separator_SelectedIndexChanged);
            // 
            // label_monthFormat
            // 
            this.label_monthFormat.AutoSize = true;
            this.label_monthFormat.Location = new System.Drawing.Point(13, 73);
            this.label_monthFormat.Name = "label_monthFormat";
            this.label_monthFormat.Size = new System.Drawing.Size(72, 13);
            this.label_monthFormat.TabIndex = 1;
            this.label_monthFormat.Text = "Month format:";
            // 
            // label_dayFormat
            // 
            this.label_dayFormat.AutoSize = true;
            this.label_dayFormat.Location = new System.Drawing.Point(13, 100);
            this.label_dayFormat.Name = "label_dayFormat";
            this.label_dayFormat.Size = new System.Drawing.Size(61, 13);
            this.label_dayFormat.TabIndex = 1;
            this.label_dayFormat.Text = "Day format:";
            // 
            // label_separator
            // 
            this.label_separator.AutoSize = true;
            this.label_separator.Location = new System.Drawing.Point(13, 127);
            this.label_separator.Name = "label_separator";
            this.label_separator.Size = new System.Drawing.Size(59, 13);
            this.label_separator.TabIndex = 1;
            this.label_separator.Text = "Separator: ";
            // 
            // button_ok
            // 
            this.button_ok.Location = new System.Drawing.Point(167, 198);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(75, 23);
            this.button_ok.TabIndex = 2;
            this.button_ok.Text = "OK";
            this.button_ok.UseVisualStyleBackColor = true;
            this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_cancel.Location = new System.Drawing.Point(248, 198);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(75, 23);
            this.button_cancel.TabIndex = 2;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            // 
            // checkBox_commaAfterDay
            // 
            this.checkBox_commaAfterDay.AutoSize = true;
            this.checkBox_commaAfterDay.Enabled = false;
            this.checkBox_commaAfterDay.Location = new System.Drawing.Point(90, 151);
            this.checkBox_commaAfterDay.Name = "checkBox_commaAfterDay";
            this.checkBox_commaAfterDay.Size = new System.Drawing.Size(169, 17);
            this.checkBox_commaAfterDay.TabIndex = 3;
            this.checkBox_commaAfterDay.Text = "Include a comma after the day";
            this.checkBox_commaAfterDay.UseVisualStyleBackColor = true;
            // 
            // DefineOutputFormatForm
            // 
            this.AcceptButton = this.button_ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button_cancel;
            this.ClientSize = new System.Drawing.Size(335, 233);
            this.ControlBox = false;
            this.Controls.Add(this.checkBox_commaAfterDay);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_ok);
            this.Controls.Add(this.label_separator);
            this.Controls.Add(this.label_dayFormat);
            this.Controls.Add(this.label_monthFormat);
            this.Controls.Add(this.label_yearFormat);
            this.Controls.Add(this.comboBox_separator);
            this.Controls.Add(this.comboBox_dayFormat);
            this.Controls.Add(this.comboBox_monthFormat);
            this.Controls.Add(this.comboBox_yearFormat);
            this.Controls.Add(this.label_dateOrder);
            this.Controls.Add(this.comboBox_dateOrder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "DefineOutputFormatForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Define Output Format";
            this.Load += new System.EventHandler(this.DefineOutputFormatForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_dateOrder;
        private System.Windows.Forms.Label label_dateOrder;
        private System.Windows.Forms.ComboBox comboBox_yearFormat;
        private System.Windows.Forms.Label label_yearFormat;
        private System.Windows.Forms.ComboBox comboBox_monthFormat;
        private System.Windows.Forms.ComboBox comboBox_dayFormat;
        private System.Windows.Forms.ComboBox comboBox_separator;
        private System.Windows.Forms.Label label_monthFormat;
        private System.Windows.Forms.Label label_dayFormat;
        private System.Windows.Forms.Label label_separator;
        private System.Windows.Forms.Button button_ok;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.CheckBox checkBox_commaAfterDay;
    }
}