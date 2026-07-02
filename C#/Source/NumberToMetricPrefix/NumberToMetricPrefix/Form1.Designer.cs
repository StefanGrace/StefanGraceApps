namespace NumberToMetricPrefix
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
            this.label_number = new System.Windows.Forms.Label();
            this.textBox_inputNumber = new System.Windows.Forms.TextBox();
            this.label_unitSymbol = new System.Windows.Forms.Label();
            this.textBox_inputUnitSymbol = new System.Windows.Forms.TextBox();
            this.textBox_output = new System.Windows.Forms.TextBox();
            this.label_output = new System.Windows.Forms.Label();
            this.label_nonThou = new System.Windows.Forms.Label();
            this.checkBox_c = new System.Windows.Forms.CheckBox();
            this.checkBox_d = new System.Windows.Forms.CheckBox();
            this.checkBox_da = new System.Windows.Forms.CheckBox();
            this.checkBox_h = new System.Windows.Forms.CheckBox();
            this.radioButton_decimal = new System.Windows.Forms.RadioButton();
            this.radioButton_binary = new System.Windows.Forms.RadioButton();
            this.label_prefixType = new System.Windows.Forms.Label();
            this.numericUpDown_maxLimit = new System.Windows.Forms.NumericUpDown();
            this.checkBox_limit = new System.Windows.Forms.CheckBox();
            this.comboBox_max = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_maxLimit)).BeginInit();
            this.SuspendLayout();
            // 
            // label_number
            // 
            this.label_number.AutoSize = true;
            this.label_number.Location = new System.Drawing.Point(13, 13);
            this.label_number.Name = "label_number";
            this.label_number.Size = new System.Drawing.Size(47, 13);
            this.label_number.TabIndex = 0;
            this.label_number.Text = "Number:";
            // 
            // textBox_inputNumber
            // 
            this.textBox_inputNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_inputNumber.Location = new System.Drawing.Point(79, 13);
            this.textBox_inputNumber.MaxLength = 100;
            this.textBox_inputNumber.Name = "textBox_inputNumber";
            this.textBox_inputNumber.Size = new System.Drawing.Size(233, 20);
            this.textBox_inputNumber.TabIndex = 0;
            this.textBox_inputNumber.TextChanged += new System.EventHandler(this.textBox_inputNumber_TextChanged);
            // 
            // label_unitSymbol
            // 
            this.label_unitSymbol.AutoSize = true;
            this.label_unitSymbol.Location = new System.Drawing.Point(13, 39);
            this.label_unitSymbol.Name = "label_unitSymbol";
            this.label_unitSymbol.Size = new System.Drawing.Size(67, 13);
            this.label_unitSymbol.TabIndex = 0;
            this.label_unitSymbol.Text = "Unit symbol: ";
            // 
            // textBox_inputUnitSymbol
            // 
            this.textBox_inputUnitSymbol.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_inputUnitSymbol.Location = new System.Drawing.Point(79, 39);
            this.textBox_inputUnitSymbol.MaxLength = 30;
            this.textBox_inputUnitSymbol.Name = "textBox_inputUnitSymbol";
            this.textBox_inputUnitSymbol.Size = new System.Drawing.Size(233, 20);
            this.textBox_inputUnitSymbol.TabIndex = 1;
            this.textBox_inputUnitSymbol.Text = "m";
            this.textBox_inputUnitSymbol.TextChanged += new System.EventHandler(this.textBox_inputUnitSymbol_TextChanged);
            // 
            // textBox_output
            // 
            this.textBox_output.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_output.Location = new System.Drawing.Point(79, 65);
            this.textBox_output.Name = "textBox_output";
            this.textBox_output.ReadOnly = true;
            this.textBox_output.Size = new System.Drawing.Size(233, 20);
            this.textBox_output.TabIndex = 2;
            // 
            // label_output
            // 
            this.label_output.AutoSize = true;
            this.label_output.Location = new System.Drawing.Point(13, 65);
            this.label_output.Name = "label_output";
            this.label_output.Size = new System.Drawing.Size(42, 13);
            this.label_output.TabIndex = 0;
            this.label_output.Text = "Output:";
            // 
            // label_nonThou
            // 
            this.label_nonThou.AutoSize = true;
            this.label_nonThou.Location = new System.Drawing.Point(79, 119);
            this.label_nonThou.Name = "label_nonThou";
            this.label_nonThou.Size = new System.Drawing.Size(177, 13);
            this.label_nonThou.TabIndex = 3;
            this.label_nonThou.Text = "Include non-thousand powers of 10:";
            // 
            // checkBox_c
            // 
            this.checkBox_c.AutoSize = true;
            this.checkBox_c.Location = new System.Drawing.Point(82, 136);
            this.checkBox_c.Name = "checkBox_c";
            this.checkBox_c.Size = new System.Drawing.Size(32, 17);
            this.checkBox_c.TabIndex = 5;
            this.checkBox_c.Text = "c";
            this.checkBox_c.UseVisualStyleBackColor = true;
            this.checkBox_c.CheckedChanged += new System.EventHandler(this.checkBox_c_CheckedChanged);
            // 
            // checkBox_d
            // 
            this.checkBox_d.AutoSize = true;
            this.checkBox_d.Location = new System.Drawing.Point(120, 136);
            this.checkBox_d.Name = "checkBox_d";
            this.checkBox_d.Size = new System.Drawing.Size(32, 17);
            this.checkBox_d.TabIndex = 6;
            this.checkBox_d.Text = "d";
            this.checkBox_d.UseVisualStyleBackColor = true;
            this.checkBox_d.CheckedChanged += new System.EventHandler(this.checkBox_d_CheckedChanged);
            // 
            // checkBox_da
            // 
            this.checkBox_da.AutoSize = true;
            this.checkBox_da.Location = new System.Drawing.Point(158, 136);
            this.checkBox_da.Name = "checkBox_da";
            this.checkBox_da.Size = new System.Drawing.Size(38, 17);
            this.checkBox_da.TabIndex = 7;
            this.checkBox_da.Text = "da";
            this.checkBox_da.UseVisualStyleBackColor = true;
            this.checkBox_da.CheckedChanged += new System.EventHandler(this.checkBox_da_CheckedChanged);
            // 
            // checkBox_h
            // 
            this.checkBox_h.AutoSize = true;
            this.checkBox_h.Location = new System.Drawing.Point(202, 136);
            this.checkBox_h.Name = "checkBox_h";
            this.checkBox_h.Size = new System.Drawing.Size(32, 17);
            this.checkBox_h.TabIndex = 8;
            this.checkBox_h.Text = "h";
            this.checkBox_h.UseVisualStyleBackColor = true;
            this.checkBox_h.CheckedChanged += new System.EventHandler(this.checkBox_h_CheckedChanged);
            // 
            // radioButton_decimal
            // 
            this.radioButton_decimal.AutoSize = true;
            this.radioButton_decimal.Checked = true;
            this.radioButton_decimal.Location = new System.Drawing.Point(79, 92);
            this.radioButton_decimal.Name = "radioButton_decimal";
            this.radioButton_decimal.Size = new System.Drawing.Size(114, 17);
            this.radioButton_decimal.TabIndex = 3;
            this.radioButton_decimal.TabStop = true;
            this.radioButton_decimal.Text = "Decimal (k = 1000)";
            this.radioButton_decimal.UseVisualStyleBackColor = true;
            this.radioButton_decimal.CheckedChanged += new System.EventHandler(this.radioButton_decimal_CheckedChanged);
            // 
            // radioButton_binary
            // 
            this.radioButton_binary.AutoSize = true;
            this.radioButton_binary.Location = new System.Drawing.Point(199, 92);
            this.radioButton_binary.Name = "radioButton_binary";
            this.radioButton_binary.Size = new System.Drawing.Size(107, 17);
            this.radioButton_binary.TabIndex = 4;
            this.radioButton_binary.Text = "Binary (ki = 1024)";
            this.radioButton_binary.UseVisualStyleBackColor = true;
            // 
            // label_prefixType
            // 
            this.label_prefixType.AutoSize = true;
            this.label_prefixType.Location = new System.Drawing.Point(12, 92);
            this.label_prefixType.Name = "label_prefixType";
            this.label_prefixType.Size = new System.Drawing.Size(59, 13);
            this.label_prefixType.TabIndex = 6;
            this.label_prefixType.Text = "Prefix type:";
            // 
            // numericUpDown_maxLimit
            // 
            this.numericUpDown_maxLimit.Location = new System.Drawing.Point(207, 169);
            this.numericUpDown_maxLimit.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numericUpDown_maxLimit.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDown_maxLimit.Name = "numericUpDown_maxLimit";
            this.numericUpDown_maxLimit.Size = new System.Drawing.Size(38, 20);
            this.numericUpDown_maxLimit.TabIndex = 9;
            this.numericUpDown_maxLimit.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDown_maxLimit.ValueChanged += new System.EventHandler(this.numericUpDown_maxLimit_ValueChanged);
            // 
            // checkBox_limit
            // 
            this.checkBox_limit.AutoSize = true;
            this.checkBox_limit.Checked = true;
            this.checkBox_limit.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_limit.Location = new System.Drawing.Point(16, 172);
            this.checkBox_limit.Name = "checkBox_limit";
            this.checkBox_limit.Size = new System.Drawing.Size(47, 17);
            this.checkBox_limit.TabIndex = 10;
            this.checkBox_limit.Text = "Limit";
            this.checkBox_limit.UseVisualStyleBackColor = true;
            this.checkBox_limit.CheckedChanged += new System.EventHandler(this.checkBox_limit_CheckedChanged);
            // 
            // comboBox_max
            // 
            this.comboBox_max.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_max.FormattingEnabled = true;
            this.comboBox_max.Items.AddRange(new object[] {
            "Max total digits",
            "Max decimal places"});
            this.comboBox_max.Location = new System.Drawing.Point(79, 168);
            this.comboBox_max.Name = "comboBox_max";
            this.comboBox_max.Size = new System.Drawing.Size(121, 21);
            this.comboBox_max.TabIndex = 11;
            this.comboBox_max.SelectedIndexChanged += new System.EventHandler(this.comboBox_max_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 201);
            this.Controls.Add(this.comboBox_max);
            this.Controls.Add(this.checkBox_limit);
            this.Controls.Add(this.numericUpDown_maxLimit);
            this.Controls.Add(this.label_prefixType);
            this.Controls.Add(this.radioButton_binary);
            this.Controls.Add(this.radioButton_decimal);
            this.Controls.Add(this.checkBox_h);
            this.Controls.Add(this.checkBox_da);
            this.Controls.Add(this.checkBox_d);
            this.Controls.Add(this.checkBox_c);
            this.Controls.Add(this.label_nonThou);
            this.Controls.Add(this.textBox_output);
            this.Controls.Add(this.textBox_inputUnitSymbol);
            this.Controls.Add(this.textBox_inputNumber);
            this.Controls.Add(this.label_output);
            this.Controls.Add(this.label_unitSymbol);
            this.Controls.Add(this.label_number);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(340, 240);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Number Formatter";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_maxLimit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_number;
        private System.Windows.Forms.TextBox textBox_inputNumber;
        private System.Windows.Forms.Label label_unitSymbol;
        private System.Windows.Forms.TextBox textBox_inputUnitSymbol;
        private System.Windows.Forms.TextBox textBox_output;
        private System.Windows.Forms.Label label_output;
        private System.Windows.Forms.Label label_nonThou;
        private System.Windows.Forms.CheckBox checkBox_c;
        private System.Windows.Forms.CheckBox checkBox_d;
        private System.Windows.Forms.CheckBox checkBox_da;
        private System.Windows.Forms.CheckBox checkBox_h;
        private System.Windows.Forms.RadioButton radioButton_decimal;
        private System.Windows.Forms.RadioButton radioButton_binary;
        private System.Windows.Forms.Label label_prefixType;
        private System.Windows.Forms.NumericUpDown numericUpDown_maxLimit;
        private System.Windows.Forms.CheckBox checkBox_limit;
        private System.Windows.Forms.ComboBox comboBox_max;
    }
}

