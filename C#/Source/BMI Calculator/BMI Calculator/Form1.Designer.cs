namespace BMI_Calculator
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
            this.weightLabel = new System.Windows.Forms.Label();
            this.heightLabel = new System.Windows.Forms.Label();
            this.weightTextBox = new System.Windows.Forms.TextBox();
            this.heightTextBox = new System.Windows.Forms.TextBox();
            this.weightUnitComboBox = new System.Windows.Forms.ComboBox();
            this.heightUnitComboBox = new System.Windows.Forms.ComboBox();
            this.outputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // weightLabel
            // 
            this.weightLabel.AutoSize = true;
            this.weightLabel.Location = new System.Drawing.Point(61, 55);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(44, 13);
            this.weightLabel.TabIndex = 0;
            this.weightLabel.Text = "Weight:";
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Location = new System.Drawing.Point(64, 81);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(41, 13);
            this.heightLabel.TabIndex = 1;
            this.heightLabel.Text = "Height:";
            // 
            // weightTextBox
            // 
            this.weightTextBox.Location = new System.Drawing.Point(108, 52);
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.Size = new System.Drawing.Size(100, 20);
            this.weightTextBox.TabIndex = 1;
            this.weightTextBox.TextChanged += new System.EventHandler(this.weightTextBox_TextChanged);
            // 
            // heightTextBox
            // 
            this.heightTextBox.Location = new System.Drawing.Point(108, 78);
            this.heightTextBox.Name = "heightTextBox";
            this.heightTextBox.Size = new System.Drawing.Size(100, 20);
            this.heightTextBox.TabIndex = 2;
            this.heightTextBox.TextChanged += new System.EventHandler(this.heightTextBox_TextChanged);
            // 
            // weightUnitComboBox
            // 
            this.weightUnitComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.weightUnitComboBox.FormattingEnabled = true;
            this.weightUnitComboBox.Items.AddRange(new object[] {
            "g",
            "kg",
            "oz",
            "lb",
            "st"});
            this.weightUnitComboBox.Location = new System.Drawing.Point(214, 51);
            this.weightUnitComboBox.Name = "weightUnitComboBox";
            this.weightUnitComboBox.Size = new System.Drawing.Size(40, 21);
            this.weightUnitComboBox.TabIndex = 3;
            this.weightUnitComboBox.SelectedIndexChanged += new System.EventHandler(this.weightUnitComboBox_SelectedIndexChanged);
            // 
            // heightUnitComboBox
            // 
            this.heightUnitComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.heightUnitComboBox.FormattingEnabled = true;
            this.heightUnitComboBox.Items.AddRange(new object[] {
            "mm",
            "cm",
            "dm",
            "m",
            "in",
            "ft",
            "yd"});
            this.heightUnitComboBox.Location = new System.Drawing.Point(214, 77);
            this.heightUnitComboBox.Name = "heightUnitComboBox";
            this.heightUnitComboBox.Size = new System.Drawing.Size(40, 21);
            this.heightUnitComboBox.TabIndex = 4;
            this.heightUnitComboBox.SelectedIndexChanged += new System.EventHandler(this.heightUnitComboBox_SelectedIndexChanged);
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.Location = new System.Drawing.Point(104, 117);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(0, 20);
            this.outputLabel.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 158);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.heightUnitComboBox);
            this.Controls.Add(this.weightUnitComboBox);
            this.Controls.Add(this.heightTextBox);
            this.Controls.Add(this.weightTextBox);
            this.Controls.Add(this.heightLabel);
            this.Controls.Add(this.weightLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label weightLabel;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.TextBox weightTextBox;
        private System.Windows.Forms.TextBox heightTextBox;
        private System.Windows.Forms.ComboBox weightUnitComboBox;
        private System.Windows.Forms.ComboBox heightUnitComboBox;
        private System.Windows.Forms.Label outputLabel;
    }
}

