namespace DecimalTime
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
            this.comboBox_function = new System.Windows.Forms.ComboBox();
            this.numericUpDown_inputHours = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_inputMinutes = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_inputSeconds = new System.Windows.Forms.NumericUpDown();
            this.label_24_60_60 = new System.Windows.Forms.Label();
            this.label_output24_60_60 = new System.Windows.Forms.Label();
            this.label_10_100_100 = new System.Windows.Forms.Label();
            this.label_output10_100_100 = new System.Windows.Forms.Label();
            this.label_20_50_100 = new System.Windows.Forms.Label();
            this.label_output20_50_100 = new System.Windows.Forms.Label();
            this.label_24_100_100 = new System.Windows.Forms.Label();
            this.label_output24_100_100 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_inputHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_inputMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_inputSeconds)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox_function
            // 
            this.comboBox_function.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_function.FormattingEnabled = true;
            this.comboBox_function.Items.AddRange(new object[] {
            "Display current time",
            "Convert from 24:60:60",
            "Convert from 10:100:100",
            "Convert from 20:50:100",
            "Convert from 24:100:100"});
            this.comboBox_function.Location = new System.Drawing.Point(12, 12);
            this.comboBox_function.Name = "comboBox_function";
            this.comboBox_function.Size = new System.Drawing.Size(148, 21);
            this.comboBox_function.TabIndex = 0;
            this.comboBox_function.SelectedIndexChanged += new System.EventHandler(this.comboBox_function_SelectedIndexChanged);
            // 
            // numericUpDown_inputHours
            // 
            this.numericUpDown_inputHours.Location = new System.Drawing.Point(166, 12);
            this.numericUpDown_inputHours.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numericUpDown_inputHours.Name = "numericUpDown_inputHours";
            this.numericUpDown_inputHours.Size = new System.Drawing.Size(42, 20);
            this.numericUpDown_inputHours.TabIndex = 1;
            this.numericUpDown_inputHours.ValueChanged += new System.EventHandler(this.numericUpDown_inputHours_ValueChanged);
            // 
            // numericUpDown_inputMinutes
            // 
            this.numericUpDown_inputMinutes.Location = new System.Drawing.Point(214, 12);
            this.numericUpDown_inputMinutes.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numericUpDown_inputMinutes.Name = "numericUpDown_inputMinutes";
            this.numericUpDown_inputMinutes.Size = new System.Drawing.Size(42, 20);
            this.numericUpDown_inputMinutes.TabIndex = 2;
            this.numericUpDown_inputMinutes.ValueChanged += new System.EventHandler(this.numericUpDown_inputMinutes_ValueChanged);
            // 
            // numericUpDown_inputSeconds
            // 
            this.numericUpDown_inputSeconds.Location = new System.Drawing.Point(262, 12);
            this.numericUpDown_inputSeconds.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numericUpDown_inputSeconds.Name = "numericUpDown_inputSeconds";
            this.numericUpDown_inputSeconds.Size = new System.Drawing.Size(42, 20);
            this.numericUpDown_inputSeconds.TabIndex = 3;
            this.numericUpDown_inputSeconds.ValueChanged += new System.EventHandler(this.numericUpDown_inputSeconds_ValueChanged);
            // 
            // label_24_60_60
            // 
            this.label_24_60_60.AutoSize = true;
            this.label_24_60_60.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_24_60_60.Location = new System.Drawing.Point(15, 49);
            this.label_24_60_60.Name = "label_24_60_60";
            this.label_24_60_60.Size = new System.Drawing.Size(85, 24);
            this.label_24_60_60.TabIndex = 2;
            this.label_24_60_60.Text = "24:60:60:";
            // 
            // label_output24_60_60
            // 
            this.label_output24_60_60.AutoSize = true;
            this.label_output24_60_60.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_output24_60_60.Location = new System.Drawing.Point(12, 75);
            this.label_output24_60_60.Name = "label_output24_60_60";
            this.label_output24_60_60.Size = new System.Drawing.Size(159, 39);
            this.label_output24_60_60.TabIndex = 2;
            this.label_output24_60_60.Text = "23:59:59";
            // 
            // label_10_100_100
            // 
            this.label_10_100_100.AutoSize = true;
            this.label_10_100_100.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_10_100_100.Location = new System.Drawing.Point(15, 129);
            this.label_10_100_100.Name = "label_10_100_100";
            this.label_10_100_100.Size = new System.Drawing.Size(105, 24);
            this.label_10_100_100.TabIndex = 2;
            this.label_10_100_100.Text = "10:100:100:";
            // 
            // label_output10_100_100
            // 
            this.label_output10_100_100.AutoSize = true;
            this.label_output10_100_100.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_output10_100_100.Location = new System.Drawing.Point(32, 153);
            this.label_output10_100_100.Name = "label_output10_100_100";
            this.label_output10_100_100.Size = new System.Drawing.Size(139, 39);
            this.label_output10_100_100.TabIndex = 2;
            this.label_output10_100_100.Text = "9:99:99";
            // 
            // label_20_50_100
            // 
            this.label_20_50_100.AutoSize = true;
            this.label_20_50_100.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_20_50_100.Location = new System.Drawing.Point(15, 208);
            this.label_20_50_100.Name = "label_20_50_100";
            this.label_20_50_100.Size = new System.Drawing.Size(95, 24);
            this.label_20_50_100.TabIndex = 2;
            this.label_20_50_100.Text = "20:50:100:";
            // 
            // label_output20_50_100
            // 
            this.label_output20_50_100.AutoSize = true;
            this.label_output20_50_100.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_output20_50_100.Location = new System.Drawing.Point(12, 234);
            this.label_output20_50_100.Name = "label_output20_50_100";
            this.label_output20_50_100.Size = new System.Drawing.Size(159, 39);
            this.label_output20_50_100.TabIndex = 2;
            this.label_output20_50_100.Text = "19:49:99";
            // 
            // label_24_100_100
            // 
            this.label_24_100_100.AutoSize = true;
            this.label_24_100_100.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_24_100_100.Location = new System.Drawing.Point(15, 288);
            this.label_24_100_100.Name = "label_24_100_100";
            this.label_24_100_100.Size = new System.Drawing.Size(105, 24);
            this.label_24_100_100.TabIndex = 2;
            this.label_24_100_100.Text = "24:100:100:";
            // 
            // label_output24_100_100
            // 
            this.label_output24_100_100.AutoSize = true;
            this.label_output24_100_100.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_output24_100_100.Location = new System.Drawing.Point(12, 312);
            this.label_output24_100_100.Name = "label_output24_100_100";
            this.label_output24_100_100.Size = new System.Drawing.Size(159, 39);
            this.label_output24_100_100.TabIndex = 2;
            this.label_output24_100_100.Text = "23:99:99";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 379);
            this.Controls.Add(this.label_output24_100_100);
            this.Controls.Add(this.label_output10_100_100);
            this.Controls.Add(this.label_24_100_100);
            this.Controls.Add(this.label_10_100_100);
            this.Controls.Add(this.label_output20_50_100);
            this.Controls.Add(this.label_output24_60_60);
            this.Controls.Add(this.label_20_50_100);
            this.Controls.Add(this.label_24_60_60);
            this.Controls.Add(this.numericUpDown_inputSeconds);
            this.Controls.Add(this.numericUpDown_inputMinutes);
            this.Controls.Add(this.numericUpDown_inputHours);
            this.Controls.Add(this.comboBox_function);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Decimal Clock";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_inputHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_inputMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_inputSeconds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_function;
        private System.Windows.Forms.NumericUpDown numericUpDown_inputHours;
        private System.Windows.Forms.NumericUpDown numericUpDown_inputMinutes;
        private System.Windows.Forms.NumericUpDown numericUpDown_inputSeconds;
        private System.Windows.Forms.Label label_24_60_60;
        private System.Windows.Forms.Label label_output24_60_60;
        private System.Windows.Forms.Label label_10_100_100;
        private System.Windows.Forms.Label label_output10_100_100;
        private System.Windows.Forms.Label label_20_50_100;
        private System.Windows.Forms.Label label_output20_50_100;
        private System.Windows.Forms.Label label_24_100_100;
        private System.Windows.Forms.Label label_output24_100_100;
        private System.Windows.Forms.Timer timer1;
    }
}

