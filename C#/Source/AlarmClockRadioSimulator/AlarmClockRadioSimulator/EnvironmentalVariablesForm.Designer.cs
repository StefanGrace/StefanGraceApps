namespace AlarmClockRadioSimulator
{
    partial class EnvironmentalVariablesForm
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
            this.tempTrackBar = new System.Windows.Forms.TrackBar();
            this.tempLabel = new System.Windows.Forms.Label();
            this.tempValueLabel = new System.Windows.Forms.Label();
            this.rhLabel = new System.Windows.Forms.Label();
            this.rhValueLabel = new System.Windows.Forms.Label();
            this.rhTrackBar = new System.Windows.Forms.TrackBar();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.pluggedInCheckBox = new System.Windows.Forms.CheckBox();
            this.lowBattCheckBox = new System.Windows.Forms.CheckBox();
            this.usbStateComboBox = new System.Windows.Forms.ComboBox();
            this.usbStateLabel = new System.Windows.Forms.Label();
            this.hpjCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.tempTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rhTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // tempTrackBar
            // 
            this.tempTrackBar.Location = new System.Drawing.Point(27, 44);
            this.tempTrackBar.Maximum = 999;
            this.tempTrackBar.Minimum = -99;
            this.tempTrackBar.Name = "tempTrackBar";
            this.tempTrackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tempTrackBar.Size = new System.Drawing.Size(45, 202);
            this.tempTrackBar.TabIndex = 0;
            this.tempTrackBar.Value = 204;
            this.tempTrackBar.Scroll += new System.EventHandler(this.tempTrackBar_Scroll);
            // 
            // tempLabel
            // 
            this.tempLabel.AutoSize = true;
            this.tempLabel.Location = new System.Drawing.Point(12, 28);
            this.tempLabel.Name = "tempLabel";
            this.tempLabel.Size = new System.Drawing.Size(67, 13);
            this.tempLabel.TabIndex = 1;
            this.tempLabel.Text = "Temperature";
            // 
            // tempValueLabel
            // 
            this.tempValueLabel.AutoSize = true;
            this.tempValueLabel.Location = new System.Drawing.Point(12, 249);
            this.tempValueLabel.Name = "tempValueLabel";
            this.tempValueLabel.Size = new System.Drawing.Size(72, 13);
            this.tempValueLabel.TabIndex = 1;
            this.tempValueLabel.Text = "20.4°C / 69°F";
            // 
            // rhLabel
            // 
            this.rhLabel.AutoSize = true;
            this.rhLabel.Location = new System.Drawing.Point(106, 15);
            this.rhLabel.Name = "rhLabel";
            this.rhLabel.Size = new System.Drawing.Size(47, 26);
            this.rhLabel.TabIndex = 1;
            this.rhLabel.Text = "Relative\r\nHumidity";
            // 
            // rhValueLabel
            // 
            this.rhValueLabel.AutoSize = true;
            this.rhValueLabel.Location = new System.Drawing.Point(106, 249);
            this.rhValueLabel.Name = "rhValueLabel";
            this.rhValueLabel.Size = new System.Drawing.Size(27, 13);
            this.rhValueLabel.TabIndex = 1;
            this.rhValueLabel.Text = "75%";
            // 
            // rhTrackBar
            // 
            this.rhTrackBar.Location = new System.Drawing.Point(109, 45);
            this.rhTrackBar.Maximum = 99;
            this.rhTrackBar.Name = "rhTrackBar";
            this.rhTrackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.rhTrackBar.Size = new System.Drawing.Size(45, 201);
            this.rhTrackBar.TabIndex = 2;
            this.rhTrackBar.Value = 75;
            this.rhTrackBar.Scroll += new System.EventHandler(this.rhTrackBar_Scroll);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(91, 301);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 3;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(179, 301);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // pluggedInCheckBox
            // 
            this.pluggedInCheckBox.AutoSize = true;
            this.pluggedInCheckBox.Location = new System.Drawing.Point(199, 45);
            this.pluggedInCheckBox.Name = "pluggedInCheckBox";
            this.pluggedInCheckBox.Size = new System.Drawing.Size(92, 17);
            this.pluggedInCheckBox.TabIndex = 4;
            this.pluggedInCheckBox.Text = "AC plugged in";
            this.pluggedInCheckBox.UseVisualStyleBackColor = true;
            this.pluggedInCheckBox.CheckedChanged += new System.EventHandler(this.pluggedInCheckBox_CheckedChanged);
            // 
            // lowBattCheckBox
            // 
            this.lowBattCheckBox.AutoSize = true;
            this.lowBattCheckBox.Location = new System.Drawing.Point(199, 69);
            this.lowBattCheckBox.Name = "lowBattCheckBox";
            this.lowBattCheckBox.Size = new System.Drawing.Size(82, 17);
            this.lowBattCheckBox.TabIndex = 5;
            this.lowBattCheckBox.Text = "Low Battery";
            this.lowBattCheckBox.UseVisualStyleBackColor = true;
            this.lowBattCheckBox.CheckedChanged += new System.EventHandler(this.lowBattCheckBox_CheckedChanged);
            // 
            // usbStateComboBox
            // 
            this.usbStateComboBox.AutoCompleteCustomSource.AddRange(new string[] {
            "Not present",
            "Empty",
            "Filled"});
            this.usbStateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.usbStateComboBox.FormattingEnabled = true;
            this.usbStateComboBox.Items.AddRange(new object[] {
            "Not present",
            "Empty",
            "Filled"});
            this.usbStateComboBox.Location = new System.Drawing.Point(199, 141);
            this.usbStateComboBox.Name = "usbStateComboBox";
            this.usbStateComboBox.Size = new System.Drawing.Size(121, 21);
            this.usbStateComboBox.TabIndex = 6;
            this.usbStateComboBox.SelectedIndexChanged += new System.EventHandler(this.usbStateComboBox_SelectedIndexChanged);
            // 
            // usbStateLabel
            // 
            this.usbStateLabel.AutoSize = true;
            this.usbStateLabel.Location = new System.Drawing.Point(199, 122);
            this.usbStateLabel.Name = "usbStateLabel";
            this.usbStateLabel.Size = new System.Drawing.Size(55, 13);
            this.usbStateLabel.TabIndex = 7;
            this.usbStateLabel.Text = "USB state";
            // 
            // hpjCheckBox
            // 
            this.hpjCheckBox.AutoSize = true;
            this.hpjCheckBox.Location = new System.Drawing.Point(199, 93);
            this.hpjCheckBox.Name = "hpjCheckBox";
            this.hpjCheckBox.Size = new System.Drawing.Size(157, 17);
            this.hpjCheckBox.TabIndex = 8;
            this.hpjCheckBox.Text = "Headphone jack plugged in";
            this.hpjCheckBox.UseVisualStyleBackColor = true;
            this.hpjCheckBox.CheckedChanged += new System.EventHandler(this.hpjCheckBox_CheckedChanged);
            // 
            // EnvironmentalVariablesForm
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(360, 337);
            this.Controls.Add(this.hpjCheckBox);
            this.Controls.Add(this.usbStateLabel);
            this.Controls.Add(this.usbStateComboBox);
            this.Controls.Add(this.lowBattCheckBox);
            this.Controls.Add(this.pluggedInCheckBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.rhTrackBar);
            this.Controls.Add(this.rhValueLabel);
            this.Controls.Add(this.tempValueLabel);
            this.Controls.Add(this.rhLabel);
            this.Controls.Add(this.tempLabel);
            this.Controls.Add(this.tempTrackBar);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(376, 376);
            this.MinimumSize = new System.Drawing.Size(376, 376);
            this.Name = "EnvironmentalVariablesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Environmental Variables";
            this.Load += new System.EventHandler(this.EnvironmentalVariablesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tempTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rhTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar tempTrackBar;
        private System.Windows.Forms.Label tempLabel;
        private System.Windows.Forms.Label tempValueLabel;
        private System.Windows.Forms.Label rhLabel;
        private System.Windows.Forms.Label rhValueLabel;
        private System.Windows.Forms.TrackBar rhTrackBar;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.CheckBox pluggedInCheckBox;
        private System.Windows.Forms.CheckBox lowBattCheckBox;
        private System.Windows.Forms.ComboBox usbStateComboBox;
        private System.Windows.Forms.Label usbStateLabel;
        private System.Windows.Forms.CheckBox hpjCheckBox;
    }
}