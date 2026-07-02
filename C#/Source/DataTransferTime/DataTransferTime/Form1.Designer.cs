namespace DataTransferTime
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
            this.textBox_dataTrasferRate = new System.Windows.Forms.TextBox();
            this.comboBox_dataRatePrefix = new System.Windows.Forms.ComboBox();
            this.comboBox_dataRateUnit = new System.Windows.Forms.ComboBox();
            this.comboBox_dataRateTime = new System.Windows.Forms.ComboBox();
            this.label_dataRateSlash = new System.Windows.Forms.Label();
            this.groupBox_dataRate = new System.Windows.Forms.GroupBox();
            this.textBox_dataTotal = new System.Windows.Forms.TextBox();
            this.comboBox_dataTotalUnit = new System.Windows.Forms.ComboBox();
            this.comboBox_dataTotalPrefix = new System.Windows.Forms.ComboBox();
            this.groupBox_dataTotal = new System.Windows.Forms.GroupBox();
            this.label_outputTime = new System.Windows.Forms.Label();
            this.label_outputTimeFormat = new System.Windows.Forms.Label();
            this.comboBox_outputTimeFormat = new System.Windows.Forms.ComboBox();
            this.groupBox_dataRate.SuspendLayout();
            this.groupBox_dataTotal.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_dataTrasferRate
            // 
            this.textBox_dataTrasferRate.Location = new System.Drawing.Point(6, 19);
            this.textBox_dataTrasferRate.MaxLength = 12;
            this.textBox_dataTrasferRate.Name = "textBox_dataTrasferRate";
            this.textBox_dataTrasferRate.Size = new System.Drawing.Size(82, 20);
            this.textBox_dataTrasferRate.TabIndex = 4;
            this.textBox_dataTrasferRate.TextChanged += new System.EventHandler(this.InputUpdated);
            // 
            // comboBox_dataRatePrefix
            // 
            this.comboBox_dataRatePrefix.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_dataRatePrefix.FormattingEnabled = true;
            this.comboBox_dataRatePrefix.Items.AddRange(new object[] {
            "",
            "k",
            "Ki",
            "M",
            "Mi",
            "G",
            "Gi",
            "T",
            "Ti",
            "P",
            "Pi",
            "E",
            "Ei",
            "Z",
            "Zi",
            "Y",
            "Yi",
            "R",
            "Ri",
            "Q",
            "Qi"});
            this.comboBox_dataRatePrefix.Location = new System.Drawing.Point(94, 18);
            this.comboBox_dataRatePrefix.Name = "comboBox_dataRatePrefix";
            this.comboBox_dataRatePrefix.Size = new System.Drawing.Size(34, 21);
            this.comboBox_dataRatePrefix.TabIndex = 5;
            this.comboBox_dataRatePrefix.SelectedValueChanged += new System.EventHandler(this.InputUpdated);
            // 
            // comboBox_dataRateUnit
            // 
            this.comboBox_dataRateUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_dataRateUnit.FormattingEnabled = true;
            this.comboBox_dataRateUnit.Items.AddRange(new object[] {
            "b",
            "B"});
            this.comboBox_dataRateUnit.Location = new System.Drawing.Point(134, 18);
            this.comboBox_dataRateUnit.Name = "comboBox_dataRateUnit";
            this.comboBox_dataRateUnit.Size = new System.Drawing.Size(34, 21);
            this.comboBox_dataRateUnit.TabIndex = 6;
            this.comboBox_dataRateUnit.SelectedValueChanged += new System.EventHandler(this.InputUpdated);
            // 
            // comboBox_dataRateTime
            // 
            this.comboBox_dataRateTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_dataRateTime.FormattingEnabled = true;
            this.comboBox_dataRateTime.Items.AddRange(new object[] {
            "ms",
            "s",
            "min",
            "h",
            "day",
            "year"});
            this.comboBox_dataRateTime.Location = new System.Drawing.Point(192, 18);
            this.comboBox_dataRateTime.Name = "comboBox_dataRateTime";
            this.comboBox_dataRateTime.Size = new System.Drawing.Size(57, 21);
            this.comboBox_dataRateTime.TabIndex = 7;
            this.comboBox_dataRateTime.SelectedValueChanged += new System.EventHandler(this.InputUpdated);
            // 
            // label_dataRateSlash
            // 
            this.label_dataRateSlash.AutoSize = true;
            this.label_dataRateSlash.Location = new System.Drawing.Point(174, 22);
            this.label_dataRateSlash.Name = "label_dataRateSlash";
            this.label_dataRateSlash.Size = new System.Drawing.Size(12, 13);
            this.label_dataRateSlash.TabIndex = 2;
            this.label_dataRateSlash.Text = "/";
            // 
            // groupBox_dataRate
            // 
            this.groupBox_dataRate.Controls.Add(this.textBox_dataTrasferRate);
            this.groupBox_dataRate.Controls.Add(this.label_dataRateSlash);
            this.groupBox_dataRate.Controls.Add(this.comboBox_dataRatePrefix);
            this.groupBox_dataRate.Controls.Add(this.comboBox_dataRateTime);
            this.groupBox_dataRate.Controls.Add(this.comboBox_dataRateUnit);
            this.groupBox_dataRate.Location = new System.Drawing.Point(12, 74);
            this.groupBox_dataRate.Name = "groupBox_dataRate";
            this.groupBox_dataRate.Size = new System.Drawing.Size(260, 56);
            this.groupBox_dataRate.TabIndex = 1;
            this.groupBox_dataRate.TabStop = false;
            this.groupBox_dataRate.Text = "Data transfer rate";
            // 
            // textBox_dataTotal
            // 
            this.textBox_dataTotal.Location = new System.Drawing.Point(6, 19);
            this.textBox_dataTotal.MaxLength = 12;
            this.textBox_dataTotal.Name = "textBox_dataTotal";
            this.textBox_dataTotal.Size = new System.Drawing.Size(82, 20);
            this.textBox_dataTotal.TabIndex = 1;
            this.textBox_dataTotal.TextChanged += new System.EventHandler(this.InputUpdated);
            // 
            // comboBox_dataTotalUnit
            // 
            this.comboBox_dataTotalUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_dataTotalUnit.FormattingEnabled = true;
            this.comboBox_dataTotalUnit.Items.AddRange(new object[] {
            "b",
            "B"});
            this.comboBox_dataTotalUnit.Location = new System.Drawing.Point(134, 19);
            this.comboBox_dataTotalUnit.Name = "comboBox_dataTotalUnit";
            this.comboBox_dataTotalUnit.Size = new System.Drawing.Size(34, 21);
            this.comboBox_dataTotalUnit.TabIndex = 3;
            this.comboBox_dataTotalUnit.SelectedValueChanged += new System.EventHandler(this.InputUpdated);
            // 
            // comboBox_dataTotalPrefix
            // 
            this.comboBox_dataTotalPrefix.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_dataTotalPrefix.FormattingEnabled = true;
            this.comboBox_dataTotalPrefix.Items.AddRange(new object[] {
            "",
            "k",
            "Ki",
            "M",
            "Mi",
            "G",
            "Gi",
            "T",
            "Ti",
            "P",
            "Pi",
            "E",
            "Ei",
            "Z",
            "Zi",
            "Y",
            "Yi",
            "R",
            "Ri",
            "Q",
            "Qi"});
            this.comboBox_dataTotalPrefix.Location = new System.Drawing.Point(94, 19);
            this.comboBox_dataTotalPrefix.Name = "comboBox_dataTotalPrefix";
            this.comboBox_dataTotalPrefix.Size = new System.Drawing.Size(34, 21);
            this.comboBox_dataTotalPrefix.TabIndex = 2;
            this.comboBox_dataTotalPrefix.SelectedValueChanged += new System.EventHandler(this.InputUpdated);
            // 
            // groupBox_dataTotal
            // 
            this.groupBox_dataTotal.Controls.Add(this.textBox_dataTotal);
            this.groupBox_dataTotal.Controls.Add(this.comboBox_dataTotalUnit);
            this.groupBox_dataTotal.Controls.Add(this.comboBox_dataTotalPrefix);
            this.groupBox_dataTotal.Location = new System.Drawing.Point(12, 12);
            this.groupBox_dataTotal.Name = "groupBox_dataTotal";
            this.groupBox_dataTotal.Size = new System.Drawing.Size(187, 52);
            this.groupBox_dataTotal.TabIndex = 0;
            this.groupBox_dataTotal.TabStop = false;
            this.groupBox_dataTotal.Text = "Total data to trasfer";
            // 
            // label_outputTime
            // 
            this.label_outputTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_outputTime.Location = new System.Drawing.Point(12, 136);
            this.label_outputTime.Name = "label_outputTime";
            this.label_outputTime.Size = new System.Drawing.Size(260, 79);
            this.label_outputTime.TabIndex = 6;
            this.label_outputTime.Text = "Time";
            this.label_outputTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_outputTimeFormat
            // 
            this.label_outputTimeFormat.AutoSize = true;
            this.label_outputTimeFormat.Location = new System.Drawing.Point(13, 236);
            this.label_outputTimeFormat.Name = "label_outputTimeFormat";
            this.label_outputTimeFormat.Size = new System.Drawing.Size(96, 13);
            this.label_outputTimeFormat.TabIndex = 7;
            this.label_outputTimeFormat.Text = "Output time format:";
            // 
            // comboBox_outputTimeFormat
            // 
            this.comboBox_outputTimeFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_outputTimeFormat.FormattingEnabled = true;
            this.comboBox_outputTimeFormat.Items.AddRange(new object[] {
            "[[year] day] h:min:s.ms",
            "[day] h:min:s.ms",
            "h:min:s.ms",
            "unit + subunit",
            "unit + decimal",
            "ms",
            "s",
            "min",
            "h",
            "day",
            "year"});
            this.comboBox_outputTimeFormat.Location = new System.Drawing.Point(115, 233);
            this.comboBox_outputTimeFormat.Name = "comboBox_outputTimeFormat";
            this.comboBox_outputTimeFormat.Size = new System.Drawing.Size(151, 21);
            this.comboBox_outputTimeFormat.TabIndex = 8;
            this.comboBox_outputTimeFormat.SelectedIndexChanged += new System.EventHandler(this.OutputTimeFormatChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label_outputTimeFormat);
            this.Controls.Add(this.label_outputTime);
            this.Controls.Add(this.groupBox_dataTotal);
            this.Controls.Add(this.comboBox_outputTimeFormat);
            this.Controls.Add(this.groupBox_dataRate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data Transfer Time";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox_dataRate.ResumeLayout(false);
            this.groupBox_dataRate.PerformLayout();
            this.groupBox_dataTotal.ResumeLayout(false);
            this.groupBox_dataTotal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_dataTrasferRate;
        private System.Windows.Forms.ComboBox comboBox_dataRatePrefix;
        private System.Windows.Forms.ComboBox comboBox_dataRateUnit;
        private System.Windows.Forms.ComboBox comboBox_dataRateTime;
        private System.Windows.Forms.Label label_dataRateSlash;
        private System.Windows.Forms.GroupBox groupBox_dataRate;
        private System.Windows.Forms.TextBox textBox_dataTotal;
        private System.Windows.Forms.ComboBox comboBox_dataTotalUnit;
        private System.Windows.Forms.ComboBox comboBox_dataTotalPrefix;
        private System.Windows.Forms.GroupBox groupBox_dataTotal;
        private System.Windows.Forms.Label label_outputTime;
        private System.Windows.Forms.Label label_outputTimeFormat;
        private System.Windows.Forms.ComboBox comboBox_outputTimeFormat;
    }
}

