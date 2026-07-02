namespace ComputerShop
{
    partial class AddProduct
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
            this.groupBox_productType = new System.Windows.Forms.GroupBox();
            this.radioButton_monitor = new System.Windows.Forms.RadioButton();
            this.radioButton_hardDrive = new System.Windows.Forms.RadioButton();
            this.radioButton_graphicsCard = new System.Windows.Forms.RadioButton();
            this.radioButton_CPU = new System.Windows.Forms.RadioButton();
            this.textBox_productName = new System.Windows.Forms.TextBox();
            this.label_procutName = new System.Windows.Forms.Label();
            this.label_price = new System.Windows.Forms.Label();
            this.textBox_price = new System.Windows.Forms.TextBox();
            this.label_dollarSign = new System.Windows.Forms.Label();
            this.button_next = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.checkBox_inStock = new System.Windows.Forms.CheckBox();
            this.groupBox_productType.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_productType
            // 
            this.groupBox_productType.Controls.Add(this.radioButton_monitor);
            this.groupBox_productType.Controls.Add(this.radioButton_hardDrive);
            this.groupBox_productType.Controls.Add(this.radioButton_graphicsCard);
            this.groupBox_productType.Controls.Add(this.radioButton_CPU);
            this.groupBox_productType.Location = new System.Drawing.Point(13, 13);
            this.groupBox_productType.Name = "groupBox_productType";
            this.groupBox_productType.Size = new System.Drawing.Size(307, 115);
            this.groupBox_productType.TabIndex = 0;
            this.groupBox_productType.TabStop = false;
            this.groupBox_productType.Text = "Product type:";
            // 
            // radioButton_monitor
            // 
            this.radioButton_monitor.AutoSize = true;
            this.radioButton_monitor.Location = new System.Drawing.Point(6, 89);
            this.radioButton_monitor.Name = "radioButton_monitor";
            this.radioButton_monitor.Size = new System.Drawing.Size(60, 17);
            this.radioButton_monitor.TabIndex = 6;
            this.radioButton_monitor.TabStop = true;
            this.radioButton_monitor.Text = "Monitor";
            this.radioButton_monitor.UseVisualStyleBackColor = true;
            // 
            // radioButton_hardDrive
            // 
            this.radioButton_hardDrive.AutoSize = true;
            this.radioButton_hardDrive.Location = new System.Drawing.Point(7, 66);
            this.radioButton_hardDrive.Name = "radioButton_hardDrive";
            this.radioButton_hardDrive.Size = new System.Drawing.Size(74, 17);
            this.radioButton_hardDrive.TabIndex = 5;
            this.radioButton_hardDrive.TabStop = true;
            this.radioButton_hardDrive.Text = "Hard drive";
            this.radioButton_hardDrive.UseVisualStyleBackColor = true;
            // 
            // radioButton_graphicsCard
            // 
            this.radioButton_graphicsCard.AutoSize = true;
            this.radioButton_graphicsCard.Location = new System.Drawing.Point(7, 43);
            this.radioButton_graphicsCard.Name = "radioButton_graphicsCard";
            this.radioButton_graphicsCard.Size = new System.Drawing.Size(91, 17);
            this.radioButton_graphicsCard.TabIndex = 4;
            this.radioButton_graphicsCard.TabStop = true;
            this.radioButton_graphicsCard.Text = "Graphics card";
            this.radioButton_graphicsCard.UseVisualStyleBackColor = true;
            // 
            // radioButton_CPU
            // 
            this.radioButton_CPU.AutoSize = true;
            this.radioButton_CPU.Checked = true;
            this.radioButton_CPU.Location = new System.Drawing.Point(7, 20);
            this.radioButton_CPU.Name = "radioButton_CPU";
            this.radioButton_CPU.Size = new System.Drawing.Size(47, 17);
            this.radioButton_CPU.TabIndex = 3;
            this.radioButton_CPU.TabStop = true;
            this.radioButton_CPU.Text = "CPU";
            this.radioButton_CPU.UseVisualStyleBackColor = true;
            // 
            // textBox_productName
            // 
            this.textBox_productName.Location = new System.Drawing.Point(95, 135);
            this.textBox_productName.MaxLength = 30;
            this.textBox_productName.Name = "textBox_productName";
            this.textBox_productName.Size = new System.Drawing.Size(232, 20);
            this.textBox_productName.TabIndex = 0;
            // 
            // label_procutName
            // 
            this.label_procutName.AutoSize = true;
            this.label_procutName.Location = new System.Drawing.Point(13, 138);
            this.label_procutName.Name = "label_procutName";
            this.label_procutName.Size = new System.Drawing.Size(76, 13);
            this.label_procutName.TabIndex = 2;
            this.label_procutName.Text = "Product name:";
            // 
            // label_price
            // 
            this.label_price.AutoSize = true;
            this.label_price.Location = new System.Drawing.Point(13, 163);
            this.label_price.Name = "label_price";
            this.label_price.Size = new System.Drawing.Size(34, 13);
            this.label_price.TabIndex = 2;
            this.label_price.Text = "Price:";
            // 
            // textBox_price
            // 
            this.textBox_price.Location = new System.Drawing.Point(110, 160);
            this.textBox_price.MaxLength = 14;
            this.textBox_price.Name = "textBox_price";
            this.textBox_price.Size = new System.Drawing.Size(104, 20);
            this.textBox_price.TabIndex = 1;
            // 
            // label_dollarSign
            // 
            this.label_dollarSign.AutoSize = true;
            this.label_dollarSign.Location = new System.Drawing.Point(92, 163);
            this.label_dollarSign.Name = "label_dollarSign";
            this.label_dollarSign.Size = new System.Drawing.Size(13, 13);
            this.label_dollarSign.TabIndex = 2;
            this.label_dollarSign.Text = "$";
            // 
            // button_next
            // 
            this.button_next.Location = new System.Drawing.Point(245, 197);
            this.button_next.Name = "button_next";
            this.button_next.Size = new System.Drawing.Size(75, 23);
            this.button_next.TabIndex = 7;
            this.button_next.Text = "Next >";
            this.button_next.UseVisualStyleBackColor = true;
            this.button_next.Click += new System.EventHandler(this.button_next_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_cancel.Location = new System.Drawing.Point(164, 197);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(75, 23);
            this.button_cancel.TabIndex = 8;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            // 
            // checkBox_inStock
            // 
            this.checkBox_inStock.AutoSize = true;
            this.checkBox_inStock.Checked = true;
            this.checkBox_inStock.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_inStock.Location = new System.Drawing.Point(231, 163);
            this.checkBox_inStock.Name = "checkBox_inStock";
            this.checkBox_inStock.Size = new System.Drawing.Size(64, 17);
            this.checkBox_inStock.TabIndex = 2;
            this.checkBox_inStock.Text = "In-stock";
            this.checkBox_inStock.UseVisualStyleBackColor = true;
            // 
            // AddProduct
            // 
            this.AcceptButton = this.button_next;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button_cancel;
            this.ClientSize = new System.Drawing.Size(332, 232);
            this.Controls.Add(this.checkBox_inStock);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_next);
            this.Controls.Add(this.label_dollarSign);
            this.Controls.Add(this.label_price);
            this.Controls.Add(this.label_procutName);
            this.Controls.Add(this.textBox_price);
            this.Controls.Add(this.textBox_productName);
            this.Controls.Add(this.groupBox_productType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddProduct";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Product";
            this.groupBox_productType.ResumeLayout(false);
            this.groupBox_productType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_productType;
        private System.Windows.Forms.RadioButton radioButton_monitor;
        private System.Windows.Forms.RadioButton radioButton_hardDrive;
        private System.Windows.Forms.RadioButton radioButton_graphicsCard;
        private System.Windows.Forms.RadioButton radioButton_CPU;
        private System.Windows.Forms.TextBox textBox_productName;
        private System.Windows.Forms.Label label_procutName;
        private System.Windows.Forms.Label label_price;
        private System.Windows.Forms.TextBox textBox_price;
        private System.Windows.Forms.Label label_dollarSign;
        private System.Windows.Forms.Button button_next;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.CheckBox checkBox_inStock;
    }
}