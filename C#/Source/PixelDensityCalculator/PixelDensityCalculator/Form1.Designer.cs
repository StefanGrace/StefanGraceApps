namespace PixelDensityCalculator
{
    partial class pixelDensityCalculatorForm
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
            this.screenSizeInput = new System.Windows.Forms.NumericUpDown();
            this.screenSizeLabel = new System.Windows.Forms.Label();
            this.widthLabel = new System.Windows.Forms.Label();
            this.heightLabel = new System.Windows.Forms.Label();
            this.widthInput = new System.Windows.Forms.NumericUpDown();
            this.heightInput = new System.Windows.Forms.NumericUpDown();
            this.ppiLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.screenSizeInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightInput)).BeginInit();
            this.SuspendLayout();
            // 
            // screenSizeInput
            // 
            this.screenSizeInput.DecimalPlaces = 1;
            this.screenSizeInput.Location = new System.Drawing.Point(158, 34);
            this.screenSizeInput.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.screenSizeInput.Name = "screenSizeInput";
            this.screenSizeInput.Size = new System.Drawing.Size(120, 20);
            this.screenSizeInput.TabIndex = 0;
            this.screenSizeInput.ValueChanged += new System.EventHandler(this.screenSize_ValueChanged);
            // 
            // screenSizeLabel
            // 
            this.screenSizeLabel.AutoSize = true;
            this.screenSizeLabel.Location = new System.Drawing.Point(45, 36);
            this.screenSizeLabel.Name = "screenSizeLabel";
            this.screenSizeLabel.Size = new System.Drawing.Size(107, 13);
            this.screenSizeLabel.TabIndex = 1;
            this.screenSizeLabel.Text = "Screen size in inches";
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Location = new System.Drawing.Point(117, 74);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(35, 13);
            this.widthLabel.TabIndex = 2;
            this.widthLabel.Text = "Width";
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Location = new System.Drawing.Point(114, 111);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(38, 13);
            this.heightLabel.TabIndex = 3;
            this.heightLabel.Text = "Height";
            // 
            // widthInput
            // 
            this.widthInput.Location = new System.Drawing.Point(158, 72);
            this.widthInput.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.widthInput.Name = "widthInput";
            this.widthInput.Size = new System.Drawing.Size(120, 20);
            this.widthInput.TabIndex = 4;
            this.widthInput.ValueChanged += new System.EventHandler(this.width_ValueChanged);
            // 
            // heightInput
            // 
            this.heightInput.Location = new System.Drawing.Point(158, 109);
            this.heightInput.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.heightInput.Name = "heightInput";
            this.heightInput.Size = new System.Drawing.Size(120, 20);
            this.heightInput.TabIndex = 5;
            this.heightInput.ValueChanged += new System.EventHandler(this.height_ValueChanged);
            // 
            // ppiLabel
            // 
            this.ppiLabel.AutoSize = true;
            this.ppiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ppiLabel.Location = new System.Drawing.Point(153, 198);
            this.ppiLabel.Name = "ppiLabel";
            this.ppiLabel.Size = new System.Drawing.Size(19, 25);
            this.ppiLabel.TabIndex = 6;
            this.ppiLabel.Text = " ";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(158, 145);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 7;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            // 
            // pixelDensityCalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 248);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.ppiLabel);
            this.Controls.Add(this.heightInput);
            this.Controls.Add(this.widthInput);
            this.Controls.Add(this.heightLabel);
            this.Controls.Add(this.widthLabel);
            this.Controls.Add(this.screenSizeLabel);
            this.Controls.Add(this.screenSizeInput);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(392, 287);
            this.MinimumSize = new System.Drawing.Size(392, 287);
            this.Name = "pixelDensityCalculatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pixel Density Calculator";
            this.Load += new System.EventHandler(this.pixelDensityCalculatorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.screenSizeInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown screenSizeInput;
        private System.Windows.Forms.Label screenSizeLabel;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.NumericUpDown widthInput;
        private System.Windows.Forms.NumericUpDown heightInput;
        private System.Windows.Forms.Label ppiLabel;
        private System.Windows.Forms.Button calculateButton;
    }
}

