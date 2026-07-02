namespace RomanNumerals
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
            this.textBox_decimal = new System.Windows.Forms.TextBox();
            this.textBox_romanNumerals = new System.Windows.Forms.TextBox();
            this.label_error = new System.Windows.Forms.Label();
            this.label_decimal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_middleDot = new System.Windows.Forms.Button();
            this.button_help = new System.Windows.Forms.Button();
            this.radioButton_uppercase = new System.Windows.Forms.RadioButton();
            this.radioButton_lowercase = new System.Windows.Forms.RadioButton();
            this.checkBox_convertInputCase = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // textBox_decimal
            // 
            this.textBox_decimal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_decimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_decimal.Location = new System.Drawing.Point(101, 16);
            this.textBox_decimal.MaxLength = 20;
            this.textBox_decimal.Name = "textBox_decimal";
            this.textBox_decimal.Size = new System.Drawing.Size(375, 29);
            this.textBox_decimal.TabIndex = 0;
            this.textBox_decimal.TextChanged += new System.EventHandler(this.textBox_decimal_TextChanged);
            // 
            // textBox_romanNumerals
            // 
            this.textBox_romanNumerals.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_romanNumerals.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox_romanNumerals.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_romanNumerals.Location = new System.Drawing.Point(101, 51);
            this.textBox_romanNumerals.MaxLength = 20;
            this.textBox_romanNumerals.Name = "textBox_romanNumerals";
            this.textBox_romanNumerals.Size = new System.Drawing.Size(375, 29);
            this.textBox_romanNumerals.TabIndex = 1;
            this.textBox_romanNumerals.TextChanged += new System.EventHandler(this.textBox_romanNumerals_TextChanged);
            // 
            // label_error
            // 
            this.label_error.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_error.ForeColor = System.Drawing.Color.Red;
            this.label_error.Location = new System.Drawing.Point(98, 93);
            this.label_error.Name = "label_error";
            this.label_error.Size = new System.Drawing.Size(376, 53);
            this.label_error.TabIndex = 1;
            this.label_error.Text = "[Error message text]";
            // 
            // label_decimal
            // 
            this.label_decimal.AutoSize = true;
            this.label_decimal.Location = new System.Drawing.Point(9, 23);
            this.label_decimal.Name = "label_decimal";
            this.label_decimal.Size = new System.Drawing.Size(48, 13);
            this.label_decimal.TabIndex = 2;
            this.label_decimal.Text = "Decimal:";
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Roman numerals:";
            // 
            // button_middleDot
            // 
            this.button_middleDot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_middleDot.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_middleDot.Location = new System.Drawing.Point(483, 51);
            this.button_middleDot.Name = "button_middleDot";
            this.button_middleDot.Size = new System.Drawing.Size(29, 29);
            this.button_middleDot.TabIndex = 2;
            this.button_middleDot.Text = "·";
            this.button_middleDot.UseVisualStyleBackColor = true;
            this.button_middleDot.Click += new System.EventHandler(this.button_middleDot_Click);
            // 
            // button_help
            // 
            this.button_help.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_help.Location = new System.Drawing.Point(437, 226);
            this.button_help.Name = "button_help";
            this.button_help.Size = new System.Drawing.Size(75, 23);
            this.button_help.TabIndex = 6;
            this.button_help.Text = "Help";
            this.button_help.UseVisualStyleBackColor = true;
            this.button_help.Click += new System.EventHandler(this.button_help_Click);
            // 
            // radioButton_uppercase
            // 
            this.radioButton_uppercase.AutoSize = true;
            this.radioButton_uppercase.Checked = true;
            this.radioButton_uppercase.Location = new System.Drawing.Point(101, 149);
            this.radioButton_uppercase.Name = "radioButton_uppercase";
            this.radioButton_uppercase.Size = new System.Drawing.Size(77, 17);
            this.radioButton_uppercase.TabIndex = 3;
            this.radioButton_uppercase.TabStop = true;
            this.radioButton_uppercase.Text = "Uppercase";
            this.radioButton_uppercase.UseVisualStyleBackColor = true;
            // 
            // radioButton_lowercase
            // 
            this.radioButton_lowercase.AutoSize = true;
            this.radioButton_lowercase.Location = new System.Drawing.Point(101, 172);
            this.radioButton_lowercase.Name = "radioButton_lowercase";
            this.radioButton_lowercase.Size = new System.Drawing.Size(77, 17);
            this.radioButton_lowercase.TabIndex = 4;
            this.radioButton_lowercase.Text = "Lowercase";
            this.radioButton_lowercase.UseVisualStyleBackColor = true;
            this.radioButton_lowercase.CheckedChanged += new System.EventHandler(this.radioButton_lowercase_CheckedChanged);
            // 
            // checkBox_convertInputCase
            // 
            this.checkBox_convertInputCase.AutoSize = true;
            this.checkBox_convertInputCase.Checked = true;
            this.checkBox_convertInputCase.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_convertInputCase.Location = new System.Drawing.Point(101, 195);
            this.checkBox_convertInputCase.Name = "checkBox_convertInputCase";
            this.checkBox_convertInputCase.Size = new System.Drawing.Size(115, 17);
            this.checkBox_convertInputCase.TabIndex = 5;
            this.checkBox_convertInputCase.Text = "Convert input case";
            this.checkBox_convertInputCase.UseVisualStyleBackColor = true;
            this.checkBox_convertInputCase.CheckedChanged += new System.EventHandler(this.checkBox_convertInputCase_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 261);
            this.Controls.Add(this.checkBox_convertInputCase);
            this.Controls.Add(this.radioButton_lowercase);
            this.Controls.Add(this.radioButton_uppercase);
            this.Controls.Add(this.button_help);
            this.Controls.Add(this.button_middleDot);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_decimal);
            this.Controls.Add(this.label_error);
            this.Controls.Add(this.textBox_romanNumerals);
            this.Controls.Add(this.textBox_decimal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Roman Numerals";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyPressed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_decimal;
        private System.Windows.Forms.TextBox textBox_romanNumerals;
        private System.Windows.Forms.Label label_error;
        private System.Windows.Forms.Label label_decimal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_middleDot;
        private System.Windows.Forms.Button button_help;
        private System.Windows.Forms.RadioButton radioButton_uppercase;
        private System.Windows.Forms.RadioButton radioButton_lowercase;
        private System.Windows.Forms.CheckBox checkBox_convertInputCase;
    }
}

