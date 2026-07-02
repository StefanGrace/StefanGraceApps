namespace DataRateCalculator
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
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.inputPerLabel = new System.Windows.Forms.Label();
            this.inputUnitComboBox = new System.Windows.Forms.ComboBox();
            this.inputTimeTextBox = new System.Windows.Forms.TextBox();
            this.inputTimeComboBox = new System.Windows.Forms.ComboBox();
            this.outputMagnitudeComboBox = new System.Windows.Forms.ComboBox();
            this.outputMagnitudeLabel = new System.Windows.Forms.Label();
            this.outputPrefixTypeLabel = new System.Windows.Forms.Label();
            this.outputPrefixTypeComboBox = new System.Windows.Forms.ComboBox();
            this.outputUnitComboBox = new System.Windows.Forms.ComboBox();
            this.outputUnitLabel = new System.Windows.Forms.Label();
            this.outputPerLabel = new System.Windows.Forms.Label();
            this.outputTimeComboBox = new System.Windows.Forms.ComboBox();
            this.outputTimeLabel = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.autoUpdateCheckBox = new System.Windows.Forms.CheckBox();
            this.inputGroupBox = new System.Windows.Forms.GroupBox();
            this.outputUnitGroupBox = new System.Windows.Forms.GroupBox();
            this.outputTimeTextBox = new System.Windows.Forms.TextBox();
            this.MaxDecPlacesNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.maxDecPlacesLabel = new System.Windows.Forms.Label();
            this.inputGroupBox.SuspendLayout();
            this.outputUnitGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaxDecPlacesNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(6, 19);
            this.inputTextBox.MaxLength = 15;
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(100, 20);
            this.inputTextBox.TabIndex = 0;
            this.inputTextBox.TextChanged += new System.EventHandler(this.inputTextBox_TextChanged);
            // 
            // inputPerLabel
            // 
            this.inputPerLabel.AutoSize = true;
            this.inputPerLabel.Location = new System.Drawing.Point(163, 21);
            this.inputPerLabel.Name = "inputPerLabel";
            this.inputPerLabel.Size = new System.Drawing.Size(22, 13);
            this.inputPerLabel.TabIndex = 1;
            this.inputPerLabel.Text = "per";
            // 
            // inputUnitComboBox
            // 
            this.inputUnitComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.inputUnitComboBox.FormattingEnabled = true;
            this.inputUnitComboBox.Items.AddRange(new object[] {
            "b",
            "B",
            "kb",
            "Kib",
            "kB",
            "KiB",
            "Mb",
            "Mib",
            "MB",
            "MiB",
            "Gb",
            "Gib",
            "GB",
            "GiB",
            "Tb",
            "Tib",
            "TB",
            "TiB",
            "Pb",
            "Pib",
            "PB",
            "PiB",
            "Eb",
            "Eib",
            "EB",
            "EiB",
            "Zb",
            "Zib",
            "ZB",
            "YiB",
            "Yb",
            "Yib",
            "YB",
            "YiB",
            "Rb",
            "Rib",
            "RB",
            "RiB",
            "Qb",
            "Qib",
            "QB",
            "QiB"});
            this.inputUnitComboBox.Location = new System.Drawing.Point(112, 18);
            this.inputUnitComboBox.Name = "inputUnitComboBox";
            this.inputUnitComboBox.Size = new System.Drawing.Size(45, 21);
            this.inputUnitComboBox.TabIndex = 1;
            this.inputUnitComboBox.SelectedIndexChanged += new System.EventHandler(this.inputUnitComboBox_SelectedIndexChanged);
            // 
            // inputTimeTextBox
            // 
            this.inputTimeTextBox.Location = new System.Drawing.Point(191, 19);
            this.inputTimeTextBox.MaxLength = 10;
            this.inputTimeTextBox.Name = "inputTimeTextBox";
            this.inputTimeTextBox.Size = new System.Drawing.Size(70, 20);
            this.inputTimeTextBox.TabIndex = 2;
            this.inputTimeTextBox.Text = "1";
            this.inputTimeTextBox.TextChanged += new System.EventHandler(this.inputTimeTextBox_TextChanged);
            // 
            // inputTimeComboBox
            // 
            this.inputTimeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.inputTimeComboBox.FormattingEnabled = true;
            this.inputTimeComboBox.Items.AddRange(new object[] {
            "ms",
            "s",
            "min",
            "h",
            "day",
            "week",
            "year",
            "decade"});
            this.inputTimeComboBox.Location = new System.Drawing.Point(268, 18);
            this.inputTimeComboBox.Name = "inputTimeComboBox";
            this.inputTimeComboBox.Size = new System.Drawing.Size(64, 21);
            this.inputTimeComboBox.TabIndex = 3;
            this.inputTimeComboBox.SelectedIndexChanged += new System.EventHandler(this.inputTimeComboBox_SelectedIndexChanged);
            // 
            // outputMagnitudeComboBox
            // 
            this.outputMagnitudeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.outputMagnitudeComboBox.FormattingEnabled = true;
            this.outputMagnitudeComboBox.Items.AddRange(new object[] {
            "Auto",
            "Unit",
            "k/K",
            "M",
            "G",
            "T",
            "P",
            "E",
            "Z",
            "Y",
            "R",
            "Q"});
            this.outputMagnitudeComboBox.Location = new System.Drawing.Point(15, 36);
            this.outputMagnitudeComboBox.Name = "outputMagnitudeComboBox";
            this.outputMagnitudeComboBox.Size = new System.Drawing.Size(72, 21);
            this.outputMagnitudeComboBox.TabIndex = 4;
            this.outputMagnitudeComboBox.SelectedIndexChanged += new System.EventHandler(this.outputMagnitudeComboBox_SelectedIndexChanged);
            // 
            // outputMagnitudeLabel
            // 
            this.outputMagnitudeLabel.AutoSize = true;
            this.outputMagnitudeLabel.Location = new System.Drawing.Point(16, 17);
            this.outputMagnitudeLabel.Name = "outputMagnitudeLabel";
            this.outputMagnitudeLabel.Size = new System.Drawing.Size(60, 13);
            this.outputMagnitudeLabel.TabIndex = 4;
            this.outputMagnitudeLabel.Text = "Magnitude:";
            // 
            // outputPrefixTypeLabel
            // 
            this.outputPrefixTypeLabel.AutoSize = true;
            this.outputPrefixTypeLabel.Location = new System.Drawing.Point(106, 17);
            this.outputPrefixTypeLabel.Name = "outputPrefixTypeLabel";
            this.outputPrefixTypeLabel.Size = new System.Drawing.Size(59, 13);
            this.outputPrefixTypeLabel.TabIndex = 4;
            this.outputPrefixTypeLabel.Text = "Prefix type:";
            // 
            // outputPrefixTypeComboBox
            // 
            this.outputPrefixTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.outputPrefixTypeComboBox.FormattingEnabled = true;
            this.outputPrefixTypeComboBox.Items.AddRange(new object[] {
            "dec",
            "bin"});
            this.outputPrefixTypeComboBox.Location = new System.Drawing.Point(109, 36);
            this.outputPrefixTypeComboBox.Name = "outputPrefixTypeComboBox";
            this.outputPrefixTypeComboBox.Size = new System.Drawing.Size(56, 21);
            this.outputPrefixTypeComboBox.TabIndex = 5;
            this.outputPrefixTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.outputPrefixTypeComboBox_SelectedIndexChanged);
            // 
            // outputUnitComboBox
            // 
            this.outputUnitComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.outputUnitComboBox.FormattingEnabled = true;
            this.outputUnitComboBox.Items.AddRange(new object[] {
            "b",
            "B"});
            this.outputUnitComboBox.Location = new System.Drawing.Point(180, 36);
            this.outputUnitComboBox.Name = "outputUnitComboBox";
            this.outputUnitComboBox.Size = new System.Drawing.Size(56, 21);
            this.outputUnitComboBox.TabIndex = 6;
            this.outputUnitComboBox.SelectedIndexChanged += new System.EventHandler(this.outputUnitComboBox_SelectedIndexChanged);
            // 
            // outputUnitLabel
            // 
            this.outputUnitLabel.AutoSize = true;
            this.outputUnitLabel.Location = new System.Drawing.Point(177, 17);
            this.outputUnitLabel.Name = "outputUnitLabel";
            this.outputUnitLabel.Size = new System.Drawing.Size(29, 13);
            this.outputUnitLabel.TabIndex = 4;
            this.outputUnitLabel.Text = "Unit:";
            // 
            // outputPerLabel
            // 
            this.outputPerLabel.AutoSize = true;
            this.outputPerLabel.Location = new System.Drawing.Point(251, 39);
            this.outputPerLabel.Name = "outputPerLabel";
            this.outputPerLabel.Size = new System.Drawing.Size(22, 13);
            this.outputPerLabel.TabIndex = 1;
            this.outputPerLabel.Text = "per";
            // 
            // outputTimeComboBox
            // 
            this.outputTimeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.outputTimeComboBox.FormattingEnabled = true;
            this.outputTimeComboBox.Items.AddRange(new object[] {
            "ms",
            "s",
            "min",
            "h",
            "day",
            "week",
            "year",
            "decade"});
            this.outputTimeComboBox.Location = new System.Drawing.Point(328, 36);
            this.outputTimeComboBox.Name = "outputTimeComboBox";
            this.outputTimeComboBox.Size = new System.Drawing.Size(64, 21);
            this.outputTimeComboBox.TabIndex = 7;
            this.outputTimeComboBox.SelectedIndexChanged += new System.EventHandler(this.outputTimeComboBox_SelectedIndexChanged);
            // 
            // outputTimeLabel
            // 
            this.outputTimeLabel.AutoSize = true;
            this.outputTimeLabel.Location = new System.Drawing.Point(279, 16);
            this.outputTimeLabel.Name = "outputTimeLabel";
            this.outputTimeLabel.Size = new System.Drawing.Size(33, 13);
            this.outputTimeLabel.TabIndex = 4;
            this.outputTimeLabel.Text = "Time:";
            // 
            // outputLabel
            // 
            this.outputLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.Location = new System.Drawing.Point(12, 160);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(440, 25);
            this.outputLabel.TabIndex = 5;
            this.outputLabel.Text = "Output";
            this.outputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(377, 199);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 9;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // autoUpdateCheckBox
            // 
            this.autoUpdateCheckBox.AutoSize = true;
            this.autoUpdateCheckBox.Location = new System.Drawing.Point(252, 203);
            this.autoUpdateCheckBox.Name = "autoUpdateCheckBox";
            this.autoUpdateCheckBox.Size = new System.Drawing.Size(117, 17);
            this.autoUpdateCheckBox.TabIndex = 8;
            this.autoUpdateCheckBox.Text = "Auto update output";
            this.autoUpdateCheckBox.UseVisualStyleBackColor = true;
            this.autoUpdateCheckBox.CheckedChanged += new System.EventHandler(this.autoUpdateCheckBox_CheckedChanged);
            // 
            // inputGroupBox
            // 
            this.inputGroupBox.Controls.Add(this.inputTextBox);
            this.inputGroupBox.Controls.Add(this.inputPerLabel);
            this.inputGroupBox.Controls.Add(this.inputUnitComboBox);
            this.inputGroupBox.Controls.Add(this.inputTimeComboBox);
            this.inputGroupBox.Controls.Add(this.inputTimeTextBox);
            this.inputGroupBox.Location = new System.Drawing.Point(12, 12);
            this.inputGroupBox.Name = "inputGroupBox";
            this.inputGroupBox.Size = new System.Drawing.Size(440, 53);
            this.inputGroupBox.TabIndex = 8;
            this.inputGroupBox.TabStop = false;
            this.inputGroupBox.Text = "Input";
            // 
            // outputUnitGroupBox
            // 
            this.outputUnitGroupBox.Controls.Add(this.outputTimeTextBox);
            this.outputUnitGroupBox.Controls.Add(this.outputMagnitudeComboBox);
            this.outputUnitGroupBox.Controls.Add(this.outputPerLabel);
            this.outputUnitGroupBox.Controls.Add(this.outputPrefixTypeComboBox);
            this.outputUnitGroupBox.Controls.Add(this.outputUnitComboBox);
            this.outputUnitGroupBox.Controls.Add(this.outputTimeComboBox);
            this.outputUnitGroupBox.Controls.Add(this.outputTimeLabel);
            this.outputUnitGroupBox.Controls.Add(this.outputMagnitudeLabel);
            this.outputUnitGroupBox.Controls.Add(this.outputUnitLabel);
            this.outputUnitGroupBox.Controls.Add(this.outputPrefixTypeLabel);
            this.outputUnitGroupBox.Location = new System.Drawing.Point(12, 78);
            this.outputUnitGroupBox.Name = "outputUnitGroupBox";
            this.outputUnitGroupBox.Size = new System.Drawing.Size(440, 70);
            this.outputUnitGroupBox.TabIndex = 9;
            this.outputUnitGroupBox.TabStop = false;
            this.outputUnitGroupBox.Text = "Output unit";
            // 
            // outputTimeTextBox
            // 
            this.outputTimeTextBox.Location = new System.Drawing.Point(282, 36);
            this.outputTimeTextBox.MaxLength = 3;
            this.outputTimeTextBox.Name = "outputTimeTextBox";
            this.outputTimeTextBox.Size = new System.Drawing.Size(40, 20);
            this.outputTimeTextBox.TabIndex = 8;
            this.outputTimeTextBox.Text = "1";
            this.outputTimeTextBox.TextChanged += new System.EventHandler(this.outputTimeTextBox_TextChanged);
            // 
            // MaxDecPlacesNumericUpDown
            // 
            this.MaxDecPlacesNumericUpDown.Location = new System.Drawing.Point(121, 202);
            this.MaxDecPlacesNumericUpDown.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.MaxDecPlacesNumericUpDown.Name = "MaxDecPlacesNumericUpDown";
            this.MaxDecPlacesNumericUpDown.Size = new System.Drawing.Size(38, 20);
            this.MaxDecPlacesNumericUpDown.TabIndex = 10;
            this.MaxDecPlacesNumericUpDown.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.MaxDecPlacesNumericUpDown.ValueChanged += new System.EventHandler(this.MaxDecPlacesNumericUpDown_ValueChanged);
            // 
            // maxDecPlacesLabel
            // 
            this.maxDecPlacesLabel.AutoSize = true;
            this.maxDecPlacesLabel.Location = new System.Drawing.Point(15, 204);
            this.maxDecPlacesLabel.Name = "maxDecPlacesLabel";
            this.maxDecPlacesLabel.Size = new System.Drawing.Size(103, 13);
            this.maxDecPlacesLabel.TabIndex = 11;
            this.maxDecPlacesLabel.Text = "Max decimal places:";
            // 
            // Form1
            // 
            this.AcceptButton = this.calculateButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 234);
            this.Controls.Add(this.maxDecPlacesLabel);
            this.Controls.Add(this.MaxDecPlacesNumericUpDown);
            this.Controls.Add(this.outputUnitGroupBox);
            this.Controls.Add(this.inputGroupBox);
            this.Controls.Add(this.autoUpdateCheckBox);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.outputLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data Rate Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.inputGroupBox.ResumeLayout(false);
            this.inputGroupBox.PerformLayout();
            this.outputUnitGroupBox.ResumeLayout(false);
            this.outputUnitGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaxDecPlacesNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.Label inputPerLabel;
        private System.Windows.Forms.ComboBox inputUnitComboBox;
        private System.Windows.Forms.TextBox inputTimeTextBox;
        private System.Windows.Forms.ComboBox inputTimeComboBox;
        private System.Windows.Forms.ComboBox outputMagnitudeComboBox;
        private System.Windows.Forms.Label outputMagnitudeLabel;
        private System.Windows.Forms.Label outputPrefixTypeLabel;
        private System.Windows.Forms.ComboBox outputPrefixTypeComboBox;
        private System.Windows.Forms.ComboBox outputUnitComboBox;
        private System.Windows.Forms.Label outputUnitLabel;
        private System.Windows.Forms.Label outputPerLabel;
        private System.Windows.Forms.ComboBox outputTimeComboBox;
        private System.Windows.Forms.Label outputTimeLabel;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.CheckBox autoUpdateCheckBox;
        private System.Windows.Forms.GroupBox inputGroupBox;
        private System.Windows.Forms.GroupBox outputUnitGroupBox;
        private System.Windows.Forms.NumericUpDown MaxDecPlacesNumericUpDown;
        private System.Windows.Forms.Label maxDecPlacesLabel;
        private System.Windows.Forms.TextBox outputTimeTextBox;
    }
}

