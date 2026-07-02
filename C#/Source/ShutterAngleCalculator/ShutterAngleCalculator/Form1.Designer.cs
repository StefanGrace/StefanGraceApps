namespace ShutterAngleCalculator
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
            this.label_frameRate = new System.Windows.Forms.Label();
            this.textBox_frameRate = new System.Windows.Forms.TextBox();
            this.label_fps = new System.Windows.Forms.Label();
            this.textBox_shutterSpeed = new System.Windows.Forms.TextBox();
            this.label_oneSlash = new System.Windows.Forms.Label();
            this.textBox_shutterAngle = new System.Windows.Forms.TextBox();
            this.comboBox_shutterAngleUnit = new System.Windows.Forms.ComboBox();
            this.radioButton_shutterSpeed = new System.Windows.Forms.RadioButton();
            this.radioButton_shutterAngle = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label_frameRate
            // 
            this.label_frameRate.AutoSize = true;
            this.label_frameRate.Location = new System.Drawing.Point(13, 13);
            this.label_frameRate.Name = "label_frameRate";
            this.label_frameRate.Size = new System.Drawing.Size(60, 13);
            this.label_frameRate.TabIndex = 0;
            this.label_frameRate.Text = "Frame rate:";
            // 
            // textBox_frameRate
            // 
            this.textBox_frameRate.Location = new System.Drawing.Point(16, 29);
            this.textBox_frameRate.Name = "textBox_frameRate";
            this.textBox_frameRate.Size = new System.Drawing.Size(57, 20);
            this.textBox_frameRate.TabIndex = 0;
            this.textBox_frameRate.TextChanged += new System.EventHandler(this.textBox_frameRate_TextChanged);
            // 
            // label_fps
            // 
            this.label_fps.AutoSize = true;
            this.label_fps.Location = new System.Drawing.Point(79, 32);
            this.label_fps.Name = "label_fps";
            this.label_fps.Size = new System.Drawing.Size(21, 13);
            this.label_fps.TabIndex = 0;
            this.label_fps.Text = "fps";
            // 
            // textBox_shutterSpeed
            // 
            this.textBox_shutterSpeed.Location = new System.Drawing.Point(28, 90);
            this.textBox_shutterSpeed.Name = "textBox_shutterSpeed";
            this.textBox_shutterSpeed.Size = new System.Drawing.Size(45, 20);
            this.textBox_shutterSpeed.TabIndex = 1;
            this.textBox_shutterSpeed.TextChanged += new System.EventHandler(this.textBox_shutterSpeed_TextChanged);
            // 
            // label_oneSlash
            // 
            this.label_oneSlash.AutoSize = true;
            this.label_oneSlash.Location = new System.Drawing.Point(13, 93);
            this.label_oneSlash.Name = "label_oneSlash";
            this.label_oneSlash.Size = new System.Drawing.Size(18, 13);
            this.label_oneSlash.TabIndex = 0;
            this.label_oneSlash.Text = "1/";
            // 
            // textBox_shutterAngle
            // 
            this.textBox_shutterAngle.Location = new System.Drawing.Point(16, 147);
            this.textBox_shutterAngle.Name = "textBox_shutterAngle";
            this.textBox_shutterAngle.ReadOnly = true;
            this.textBox_shutterAngle.Size = new System.Drawing.Size(57, 20);
            this.textBox_shutterAngle.TabIndex = 2;
            this.textBox_shutterAngle.TextChanged += new System.EventHandler(this.textBox_shutterAngle_TextChanged);
            // 
            // comboBox_shutterAngleUnit
            // 
            this.comboBox_shutterAngleUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_shutterAngleUnit.FormattingEnabled = true;
            this.comboBox_shutterAngleUnit.Items.AddRange(new object[] {
            "°",
            "rad",
            "grad",
            "%",
            "dec"});
            this.comboBox_shutterAngleUnit.Location = new System.Drawing.Point(79, 147);
            this.comboBox_shutterAngleUnit.Name = "comboBox_shutterAngleUnit";
            this.comboBox_shutterAngleUnit.Size = new System.Drawing.Size(58, 21);
            this.comboBox_shutterAngleUnit.TabIndex = 5;
            this.comboBox_shutterAngleUnit.SelectedIndexChanged += new System.EventHandler(this.comboBox_shutterAngleUnit_SelectedIndexChanged);
            // 
            // radioButton_shutterSpeed
            // 
            this.radioButton_shutterSpeed.AutoSize = true;
            this.radioButton_shutterSpeed.Checked = true;
            this.radioButton_shutterSpeed.Location = new System.Drawing.Point(16, 67);
            this.radioButton_shutterSpeed.Name = "radioButton_shutterSpeed";
            this.radioButton_shutterSpeed.Size = new System.Drawing.Size(94, 17);
            this.radioButton_shutterSpeed.TabIndex = 3;
            this.radioButton_shutterSpeed.TabStop = true;
            this.radioButton_shutterSpeed.Text = "Shutter speed:";
            this.radioButton_shutterSpeed.UseVisualStyleBackColor = true;
            this.radioButton_shutterSpeed.CheckedChanged += new System.EventHandler(this.radioButton_shutterSpeed_CheckedChanged);
            // 
            // radioButton_shutterAngle
            // 
            this.radioButton_shutterAngle.AutoSize = true;
            this.radioButton_shutterAngle.Location = new System.Drawing.Point(15, 124);
            this.radioButton_shutterAngle.Name = "radioButton_shutterAngle";
            this.radioButton_shutterAngle.Size = new System.Drawing.Size(91, 17);
            this.radioButton_shutterAngle.TabIndex = 4;
            this.radioButton_shutterAngle.Text = "Shutter angle:";
            this.radioButton_shutterAngle.UseVisualStyleBackColor = true;
            this.radioButton_shutterAngle.CheckedChanged += new System.EventHandler(this.radioButton_shutterAngle_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 201);
            this.Controls.Add(this.radioButton_shutterAngle);
            this.Controls.Add(this.radioButton_shutterSpeed);
            this.Controls.Add(this.comboBox_shutterAngleUnit);
            this.Controls.Add(this.textBox_shutterAngle);
            this.Controls.Add(this.textBox_shutterSpeed);
            this.Controls.Add(this.textBox_frameRate);
            this.Controls.Add(this.label_oneSlash);
            this.Controls.Add(this.label_fps);
            this.Controls.Add(this.label_frameRate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shutter Angle Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_frameRate;
        private System.Windows.Forms.TextBox textBox_frameRate;
        private System.Windows.Forms.Label label_fps;
        private System.Windows.Forms.TextBox textBox_shutterSpeed;
        private System.Windows.Forms.Label label_oneSlash;
        private System.Windows.Forms.TextBox textBox_shutterAngle;
        private System.Windows.Forms.ComboBox comboBox_shutterAngleUnit;
        private System.Windows.Forms.RadioButton radioButton_shutterSpeed;
        private System.Windows.Forms.RadioButton radioButton_shutterAngle;
    }
}

