namespace Uno
{
    partial class HighScores
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
            this.rankLable = new System.Windows.Forms.Label();
            this.dateTimeLabel = new System.Windows.Forms.Label();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.dateFormatButton = new System.Windows.Forms.Button();
            this.resetScoresButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rankLable
            // 
            this.rankLable.AutoSize = true;
            this.rankLable.Location = new System.Drawing.Point(12, 9);
            this.rankLable.Name = "rankLable";
            this.rankLable.Size = new System.Drawing.Size(36, 286);
            this.rankLable.TabIndex = 0;
            this.rankLable.Text = "Rank \r\n\r\n\r\n1\r\n\r\n2\r\n\r\n3\r\n\r\n4\r\n\r\n5\r\n\r\n6\r\n\r\n7\r\n\r\n8\r\n\r\n9\r\n\r\n10";
            this.rankLable.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dateTimeLabel
            // 
            this.dateTimeLabel.AutoSize = true;
            this.dateTimeLabel.Location = new System.Drawing.Point(99, 9);
            this.dateTimeLabel.Name = "dateTimeLabel";
            this.dateTimeLabel.Size = new System.Drawing.Size(58, 13);
            this.dateTimeLabel.TabIndex = 1;
            this.dateTimeLabel.Text = "Date/Time";
            this.dateTimeLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Location = new System.Drawing.Point(231, 9);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(35, 13);
            this.userNameLabel.TabIndex = 2;
            this.userNameLabel.Text = "Name";
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Location = new System.Drawing.Point(417, 9);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(35, 286);
            this.scoreLabel.TabIndex = 3;
            this.scoreLabel.Text = "Score\r\n\r\n\r\n0\r\n\r\n0\r\n\r\n0\r\n\r\n0\r\n\r\n0\r\n\r\n0\r\n\r\n0\r\n\r\n0\r\n\r\n0\r\n\r\n0";
            this.scoreLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.okButton.Location = new System.Drawing.Point(102, 313);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 4;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // dateFormatButton
            // 
            this.dateFormatButton.Location = new System.Drawing.Point(191, 313);
            this.dateFormatButton.Name = "dateFormatButton";
            this.dateFormatButton.Size = new System.Drawing.Size(75, 23);
            this.dateFormatButton.TabIndex = 5;
            this.dateFormatButton.Text = "Date Format";
            this.dateFormatButton.UseVisualStyleBackColor = true;
            this.dateFormatButton.Click += new System.EventHandler(this.dateFormatButton_Click);
            // 
            // resetScoresButton
            // 
            this.resetScoresButton.Location = new System.Drawing.Point(272, 313);
            this.resetScoresButton.Name = "resetScoresButton";
            this.resetScoresButton.Size = new System.Drawing.Size(75, 23);
            this.resetScoresButton.TabIndex = 6;
            this.resetScoresButton.Text = "Reset";
            this.resetScoresButton.UseVisualStyleBackColor = true;
            this.resetScoresButton.Click += new System.EventHandler(this.resetScoresButton_Click);
            // 
            // HighScores
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.okButton;
            this.ClientSize = new System.Drawing.Size(464, 349);
            this.Controls.Add(this.resetScoresButton);
            this.Controls.Add(this.dateFormatButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.dateTimeLabel);
            this.Controls.Add(this.rankLable);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(480, 388);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(480, 388);
            this.Name = "HighScores";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "High Scores";
            this.Load += new System.EventHandler(this.HighScores_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label rankLable;
        private System.Windows.Forms.Label dateTimeLabel;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button dateFormatButton;
        private System.Windows.Forms.Button resetScoresButton;
    }
}