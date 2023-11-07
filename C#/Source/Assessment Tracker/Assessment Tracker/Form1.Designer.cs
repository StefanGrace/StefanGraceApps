namespace Assessment_Tracker
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
            this.label3 = new System.Windows.Forms.Label();
            this.assessmentWeightingTextBox = new System.Windows.Forms.TextBox();
            this.assessmentMarkTextBox = new System.Windows.Forms.TextBox();
            this.submissionMarkTextBox = new System.Windows.Forms.TextBox();
            this.nextButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.paperPercentageLabel = new System.Windows.Forms.Label();
            this.paperGradeLabel = new System.Windows.Forms.Label();
            this.paperStatusLabel = new System.Windows.Forms.Label();
            this.InvalidInputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Assessment Weighting";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Assessment Mark";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Submission Mark";
            // 
            // assessmentWeightingTextBox
            // 
            this.assessmentWeightingTextBox.Location = new System.Drawing.Point(132, 42);
            this.assessmentWeightingTextBox.Name = "assessmentWeightingTextBox";
            this.assessmentWeightingTextBox.Size = new System.Drawing.Size(100, 20);
            this.assessmentWeightingTextBox.TabIndex = 3;
            this.assessmentWeightingTextBox.TextChanged += new System.EventHandler(this.assessmentWeightingTextBox_TextChanged);
            // 
            // assessmentMarkTextBox
            // 
            this.assessmentMarkTextBox.Location = new System.Drawing.Point(132, 68);
            this.assessmentMarkTextBox.Name = "assessmentMarkTextBox";
            this.assessmentMarkTextBox.Size = new System.Drawing.Size(100, 20);
            this.assessmentMarkTextBox.TabIndex = 4;
            this.assessmentMarkTextBox.TextChanged += new System.EventHandler(this.AssessmentMarkTextBox_TextChanged);
            // 
            // submissionMarkTextBox
            // 
            this.submissionMarkTextBox.Location = new System.Drawing.Point(132, 95);
            this.submissionMarkTextBox.Name = "submissionMarkTextBox";
            this.submissionMarkTextBox.Size = new System.Drawing.Size(100, 20);
            this.submissionMarkTextBox.TabIndex = 5;
            this.submissionMarkTextBox.TextChanged += new System.EventHandler(this.submissionMarkTextBox_TextChanged);
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(146, 201);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(75, 23);
            this.nextButton.TabIndex = 6;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Paper Percentage: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Paper Grade:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Paper Status:";
            // 
            // paperPercentageLabel
            // 
            this.paperPercentageLabel.AutoSize = true;
            this.paperPercentageLabel.Location = new System.Drawing.Point(132, 123);
            this.paperPercentageLabel.Name = "paperPercentageLabel";
            this.paperPercentageLabel.Size = new System.Drawing.Size(0, 13);
            this.paperPercentageLabel.TabIndex = 10;
            // 
            // paperGradeLabel
            // 
            this.paperGradeLabel.AutoSize = true;
            this.paperGradeLabel.Location = new System.Drawing.Point(132, 149);
            this.paperGradeLabel.Name = "paperGradeLabel";
            this.paperGradeLabel.Size = new System.Drawing.Size(0, 13);
            this.paperGradeLabel.TabIndex = 11;
            // 
            // paperStatusLabel
            // 
            this.paperStatusLabel.AutoSize = true;
            this.paperStatusLabel.Location = new System.Drawing.Point(132, 175);
            this.paperStatusLabel.Name = "paperStatusLabel";
            this.paperStatusLabel.Size = new System.Drawing.Size(0, 13);
            this.paperStatusLabel.TabIndex = 12;
            // 
            // InvalidInputLabel
            // 
            this.InvalidInputLabel.AutoSize = true;
            this.InvalidInputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvalidInputLabel.ForeColor = System.Drawing.Color.Red;
            this.InvalidInputLabel.Location = new System.Drawing.Point(132, 254);
            this.InvalidInputLabel.Name = "InvalidInputLabel";
            this.InvalidInputLabel.Size = new System.Drawing.Size(78, 13);
            this.InvalidInputLabel.TabIndex = 13;
            this.InvalidInputLabel.Text = "Invalid Input";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 276);
            this.Controls.Add(this.InvalidInputLabel);
            this.Controls.Add(this.paperStatusLabel);
            this.Controls.Add(this.paperGradeLabel);
            this.Controls.Add(this.paperPercentageLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.submissionMarkTextBox);
            this.Controls.Add(this.assessmentMarkTextBox);
            this.Controls.Add(this.assessmentWeightingTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Assessment Tracker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox assessmentWeightingTextBox;
        private System.Windows.Forms.TextBox assessmentMarkTextBox;
        private System.Windows.Forms.TextBox submissionMarkTextBox;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label paperPercentageLabel;
        private System.Windows.Forms.Label paperGradeLabel;
        private System.Windows.Forms.Label paperStatusLabel;
        private System.Windows.Forms.Label InvalidInputLabel;
    }
}

