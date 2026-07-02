namespace PassingSpeedCalculator
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bicycleSpeedTextBox = new System.Windows.Forms.TextBox();
            this.bicycleSpeedLabel = new System.Windows.Forms.Label();
            this.carSpeedTextBox = new System.Windows.Forms.TextBox();
            this.carSpeedLable = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.autoUpdateCheckBox = new System.Windows.Forms.CheckBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.speedUnitComboBox = new System.Windows.Forms.ComboBox();
            this.speedUnitLabel = new System.Windows.Forms.Label();
            this.convertValuesCheckBox = new System.Windows.Forms.CheckBox();
            this.bicycleSpeedUnitLabel = new System.Windows.Forms.Label();
            this.carSpeedUnitLabel = new System.Windows.Forms.Label();
            this.sameDirPassSpeedLabel = new System.Windows.Forms.Label();
            this.otherDirPassSpeedLabel = new System.Windows.Forms.Label();
            this.dirRatioLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Relative speed of cars passing cyclist in same direction:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(284, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Relative speed of cars passing cyclist in opposite direction:";
            // 
            // bicycleSpeedTextBox
            // 
            this.bicycleSpeedTextBox.Location = new System.Drawing.Point(93, 61);
            this.bicycleSpeedTextBox.MaxLength = 12;
            this.bicycleSpeedTextBox.Name = "bicycleSpeedTextBox";
            this.bicycleSpeedTextBox.Size = new System.Drawing.Size(100, 20);
            this.bicycleSpeedTextBox.TabIndex = 0;
            this.bicycleSpeedTextBox.TextChanged += new System.EventHandler(this.bicycleSpeedTextBox_TextChanged);
            // 
            // bicycleSpeedLabel
            // 
            this.bicycleSpeedLabel.AutoSize = true;
            this.bicycleSpeedLabel.Location = new System.Drawing.Point(11, 61);
            this.bicycleSpeedLabel.Name = "bicycleSpeedLabel";
            this.bicycleSpeedLabel.Size = new System.Drawing.Size(76, 13);
            this.bicycleSpeedLabel.TabIndex = 2;
            this.bicycleSpeedLabel.Text = "Bicycle speed:";
            // 
            // carSpeedTextBox
            // 
            this.carSpeedTextBox.Location = new System.Drawing.Point(93, 87);
            this.carSpeedTextBox.MaxLength = 12;
            this.carSpeedTextBox.Name = "carSpeedTextBox";
            this.carSpeedTextBox.Size = new System.Drawing.Size(100, 20);
            this.carSpeedTextBox.TabIndex = 1;
            this.carSpeedTextBox.TextChanged += new System.EventHandler(this.carSpeedTextBox_TextChanged);
            // 
            // carSpeedLable
            // 
            this.carSpeedLable.AutoSize = true;
            this.carSpeedLable.Location = new System.Drawing.Point(11, 90);
            this.carSpeedLable.Name = "carSpeedLable";
            this.carSpeedLable.Size = new System.Drawing.Size(58, 13);
            this.carSpeedLable.TabIndex = 2;
            this.carSpeedLable.Text = "Car speed:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(350, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ratio of cars passing in opposite direction as opposed to same direction :";
            // 
            // autoUpdateCheckBox
            // 
            this.autoUpdateCheckBox.AutoSize = true;
            this.autoUpdateCheckBox.Checked = true;
            this.autoUpdateCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.autoUpdateCheckBox.Location = new System.Drawing.Point(15, 352);
            this.autoUpdateCheckBox.Name = "autoUpdateCheckBox";
            this.autoUpdateCheckBox.Size = new System.Drawing.Size(117, 17);
            this.autoUpdateCheckBox.TabIndex = 2;
            this.autoUpdateCheckBox.Text = "Auto update output";
            this.autoUpdateCheckBox.UseVisualStyleBackColor = true;
            this.autoUpdateCheckBox.CheckedChanged += new System.EventHandler(this.autoUpdateCheckBox_CheckedChanged);
            // 
            // calculateButton
            // 
            this.calculateButton.Enabled = false;
            this.calculateButton.Location = new System.Drawing.Point(317, 346);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 3;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // speedUnitComboBox
            // 
            this.speedUnitComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.speedUnitComboBox.FormattingEnabled = true;
            this.speedUnitComboBox.Items.AddRange(new object[] {
            "km/h",
            "mph",
            "m/s",
            "ft/s"});
            this.speedUnitComboBox.Location = new System.Drawing.Point(93, 12);
            this.speedUnitComboBox.Name = "speedUnitComboBox";
            this.speedUnitComboBox.Size = new System.Drawing.Size(100, 21);
            this.speedUnitComboBox.TabIndex = 4;
            this.speedUnitComboBox.SelectedIndexChanged += new System.EventHandler(this.speedUnitComboBox_SelectedIndexChanged);
            // 
            // speedUnitLabel
            // 
            this.speedUnitLabel.AutoSize = true;
            this.speedUnitLabel.Location = new System.Drawing.Point(11, 15);
            this.speedUnitLabel.Name = "speedUnitLabel";
            this.speedUnitLabel.Size = new System.Drawing.Size(61, 13);
            this.speedUnitLabel.TabIndex = 2;
            this.speedUnitLabel.Text = "Speed unit:";
            // 
            // convertValuesCheckBox
            // 
            this.convertValuesCheckBox.AutoSize = true;
            this.convertValuesCheckBox.Checked = true;
            this.convertValuesCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.convertValuesCheckBox.Location = new System.Drawing.Point(199, 15);
            this.convertValuesCheckBox.Name = "convertValuesCheckBox";
            this.convertValuesCheckBox.Size = new System.Drawing.Size(177, 17);
            this.convertValuesCheckBox.TabIndex = 5;
            this.convertValuesCheckBox.Text = "Convert input values on change";
            this.convertValuesCheckBox.UseVisualStyleBackColor = true;
            // 
            // bicycleSpeedUnitLabel
            // 
            this.bicycleSpeedUnitLabel.AutoSize = true;
            this.bicycleSpeedUnitLabel.Location = new System.Drawing.Point(199, 64);
            this.bicycleSpeedUnitLabel.Name = "bicycleSpeedUnitLabel";
            this.bicycleSpeedUnitLabel.Size = new System.Drawing.Size(32, 13);
            this.bicycleSpeedUnitLabel.TabIndex = 7;
            this.bicycleSpeedUnitLabel.Text = "km/h";
            // 
            // carSpeedUnitLabel
            // 
            this.carSpeedUnitLabel.AutoSize = true;
            this.carSpeedUnitLabel.Location = new System.Drawing.Point(199, 90);
            this.carSpeedUnitLabel.Name = "carSpeedUnitLabel";
            this.carSpeedUnitLabel.Size = new System.Drawing.Size(32, 13);
            this.carSpeedUnitLabel.TabIndex = 7;
            this.carSpeedUnitLabel.Text = "km/h";
            // 
            // sameDirPassSpeedLabel
            // 
            this.sameDirPassSpeedLabel.AutoSize = true;
            this.sameDirPassSpeedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sameDirPassSpeedLabel.Location = new System.Drawing.Point(13, 164);
            this.sameDirPassSpeedLabel.Name = "sameDirPassSpeedLabel";
            this.sameDirPassSpeedLabel.Size = new System.Drawing.Size(115, 13);
            this.sameDirPassSpeedLabel.TabIndex = 8;
            this.sameDirPassSpeedLabel.Text = "sameDirPassSpeed";
            // 
            // otherDirPassSpeedLabel
            // 
            this.otherDirPassSpeedLabel.AutoSize = true;
            this.otherDirPassSpeedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.otherDirPassSpeedLabel.Location = new System.Drawing.Point(11, 225);
            this.otherDirPassSpeedLabel.Name = "otherDirPassSpeedLabel";
            this.otherDirPassSpeedLabel.Size = new System.Drawing.Size(115, 13);
            this.otherDirPassSpeedLabel.TabIndex = 8;
            this.otherDirPassSpeedLabel.Text = "otherDirPassSpeed";
            // 
            // dirRatioLabel
            // 
            this.dirRatioLabel.AutoSize = true;
            this.dirRatioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dirRatioLabel.Location = new System.Drawing.Point(13, 290);
            this.dirRatioLabel.Name = "dirRatioLabel";
            this.dirRatioLabel.Size = new System.Drawing.Size(51, 13);
            this.dirRatioLabel.TabIndex = 8;
            this.dirRatioLabel.Text = "dirRatio";
            // 
            // Form1
            // 
            this.AcceptButton = this.calculateButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 381);
            this.Controls.Add(this.dirRatioLabel);
            this.Controls.Add(this.otherDirPassSpeedLabel);
            this.Controls.Add(this.sameDirPassSpeedLabel);
            this.Controls.Add(this.carSpeedUnitLabel);
            this.Controls.Add(this.bicycleSpeedUnitLabel);
            this.Controls.Add(this.convertValuesCheckBox);
            this.Controls.Add(this.speedUnitComboBox);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.autoUpdateCheckBox);
            this.Controls.Add(this.carSpeedLable);
            this.Controls.Add(this.speedUnitLabel);
            this.Controls.Add(this.bicycleSpeedLabel);
            this.Controls.Add(this.carSpeedTextBox);
            this.Controls.Add(this.bicycleSpeedTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Passing Speed Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox bicycleSpeedTextBox;
        private System.Windows.Forms.Label bicycleSpeedLabel;
        private System.Windows.Forms.TextBox carSpeedTextBox;
        private System.Windows.Forms.Label carSpeedLable;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox autoUpdateCheckBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.ComboBox speedUnitComboBox;
        private System.Windows.Forms.Label speedUnitLabel;
        private System.Windows.Forms.CheckBox convertValuesCheckBox;
        private System.Windows.Forms.Label bicycleSpeedUnitLabel;
        private System.Windows.Forms.Label carSpeedUnitLabel;
        private System.Windows.Forms.Label sameDirPassSpeedLabel;
        private System.Windows.Forms.Label otherDirPassSpeedLabel;
        private System.Windows.Forms.Label dirRatioLabel;
    }
}

