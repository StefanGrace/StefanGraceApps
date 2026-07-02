namespace RomanNumerals
{
    partial class HelpForm
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
            this.label_numerals = new System.Windows.Forms.Label();
            this.label_subtractiveNotation = new System.Windows.Forms.Label();
            this.label_fractions = new System.Windows.Forms.Label();
            this.label_numeralsHeading = new System.Windows.Forms.Label();
            this.label_subtractiveNotationHeading = new System.Windows.Forms.Label();
            this.label_fractionsHeading = new System.Windows.Forms.Label();
            this.button_close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_numerals
            // 
            this.label_numerals.AutoSize = true;
            this.label_numerals.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_numerals.Location = new System.Drawing.Point(12, 35);
            this.label_numerals.Name = "label_numerals";
            this.label_numerals.Size = new System.Drawing.Size(83, 147);
            this.label_numerals.TabIndex = 0;
            this.label_numerals.Text = "I = 1\r\nV = 5\r\nX = 10\r\nL = 50\r\nC = 100\r\nD = 500\r\nM = 1000\r\n";
            // 
            // label_subtractiveNotation
            // 
            this.label_subtractiveNotation.AutoSize = true;
            this.label_subtractiveNotation.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_subtractiveNotation.Location = new System.Drawing.Point(126, 35);
            this.label_subtractiveNotation.Name = "label_subtractiveNotation";
            this.label_subtractiveNotation.Size = new System.Drawing.Size(87, 147);
            this.label_subtractiveNotation.TabIndex = 0;
            this.label_subtractiveNotation.Text = "\r\nIV = 4\r\nIX = 9\r\nXL = 40\r\nXC = 90\r\nCD = 400\r\nCM = 900";
            // 
            // label_fractions
            // 
            this.label_fractions.AutoSize = true;
            this.label_fractions.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_fractions.Location = new System.Drawing.Point(250, 35);
            this.label_fractions.Name = "label_fractions";
            this.label_fractions.Size = new System.Drawing.Size(69, 42);
            this.label_fractions.TabIndex = 0;
            this.label_fractions.Text = "· = 1/12\r\nS = 1/2";
            // 
            // label_numeralsHeading
            // 
            this.label_numeralsHeading.AutoSize = true;
            this.label_numeralsHeading.Location = new System.Drawing.Point(13, 9);
            this.label_numeralsHeading.Name = "label_numeralsHeading";
            this.label_numeralsHeading.Size = new System.Drawing.Size(54, 13);
            this.label_numeralsHeading.TabIndex = 1;
            this.label_numeralsHeading.Text = "Numerals:";
            // 
            // label_subtractiveNotationHeading
            // 
            this.label_subtractiveNotationHeading.AllowDrop = true;
            this.label_subtractiveNotationHeading.AutoSize = true;
            this.label_subtractiveNotationHeading.Location = new System.Drawing.Point(127, 9);
            this.label_subtractiveNotationHeading.Name = "label_subtractiveNotationHeading";
            this.label_subtractiveNotationHeading.Size = new System.Drawing.Size(64, 26);
            this.label_subtractiveNotationHeading.TabIndex = 1;
            this.label_subtractiveNotationHeading.Text = "Subtractive \r\nnotation:";
            // 
            // label_fractionsHeading
            // 
            this.label_fractionsHeading.AutoSize = true;
            this.label_fractionsHeading.Location = new System.Drawing.Point(251, 9);
            this.label_fractionsHeading.Name = "label_fractionsHeading";
            this.label_fractionsHeading.Size = new System.Drawing.Size(53, 13);
            this.label_fractionsHeading.TabIndex = 1;
            this.label_fractionsHeading.Text = "Fractions:";
            // 
            // button_close
            // 
            this.button_close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_close.Location = new System.Drawing.Point(279, 192);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(75, 23);
            this.button_close.TabIndex = 2;
            this.button_close.Text = "Close";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // HelpForm
            // 
            this.AcceptButton = this.button_close;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button_close;
            this.ClientSize = new System.Drawing.Size(366, 227);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.label_subtractiveNotationHeading);
            this.Controls.Add(this.label_fractionsHeading);
            this.Controls.Add(this.label_numeralsHeading);
            this.Controls.Add(this.label_fractions);
            this.Controls.Add(this.label_subtractiveNotation);
            this.Controls.Add(this.label_numerals);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "HelpForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Roman Numerals Help";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_numerals;
        private System.Windows.Forms.Label label_subtractiveNotation;
        private System.Windows.Forms.Label label_fractions;
        private System.Windows.Forms.Label label_numeralsHeading;
        private System.Windows.Forms.Label label_subtractiveNotationHeading;
        private System.Windows.Forms.Label label_fractionsHeading;
        private System.Windows.Forms.Button button_close;
    }
}