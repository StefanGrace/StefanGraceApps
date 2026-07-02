namespace CSV_to_TableTXT
{
    partial class MainForm
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
            this.inputCSVTextBox = new System.Windows.Forms.TextBox();
            this.outputTXTTextBox = new System.Windows.Forms.TextBox();
            this.inputCSVLabel = new System.Windows.Forms.Label();
            this.outputTXTLabel = new System.Windows.Forms.Label();
            this.footerCheckBox = new System.Windows.Forms.CheckBox();
            this.bordersCheckBox = new System.Windows.Forms.CheckBox();
            this.aligmentLabel = new System.Windows.Forms.Label();
            this.alignmentComboBox = new System.Windows.Forms.ComboBox();
            this.alignmentHelpButton = new System.Windows.Forms.Button();
            this.alignmentTextBox = new System.Windows.Forms.TextBox();
            this.widthLimitCheckBox = new System.Windows.Forms.CheckBox();
            this.widthAllRadioButton = new System.Windows.Forms.RadioButton();
            this.widthIndividualRadioButton = new System.Windows.Forms.RadioButton();
            this.widthAllNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.widthIndividualTextBox = new System.Windows.Forms.TextBox();
            this.widthIndividualHelpButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.previewButton = new System.Windows.Forms.Button();
            this.autoAlignmentComboBox = new System.Windows.Forms.ComboBox();
            this.autoAlignmentLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.widthAllNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // inputCSVTextBox
            // 
            this.inputCSVTextBox.Location = new System.Drawing.Point(12, 26);
            this.inputCSVTextBox.Name = "inputCSVTextBox";
            this.inputCSVTextBox.Size = new System.Drawing.Size(560, 20);
            this.inputCSVTextBox.TabIndex = 0;
            // 
            // outputTXTTextBox
            // 
            this.outputTXTTextBox.Location = new System.Drawing.Point(12, 72);
            this.outputTXTTextBox.Name = "outputTXTTextBox";
            this.outputTXTTextBox.Size = new System.Drawing.Size(560, 20);
            this.outputTXTTextBox.TabIndex = 1;
            // 
            // inputCSVLabel
            // 
            this.inputCSVLabel.AutoSize = true;
            this.inputCSVLabel.Location = new System.Drawing.Point(13, 7);
            this.inputCSVLabel.Name = "inputCSVLabel";
            this.inputCSVLabel.Size = new System.Drawing.Size(98, 13);
            this.inputCSVLabel.TabIndex = 2;
            this.inputCSVLabel.Text = "Input CSV file path:";
            // 
            // outputTXTLabel
            // 
            this.outputTXTLabel.AutoSize = true;
            this.outputTXTLabel.Location = new System.Drawing.Point(13, 56);
            this.outputTXTLabel.Name = "outputTXTLabel";
            this.outputTXTLabel.Size = new System.Drawing.Size(106, 13);
            this.outputTXTLabel.TabIndex = 3;
            this.outputTXTLabel.Text = "Output TXT file path:";
            // 
            // footerCheckBox
            // 
            this.footerCheckBox.AutoSize = true;
            this.footerCheckBox.Location = new System.Drawing.Point(16, 109);
            this.footerCheckBox.Name = "footerCheckBox";
            this.footerCheckBox.Size = new System.Drawing.Size(106, 17);
            this.footerCheckBox.TabIndex = 2;
            this.footerCheckBox.Text = "Last row is footer";
            this.footerCheckBox.UseVisualStyleBackColor = true;
            this.footerCheckBox.CheckedChanged += new System.EventHandler(this.footerCheckBox_CheckedChanged);
            // 
            // bordersCheckBox
            // 
            this.bordersCheckBox.AutoSize = true;
            this.bordersCheckBox.Checked = true;
            this.bordersCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.bordersCheckBox.Location = new System.Drawing.Point(159, 109);
            this.bordersCheckBox.Name = "bordersCheckBox";
            this.bordersCheckBox.Size = new System.Drawing.Size(157, 17);
            this.bordersCheckBox.TabIndex = 3;
            this.bordersCheckBox.Text = "Add top and bottom borders";
            this.bordersCheckBox.UseVisualStyleBackColor = true;
            this.bordersCheckBox.CheckedChanged += new System.EventHandler(this.bordersCheckBox_CheckedChanged);
            // 
            // aligmentLabel
            // 
            this.aligmentLabel.AutoSize = true;
            this.aligmentLabel.Location = new System.Drawing.Point(11, 144);
            this.aligmentLabel.Name = "aligmentLabel";
            this.aligmentLabel.Size = new System.Drawing.Size(56, 13);
            this.aligmentLabel.TabIndex = 6;
            this.aligmentLabel.Text = "Alignment:";
            // 
            // alignmentComboBox
            // 
            this.alignmentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.alignmentComboBox.FormattingEnabled = true;
            this.alignmentComboBox.Items.AddRange(new object[] {
            "Auto",
            "Left",
            "Right",
            "Manual"});
            this.alignmentComboBox.Location = new System.Drawing.Point(73, 141);
            this.alignmentComboBox.Name = "alignmentComboBox";
            this.alignmentComboBox.Size = new System.Drawing.Size(121, 21);
            this.alignmentComboBox.TabIndex = 4;
            this.alignmentComboBox.SelectedIndexChanged += new System.EventHandler(this.alignmentComboBox_SelectedIndexChanged);
            // 
            // alignmentHelpButton
            // 
            this.alignmentHelpButton.Location = new System.Drawing.Point(200, 140);
            this.alignmentHelpButton.Name = "alignmentHelpButton";
            this.alignmentHelpButton.Size = new System.Drawing.Size(23, 23);
            this.alignmentHelpButton.TabIndex = 5;
            this.alignmentHelpButton.Text = "?";
            this.alignmentHelpButton.UseVisualStyleBackColor = true;
            // 
            // alignmentTextBox
            // 
            this.alignmentTextBox.Location = new System.Drawing.Point(229, 141);
            this.alignmentTextBox.Name = "alignmentTextBox";
            this.alignmentTextBox.Size = new System.Drawing.Size(338, 20);
            this.alignmentTextBox.TabIndex = 6;
            // 
            // widthLimitCheckBox
            // 
            this.widthLimitCheckBox.AutoSize = true;
            this.widthLimitCheckBox.Location = new System.Drawing.Point(16, 219);
            this.widthLimitCheckBox.Name = "widthLimitCheckBox";
            this.widthLimitCheckBox.Size = new System.Drawing.Size(137, 17);
            this.widthLimitCheckBox.TabIndex = 7;
            this.widthLimitCheckBox.Text = "Limit max column width ";
            this.widthLimitCheckBox.UseVisualStyleBackColor = true;
            // 
            // widthAllRadioButton
            // 
            this.widthAllRadioButton.AutoSize = true;
            this.widthAllRadioButton.Checked = true;
            this.widthAllRadioButton.Location = new System.Drawing.Point(159, 219);
            this.widthAllRadioButton.Name = "widthAllRadioButton";
            this.widthAllRadioButton.Size = new System.Drawing.Size(98, 17);
            this.widthAllRadioButton.TabIndex = 8;
            this.widthAllRadioButton.TabStop = true;
            this.widthAllRadioButton.Text = "For all columns:";
            this.widthAllRadioButton.UseVisualStyleBackColor = true;
            // 
            // widthIndividualRadioButton
            // 
            this.widthIndividualRadioButton.AutoSize = true;
            this.widthIndividualRadioButton.Location = new System.Drawing.Point(159, 243);
            this.widthIndividualRadioButton.Name = "widthIndividualRadioButton";
            this.widthIndividualRadioButton.Size = new System.Drawing.Size(132, 17);
            this.widthIndividualRadioButton.TabIndex = 10;
            this.widthIndividualRadioButton.Text = "For individual columns:";
            this.widthIndividualRadioButton.UseVisualStyleBackColor = true;
            // 
            // widthAllNumericUpDown
            // 
            this.widthAllNumericUpDown.Location = new System.Drawing.Point(264, 217);
            this.widthAllNumericUpDown.Name = "widthAllNumericUpDown";
            this.widthAllNumericUpDown.Size = new System.Drawing.Size(52, 20);
            this.widthAllNumericUpDown.TabIndex = 9;
            // 
            // widthIndividualTextBox
            // 
            this.widthIndividualTextBox.Location = new System.Drawing.Point(326, 243);
            this.widthIndividualTextBox.Name = "widthIndividualTextBox";
            this.widthIndividualTextBox.Size = new System.Drawing.Size(241, 20);
            this.widthIndividualTextBox.TabIndex = 12;
            // 
            // widthIndividualHelpButton
            // 
            this.widthIndividualHelpButton.Location = new System.Drawing.Point(297, 241);
            this.widthIndividualHelpButton.Name = "widthIndividualHelpButton";
            this.widthIndividualHelpButton.Size = new System.Drawing.Size(23, 23);
            this.widthIndividualHelpButton.TabIndex = 11;
            this.widthIndividualHelpButton.Text = "?";
            this.widthIndividualHelpButton.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(497, 285);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 14;
            this.saveButton.Text = "Save TXT";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // previewButton
            // 
            this.previewButton.Location = new System.Drawing.Point(416, 285);
            this.previewButton.Name = "previewButton";
            this.previewButton.Size = new System.Drawing.Size(75, 23);
            this.previewButton.TabIndex = 13;
            this.previewButton.Text = "Preview...";
            this.previewButton.UseVisualStyleBackColor = true;
            this.previewButton.Click += new System.EventHandler(this.previewButton_Click);
            // 
            // autoAlignmentComboBox
            // 
            this.autoAlignmentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.autoAlignmentComboBox.FormattingEnabled = true;
            this.autoAlignmentComboBox.Items.AddRange(new object[] {
            "First data row",
            "Majority (left if equal)",
            "Majority (right if equal)",
            "All have to be numeric for right-alignment",
            "At least one has to be numeric for right-alignment"});
            this.autoAlignmentComboBox.Location = new System.Drawing.Point(146, 169);
            this.autoAlignmentComboBox.Name = "autoAlignmentComboBox";
            this.autoAlignmentComboBox.Size = new System.Drawing.Size(265, 21);
            this.autoAlignmentComboBox.TabIndex = 15;
            this.autoAlignmentComboBox.SelectedIndexChanged += new System.EventHandler(this.autoAlignmentComboBox_SelectedIndexChanged);
            // 
            // autoAlignmentLabel
            // 
            this.autoAlignmentLabel.AutoSize = true;
            this.autoAlignmentLabel.Location = new System.Drawing.Point(11, 172);
            this.autoAlignmentLabel.Name = "autoAlignmentLabel";
            this.autoAlignmentLabel.Size = new System.Drawing.Size(127, 13);
            this.autoAlignmentLabel.TabIndex = 16;
            this.autoAlignmentLabel.Text = "Auto-alignment detection:";
            // 
            // MainForm
            // 
            this.AcceptButton = this.saveButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 321);
            this.Controls.Add(this.autoAlignmentLabel);
            this.Controls.Add(this.autoAlignmentComboBox);
            this.Controls.Add(this.previewButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.widthIndividualTextBox);
            this.Controls.Add(this.widthAllNumericUpDown);
            this.Controls.Add(this.widthIndividualRadioButton);
            this.Controls.Add(this.widthAllRadioButton);
            this.Controls.Add(this.widthLimitCheckBox);
            this.Controls.Add(this.alignmentTextBox);
            this.Controls.Add(this.widthIndividualHelpButton);
            this.Controls.Add(this.alignmentHelpButton);
            this.Controls.Add(this.alignmentComboBox);
            this.Controls.Add(this.aligmentLabel);
            this.Controls.Add(this.bordersCheckBox);
            this.Controls.Add(this.footerCheckBox);
            this.Controls.Add(this.outputTXTLabel);
            this.Controls.Add(this.inputCSVLabel);
            this.Controls.Add(this.outputTXTTextBox);
            this.Controls.Add(this.inputCSVTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CSV to Table TXT Converter";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.widthAllNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputCSVTextBox;
        private System.Windows.Forms.TextBox outputTXTTextBox;
        private System.Windows.Forms.Label inputCSVLabel;
        private System.Windows.Forms.Label outputTXTLabel;
        private System.Windows.Forms.CheckBox footerCheckBox;
        private System.Windows.Forms.CheckBox bordersCheckBox;
        private System.Windows.Forms.Label aligmentLabel;
        private System.Windows.Forms.ComboBox alignmentComboBox;
        private System.Windows.Forms.Button alignmentHelpButton;
        private System.Windows.Forms.TextBox alignmentTextBox;
        private System.Windows.Forms.CheckBox widthLimitCheckBox;
        private System.Windows.Forms.RadioButton widthAllRadioButton;
        private System.Windows.Forms.RadioButton widthIndividualRadioButton;
        private System.Windows.Forms.NumericUpDown widthAllNumericUpDown;
        private System.Windows.Forms.TextBox widthIndividualTextBox;
        private System.Windows.Forms.Button widthIndividualHelpButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button previewButton;
        private System.Windows.Forms.ComboBox autoAlignmentComboBox;
        private System.Windows.Forms.Label autoAlignmentLabel;
    }
}

