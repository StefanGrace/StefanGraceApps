namespace AlarmClockRadioSimulator
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
            this.upButton = new System.Windows.Forms.Button();
            this.downButton = new System.Windows.Forms.Button();
            this.SetButton = new System.Windows.Forms.Button();
            this.sleepButton = new System.Windows.Forms.Button();
            this.timeFormatListBox = new System.Windows.Forms.ListBox();
            this.DisplayPictureBox = new System.Windows.Forms.PictureBox();
            this.snoozeButton = new System.Windows.Forms.Button();
            this.timeFormatLabel = new System.Windows.Forms.Label();
            this.tempUnitListBox = new System.Windows.Forms.ListBox();
            this.tempUnitLabel = new System.Windows.Forms.Label();
            this.alarm1ListBox = new System.Windows.Forms.ListBox();
            this.alarm1Label = new System.Windows.Forms.Label();
            this.alarm2ListBox = new System.Windows.Forms.ListBox();
            this.alarm2Label = new System.Windows.Forms.Label();
            this.functionListBox = new System.Windows.Forms.ListBox();
            this.functionLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.brightnessTrackBar = new System.Windows.Forms.TrackBar();
            this.volumeTrackBar = new System.Windows.Forms.TrackBar();
            this.brightnessLabel = new System.Windows.Forms.Label();
            this.volumeLabel = new System.Windows.Forms.Label();
            this.aL1Label = new System.Windows.Forms.Label();
            this.pmLabel = new System.Windows.Forms.Label();
            this.fmrLabel = new System.Windows.Forms.Label();
            this.amrLabel = new System.Windows.Forms.Label();
            this.usbLabel = new System.Windows.Forms.Label();
            this.acLabel = new System.Windows.Forms.Label();
            this.aL2Label = new System.Windows.Forms.Label();
            this.flashTimer = new System.Windows.Forms.Timer(this.components);
            this.environmentalVariablesButton = new System.Windows.Forms.Button();
            this.longPressLabel = new System.Windows.Forms.Label();
            this.speakerProgressBar = new System.Windows.Forms.ProgressBar();
            this.speakerLabel = new System.Windows.Forms.Label();
            this.buzzLabel = new System.Windows.Forms.Label();
            this.hpjProgressBar = new System.Windows.Forms.ProgressBar();
            this.hpJackLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DisplayPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brightnessTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.volumeTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // upButton
            // 
            this.upButton.AccessibleName = "Up";
            this.upButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.upButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upButton.ForeColor = System.Drawing.Color.White;
            this.upButton.Location = new System.Drawing.Point(500, 103);
            this.upButton.Name = "upButton";
            this.upButton.Size = new System.Drawing.Size(174, 39);
            this.upButton.TabIndex = 2;
            this.upButton.Text = "▲";
            this.upButton.UseVisualStyleBackColor = false;
            this.upButton.Click += new System.EventHandler(this.upButton_Click);
            // 
            // downButton
            // 
            this.downButton.AccessibleName = "Down";
            this.downButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.downButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.downButton.ForeColor = System.Drawing.Color.White;
            this.downButton.Location = new System.Drawing.Point(320, 103);
            this.downButton.Name = "downButton";
            this.downButton.Size = new System.Drawing.Size(174, 39);
            this.downButton.TabIndex = 1;
            this.downButton.Text = "▼";
            this.downButton.UseVisualStyleBackColor = false;
            this.downButton.Click += new System.EventHandler(this.downButton_Click);
            // 
            // SetButton
            // 
            this.SetButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetButton.ForeColor = System.Drawing.Color.White;
            this.SetButton.Location = new System.Drawing.Point(140, 103);
            this.SetButton.Name = "SetButton";
            this.SetButton.Size = new System.Drawing.Size(174, 39);
            this.SetButton.TabIndex = 0;
            this.SetButton.Text = "SET / STOP";
            this.SetButton.UseVisualStyleBackColor = false;
            this.SetButton.Click += new System.EventHandler(this.SetButton_Click);
            // 
            // sleepButton
            // 
            this.sleepButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sleepButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sleepButton.ForeColor = System.Drawing.Color.White;
            this.sleepButton.Location = new System.Drawing.Point(680, 103);
            this.sleepButton.Name = "sleepButton";
            this.sleepButton.Size = new System.Drawing.Size(174, 39);
            this.sleepButton.TabIndex = 3;
            this.sleepButton.Text = "SLEEP";
            this.sleepButton.UseVisualStyleBackColor = false;
            this.sleepButton.Click += new System.EventHandler(this.sleepButton_Click);
            // 
            // timeFormatListBox
            // 
            this.timeFormatListBox.AccessibleName = "Time format switch";
            this.timeFormatListBox.FormattingEnabled = true;
            this.timeFormatListBox.Items.AddRange(new object[] {
            "24-HOUR",
            "12-HOUR"});
            this.timeFormatListBox.Location = new System.Drawing.Point(140, 29);
            this.timeFormatListBox.Name = "timeFormatListBox";
            this.timeFormatListBox.Size = new System.Drawing.Size(120, 30);
            this.timeFormatListBox.TabIndex = 5;
            this.timeFormatListBox.SelectedIndexChanged += new System.EventHandler(this.timeFormatListBox_SelectedIndexChanged);
            // 
            // DisplayPictureBox
            // 
            this.DisplayPictureBox.AccessibleDescription = "Simulates the alarm clock radio\'s green LED display. Has 4 big 7-segment digits a" +
    "t the left, 4 small 14-segment digits at the top right and 2 small 7-segment dig" +
    "its at the bottom right.";
            this.DisplayPictureBox.AccessibleName = "Display";
            this.DisplayPictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.DisplayPictureBox.Location = new System.Drawing.Point(76, 233);
            this.DisplayPictureBox.Name = "DisplayPictureBox";
            this.DisplayPictureBox.Size = new System.Drawing.Size(840, 256);
            this.DisplayPictureBox.TabIndex = 4;
            this.DisplayPictureBox.TabStop = false;
            // 
            // snoozeButton
            // 
            this.snoozeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.snoozeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.snoozeButton.ForeColor = System.Drawing.Color.White;
            this.snoozeButton.Location = new System.Drawing.Point(140, 148);
            this.snoozeButton.Name = "snoozeButton";
            this.snoozeButton.Size = new System.Drawing.Size(714, 39);
            this.snoozeButton.TabIndex = 4;
            this.snoozeButton.Text = "SNOOZE / DISPLAY";
            this.snoozeButton.UseVisualStyleBackColor = false;
            this.snoozeButton.Click += new System.EventHandler(this.snoozeButton_Click);
            // 
            // timeFormatLabel
            // 
            this.timeFormatLabel.AutoSize = true;
            this.timeFormatLabel.Location = new System.Drawing.Point(157, 9);
            this.timeFormatLabel.Name = "timeFormatLabel";
            this.timeFormatLabel.Size = new System.Drawing.Size(81, 13);
            this.timeFormatLabel.TabIndex = 6;
            this.timeFormatLabel.Text = "TIME FORMAT";
            // 
            // tempUnitListBox
            // 
            this.tempUnitListBox.AccessibleName = "temperature unit switch";
            this.tempUnitListBox.FormattingEnabled = true;
            this.tempUnitListBox.Items.AddRange(new object[] {
            "CELSIUS",
            "FAHRENHEIT"});
            this.tempUnitListBox.Location = new System.Drawing.Point(734, 29);
            this.tempUnitListBox.Name = "tempUnitListBox";
            this.tempUnitListBox.Size = new System.Drawing.Size(120, 30);
            this.tempUnitListBox.TabIndex = 9;
            this.tempUnitListBox.SelectedIndexChanged += new System.EventHandler(this.tempUnitListBox_SelectedIndexChanged);
            // 
            // tempUnitLabel
            // 
            this.tempUnitLabel.AutoSize = true;
            this.tempUnitLabel.Location = new System.Drawing.Point(736, 9);
            this.tempUnitLabel.Name = "tempUnitLabel";
            this.tempUnitLabel.Size = new System.Drawing.Size(118, 13);
            this.tempUnitLabel.TabIndex = 8;
            this.tempUnitLabel.Text = "TEMPERATURE UNIT";
            // 
            // alarm1ListBox
            // 
            this.alarm1ListBox.AccessibleName = "Alarm 1 switch";
            this.alarm1ListBox.FormattingEnabled = true;
            this.alarm1ListBox.Items.AddRange(new object[] {
            "OFF",
            "FM",
            "AM",
            "USB",
            "BUZZ"});
            this.alarm1ListBox.Location = new System.Drawing.Point(290, 29);
            this.alarm1ListBox.Name = "alarm1ListBox";
            this.alarm1ListBox.Size = new System.Drawing.Size(120, 69);
            this.alarm1ListBox.TabIndex = 6;
            this.alarm1ListBox.SelectedIndexChanged += new System.EventHandler(this.alarm1ListBox_SelectedIndexChanged);
            // 
            // alarm1Label
            // 
            this.alarm1Label.AutoSize = true;
            this.alarm1Label.Location = new System.Drawing.Point(317, 9);
            this.alarm1Label.Name = "alarm1Label";
            this.alarm1Label.Size = new System.Drawing.Size(53, 13);
            this.alarm1Label.TabIndex = 6;
            this.alarm1Label.Text = "ALARM 1";
            // 
            // alarm2ListBox
            // 
            this.alarm2ListBox.AccessibleName = "Alarm 1 switch";
            this.alarm2ListBox.FormattingEnabled = true;
            this.alarm2ListBox.Items.AddRange(new object[] {
            "OFF",
            "FM",
            "AM",
            "USB",
            "BUZZ"});
            this.alarm2ListBox.Location = new System.Drawing.Point(442, 29);
            this.alarm2ListBox.Name = "alarm2ListBox";
            this.alarm2ListBox.Size = new System.Drawing.Size(120, 69);
            this.alarm2ListBox.TabIndex = 7;
            this.alarm2ListBox.SelectedIndexChanged += new System.EventHandler(this.alarm2ListBox_SelectedIndexChanged);
            // 
            // alarm2Label
            // 
            this.alarm2Label.AutoSize = true;
            this.alarm2Label.Location = new System.Drawing.Point(476, 9);
            this.alarm2Label.Name = "alarm2Label";
            this.alarm2Label.Size = new System.Drawing.Size(53, 13);
            this.alarm2Label.TabIndex = 6;
            this.alarm2Label.Text = "ALARM 2";
            // 
            // functionListBox
            // 
            this.functionListBox.AccessibleName = "function switch";
            this.functionListBox.FormattingEnabled = true;
            this.functionListBox.Items.AddRange(new object[] {
            "OFF",
            "FM",
            "AM",
            "USB"});
            this.functionListBox.Location = new System.Drawing.Point(591, 29);
            this.functionListBox.Name = "functionListBox";
            this.functionListBox.Size = new System.Drawing.Size(120, 56);
            this.functionListBox.TabIndex = 8;
            this.functionListBox.SelectedIndexChanged += new System.EventHandler(this.functionListBox_SelectedIndexChanged);
            // 
            // functionLabel
            // 
            this.functionLabel.AutoSize = true;
            this.functionLabel.Location = new System.Drawing.Point(612, 9);
            this.functionLabel.Name = "functionLabel";
            this.functionLabel.Size = new System.Drawing.Size(62, 13);
            this.functionLabel.TabIndex = 6;
            this.functionLabel.Text = "FUNCTION";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // brightnessTrackBar
            // 
            this.brightnessTrackBar.AccessibleDescription = "Simulates the brightness knob on the alarm clock radio";
            this.brightnessTrackBar.AccessibleName = "Brightness Slider";
            this.brightnessTrackBar.Location = new System.Drawing.Point(34, 29);
            this.brightnessTrackBar.Name = "brightnessTrackBar";
            this.brightnessTrackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.brightnessTrackBar.Size = new System.Drawing.Size(45, 137);
            this.brightnessTrackBar.TabIndex = 11;
            this.brightnessTrackBar.Value = 10;
            this.brightnessTrackBar.Scroll += new System.EventHandler(this.brightnessTrackBar_Scroll);
            // 
            // volumeTrackBar
            // 
            this.volumeTrackBar.AccessibleDescription = "Simulates the volume knob on the alarm clock radio";
            this.volumeTrackBar.AccessibleName = "Volume Slider";
            this.volumeTrackBar.Location = new System.Drawing.Point(896, 29);
            this.volumeTrackBar.Name = "volumeTrackBar";
            this.volumeTrackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.volumeTrackBar.Size = new System.Drawing.Size(45, 137);
            this.volumeTrackBar.TabIndex = 10;
            this.volumeTrackBar.Value = 7;
            this.volumeTrackBar.Scroll += new System.EventHandler(this.volumeTrackBar_Scroll);
            // 
            // brightnessLabel
            // 
            this.brightnessLabel.AutoSize = true;
            this.brightnessLabel.Location = new System.Drawing.Point(12, 9);
            this.brightnessLabel.Name = "brightnessLabel";
            this.brightnessLabel.Size = new System.Drawing.Size(77, 13);
            this.brightnessLabel.TabIndex = 6;
            this.brightnessLabel.Text = "BRIGHTNESS";
            // 
            // volumeLabel
            // 
            this.volumeLabel.AutoSize = true;
            this.volumeLabel.Location = new System.Drawing.Point(893, 9);
            this.volumeLabel.Name = "volumeLabel";
            this.volumeLabel.Size = new System.Drawing.Size(52, 13);
            this.volumeLabel.TabIndex = 6;
            this.volumeLabel.Text = "VOLUME";
            // 
            // aL1Label
            // 
            this.aL1Label.AutoSize = true;
            this.aL1Label.Location = new System.Drawing.Point(90, 214);
            this.aL1Label.Name = "aL1Label";
            this.aL1Label.Size = new System.Drawing.Size(26, 13);
            this.aL1Label.TabIndex = 10;
            this.aL1Label.Text = "AL1";
            // 
            // pmLabel
            // 
            this.pmLabel.AutoSize = true;
            this.pmLabel.Location = new System.Drawing.Point(882, 214);
            this.pmLabel.Name = "pmLabel";
            this.pmLabel.Size = new System.Drawing.Size(23, 13);
            this.pmLabel.TabIndex = 10;
            this.pmLabel.Text = "PM";
            // 
            // fmrLabel
            // 
            this.fmrLabel.AutoSize = true;
            this.fmrLabel.Location = new System.Drawing.Point(476, 201);
            this.fmrLabel.Name = "fmrLabel";
            this.fmrLabel.Size = new System.Drawing.Size(41, 26);
            this.fmrLabel.TabIndex = 10;
            this.fmrLabel.Text = "FM\r\nRADIO";
            this.fmrLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // amrLabel
            // 
            this.amrLabel.AutoSize = true;
            this.amrLabel.Location = new System.Drawing.Point(612, 201);
            this.amrLabel.Name = "amrLabel";
            this.amrLabel.Size = new System.Drawing.Size(41, 26);
            this.amrLabel.TabIndex = 10;
            this.amrLabel.Text = "AM\r\nRADIO";
            this.amrLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // usbLabel
            // 
            this.usbLabel.AutoSize = true;
            this.usbLabel.Location = new System.Drawing.Point(749, 214);
            this.usbLabel.Name = "usbLabel";
            this.usbLabel.Size = new System.Drawing.Size(29, 13);
            this.usbLabel.TabIndex = 10;
            this.usbLabel.Text = "USB";
            this.usbLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // acLabel
            // 
            this.acLabel.AutoSize = true;
            this.acLabel.Location = new System.Drawing.Point(352, 214);
            this.acLabel.Name = "acLabel";
            this.acLabel.Size = new System.Drawing.Size(21, 13);
            this.acLabel.TabIndex = 10;
            this.acLabel.Text = "AC";
            this.acLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // aL2Label
            // 
            this.aL2Label.AutoSize = true;
            this.aL2Label.Location = new System.Drawing.Point(223, 214);
            this.aL2Label.Name = "aL2Label";
            this.aL2Label.Size = new System.Drawing.Size(26, 13);
            this.aL2Label.TabIndex = 10;
            this.aL2Label.Text = "AL2";
            this.aL2Label.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // flashTimer
            // 
            this.flashTimer.Interval = 500;
            this.flashTimer.Tick += new System.EventHandler(this.flashTimer_Tick);
            // 
            // environmentalVariablesButton
            // 
            this.environmentalVariablesButton.Location = new System.Drawing.Point(379, 526);
            this.environmentalVariablesButton.Name = "environmentalVariablesButton";
            this.environmentalVariablesButton.Size = new System.Drawing.Size(150, 23);
            this.environmentalVariablesButton.TabIndex = 12;
            this.environmentalVariablesButton.Text = "Environmental Variables";
            this.environmentalVariablesButton.UseVisualStyleBackColor = true;
            this.environmentalVariablesButton.Click += new System.EventHandler(this.environmentalVariablesButton_Click);
            // 
            // longPressLabel
            // 
            this.longPressLabel.AutoSize = true;
            this.longPressLabel.Location = new System.Drawing.Point(73, 531);
            this.longPressLabel.Name = "longPressLabel";
            this.longPressLabel.Size = new System.Drawing.Size(267, 13);
            this.longPressLabel.TabIndex = 13;
            this.longPressLabel.Text = "Hold Shift while clicking buttons to simulate long-press. ";
            // 
            // speakerProgressBar
            // 
            this.speakerProgressBar.Location = new System.Drawing.Point(591, 526);
            this.speakerProgressBar.Name = "speakerProgressBar";
            this.speakerProgressBar.Size = new System.Drawing.Size(100, 23);
            this.speakerProgressBar.TabIndex = 14;
            // 
            // speakerLabel
            // 
            this.speakerLabel.AutoSize = true;
            this.speakerLabel.Location = new System.Drawing.Point(588, 510);
            this.speakerLabel.Name = "speakerLabel";
            this.speakerLabel.Size = new System.Drawing.Size(50, 13);
            this.speakerLabel.TabIndex = 15;
            this.speakerLabel.Text = "Speaker:";
            // 
            // buzzLabel
            // 
            this.buzzLabel.AutoSize = true;
            this.buzzLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buzzLabel.ForeColor = System.Drawing.Color.Red;
            this.buzzLabel.Location = new System.Drawing.Point(736, 531);
            this.buzzLabel.Name = "buzzLabel";
            this.buzzLabel.Size = new System.Drawing.Size(34, 13);
            this.buzzLabel.TabIndex = 16;
            this.buzzLabel.Text = "Buzz";
            this.buzzLabel.Visible = false;
            // 
            // hpjProgressBar
            // 
            this.hpjProgressBar.Location = new System.Drawing.Point(805, 526);
            this.hpjProgressBar.Name = "hpjProgressBar";
            this.hpjProgressBar.Size = new System.Drawing.Size(100, 23);
            this.hpjProgressBar.TabIndex = 14;
            // 
            // hpJackLabel
            // 
            this.hpJackLabel.AutoSize = true;
            this.hpJackLabel.Location = new System.Drawing.Point(802, 510);
            this.hpJackLabel.Name = "hpJackLabel";
            this.hpJackLabel.Size = new System.Drawing.Size(92, 13);
            this.hpJackLabel.TabIndex = 15;
            this.hpJackLabel.Text = "Headphone Jack:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1008, 561);
            this.Controls.Add(this.buzzLabel);
            this.Controls.Add(this.hpJackLabel);
            this.Controls.Add(this.hpjProgressBar);
            this.Controls.Add(this.speakerLabel);
            this.Controls.Add(this.speakerProgressBar);
            this.Controls.Add(this.longPressLabel);
            this.Controls.Add(this.environmentalVariablesButton);
            this.Controls.Add(this.aL2Label);
            this.Controls.Add(this.acLabel);
            this.Controls.Add(this.usbLabel);
            this.Controls.Add(this.amrLabel);
            this.Controls.Add(this.fmrLabel);
            this.Controls.Add(this.pmLabel);
            this.Controls.Add(this.aL1Label);
            this.Controls.Add(this.volumeTrackBar);
            this.Controls.Add(this.brightnessTrackBar);
            this.Controls.Add(this.tempUnitLabel);
            this.Controls.Add(this.tempUnitListBox);
            this.Controls.Add(this.functionLabel);
            this.Controls.Add(this.alarm2Label);
            this.Controls.Add(this.alarm1Label);
            this.Controls.Add(this.volumeLabel);
            this.Controls.Add(this.brightnessLabel);
            this.Controls.Add(this.timeFormatLabel);
            this.Controls.Add(this.snoozeButton);
            this.Controls.Add(this.DisplayPictureBox);
            this.Controls.Add(this.functionListBox);
            this.Controls.Add(this.alarm2ListBox);
            this.Controls.Add(this.alarm1ListBox);
            this.Controls.Add(this.timeFormatListBox);
            this.Controls.Add(this.sleepButton);
            this.Controls.Add(this.SetButton);
            this.Controls.Add(this.downButton);
            this.Controls.Add(this.upButton);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1024, 600);
            this.MinimumSize = new System.Drawing.Size(1024, 600);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alarm Clock Radio Simulator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DisplayPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brightnessTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.volumeTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button upButton;
        private System.Windows.Forms.Button downButton;
        private System.Windows.Forms.Button SetButton;
        private System.Windows.Forms.Button sleepButton;
        private System.Windows.Forms.PictureBox DisplayPictureBox;
        private System.Windows.Forms.Button snoozeButton;
        private System.Windows.Forms.Label timeFormatLabel;
        private System.Windows.Forms.ListBox timeFormatListBox;
        private System.Windows.Forms.ListBox tempUnitListBox;
        private System.Windows.Forms.Label tempUnitLabel;
        private System.Windows.Forms.ListBox alarm1ListBox;
        private System.Windows.Forms.Label alarm1Label;
        private System.Windows.Forms.ListBox alarm2ListBox;
        private System.Windows.Forms.Label alarm2Label;
        private System.Windows.Forms.ListBox functionListBox;
        private System.Windows.Forms.Label functionLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TrackBar brightnessTrackBar;
        private System.Windows.Forms.TrackBar volumeTrackBar;
        private System.Windows.Forms.Label brightnessLabel;
        private System.Windows.Forms.Label volumeLabel;
        private System.Windows.Forms.Label aL1Label;
        private System.Windows.Forms.Label pmLabel;
        private System.Windows.Forms.Label fmrLabel;
        private System.Windows.Forms.Label amrLabel;
        private System.Windows.Forms.Label usbLabel;
        private System.Windows.Forms.Label acLabel;
        private System.Windows.Forms.Label aL2Label;
        private System.Windows.Forms.Timer flashTimer;
        private System.Windows.Forms.Button environmentalVariablesButton;
        private System.Windows.Forms.Label longPressLabel;
        private System.Windows.Forms.ProgressBar speakerProgressBar;
        private System.Windows.Forms.Label speakerLabel;
        private System.Windows.Forms.Label buzzLabel;
        private System.Windows.Forms.ProgressBar hpjProgressBar;
        private System.Windows.Forms.Label hpJackLabel;
    }
}

