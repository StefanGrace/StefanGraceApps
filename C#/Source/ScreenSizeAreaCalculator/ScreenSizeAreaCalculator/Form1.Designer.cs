namespace ScreenSizeAreaCalculator
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
            this.label_diagonalLength = new System.Windows.Forms.Label();
            this.textBox_diagonalLength = new System.Windows.Forms.TextBox();
            this.comboBox_diagonalLengthUnit = new System.Windows.Forms.ComboBox();
            this.label_aspectRatio = new System.Windows.Forms.Label();
            this.textBox_aspectRatioX = new System.Windows.Forms.TextBox();
            this.label_aspectRatioColon = new System.Windows.Forms.Label();
            this.textBox_aspectRatioY = new System.Windows.Forms.TextBox();
            this.textBox_aspectRatioNumber = new System.Windows.Forms.TextBox();
            this.label_ar = new System.Windows.Forms.Label();
            this.textBox_wdith = new System.Windows.Forms.TextBox();
            this.textBox_height = new System.Windows.Forms.TextBox();
            this.label_wdith = new System.Windows.Forms.Label();
            this.label_height = new System.Windows.Forms.Label();
            this.comboBox_widthHeightUnit = new System.Windows.Forms.ComboBox();
            this.label_area = new System.Windows.Forms.Label();
            this.textBox_area = new System.Windows.Forms.TextBox();
            this.comboBox_areaUnit = new System.Windows.Forms.ComboBox();
            this.label_by = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_diagonalLength
            // 
            this.label_diagonalLength.AutoSize = true;
            this.label_diagonalLength.Location = new System.Drawing.Point(13, 13);
            this.label_diagonalLength.Name = "label_diagonalLength";
            this.label_diagonalLength.Size = new System.Drawing.Size(84, 13);
            this.label_diagonalLength.TabIndex = 0;
            this.label_diagonalLength.Text = "Diagonal length:";
            // 
            // textBox_diagonalLength
            // 
            this.textBox_diagonalLength.Location = new System.Drawing.Point(16, 30);
            this.textBox_diagonalLength.Name = "textBox_diagonalLength";
            this.textBox_diagonalLength.Size = new System.Drawing.Size(100, 20);
            this.textBox_diagonalLength.TabIndex = 1;
            // 
            // comboBox_diagonalLengthUnit
            // 
            this.comboBox_diagonalLengthUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_diagonalLengthUnit.FormattingEnabled = true;
            this.comboBox_diagonalLengthUnit.Items.AddRange(new object[] {
            "mm",
            "cm",
            "in",
            "ft"});
            this.comboBox_diagonalLengthUnit.Location = new System.Drawing.Point(122, 30);
            this.comboBox_diagonalLengthUnit.Name = "comboBox_diagonalLengthUnit";
            this.comboBox_diagonalLengthUnit.Size = new System.Drawing.Size(43, 21);
            this.comboBox_diagonalLengthUnit.TabIndex = 2;
            this.comboBox_diagonalLengthUnit.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label_aspectRatio
            // 
            this.label_aspectRatio.AutoSize = true;
            this.label_aspectRatio.Location = new System.Drawing.Point(13, 69);
            this.label_aspectRatio.Name = "label_aspectRatio";
            this.label_aspectRatio.Size = new System.Drawing.Size(66, 13);
            this.label_aspectRatio.TabIndex = 0;
            this.label_aspectRatio.Text = "Aspect ratio:";
            // 
            // textBox_aspectRatioX
            // 
            this.textBox_aspectRatioX.Location = new System.Drawing.Point(16, 86);
            this.textBox_aspectRatioX.MaxLength = 5;
            this.textBox_aspectRatioX.Name = "textBox_aspectRatioX";
            this.textBox_aspectRatioX.Size = new System.Drawing.Size(40, 20);
            this.textBox_aspectRatioX.TabIndex = 3;
            // 
            // label_aspectRatioColon
            // 
            this.label_aspectRatioColon.AutoSize = true;
            this.label_aspectRatioColon.Location = new System.Drawing.Point(62, 89);
            this.label_aspectRatioColon.Name = "label_aspectRatioColon";
            this.label_aspectRatioColon.Size = new System.Drawing.Size(10, 13);
            this.label_aspectRatioColon.TabIndex = 4;
            this.label_aspectRatioColon.Text = ":";
            // 
            // textBox_aspectRatioY
            // 
            this.textBox_aspectRatioY.Location = new System.Drawing.Point(78, 86);
            this.textBox_aspectRatioY.MaxLength = 5;
            this.textBox_aspectRatioY.Name = "textBox_aspectRatioY";
            this.textBox_aspectRatioY.Size = new System.Drawing.Size(40, 20);
            this.textBox_aspectRatioY.TabIndex = 4;
            // 
            // textBox_aspectRatioNumber
            // 
            this.textBox_aspectRatioNumber.Location = new System.Drawing.Point(157, 86);
            this.textBox_aspectRatioNumber.Name = "textBox_aspectRatioNumber";
            this.textBox_aspectRatioNumber.Size = new System.Drawing.Size(72, 20);
            this.textBox_aspectRatioNumber.TabIndex = 5;
            // 
            // label_ar
            // 
            this.label_ar.AutoSize = true;
            this.label_ar.Location = new System.Drawing.Point(235, 89);
            this.label_ar.Name = "label_ar";
            this.label_ar.Size = new System.Drawing.Size(22, 13);
            this.label_ar.TabIndex = 4;
            this.label_ar.Text = "AR";
            // 
            // textBox_wdith
            // 
            this.textBox_wdith.Location = new System.Drawing.Point(16, 137);
            this.textBox_wdith.Name = "textBox_wdith";
            this.textBox_wdith.Size = new System.Drawing.Size(63, 20);
            this.textBox_wdith.TabIndex = 6;
            // 
            // textBox_height
            // 
            this.textBox_height.Location = new System.Drawing.Point(102, 137);
            this.textBox_height.Name = "textBox_height";
            this.textBox_height.Size = new System.Drawing.Size(63, 20);
            this.textBox_height.TabIndex = 7;
            // 
            // label_wdith
            // 
            this.label_wdith.AutoSize = true;
            this.label_wdith.Location = new System.Drawing.Point(13, 121);
            this.label_wdith.Name = "label_wdith";
            this.label_wdith.Size = new System.Drawing.Size(38, 13);
            this.label_wdith.TabIndex = 0;
            this.label_wdith.Text = "Width:";
            // 
            // label_height
            // 
            this.label_height.AutoSize = true;
            this.label_height.Location = new System.Drawing.Point(99, 121);
            this.label_height.Name = "label_height";
            this.label_height.Size = new System.Drawing.Size(41, 13);
            this.label_height.TabIndex = 0;
            this.label_height.Text = "Height:";
            // 
            // comboBox_widthHeightUnit
            // 
            this.comboBox_widthHeightUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_widthHeightUnit.FormattingEnabled = true;
            this.comboBox_widthHeightUnit.Items.AddRange(new object[] {
            "mm",
            "cm",
            "in",
            "ft"});
            this.comboBox_widthHeightUnit.Location = new System.Drawing.Point(171, 137);
            this.comboBox_widthHeightUnit.Name = "comboBox_widthHeightUnit";
            this.comboBox_widthHeightUnit.Size = new System.Drawing.Size(43, 21);
            this.comboBox_widthHeightUnit.TabIndex = 8;
            // 
            // label_area
            // 
            this.label_area.AutoSize = true;
            this.label_area.Location = new System.Drawing.Point(13, 180);
            this.label_area.Name = "label_area";
            this.label_area.Size = new System.Drawing.Size(29, 13);
            this.label_area.TabIndex = 0;
            this.label_area.Text = "Area";
            // 
            // textBox_area
            // 
            this.textBox_area.Location = new System.Drawing.Point(16, 196);
            this.textBox_area.Name = "textBox_area";
            this.textBox_area.Size = new System.Drawing.Size(100, 20);
            this.textBox_area.TabIndex = 9;
            // 
            // comboBox_areaUnit
            // 
            this.comboBox_areaUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_areaUnit.FormattingEnabled = true;
            this.comboBox_areaUnit.Items.AddRange(new object[] {
            "mm²",
            "cm²",
            "in²",
            "ft²"});
            this.comboBox_areaUnit.Location = new System.Drawing.Point(122, 196);
            this.comboBox_areaUnit.Name = "comboBox_areaUnit";
            this.comboBox_areaUnit.Size = new System.Drawing.Size(50, 21);
            this.comboBox_areaUnit.TabIndex = 10;
            this.comboBox_areaUnit.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label_by
            // 
            this.label_by.AutoSize = true;
            this.label_by.Location = new System.Drawing.Point(85, 139);
            this.label_by.Name = "label_by";
            this.label_by.Size = new System.Drawing.Size(13, 13);
            this.label_by.TabIndex = 4;
            this.label_by.Text = "×";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label_ar);
            this.Controls.Add(this.label_by);
            this.Controls.Add(this.label_aspectRatioColon);
            this.Controls.Add(this.textBox_aspectRatioNumber);
            this.Controls.Add(this.textBox_aspectRatioY);
            this.Controls.Add(this.textBox_height);
            this.Controls.Add(this.textBox_area);
            this.Controls.Add(this.textBox_wdith);
            this.Controls.Add(this.textBox_aspectRatioX);
            this.Controls.Add(this.comboBox_widthHeightUnit);
            this.Controls.Add(this.comboBox_areaUnit);
            this.Controls.Add(this.comboBox_diagonalLengthUnit);
            this.Controls.Add(this.textBox_diagonalLength);
            this.Controls.Add(this.label_height);
            this.Controls.Add(this.label_area);
            this.Controls.Add(this.label_wdith);
            this.Controls.Add(this.label_aspectRatio);
            this.Controls.Add(this.label_diagonalLength);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Screen Size/Area Calc";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_diagonalLength;
        private System.Windows.Forms.TextBox textBox_diagonalLength;
        private System.Windows.Forms.ComboBox comboBox_diagonalLengthUnit;
        private System.Windows.Forms.Label label_aspectRatio;
        private System.Windows.Forms.TextBox textBox_aspectRatioX;
        private System.Windows.Forms.Label label_aspectRatioColon;
        private System.Windows.Forms.TextBox textBox_aspectRatioY;
        private System.Windows.Forms.TextBox textBox_aspectRatioNumber;
        private System.Windows.Forms.Label label_ar;
        private System.Windows.Forms.TextBox textBox_wdith;
        private System.Windows.Forms.TextBox textBox_height;
        private System.Windows.Forms.Label label_wdith;
        private System.Windows.Forms.Label label_height;
        private System.Windows.Forms.ComboBox comboBox_widthHeightUnit;
        private System.Windows.Forms.Label label_area;
        private System.Windows.Forms.TextBox textBox_area;
        private System.Windows.Forms.ComboBox comboBox_areaUnit;
        private System.Windows.Forms.Label label_by;
    }
}

