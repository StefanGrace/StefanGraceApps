namespace ExtendedClock
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericUpDown_custom = new System.Windows.Forms.NumericUpDown();
            this.radioButton_custom = new System.Windows.Forms.RadioButton();
            this.radioButton_48hour = new System.Windows.Forms.RadioButton();
            this.radioButton_36hour = new System.Windows.Forms.RadioButton();
            this.radioButton_30hour = new System.Windows.Forms.RadioButton();
            this.radioButton_24hour = new System.Windows.Forms.RadioButton();
            this.radioButton_12hour = new System.Windows.Forms.RadioButton();
            this.radioButton_6hour = new System.Windows.Forms.RadioButton();
            this.comboBox_mode = new System.Windows.Forms.ComboBox();
            this.label_time = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.comboBox_hour = new System.Windows.Forms.ComboBox();
            this.checkBox_seconds = new System.Windows.Forms.CheckBox();
            this.checkBox_timeInTitle = new System.Windows.Forms.CheckBox();
            this.comboBox_minute = new System.Windows.Forms.ComboBox();
            this.label_hourMinuteColon = new System.Windows.Forms.Label();
            this.label_minuteSecondColon = new System.Windows.Forms.Label();
            this.comboBox_second = new System.Windows.Forms.ComboBox();
            this.comboBox_meridian = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_custom)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDown_custom);
            this.groupBox1.Controls.Add(this.radioButton_custom);
            this.groupBox1.Controls.Add(this.radioButton_48hour);
            this.groupBox1.Controls.Add(this.radioButton_36hour);
            this.groupBox1.Controls.Add(this.radioButton_30hour);
            this.groupBox1.Controls.Add(this.radioButton_24hour);
            this.groupBox1.Controls.Add(this.radioButton_12hour);
            this.groupBox1.Controls.Add(this.radioButton_6hour);
            this.groupBox1.Location = new System.Drawing.Point(25, 148);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(435, 79);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Display format:";
            // 
            // numericUpDown_custom
            // 
            this.numericUpDown_custom.Location = new System.Drawing.Point(77, 44);
            this.numericUpDown_custom.Maximum = new decimal(new int[] {
            48,
            0,
            0,
            0});
            this.numericUpDown_custom.Minimum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.numericUpDown_custom.Name = "numericUpDown_custom";
            this.numericUpDown_custom.Size = new System.Drawing.Size(56, 20);
            this.numericUpDown_custom.TabIndex = 1;
            this.numericUpDown_custom.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.numericUpDown_custom.ValueChanged += new System.EventHandler(this.numericUpDown_custom_ValueChanged);
            // 
            // radioButton_custom
            // 
            this.radioButton_custom.AutoSize = true;
            this.radioButton_custom.Location = new System.Drawing.Point(7, 43);
            this.radioButton_custom.Name = "radioButton_custom";
            this.radioButton_custom.Size = new System.Drawing.Size(63, 17);
            this.radioButton_custom.TabIndex = 0;
            this.radioButton_custom.Text = "Custom:";
            this.radioButton_custom.UseVisualStyleBackColor = true;
            // 
            // radioButton_48hour
            // 
            this.radioButton_48hour.AutoSize = true;
            this.radioButton_48hour.Location = new System.Drawing.Point(311, 20);
            this.radioButton_48hour.Name = "radioButton_48hour";
            this.radioButton_48hour.Size = new System.Drawing.Size(61, 17);
            this.radioButton_48hour.TabIndex = 0;
            this.radioButton_48hour.Text = "48-hour";
            this.radioButton_48hour.UseVisualStyleBackColor = true;
            // 
            // radioButton_36hour
            // 
            this.radioButton_36hour.AutoSize = true;
            this.radioButton_36hour.Location = new System.Drawing.Point(244, 20);
            this.radioButton_36hour.Name = "radioButton_36hour";
            this.radioButton_36hour.Size = new System.Drawing.Size(61, 17);
            this.radioButton_36hour.TabIndex = 0;
            this.radioButton_36hour.Text = "36-hour";
            this.radioButton_36hour.UseVisualStyleBackColor = true;
            // 
            // radioButton_30hour
            // 
            this.radioButton_30hour.AutoSize = true;
            this.radioButton_30hour.Location = new System.Drawing.Point(184, 20);
            this.radioButton_30hour.Name = "radioButton_30hour";
            this.radioButton_30hour.Size = new System.Drawing.Size(61, 17);
            this.radioButton_30hour.TabIndex = 0;
            this.radioButton_30hour.Text = "30-hour";
            this.radioButton_30hour.UseVisualStyleBackColor = true;
            // 
            // radioButton_24hour
            // 
            this.radioButton_24hour.AutoSize = true;
            this.radioButton_24hour.Location = new System.Drawing.Point(123, 20);
            this.radioButton_24hour.Name = "radioButton_24hour";
            this.radioButton_24hour.Size = new System.Drawing.Size(61, 17);
            this.radioButton_24hour.TabIndex = 0;
            this.radioButton_24hour.Text = "24-hour";
            this.radioButton_24hour.UseVisualStyleBackColor = true;
            // 
            // radioButton_12hour
            // 
            this.radioButton_12hour.AutoSize = true;
            this.radioButton_12hour.Location = new System.Drawing.Point(62, 20);
            this.radioButton_12hour.Name = "radioButton_12hour";
            this.radioButton_12hour.Size = new System.Drawing.Size(61, 17);
            this.radioButton_12hour.TabIndex = 0;
            this.radioButton_12hour.Text = "12-hour";
            this.radioButton_12hour.UseVisualStyleBackColor = true;
            // 
            // radioButton_6hour
            // 
            this.radioButton_6hour.AutoSize = true;
            this.radioButton_6hour.Location = new System.Drawing.Point(7, 20);
            this.radioButton_6hour.Name = "radioButton_6hour";
            this.radioButton_6hour.Size = new System.Drawing.Size(55, 17);
            this.radioButton_6hour.TabIndex = 0;
            this.radioButton_6hour.Text = "6-hour";
            this.radioButton_6hour.UseVisualStyleBackColor = true;
            // 
            // comboBox_mode
            // 
            this.comboBox_mode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_mode.FormattingEnabled = true;
            this.comboBox_mode.Items.AddRange(new object[] {
            "Display current time",
            "Convert from 6-hour",
            "Convert from 12-hour",
            "Convert from 24-hour",
            "Convert from 30-hour",
            "Convert from 36-hour",
            "Convert from 48-hour"});
            this.comboBox_mode.Location = new System.Drawing.Point(12, 12);
            this.comboBox_mode.Name = "comboBox_mode";
            this.comboBox_mode.Size = new System.Drawing.Size(146, 21);
            this.comboBox_mode.TabIndex = 1;
            this.comboBox_mode.SelectedIndexChanged += new System.EventHandler(this.comboBox_mode_SelectedIndexChanged);
            // 
            // label_time
            // 
            this.label_time.AutoSize = true;
            this.label_time.Font = new System.Drawing.Font("Arial", 26.25F);
            this.label_time.Location = new System.Drawing.Point(206, 73);
            this.label_time.Name = "label_time";
            this.label_time.Size = new System.Drawing.Size(91, 40);
            this.label_time.TabIndex = 2;
            this.label_time.Text = "Time";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 50;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // comboBox_hour
            // 
            this.comboBox_hour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_hour.FormattingEnabled = true;
            this.comboBox_hour.Location = new System.Drawing.Point(179, 12);
            this.comboBox_hour.Name = "comboBox_hour";
            this.comboBox_hour.Size = new System.Drawing.Size(54, 21);
            this.comboBox_hour.TabIndex = 3;
            // 
            // checkBox_seconds
            // 
            this.checkBox_seconds.AutoSize = true;
            this.checkBox_seconds.Location = new System.Drawing.Point(25, 233);
            this.checkBox_seconds.Name = "checkBox_seconds";
            this.checkBox_seconds.Size = new System.Drawing.Size(68, 17);
            this.checkBox_seconds.TabIndex = 4;
            this.checkBox_seconds.Text = "Seconds";
            this.checkBox_seconds.UseVisualStyleBackColor = true;
            this.checkBox_seconds.CheckedChanged += new System.EventHandler(this.checkBox_seconds_CheckedChanged);
            // 
            // checkBox_timeInTitle
            // 
            this.checkBox_timeInTitle.AutoSize = true;
            this.checkBox_timeInTitle.Location = new System.Drawing.Point(99, 233);
            this.checkBox_timeInTitle.Name = "checkBox_timeInTitle";
            this.checkBox_timeInTitle.Size = new System.Drawing.Size(123, 17);
            this.checkBox_timeInTitle.TabIndex = 4;
            this.checkBox_timeInTitle.Text = "Show time in title bar";
            this.checkBox_timeInTitle.UseVisualStyleBackColor = true;
            this.checkBox_timeInTitle.CheckedChanged += new System.EventHandler(this.checkBox_timeInTitle_CheckedChanged);
            // 
            // comboBox_minute
            // 
            this.comboBox_minute.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_minute.FormattingEnabled = true;
            this.comboBox_minute.Location = new System.Drawing.Point(248, 12);
            this.comboBox_minute.Name = "comboBox_minute";
            this.comboBox_minute.Size = new System.Drawing.Size(54, 21);
            this.comboBox_minute.TabIndex = 3;
            // 
            // label_hourMinuteColon
            // 
            this.label_hourMinuteColon.AutoSize = true;
            this.label_hourMinuteColon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_hourMinuteColon.Location = new System.Drawing.Point(235, 14);
            this.label_hourMinuteColon.Name = "label_hourMinuteColon";
            this.label_hourMinuteColon.Size = new System.Drawing.Size(11, 16);
            this.label_hourMinuteColon.TabIndex = 5;
            this.label_hourMinuteColon.Text = ":";
            // 
            // label_minuteSecondColon
            // 
            this.label_minuteSecondColon.AutoSize = true;
            this.label_minuteSecondColon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_minuteSecondColon.Location = new System.Drawing.Point(305, 14);
            this.label_minuteSecondColon.Name = "label_minuteSecondColon";
            this.label_minuteSecondColon.Size = new System.Drawing.Size(11, 16);
            this.label_minuteSecondColon.TabIndex = 5;
            this.label_minuteSecondColon.Text = ":";
            // 
            // comboBox_second
            // 
            this.comboBox_second.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_second.FormattingEnabled = true;
            this.comboBox_second.Location = new System.Drawing.Point(317, 12);
            this.comboBox_second.Name = "comboBox_second";
            this.comboBox_second.Size = new System.Drawing.Size(54, 21);
            this.comboBox_second.TabIndex = 3;
            // 
            // comboBox_meridian
            // 
            this.comboBox_meridian.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_meridian.FormattingEnabled = true;
            this.comboBox_meridian.Location = new System.Drawing.Point(392, 12);
            this.comboBox_meridian.Name = "comboBox_meridian";
            this.comboBox_meridian.Size = new System.Drawing.Size(120, 21);
            this.comboBox_meridian.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 261);
            this.Controls.Add(this.label_minuteSecondColon);
            this.Controls.Add(this.label_hourMinuteColon);
            this.Controls.Add(this.checkBox_timeInTitle);
            this.Controls.Add(this.checkBox_seconds);
            this.Controls.Add(this.comboBox_meridian);
            this.Controls.Add(this.comboBox_second);
            this.Controls.Add(this.comboBox_minute);
            this.Controls.Add(this.comboBox_hour);
            this.Controls.Add(this.label_time);
            this.Controls.Add(this.comboBox_mode);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Extended 24-hour Clock";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_custom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox_mode;
        private System.Windows.Forms.RadioButton radioButton_48hour;
        private System.Windows.Forms.RadioButton radioButton_36hour;
        private System.Windows.Forms.RadioButton radioButton_30hour;
        private System.Windows.Forms.RadioButton radioButton_24hour;
        private System.Windows.Forms.RadioButton radioButton_12hour;
        private System.Windows.Forms.RadioButton radioButton_6hour;
        private System.Windows.Forms.Label label_time;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.NumericUpDown numericUpDown_custom;
        private System.Windows.Forms.RadioButton radioButton_custom;
        private System.Windows.Forms.ComboBox comboBox_hour;
        private System.Windows.Forms.CheckBox checkBox_seconds;
        private System.Windows.Forms.CheckBox checkBox_timeInTitle;
        private System.Windows.Forms.ComboBox comboBox_minute;
        private System.Windows.Forms.Label label_hourMinuteColon;
        private System.Windows.Forms.Label label_minuteSecondColon;
        private System.Windows.Forms.ComboBox comboBox_second;
        private System.Windows.Forms.ComboBox comboBox_meridian;
    }
}

