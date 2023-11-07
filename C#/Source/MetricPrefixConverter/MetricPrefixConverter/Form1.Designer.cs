namespace MetricPrefixConverter
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
            this.inputPrefixes = new System.Windows.Forms.ComboBox();
            this.outputPrefixes = new System.Windows.Forms.ComboBox();
            this.outputText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(87, 39);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(203, 20);
            this.inputTextBox.TabIndex = 0;
            this.inputTextBox.Text = "0";
            this.inputTextBox.TextChanged += new System.EventHandler(this.inputTextBox_TextChanged);
            // 
            // inputPrefixes
            // 
            this.inputPrefixes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.inputPrefixes.Items.AddRange(new object[] {
            "Y",
            "Z",
            "E",
            "P",
            "T",
            "G",
            "M",
            "k",
            "h",
            "da",
            "",
            "d",
            "c",
            "m",
            "µ",
            "n",
            "p",
            "f",
            "a",
            "z",
            "y"});
            this.inputPrefixes.Location = new System.Drawing.Point(296, 39);
            this.inputPrefixes.MaxDropDownItems = 21;
            this.inputPrefixes.Name = "inputPrefixes";
            this.inputPrefixes.Size = new System.Drawing.Size(42, 21);
            this.inputPrefixes.TabIndex = 1;
            this.inputPrefixes.SelectedIndexChanged += new System.EventHandler(this.inputPrefixes_SelectedIndexChanged);
            // 
            // outputPrefixes
            // 
            this.outputPrefixes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.outputPrefixes.Items.AddRange(new object[] {
            "Y",
            "Z",
            "E",
            "P",
            "T",
            "G",
            "M",
            "k",
            "h",
            "da",
            "",
            "d",
            "c",
            "m",
            "µ",
            "n",
            "p",
            "f",
            "a",
            "z",
            "y"});
            this.outputPrefixes.Location = new System.Drawing.Point(296, 66);
            this.outputPrefixes.MaxDropDownItems = 21;
            this.outputPrefixes.Name = "outputPrefixes";
            this.outputPrefixes.Size = new System.Drawing.Size(42, 21);
            this.outputPrefixes.TabIndex = 2;
            this.outputPrefixes.SelectedIndexChanged += new System.EventHandler(this.outputPrefixes_SelectedIndexChanged);
            // 
            // outputText
            // 
            this.outputText.AutoSize = true;
            this.outputText.Location = new System.Drawing.Point(88, 69);
            this.outputText.Name = "outputText";
            this.outputText.Size = new System.Drawing.Size(13, 13);
            this.outputText.TabIndex = 3;
            this.outputText.Text = "0";
            this.outputText.Click += new System.EventHandler(this.outputText_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 161);
            this.Controls.Add(this.outputText);
            this.Controls.Add(this.outputPrefixes);
            this.Controls.Add(this.inputPrefixes);
            this.Controls.Add(this.inputTextBox);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 200);
            this.MinimumSize = new System.Drawing.Size(400, 200);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Metric Prefix Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.ComboBox inputPrefixes;
        private System.Windows.Forms.ComboBox outputPrefixes;
        private System.Windows.Forms.Label outputText;
    }
}

