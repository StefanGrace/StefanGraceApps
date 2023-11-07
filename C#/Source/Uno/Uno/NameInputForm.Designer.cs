namespace Uno
{
    partial class NameInputForm
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
            this.submitButton = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.enterYouNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(101, 56);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 1;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(70, 30);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(138, 20);
            this.nameTextBox.TabIndex = 0;
            // 
            // enterYouNameLabel
            // 
            this.enterYouNameLabel.AutoSize = true;
            this.enterYouNameLabel.Location = new System.Drawing.Point(98, 9);
            this.enterYouNameLabel.Name = "enterYouNameLabel";
            this.enterYouNameLabel.Size = new System.Drawing.Size(88, 13);
            this.enterYouNameLabel.TabIndex = 2;
            this.enterYouNameLabel.Text = "Enter Your Name";
            // 
            // NameInputForm
            // 
            this.AcceptButton = this.submitButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 91);
            this.Controls.Add(this.enterYouNameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.submitButton);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 130);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 116);
            this.Name = "NameInputForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "A New High Score!";
            this.Load += new System.EventHandler(this.NameInputForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label enterYouNameLabel;
    }
}