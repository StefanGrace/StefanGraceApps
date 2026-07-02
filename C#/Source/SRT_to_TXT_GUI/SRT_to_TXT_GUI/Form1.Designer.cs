namespace SRT_to_TXT_GUI
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
            this.label_input = new System.Windows.Forms.Label();
            this.textBox_input = new System.Windows.Forms.TextBox();
            this.label_output = new System.Windows.Forms.Label();
            this.textBox_output = new System.Windows.Forms.TextBox();
            this.checkBox_singleLine = new System.Windows.Forms.CheckBox();
            this.checkBox_gapBetweenSubs = new System.Windows.Forms.CheckBox();
            this.checkBox_joinLines = new System.Windows.Forms.CheckBox();
            this.button_convert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_input
            // 
            this.label_input.AutoSize = true;
            this.label_input.Location = new System.Drawing.Point(12, 19);
            this.label_input.Name = "label_input";
            this.label_input.Size = new System.Drawing.Size(75, 13);
            this.label_input.TabIndex = 0;
            this.label_input.Text = "Input SRT file:";
            // 
            // textBox_input
            // 
            this.textBox_input.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_input.Location = new System.Drawing.Point(100, 16);
            this.textBox_input.Name = "textBox_input";
            this.textBox_input.Size = new System.Drawing.Size(490, 20);
            this.textBox_input.TabIndex = 0;
            // 
            // label_output
            // 
            this.label_output.AutoSize = true;
            this.label_output.Location = new System.Drawing.Point(12, 46);
            this.label_output.Name = "label_output";
            this.label_output.Size = new System.Drawing.Size(82, 13);
            this.label_output.TabIndex = 0;
            this.label_output.Text = "Output TXT file:";
            // 
            // textBox_output
            // 
            this.textBox_output.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_output.Location = new System.Drawing.Point(100, 43);
            this.textBox_output.Name = "textBox_output";
            this.textBox_output.Size = new System.Drawing.Size(490, 20);
            this.textBox_output.TabIndex = 1;
            // 
            // checkBox_singleLine
            // 
            this.checkBox_singleLine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBox_singleLine.AutoSize = true;
            this.checkBox_singleLine.Location = new System.Drawing.Point(13, 97);
            this.checkBox_singleLine.Name = "checkBox_singleLine";
            this.checkBox_singleLine.Size = new System.Drawing.Size(74, 17);
            this.checkBox_singleLine.TabIndex = 2;
            this.checkBox_singleLine.Text = "Single line";
            this.checkBox_singleLine.UseVisualStyleBackColor = true;
            this.checkBox_singleLine.CheckedChanged += new System.EventHandler(this.checkBox_singleLine_CheckedChanged);
            // 
            // checkBox_gapBetweenSubs
            // 
            this.checkBox_gapBetweenSubs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBox_gapBetweenSubs.AutoSize = true;
            this.checkBox_gapBetweenSubs.Location = new System.Drawing.Point(100, 97);
            this.checkBox_gapBetweenSubs.Name = "checkBox_gapBetweenSubs";
            this.checkBox_gapBetweenSubs.Size = new System.Drawing.Size(135, 17);
            this.checkBox_gapBetweenSubs.TabIndex = 3;
            this.checkBox_gapBetweenSubs.Text = "Add gap between subs";
            this.checkBox_gapBetweenSubs.UseVisualStyleBackColor = true;
            // 
            // checkBox_joinLines
            // 
            this.checkBox_joinLines.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBox_joinLines.AutoSize = true;
            this.checkBox_joinLines.Checked = true;
            this.checkBox_joinLines.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_joinLines.Location = new System.Drawing.Point(241, 97);
            this.checkBox_joinLines.Name = "checkBox_joinLines";
            this.checkBox_joinLines.Size = new System.Drawing.Size(119, 17);
            this.checkBox_joinLines.TabIndex = 4;
            this.checkBox_joinLines.Text = "Join lines within sub";
            this.checkBox_joinLines.UseVisualStyleBackColor = true;
            // 
            // button_convert
            // 
            this.button_convert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_convert.Location = new System.Drawing.Point(515, 91);
            this.button_convert.Name = "button_convert";
            this.button_convert.Size = new System.Drawing.Size(75, 23);
            this.button_convert.TabIndex = 5;
            this.button_convert.Text = "Convert";
            this.button_convert.UseVisualStyleBackColor = true;
            this.button_convert.Click += new System.EventHandler(this.button_convert_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.button_convert;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 126);
            this.Controls.Add(this.button_convert);
            this.Controls.Add(this.checkBox_joinLines);
            this.Controls.Add(this.checkBox_gapBetweenSubs);
            this.Controls.Add(this.checkBox_singleLine);
            this.Controls.Add(this.textBox_output);
            this.Controls.Add(this.textBox_input);
            this.Controls.Add(this.label_output);
            this.Controls.Add(this.label_input);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SRT to TXT Converter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_input;
        private System.Windows.Forms.TextBox textBox_input;
        private System.Windows.Forms.Label label_output;
        private System.Windows.Forms.TextBox textBox_output;
        private System.Windows.Forms.CheckBox checkBox_singleLine;
        private System.Windows.Forms.CheckBox checkBox_gapBetweenSubs;
        private System.Windows.Forms.CheckBox checkBox_joinLines;
        private System.Windows.Forms.Button button_convert;
    }
}

