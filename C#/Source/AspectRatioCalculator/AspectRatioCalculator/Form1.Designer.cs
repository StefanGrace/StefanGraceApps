namespace AspectRatioCalculator
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
            this.widthTextBox = new System.Windows.Forms.TextBox();
            this.heightTextBox = new System.Windows.Forms.TextBox();
            this.aspectRatioLabel = new System.Windows.Forms.Label();
            this.widthLabel = new System.Windows.Forms.Label();
            this.heightLabel = new System.Windows.Forms.Label();
            this.clearWidthButton = new System.Windows.Forms.Button();
            this.clearHeightButton = new System.Windows.Forms.Button();
            this.clearAllButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // widthTextBox
            // 
            this.widthTextBox.Location = new System.Drawing.Point(83, 34);
            this.widthTextBox.Name = "widthTextBox";
            this.widthTextBox.Size = new System.Drawing.Size(100, 20);
            this.widthTextBox.TabIndex = 0;
            this.widthTextBox.TextChanged += new System.EventHandler(this.widthTextBox_TextChanged);
            // 
            // heightTextBox
            // 
            this.heightTextBox.Location = new System.Drawing.Point(83, 68);
            this.heightTextBox.Name = "heightTextBox";
            this.heightTextBox.Size = new System.Drawing.Size(100, 20);
            this.heightTextBox.TabIndex = 1;
            this.heightTextBox.TextChanged += new System.EventHandler(this.heightTextBox_TextChanged);
            // 
            // aspectRatioLabel
            // 
            this.aspectRatioLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.aspectRatioLabel.AutoSize = true;
            this.aspectRatioLabel.Location = new System.Drawing.Point(128, 94);
            this.aspectRatioLabel.Name = "aspectRatioLabel";
            this.aspectRatioLabel.Size = new System.Drawing.Size(0, 13);
            this.aspectRatioLabel.TabIndex = 2;
            this.aspectRatioLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Location = new System.Drawing.Point(42, 37);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(35, 13);
            this.widthLabel.TabIndex = 3;
            this.widthLabel.Text = "Width";
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Location = new System.Drawing.Point(39, 68);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(38, 13);
            this.heightLabel.TabIndex = 4;
            this.heightLabel.Text = "Height";
            // 
            // clearWidthButton
            // 
            this.clearWidthButton.Location = new System.Drawing.Point(189, 34);
            this.clearWidthButton.Name = "clearWidthButton";
            this.clearWidthButton.Size = new System.Drawing.Size(75, 20);
            this.clearWidthButton.TabIndex = 5;
            this.clearWidthButton.Text = "Clear";
            this.clearWidthButton.UseVisualStyleBackColor = true;
            this.clearWidthButton.Click += new System.EventHandler(this.clearWidthButton_Click);
            // 
            // clearHeightButton
            // 
            this.clearHeightButton.Location = new System.Drawing.Point(189, 68);
            this.clearHeightButton.Name = "clearHeightButton";
            this.clearHeightButton.Size = new System.Drawing.Size(75, 20);
            this.clearHeightButton.TabIndex = 6;
            this.clearHeightButton.Text = "Clear";
            this.clearHeightButton.UseVisualStyleBackColor = true;
            this.clearHeightButton.Click += new System.EventHandler(this.clearHeightButton_Click);
            // 
            // clearAllButton
            // 
            this.clearAllButton.Location = new System.Drawing.Point(83, 119);
            this.clearAllButton.Name = "clearAllButton";
            this.clearAllButton.Size = new System.Drawing.Size(100, 23);
            this.clearAllButton.TabIndex = 7;
            this.clearAllButton.Text = "Clear All";
            this.clearAllButton.UseVisualStyleBackColor = true;
            this.clearAllButton.Click += new System.EventHandler(this.clearAllButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 188);
            this.Controls.Add(this.clearAllButton);
            this.Controls.Add(this.clearHeightButton);
            this.Controls.Add(this.clearWidthButton);
            this.Controls.Add(this.heightLabel);
            this.Controls.Add(this.widthLabel);
            this.Controls.Add(this.aspectRatioLabel);
            this.Controls.Add(this.heightTextBox);
            this.Controls.Add(this.widthTextBox);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(324, 227);
            this.MinimumSize = new System.Drawing.Size(324, 227);
            this.Name = "Form1";
            this.Text = "Aspect Ratio Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox widthTextBox;
        private System.Windows.Forms.TextBox heightTextBox;
        private System.Windows.Forms.Label aspectRatioLabel;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.Button clearWidthButton;
        private System.Windows.Forms.Button clearHeightButton;
        private System.Windows.Forms.Button clearAllButton;
    }
}

