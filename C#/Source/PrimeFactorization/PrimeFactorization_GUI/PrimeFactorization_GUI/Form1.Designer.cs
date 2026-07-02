namespace PrimeFactorization
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
            this.checkBox_seperateLines = new System.Windows.Forms.CheckBox();
            this.checkBox_expNotation = new System.Windows.Forms.CheckBox();
            this.checkBox_showExp1 = new System.Windows.Forms.CheckBox();
            this.textBox_output = new System.Windows.Forms.TextBox();
            this.textBox_input = new System.Windows.Forms.TextBox();
            this.button_factorize = new System.Windows.Forms.Button();
            this.label_input = new System.Windows.Forms.Label();
            this.label_output = new System.Windows.Forms.Label();
            this.checkBox_autoUpdate = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // checkBox_seperateLines
            // 
            this.checkBox_seperateLines.AutoSize = true;
            this.checkBox_seperateLines.Location = new System.Drawing.Point(23, 38);
            this.checkBox_seperateLines.Name = "checkBox_seperateLines";
            this.checkBox_seperateLines.Size = new System.Drawing.Size(93, 17);
            this.checkBox_seperateLines.TabIndex = 2;
            this.checkBox_seperateLines.Text = "Seperate lines";
            this.checkBox_seperateLines.UseVisualStyleBackColor = true;
            this.checkBox_seperateLines.CheckedChanged += new System.EventHandler(this.checkBox_seperateLines_CheckedChanged);
            // 
            // checkBox_expNotation
            // 
            this.checkBox_expNotation.AutoSize = true;
            this.checkBox_expNotation.Location = new System.Drawing.Point(122, 38);
            this.checkBox_expNotation.Name = "checkBox_expNotation";
            this.checkBox_expNotation.Size = new System.Drawing.Size(122, 17);
            this.checkBox_expNotation.TabIndex = 3;
            this.checkBox_expNotation.Text = "Exponential notation";
            this.checkBox_expNotation.UseVisualStyleBackColor = true;
            this.checkBox_expNotation.CheckedChanged += new System.EventHandler(this.checkBox_expNotation_CheckedChanged);
            // 
            // checkBox_showExp1
            // 
            this.checkBox_showExp1.AutoSize = true;
            this.checkBox_showExp1.Enabled = false;
            this.checkBox_showExp1.Location = new System.Drawing.Point(122, 61);
            this.checkBox_showExp1.Name = "checkBox_showExp1";
            this.checkBox_showExp1.Size = new System.Drawing.Size(153, 17);
            this.checkBox_showExp1.TabIndex = 4;
            this.checkBox_showExp1.Text = "Show exponents that are 1";
            this.checkBox_showExp1.UseVisualStyleBackColor = true;
            this.checkBox_showExp1.CheckedChanged += new System.EventHandler(this.checkBox_showExp1_CheckedChanged);
            // 
            // textBox_output
            // 
            this.textBox_output.AcceptsReturn = true;
            this.textBox_output.Location = new System.Drawing.Point(12, 104);
            this.textBox_output.Multiline = true;
            this.textBox_output.Name = "textBox_output";
            this.textBox_output.ReadOnly = true;
            this.textBox_output.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_output.Size = new System.Drawing.Size(313, 205);
            this.textBox_output.TabIndex = 5;
            // 
            // textBox_input
            // 
            this.textBox_input.Location = new System.Drawing.Point(66, 12);
            this.textBox_input.Name = "textBox_input";
            this.textBox_input.Size = new System.Drawing.Size(178, 20);
            this.textBox_input.TabIndex = 0;
            this.textBox_input.TextChanged += new System.EventHandler(this.textBox_input_TextChanged);
            // 
            // button_factorize
            // 
            this.button_factorize.Enabled = false;
            this.button_factorize.Location = new System.Drawing.Point(250, 10);
            this.button_factorize.Name = "button_factorize";
            this.button_factorize.Size = new System.Drawing.Size(75, 23);
            this.button_factorize.TabIndex = 1;
            this.button_factorize.Text = "Factorize";
            this.button_factorize.UseVisualStyleBackColor = true;
            this.button_factorize.Click += new System.EventHandler(this.button_factorize_Click);
            // 
            // label_input
            // 
            this.label_input.AutoSize = true;
            this.label_input.Location = new System.Drawing.Point(12, 15);
            this.label_input.Name = "label_input";
            this.label_input.Size = new System.Drawing.Size(47, 13);
            this.label_input.TabIndex = 5;
            this.label_input.Text = "Number:";
            // 
            // label_output
            // 
            this.label_output.AutoSize = true;
            this.label_output.Location = new System.Drawing.Point(12, 85);
            this.label_output.Name = "label_output";
            this.label_output.Size = new System.Drawing.Size(71, 13);
            this.label_output.TabIndex = 6;
            this.label_output.Text = "Prime factors:";
            // 
            // checkBox_autoUpdate
            // 
            this.checkBox_autoUpdate.AutoSize = true;
            this.checkBox_autoUpdate.Location = new System.Drawing.Point(23, 61);
            this.checkBox_autoUpdate.Name = "checkBox_autoUpdate";
            this.checkBox_autoUpdate.Size = new System.Drawing.Size(84, 17);
            this.checkBox_autoUpdate.TabIndex = 7;
            this.checkBox_autoUpdate.Text = "Auto-update";
            this.checkBox_autoUpdate.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AcceptButton = this.button_factorize;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 321);
            this.Controls.Add(this.checkBox_autoUpdate);
            this.Controls.Add(this.label_output);
            this.Controls.Add(this.label_input);
            this.Controls.Add(this.button_factorize);
            this.Controls.Add(this.textBox_input);
            this.Controls.Add(this.textBox_output);
            this.Controls.Add(this.checkBox_showExp1);
            this.Controls.Add(this.checkBox_expNotation);
            this.Controls.Add(this.checkBox_seperateLines);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prime Factorization";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox_seperateLines;
        private System.Windows.Forms.CheckBox checkBox_expNotation;
        private System.Windows.Forms.CheckBox checkBox_showExp1;
        private System.Windows.Forms.TextBox textBox_output;
        private System.Windows.Forms.TextBox textBox_input;
        private System.Windows.Forms.Button button_factorize;
        private System.Windows.Forms.Label label_input;
        private System.Windows.Forms.Label label_output;
        private System.Windows.Forms.CheckBox checkBox_autoUpdate;
    }
}

