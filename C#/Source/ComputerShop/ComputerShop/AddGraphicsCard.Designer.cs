namespace ComputerShop
{
    partial class AddGraphicsCard
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
            this.label_vram = new System.Windows.Forms.Label();
            this.comboBox_vram = new System.Windows.Forms.ComboBox();
            this.textBox_vram = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_back
            // 
            this.button_back.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_back.Location = new System.Drawing.Point(116, 226);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(75, 23);
            this.button_back.TabIndex = 3;
            this.button_back.Text = "< Back";
            this.button_back.UseVisualStyleBackColor = true;
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(197, 226);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(75, 23);
            this.button_add.TabIndex = 2;
            this.button_add.Text = "Add";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // label_vram
            // 
            this.label_vram.AutoSize = true;
            this.label_vram.Location = new System.Drawing.Point(10, 14);
            this.label_vram.Name = "label_vram";
            this.label_vram.Size = new System.Drawing.Size(64, 13);
            this.label_vram.TabIndex = 14;
            this.label_vram.Text = "Video RAM:";
            // 
            // comboBox_vram
            // 
            this.comboBox_vram.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_vram.FormattingEnabled = true;
            this.comboBox_vram.Items.AddRange(new object[] {
            "MB",
            "GB"});
            this.comboBox_vram.Location = new System.Drawing.Point(152, 11);
            this.comboBox_vram.Name = "comboBox_vram";
            this.comboBox_vram.Size = new System.Drawing.Size(59, 21);
            this.comboBox_vram.TabIndex = 1;
            // 
            // textBox_vram
            // 
            this.textBox_vram.Location = new System.Drawing.Point(78, 11);
            this.textBox_vram.MaxLength = 4;
            this.textBox_vram.Name = "textBox_vram";
            this.textBox_vram.Size = new System.Drawing.Size(68, 20);
            this.textBox_vram.TabIndex = 0;
            this.textBox_vram.Enter += new System.EventHandler(this.textBox_vram_Enter);
            // 
            // AddGraphicsCard
            // 
            this.AcceptButton = this.button_add;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button_back;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.textBox_vram);
            this.Controls.Add(this.label_vram);
            this.Controls.Add(this.comboBox_vram);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.button_add);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddGraphicsCard";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Graphics Card";
            this.Load += new System.EventHandler(this.AddGraphicsCard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Label label_vram;
        private System.Windows.Forms.ComboBox comboBox_vram;
        private System.Windows.Forms.TextBox textBox_vram;
    }
}