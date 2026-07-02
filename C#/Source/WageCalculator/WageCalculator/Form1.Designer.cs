namespace WageCalculator
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.monthlyLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.goButton = new System.Windows.Forms.Button();
            this.weeklyLabel = new System.Windows.Forms.Label();
            this.dailyLabel = new System.Windows.Forms.Label();
            this.outputMessageLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bradley Hand ITC", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(404, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "To calculate your Monthly, Weekly and Daily Wage...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Papyrus", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.Location = new System.Drawing.Point(13, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Please type in your yearly wage.";
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(16, 72);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(208, 20);
            this.inputTextBox.TabIndex = 2;
            // 
            // monthlyLabel
            // 
            this.monthlyLabel.AutoSize = true;
            this.monthlyLabel.Location = new System.Drawing.Point(13, 104);
            this.monthlyLabel.Name = "monthlyLabel";
            this.monthlyLabel.Size = new System.Drawing.Size(47, 13);
            this.monthlyLabel.TabIndex = 3;
            this.monthlyLabel.Text = "Monthly:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 3.75F);
            this.label3.Location = new System.Drawing.Point(16, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 6);
            this.label3.TabIndex = 4;
            this.label3.Text = "(Daily calculation is based on non leap year)";
            // 
            // goButton
            // 
            this.goButton.BackColor = System.Drawing.Color.SeaGreen;
            this.goButton.Location = new System.Drawing.Point(230, 70);
            this.goButton.MaximumSize = new System.Drawing.Size(41, 23);
            this.goButton.MinimumSize = new System.Drawing.Size(41, 23);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(41, 23);
            this.goButton.TabIndex = 5;
            this.goButton.Text = "GO";
            this.goButton.UseVisualStyleBackColor = false;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // weeklyLabel
            // 
            this.weeklyLabel.AutoSize = true;
            this.weeklyLabel.Location = new System.Drawing.Point(13, 127);
            this.weeklyLabel.Name = "weeklyLabel";
            this.weeklyLabel.Size = new System.Drawing.Size(46, 13);
            this.weeklyLabel.TabIndex = 6;
            this.weeklyLabel.Text = "Weekly:";
            // 
            // dailyLabel
            // 
            this.dailyLabel.AutoSize = true;
            this.dailyLabel.Location = new System.Drawing.Point(13, 149);
            this.dailyLabel.Name = "dailyLabel";
            this.dailyLabel.Size = new System.Drawing.Size(33, 13);
            this.dailyLabel.TabIndex = 7;
            this.dailyLabel.Text = "Daily:";
            // 
            // outputMessageLabel
            // 
            this.outputMessageLabel.AutoSize = true;
            this.outputMessageLabel.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputMessageLabel.Location = new System.Drawing.Point(13, 199);
            this.outputMessageLabel.Name = "outputMessageLabel";
            this.outputMessageLabel.Size = new System.Drawing.Size(57, 21);
            this.outputMessageLabel.TabIndex = 8;
            this.outputMessageLabel.Text = "label6";
            this.outputMessageLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 232);
            this.Controls.Add(this.outputMessageLabel);
            this.Controls.Add(this.dailyLabel);
            this.Controls.Add(this.weeklyLabel);
            this.Controls.Add(this.goButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.monthlyLabel);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Wage Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.Label monthlyLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button goButton;
        private System.Windows.Forms.Label weeklyLabel;
        private System.Windows.Forms.Label dailyLabel;
        private System.Windows.Forms.Label outputMessageLabel;
    }
}

