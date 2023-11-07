namespace PixelAndAspectToDimensions
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
            this.pixelsTextBox = new System.Windows.Forms.TextBox();
            this.unitComboBox = new System.Windows.Forms.ComboBox();
            this.ratioRadioButton = new System.Windows.Forms.RadioButton();
            this.numberRadioButton = new System.Windows.Forms.RadioButton();
            this.ratioWidthTextBox = new System.Windows.Forms.TextBox();
            this.colonLabel = new System.Windows.Forms.Label();
            this.ratioHeightTextBox = new System.Windows.Forms.TextBox();
            this.AspectTextBox = new System.Windows.Forms.TextBox();
            this.aspectRatioLabel = new System.Windows.Forms.Label();
            this.dimensionsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pixelsTextBox
            // 
            this.pixelsTextBox.Location = new System.Drawing.Point(111, 33);
            this.pixelsTextBox.Name = "pixelsTextBox";
            this.pixelsTextBox.Size = new System.Drawing.Size(100, 20);
            this.pixelsTextBox.TabIndex = 0;
            this.pixelsTextBox.TextChanged += new System.EventHandler(this.pixelsTextBox_TextChanged);
            // 
            // unitComboBox
            // 
            this.unitComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.unitComboBox.FormattingEnabled = true;
            this.unitComboBox.Items.AddRange(new object[] {
            "pixels",
            "kilopixels",
            "megapixels",
            "gigapixels"});
            this.unitComboBox.Location = new System.Drawing.Point(218, 31);
            this.unitComboBox.Name = "unitComboBox";
            this.unitComboBox.Size = new System.Drawing.Size(121, 21);
            this.unitComboBox.TabIndex = 1;
            this.unitComboBox.SelectedIndexChanged += new System.EventHandler(this.unitComboBox_SelectedIndexChanged);
            // 
            // ratioRadioButton
            // 
            this.ratioRadioButton.AutoSize = true;
            this.ratioRadioButton.Checked = true;
            this.ratioRadioButton.Location = new System.Drawing.Point(111, 96);
            this.ratioRadioButton.Name = "ratioRadioButton";
            this.ratioRadioButton.Size = new System.Drawing.Size(50, 17);
            this.ratioRadioButton.TabIndex = 2;
            this.ratioRadioButton.TabStop = true;
            this.ratioRadioButton.Text = "Ratio";
            this.ratioRadioButton.UseVisualStyleBackColor = true;
            this.ratioRadioButton.CheckedChanged += new System.EventHandler(this.ratioRadioButton_CheckedChanged);
            // 
            // numberRadioButton
            // 
            this.numberRadioButton.AutoSize = true;
            this.numberRadioButton.Location = new System.Drawing.Point(111, 120);
            this.numberRadioButton.Name = "numberRadioButton";
            this.numberRadioButton.Size = new System.Drawing.Size(62, 17);
            this.numberRadioButton.TabIndex = 3;
            this.numberRadioButton.TabStop = true;
            this.numberRadioButton.Text = "Number";
            this.numberRadioButton.UseVisualStyleBackColor = true;
            this.numberRadioButton.CheckedChanged += new System.EventHandler(this.numberRadioButton_CheckedChanged);
            // 
            // ratioWidthTextBox
            // 
            this.ratioWidthTextBox.Location = new System.Drawing.Point(167, 96);
            this.ratioWidthTextBox.Name = "ratioWidthTextBox";
            this.ratioWidthTextBox.Size = new System.Drawing.Size(25, 20);
            this.ratioWidthTextBox.TabIndex = 4;
            this.ratioWidthTextBox.TextChanged += new System.EventHandler(this.ratioWidthTextBox_TextChanged);
            // 
            // colonLabel
            // 
            this.colonLabel.AutoSize = true;
            this.colonLabel.Location = new System.Drawing.Point(198, 100);
            this.colonLabel.Name = "colonLabel";
            this.colonLabel.Size = new System.Drawing.Size(10, 13);
            this.colonLabel.TabIndex = 5;
            this.colonLabel.Text = ":";
            // 
            // ratioHeightTextBox
            // 
            this.ratioHeightTextBox.Location = new System.Drawing.Point(214, 96);
            this.ratioHeightTextBox.Name = "ratioHeightTextBox";
            this.ratioHeightTextBox.Size = new System.Drawing.Size(25, 20);
            this.ratioHeightTextBox.TabIndex = 6;
            this.ratioHeightTextBox.TextChanged += new System.EventHandler(this.ratioHeightTextBox_TextChanged);
            // 
            // AspectTextBox
            // 
            this.AspectTextBox.Location = new System.Drawing.Point(179, 119);
            this.AspectTextBox.Name = "AspectTextBox";
            this.AspectTextBox.Size = new System.Drawing.Size(60, 20);
            this.AspectTextBox.TabIndex = 7;
            this.AspectTextBox.TextChanged += new System.EventHandler(this.AspectTextBox_TextChanged);
            // 
            // aspectRatioLabel
            // 
            this.aspectRatioLabel.AutoSize = true;
            this.aspectRatioLabel.Location = new System.Drawing.Point(111, 77);
            this.aspectRatioLabel.Name = "aspectRatioLabel";
            this.aspectRatioLabel.Size = new System.Drawing.Size(63, 13);
            this.aspectRatioLabel.TabIndex = 8;
            this.aspectRatioLabel.Text = "Aspect ratio";
            // 
            // dimensionsLabel
            // 
            this.dimensionsLabel.AutoSize = true;
            this.dimensionsLabel.Location = new System.Drawing.Point(114, 181);
            this.dimensionsLabel.Name = "dimensionsLabel";
            this.dimensionsLabel.Size = new System.Drawing.Size(61, 13);
            this.dimensionsLabel.TabIndex = 9;
            this.dimensionsLabel.Text = "Dimensions";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 321);
            this.Controls.Add(this.dimensionsLabel);
            this.Controls.Add(this.aspectRatioLabel);
            this.Controls.Add(this.AspectTextBox);
            this.Controls.Add(this.ratioHeightTextBox);
            this.Controls.Add(this.colonLabel);
            this.Controls.Add(this.ratioWidthTextBox);
            this.Controls.Add(this.numberRadioButton);
            this.Controls.Add(this.ratioRadioButton);
            this.Controls.Add(this.unitComboBox);
            this.Controls.Add(this.pixelsTextBox);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(480, 360);
            this.MinimumSize = new System.Drawing.Size(480, 360);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pixel and Aspect to Dimensions";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pixelsTextBox;
        private System.Windows.Forms.ComboBox unitComboBox;
        private System.Windows.Forms.RadioButton ratioRadioButton;
        private System.Windows.Forms.RadioButton numberRadioButton;
        private System.Windows.Forms.TextBox ratioWidthTextBox;
        private System.Windows.Forms.Label colonLabel;
        private System.Windows.Forms.TextBox ratioHeightTextBox;
        private System.Windows.Forms.TextBox AspectTextBox;
        private System.Windows.Forms.Label aspectRatioLabel;
        private System.Windows.Forms.Label dimensionsLabel;
    }
}

