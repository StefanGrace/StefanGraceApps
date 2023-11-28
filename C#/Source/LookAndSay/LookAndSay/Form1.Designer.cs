namespace LookAndSay
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
            this.StartTextBox = new System.Windows.Forms.TextBox();
            this.StartLabel = new System.Windows.Forms.Label();
            this.IterationsLabel = new System.Windows.Forms.Label();
            this.IterationsTextBox = new System.Windows.Forms.TextBox();
            this.OutputLabel = new System.Windows.Forms.Label();
            this.OutputTextBox = new System.Windows.Forms.RichTextBox();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StartTextBox
            // 
            this.StartTextBox.Location = new System.Drawing.Point(67, 41);
            this.StartTextBox.MaxLength = 20;
            this.StartTextBox.Name = "StartTextBox";
            this.StartTextBox.Size = new System.Drawing.Size(134, 20);
            this.StartTextBox.TabIndex = 0;
            this.StartTextBox.Text = "1";
            // 
            // StartLabel
            // 
            this.StartLabel.AutoSize = true;
            this.StartLabel.Location = new System.Drawing.Point(32, 44);
            this.StartLabel.Name = "StartLabel";
            this.StartLabel.Size = new System.Drawing.Size(32, 13);
            this.StartLabel.TabIndex = 1;
            this.StartLabel.Text = "Start:";
            // 
            // IterationsLabel
            // 
            this.IterationsLabel.AutoSize = true;
            this.IterationsLabel.Location = new System.Drawing.Point(207, 44);
            this.IterationsLabel.Name = "IterationsLabel";
            this.IterationsLabel.Size = new System.Drawing.Size(53, 13);
            this.IterationsLabel.TabIndex = 1;
            this.IterationsLabel.Text = "Iterations:";
            // 
            // IterationsTextBox
            // 
            this.IterationsTextBox.Location = new System.Drawing.Point(263, 41);
            this.IterationsTextBox.MaxLength = 2;
            this.IterationsTextBox.Name = "IterationsTextBox";
            this.IterationsTextBox.Size = new System.Drawing.Size(21, 20);
            this.IterationsTextBox.TabIndex = 1;
            this.IterationsTextBox.Text = "20";
            // 
            // OutputLabel
            // 
            this.OutputLabel.AutoSize = true;
            this.OutputLabel.Location = new System.Drawing.Point(35, 82);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.Size = new System.Drawing.Size(42, 13);
            this.OutputLabel.TabIndex = 2;
            this.OutputLabel.Text = "Output:";
            // 
            // OutputTextBox
            // 
            this.OutputTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OutputTextBox.Location = new System.Drawing.Point(35, 98);
            this.OutputTextBox.Name = "OutputTextBox";
            this.OutputTextBox.ReadOnly = true;
            this.OutputTextBox.Size = new System.Drawing.Size(562, 331);
            this.OutputTextBox.TabIndex = 3;
            this.OutputTextBox.Text = "";
            this.OutputTextBox.WordWrap = false;
            // 
            // GenerateButton
            // 
            this.GenerateButton.Location = new System.Drawing.Point(327, 39);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(75, 23);
            this.GenerateButton.TabIndex = 2;
            this.GenerateButton.Text = "Generate";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.GenerateButton);
            this.Controls.Add(this.OutputTextBox);
            this.Controls.Add(this.OutputLabel);
            this.Controls.Add(this.IterationsLabel);
            this.Controls.Add(this.StartLabel);
            this.Controls.Add(this.IterationsTextBox);
            this.Controls.Add(this.StartTextBox);
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Look and Say";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox StartTextBox;
        private System.Windows.Forms.Label StartLabel;
        private System.Windows.Forms.Label IterationsLabel;
        private System.Windows.Forms.TextBox IterationsTextBox;
        private System.Windows.Forms.Label OutputLabel;
        private System.Windows.Forms.RichTextBox OutputTextBox;
        private System.Windows.Forms.Button GenerateButton;
    }
}

