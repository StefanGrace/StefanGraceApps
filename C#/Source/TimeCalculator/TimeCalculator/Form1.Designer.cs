namespace TimeCalculator
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
            this.textBox_input1 = new System.Windows.Forms.TextBox();
            this.label_input1 = new System.Windows.Forms.Label();
            this.radioButton_displayDuration = new System.Windows.Forms.RadioButton();
            this.radioButton_addDurations = new System.Windows.Forms.RadioButton();
            this.radioButton_differenceBetweenDurations = new System.Windows.Forms.RadioButton();
            this.radioButton_durationTimesNumber = new System.Windows.Forms.RadioButton();
            this.radioButton_durationDividedByNumber = new System.Windows.Forms.RadioButton();
            this.radioButton_addDurationToDate = new System.Windows.Forms.RadioButton();
            this.radioButton_subtractDurationFromDate = new System.Windows.Forms.RadioButton();
            this.radioButton_differenceBetweenDates = new System.Windows.Forms.RadioButton();
            this.radioButton_addDurationToCurrentDate = new System.Windows.Forms.RadioButton();
            this.radioButton_subtractDurationFromCurrentDate = new System.Windows.Forms.RadioButton();
            this.radioButton_differenceBetweenDateAndCurrentDate = new System.Windows.Forms.RadioButton();
            this.label_input1Type = new System.Windows.Forms.Label();
            this.textBox_input2 = new System.Windows.Forms.TextBox();
            this.label_input2 = new System.Windows.Forms.Label();
            this.label_input2Type = new System.Windows.Forms.Label();
            this.label_ouputDurationFormat = new System.Windows.Forms.Label();
            this.comboBox_outputDurationFormat = new System.Windows.Forms.ComboBox();
            this.label_outputDateFormat = new System.Windows.Forms.Label();
            this.comboBox_outputDateFormat = new System.Windows.Forms.ComboBox();
            this.textBox_output = new System.Windows.Forms.TextBox();
            this.label_output = new System.Windows.Forms.Label();
            this.label_secondDecimalPlaces = new System.Windows.Forms.Label();
            this.numericUpDown_secondDecimalPlaces = new System.Windows.Forms.NumericUpDown();
            this.checkBox_years = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_secondDecimalPlaces)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_input1
            // 
            this.textBox_input1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_input1.Location = new System.Drawing.Point(70, 12);
            this.textBox_input1.Name = "textBox_input1";
            this.textBox_input1.Size = new System.Drawing.Size(273, 20);
            this.textBox_input1.TabIndex = 0;
            this.textBox_input1.TextChanged += new System.EventHandler(this.InputUpdated);
            // 
            // label_input1
            // 
            this.label_input1.AutoSize = true;
            this.label_input1.Location = new System.Drawing.Point(21, 15);
            this.label_input1.Name = "label_input1";
            this.label_input1.Size = new System.Drawing.Size(43, 13);
            this.label_input1.TabIndex = 1;
            this.label_input1.Text = "Input 1:";
            // 
            // radioButton_displayDuration
            // 
            this.radioButton_displayDuration.AutoSize = true;
            this.radioButton_displayDuration.Location = new System.Drawing.Point(24, 38);
            this.radioButton_displayDuration.Name = "radioButton_displayDuration";
            this.radioButton_displayDuration.Size = new System.Drawing.Size(100, 17);
            this.radioButton_displayDuration.TabIndex = 2;
            this.radioButton_displayDuration.Text = "Display duration";
            this.radioButton_displayDuration.UseVisualStyleBackColor = true;
            this.radioButton_displayDuration.CheckedChanged += new System.EventHandler(this.FunctionChanged);
            // 
            // radioButton_addDurations
            // 
            this.radioButton_addDurations.AutoSize = true;
            this.radioButton_addDurations.Checked = true;
            this.radioButton_addDurations.Location = new System.Drawing.Point(24, 61);
            this.radioButton_addDurations.Name = "radioButton_addDurations";
            this.radioButton_addDurations.Size = new System.Drawing.Size(90, 17);
            this.radioButton_addDurations.TabIndex = 2;
            this.radioButton_addDurations.TabStop = true;
            this.radioButton_addDurations.Text = "Add durations";
            this.radioButton_addDurations.UseVisualStyleBackColor = true;
            this.radioButton_addDurations.CheckedChanged += new System.EventHandler(this.FunctionChanged);
            // 
            // radioButton_differenceBetweenDurations
            // 
            this.radioButton_differenceBetweenDurations.AutoSize = true;
            this.radioButton_differenceBetweenDurations.Location = new System.Drawing.Point(24, 84);
            this.radioButton_differenceBetweenDurations.Name = "radioButton_differenceBetweenDurations";
            this.radioButton_differenceBetweenDurations.Size = new System.Drawing.Size(164, 17);
            this.radioButton_differenceBetweenDurations.TabIndex = 2;
            this.radioButton_differenceBetweenDurations.Text = "Difference between durations";
            this.radioButton_differenceBetweenDurations.UseVisualStyleBackColor = true;
            this.radioButton_differenceBetweenDurations.CheckedChanged += new System.EventHandler(this.FunctionChanged);
            // 
            // radioButton_durationTimesNumber
            // 
            this.radioButton_durationTimesNumber.AutoSize = true;
            this.radioButton_durationTimesNumber.Location = new System.Drawing.Point(24, 107);
            this.radioButton_durationTimesNumber.Name = "radioButton_durationTimesNumber";
            this.radioButton_durationTimesNumber.Size = new System.Drawing.Size(130, 17);
            this.radioButton_durationTimesNumber.TabIndex = 2;
            this.radioButton_durationTimesNumber.Text = "Duration times number";
            this.radioButton_durationTimesNumber.UseVisualStyleBackColor = true;
            this.radioButton_durationTimesNumber.CheckedChanged += new System.EventHandler(this.FunctionChanged);
            // 
            // radioButton_durationDividedByNumber
            // 
            this.radioButton_durationDividedByNumber.AutoSize = true;
            this.radioButton_durationDividedByNumber.Location = new System.Drawing.Point(24, 130);
            this.radioButton_durationDividedByNumber.Name = "radioButton_durationDividedByNumber";
            this.radioButton_durationDividedByNumber.Size = new System.Drawing.Size(154, 17);
            this.radioButton_durationDividedByNumber.TabIndex = 2;
            this.radioButton_durationDividedByNumber.Text = "Duration divided by number";
            this.radioButton_durationDividedByNumber.UseVisualStyleBackColor = true;
            this.radioButton_durationDividedByNumber.CheckedChanged += new System.EventHandler(this.FunctionChanged);
            // 
            // radioButton_addDurationToDate
            // 
            this.radioButton_addDurationToDate.AutoSize = true;
            this.radioButton_addDurationToDate.Location = new System.Drawing.Point(24, 153);
            this.radioButton_addDurationToDate.Name = "radioButton_addDurationToDate";
            this.radioButton_addDurationToDate.Size = new System.Drawing.Size(121, 17);
            this.radioButton_addDurationToDate.TabIndex = 2;
            this.radioButton_addDurationToDate.Text = "Add duration to date";
            this.radioButton_addDurationToDate.UseVisualStyleBackColor = true;
            this.radioButton_addDurationToDate.CheckedChanged += new System.EventHandler(this.FunctionChanged);
            // 
            // radioButton_subtractDurationFromDate
            // 
            this.radioButton_subtractDurationFromDate.AutoSize = true;
            this.radioButton_subtractDurationFromDate.Location = new System.Drawing.Point(24, 176);
            this.radioButton_subtractDurationFromDate.Name = "radioButton_subtractDurationFromDate";
            this.radioButton_subtractDurationFromDate.Size = new System.Drawing.Size(153, 17);
            this.radioButton_subtractDurationFromDate.TabIndex = 2;
            this.radioButton_subtractDurationFromDate.Text = "Subtract duration from date";
            this.radioButton_subtractDurationFromDate.UseVisualStyleBackColor = true;
            this.radioButton_subtractDurationFromDate.CheckedChanged += new System.EventHandler(this.FunctionChanged);
            // 
            // radioButton_differenceBetweenDates
            // 
            this.radioButton_differenceBetweenDates.AutoSize = true;
            this.radioButton_differenceBetweenDates.Location = new System.Drawing.Point(24, 199);
            this.radioButton_differenceBetweenDates.Name = "radioButton_differenceBetweenDates";
            this.radioButton_differenceBetweenDates.Size = new System.Drawing.Size(147, 17);
            this.radioButton_differenceBetweenDates.TabIndex = 2;
            this.radioButton_differenceBetweenDates.Text = "Difference between dates";
            this.radioButton_differenceBetweenDates.UseVisualStyleBackColor = true;
            this.radioButton_differenceBetweenDates.CheckedChanged += new System.EventHandler(this.FunctionChanged);
            // 
            // radioButton_addDurationToCurrentDate
            // 
            this.radioButton_addDurationToCurrentDate.AutoSize = true;
            this.radioButton_addDurationToCurrentDate.Location = new System.Drawing.Point(24, 222);
            this.radioButton_addDurationToCurrentDate.Name = "radioButton_addDurationToCurrentDate";
            this.radioButton_addDurationToCurrentDate.Size = new System.Drawing.Size(157, 17);
            this.radioButton_addDurationToCurrentDate.TabIndex = 2;
            this.radioButton_addDurationToCurrentDate.Text = "Add duration to current date";
            this.radioButton_addDurationToCurrentDate.UseVisualStyleBackColor = true;
            this.radioButton_addDurationToCurrentDate.CheckedChanged += new System.EventHandler(this.FunctionChanged);
            // 
            // radioButton_subtractDurationFromCurrentDate
            // 
            this.radioButton_subtractDurationFromCurrentDate.AutoSize = true;
            this.radioButton_subtractDurationFromCurrentDate.Location = new System.Drawing.Point(24, 245);
            this.radioButton_subtractDurationFromCurrentDate.Name = "radioButton_subtractDurationFromCurrentDate";
            this.radioButton_subtractDurationFromCurrentDate.Size = new System.Drawing.Size(189, 17);
            this.radioButton_subtractDurationFromCurrentDate.TabIndex = 2;
            this.radioButton_subtractDurationFromCurrentDate.Text = "Subtract duration from current date";
            this.radioButton_subtractDurationFromCurrentDate.UseVisualStyleBackColor = true;
            this.radioButton_subtractDurationFromCurrentDate.CheckedChanged += new System.EventHandler(this.FunctionChanged);
            // 
            // radioButton_differenceBetweenDateAndCurrentDate
            // 
            this.radioButton_differenceBetweenDateAndCurrentDate.AutoSize = true;
            this.radioButton_differenceBetweenDateAndCurrentDate.Location = new System.Drawing.Point(24, 268);
            this.radioButton_differenceBetweenDateAndCurrentDate.Name = "radioButton_differenceBetweenDateAndCurrentDate";
            this.radioButton_differenceBetweenDateAndCurrentDate.Size = new System.Drawing.Size(223, 17);
            this.radioButton_differenceBetweenDateAndCurrentDate.TabIndex = 2;
            this.radioButton_differenceBetweenDateAndCurrentDate.Text = "Difference between date and current date";
            this.radioButton_differenceBetweenDateAndCurrentDate.UseVisualStyleBackColor = true;
            this.radioButton_differenceBetweenDateAndCurrentDate.CheckedChanged += new System.EventHandler(this.FunctionChanged);
            // 
            // label_input1Type
            // 
            this.label_input1Type.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_input1Type.AutoSize = true;
            this.label_input1Type.Location = new System.Drawing.Point(349, 15);
            this.label_input1Type.Name = "label_input1Type";
            this.label_input1Type.Size = new System.Drawing.Size(67, 13);
            this.label_input1Type.TabIndex = 3;
            this.label_input1Type.Text = "Input 1 Type";
            // 
            // textBox_input2
            // 
            this.textBox_input2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_input2.Location = new System.Drawing.Point(70, 291);
            this.textBox_input2.Name = "textBox_input2";
            this.textBox_input2.Size = new System.Drawing.Size(273, 20);
            this.textBox_input2.TabIndex = 3;
            this.textBox_input2.TextChanged += new System.EventHandler(this.InputUpdated);
            // 
            // label_input2
            // 
            this.label_input2.AutoSize = true;
            this.label_input2.Location = new System.Drawing.Point(21, 294);
            this.label_input2.Name = "label_input2";
            this.label_input2.Size = new System.Drawing.Size(43, 13);
            this.label_input2.TabIndex = 1;
            this.label_input2.Text = "Input 2:";
            // 
            // label_input2Type
            // 
            this.label_input2Type.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_input2Type.AutoSize = true;
            this.label_input2Type.Location = new System.Drawing.Point(349, 294);
            this.label_input2Type.Name = "label_input2Type";
            this.label_input2Type.Size = new System.Drawing.Size(67, 13);
            this.label_input2Type.TabIndex = 3;
            this.label_input2Type.Text = "Input 2 Type";
            // 
            // label_ouputDurationFormat
            // 
            this.label_ouputDurationFormat.AutoSize = true;
            this.label_ouputDurationFormat.Location = new System.Drawing.Point(21, 320);
            this.label_ouputDurationFormat.Name = "label_ouputDurationFormat";
            this.label_ouputDurationFormat.Size = new System.Drawing.Size(115, 13);
            this.label_ouputDurationFormat.TabIndex = 4;
            this.label_ouputDurationFormat.Text = "Output duration format:";
            // 
            // comboBox_outputDurationFormat
            // 
            this.comboBox_outputDurationFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_outputDurationFormat.FormattingEnabled = true;
            this.comboBox_outputDurationFormat.Items.AddRange(new object[] {
            "[[year] day] h:min:s.ms",
            "[day] h:min:s.ms",
            "h:min:s.ms",
            "unit + subunit",
            "unit + subunits",
            "unit + decimal",
            "ms",
            "s",
            "min",
            "h",
            "day",
            "year"});
            this.comboBox_outputDurationFormat.Location = new System.Drawing.Point(142, 317);
            this.comboBox_outputDurationFormat.Name = "comboBox_outputDurationFormat";
            this.comboBox_outputDurationFormat.Size = new System.Drawing.Size(128, 21);
            this.comboBox_outputDurationFormat.TabIndex = 4;
            this.comboBox_outputDurationFormat.SelectedValueChanged += new System.EventHandler(this.OutputFormatChanged);
            // 
            // label_outputDateFormat
            // 
            this.label_outputDateFormat.AutoSize = true;
            this.label_outputDateFormat.Location = new System.Drawing.Point(21, 347);
            this.label_outputDateFormat.Name = "label_outputDateFormat";
            this.label_outputDateFormat.Size = new System.Drawing.Size(98, 13);
            this.label_outputDateFormat.TabIndex = 4;
            this.label_outputDateFormat.Text = "Output date format:";
            // 
            // comboBox_outputDateFormat
            // 
            this.comboBox_outputDateFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_outputDateFormat.FormattingEnabled = true;
            this.comboBox_outputDateFormat.Items.AddRange(new object[] {
            "System short",
            "System long",
            "ISO 8601"});
            this.comboBox_outputDateFormat.Location = new System.Drawing.Point(142, 344);
            this.comboBox_outputDateFormat.Name = "comboBox_outputDateFormat";
            this.comboBox_outputDateFormat.Size = new System.Drawing.Size(128, 21);
            this.comboBox_outputDateFormat.TabIndex = 5;
            this.comboBox_outputDateFormat.SelectedValueChanged += new System.EventHandler(this.OutputFormatChanged);
            // 
            // textBox_output
            // 
            this.textBox_output.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_output.Location = new System.Drawing.Point(70, 409);
            this.textBox_output.Name = "textBox_output";
            this.textBox_output.ReadOnly = true;
            this.textBox_output.Size = new System.Drawing.Size(273, 20);
            this.textBox_output.TabIndex = 7;
            // 
            // label_output
            // 
            this.label_output.AutoSize = true;
            this.label_output.Location = new System.Drawing.Point(21, 412);
            this.label_output.Name = "label_output";
            this.label_output.Size = new System.Drawing.Size(42, 13);
            this.label_output.TabIndex = 1;
            this.label_output.Text = "Output:";
            // 
            // label_secondDecimalPlaces
            // 
            this.label_secondDecimalPlaces.AutoSize = true;
            this.label_secondDecimalPlaces.Location = new System.Drawing.Point(21, 374);
            this.label_secondDecimalPlaces.Name = "label_secondDecimalPlaces";
            this.label_secondDecimalPlaces.Size = new System.Drawing.Size(120, 13);
            this.label_secondDecimalPlaces.TabIndex = 4;
            this.label_secondDecimalPlaces.Text = "Second decimal places:";
            // 
            // numericUpDown_secondDecimalPlaces
            // 
            this.numericUpDown_secondDecimalPlaces.Location = new System.Drawing.Point(142, 372);
            this.numericUpDown_secondDecimalPlaces.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.numericUpDown_secondDecimalPlaces.Name = "numericUpDown_secondDecimalPlaces";
            this.numericUpDown_secondDecimalPlaces.Size = new System.Drawing.Size(30, 20);
            this.numericUpDown_secondDecimalPlaces.TabIndex = 6;
            this.numericUpDown_secondDecimalPlaces.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDown_secondDecimalPlaces.ValueChanged += new System.EventHandler(this.OutputFormatChanged);
            // 
            // checkBox_years
            // 
            this.checkBox_years.AutoSize = true;
            this.checkBox_years.Checked = true;
            this.checkBox_years.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_years.Location = new System.Drawing.Point(277, 320);
            this.checkBox_years.Name = "checkBox_years";
            this.checkBox_years.Size = new System.Drawing.Size(53, 17);
            this.checkBox_years.TabIndex = 8;
            this.checkBox_years.Text = "Years";
            this.checkBox_years.UseVisualStyleBackColor = true;
            this.checkBox_years.CheckedChanged += new System.EventHandler(this.OutputFormatChanged);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 441);
            this.Controls.Add(this.checkBox_years);
            this.Controls.Add(this.numericUpDown_secondDecimalPlaces);
            this.Controls.Add(this.comboBox_outputDateFormat);
            this.Controls.Add(this.comboBox_outputDurationFormat);
            this.Controls.Add(this.label_secondDecimalPlaces);
            this.Controls.Add(this.label_outputDateFormat);
            this.Controls.Add(this.label_ouputDurationFormat);
            this.Controls.Add(this.label_input2Type);
            this.Controls.Add(this.label_input1Type);
            this.Controls.Add(this.radioButton_differenceBetweenDateAndCurrentDate);
            this.Controls.Add(this.radioButton_subtractDurationFromCurrentDate);
            this.Controls.Add(this.radioButton_addDurationToCurrentDate);
            this.Controls.Add(this.radioButton_differenceBetweenDates);
            this.Controls.Add(this.radioButton_subtractDurationFromDate);
            this.Controls.Add(this.radioButton_addDurationToDate);
            this.Controls.Add(this.radioButton_durationDividedByNumber);
            this.Controls.Add(this.radioButton_durationTimesNumber);
            this.Controls.Add(this.radioButton_differenceBetweenDurations);
            this.Controls.Add(this.radioButton_addDurations);
            this.Controls.Add(this.radioButton_displayDuration);
            this.Controls.Add(this.label_output);
            this.Controls.Add(this.label_input2);
            this.Controls.Add(this.label_input1);
            this.Controls.Add(this.textBox_output);
            this.Controls.Add(this.textBox_input2);
            this.Controls.Add(this.textBox_input1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(960, 680);
            this.MinimumSize = new System.Drawing.Size(450, 480);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Time Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_secondDecimalPlaces)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_input1;
        private System.Windows.Forms.Label label_input1;
        private System.Windows.Forms.RadioButton radioButton_displayDuration;
        private System.Windows.Forms.RadioButton radioButton_addDurations;
        private System.Windows.Forms.RadioButton radioButton_differenceBetweenDurations;
        private System.Windows.Forms.RadioButton radioButton_durationTimesNumber;
        private System.Windows.Forms.RadioButton radioButton_durationDividedByNumber;
        private System.Windows.Forms.RadioButton radioButton_addDurationToDate;
        private System.Windows.Forms.RadioButton radioButton_subtractDurationFromDate;
        private System.Windows.Forms.RadioButton radioButton_differenceBetweenDates;
        private System.Windows.Forms.RadioButton radioButton_addDurationToCurrentDate;
        private System.Windows.Forms.RadioButton radioButton_subtractDurationFromCurrentDate;
        private System.Windows.Forms.RadioButton radioButton_differenceBetweenDateAndCurrentDate;
        private System.Windows.Forms.Label label_input1Type;
        private System.Windows.Forms.TextBox textBox_input2;
        private System.Windows.Forms.Label label_input2;
        private System.Windows.Forms.Label label_input2Type;
        private System.Windows.Forms.Label label_ouputDurationFormat;
        private System.Windows.Forms.ComboBox comboBox_outputDurationFormat;
        private System.Windows.Forms.Label label_outputDateFormat;
        private System.Windows.Forms.ComboBox comboBox_outputDateFormat;
        private System.Windows.Forms.TextBox textBox_output;
        private System.Windows.Forms.Label label_output;
        private System.Windows.Forms.Label label_secondDecimalPlaces;
        private System.Windows.Forms.NumericUpDown numericUpDown_secondDecimalPlaces;
        private System.Windows.Forms.CheckBox checkBox_years;
        private System.Windows.Forms.Timer timer1;
    }
}

