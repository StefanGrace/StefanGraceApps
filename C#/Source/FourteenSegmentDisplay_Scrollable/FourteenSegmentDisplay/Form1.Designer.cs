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
            this.label_align = new System.Windows.Forms.Label();
            this.label_displayColor = new System.Windows.Forms.Label();
            this.comboBox_displayColor = new System.Windows.Forms.ComboBox();
            this.timer_startup = new System.Windows.Forms.Timer(this.components);
            this.timer_refresh = new System.Windows.Forms.Timer(this.components);
            this.timer_scroll = new System.Windows.Forms.Timer(this.components);
            this.trackBar_speed = new System.Windows.Forms.TrackBar();
            this.label_scrollSpeed = new System.Windows.Forms.Label();
            this.label_speedValue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_display)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_speed)).BeginInit();
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
            this.textBox_input.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_input.Location = new System.Drawing.Point(102, 135);
            this.textBox_input.MaxLength = 100;
            this.textBox_input.Name = "textBox_input";
            this.textBox_input.Size = new System.Drawing.Size(422, 25);
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
            this.comboBox_align.TabIndex = 2;
            this.comboBox_align.SelectedIndexChanged += new System.EventHandler(this.comboBox_algin_SelectedIndexChanged);
            // 
            // label_align
            // 
            this.label_align.AutoSize = true;
            this.label_align.Location = new System.Drawing.Point(12, 170);
            this.label_align.Name = "label_align";
            this.label_align.Size = new System.Drawing.Size(79, 13);
            this.label_align.TabIndex = 4;
            this.label_align.Text = "Text alignment:";
            // 
            // label_displayColor
            // 
            this.label_displayColor.AutoSize = true;
            this.label_displayColor.Location = new System.Drawing.Point(12, 197);
            this.label_displayColor.Name = "label_displayColor";
            this.label_displayColor.Size = new System.Drawing.Size(70, 13);
            this.label_displayColor.TabIndex = 4;
            this.label_displayColor.Text = "Display color:";
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
            // timer_scroll
            // 
            this.timer_scroll.Enabled = true;
            this.timer_scroll.Interval = 400;
            this.timer_scroll.Tick += new System.EventHandler(this.timer_scroll_Tick);
            // 
            // trackBar_speed
            // 
            this.trackBar_speed.LargeChange = 6;
            this.trackBar_speed.Location = new System.Drawing.Point(102, 223);
            this.trackBar_speed.Maximum = 5;
            this.trackBar_speed.Name = "trackBar_speed";
            this.trackBar_speed.Size = new System.Drawing.Size(116, 45);
            this.trackBar_speed.TabIndex = 4;
            this.trackBar_speed.Value = 2;
            this.trackBar_speed.Scroll += new System.EventHandler(this.trackBar_speed_Scroll);
            // 
            // label_scrollSpeed
            // 
            this.label_scrollSpeed.AutoSize = true;
            this.label_scrollSpeed.Location = new System.Drawing.Point(12, 223);
            this.label_scrollSpeed.Name = "label_scrollSpeed";
            this.label_scrollSpeed.Size = new System.Drawing.Size(68, 13);
            this.label_scrollSpeed.TabIndex = 4;
            this.label_scrollSpeed.Text = "Scroll speed:";
            // 
            // label_speedValue
            // 
            this.label_speedValue.AutoSize = true;
            this.label_speedValue.Location = new System.Drawing.Point(224, 223);
            this.label_speedValue.Name = "label_speedValue";
            this.label_speedValue.Size = new System.Drawing.Size(41, 13);
            this.label_speedValue.TabIndex = 5;
            this.label_speedValue.Text = "400 ms";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 280);
            this.Controls.Add(this.label_speedValue);
            this.Controls.Add(this.trackBar_speed);
            this.Controls.Add(this.label_scrollSpeed);
            this.Controls.Add(this.label_displayColor);
            this.Controls.Add(this.label_align);
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
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_speed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_display;
        private System.Windows.Forms.TextBox textBox_input;
        private System.Windows.Forms.Label label_input;
        private System.Windows.Forms.ComboBox comboBox_align;
        private System.Windows.Forms.Label label_align;
        private System.Windows.Forms.Label label_displayColor;
        private System.Windows.Forms.ComboBox comboBox_displayColor;
        private System.Windows.Forms.Timer timer_startup;
        private System.Windows.Forms.Timer timer_refresh;
        private System.Windows.Forms.Timer timer_scroll;
        private System.Windows.Forms.TrackBar trackBar_speed;
        private System.Windows.Forms.Label label_scrollSpeed;
        private System.Windows.Forms.Label label_speedValue;
    }
}

