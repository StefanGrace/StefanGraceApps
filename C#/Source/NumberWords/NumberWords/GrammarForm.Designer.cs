namespace NumberWords
{
    partial class GrammarForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GrammarForm));
            this.IncludeAndCheckBox = new System.Windows.Forms.CheckBox();
            this.NegitiaveMinusCheckBox = new System.Windows.Forms.CheckBox();
            this.CommansCheckBox = new System.Windows.Forms.CheckBox();
            this.ZeroBeforePointCheckBox = new System.Windows.Forms.CheckBox();
            this.ShortHandCheckBox = new System.Windows.Forms.CheckBox();
            this.LetterCasingLabel = new System.Windows.Forms.Label();
            this.LetterCasingComboBox = new System.Windows.Forms.ComboBox();
            this.OkButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IncludeAndCheckBox
            // 
            resources.ApplyResources(this.IncludeAndCheckBox, "IncludeAndCheckBox");
            this.IncludeAndCheckBox.Checked = true;
            this.IncludeAndCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.IncludeAndCheckBox.Name = "IncludeAndCheckBox";
            this.IncludeAndCheckBox.UseVisualStyleBackColor = true;
            // 
            // NegitiaveMinusCheckBox
            // 
            resources.ApplyResources(this.NegitiaveMinusCheckBox, "NegitiaveMinusCheckBox");
            this.NegitiaveMinusCheckBox.Name = "NegitiaveMinusCheckBox";
            this.NegitiaveMinusCheckBox.UseVisualStyleBackColor = true;
            // 
            // CommansCheckBox
            // 
            resources.ApplyResources(this.CommansCheckBox, "CommansCheckBox");
            this.CommansCheckBox.Name = "CommansCheckBox";
            this.CommansCheckBox.UseVisualStyleBackColor = true;
            // 
            // ZeroBeforePointCheckBox
            // 
            resources.ApplyResources(this.ZeroBeforePointCheckBox, "ZeroBeforePointCheckBox");
            this.ZeroBeforePointCheckBox.CausesValidation = false;
            this.ZeroBeforePointCheckBox.Checked = true;
            this.ZeroBeforePointCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ZeroBeforePointCheckBox.Name = "ZeroBeforePointCheckBox";
            this.ZeroBeforePointCheckBox.UseVisualStyleBackColor = true;
            // 
            // ShortHandCheckBox
            // 
            resources.ApplyResources(this.ShortHandCheckBox, "ShortHandCheckBox");
            this.ShortHandCheckBox.Name = "ShortHandCheckBox";
            this.ShortHandCheckBox.UseVisualStyleBackColor = true;
            // 
            // LetterCasingLabel
            // 
            resources.ApplyResources(this.LetterCasingLabel, "LetterCasingLabel");
            this.LetterCasingLabel.Name = "LetterCasingLabel";
            // 
            // LetterCasingComboBox
            // 
            this.LetterCasingComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LetterCasingComboBox.FormattingEnabled = true;
            this.LetterCasingComboBox.Items.AddRange(new object[] {
            resources.GetString("LetterCasingComboBox.Items"),
            resources.GetString("LetterCasingComboBox.Items1"),
            resources.GetString("LetterCasingComboBox.Items2"),
            resources.GetString("LetterCasingComboBox.Items3")});
            resources.ApplyResources(this.LetterCasingComboBox, "LetterCasingComboBox");
            this.LetterCasingComboBox.Name = "LetterCasingComboBox";
            // 
            // OkButton
            // 
            resources.ApplyResources(this.OkButton, "OkButton");
            this.OkButton.Name = "OkButton";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.CancelButton, "CancelButton");
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // GrammarForm
            // 
            this.AcceptButton = this.OkButton;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.LetterCasingComboBox);
            this.Controls.Add(this.LetterCasingLabel);
            this.Controls.Add(this.ShortHandCheckBox);
            this.Controls.Add(this.ZeroBeforePointCheckBox);
            this.Controls.Add(this.CommansCheckBox);
            this.Controls.Add(this.NegitiaveMinusCheckBox);
            this.Controls.Add(this.IncludeAndCheckBox);
            this.MaximizeBox = false;
            this.Name = "GrammarForm";
            this.Load += new System.EventHandler(this.GrammerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox IncludeAndCheckBox;
        private System.Windows.Forms.CheckBox NegitiaveMinusCheckBox;
        private System.Windows.Forms.CheckBox CommansCheckBox;
        private System.Windows.Forms.CheckBox ZeroBeforePointCheckBox;
        private System.Windows.Forms.CheckBox ShortHandCheckBox;
        private System.Windows.Forms.Label LetterCasingLabel;
        private System.Windows.Forms.ComboBox LetterCasingComboBox;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button CancelButton;
    }
}