namespace Clock
{
    partial class PresetNameForm
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
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_ok = new System.Windows.Forms.Button();
            this.label_presetName = new System.Windows.Forms.Label();
            this.textBox_presetName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_cancel
            // 
            this.button_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_cancel.Location = new System.Drawing.Point(257, 76);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(75, 23);
            this.button_cancel.TabIndex = 2;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            // 
            // button_ok
            // 
            this.button_ok.Enabled = false;
            this.button_ok.Location = new System.Drawing.Point(176, 76);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(75, 23);
            this.button_ok.TabIndex = 1;
            this.button_ok.Text = "OK";
            this.button_ok.UseVisualStyleBackColor = true;
            this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
            // 
            // label_presetName
            // 
            this.label_presetName.AutoSize = true;
            this.label_presetName.Location = new System.Drawing.Point(14, 27);
            this.label_presetName.Name = "label_presetName";
            this.label_presetName.Size = new System.Drawing.Size(69, 13);
            this.label_presetName.TabIndex = 2;
            this.label_presetName.Text = "Preset name:";
            // 
            // textBox_presetName
            // 
            this.textBox_presetName.Location = new System.Drawing.Point(89, 24);
            this.textBox_presetName.MaxLength = 32;
            this.textBox_presetName.Name = "textBox_presetName";
            this.textBox_presetName.Size = new System.Drawing.Size(228, 20);
            this.textBox_presetName.TabIndex = 0;
            this.textBox_presetName.TextChanged += new System.EventHandler(this.textBox_presetName_TextChanged);
            // 
            // PresetNameForm
            // 
            this.AcceptButton = this.button_ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button_cancel;
            this.ClientSize = new System.Drawing.Size(344, 111);
            this.ControlBox = false;
            this.Controls.Add(this.textBox_presetName);
            this.Controls.Add(this.label_presetName);
            this.Controls.Add(this.button_ok);
            this.Controls.Add(this.button_cancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "PresetNameForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Preset Name";
            this.Load += new System.EventHandler(this.PresetNameForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Button button_ok;
        private System.Windows.Forms.Label label_presetName;
        private System.Windows.Forms.TextBox textBox_presetName;
    }
}