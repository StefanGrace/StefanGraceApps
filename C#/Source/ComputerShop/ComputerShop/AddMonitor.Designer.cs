namespace ComputerShop
{
    partial class AddMonitor
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
            this.label_resolution = new System.Windows.Forms.Label();
            this.textBox_resolutionX = new System.Windows.Forms.TextBox();
            this.textBox_resolutionY = new System.Windows.Forms.TextBox();
            this.label_multiply = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_refreshRate = new System.Windows.Forms.Label();
            this.textBox_usbHub = new System.Windows.Forms.TextBox();
            this.label_usbHub = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_inputs = new System.Windows.Forms.TextBox();
            this.label_hertz = new System.Windows.Forms.Label();
            this.label_inch = new System.Windows.Forms.Label();
            this.label_onePerLine = new System.Windows.Forms.Label();
            this.textBox_panelType = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_size = new System.Windows.Forms.TextBox();
            this.textBox_refreshRate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_back
            // 
            this.button_back.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_back.Location = new System.Drawing.Point(116, 226);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(75, 23);
            this.button_back.TabIndex = 8;
            this.button_back.Text = "< Back";
            this.button_back.UseVisualStyleBackColor = true;
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(197, 226);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(75, 23);
            this.button_add.TabIndex = 7;
            this.button_add.Text = "Add";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // label_resolution
            // 
            this.label_resolution.AutoSize = true;
            this.label_resolution.Location = new System.Drawing.Point(12, 15);
            this.label_resolution.Name = "label_resolution";
            this.label_resolution.Size = new System.Drawing.Size(60, 13);
            this.label_resolution.TabIndex = 18;
            this.label_resolution.Text = "Resolution:";
            // 
            // textBox_resolutionX
            // 
            this.textBox_resolutionX.Location = new System.Drawing.Point(91, 12);
            this.textBox_resolutionX.MaxLength = 5;
            this.textBox_resolutionX.Name = "textBox_resolutionX";
            this.textBox_resolutionX.Size = new System.Drawing.Size(44, 20);
            this.textBox_resolutionX.TabIndex = 0;
            this.textBox_resolutionX.Enter += new System.EventHandler(this.textBox_resolutionX_Enter);
            // 
            // textBox_resolutionY
            // 
            this.textBox_resolutionY.Location = new System.Drawing.Point(160, 12);
            this.textBox_resolutionY.MaxLength = 5;
            this.textBox_resolutionY.Name = "textBox_resolutionY";
            this.textBox_resolutionY.Size = new System.Drawing.Size(44, 20);
            this.textBox_resolutionY.TabIndex = 1;
            this.textBox_resolutionY.Enter += new System.EventHandler(this.textBox_resolutionY_Enter);
            // 
            // label_multiply
            // 
            this.label_multiply.AutoSize = true;
            this.label_multiply.Location = new System.Drawing.Point(141, 15);
            this.label_multiply.Name = "label_multiply";
            this.label_multiply.Size = new System.Drawing.Size(13, 13);
            this.label_multiply.TabIndex = 18;
            this.label_multiply.Text = "×";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Diagonal size:";
            // 
            // label_refreshRate
            // 
            this.label_refreshRate.AutoSize = true;
            this.label_refreshRate.Location = new System.Drawing.Point(12, 66);
            this.label_refreshRate.Name = "label_refreshRate";
            this.label_refreshRate.Size = new System.Drawing.Size(68, 13);
            this.label_refreshRate.TabIndex = 18;
            this.label_refreshRate.Text = "Refresh rate:";
            // 
            // textBox_usbHub
            // 
            this.textBox_usbHub.Location = new System.Drawing.Point(91, 200);
            this.textBox_usbHub.MaxLength = 20;
            this.textBox_usbHub.Multiline = true;
            this.textBox_usbHub.Name = "textBox_usbHub";
            this.textBox_usbHub.Size = new System.Drawing.Size(113, 20);
            this.textBox_usbHub.TabIndex = 6;
            this.textBox_usbHub.Enter += new System.EventHandler(this.textBox_usbHub_Enter);
            // 
            // label_usbHub
            // 
            this.label_usbHub.AutoSize = true;
            this.label_usbHub.Location = new System.Drawing.Point(12, 203);
            this.label_usbHub.Name = "label_usbHub";
            this.label_usbHub.Size = new System.Drawing.Size(53, 13);
            this.label_usbHub.TabIndex = 18;
            this.label_usbHub.Text = "USB hub:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Inputs: ";
            // 
            // textBox_inputs
            // 
            this.textBox_inputs.AcceptsReturn = true;
            this.textBox_inputs.Location = new System.Drawing.Point(91, 116);
            this.textBox_inputs.MaxLength = 32000;
            this.textBox_inputs.Multiline = true;
            this.textBox_inputs.Name = "textBox_inputs";
            this.textBox_inputs.Size = new System.Drawing.Size(113, 78);
            this.textBox_inputs.TabIndex = 5;
            // 
            // label_hertz
            // 
            this.label_hertz.AutoSize = true;
            this.label_hertz.Location = new System.Drawing.Point(165, 66);
            this.label_hertz.Name = "label_hertz";
            this.label_hertz.Size = new System.Drawing.Size(20, 13);
            this.label_hertz.TabIndex = 18;
            this.label_hertz.Text = "Hz";
            // 
            // label_inch
            // 
            this.label_inch.AutoSize = true;
            this.label_inch.Location = new System.Drawing.Point(165, 40);
            this.label_inch.Name = "label_inch";
            this.label_inch.Size = new System.Drawing.Size(27, 13);
            this.label_inch.TabIndex = 18;
            this.label_inch.Text = "inch";
            // 
            // label_onePerLine
            // 
            this.label_onePerLine.AutoSize = true;
            this.label_onePerLine.Location = new System.Drawing.Point(12, 129);
            this.label_onePerLine.Name = "label_onePerLine";
            this.label_onePerLine.Size = new System.Drawing.Size(68, 13);
            this.label_onePerLine.TabIndex = 18;
            this.label_onePerLine.Text = "(one per line)";
            // 
            // textBox_panelType
            // 
            this.textBox_panelType.Location = new System.Drawing.Point(91, 90);
            this.textBox_panelType.MaxLength = 20;
            this.textBox_panelType.Multiline = true;
            this.textBox_panelType.Name = "textBox_panelType";
            this.textBox_panelType.Size = new System.Drawing.Size(113, 20);
            this.textBox_panelType.TabIndex = 4;
            this.textBox_panelType.Enter += new System.EventHandler(this.textBox_panelType_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Panel type:";
            // 
            // textBox_size
            // 
            this.textBox_size.Location = new System.Drawing.Point(91, 38);
            this.textBox_size.MaxLength = 8;
            this.textBox_size.Name = "textBox_size";
            this.textBox_size.Size = new System.Drawing.Size(68, 20);
            this.textBox_size.TabIndex = 2;
            this.textBox_size.Enter += new System.EventHandler(this.textBox_size_Enter);
            // 
            // textBox_refreshRate
            // 
            this.textBox_refreshRate.Location = new System.Drawing.Point(91, 64);
            this.textBox_refreshRate.MaxLength = 8;
            this.textBox_refreshRate.Name = "textBox_refreshRate";
            this.textBox_refreshRate.Size = new System.Drawing.Size(68, 20);
            this.textBox_refreshRate.TabIndex = 3;
            this.textBox_refreshRate.Enter += new System.EventHandler(this.textBox_refreshRate_Enter);
            // 
            // AddMonitor
            // 
            this.AcceptButton = this.button_add;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button_back;
            this.ClientSize = new System.Drawing.Size(284, 261);
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
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.button_add);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddMonitor";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Monitor";
            this.Load += new System.EventHandler(this.AddMonitor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Label label_resolution;
        private System.Windows.Forms.TextBox textBox_resolutionX;
        private System.Windows.Forms.TextBox textBox_resolutionY;
        private System.Windows.Forms.Label label_multiply;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_refreshRate;
        private System.Windows.Forms.TextBox textBox_usbHub;
        private System.Windows.Forms.Label label_usbHub;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_inputs;
        private System.Windows.Forms.Label label_hertz;
        private System.Windows.Forms.Label label_inch;
        private System.Windows.Forms.Label label_onePerLine;
        private System.Windows.Forms.TextBox textBox_panelType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_size;
        private System.Windows.Forms.TextBox textBox_refreshRate;
    }
}