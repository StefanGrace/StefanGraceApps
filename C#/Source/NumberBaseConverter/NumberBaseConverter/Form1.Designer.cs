namespace NumberBaseConverter
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
            this.textBox_input = new System.Windows.Forms.TextBox();
            this.textBox_output = new System.Windows.Forms.TextBox();
            this.label_input = new System.Windows.Forms.Label();
            this.numericUpDown_inputBase = new System.Windows.Forms.NumericUpDown();
            this.label_inputBase = new System.Windows.Forms.Label();
            this.numericUpDown_outputBase = new System.Windows.Forms.NumericUpDown();
            this.label_output = new System.Windows.Forms.Label();
            this.label_outputBase = new System.Windows.Forms.Label();
            this.label_keyNumbers = new System.Windows.Forms.Label();
            this.label_keyUppercase = new System.Windows.Forms.Label();
            this.label_keyLowercase = new System.Windows.Forms.Label();
            this.label_keySymbols = new System.Windows.Forms.Label();
            this.checkBox_digitSeperators = new System.Windows.Forms.CheckBox();
            this.checkBox_integerSeperators = new System.Windows.Forms.CheckBox();
            this.checkBox_fractionalSeperators = new System.Windows.Forms.CheckBox();
            this.numericUpDown_seperatorDigits = new System.Windows.Forms.NumericUpDown();
            this.label_every = new System.Windows.Forms.Label();
            this.label_digits = new System.Windows.Forms.Label();
            this.comboBox_seperatorChar = new System.Windows.Forms.ComboBox();
            this.groupBox_digitSeperation = new System.Windows.Forms.GroupBox();
            this.label_tips = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_inputBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_outputBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_seperatorDigits)).BeginInit();
            this.groupBox_digitSeperation.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_input
            // 
            this.textBox_input.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_input.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_input.Location = new System.Drawing.Point(52, 12);
            this.textBox_input.Name = "textBox_input";
            this.textBox_input.Size = new System.Drawing.Size(434, 22);
            this.textBox_input.TabIndex = 0;
            this.textBox_input.TextChanged += new System.EventHandler(this.InputUpdated);
            // 
            // textBox_output
            // 
            this.textBox_output.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_output.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_output.Location = new System.Drawing.Point(52, 38);
            this.textBox_output.Name = "textBox_output";
            this.textBox_output.ReadOnly = true;
            this.textBox_output.Size = new System.Drawing.Size(434, 22);
            this.textBox_output.TabIndex = 2;
            // 
            // label_input
            // 
            this.label_input.AutoSize = true;
            this.label_input.Location = new System.Drawing.Point(12, 15);
            this.label_input.Name = "label_input";
            this.label_input.Size = new System.Drawing.Size(34, 13);
            this.label_input.TabIndex = 1;
            this.label_input.Text = "Input:";
            // 
            // numericUpDown_inputBase
            // 
            this.numericUpDown_inputBase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown_inputBase.Location = new System.Drawing.Point(532, 12);
            this.numericUpDown_inputBase.Maximum = new decimal(new int[] {
            64,
            0,
            0,
            0});
            this.numericUpDown_inputBase.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown_inputBase.Name = "numericUpDown_inputBase";
            this.numericUpDown_inputBase.Size = new System.Drawing.Size(37, 20);
            this.numericUpDown_inputBase.TabIndex = 1;
            this.numericUpDown_inputBase.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_inputBase.ValueChanged += new System.EventHandler(this.BaseUpdated);
            // 
            // label_inputBase
            // 
            this.label_inputBase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_inputBase.AutoSize = true;
            this.label_inputBase.Location = new System.Drawing.Point(492, 15);
            this.label_inputBase.Name = "label_inputBase";
            this.label_inputBase.Size = new System.Drawing.Size(34, 13);
            this.label_inputBase.TabIndex = 1;
            this.label_inputBase.Text = "Base:";
            // 
            // numericUpDown_outputBase
            // 
            this.numericUpDown_outputBase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown_outputBase.Location = new System.Drawing.Point(532, 38);
            this.numericUpDown_outputBase.Maximum = new decimal(new int[] {
            64,
            0,
            0,
            0});
            this.numericUpDown_outputBase.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown_outputBase.Name = "numericUpDown_outputBase";
            this.numericUpDown_outputBase.Size = new System.Drawing.Size(37, 20);
            this.numericUpDown_outputBase.TabIndex = 3;
            this.numericUpDown_outputBase.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_outputBase.ValueChanged += new System.EventHandler(this.BaseUpdated);
            // 
            // label_output
            // 
            this.label_output.AutoSize = true;
            this.label_output.Location = new System.Drawing.Point(4, 41);
            this.label_output.Name = "label_output";
            this.label_output.Size = new System.Drawing.Size(42, 13);
            this.label_output.TabIndex = 1;
            this.label_output.Text = "Output:";
            // 
            // label_outputBase
            // 
            this.label_outputBase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_outputBase.AutoSize = true;
            this.label_outputBase.Location = new System.Drawing.Point(492, 41);
            this.label_outputBase.Name = "label_outputBase";
            this.label_outputBase.Size = new System.Drawing.Size(34, 13);
            this.label_outputBase.TabIndex = 1;
            this.label_outputBase.Text = "Base:";
            // 
            // label_keyNumbers
            // 
            this.label_keyNumbers.AutoSize = true;
            this.label_keyNumbers.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_keyNumbers.Location = new System.Drawing.Point(49, 75);
            this.label_keyNumbers.Name = "label_keyNumbers";
            this.label_keyNumbers.Size = new System.Drawing.Size(84, 14);
            this.label_keyNumbers.TabIndex = 3;
            this.label_keyNumbers.Text = "Key numbers";
            // 
            // label_keyUppercase
            // 
            this.label_keyUppercase.AutoSize = true;
            this.label_keyUppercase.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_keyUppercase.Location = new System.Drawing.Point(139, 75);
            this.label_keyUppercase.Name = "label_keyUppercase";
            this.label_keyUppercase.Size = new System.Drawing.Size(70, 14);
            this.label_keyUppercase.TabIndex = 3;
            this.label_keyUppercase.Text = "Key upper";
            // 
            // label_keyLowercase
            // 
            this.label_keyLowercase.AutoSize = true;
            this.label_keyLowercase.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_keyLowercase.Location = new System.Drawing.Point(229, 75);
            this.label_keyLowercase.Name = "label_keyLowercase";
            this.label_keyLowercase.Size = new System.Drawing.Size(70, 14);
            this.label_keyLowercase.TabIndex = 3;
            this.label_keyLowercase.Text = "Key lower";
            // 
            // label_keySymbols
            // 
            this.label_keySymbols.AutoSize = true;
            this.label_keySymbols.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_keySymbols.Location = new System.Drawing.Point(319, 75);
            this.label_keySymbols.Name = "label_keySymbols";
            this.label_keySymbols.Size = new System.Drawing.Size(84, 14);
            this.label_keySymbols.TabIndex = 3;
            this.label_keySymbols.Text = "Key symbols";
            // 
            // checkBox_digitSeperators
            // 
            this.checkBox_digitSeperators.AutoSize = true;
            this.checkBox_digitSeperators.Location = new System.Drawing.Point(6, 19);
            this.checkBox_digitSeperators.Name = "checkBox_digitSeperators";
            this.checkBox_digitSeperators.Size = new System.Drawing.Size(99, 17);
            this.checkBox_digitSeperators.TabIndex = 0;
            this.checkBox_digitSeperators.Text = "Digit seperators";
            this.checkBox_digitSeperators.UseVisualStyleBackColor = true;
            this.checkBox_digitSeperators.CheckStateChanged += new System.EventHandler(this.DigitSeperationUpdated);
            // 
            // checkBox_integerSeperators
            // 
            this.checkBox_integerSeperators.AutoSize = true;
            this.checkBox_integerSeperators.Checked = true;
            this.checkBox_integerSeperators.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_integerSeperators.Enabled = false;
            this.checkBox_integerSeperators.Location = new System.Drawing.Point(6, 42);
            this.checkBox_integerSeperators.Name = "checkBox_integerSeperators";
            this.checkBox_integerSeperators.Size = new System.Drawing.Size(97, 17);
            this.checkBox_integerSeperators.TabIndex = 0;
            this.checkBox_integerSeperators.Text = "For integer part";
            this.checkBox_integerSeperators.UseVisualStyleBackColor = true;
            this.checkBox_integerSeperators.CheckStateChanged += new System.EventHandler(this.DigitSeperationUpdated);
            // 
            // checkBox_fractionalSeperators
            // 
            this.checkBox_fractionalSeperators.AutoSize = true;
            this.checkBox_fractionalSeperators.Checked = true;
            this.checkBox_fractionalSeperators.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_fractionalSeperators.Enabled = false;
            this.checkBox_fractionalSeperators.Location = new System.Drawing.Point(6, 65);
            this.checkBox_fractionalSeperators.Name = "checkBox_fractionalSeperators";
            this.checkBox_fractionalSeperators.Size = new System.Drawing.Size(108, 17);
            this.checkBox_fractionalSeperators.TabIndex = 0;
            this.checkBox_fractionalSeperators.Text = "For fractional part";
            this.checkBox_fractionalSeperators.UseVisualStyleBackColor = true;
            this.checkBox_fractionalSeperators.CheckStateChanged += new System.EventHandler(this.DigitSeperationUpdated);
            // 
            // numericUpDown_seperatorDigits
            // 
            this.numericUpDown_seperatorDigits.Enabled = false;
            this.numericUpDown_seperatorDigits.Location = new System.Drawing.Point(258, 20);
            this.numericUpDown_seperatorDigits.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numericUpDown_seperatorDigits.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown_seperatorDigits.Name = "numericUpDown_seperatorDigits";
            this.numericUpDown_seperatorDigits.Size = new System.Drawing.Size(37, 20);
            this.numericUpDown_seperatorDigits.TabIndex = 4;
            this.numericUpDown_seperatorDigits.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDown_seperatorDigits.ValueChanged += new System.EventHandler(this.DigitSeperationUpdated);
            // 
            // label_every
            // 
            this.label_every.AutoSize = true;
            this.label_every.Enabled = false;
            this.label_every.Location = new System.Drawing.Point(222, 22);
            this.label_every.Name = "label_every";
            this.label_every.Size = new System.Drawing.Size(34, 13);
            this.label_every.TabIndex = 5;
            this.label_every.Text = "Every";
            // 
            // label_digits
            // 
            this.label_digits.AutoSize = true;
            this.label_digits.Enabled = false;
            this.label_digits.Location = new System.Drawing.Point(302, 22);
            this.label_digits.Name = "label_digits";
            this.label_digits.Size = new System.Drawing.Size(31, 13);
            this.label_digits.TabIndex = 5;
            this.label_digits.Text = "digits";
            // 
            // comboBox_seperatorChar
            // 
            this.comboBox_seperatorChar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_seperatorChar.Enabled = false;
            this.comboBox_seperatorChar.FormattingEnabled = true;
            this.comboBox_seperatorChar.Items.AddRange(new object[] {
            "Space",
            "Comma",
            "Apostrophe",
            "Underscore"});
            this.comboBox_seperatorChar.Location = new System.Drawing.Point(119, 19);
            this.comboBox_seperatorChar.Name = "comboBox_seperatorChar";
            this.comboBox_seperatorChar.Size = new System.Drawing.Size(88, 21);
            this.comboBox_seperatorChar.TabIndex = 6;
            this.comboBox_seperatorChar.SelectedIndexChanged += new System.EventHandler(this.DigitSeperationUpdated);
            // 
            // groupBox_digitSeperation
            // 
            this.groupBox_digitSeperation.Controls.Add(this.checkBox_digitSeperators);
            this.groupBox_digitSeperation.Controls.Add(this.comboBox_seperatorChar);
            this.groupBox_digitSeperation.Controls.Add(this.checkBox_integerSeperators);
            this.groupBox_digitSeperation.Controls.Add(this.label_digits);
            this.groupBox_digitSeperation.Controls.Add(this.checkBox_fractionalSeperators);
            this.groupBox_digitSeperation.Controls.Add(this.label_every);
            this.groupBox_digitSeperation.Controls.Add(this.numericUpDown_seperatorDigits);
            this.groupBox_digitSeperation.Location = new System.Drawing.Point(15, 450);
            this.groupBox_digitSeperation.Name = "groupBox_digitSeperation";
            this.groupBox_digitSeperation.Size = new System.Drawing.Size(351, 91);
            this.groupBox_digitSeperation.TabIndex = 7;
            this.groupBox_digitSeperation.TabStop = false;
            this.groupBox_digitSeperation.Text = "Output digit seperators";
            // 
            // label_tips
            // 
            this.label_tips.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tips.Location = new System.Drawing.Point(18, 549);
            this.label_tips.Name = "label_tips";
            this.label_tips.Size = new System.Drawing.Size(413, 77);
            this.label_tips.TabIndex = 8;
            this.label_tips.Text = "You can enter fractional values using \".\" in any base.\r\n\r\nTip: you can enter a fr" +
    "action by entering the numerator in the input box preceded by \".\", and the denom" +
    "inator as the base.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 627);
            this.Controls.Add(this.label_tips);
            this.Controls.Add(this.groupBox_digitSeperation);
            this.Controls.Add(this.label_keySymbols);
            this.Controls.Add(this.label_keyLowercase);
            this.Controls.Add(this.label_keyUppercase);
            this.Controls.Add(this.label_keyNumbers);
            this.Controls.Add(this.numericUpDown_outputBase);
            this.Controls.Add(this.numericUpDown_inputBase);
            this.Controls.Add(this.label_output);
            this.Controls.Add(this.label_outputBase);
            this.Controls.Add(this.label_inputBase);
            this.Controls.Add(this.label_input);
            this.Controls.Add(this.textBox_output);
            this.Controls.Add(this.textBox_input);
            this.MinimumSize = new System.Drawing.Size(600, 666);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Number Base Converter";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_inputBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_outputBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_seperatorDigits)).EndInit();
            this.groupBox_digitSeperation.ResumeLayout(false);
            this.groupBox_digitSeperation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_input;
        private System.Windows.Forms.TextBox textBox_output;
        private System.Windows.Forms.Label label_input;
        private System.Windows.Forms.NumericUpDown numericUpDown_inputBase;
        private System.Windows.Forms.Label label_inputBase;
        private System.Windows.Forms.NumericUpDown numericUpDown_outputBase;
        private System.Windows.Forms.Label label_output;
        private System.Windows.Forms.Label label_outputBase;
        private System.Windows.Forms.Label label_keyNumbers;
        private System.Windows.Forms.Label label_keyUppercase;
        private System.Windows.Forms.Label label_keyLowercase;
        private System.Windows.Forms.Label label_keySymbols;
        private System.Windows.Forms.CheckBox checkBox_digitSeperators;
        private System.Windows.Forms.CheckBox checkBox_integerSeperators;
        private System.Windows.Forms.CheckBox checkBox_fractionalSeperators;
        private System.Windows.Forms.NumericUpDown numericUpDown_seperatorDigits;
        private System.Windows.Forms.Label label_every;
        private System.Windows.Forms.Label label_digits;
        private System.Windows.Forms.ComboBox comboBox_seperatorChar;
        private System.Windows.Forms.GroupBox groupBox_digitSeperation;
        private System.Windows.Forms.Label label_tips;
    }
}

