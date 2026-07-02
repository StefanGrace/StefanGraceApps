namespace ComputerShop
{
    partial class EditGraphicsCard
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
            this.textBox_vram = new System.Windows.Forms.TextBox();
            this.label_vram = new System.Windows.Forms.Label();
            this.comboBox_vram = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button_ok
            // 
            this.button_ok.Location = new System.Drawing.Point(116, 226);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(75, 23);
            this.button_ok.TabIndex = 6;
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
            this.button_cancel.TabIndex = 7;
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
            this.label_dollarSign.Location = new System.Drawing.Point(75, 41);
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
            this.textBox_price.Location = new System.Drawing.Point(94, 38);
            this.textBox_price.MaxLength = 14;
            this.textBox_price.Name = "textBox_price";
            this.textBox_price.Size = new System.Drawing.Size(106, 20);
            this.textBox_price.TabIndex = 1;
            // 
            // textBox_productName
            // 
            this.textBox_productName.Location = new System.Drawing.Point(94, 12);
            this.textBox_productName.MaxLength = 30;
            this.textBox_productName.Name = "textBox_productName";
            this.textBox_productName.Size = new System.Drawing.Size(178, 20);
            this.textBox_productName.TabIndex = 0;
            // 
            // textBox_vram
            // 
            this.textBox_vram.Location = new System.Drawing.Point(94, 64);
            this.textBox_vram.MaxLength = 4;
            this.textBox_vram.Name = "textBox_vram";
            this.textBox_vram.Size = new System.Drawing.Size(68, 20);
            this.textBox_vram.TabIndex = 3;
            // 
            // label_vram
            // 
            this.label_vram.AutoSize = true;
            this.label_vram.Location = new System.Drawing.Point(12, 67);
            this.label_vram.Name = "label_vram";
            this.label_vram.Size = new System.Drawing.Size(64, 13);
            this.label_vram.TabIndex = 42;
            this.label_vram.Text = "Video RAM:";
            // 
            // comboBox_vram
            // 
            this.comboBox_vram.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_vram.FormattingEnabled = true;
            this.comboBox_vram.Items.AddRange(new object[] {
            "MB",
            "GB"});
            this.comboBox_vram.Location = new System.Drawing.Point(168, 64);
            this.comboBox_vram.Name = "comboBox_vram";
            this.comboBox_vram.Size = new System.Drawing.Size(59, 21);
            this.comboBox_vram.TabIndex = 4;
            // 
            // EditGraphicsCard
            // 
            this.AcceptButton = this.button_ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button_cancel;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.textBox_vram);
            this.Controls.Add(this.label_vram);
            this.Controls.Add(this.comboBox_vram);
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
            this.Name = "EditGraphicsCard";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Graphics Card";
            this.Load += new System.EventHandler(this.EditGraphicsCard_Load);
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
        private System.Windows.Forms.TextBox textBox_vram;
        private System.Windows.Forms.Label label_vram;
        private System.Windows.Forms.ComboBox comboBox_vram;
    }
}