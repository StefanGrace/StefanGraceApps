namespace FilenameDateTimesToSRT
{
    partial class ErrorListForm
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
            this.errorsTextBox = new System.Windows.Forms.TextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.filenamesRadioButton = new System.Windows.Forms.RadioButton();
            this.exceptionsRadioButton = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // errorsTextBox
            // 
            this.errorsTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.errorsTextBox.Location = new System.Drawing.Point(13, 13);
            this.errorsTextBox.Multiline = true;
            this.errorsTextBox.Name = "errorsTextBox";
            this.errorsTextBox.ReadOnly = true;
            this.errorsTextBox.Size = new System.Drawing.Size(359, 233);
            this.errorsTextBox.TabIndex = 0;
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.okButton.Location = new System.Drawing.Point(294, 252);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(78, 23);
            this.okButton.TabIndex = 1;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // filenamesRadioButton
            // 
            this.filenamesRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.filenamesRadioButton.AutoSize = true;
            this.filenamesRadioButton.Checked = true;
            this.filenamesRadioButton.Location = new System.Drawing.Point(13, 252);
            this.filenamesRadioButton.Name = "filenamesRadioButton";
            this.filenamesRadioButton.Size = new System.Drawing.Size(72, 17);
            this.filenamesRadioButton.TabIndex = 2;
            this.filenamesRadioButton.TabStop = true;
            this.filenamesRadioButton.Text = "Filenames";
            this.filenamesRadioButton.UseVisualStyleBackColor = true;
            this.filenamesRadioButton.CheckedChanged += new System.EventHandler(this.filenamesRadioButton_CheckedChanged);
            // 
            // exceptionsRadioButton
            // 
            this.exceptionsRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.exceptionsRadioButton.AutoSize = true;
            this.exceptionsRadioButton.Location = new System.Drawing.Point(91, 252);
            this.exceptionsRadioButton.Name = "exceptionsRadioButton";
            this.exceptionsRadioButton.Size = new System.Drawing.Size(97, 17);
            this.exceptionsRadioButton.TabIndex = 3;
            this.exceptionsRadioButton.Text = "Error messages";
            this.exceptionsRadioButton.UseVisualStyleBackColor = true;
            this.exceptionsRadioButton.CheckedChanged += new System.EventHandler(this.exceptionsRadioButton_CheckedChanged);
            // 
            // ErrorListForm
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.okButton;
            this.ClientSize = new System.Drawing.Size(384, 281);
            this.Controls.Add(this.exceptionsRadioButton);
            this.Controls.Add(this.filenamesRadioButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.errorsTextBox);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(360, 240);
            this.Name = "ErrorListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Error List";
            this.Load += new System.EventHandler(this.ErrorListForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox errorsTextBox;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.RadioButton filenamesRadioButton;
        private System.Windows.Forms.RadioButton exceptionsRadioButton;
    }
}