namespace DateFormatter
{
    partial class AmbiguousDateForm
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
            this.label_question = new System.Windows.Forms.Label();
            this.listBox_choices = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label_question
            // 
            this.label_question.AutoSize = true;
            this.label_question.Location = new System.Drawing.Point(13, 13);
            this.label_question.Name = "label_question";
            this.label_question.Size = new System.Drawing.Size(52, 13);
            this.label_question.TabIndex = 0;
            this.label_question.Text = "Question:";
            // 
            // listBox_choices
            // 
            this.listBox_choices.FormattingEnabled = true;
            this.listBox_choices.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.listBox_choices.Location = new System.Drawing.Point(16, 38);
            this.listBox_choices.Name = "listBox_choices";
            this.listBox_choices.Size = new System.Drawing.Size(256, 134);
            this.listBox_choices.TabIndex = 1;
            this.listBox_choices.SelectedIndexChanged += new System.EventHandler(this.listBox_choices_SelectedIndexChanged);
            // 
            // AmbiguousDateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 188);
            this.Controls.Add(this.listBox_choices);
            this.Controls.Add(this.label_question);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 227);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 227);
            this.Name = "AmbiguousDateForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ambiguous Date";
            this.Load += new System.EventHandler(this.AmbiguousDateForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_question;
        private System.Windows.Forms.ListBox listBox_choices;
    }
}