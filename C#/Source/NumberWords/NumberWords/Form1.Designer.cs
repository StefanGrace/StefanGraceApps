namespace NumberWords
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
            this.FunctionGroupBox = new System.Windows.Forms.GroupBox();
            this.RangeWithIntervalRadioButton = new System.Windows.Forms.RadioButton();
            this.RangeRadioButton = new System.Windows.Forms.RadioButton();
            this.CountToNumberRadioButton = new System.Windows.Forms.RadioButton();
            this.SingleNumberRadioButton = new System.Windows.Forms.RadioButton();
            this.NumberStartTextBox = new System.Windows.Forms.TextBox();
            this.NumberStartLabel = new System.Windows.Forms.Label();
            this.EndTextBox = new System.Windows.Forms.TextBox();
            this.IntervalTextBox = new System.Windows.Forms.TextBox();
            this.EndLabel = new System.Windows.Forms.Label();
            this.IntervalLabel = new System.Windows.Forms.Label();
            this.IncludeZeroCheckBox = new System.Windows.Forms.CheckBox();
            this.SingleOutputTextBox = new System.Windows.Forms.TextBox();
            this.SaveOutputButton = new System.Windows.Forms.Button();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.GrammarButton = new System.Windows.Forms.Button();
            this.OutputLabel = new System.Windows.Forms.Label();
            this.OutputRichTextBox = new System.Windows.Forms.RichTextBox();
            this.OutputLabel1 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.FunctionGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // FunctionGroupBox
            // 
            this.FunctionGroupBox.Controls.Add(this.RangeWithIntervalRadioButton);
            this.FunctionGroupBox.Controls.Add(this.RangeRadioButton);
            this.FunctionGroupBox.Controls.Add(this.CountToNumberRadioButton);
            this.FunctionGroupBox.Controls.Add(this.SingleNumberRadioButton);
            this.FunctionGroupBox.Location = new System.Drawing.Point(56, 13);
            this.FunctionGroupBox.Name = "FunctionGroupBox";
            this.FunctionGroupBox.Size = new System.Drawing.Size(399, 49);
            this.FunctionGroupBox.TabIndex = 0;
            this.FunctionGroupBox.TabStop = false;
            this.FunctionGroupBox.Text = "Function";
            // 
            // RangeWithIntervalRadioButton
            // 
            this.RangeWithIntervalRadioButton.AutoSize = true;
            this.RangeWithIntervalRadioButton.Location = new System.Drawing.Point(278, 20);
            this.RangeWithIntervalRadioButton.Name = "RangeWithIntervalRadioButton";
            this.RangeWithIntervalRadioButton.Size = new System.Drawing.Size(116, 17);
            this.RangeWithIntervalRadioButton.TabIndex = 3;
            this.RangeWithIntervalRadioButton.TabStop = true;
            this.RangeWithIntervalRadioButton.Text = "Range with interval";
            this.RangeWithIntervalRadioButton.UseVisualStyleBackColor = true;
            this.RangeWithIntervalRadioButton.Click += new System.EventHandler(this.RangeWithIntervalRadioButton_Click);
            // 
            // RangeRadioButton
            // 
            this.RangeRadioButton.AutoSize = true;
            this.RangeRadioButton.Location = new System.Drawing.Point(214, 20);
            this.RangeRadioButton.Name = "RangeRadioButton";
            this.RangeRadioButton.Size = new System.Drawing.Size(57, 17);
            this.RangeRadioButton.TabIndex = 2;
            this.RangeRadioButton.TabStop = true;
            this.RangeRadioButton.Text = "Range";
            this.RangeRadioButton.UseVisualStyleBackColor = true;
            this.RangeRadioButton.Click += new System.EventHandler(this.RangeRadioButton_Click);
            // 
            // CountToNumberRadioButton
            // 
            this.CountToNumberRadioButton.AutoSize = true;
            this.CountToNumberRadioButton.Location = new System.Drawing.Point(105, 20);
            this.CountToNumberRadioButton.Name = "CountToNumberRadioButton";
            this.CountToNumberRadioButton.Size = new System.Drawing.Size(103, 17);
            this.CountToNumberRadioButton.TabIndex = 1;
            this.CountToNumberRadioButton.TabStop = true;
            this.CountToNumberRadioButton.Text = "Count to number";
            this.CountToNumberRadioButton.UseVisualStyleBackColor = true;
            this.CountToNumberRadioButton.Click += new System.EventHandler(this.CountToNumberRadioButton_Click);
            // 
            // SingleNumberRadioButton
            // 
            this.SingleNumberRadioButton.AutoSize = true;
            this.SingleNumberRadioButton.Location = new System.Drawing.Point(7, 19);
            this.SingleNumberRadioButton.Name = "SingleNumberRadioButton";
            this.SingleNumberRadioButton.Size = new System.Drawing.Size(92, 17);
            this.SingleNumberRadioButton.TabIndex = 0;
            this.SingleNumberRadioButton.TabStop = true;
            this.SingleNumberRadioButton.Text = "Single number";
            this.SingleNumberRadioButton.UseVisualStyleBackColor = true;
            this.SingleNumberRadioButton.Click += new System.EventHandler(this.SingleNumberRadioButton_Click);
            // 
            // NumberStartTextBox
            // 
            this.NumberStartTextBox.Location = new System.Drawing.Point(131, 82);
            this.NumberStartTextBox.Name = "NumberStartTextBox";
            this.NumberStartTextBox.Size = new System.Drawing.Size(319, 20);
            this.NumberStartTextBox.TabIndex = 4;
            this.NumberStartTextBox.TextChanged += new System.EventHandler(this.NumberStartTextBox_TextChanged);
            // 
            // NumberStartLabel
            // 
            this.NumberStartLabel.AutoSize = true;
            this.NumberStartLabel.Location = new System.Drawing.Point(60, 82);
            this.NumberStartLabel.Name = "NumberStartLabel";
            this.NumberStartLabel.Size = new System.Drawing.Size(47, 13);
            this.NumberStartLabel.TabIndex = 2;
            this.NumberStartLabel.Text = "Number:";
            // 
            // EndTextBox
            // 
            this.EndTextBox.Location = new System.Drawing.Point(131, 108);
            this.EndTextBox.Name = "EndTextBox";
            this.EndTextBox.Size = new System.Drawing.Size(319, 20);
            this.EndTextBox.TabIndex = 5;
            // 
            // IntervalTextBox
            // 
            this.IntervalTextBox.Location = new System.Drawing.Point(131, 134);
            this.IntervalTextBox.Name = "IntervalTextBox";
            this.IntervalTextBox.Size = new System.Drawing.Size(319, 20);
            this.IntervalTextBox.TabIndex = 6;
            this.IntervalTextBox.Text = "1";
            // 
            // EndLabel
            // 
            this.EndLabel.AutoSize = true;
            this.EndLabel.Location = new System.Drawing.Point(60, 108);
            this.EndLabel.Name = "EndLabel";
            this.EndLabel.Size = new System.Drawing.Size(29, 13);
            this.EndLabel.TabIndex = 2;
            this.EndLabel.Text = "End:";
            // 
            // IntervalLabel
            // 
            this.IntervalLabel.AutoSize = true;
            this.IntervalLabel.Location = new System.Drawing.Point(60, 134);
            this.IntervalLabel.Name = "IntervalLabel";
            this.IntervalLabel.Size = new System.Drawing.Size(45, 13);
            this.IntervalLabel.TabIndex = 2;
            this.IntervalLabel.Text = "Interval:";
            // 
            // IncludeZeroCheckBox
            // 
            this.IncludeZeroCheckBox.AutoSize = true;
            this.IncludeZeroCheckBox.Checked = true;
            this.IncludeZeroCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.IncludeZeroCheckBox.Location = new System.Drawing.Point(131, 160);
            this.IncludeZeroCheckBox.Name = "IncludeZeroCheckBox";
            this.IncludeZeroCheckBox.Size = new System.Drawing.Size(84, 17);
            this.IncludeZeroCheckBox.TabIndex = 7;
            this.IncludeZeroCheckBox.Text = "Include zero";
            this.IncludeZeroCheckBox.UseVisualStyleBackColor = true;
            // 
            // SingleOutputTextBox
            // 
            this.SingleOutputTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.SingleOutputTextBox.Location = new System.Drawing.Point(131, 183);
            this.SingleOutputTextBox.Name = "SingleOutputTextBox";
            this.SingleOutputTextBox.ReadOnly = true;
            this.SingleOutputTextBox.Size = new System.Drawing.Size(319, 20);
            this.SingleOutputTextBox.TabIndex = 8;
            // 
            // SaveOutputButton
            // 
            this.SaveOutputButton.Location = new System.Drawing.Point(131, 210);
            this.SaveOutputButton.Name = "SaveOutputButton";
            this.SaveOutputButton.Size = new System.Drawing.Size(75, 23);
            this.SaveOutputButton.TabIndex = 9;
            this.SaveOutputButton.Text = "Save Output";
            this.SaveOutputButton.UseVisualStyleBackColor = true;
            this.SaveOutputButton.Click += new System.EventHandler(this.SaveOutputButton_Click);
            // 
            // GenerateButton
            // 
            this.GenerateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenerateButton.Location = new System.Drawing.Point(213, 210);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(75, 23);
            this.GenerateButton.TabIndex = 10;
            this.GenerateButton.Text = "Generate";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // GrammarButton
            // 
            this.GrammarButton.Location = new System.Drawing.Point(295, 210);
            this.GrammarButton.Name = "GrammarButton";
            this.GrammarButton.Size = new System.Drawing.Size(75, 23);
            this.GrammarButton.TabIndex = 11;
            this.GrammarButton.Text = "Grammar...";
            this.GrammarButton.UseVisualStyleBackColor = true;
            this.GrammarButton.Click += new System.EventHandler(this.GrammerBbutton_Click);
            // 
            // OutputLabel
            // 
            this.OutputLabel.AutoSize = true;
            this.OutputLabel.Location = new System.Drawing.Point(62, 186);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.Size = new System.Drawing.Size(42, 13);
            this.OutputLabel.TabIndex = 2;
            this.OutputLabel.Text = "Output:";
            // 
            // OutputRichTextBox
            // 
            this.OutputRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OutputRichTextBox.Location = new System.Drawing.Point(462, 32);
            this.OutputRichTextBox.Name = "OutputRichTextBox";
            this.OutputRichTextBox.ReadOnly = true;
            this.OutputRichTextBox.Size = new System.Drawing.Size(450, 297);
            this.OutputRichTextBox.TabIndex = 12;
            this.OutputRichTextBox.Text = "";
            this.OutputRichTextBox.WordWrap = false;
            // 
            // OutputLabel1
            // 
            this.OutputLabel1.AutoSize = true;
            this.OutputLabel1.Location = new System.Drawing.Point(459, 13);
            this.OutputLabel1.Name = "OutputLabel1";
            this.OutputLabel1.Size = new System.Drawing.Size(42, 13);
            this.OutputLabel1.TabIndex = 2;
            this.OutputLabel1.Text = "Output:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 341);
            this.Controls.Add(this.OutputRichTextBox);
            this.Controls.Add(this.GrammarButton);
            this.Controls.Add(this.GenerateButton);
            this.Controls.Add(this.SaveOutputButton);
            this.Controls.Add(this.SingleOutputTextBox);
            this.Controls.Add(this.IncludeZeroCheckBox);
            this.Controls.Add(this.OutputLabel1);
            this.Controls.Add(this.OutputLabel);
            this.Controls.Add(this.IntervalLabel);
            this.Controls.Add(this.EndLabel);
            this.Controls.Add(this.NumberStartLabel);
            this.Controls.Add(this.IntervalTextBox);
            this.Controls.Add(this.EndTextBox);
            this.Controls.Add(this.NumberStartTextBox);
            this.Controls.Add(this.FunctionGroupBox);
            this.MinimumSize = new System.Drawing.Size(512, 380);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Number Words";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.FunctionGroupBox.ResumeLayout(false);
            this.FunctionGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox FunctionGroupBox;
        private System.Windows.Forms.RadioButton SingleNumberRadioButton;
        private System.Windows.Forms.RadioButton RangeWithIntervalRadioButton;
        private System.Windows.Forms.RadioButton RangeRadioButton;
        private System.Windows.Forms.RadioButton CountToNumberRadioButton;
        private System.Windows.Forms.TextBox NumberStartTextBox;
        private System.Windows.Forms.Label NumberStartLabel;
        private System.Windows.Forms.TextBox EndTextBox;
        private System.Windows.Forms.TextBox IntervalTextBox;
        private System.Windows.Forms.Label EndLabel;
        private System.Windows.Forms.Label IntervalLabel;
        private System.Windows.Forms.CheckBox IncludeZeroCheckBox;
        private System.Windows.Forms.TextBox SingleOutputTextBox;
        private System.Windows.Forms.Button SaveOutputButton;
        private System.Windows.Forms.Button GenerateButton;
        private System.Windows.Forms.Button GrammarButton;
        private System.Windows.Forms.Label OutputLabel;
        private System.Windows.Forms.RichTextBox OutputRichTextBox;
        private System.Windows.Forms.Label OutputLabel1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

