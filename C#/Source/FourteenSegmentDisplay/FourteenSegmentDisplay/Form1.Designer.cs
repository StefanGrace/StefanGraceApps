namespace FourteenSegmentDisplay
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
            this.pictureBox_display = new System.Windows.Forms.PictureBox();
            this.textBox_input = new System.Windows.Forms.TextBox();
            this.label_input = new System.Windows.Forms.Label();
            this.comboBox_align = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_displayColor = new System.Windows.Forms.ComboBox();
            this.timer_startup = new System.Windows.Forms.Timer(this.components);
            this.timer_refresh = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_display)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_display
            // 
            this.pictureBox_display.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.pictureBox_display.Location = new System.Drawing.Point(12, 12);
            this.pictureBox_display.Name = "pictureBox_display";
            this.pictureBox_display.Size = new System.Drawing.Size(512, 100);
            this.pictureBox_display.TabIndex = 0;
            this.pictureBox_display.TabStop = false;
            // 
            // textBox_input
            // 
            this.textBox_input.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_input.Location = new System.Drawing.Point(102, 135);
            this.textBox_input.MaxLength = 10;
            this.textBox_input.Name = "textBox_input";
            this.textBox_input.Size = new System.Drawing.Size(116, 26);
            this.textBox_input.TabIndex = 1;
            this.textBox_input.TextChanged += new System.EventHandler(this.textBox_input_TextChanged);
            // 
            // label_input
            // 
            this.label_input.AutoSize = true;
            this.label_input.Location = new System.Drawing.Point(12, 142);
            this.label_input.Name = "label_input";
            this.label_input.Size = new System.Drawing.Size(54, 13);
            this.label_input.TabIndex = 2;
            this.label_input.Text = "Input text:";
            // 
            // comboBox_align
            // 
            this.comboBox_align.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_align.FormattingEnabled = true;
            this.comboBox_align.Items.AddRange(new object[] {
            "Left",
            "Center-left",
            "Center-right",
            "Right"});
            this.comboBox_align.Location = new System.Drawing.Point(102, 167);
            this.comboBox_align.Name = "comboBox_align";
            this.comboBox_align.Size = new System.Drawing.Size(116, 21);
            this.comboBox_align.TabIndex = 3;
            this.comboBox_align.SelectedIndexChanged += new System.EventHandler(this.comboBox_algin_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Text alignment:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Display color:";
            // 
            // comboBox_displayColor
            // 
            this.comboBox_displayColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_displayColor.FormattingEnabled = true;
            this.comboBox_displayColor.Items.AddRange(new object[] {
            "Red",
            "Orange",
            "Green",
            "Blue"});
            this.comboBox_displayColor.Location = new System.Drawing.Point(102, 194);
            this.comboBox_displayColor.Name = "comboBox_displayColor";
            this.comboBox_displayColor.Size = new System.Drawing.Size(116, 21);
            this.comboBox_displayColor.TabIndex = 3;
            this.comboBox_displayColor.SelectedIndexChanged += new System.EventHandler(this.comboBox_displayColor_SelectedIndexChanged);
            // 
            // timer_startup
            // 
            this.timer_startup.Enabled = true;
            this.timer_startup.Tick += new System.EventHandler(this.timer_startup_Tick);
            // 
            // timer_refresh
            // 
            this.timer_refresh.Enabled = true;
            this.timer_refresh.Interval = 500;
            this.timer_refresh.Tick += new System.EventHandler(this.timer_refresh_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 280);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_displayColor);
            this.Controls.Add(this.comboBox_align);
            this.Controls.Add(this.label_input);
            this.Controls.Add(this.textBox_input);
            this.Controls.Add(this.pictureBox_display);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "14-Segment Display";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_display)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_display;
        private System.Windows.Forms.TextBox textBox_input;
        private System.Windows.Forms.Label label_input;
        private System.Windows.Forms.ComboBox comboBox_align;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_displayColor;
        private System.Windows.Forms.Timer timer_startup;
        private System.Windows.Forms.Timer timer_refresh;
    }
}

