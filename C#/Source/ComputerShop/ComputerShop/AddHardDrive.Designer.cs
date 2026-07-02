namespace ComputerShop
{
    partial class AddHardDrive
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
            this.button_back = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.label_capasity = new System.Windows.Forms.Label();
            this.comboBox_capasity = new System.Windows.Forms.ComboBox();
            this.label_formFactor = new System.Windows.Forms.Label();
            this.label_connector = new System.Windows.Forms.Label();
            this.comboBox_formFactor = new System.Windows.Forms.ComboBox();
            this.comboBox_connector = new System.Windows.Forms.ComboBox();
            this.label_rotaitionalSpeed = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_capasity = new System.Windows.Forms.TextBox();
            this.textBox_rpm = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_back
            // 
            this.button_back.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_back.Location = new System.Drawing.Point(116, 226);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(75, 23);
            this.button_back.TabIndex = 6;
            this.button_back.Text = "< Back";
            this.button_back.UseVisualStyleBackColor = true;
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(197, 226);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(75, 23);
            this.button_add.TabIndex = 5;
            this.button_add.Text = "Add";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // label_capasity
            // 
            this.label_capasity.AutoSize = true;
            this.label_capasity.Location = new System.Drawing.Point(12, 14);
            this.label_capasity.Name = "label_capasity";
            this.label_capasity.Size = new System.Drawing.Size(50, 13);
            this.label_capasity.TabIndex = 17;
            this.label_capasity.Text = "Capasity:";
            // 
            // comboBox_capasity
            // 
            this.comboBox_capasity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_capasity.FormattingEnabled = true;
            this.comboBox_capasity.Items.AddRange(new object[] {
            "MB",
            "GB",
            "TB",
            "PB"});
            this.comboBox_capasity.Location = new System.Drawing.Point(183, 11);
            this.comboBox_capasity.Name = "comboBox_capasity";
            this.comboBox_capasity.Size = new System.Drawing.Size(59, 21);
            this.comboBox_capasity.TabIndex = 1;
            // 
            // label_formFactor
            // 
            this.label_formFactor.AutoSize = true;
            this.label_formFactor.Location = new System.Drawing.Point(12, 41);
            this.label_formFactor.Name = "label_formFactor";
            this.label_formFactor.Size = new System.Drawing.Size(63, 13);
            this.label_formFactor.TabIndex = 17;
            this.label_formFactor.Text = "Form factor:";
            // 
            // label_connector
            // 
            this.label_connector.AutoSize = true;
            this.label_connector.Location = new System.Drawing.Point(12, 67);
            this.label_connector.Name = "label_connector";
            this.label_connector.Size = new System.Drawing.Size(53, 13);
            this.label_connector.TabIndex = 17;
            this.label_connector.Text = "Conector:";
            // 
            // comboBox_formFactor
            // 
            this.comboBox_formFactor.FormattingEnabled = true;
            this.comboBox_formFactor.Items.AddRange(new object[] {
            "2.5 inch",
            "3.5 inch"});
            this.comboBox_formFactor.Location = new System.Drawing.Point(110, 37);
            this.comboBox_formFactor.Name = "comboBox_formFactor";
            this.comboBox_formFactor.Size = new System.Drawing.Size(132, 21);
            this.comboBox_formFactor.TabIndex = 2;
            // 
            // comboBox_connector
            // 
            this.comboBox_connector.FormattingEnabled = true;
            this.comboBox_connector.Items.AddRange(new object[] {
            "SATA",
            "SAS",
            "IDE"});
            this.comboBox_connector.Location = new System.Drawing.Point(110, 64);
            this.comboBox_connector.Name = "comboBox_connector";
            this.comboBox_connector.Size = new System.Drawing.Size(133, 21);
            this.comboBox_connector.TabIndex = 3;
            // 
            // label_rotaitionalSpeed
            // 
            this.label_rotaitionalSpeed.AutoSize = true;
            this.label_rotaitionalSpeed.Location = new System.Drawing.Point(12, 93);
            this.label_rotaitionalSpeed.Name = "label_rotaitionalSpeed";
            this.label_rotaitionalSpeed.Size = new System.Drawing.Size(92, 13);
            this.label_rotaitionalSpeed.TabIndex = 17;
            this.label_rotaitionalSpeed.Text = "Rotaitional speed:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(185, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "RPM";
            // 
            // textBox_capasity
            // 
            this.textBox_capasity.Location = new System.Drawing.Point(110, 11);
            this.textBox_capasity.MaxLength = 4;
            this.textBox_capasity.Name = "textBox_capasity";
            this.textBox_capasity.Size = new System.Drawing.Size(68, 20);
            this.textBox_capasity.TabIndex = 0;
            this.textBox_capasity.Enter += new System.EventHandler(this.textBox_capasity_Enter);
            // 
            // textBox_rpm
            // 
            this.textBox_rpm.Location = new System.Drawing.Point(110, 91);
            this.textBox_rpm.MaxLength = 6;
            this.textBox_rpm.Name = "textBox_rpm";
            this.textBox_rpm.Size = new System.Drawing.Size(68, 20);
            this.textBox_rpm.TabIndex = 4;
            this.textBox_rpm.Enter += new System.EventHandler(this.textBox_rpm_Enter);
            // 
            // AddHardDrive
            // 
            this.AcceptButton = this.button_add;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button_back;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.textBox_rpm);
            this.Controls.Add(this.textBox_capasity);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_connector);
            this.Controls.Add(this.comboBox_formFactor);
            this.Controls.Add(this.label_rotaitionalSpeed);
            this.Controls.Add(this.label_connector);
            this.Controls.Add(this.label_formFactor);
            this.Controls.Add(this.label_capasity);
            this.Controls.Add(this.comboBox_capasity);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.button_add);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddHardDrive";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Hard Drive";
            this.Load += new System.EventHandler(this.AddHardDrive_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Label label_capasity;
        private System.Windows.Forms.ComboBox comboBox_capasity;
        private System.Windows.Forms.Label label_formFactor;
        private System.Windows.Forms.Label label_connector;
        private System.Windows.Forms.ComboBox comboBox_formFactor;
        private System.Windows.Forms.ComboBox comboBox_connector;
        private System.Windows.Forms.Label label_rotaitionalSpeed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_capasity;
        private System.Windows.Forms.TextBox textBox_rpm;
    }
}