namespace DateFormatter
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
            this.radioButton_convertDateFormat = new System.Windows.Forms.RadioButton();
            this.label_input = new System.Windows.Forms.Label();
            this.textBox_input = new System.Windows.Forms.TextBox();
            this.radioButton_inputDateByElement = new System.Windows.Forms.RadioButton();
            this.label_year = new System.Windows.Forms.Label();
            this.textBox_year = new System.Windows.Forms.TextBox();
            this.label_month = new System.Windows.Forms.Label();
            this.textBox_month = new System.Windows.Forms.TextBox();
            this.textBox_day = new System.Windows.Forms.TextBox();
            this.label_day = new System.Windows.Forms.Label();
            this.radioButton_formatCurrrentDate = new System.Windows.Forms.RadioButton();
            this.textBox_output = new System.Windows.Forms.TextBox();
            this.label_output = new System.Windows.Forms.Label();
            this.button_outputFormat = new System.Windows.Forms.Button();
            this.button_formatDate = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // radioButton_convertDateFormat
            // 
            this.radioButton_convertDateFormat.AutoSize = true;
            this.radioButton_convertDateFormat.Checked = true;
            this.radioButton_convertDateFormat.Location = new System.Drawing.Point(15, 11);
            this.radioButton_convertDateFormat.Name = "radioButton_convertDateFormat";
            this.radioButton_convertDateFormat.Size = new System.Drawing.Size(118, 17);
            this.radioButton_convertDateFormat.TabIndex = 9;
            this.radioButton_convertDateFormat.TabStop = true;
            this.radioButton_convertDateFormat.Text = "Convert date format";
            this.radioButton_convertDateFormat.UseVisualStyleBackColor = true;
            this.radioButton_convertDateFormat.CheckedChanged += new System.EventHandler(this.radioButton_convertDateFormat_CheckedChanged);
            // 
            // label_input
            // 
            this.label_input.AutoSize = true;
            this.label_input.Location = new System.Drawing.Point(12, 37);
            this.label_input.Name = "label_input";
            this.label_input.Size = new System.Drawing.Size(34, 13);
            this.label_input.TabIndex = 1;
            this.label_input.Text = "Input:";
            // 
            // textBox_input
            // 
            this.textBox_input.Location = new System.Drawing.Point(52, 34);
            this.textBox_input.MaxLength = 28;
            this.textBox_input.Name = "textBox_input";
            this.textBox_input.Size = new System.Drawing.Size(202, 20);
            this.textBox_input.TabIndex = 0;
            // 
            // radioButton_inputDateByElement
            // 
            this.radioButton_inputDateByElement.AutoSize = true;
            this.radioButton_inputDateByElement.Location = new System.Drawing.Point(15, 60);
            this.radioButton_inputDateByElement.Name = "radioButton_inputDateByElement";
            this.radioButton_inputDateByElement.Size = new System.Drawing.Size(127, 17);
            this.radioButton_inputDateByElement.TabIndex = 1;
            this.radioButton_inputDateByElement.Text = "Input date by element";
            this.radioButton_inputDateByElement.UseVisualStyleBackColor = true;
            this.radioButton_inputDateByElement.CheckedChanged += new System.EventHandler(this.radioButton_inputDateByElement_CheckedChanged);
            // 
            // label_year
            // 
            this.label_year.AutoSize = true;
            this.label_year.Enabled = false;
            this.label_year.Location = new System.Drawing.Point(12, 86);
            this.label_year.Name = "label_year";
            this.label_year.Size = new System.Drawing.Size(32, 13);
            this.label_year.TabIndex = 1;
            this.label_year.Text = "Year:";
            // 
            // textBox_year
            // 
            this.textBox_year.Enabled = false;
            this.textBox_year.Location = new System.Drawing.Point(52, 83);
            this.textBox_year.MaxLength = 4;
            this.textBox_year.Name = "textBox_year";
            this.textBox_year.Size = new System.Drawing.Size(80, 20);
            this.textBox_year.TabIndex = 2;
            // 
            // label_month
            // 
            this.label_month.AutoSize = true;
            this.label_month.Enabled = false;
            this.label_month.Location = new System.Drawing.Point(12, 112);
            this.label_month.Name = "label_month";
            this.label_month.Size = new System.Drawing.Size(40, 13);
            this.label_month.TabIndex = 1;
            this.label_month.Text = "Month:";
            // 
            // textBox_month
            // 
            this.textBox_month.Enabled = false;
            this.textBox_month.Location = new System.Drawing.Point(52, 109);
            this.textBox_month.MaxLength = 9;
            this.textBox_month.Name = "textBox_month";
            this.textBox_month.Size = new System.Drawing.Size(80, 20);
            this.textBox_month.TabIndex = 3;
            // 
            // textBox_day
            // 
            this.textBox_day.Enabled = false;
            this.textBox_day.Location = new System.Drawing.Point(52, 135);
            this.textBox_day.MaxLength = 4;
            this.textBox_day.Name = "textBox_day";
            this.textBox_day.Size = new System.Drawing.Size(80, 20);
            this.textBox_day.TabIndex = 4;
            // 
            // label_day
            // 
            this.label_day.AutoSize = true;
            this.label_day.Enabled = false;
            this.label_day.Location = new System.Drawing.Point(12, 138);
            this.label_day.Name = "label_day";
            this.label_day.Size = new System.Drawing.Size(29, 13);
            this.label_day.TabIndex = 1;
            this.label_day.Text = "Day:";
            // 
            // radioButton_formatCurrrentDate
            // 
            this.radioButton_formatCurrrentDate.AutoSize = true;
            this.radioButton_formatCurrrentDate.Location = new System.Drawing.Point(16, 161);
            this.radioButton_formatCurrrentDate.Name = "radioButton_formatCurrrentDate";
            this.radioButton_formatCurrrentDate.Size = new System.Drawing.Size(117, 17);
            this.radioButton_formatCurrrentDate.TabIndex = 5;
            this.radioButton_formatCurrrentDate.Text = "Format current date";
            this.radioButton_formatCurrrentDate.UseVisualStyleBackColor = true;
            this.radioButton_formatCurrrentDate.CheckedChanged += new System.EventHandler(this.radioButton_formatCurrrentDate_CheckedChanged);
            // 
            // textBox_output
            // 
            this.textBox_output.Location = new System.Drawing.Point(52, 184);
            this.textBox_output.MaxLength = 28;
            this.textBox_output.Name = "textBox_output";
            this.textBox_output.ReadOnly = true;
            this.textBox_output.Size = new System.Drawing.Size(202, 20);
            this.textBox_output.TabIndex = 6;
            // 
            // label_output
            // 
            this.label_output.AutoSize = true;
            this.label_output.Location = new System.Drawing.Point(10, 187);
            this.label_output.Name = "label_output";
            this.label_output.Size = new System.Drawing.Size(42, 13);
            this.label_output.TabIndex = 1;
            this.label_output.Text = "Output:";
            // 
            // button_outputFormat
            // 
            this.button_outputFormat.Location = new System.Drawing.Point(16, 235);
            this.button_outputFormat.Name = "button_outputFormat";
            this.button_outputFormat.Size = new System.Drawing.Size(116, 23);
            this.button_outputFormat.TabIndex = 7;
            this.button_outputFormat.Text = "Output format...";
            this.button_outputFormat.UseVisualStyleBackColor = true;
            this.button_outputFormat.Click += new System.EventHandler(this.button_outputFormat_Click);
            // 
            // button_formatDate
            // 
            this.button_formatDate.Location = new System.Drawing.Point(138, 235);
            this.button_formatDate.Name = "button_formatDate";
            this.button_formatDate.Size = new System.Drawing.Size(116, 23);
            this.button_formatDate.TabIndex = 8;
            this.button_formatDate.Text = "Format date";
            this.button_formatDate.UseVisualStyleBackColor = true;
            this.button_formatDate.Click += new System.EventHandler(this.button_formatDate_Click);
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(16, 264);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(238, 23);
            this.button_save.TabIndex = 8;
            this.button_save.Text = "Save output format to file";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(16, 293);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(238, 23);
            this.button_delete.TabIndex = 8;
            this.button_delete.Text = "Delete output format save file";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.button_formatDate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 325);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.button_formatDate);
            this.Controls.Add(this.button_outputFormat);
            this.Controls.Add(this.textBox_day);
            this.Controls.Add(this.textBox_month);
            this.Controls.Add(this.textBox_year);
            this.Controls.Add(this.textBox_output);
            this.Controls.Add(this.textBox_input);
            this.Controls.Add(this.label_day);
            this.Controls.Add(this.label_month);
            this.Controls.Add(this.label_year);
            this.Controls.Add(this.label_output);
            this.Controls.Add(this.label_input);
            this.Controls.Add(this.radioButton_formatCurrrentDate);
            this.Controls.Add(this.radioButton_inputDateByElement);
            this.Controls.Add(this.radioButton_convertDateFormat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Date Formatter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton_convertDateFormat;
        private System.Windows.Forms.Label label_input;
        private System.Windows.Forms.TextBox textBox_input;
        private System.Windows.Forms.RadioButton radioButton_inputDateByElement;
        private System.Windows.Forms.Label label_year;
        private System.Windows.Forms.TextBox textBox_year;
        private System.Windows.Forms.Label label_month;
        private System.Windows.Forms.TextBox textBox_month;
        private System.Windows.Forms.TextBox textBox_day;
        private System.Windows.Forms.Label label_day;
        private System.Windows.Forms.RadioButton radioButton_formatCurrrentDate;
        private System.Windows.Forms.TextBox textBox_output;
        private System.Windows.Forms.Label label_output;
        private System.Windows.Forms.Button button_outputFormat;
        private System.Windows.Forms.Button button_formatDate;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_delete;
    }
}

