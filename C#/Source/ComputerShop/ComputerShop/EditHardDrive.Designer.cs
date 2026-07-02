namespace ComputerShop
{
    partial class EditHardDrive
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
            this.button_ok = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.checkBox_inStock = new System.Windows.Forms.CheckBox();
            this.label_dollarSign = new System.Windows.Forms.Label();
            this.label_price = new System.Windows.Forms.Label();
            this.label_procutName = new System.Windows.Forms.Label();
            this.textBox_price = new System.Windows.Forms.TextBox();
            this.textBox_productName = new System.Windows.Forms.TextBox();
            this.textBox_rpm = new System.Windows.Forms.TextBox();
            this.textBox_capasity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_connector = new System.Windows.Forms.ComboBox();
            this.comboBox_formFactor = new System.Windows.Forms.ComboBox();
            this.label_rotaitionalSpeed = new System.Windows.Forms.Label();
            this.label_connector = new System.Windows.Forms.Label();
            this.label_formFactor = new System.Windows.Forms.Label();
            this.label_capasity = new System.Windows.Forms.Label();
            this.comboBox_capasity = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button_ok
            // 
            this.button_ok.Location = new System.Drawing.Point(116, 226);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(75, 23);
            this.button_ok.TabIndex = 8;
            this.button_ok.Text = "OK";
            this.button_ok.UseVisualStyleBackColor = true;
            this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_cancel.Location = new System.Drawing.Point(197, 226);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(75, 23);
            this.button_cancel.TabIndex = 9;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            // 
            // checkBox_inStock
            // 
            this.checkBox_inStock.AutoSize = true;
            this.checkBox_inStock.Checked = true;
            this.checkBox_inStock.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_inStock.Location = new System.Drawing.Point(206, 41);
            this.checkBox_inStock.Name = "checkBox_inStock";
            this.checkBox_inStock.Size = new System.Drawing.Size(64, 17);
            this.checkBox_inStock.TabIndex = 2;
            this.checkBox_inStock.Text = "In-stock";
            this.checkBox_inStock.UseVisualStyleBackColor = true;
            // 
            // label_dollarSign
            // 
            this.label_dollarSign.AutoSize = true;
            this.label_dollarSign.Location = new System.Drawing.Point(97, 41);
            this.label_dollarSign.Name = "label_dollarSign";
            this.label_dollarSign.Size = new System.Drawing.Size(13, 13);
            this.label_dollarSign.TabIndex = 37;
            this.label_dollarSign.Text = "$";
            // 
            // label_price
            // 
            this.label_price.AutoSize = true;
            this.label_price.Location = new System.Drawing.Point(12, 41);
            this.label_price.Name = "label_price";
            this.label_price.Size = new System.Drawing.Size(34, 13);
            this.label_price.TabIndex = 38;
            this.label_price.Text = "Price:";
            // 
            // label_procutName
            // 
            this.label_procutName.AutoSize = true;
            this.label_procutName.Location = new System.Drawing.Point(12, 15);
            this.label_procutName.Name = "label_procutName";
            this.label_procutName.Size = new System.Drawing.Size(76, 13);
            this.label_procutName.TabIndex = 39;
            this.label_procutName.Text = "Product name:";
            // 
            // textBox_price
            // 
            this.textBox_price.Location = new System.Drawing.Point(116, 38);
            this.textBox_price.MaxLength = 14;
            this.textBox_price.Name = "textBox_price";
            this.textBox_price.Size = new System.Drawing.Size(84, 20);
            this.textBox_price.TabIndex = 1;
            // 
            // textBox_productName
            // 
            this.textBox_productName.Location = new System.Drawing.Point(116, 12);
            this.textBox_productName.MaxLength = 30;
            this.textBox_productName.Name = "textBox_productName";
            this.textBox_productName.Size = new System.Drawing.Size(156, 20);
            this.textBox_productName.TabIndex = 0;
            // 
            // textBox_rpm
            // 
            this.textBox_rpm.Location = new System.Drawing.Point(116, 144);
            this.textBox_rpm.MaxLength = 6;
            this.textBox_rpm.Name = "textBox_rpm";
            this.textBox_rpm.Size = new System.Drawing.Size(68, 20);
            this.textBox_rpm.TabIndex = 7;
            // 
            // textBox_capasity
            // 
            this.textBox_capasity.Location = new System.Drawing.Point(116, 64);
            this.textBox_capasity.MaxLength = 4;
            this.textBox_capasity.Name = "textBox_capasity";
            this.textBox_capasity.Size = new System.Drawing.Size(68, 20);
            this.textBox_capasity.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(191, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 49;
            this.label1.Text = "RPM";
            // 
            // comboBox_connector
            // 
            this.comboBox_connector.FormattingEnabled = true;
            this.comboBox_connector.Items.AddRange(new object[] {
            "SATA",
            "SAS",
            "IDE"});
            this.comboBox_connector.Location = new System.Drawing.Point(116, 117);
            this.comboBox_connector.Name = "comboBox_connector";
            this.comboBox_connector.Size = new System.Drawing.Size(133, 21);
            this.comboBox_connector.TabIndex = 6;
            // 
            // comboBox_formFactor
            // 
            this.comboBox_formFactor.FormattingEnabled = true;
            this.comboBox_formFactor.Items.AddRange(new object[] {
            "2.5 inch",
            "3.5 inch"});
            this.comboBox_formFactor.Location = new System.Drawing.Point(116, 90);
            this.comboBox_formFactor.Name = "comboBox_formFactor";
            this.comboBox_formFactor.Size = new System.Drawing.Size(132, 21);
            this.comboBox_formFactor.TabIndex = 5;
            // 
            // label_rotaitionalSpeed
            // 
            this.label_rotaitionalSpeed.AutoSize = true;
            this.label_rotaitionalSpeed.Location = new System.Drawing.Point(12, 146);
            this.label_rotaitionalSpeed.Name = "label_rotaitionalSpeed";
            this.label_rotaitionalSpeed.Size = new System.Drawing.Size(92, 13);
            this.label_rotaitionalSpeed.TabIndex = 45;
            this.label_rotaitionalSpeed.Text = "Rotaitional speed:";
            // 
            // label_connector
            // 
            this.label_connector.AutoSize = true;
            this.label_connector.Location = new System.Drawing.Point(12, 120);
            this.label_connector.Name = "label_connector";
            this.label_connector.Size = new System.Drawing.Size(53, 13);
            this.label_connector.TabIndex = 46;
            this.label_connector.Text = "Conector:";
            // 
            // label_formFactor
            // 
            this.label_formFactor.AutoSize = true;
            this.label_formFactor.Location = new System.Drawing.Point(12, 94);
            this.label_formFactor.Name = "label_formFactor";
            this.label_formFactor.Size = new System.Drawing.Size(63, 13);
            this.label_formFactor.TabIndex = 47;
            this.label_formFactor.Text = "Form factor:";
            // 
            // label_capasity
            // 
            this.label_capasity.AutoSize = true;
            this.label_capasity.Location = new System.Drawing.Point(12, 67);
            this.label_capasity.Name = "label_capasity";
            this.label_capasity.Size = new System.Drawing.Size(50, 13);
            this.label_capasity.TabIndex = 48;
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
            this.comboBox_capasity.Location = new System.Drawing.Point(189, 64);
            this.comboBox_capasity.Name = "comboBox_capasity";
            this.comboBox_capasity.Size = new System.Drawing.Size(59, 21);
            this.comboBox_capasity.TabIndex = 4;
            // 
            // EditHardDrive
            // 
            this.AcceptButton = this.button_ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button_cancel;
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
            this.Controls.Add(this.checkBox_inStock);
            this.Controls.Add(this.label_dollarSign);
            this.Controls.Add(this.label_price);
            this.Controls.Add(this.label_procutName);
            this.Controls.Add(this.textBox_price);
            this.Controls.Add(this.textBox_productName);
            this.Controls.Add(this.button_ok);
            this.Controls.Add(this.button_cancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditHardDrive";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Hard Drive";
            this.Load += new System.EventHandler(this.EditHardDrive_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_ok;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.CheckBox checkBox_inStock;
        private System.Windows.Forms.Label label_dollarSign;
        private System.Windows.Forms.Label label_price;
        private System.Windows.Forms.Label label_procutName;
        private System.Windows.Forms.TextBox textBox_price;
        private System.Windows.Forms.TextBox textBox_productName;
        private System.Windows.Forms.TextBox textBox_rpm;
        private System.Windows.Forms.TextBox textBox_capasity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_connector;
        private System.Windows.Forms.ComboBox comboBox_formFactor;
        private System.Windows.Forms.Label label_rotaitionalSpeed;
        private System.Windows.Forms.Label label_connector;
        private System.Windows.Forms.Label label_formFactor;
        private System.Windows.Forms.Label label_capasity;
        private System.Windows.Forms.ComboBox comboBox_capasity;
    }
}