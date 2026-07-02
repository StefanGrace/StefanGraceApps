namespace LuxCalculator
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
            this.label_aperture = new System.Windows.Forms.Label();
            this.label_shutterSpeed = new System.Windows.Forms.Label();
            this.label_iso = new System.Windows.Forms.Label();
            this.textBox_iso = new System.Windows.Forms.TextBox();
            this.textBox_shutterSpeed1 = new System.Windows.Forms.TextBox();
            this.textBox_aperture = new System.Windows.Forms.TextBox();
            this.label_f = new System.Windows.Forms.Label();
            this.label_output = new System.Windows.Forms.Label();
            this.comboBox_shutterUnit = new System.Windows.Forms.ComboBox();
            this.label_min = new System.Windows.Forms.Label();
            this.textBox_shutterSpeed2 = new System.Windows.Forms.TextBox();
            this.label_sec = new System.Windows.Forms.Label();
            this.button_calculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_aperture
            // 
            this.label_aperture.AutoSize = true;
            this.label_aperture.Location = new System.Drawing.Point(13, 13);
            this.label_aperture.Name = "label_aperture";
            this.label_aperture.Size = new System.Drawing.Size(50, 13);
            this.label_aperture.TabIndex = 0;
            this.label_aperture.Text = "Aperture:";
            // 
            // label_shutterSpeed
            // 
            this.label_shutterSpeed.AutoSize = true;
            this.label_shutterSpeed.Location = new System.Drawing.Point(13, 39);
            this.label_shutterSpeed.Name = "label_shutterSpeed";
            this.label_shutterSpeed.Size = new System.Drawing.Size(79, 13);
            this.label_shutterSpeed.TabIndex = 1;
            this.label_shutterSpeed.Text = "Shutter speed: ";
            // 
            // label_iso
            // 
            this.label_iso.AutoSize = true;
            this.label_iso.Location = new System.Drawing.Point(13, 65);
            this.label_iso.Name = "label_iso";
            this.label_iso.Size = new System.Drawing.Size(31, 13);
            this.label_iso.TabIndex = 1;
            this.label_iso.Text = "ISO: ";
            // 
            // textBox_iso
            // 
            this.textBox_iso.Location = new System.Drawing.Point(91, 65);
            this.textBox_iso.MaxLength = 9;
            this.textBox_iso.Name = "textBox_iso";
            this.textBox_iso.Size = new System.Drawing.Size(66, 20);
            this.textBox_iso.TabIndex = 4;
            // 
            // textBox_shutterSpeed1
            // 
            this.textBox_shutterSpeed1.Location = new System.Drawing.Point(163, 39);
            this.textBox_shutterSpeed1.MaxLength = 8;
            this.textBox_shutterSpeed1.Name = "textBox_shutterSpeed1";
            this.textBox_shutterSpeed1.Size = new System.Drawing.Size(54, 20);
            this.textBox_shutterSpeed1.TabIndex = 2;
            // 
            // textBox_aperture
            // 
            this.textBox_aperture.Location = new System.Drawing.Point(103, 13);
            this.textBox_aperture.MaxLength = 8;
            this.textBox_aperture.Name = "textBox_aperture";
            this.textBox_aperture.Size = new System.Drawing.Size(54, 20);
            this.textBox_aperture.TabIndex = 0;
            // 
            // label_f
            // 
            this.label_f.AutoSize = true;
            this.label_f.Location = new System.Drawing.Point(88, 16);
            this.label_f.Name = "label_f";
            this.label_f.Size = new System.Drawing.Size(15, 13);
            this.label_f.TabIndex = 0;
            this.label_f.Text = "f/";
            // 
            // label_output
            // 
            this.label_output.AutoSize = true;
            this.label_output.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_output.Location = new System.Drawing.Point(12, 134);
            this.label_output.Name = "label_output";
            this.label_output.Size = new System.Drawing.Size(50, 24);
            this.label_output.TabIndex = 3;
            this.label_output.Text = "lux: ";
            // 
            // comboBox_shutterUnit
            // 
            this.comboBox_shutterUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_shutterUnit.FormattingEnabled = true;
            this.comboBox_shutterUnit.Items.AddRange(new object[] {
            "1/",
            "Seconds",
            "Time"});
            this.comboBox_shutterUnit.Location = new System.Drawing.Point(91, 39);
            this.comboBox_shutterUnit.Name = "comboBox_shutterUnit";
            this.comboBox_shutterUnit.Size = new System.Drawing.Size(66, 21);
            this.comboBox_shutterUnit.TabIndex = 1;
            this.comboBox_shutterUnit.SelectedIndexChanged += new System.EventHandler(this.comboBox_shutterUnit_SelectedIndexChanged);
            // 
            // label_min
            // 
            this.label_min.AutoSize = true;
            this.label_min.Location = new System.Drawing.Point(223, 42);
            this.label_min.Name = "label_min";
            this.label_min.Size = new System.Drawing.Size(23, 13);
            this.label_min.TabIndex = 5;
            this.label_min.Text = "min";
            this.label_min.Visible = false;
            // 
            // textBox_shutterSpeed2
            // 
            this.textBox_shutterSpeed2.Location = new System.Drawing.Point(252, 39);
            this.textBox_shutterSpeed2.MaxLength = 8;
            this.textBox_shutterSpeed2.Name = "textBox_shutterSpeed2";
            this.textBox_shutterSpeed2.Size = new System.Drawing.Size(54, 20);
            this.textBox_shutterSpeed2.TabIndex = 3;
            this.textBox_shutterSpeed2.Visible = false;
            // 
            // label_sec
            // 
            this.label_sec.AutoSize = true;
            this.label_sec.Location = new System.Drawing.Point(312, 42);
            this.label_sec.Name = "label_sec";
            this.label_sec.Size = new System.Drawing.Size(24, 13);
            this.label_sec.TabIndex = 5;
            this.label_sec.Text = "sec";
            this.label_sec.Visible = false;
            // 
            // button_calculate
            // 
            this.button_calculate.Location = new System.Drawing.Point(91, 91);
            this.button_calculate.Name = "button_calculate";
            this.button_calculate.Size = new System.Drawing.Size(66, 23);
            this.button_calculate.TabIndex = 5;
            this.button_calculate.Text = "Calculate";
            this.button_calculate.UseVisualStyleBackColor = true;
            this.button_calculate.Click += new System.EventHandler(this.button_calculate_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.button_calculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 175);
            this.Controls.Add(this.button_calculate);
            this.Controls.Add(this.label_sec);
            this.Controls.Add(this.label_min);
            this.Controls.Add(this.comboBox_shutterUnit);
            this.Controls.Add(this.label_output);
            this.Controls.Add(this.textBox_aperture);
            this.Controls.Add(this.textBox_shutterSpeed2);
            this.Controls.Add(this.textBox_shutterSpeed1);
            this.Controls.Add(this.textBox_iso);
            this.Controls.Add(this.label_iso);
            this.Controls.Add(this.label_shutterSpeed);
            this.Controls.Add(this.label_f);
            this.Controls.Add(this.label_aperture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lux Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_aperture;
        private System.Windows.Forms.Label label_shutterSpeed;
        private System.Windows.Forms.Label label_iso;
        private System.Windows.Forms.TextBox textBox_iso;
        private System.Windows.Forms.TextBox textBox_shutterSpeed1;
        private System.Windows.Forms.TextBox textBox_aperture;
        private System.Windows.Forms.Label label_f;
        private System.Windows.Forms.Label label_output;
        private System.Windows.Forms.ComboBox comboBox_shutterUnit;
        private System.Windows.Forms.Label label_min;
        private System.Windows.Forms.TextBox textBox_shutterSpeed2;
        private System.Windows.Forms.Label label_sec;
        private System.Windows.Forms.Button button_calculate;
    }
}

