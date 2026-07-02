namespace FlickerSafeShutterCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox_frameRate = new System.Windows.Forms.TextBox();
            this.label_frateRate = new System.Windows.Forms.Label();
            this.label_flickerFrequency = new System.Windows.Forms.Label();
            this.textBox_flickerFrequency = new System.Windows.Forms.TextBox();
            this.label_fps = new System.Windows.Forms.Label();
            this.label_Hz = new System.Windows.Forms.Label();
            this.label_note = new System.Windows.Forms.Label();
            this.listBox_safeShutters = new System.Windows.Forms.ListBox();
            this.radioButton_shutterSpeed = new System.Windows.Forms.RadioButton();
            this.radioButton_shutterAngle = new System.Windows.Forms.RadioButton();
            this.radioButton_shutterSpeedAndAngle = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // textBox_frameRate
            // 
            this.textBox_frameRate.Location = new System.Drawing.Point(16, 29);
            this.textBox_frameRate.Name = "textBox_frameRate";
            this.textBox_frameRate.Size = new System.Drawing.Size(64, 20);
            this.textBox_frameRate.TabIndex = 0;
            this.textBox_frameRate.TextChanged += new System.EventHandler(this.textBox_frameRate_TextChanged);
            // 
            // label_frateRate
            // 
            this.label_frateRate.AutoSize = true;
            this.label_frateRate.Location = new System.Drawing.Point(13, 13);
            this.label_frateRate.Name = "label_frateRate";
            this.label_frateRate.Size = new System.Drawing.Size(60, 13);
            this.label_frateRate.TabIndex = 1;
            this.label_frateRate.Text = "Frame rate:";
            // 
            // label_flickerFrequency
            // 
            this.label_flickerFrequency.AutoSize = true;
            this.label_flickerFrequency.Location = new System.Drawing.Point(303, 13);
            this.label_flickerFrequency.Name = "label_flickerFrequency";
            this.label_flickerFrequency.Size = new System.Drawing.Size(91, 13);
            this.label_flickerFrequency.TabIndex = 1;
            this.label_flickerFrequency.Text = "Flicker frequency:";
            // 
            // textBox_flickerFrequency
            // 
            this.textBox_flickerFrequency.Location = new System.Drawing.Point(306, 29);
            this.textBox_flickerFrequency.Name = "textBox_flickerFrequency";
            this.textBox_flickerFrequency.Size = new System.Drawing.Size(64, 20);
            this.textBox_flickerFrequency.TabIndex = 1;
            this.textBox_flickerFrequency.TextChanged += new System.EventHandler(this.textBox_flickerFrequency_TextChanged);
            // 
            // label_fps
            // 
            this.label_fps.AutoSize = true;
            this.label_fps.Location = new System.Drawing.Point(86, 32);
            this.label_fps.Name = "label_fps";
            this.label_fps.Size = new System.Drawing.Size(21, 13);
            this.label_fps.TabIndex = 2;
            this.label_fps.Text = "fps";
            // 
            // label_Hz
            // 
            this.label_Hz.AutoSize = true;
            this.label_Hz.Location = new System.Drawing.Point(376, 32);
            this.label_Hz.Name = "label_Hz";
            this.label_Hz.Size = new System.Drawing.Size(20, 13);
            this.label_Hz.TabIndex = 2;
            this.label_Hz.Text = "Hz";
            // 
            // label_note
            // 
            this.label_note.Location = new System.Drawing.Point(13, 61);
            this.label_note.Name = "label_note";
            this.label_note.Size = new System.Drawing.Size(407, 50);
            this.label_note.TabIndex = 4;
            this.label_note.Text = resources.GetString("label_note.Text");
            // 
            // listBox_safeShutters
            // 
            this.listBox_safeShutters.FormattingEnabled = true;
            this.listBox_safeShutters.Location = new System.Drawing.Point(12, 111);
            this.listBox_safeShutters.Name = "listBox_safeShutters";
            this.listBox_safeShutters.Size = new System.Drawing.Size(298, 238);
            this.listBox_safeShutters.TabIndex = 5;
            // 
            // radioButton_shutterSpeed
            // 
            this.radioButton_shutterSpeed.AutoSize = true;
            this.radioButton_shutterSpeed.Location = new System.Drawing.Point(316, 114);
            this.radioButton_shutterSpeed.Name = "radioButton_shutterSpeed";
            this.radioButton_shutterSpeed.Size = new System.Drawing.Size(96, 17);
            this.radioButton_shutterSpeed.TabIndex = 2;
            this.radioButton_shutterSpeed.Text = "Shutter speeds";
            this.radioButton_shutterSpeed.UseVisualStyleBackColor = true;
            this.radioButton_shutterSpeed.CheckedChanged += new System.EventHandler(this.radioButton_shutterSpeed_CheckedChanged);
            // 
            // radioButton_shutterAngle
            // 
            this.radioButton_shutterAngle.AutoSize = true;
            this.radioButton_shutterAngle.Location = new System.Drawing.Point(316, 137);
            this.radioButton_shutterAngle.Name = "radioButton_shutterAngle";
            this.radioButton_shutterAngle.Size = new System.Drawing.Size(93, 17);
            this.radioButton_shutterAngle.TabIndex = 3;
            this.radioButton_shutterAngle.Text = "Shutter angles";
            this.radioButton_shutterAngle.UseVisualStyleBackColor = true;
            this.radioButton_shutterAngle.CheckedChanged += new System.EventHandler(this.radioButton_shutterAngle_CheckedChanged);
            // 
            // radioButton_shutterSpeedAndAngle
            // 
            this.radioButton_shutterSpeedAndAngle.AutoSize = true;
            this.radioButton_shutterSpeedAndAngle.Checked = true;
            this.radioButton_shutterSpeedAndAngle.Location = new System.Drawing.Point(316, 160);
            this.radioButton_shutterSpeedAndAngle.Name = "radioButton_shutterSpeedAndAngle";
            this.radioButton_shutterSpeedAndAngle.Size = new System.Drawing.Size(47, 17);
            this.radioButton_shutterSpeedAndAngle.TabIndex = 4;
            this.radioButton_shutterSpeedAndAngle.TabStop = true;
            this.radioButton_shutterSpeedAndAngle.Text = "Both";
            this.radioButton_shutterSpeedAndAngle.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 361);
            this.Controls.Add(this.radioButton_shutterSpeedAndAngle);
            this.Controls.Add(this.radioButton_shutterAngle);
            this.Controls.Add(this.radioButton_shutterSpeed);
            this.Controls.Add(this.listBox_safeShutters);
            this.Controls.Add(this.label_note);
            this.Controls.Add(this.label_Hz);
            this.Controls.Add(this.label_fps);
            this.Controls.Add(this.label_flickerFrequency);
            this.Controls.Add(this.label_frateRate);
            this.Controls.Add(this.textBox_flickerFrequency);
            this.Controls.Add(this.textBox_frameRate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flicker-Safe Shutter Speed Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_frameRate;
        private System.Windows.Forms.Label label_frateRate;
        private System.Windows.Forms.Label label_flickerFrequency;
        private System.Windows.Forms.TextBox textBox_flickerFrequency;
        private System.Windows.Forms.Label label_fps;
        private System.Windows.Forms.Label label_Hz;
        private System.Windows.Forms.Label label_note;
        private System.Windows.Forms.ListBox listBox_safeShutters;
        private System.Windows.Forms.RadioButton radioButton_shutterSpeed;
        private System.Windows.Forms.RadioButton radioButton_shutterAngle;
        private System.Windows.Forms.RadioButton radioButton_shutterSpeedAndAngle;
    }
}

