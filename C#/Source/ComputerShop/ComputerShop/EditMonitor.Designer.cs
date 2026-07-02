namespace ComputerShop
{
    partial class EditMonitor
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
            this.checkBox_inStock = new System.Windows.Forms.CheckBox();
            this.label_dollarSign = new System.Windows.Forms.Label();
            this.label_price = new System.Windows.Forms.Label();
            this.label_procutName = new System.Windows.Forms.Label();
            this.textBox_price = new System.Windows.Forms.TextBox();
            this.textBox_productName = new System.Windows.Forms.TextBox();
            this.button_ok = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.textBox_refreshRate = new System.Windows.Forms.TextBox();
            this.textBox_size = new System.Windows.Forms.TextBox();
            this.textBox_inputs = new System.Windows.Forms.TextBox();
            this.textBox_panelType = new System.Windows.Forms.TextBox();
            this.textBox_usbHub = new System.Windows.Forms.TextBox();
            this.textBox_resolutionY = new System.Windows.Forms.TextBox();
            this.textBox_resolutionX = new System.Windows.Forms.TextBox();
            this.label_multiply = new System.Windows.Forms.Label();
            this.label_onePerLine = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_inch = new System.Windows.Forms.Label();
            this.label_hertz = new System.Windows.Forms.Label();
            this.label_usbHub = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_refreshRate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_resolution = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            // button_ok
            // 
            this.button_ok.Location = new System.Drawing.Point(116, 286);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(75, 23);
            this.button_ok.TabIndex = 40;
            this.button_ok.Text = "OK";
            this.button_ok.UseVisualStyleBackColor = true;
            this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_cancel.Location = new System.Drawing.Point(197, 286);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(75, 23);
            this.button_cancel.TabIndex = 41;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            // 
            // textBox_refreshRate
            // 
            this.textBox_refreshRate.Location = new System.Drawing.Point(94, 116);
            this.textBox_refreshRate.MaxLength = 8;
            this.textBox_refreshRate.Name = "textBox_refreshRate";
            this.textBox_refreshRate.Size = new System.Drawing.Size(68, 20);
            this.textBox_refreshRate.TabIndex = 6;
            // 
            // textBox_size
            // 
            this.textBox_size.Location = new System.Drawing.Point(94, 90);
            this.textBox_size.MaxLength = 8;
            this.textBox_size.Name = "textBox_size";
            this.textBox_size.Size = new System.Drawing.Size(68, 20);
            this.textBox_size.TabIndex = 5;
            // 
            // textBox_inputs
            // 
            this.textBox_inputs.AcceptsReturn = true;
            this.textBox_inputs.Location = new System.Drawing.Point(94, 168);
            this.textBox_inputs.MaxLength = 32000;
            this.textBox_inputs.Multiline = true;
            this.textBox_inputs.Name = "textBox_inputs";
            this.textBox_inputs.Size = new System.Drawing.Size(113, 78);
            this.textBox_inputs.TabIndex = 8;
            // 
            // textBox_panelType
            // 
            this.textBox_panelType.Location = new System.Drawing.Point(94, 142);
            this.textBox_panelType.MaxLength = 20;
            this.textBox_panelType.Multiline = true;
            this.textBox_panelType.Name = "textBox_panelType";
            this.textBox_panelType.Size = new System.Drawing.Size(113, 20);
            this.textBox_panelType.TabIndex = 7;
            // 
            // textBox_usbHub
            // 
            this.textBox_usbHub.Location = new System.Drawing.Point(94, 252);
            this.textBox_usbHub.MaxLength = 20;
            this.textBox_usbHub.Multiline = true;
            this.textBox_usbHub.Name = "textBox_usbHub";
            this.textBox_usbHub.Size = new System.Drawing.Size(113, 20);
            this.textBox_usbHub.TabIndex = 9;
            // 
            // textBox_resolutionY
            // 
            this.textBox_resolutionY.Location = new System.Drawing.Point(163, 64);
            this.textBox_resolutionY.MaxLength = 5;
            this.textBox_resolutionY.Name = "textBox_resolutionY";
            this.textBox_resolutionY.Size = new System.Drawing.Size(44, 20);
            this.textBox_resolutionY.TabIndex = 4;
            // 
            // textBox_resolutionX
            // 
            this.textBox_resolutionX.Location = new System.Drawing.Point(94, 64);
            this.textBox_resolutionX.MaxLength = 5;
            this.textBox_resolutionX.Name = "textBox_resolutionX";
            this.textBox_resolutionX.Size = new System.Drawing.Size(44, 20);
            this.textBox_resolutionX.TabIndex = 3;
            // 
            // label_multiply
            // 
            this.label_multiply.AutoSize = true;
            this.label_multiply.Location = new System.Drawing.Point(144, 67);
            this.label_multiply.Name = "label_multiply";
            this.label_multiply.Size = new System.Drawing.Size(13, 13);
            this.label_multiply.TabIndex = 56;
            this.label_multiply.Text = "×";
            // 
            // label_onePerLine
            // 
            this.label_onePerLine.AutoSize = true;
            this.label_onePerLine.Location = new System.Drawing.Point(12, 178);
            this.label_onePerLine.Name = "label_onePerLine";
            this.label_onePerLine.Size = new System.Drawing.Size(68, 13);
            this.label_onePerLine.TabIndex = 53;
            this.label_onePerLine.Text = "(one per line)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 54;
            this.label2.Text = "Inputs: ";
            // 
            // label_inch
            // 
            this.label_inch.AutoSize = true;
            this.label_inch.Location = new System.Drawing.Point(168, 92);
            this.label_inch.Name = "label_inch";
            this.label_inch.Size = new System.Drawing.Size(27, 13);
            this.label_inch.TabIndex = 57;
            this.label_inch.Text = "inch";
            // 
            // label_hertz
            // 
            this.label_hertz.AutoSize = true;
            this.label_hertz.Location = new System.Drawing.Point(168, 118);
            this.label_hertz.Name = "label_hertz";
            this.label_hertz.Size = new System.Drawing.Size(20, 13);
            this.label_hertz.TabIndex = 52;
            this.label_hertz.Text = "Hz";
            // 
            // label_usbHub
            // 
            this.label_usbHub.AutoSize = true;
            this.label_usbHub.Location = new System.Drawing.Point(12, 252);
            this.label_usbHub.Name = "label_usbHub";
            this.label_usbHub.Size = new System.Drawing.Size(53, 13);
            this.label_usbHub.TabIndex = 51;
            this.label_usbHub.Text = "USB hub:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 50;
            this.label3.Text = "Panel type:";
            // 
            // label_refreshRate
            // 
            this.label_refreshRate.AutoSize = true;
            this.label_refreshRate.Location = new System.Drawing.Point(12, 115);
            this.label_refreshRate.Name = "label_refreshRate";
            this.label_refreshRate.Size = new System.Drawing.Size(68, 13);
            this.label_refreshRate.TabIndex = 49;
            this.label_refreshRate.Text = "Refresh rate:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 55;
            this.label1.Text = "Diagonal size:";
            // 
            // label_resolution
            // 
            this.label_resolution.AutoSize = true;
            this.label_resolution.Location = new System.Drawing.Point(12, 64);
            this.label_resolution.Name = "label_resolution";
            this.label_resolution.Size = new System.Drawing.Size(60, 13);
            this.label_resolution.TabIndex = 58;
            this.label_resolution.Text = "Resolution:";
            // 
            // EditMonitor
            // 
            this.AcceptButton = this.button_ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button_cancel;
            this.ClientSize = new System.Drawing.Size(284, 321);
            this.Controls.Add(this.textBox_refreshRate);
            this.Controls.Add(this.textBox_size);
            this.Controls.Add(this.textBox_inputs);
            this.Controls.Add(this.textBox_panelType);
            this.Controls.Add(this.textBox_usbHub);
            this.Controls.Add(this.textBox_resolutionY);
            this.Controls.Add(this.textBox_resolutionX);
            this.Controls.Add(this.label_multiply);
            this.Controls.Add(this.label_onePerLine);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_inch);
            this.Controls.Add(this.label_hertz);
            this.Controls.Add(this.label_usbHub);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_refreshRate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_resolution);
            this.Controls.Add(this.button_ok);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.checkBox_inStock);
            this.Controls.Add(this.label_dollarSign);
            this.Controls.Add(this.label_price);
            this.Controls.Add(this.label_procutName);
            this.Controls.Add(this.textBox_price);
            this.Controls.Add(this.textBox_productName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditMonitor";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Monitor";
            this.Load += new System.EventHandler(this.EditMonitor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox_inStock;
        private System.Windows.Forms.Label label_dollarSign;
        private System.Windows.Forms.Label label_price;
        private System.Windows.Forms.Label label_procutName;
        private System.Windows.Forms.TextBox textBox_price;
        private System.Windows.Forms.TextBox textBox_productName;
        private System.Windows.Forms.Button button_ok;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.TextBox textBox_refreshRate;
        private System.Windows.Forms.TextBox textBox_size;
        private System.Windows.Forms.TextBox textBox_inputs;
        private System.Windows.Forms.TextBox textBox_panelType;
        private System.Windows.Forms.TextBox textBox_usbHub;
        private System.Windows.Forms.TextBox textBox_resolutionY;
        private System.Windows.Forms.TextBox textBox_resolutionX;
        private System.Windows.Forms.Label label_multiply;
        private System.Windows.Forms.Label label_onePerLine;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_inch;
        private System.Windows.Forms.Label label_hertz;
        private System.Windows.Forms.Label label_usbHub;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_refreshRate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_resolution;
    }
}