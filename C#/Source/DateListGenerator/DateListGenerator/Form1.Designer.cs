namespace DateListGenerator
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
            this.groupBox_range = new System.Windows.Forms.GroupBox();
            this.comboBox_endDay = new System.Windows.Forms.ComboBox();
            this.comboBox_startDay = new System.Windows.Forms.ComboBox();
            this.comboBox_endMonth = new System.Windows.Forms.ComboBox();
            this.comboBox_startMonth = new System.Windows.Forms.ComboBox();
            this.label_end = new System.Windows.Forms.Label();
            this.label_day = new System.Windows.Forms.Label();
            this.label_month = new System.Windows.Forms.Label();
            this.label_year = new System.Windows.Forms.Label();
            this.label_start = new System.Windows.Forms.Label();
            this.textBox_endYear = new System.Windows.Forms.TextBox();
            this.textBox_startYear = new System.Windows.Forms.TextBox();
            this.radioButton_generateSome = new System.Windows.Forms.RadioButton();
            this.radioButton_generateRandom = new System.Windows.Forms.RadioButton();
            this.radioButton_generateOrder = new System.Windows.Forms.RadioButton();
            this.groupBox_dates = new System.Windows.Forms.GroupBox();
            this.checkBox_duplicates = new System.Windows.Forms.CheckBox();
            this.numericUpDown_numDates = new System.Windows.Forms.NumericUpDown();
            this.label_numDates = new System.Windows.Forms.Label();
            this.groupBox_filters = new System.Windows.Forms.GroupBox();
            this.label_maxDay = new System.Windows.Forms.Label();
            this.label_minDay = new System.Windows.Forms.Label();
            this.label_filterDay = new System.Windows.Forms.Label();
            this.numericUpDown_maxDay = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_minDay = new System.Windows.Forms.NumericUpDown();
            this.label_filterMonth = new System.Windows.Forms.Label();
            this.label_filterWeekday = new System.Windows.Forms.Label();
            this.comboBox_filterMonth = new System.Windows.Forms.ComboBox();
            this.comboBox_filterWeekday = new System.Windows.Forms.ComboBox();
            this.button_format = new System.Windows.Forms.Button();
            this.button_generate = new System.Windows.Forms.Button();
            this.button_saveOutput = new System.Windows.Forms.Button();
            this.button_saveSettings = new System.Windows.Forms.Button();
            this.richTextBox_output = new System.Windows.Forms.RichTextBox();
            this.label_output = new System.Windows.Forms.Label();
            this.groupBox_range.SuspendLayout();
            this.groupBox_dates.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_numDates)).BeginInit();
            this.groupBox_filters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_maxDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_minDay)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_range
            // 
            this.groupBox_range.Controls.Add(this.comboBox_endDay);
            this.groupBox_range.Controls.Add(this.comboBox_startDay);
            this.groupBox_range.Controls.Add(this.comboBox_endMonth);
            this.groupBox_range.Controls.Add(this.comboBox_startMonth);
            this.groupBox_range.Controls.Add(this.label_end);
            this.groupBox_range.Controls.Add(this.label_day);
            this.groupBox_range.Controls.Add(this.label_month);
            this.groupBox_range.Controls.Add(this.label_year);
            this.groupBox_range.Controls.Add(this.label_start);
            this.groupBox_range.Controls.Add(this.textBox_endYear);
            this.groupBox_range.Controls.Add(this.textBox_startYear);
            this.groupBox_range.Location = new System.Drawing.Point(12, 12);
            this.groupBox_range.Name = "groupBox_range";
            this.groupBox_range.Size = new System.Drawing.Size(271, 100);
            this.groupBox_range.TabIndex = 0;
            this.groupBox_range.TabStop = false;
            this.groupBox_range.Text = "Date range (inclusive)";
            // 
            // comboBox_endDay
            // 
            this.comboBox_endDay.FormattingEnabled = true;
            this.comboBox_endDay.Location = new System.Drawing.Point(196, 66);
            this.comboBox_endDay.MaxLength = 2;
            this.comboBox_endDay.Name = "comboBox_endDay";
            this.comboBox_endDay.Size = new System.Drawing.Size(55, 21);
            this.comboBox_endDay.TabIndex = 6;
            // 
            // comboBox_startDay
            // 
            this.comboBox_startDay.FormattingEnabled = true;
            this.comboBox_startDay.Location = new System.Drawing.Point(196, 38);
            this.comboBox_startDay.MaxLength = 2;
            this.comboBox_startDay.Name = "comboBox_startDay";
            this.comboBox_startDay.Size = new System.Drawing.Size(55, 21);
            this.comboBox_startDay.TabIndex = 3;
            // 
            // comboBox_endMonth
            // 
            this.comboBox_endMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_endMonth.FormattingEnabled = true;
            this.comboBox_endMonth.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.comboBox_endMonth.Location = new System.Drawing.Point(100, 66);
            this.comboBox_endMonth.Name = "comboBox_endMonth";
            this.comboBox_endMonth.Size = new System.Drawing.Size(90, 21);
            this.comboBox_endMonth.TabIndex = 5;
            this.comboBox_endMonth.SelectedIndexChanged += new System.EventHandler(this.comboBox_endMonth_SelectedIndexChanged);
            // 
            // comboBox_startMonth
            // 
            this.comboBox_startMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_startMonth.FormattingEnabled = true;
            this.comboBox_startMonth.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.comboBox_startMonth.Location = new System.Drawing.Point(100, 38);
            this.comboBox_startMonth.Name = "comboBox_startMonth";
            this.comboBox_startMonth.Size = new System.Drawing.Size(90, 21);
            this.comboBox_startMonth.TabIndex = 2;
            this.comboBox_startMonth.SelectedIndexChanged += new System.EventHandler(this.comboBox_startMonth_SelectedIndexChanged);
            // 
            // label_end
            // 
            this.label_end.AutoSize = true;
            this.label_end.Location = new System.Drawing.Point(6, 69);
            this.label_end.Name = "label_end";
            this.label_end.Size = new System.Drawing.Size(29, 13);
            this.label_end.TabIndex = 1;
            this.label_end.Text = "End:";
            // 
            // label_day
            // 
            this.label_day.AutoSize = true;
            this.label_day.Location = new System.Drawing.Point(203, 20);
            this.label_day.Name = "label_day";
            this.label_day.Size = new System.Drawing.Size(26, 13);
            this.label_day.TabIndex = 1;
            this.label_day.Text = "Day";
            // 
            // label_month
            // 
            this.label_month.AutoSize = true;
            this.label_month.Location = new System.Drawing.Point(109, 20);
            this.label_month.Name = "label_month";
            this.label_month.Size = new System.Drawing.Size(37, 13);
            this.label_month.TabIndex = 1;
            this.label_month.Text = "Month";
            // 
            // label_year
            // 
            this.label_year.AutoSize = true;
            this.label_year.Location = new System.Drawing.Point(51, 20);
            this.label_year.Name = "label_year";
            this.label_year.Size = new System.Drawing.Size(29, 13);
            this.label_year.TabIndex = 1;
            this.label_year.Text = "Year";
            // 
            // label_start
            // 
            this.label_start.AutoSize = true;
            this.label_start.Location = new System.Drawing.Point(6, 38);
            this.label_start.Name = "label_start";
            this.label_start.Size = new System.Drawing.Size(32, 13);
            this.label_start.TabIndex = 1;
            this.label_start.Text = "Start:";
            // 
            // textBox_endYear
            // 
            this.textBox_endYear.Location = new System.Drawing.Point(45, 66);
            this.textBox_endYear.MaxLength = 4;
            this.textBox_endYear.Name = "textBox_endYear";
            this.textBox_endYear.Size = new System.Drawing.Size(49, 20);
            this.textBox_endYear.TabIndex = 4;
            this.textBox_endYear.TextChanged += new System.EventHandler(this.textBox_endYear_TextChanged);
            // 
            // textBox_startYear
            // 
            this.textBox_startYear.Location = new System.Drawing.Point(45, 38);
            this.textBox_startYear.MaxLength = 4;
            this.textBox_startYear.Name = "textBox_startYear";
            this.textBox_startYear.Size = new System.Drawing.Size(49, 20);
            this.textBox_startYear.TabIndex = 1;
            this.textBox_startYear.TextChanged += new System.EventHandler(this.textBox_startYear_TextChanged);
            // 
            // radioButton_generateSome
            // 
            this.radioButton_generateSome.AutoSize = true;
            this.radioButton_generateSome.Checked = true;
            this.radioButton_generateSome.Location = new System.Drawing.Point(12, 130);
            this.radioButton_generateSome.Name = "radioButton_generateSome";
            this.radioButton_generateSome.Size = new System.Drawing.Size(164, 17);
            this.radioButton_generateSome.TabIndex = 7;
            this.radioButton_generateSome.TabStop = true;
            this.radioButton_generateSome.Text = "Generate some random dates";
            this.radioButton_generateSome.UseVisualStyleBackColor = true;
            this.radioButton_generateSome.CheckedChanged += new System.EventHandler(this.radioButton_generateSome_CheckedChanged);
            // 
            // radioButton_generateRandom
            // 
            this.radioButton_generateRandom.AutoSize = true;
            this.radioButton_generateRandom.Location = new System.Drawing.Point(12, 204);
            this.radioButton_generateRandom.Name = "radioButton_generateRandom";
            this.radioButton_generateRandom.Size = new System.Drawing.Size(187, 17);
            this.radioButton_generateRandom.TabIndex = 7;
            this.radioButton_generateRandom.Text = "Generate all dates in random order";
            this.radioButton_generateRandom.UseVisualStyleBackColor = true;
            // 
            // radioButton_generateOrder
            // 
            this.radioButton_generateOrder.AutoSize = true;
            this.radioButton_generateOrder.Location = new System.Drawing.Point(12, 227);
            this.radioButton_generateOrder.Name = "radioButton_generateOrder";
            this.radioButton_generateOrder.Size = new System.Drawing.Size(215, 17);
            this.radioButton_generateOrder.TabIndex = 7;
            this.radioButton_generateOrder.Text = "Generate all dates in chronological order";
            this.radioButton_generateOrder.UseVisualStyleBackColor = true;
            // 
            // groupBox_dates
            // 
            this.groupBox_dates.Controls.Add(this.checkBox_duplicates);
            this.groupBox_dates.Controls.Add(this.numericUpDown_numDates);
            this.groupBox_dates.Controls.Add(this.label_numDates);
            this.groupBox_dates.Location = new System.Drawing.Point(12, 153);
            this.groupBox_dates.Name = "groupBox_dates";
            this.groupBox_dates.Size = new System.Drawing.Size(271, 45);
            this.groupBox_dates.TabIndex = 2;
            this.groupBox_dates.TabStop = false;
            // 
            // checkBox_duplicates
            // 
            this.checkBox_duplicates.AutoSize = true;
            this.checkBox_duplicates.Location = new System.Drawing.Point(153, 20);
            this.checkBox_duplicates.Name = "checkBox_duplicates";
            this.checkBox_duplicates.Size = new System.Drawing.Size(102, 17);
            this.checkBox_duplicates.TabIndex = 9;
            this.checkBox_duplicates.Text = "Allow duplicates";
            this.checkBox_duplicates.UseVisualStyleBackColor = true;
            // 
            // numericUpDown_numDates
            // 
            this.numericUpDown_numDates.Location = new System.Drawing.Point(100, 18);
            this.numericUpDown_numDates.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericUpDown_numDates.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_numDates.Name = "numericUpDown_numDates";
            this.numericUpDown_numDates.Size = new System.Drawing.Size(46, 20);
            this.numericUpDown_numDates.TabIndex = 8;
            this.numericUpDown_numDates.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // label_numDates
            // 
            this.label_numDates.AutoSize = true;
            this.label_numDates.Location = new System.Drawing.Point(7, 20);
            this.label_numDates.Name = "label_numDates";
            this.label_numDates.Size = new System.Drawing.Size(88, 13);
            this.label_numDates.TabIndex = 0;
            this.label_numDates.Text = "Number of dates:";
            // 
            // groupBox_filters
            // 
            this.groupBox_filters.Controls.Add(this.label_maxDay);
            this.groupBox_filters.Controls.Add(this.label_minDay);
            this.groupBox_filters.Controls.Add(this.label_filterDay);
            this.groupBox_filters.Controls.Add(this.numericUpDown_maxDay);
            this.groupBox_filters.Controls.Add(this.numericUpDown_minDay);
            this.groupBox_filters.Controls.Add(this.label_filterMonth);
            this.groupBox_filters.Controls.Add(this.label_filterWeekday);
            this.groupBox_filters.Controls.Add(this.comboBox_filterMonth);
            this.groupBox_filters.Controls.Add(this.comboBox_filterWeekday);
            this.groupBox_filters.Location = new System.Drawing.Point(12, 259);
            this.groupBox_filters.Name = "groupBox_filters";
            this.groupBox_filters.Size = new System.Drawing.Size(271, 125);
            this.groupBox_filters.TabIndex = 3;
            this.groupBox_filters.TabStop = false;
            this.groupBox_filters.Text = "Filters";
            // 
            // label_maxDay
            // 
            this.label_maxDay.AutoSize = true;
            this.label_maxDay.Location = new System.Drawing.Point(131, 102);
            this.label_maxDay.Name = "label_maxDay";
            this.label_maxDay.Size = new System.Drawing.Size(27, 13);
            this.label_maxDay.TabIndex = 0;
            this.label_maxDay.Text = "Max";
            // 
            // label_minDay
            // 
            this.label_minDay.AutoSize = true;
            this.label_minDay.Location = new System.Drawing.Point(76, 102);
            this.label_minDay.Name = "label_minDay";
            this.label_minDay.Size = new System.Drawing.Size(24, 13);
            this.label_minDay.TabIndex = 0;
            this.label_minDay.Text = "Min";
            // 
            // label_filterDay
            // 
            this.label_filterDay.AutoSize = true;
            this.label_filterDay.Location = new System.Drawing.Point(9, 81);
            this.label_filterDay.Name = "label_filterDay";
            this.label_filterDay.Size = new System.Drawing.Size(29, 13);
            this.label_filterDay.TabIndex = 0;
            this.label_filterDay.Text = "Day:";
            // 
            // numericUpDown_maxDay
            // 
            this.numericUpDown_maxDay.Location = new System.Drawing.Point(121, 79);
            this.numericUpDown_maxDay.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.numericUpDown_maxDay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_maxDay.Name = "numericUpDown_maxDay";
            this.numericUpDown_maxDay.Size = new System.Drawing.Size(46, 20);
            this.numericUpDown_maxDay.TabIndex = 15;
            this.numericUpDown_maxDay.Value = new decimal(new int[] {
            31,
            0,
            0,
            0});
            // 
            // numericUpDown_minDay
            // 
            this.numericUpDown_minDay.Location = new System.Drawing.Point(69, 79);
            this.numericUpDown_minDay.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.numericUpDown_minDay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_minDay.Name = "numericUpDown_minDay";
            this.numericUpDown_minDay.Size = new System.Drawing.Size(46, 20);
            this.numericUpDown_minDay.TabIndex = 14;
            this.numericUpDown_minDay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label_filterMonth
            // 
            this.label_filterMonth.AutoSize = true;
            this.label_filterMonth.Location = new System.Drawing.Point(7, 50);
            this.label_filterMonth.Name = "label_filterMonth";
            this.label_filterMonth.Size = new System.Drawing.Size(40, 13);
            this.label_filterMonth.TabIndex = 0;
            this.label_filterMonth.Text = "Month:";
            // 
            // label_filterWeekday
            // 
            this.label_filterWeekday.AutoSize = true;
            this.label_filterWeekday.Location = new System.Drawing.Point(7, 20);
            this.label_filterWeekday.Name = "label_filterWeekday";
            this.label_filterWeekday.Size = new System.Drawing.Size(56, 13);
            this.label_filterWeekday.TabIndex = 0;
            this.label_filterWeekday.Text = "Weekday:";
            // 
            // comboBox_filterMonth
            // 
            this.comboBox_filterMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_filterMonth.FormattingEnabled = true;
            this.comboBox_filterMonth.Items.AddRange(new object[] {
            "All",
            "Q1",
            "Q2",
            "Q3",
            "Q4",
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.comboBox_filterMonth.Location = new System.Drawing.Point(69, 47);
            this.comboBox_filterMonth.Name = "comboBox_filterMonth";
            this.comboBox_filterMonth.Size = new System.Drawing.Size(98, 21);
            this.comboBox_filterMonth.TabIndex = 13;
            // 
            // comboBox_filterWeekday
            // 
            this.comboBox_filterWeekday.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_filterWeekday.FormattingEnabled = true;
            this.comboBox_filterWeekday.Items.AddRange(new object[] {
            "All",
            "Week",
            "Weekend",
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"});
            this.comboBox_filterWeekday.Location = new System.Drawing.Point(69, 17);
            this.comboBox_filterWeekday.Name = "comboBox_filterWeekday";
            this.comboBox_filterWeekday.Size = new System.Drawing.Size(98, 21);
            this.comboBox_filterWeekday.TabIndex = 12;
            // 
            // button_format
            // 
            this.button_format.Location = new System.Drawing.Point(17, 402);
            this.button_format.Name = "button_format";
            this.button_format.Size = new System.Drawing.Size(95, 23);
            this.button_format.TabIndex = 16;
            this.button_format.Text = "Date format...";
            this.button_format.UseVisualStyleBackColor = true;
            this.button_format.Click += new System.EventHandler(this.button_format_Click);
            // 
            // button_generate
            // 
            this.button_generate.Location = new System.Drawing.Point(17, 431);
            this.button_generate.Name = "button_generate";
            this.button_generate.Size = new System.Drawing.Size(266, 28);
            this.button_generate.TabIndex = 19;
            this.button_generate.Text = "Generate";
            this.button_generate.UseVisualStyleBackColor = true;
            this.button_generate.Click += new System.EventHandler(this.button_generate_Click);
            // 
            // button_saveOutput
            // 
            this.button_saveOutput.Location = new System.Drawing.Point(118, 402);
            this.button_saveOutput.Name = "button_saveOutput";
            this.button_saveOutput.Size = new System.Drawing.Size(75, 23);
            this.button_saveOutput.TabIndex = 17;
            this.button_saveOutput.Text = "Save output";
            this.button_saveOutput.UseVisualStyleBackColor = true;
            this.button_saveOutput.Click += new System.EventHandler(this.button_saveOutput_Click);
            // 
            // button_saveSettings
            // 
            this.button_saveSettings.Location = new System.Drawing.Point(199, 402);
            this.button_saveSettings.Name = "button_saveSettings";
            this.button_saveSettings.Size = new System.Drawing.Size(84, 23);
            this.button_saveSettings.TabIndex = 18;
            this.button_saveSettings.Text = "Save settings";
            this.button_saveSettings.UseVisualStyleBackColor = true;
            this.button_saveSettings.Click += new System.EventHandler(this.button_saveSettings_Click);
            // 
            // richTextBox_output
            // 
            this.richTextBox_output.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox_output.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_output.Location = new System.Drawing.Point(289, 32);
            this.richTextBox_output.Name = "richTextBox_output";
            this.richTextBox_output.ReadOnly = true;
            this.richTextBox_output.Size = new System.Drawing.Size(323, 429);
            this.richTextBox_output.TabIndex = 20;
            this.richTextBox_output.Text = "";
            // 
            // label_output
            // 
            this.label_output.AutoSize = true;
            this.label_output.Location = new System.Drawing.Point(290, 13);
            this.label_output.Name = "label_output";
            this.label_output.Size = new System.Drawing.Size(42, 13);
            this.label_output.TabIndex = 6;
            this.label_output.Text = "Output:";
            // 
            // Form1
            // 
            this.AcceptButton = this.button_generate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 473);
            this.Controls.Add(this.label_output);
            this.Controls.Add(this.richTextBox_output);
            this.Controls.Add(this.button_saveSettings);
            this.Controls.Add(this.button_saveOutput);
            this.Controls.Add(this.button_generate);
            this.Controls.Add(this.button_format);
            this.Controls.Add(this.groupBox_filters);
            this.Controls.Add(this.groupBox_dates);
            this.Controls.Add(this.radioButton_generateOrder);
            this.Controls.Add(this.radioButton_generateRandom);
            this.Controls.Add(this.radioButton_generateSome);
            this.Controls.Add(this.groupBox_range);
            this.MinimumSize = new System.Drawing.Size(640, 512);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Date List Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox_range.ResumeLayout(false);
            this.groupBox_range.PerformLayout();
            this.groupBox_dates.ResumeLayout(false);
            this.groupBox_dates.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_numDates)).EndInit();
            this.groupBox_filters.ResumeLayout(false);
            this.groupBox_filters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_maxDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_minDay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_range;
        private System.Windows.Forms.Label label_end;
        private System.Windows.Forms.Label label_year;
        private System.Windows.Forms.Label label_start;
        private System.Windows.Forms.TextBox textBox_startYear;
        private System.Windows.Forms.ComboBox comboBox_startDay;
        private System.Windows.Forms.ComboBox comboBox_startMonth;
        private System.Windows.Forms.Label label_month;
        private System.Windows.Forms.ComboBox comboBox_endDay;
        private System.Windows.Forms.ComboBox comboBox_endMonth;
        private System.Windows.Forms.Label label_day;
        private System.Windows.Forms.TextBox textBox_endYear;
        private System.Windows.Forms.RadioButton radioButton_generateSome;
        private System.Windows.Forms.RadioButton radioButton_generateRandom;
        private System.Windows.Forms.RadioButton radioButton_generateOrder;
        private System.Windows.Forms.GroupBox groupBox_dates;
        private System.Windows.Forms.CheckBox checkBox_duplicates;
        private System.Windows.Forms.NumericUpDown numericUpDown_numDates;
        private System.Windows.Forms.Label label_numDates;
        private System.Windows.Forms.GroupBox groupBox_filters;
        private System.Windows.Forms.Label label_maxDay;
        private System.Windows.Forms.Label label_minDay;
        private System.Windows.Forms.Label label_filterDay;
        private System.Windows.Forms.NumericUpDown numericUpDown_maxDay;
        private System.Windows.Forms.NumericUpDown numericUpDown_minDay;
        private System.Windows.Forms.Label label_filterMonth;
        private System.Windows.Forms.Label label_filterWeekday;
        private System.Windows.Forms.ComboBox comboBox_filterMonth;
        private System.Windows.Forms.ComboBox comboBox_filterWeekday;
        private System.Windows.Forms.Button button_format;
        private System.Windows.Forms.Button button_generate;
        private System.Windows.Forms.Button button_saveOutput;
        private System.Windows.Forms.Button button_saveSettings;
        private System.Windows.Forms.RichTextBox richTextBox_output;
        private System.Windows.Forms.Label label_output;
    }
}

