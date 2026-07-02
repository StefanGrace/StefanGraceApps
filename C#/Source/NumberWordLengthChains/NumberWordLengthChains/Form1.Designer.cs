namespace NumberWordLengthChains
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
            this.label_input = new System.Windows.Forms.Label();
            this.richTextBox_output = new System.Windows.Forms.RichTextBox();
            this.label_chainLength = new System.Windows.Forms.Label();
            this.checkBox_excludeNonLetters = new System.Windows.Forms.CheckBox();
            this.button_grammar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_input
            // 
            this.textBox_input.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_input.Location = new System.Drawing.Point(90, 12);
            this.textBox_input.Name = "textBox_input";
            this.textBox_input.Size = new System.Drawing.Size(394, 20);
            this.textBox_input.TabIndex = 0;
            this.textBox_input.TextChanged += new System.EventHandler(this.textBox_input_TextChanged);
            // 
            // label_input
            // 
            this.label_input.AutoSize = true;
            this.label_input.Location = new System.Drawing.Point(12, 15);
            this.label_input.Name = "label_input";
            this.label_input.Size = new System.Drawing.Size(72, 13);
            this.label_input.TabIndex = 1;
            this.label_input.Text = "Input number:";
            // 
            // richTextBox_output
            // 
            this.richTextBox_output.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox_output.Location = new System.Drawing.Point(15, 49);
            this.richTextBox_output.Name = "richTextBox_output";
            this.richTextBox_output.Size = new System.Drawing.Size(469, 160);
            this.richTextBox_output.TabIndex = 2;
            this.richTextBox_output.Text = "";
            this.richTextBox_output.WordWrap = false;
            // 
            // label_chainLength
            // 
            this.label_chainLength.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_chainLength.AutoSize = true;
            this.label_chainLength.Location = new System.Drawing.Point(15, 212);
            this.label_chainLength.Name = "label_chainLength";
            this.label_chainLength.Size = new System.Drawing.Size(69, 13);
            this.label_chainLength.TabIndex = 3;
            this.label_chainLength.Text = "Chain length:";
            // 
            // checkBox_excludeNonLetters
            // 
            this.checkBox_excludeNonLetters.AutoSize = true;
            this.checkBox_excludeNonLetters.Location = new System.Drawing.Point(274, 232);
            this.checkBox_excludeNonLetters.Name = "checkBox_excludeNonLetters";
            this.checkBox_excludeNonLetters.Size = new System.Drawing.Size(197, 17);
            this.checkBox_excludeNonLetters.TabIndex = 4;
            this.checkBox_excludeNonLetters.Text = "Exclude non-letters from word length";
            this.checkBox_excludeNonLetters.UseVisualStyleBackColor = true;
            this.checkBox_excludeNonLetters.CheckedChanged += new System.EventHandler(this.checkBox_excludeNonLetters_CheckedChanged);
            // 
            // button_grammar
            // 
            this.button_grammar.Location = new System.Drawing.Point(179, 228);
            this.button_grammar.Name = "button_grammar";
            this.button_grammar.Size = new System.Drawing.Size(75, 23);
            this.button_grammar.TabIndex = 5;
            this.button_grammar.Text = "Grammar...";
            this.button_grammar.UseVisualStyleBackColor = true;
            this.button_grammar.Click += new System.EventHandler(this.button_grammar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 261);
            this.Controls.Add(this.button_grammar);
            this.Controls.Add(this.checkBox_excludeNonLetters);
            this.Controls.Add(this.label_chainLength);
            this.Controls.Add(this.richTextBox_output);
            this.Controls.Add(this.label_input);
            this.Controls.Add(this.textBox_input);
            this.MinimumSize = new System.Drawing.Size(512, 300);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Number Word Length Chain";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_input;
        private System.Windows.Forms.Label label_input;
        private System.Windows.Forms.RichTextBox richTextBox_output;
        private System.Windows.Forms.Label label_chainLength;
        private System.Windows.Forms.CheckBox checkBox_excludeNonLetters;
        private System.Windows.Forms.Button button_grammar;
    }
}

