namespace DataTransferTime
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
            this.textBox_dataTrasferRate = new System.Windows.Forms.TextBox();
            this.comboBox_dataRatePrefix = new System.Windows.Forms.ComboBox();
            this.comboBox_dataRateUnit = new System.Windows.Forms.ComboBox();
            this.comboBox_dataRateTime = new System.Windows.Forms.ComboBox();
            this.label_dataRateSlash = new System.Windows.Forms.Label();
            this.groupBox_dataRate = new System.Windows.Forms.GroupBox();
            this.textBox_dataTotal = new System.Windows.Forms.TextBox();
            this.comboBox_dataTotalUnit = new System.Windows.Forms.ComboBox();
            this.comboBox_dataTotalPrefix = new System.Windows.Forms.ComboBox();
            this.groupBox_dataTotal = new System.Windows.Forms.GroupBox();
            this.label_outputTime = new System.Windows.Forms.Label();
            this.label_outputTimeFormat = new System.Windows.Forms.Label();
            this.comboBox_outputTimeFormat = new System.Windows.Forms.ComboBox();
            this.groupBox_startDateTime = new System.Windows.Forms.GroupBox();
            this.label_startYear = new System.Windows.Forms.Label();
            this.label_startMonth = new System.Windows.Forms.Label();
            this.label_startDay = new System.Windows.Forms.Label();
            this.label_startHour = new System.Windows.Forms.Label();
            this.label_startMinute = new System.Windows.Forms.Label();
            this.numericUpDown_startYear = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_startMinute = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_startHour = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_startDay = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_startMonth = new System.Windows.Forms.NumericUpDown();
            this.label_outputDateTime = new System.Windows.Forms.Label();
            this.label_finishDateTime = new System.Windows.Forms.Label();
            this.groupBox_dataRate.SuspendLayout();
            this.groupBox_dataTotal.SuspendLayout();
            this.groupBox_startDateTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_startYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_startMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_startHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_startDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_startMonth)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_dataTrasferRate
            // 
            this.textBox_dataTrasferRate.Location = new System.Drawing.Point(6, 19);
            this.textBox_dataTrasferRate.MaxLength = 12;
            this.textBox_dataTrasferRate.Name = "textBox_dataTrasferRate";
            this.textBox_dataTrasferRate.Size = new System.Drawing.Size(82, 20);
            this.textBox_dataTrasferRate.TabIndex = 4;
            this.textBox_dataTrasferRate.TextChanged += new System.EventHandler(this.InputUpdated);
            // 
            // comboBox_dataRatePrefix
            // 
            this.comboBox_dataRatePrefix.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_dataRatePrefix.FormattingEnabled = true;
            this.comboBox_dataRatePrefix.Items.AddRange(new object[] {
            "",
            "k",
            "Ki",
            "M",
            "Mi",
            "G",
            "Gi",
            "T",
            "Ti",
            "P",
            "Pi",
            "E",
            "Ei",
            "Z",
            "Zi",
            "Y",
            "Yi",
            "R",
            "Ri",
            "Q",
            "Qi"});
            this.comboBox_dataRatePrefix.Location = new System.Drawing.Point(94, 18);
            this.comboBox_dataRatePrefix.Name = "comboBox_dataRatePrefix";
            this.comboBox_dataRatePrefix.Size = new System.Drawing.Size(34, 21);
            this.comboBox_dataRatePrefix.TabIndex = 5;
            this.comboBox_dataRatePrefix.SelectedValueChanged += new System.EventHandler(this.InputUpdated);
            // 
            // comboBox_dataRateUnit
            // 
            this.comboBox_dataRateUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_dataRateUnit.FormattingEnabled = true;
            this.comboBox_dataRateUnit.Items.AddRange(new object[] {
            "b",
            "B"});
            this.comboBox_dataRateUnit.Location = new System.Drawing.Point(134, 18);
            this.comboBox_dataRateUnit.Name = "comboBox_dataRateUnit";
            this.comboBox_dataRateUnit.Size = new System.Drawing.Size(34, 21);
            this.comboBox_dataRateUnit.TabIndex = 6;
            this.comboBox_dataRateUnit.SelectedValueChanged += new System.EventHandler(this.InputUpdated);
            // 
            // comboBox_dataRateTime
            // 
            this.comboBox_dataRateTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_dataRateTime.FormattingEnabled = true;
            this.comboBox_dataRateTime.Items.AddRange(new object[] {
            "ms",
            "s",
            "min",
            "h",
            "day",
            "year"});
            this.comboBox_dataRateTime.Location = new System.Drawing.Point(192, 18);
            this.comboBox_dataRateTime.Name = "comboBox_dataRateTime";
            this.comboBox_dataRateTime.Size = new System.Drawing.Size(57, 21);
            this.comboBox_dataRateTime.TabIndex = 7;
            this.comboBox_dataRateTime.SelectedValueChanged += new System.EventHandler(this.InputUpdated);
            // 
            // label_dataRateSlash
            // 
            this.label_dataRateSlash.AutoSize = true;
            this.label_dataRateSlash.Location = new System.Drawing.Point(174, 22);
            this.label_dataRateSlash.Name = "label_dataRateSlash";
            this.label_dataRateSlash.Size = new System.Drawing.Size(12, 13);
            this.label_dataRateSlash.TabIndex = 2;
            this.label_dataRateSlash.Text = "/";
            // 
            // groupBox_dataRate
            // 
            this.groupBox_dataRate.Controls.Add(this.textBox_dataTrasferRate);
            this.groupBox_dataRate.Controls.Add(this.label_dataRateSlash);
            this.groupBox_dataRate.Controls.Add(this.comboBox_dataRatePrefix);
            this.groupBox_dataRate.Controls.Add(this.comboBox_dataRateTime);
            this.groupBox_dataRate.Controls.Add(this.comboBox_dataRateUnit);
            this.groupBox_dataRate.Location = new System.Drawing.Point(12, 74);
            this.groupBox_dataRate.Name = "groupBox_dataRate";
            this.groupBox_dataRate.Size = new System.Drawing.Size(260, 56);
            this.groupBox_dataRate.TabIndex = 1;
            this.groupBox_dataRate.TabStop = false;
            this.groupBox_dataRate.Text = "Data transfer rate";
            // 
            // textBox_dataTotal
            // 
            this.textBox_dataTotal.Location = new System.Drawing.Point(6, 19);
            this.textBox_dataTotal.MaxLength = 12;
            this.textBox_dataTotal.Name = "textBox_dataTotal";
            this.textBox_dataTotal.Size = new System.Drawing.Size(82, 20);
            this.textBox_dataTotal.TabIndex = 1;
            this.textBox_dataTotal.TextChanged += new System.EventHandler(this.InputUpdated);
            // 
            // comboBox_dataTotalUnit
            // 
            this.comboBox_dataTotalUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_dataTotalUnit.FormattingEnabled = true;
            this.comboBox_dataTotalUnit.Items.AddRange(new object[] {
            "b",
            "B"});
            this.comboBox_dataTotalUnit.Location = new System.Drawing.Point(134, 19);
            this.comboBox_dataTotalUnit.Name = "comboBox_dataTotalUnit";
            this.comboBox_dataTotalUnit.Size = new System.Drawing.Size(34, 21);
            this.comboBox_dataTotalUnit.TabIndex = 3;
            this.comboBox_dataTotalUnit.SelectedValueChanged += new System.EventHandler(this.InputUpdated);
            // 
            // comboBox_dataTotalPrefix
            // 
            this.comboBox_dataTotalPrefix.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_dataTotalPrefix.FormattingEnabled = true;
            this.comboBox_dataTotalPrefix.Items.AddRange(new object[] {
            "",
            "k",
            "Ki",
            "M",
            "Mi",
            "G",
            "Gi",
            "T",
            "Ti",
            "P",
            "Pi",
            "E",
            "Ei",
            "Z",
            "Zi",
            "Y",
            "Yi",
            "R",
            "Ri",
            "Q",
            "Qi"});
            this.comboBox_dataTotalPrefix.Location = new System.Drawing.Point(94, 19);
            this.comboBox_dataTotalPrefix.Name = "comboBox_dataTotalPrefix";
            this.comboBox_dataTotalPrefix.Size = new System.Drawing.Size(34, 21);
            this.comboBox_dataTotalPrefix.TabIndex = 2;
            this.comboBox_dataTotalPrefix.SelectedValueChanged += new System.EventHandler(this.InputUpdated);
            // 
            // groupBox_dataTotal
            // 
            this.groupBox_dataTotal.Controls.Add(this.textBox_dataTotal);
            this.groupBox_dataTotal.Controls.Add(this.comboBox_dataTotalUnit);
            this.groupBox_dataTotal.Controls.Add(this.comboBox_dataTotalPrefix);
            this.groupBox_dataTotal.Location = new System.Drawing.Point(12, 12);
            this.groupBox_dataTotal.Name = "groupBox_dataTotal";
            this.groupBox_dataTotal.Size = new System.Drawing.Size(187, 52);
            this.groupBox_dataTotal.TabIndex = 0;
            this.groupBox_dataTotal.TabStop = false;
            this.groupBox_dataTotal.Text = "Total data to trasfer";
            // 
            // label_outputTime
            // 
            this.label_outputTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_outputTime.Location = new System.Drawing.Point(11, 165);
            this.label_outputTime.Name = "label_outputTime";
            this.label_outputTime.Size = new System.Drawing.Size(260, 72);
            this.label_outputTime.TabIndex = 6;
            this.label_outputTime.Text = "Time";
            this.label_outputTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_outputTimeFormat
            // 
            this.label_outputTimeFormat.AutoSize = true;
            this.label_outputTimeFormat.Location = new System.Drawing.Point(13, 144);
            this.label_outputTimeFormat.Name = "label_outputTimeFormat";
            this.label_outputTimeFormat.Size = new System.Drawing.Size(96, 13);
            this.label_outputTimeFormat.TabIndex = 7;
            this.label_outputTimeFormat.Text = "Output time format:";
            // 
            // comboBox_outputTimeFormat
            // 
            this.comboBox_outputTimeFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_outputTimeFormat.FormattingEnabled = true;
            this.comboBox_outputTimeFormat.Items.AddRange(new object[] {
            "[[year] day] h:min:s.ms",
            "[day] h:min:s.ms",
            "h:min:s.ms",
            "unit + subunit",
            "unit + decimal",
            "ms",
            "s",
            "min",
            "h",
            "day",
            "year"});
            this.comboBox_outputTimeFormat.Location = new System.Drawing.Point(115, 141);
            this.comboBox_outputTimeFormat.Name = "comboBox_outputTimeFormat";
            this.comboBox_outputTimeFormat.Size = new System.Drawing.Size(151, 21);
            this.comboBox_outputTimeFormat.TabIndex = 8;
            this.comboBox_outputTimeFormat.SelectedIndexChanged += new System.EventHandler(this.OutputTimeFormatChanged);
            // 
            // groupBox_startDateTime
            // 
            this.groupBox_startDateTime.Controls.Add(this.label_startYear);
            this.groupBox_startDateTime.Controls.Add(this.label_startMonth);
            this.groupBox_startDateTime.Controls.Add(this.label_startDay);
            this.groupBox_startDateTime.Controls.Add(this.label_startHour);
            this.groupBox_startDateTime.Controls.Add(this.label_startMinute);
            this.groupBox_startDateTime.Controls.Add(this.numericUpDown_startYear);
            this.groupBox_startDateTime.Controls.Add(this.numericUpDown_startMinute);
            this.groupBox_startDateTime.Controls.Add(this.numericUpDown_startHour);
            this.groupBox_startDateTime.Controls.Add(this.numericUpDown_startDay);
            this.groupBox_startDateTime.Controls.Add(this.numericUpDown_startMonth);
            this.groupBox_startDateTime.Location = new System.Drawing.Point(11, 240);
            this.groupBox_startDateTime.Name = "groupBox_startDateTime";
            this.groupBox_startDateTime.Size = new System.Drawing.Size(254, 70);
            this.groupBox_startDateTime.TabIndex = 9;
            this.groupBox_startDateTime.TabStop = false;
            this.groupBox_startDateTime.Text = "Start date/time";
            // 
            // label_startYear
            // 
            this.label_startYear.Location = new System.Drawing.Point(3, 42);
            this.label_startYear.Name = "label_startYear";
            this.label_startYear.Size = new System.Drawing.Size(53, 13);
            this.label_startYear.TabIndex = 1;
            this.label_startYear.Text = "year";
            this.label_startYear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_startMonth
            // 
            this.label_startMonth.Location = new System.Drawing.Point(62, 42);
            this.label_startMonth.Name = "label_startMonth";
            this.label_startMonth.Size = new System.Drawing.Size(36, 13);
            this.label_startMonth.TabIndex = 1;
            this.label_startMonth.Text = "month";
            this.label_startMonth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_startDay
            // 
            this.label_startDay.Location = new System.Drawing.Point(104, 42);
            this.label_startDay.Name = "label_startDay";
            this.label_startDay.Size = new System.Drawing.Size(36, 13);
            this.label_startDay.TabIndex = 1;
            this.label_startDay.Text = "day";
            this.label_startDay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_startHour
            // 
            this.label_startHour.Location = new System.Drawing.Point(170, 42);
            this.label_startHour.Name = "label_startHour";
            this.label_startHour.Size = new System.Drawing.Size(36, 13);
            this.label_startHour.TabIndex = 1;
            this.label_startHour.Text = "hour";
            this.label_startHour.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_startMinute
            // 
            this.label_startMinute.Location = new System.Drawing.Point(212, 42);
            this.label_startMinute.Name = "label_startMinute";
            this.label_startMinute.Size = new System.Drawing.Size(36, 13);
            this.label_startMinute.TabIndex = 1;
            this.label_startMinute.Text = "min";
            this.label_startMinute.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericUpDown_startYear
            // 
            this.numericUpDown_startYear.Location = new System.Drawing.Point(6, 19);
            this.numericUpDown_startYear.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDown_startYear.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_startYear.Name = "numericUpDown_startYear";
            this.numericUpDown_startYear.Size = new System.Drawing.Size(50, 20);
            this.numericUpDown_startYear.TabIndex = 0;
            this.numericUpDown_startYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown_startYear.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_startYear.ValueChanged += new System.EventHandler(this.StartYearOrMonthChanged);
            // 
            // numericUpDown_startMinute
            // 
            this.numericUpDown_startMinute.Location = new System.Drawing.Point(212, 19);
            this.numericUpDown_startMinute.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericUpDown_startMinute.Name = "numericUpDown_startMinute";
            this.numericUpDown_startMinute.Size = new System.Drawing.Size(36, 20);
            this.numericUpDown_startMinute.TabIndex = 4;
            this.numericUpDown_startMinute.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown_startMinute.ValueChanged += new System.EventHandler(this.StartDateChanged);
            // 
            // numericUpDown_startHour
            // 
            this.numericUpDown_startHour.Location = new System.Drawing.Point(170, 19);
            this.numericUpDown_startHour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numericUpDown_startHour.Name = "numericUpDown_startHour";
            this.numericUpDown_startHour.Size = new System.Drawing.Size(36, 20);
            this.numericUpDown_startHour.TabIndex = 3;
            this.numericUpDown_startHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown_startHour.ValueChanged += new System.EventHandler(this.StartDateChanged);
            // 
            // numericUpDown_startDay
            // 
            this.numericUpDown_startDay.Location = new System.Drawing.Point(104, 19);
            this.numericUpDown_startDay.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.numericUpDown_startDay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_startDay.Name = "numericUpDown_startDay";
            this.numericUpDown_startDay.Size = new System.Drawing.Size(36, 20);
            this.numericUpDown_startDay.TabIndex = 2;
            this.numericUpDown_startDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown_startDay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_startDay.ValueChanged += new System.EventHandler(this.StartDateChanged);
            // 
            // numericUpDown_startMonth
            // 
            this.numericUpDown_startMonth.Location = new System.Drawing.Point(62, 19);
            this.numericUpDown_startMonth.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDown_startMonth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_startMonth.Name = "numericUpDown_startMonth";
            this.numericUpDown_startMonth.Size = new System.Drawing.Size(36, 20);
            this.numericUpDown_startMonth.TabIndex = 1;
            this.numericUpDown_startMonth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown_startMonth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_startMonth.ValueChanged += new System.EventHandler(this.StartYearOrMonthChanged);
            // 
            // label_outputDateTime
            // 
            this.label_outputDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_outputDateTime.Location = new System.Drawing.Point(6, 330);
            this.label_outputDateTime.Name = "label_outputDateTime";
            this.label_outputDateTime.Size = new System.Drawing.Size(260, 39);
            this.label_outputDateTime.TabIndex = 6;
            this.label_outputDateTime.Text = "Date/Time";
            this.label_outputDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_finishDateTime
            // 
            this.label_finishDateTime.AutoSize = true;
            this.label_finishDateTime.Location = new System.Drawing.Point(12, 317);
            this.label_finishDateTime.Name = "label_finishDateTime";
            this.label_finishDateTime.Size = new System.Drawing.Size(85, 13);
            this.label_finishDateTime.TabIndex = 10;
            this.label_finishDateTime.Text = "Finish date/time:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 385);
            this.Controls.Add(this.label_finishDateTime);
            this.Controls.Add(this.groupBox_startDateTime);
            this.Controls.Add(this.label_outputTimeFormat);
            this.Controls.Add(this.label_outputDateTime);
            this.Controls.Add(this.label_outputTime);
            this.Controls.Add(this.groupBox_dataTotal);
            this.Controls.Add(this.comboBox_outputTimeFormat);
            this.Controls.Add(this.groupBox_dataRate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data Transfer Time";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox_dataRate.ResumeLayout(false);
            this.groupBox_dataRate.PerformLayout();
            this.groupBox_dataTotal.ResumeLayout(false);
            this.groupBox_dataTotal.PerformLayout();
            this.groupBox_startDateTime.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_startYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_startMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_startHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_startDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_startMonth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_dataTrasferRate;
        private System.Windows.Forms.ComboBox comboBox_dataRatePrefix;
        private System.Windows.Forms.ComboBox comboBox_dataRateUnit;
        private System.Windows.Forms.ComboBox comboBox_dataRateTime;
        private System.Windows.Forms.Label label_dataRateSlash;
        private System.Windows.Forms.GroupBox groupBox_dataRate;
        private System.Windows.Forms.TextBox textBox_dataTotal;
        private System.Windows.Forms.ComboBox comboBox_dataTotalUnit;
        private System.Windows.Forms.ComboBox comboBox_dataTotalPrefix;
        private System.Windows.Forms.GroupBox groupBox_dataTotal;
        private System.Windows.Forms.Label label_outputTime;
        private System.Windows.Forms.Label label_outputTimeFormat;
        private System.Windows.Forms.ComboBox comboBox_outputTimeFormat;
        private System.Windows.Forms.GroupBox groupBox_startDateTime;
        private System.Windows.Forms.NumericUpDown numericUpDown_startMonth;
        private System.Windows.Forms.NumericUpDown numericUpDown_startYear;
        private System.Windows.Forms.NumericUpDown numericUpDown_startMinute;
        private System.Windows.Forms.NumericUpDown numericUpDown_startHour;
        private System.Windows.Forms.NumericUpDown numericUpDown_startDay;
        private System.Windows.Forms.Label label_startYear;
        private System.Windows.Forms.Label label_startMonth;
        private System.Windows.Forms.Label label_startDay;
        private System.Windows.Forms.Label label_startHour;
        private System.Windows.Forms.Label label_startMinute;
        private System.Windows.Forms.Label label_outputDateTime;
        private System.Windows.Forms.Label label_finishDateTime;
    }
}

