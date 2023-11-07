namespace Revised12hourClock
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
            this.timeOutput = new System.Windows.Forms.Label();
            this.minutesCheckBox = new System.Windows.Forms.CheckBox();
            this.secondsCheckBox = new System.Windows.Forms.CheckBox();
            this.outputFormatComboBox = new System.Windows.Forms.ComboBox();
            this.timeSourceComboBox = new System.Windows.Forms.ComboBox();
            this.hourInputTextbox = new System.Windows.Forms.TextBox();
            this.hourMinuteColon = new System.Windows.Forms.Label();
            this.minuteSecondColon = new System.Windows.Forms.Label();
            this.minuteInputTextbox = new System.Windows.Forms.TextBox();
            this.secondInputTextbox = new System.Windows.Forms.TextBox();
            this.amPmComboBox = new System.Windows.Forms.ComboBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // timeOutput
            // 
            this.timeOutput.AutoSize = true;
            this.timeOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeOutput.Location = new System.Drawing.Point(140, 67);
            this.timeOutput.Name = "timeOutput";
            this.timeOutput.Size = new System.Drawing.Size(130, 55);
            this.timeOutput.TabIndex = 0;
            this.timeOutput.Text = "Time";
            this.timeOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minutesCheckBox
            // 
            this.minutesCheckBox.AutoSize = true;
            this.minutesCheckBox.Checked = true;
            this.minutesCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.minutesCheckBox.Location = new System.Drawing.Point(196, 161);
            this.minutesCheckBox.Name = "minutesCheckBox";
            this.minutesCheckBox.Size = new System.Drawing.Size(63, 17);
            this.minutesCheckBox.TabIndex = 7;
            this.minutesCheckBox.Text = "Minutes";
            this.minutesCheckBox.UseVisualStyleBackColor = true;
            // 
            // secondsCheckBox
            // 
            this.secondsCheckBox.AutoSize = true;
            this.secondsCheckBox.Location = new System.Drawing.Point(277, 161);
            this.secondsCheckBox.Name = "secondsCheckBox";
            this.secondsCheckBox.Size = new System.Drawing.Size(68, 17);
            this.secondsCheckBox.TabIndex = 8;
            this.secondsCheckBox.Text = "Seconds";
            this.secondsCheckBox.UseVisualStyleBackColor = true;
            // 
            // outputFormatComboBox
            // 
            this.outputFormatComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.outputFormatComboBox.FormattingEnabled = true;
            this.outputFormatComboBox.Items.AddRange(new object[] {
            "Compact",
            "Long"});
            this.outputFormatComboBox.Location = new System.Drawing.Point(58, 159);
            this.outputFormatComboBox.Name = "outputFormatComboBox";
            this.outputFormatComboBox.Size = new System.Drawing.Size(121, 21);
            this.outputFormatComboBox.TabIndex = 6;
            // 
            // timeSourceComboBox
            // 
            this.timeSourceComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.timeSourceComboBox.FormattingEnabled = true;
            this.timeSourceComboBox.Items.AddRange(new object[] {
            "Display current time",
            "Convert from 12-hour",
            "Convert from 24-hour"});
            this.timeSourceComboBox.Location = new System.Drawing.Point(58, 13);
            this.timeSourceComboBox.Name = "timeSourceComboBox";
            this.timeSourceComboBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.timeSourceComboBox.Size = new System.Drawing.Size(160, 21);
            this.timeSourceComboBox.TabIndex = 1;
            // 
            // hourInputTextbox
            // 
            this.hourInputTextbox.Location = new System.Drawing.Point(229, 13);
            this.hourInputTextbox.MaxLength = 2;
            this.hourInputTextbox.Name = "hourInputTextbox";
            this.hourInputTextbox.Size = new System.Drawing.Size(20, 20);
            this.hourInputTextbox.TabIndex = 2;
            this.hourInputTextbox.Text = "00";
            // 
            // hourMinuteColon
            // 
            this.hourMinuteColon.AutoSize = true;
            this.hourMinuteColon.Location = new System.Drawing.Point(249, 16);
            this.hourMinuteColon.Name = "hourMinuteColon";
            this.hourMinuteColon.Size = new System.Drawing.Size(10, 13);
            this.hourMinuteColon.TabIndex = 6;
            this.hourMinuteColon.Text = ":";
            // 
            // minuteSecondColon
            // 
            this.minuteSecondColon.AutoSize = true;
            this.minuteSecondColon.Location = new System.Drawing.Point(283, 16);
            this.minuteSecondColon.Name = "minuteSecondColon";
            this.minuteSecondColon.Size = new System.Drawing.Size(10, 13);
            this.minuteSecondColon.TabIndex = 7;
            this.minuteSecondColon.Text = ":";
            // 
            // minuteInputTextbox
            // 
            this.minuteInputTextbox.Location = new System.Drawing.Point(260, 13);
            this.minuteInputTextbox.MaxLength = 2;
            this.minuteInputTextbox.Name = "minuteInputTextbox";
            this.minuteInputTextbox.Size = new System.Drawing.Size(20, 20);
            this.minuteInputTextbox.TabIndex = 3;
            this.minuteInputTextbox.Text = "00";
            // 
            // secondInputTextbox
            // 
            this.secondInputTextbox.Location = new System.Drawing.Point(294, 13);
            this.secondInputTextbox.MaxLength = 2;
            this.secondInputTextbox.Name = "secondInputTextbox";
            this.secondInputTextbox.Size = new System.Drawing.Size(20, 20);
            this.secondInputTextbox.TabIndex = 4;
            this.secondInputTextbox.Text = "00";
            // 
            // amPmComboBox
            // 
            this.amPmComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.amPmComboBox.FormattingEnabled = true;
            this.amPmComboBox.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.amPmComboBox.Location = new System.Drawing.Point(323, 13);
            this.amPmComboBox.Name = "amPmComboBox";
            this.amPmComboBox.Size = new System.Drawing.Size(48, 21);
            this.amPmComboBox.TabIndex = 5;
            // 
            // timer
            // 
            this.timer.Interval = 20;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 201);
            this.Controls.Add(this.amPmComboBox);
            this.Controls.Add(this.secondInputTextbox);
            this.Controls.Add(this.minuteInputTextbox);
            this.Controls.Add(this.minuteSecondColon);
            this.Controls.Add(this.hourMinuteColon);
            this.Controls.Add(this.hourInputTextbox);
            this.Controls.Add(this.timeSourceComboBox);
            this.Controls.Add(this.outputFormatComboBox);
            this.Controls.Add(this.secondsCheckBox);
            this.Controls.Add(this.minutesCheckBox);
            this.Controls.Add(this.timeOutput);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(430, 240);
            this.MinimumSize = new System.Drawing.Size(430, 240);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Revised 12-hour clock";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label timeOutput;
        private System.Windows.Forms.CheckBox minutesCheckBox;
        private System.Windows.Forms.CheckBox secondsCheckBox;
        private System.Windows.Forms.ComboBox outputFormatComboBox;
        private System.Windows.Forms.ComboBox timeSourceComboBox;
        private System.Windows.Forms.TextBox hourInputTextbox;
        private System.Windows.Forms.Label hourMinuteColon;
        private System.Windows.Forms.Label minuteSecondColon;
        private System.Windows.Forms.TextBox minuteInputTextbox;
        private System.Windows.Forms.TextBox secondInputTextbox;
        private System.Windows.Forms.ComboBox amPmComboBox;
        private System.Windows.Forms.Timer timer;
    }
}

