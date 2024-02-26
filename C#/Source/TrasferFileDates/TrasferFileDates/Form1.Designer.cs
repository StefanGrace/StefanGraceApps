namespace TrasferFileDates
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
            this.label_fromDir = new System.Windows.Forms.Label();
            this.textBox_fromDir = new System.Windows.Forms.TextBox();
            this.label_toDir = new System.Windows.Forms.Label();
            this.textBox_toDir = new System.Windows.Forms.TextBox();
            this.label_fromExt = new System.Windows.Forms.Label();
            this.textBox_fromExt = new System.Windows.Forms.TextBox();
            this.label_toExt = new System.Windows.Forms.Label();
            this.textBox_toExt = new System.Windows.Forms.TextBox();
            this.checkBox_modified = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox_created = new System.Windows.Forms.CheckBox();
            this.checkBox_accessed = new System.Windows.Forms.CheckBox();
            this.button_trasfer = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_fromDir
            // 
            this.label_fromDir.AutoSize = true;
            this.label_fromDir.Location = new System.Drawing.Point(12, 18);
            this.label_fromDir.Name = "label_fromDir";
            this.label_fromDir.Size = new System.Drawing.Size(79, 13);
            this.label_fromDir.TabIndex = 0;
            this.label_fromDir.Text = "From files in dir:";
            // 
            // textBox_fromDir
            // 
            this.textBox_fromDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_fromDir.Location = new System.Drawing.Point(97, 15);
            this.textBox_fromDir.Name = "textBox_fromDir";
            this.textBox_fromDir.Size = new System.Drawing.Size(515, 20);
            this.textBox_fromDir.TabIndex = 0;
            // 
            // label_toDir
            // 
            this.label_toDir.AutoSize = true;
            this.label_toDir.Location = new System.Drawing.Point(12, 44);
            this.label_toDir.Name = "label_toDir";
            this.label_toDir.Size = new System.Drawing.Size(69, 13);
            this.label_toDir.TabIndex = 0;
            this.label_toDir.Text = "To files in dir:";
            // 
            // textBox_toDir
            // 
            this.textBox_toDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_toDir.Location = new System.Drawing.Point(97, 41);
            this.textBox_toDir.Name = "textBox_toDir";
            this.textBox_toDir.Size = new System.Drawing.Size(515, 20);
            this.textBox_toDir.TabIndex = 1;
            // 
            // label_fromExt
            // 
            this.label_fromExt.AutoSize = true;
            this.label_fromExt.Location = new System.Drawing.Point(12, 79);
            this.label_fromExt.Name = "label_fromExt";
            this.label_fromExt.Size = new System.Drawing.Size(93, 13);
            this.label_fromExt.TabIndex = 0;
            this.label_fromExt.Text = "From files with ext:";
            // 
            // textBox_fromExt
            // 
            this.textBox_fromExt.Location = new System.Drawing.Point(111, 76);
            this.textBox_fromExt.Name = "textBox_fromExt";
            this.textBox_fromExt.Size = new System.Drawing.Size(100, 20);
            this.textBox_fromExt.TabIndex = 2;
            this.textBox_fromExt.Text = "bmp";
            // 
            // label_toExt
            // 
            this.label_toExt.AutoSize = true;
            this.label_toExt.Location = new System.Drawing.Point(239, 79);
            this.label_toExt.Name = "label_toExt";
            this.label_toExt.Size = new System.Drawing.Size(83, 13);
            this.label_toExt.TabIndex = 0;
            this.label_toExt.Text = "To files with ext:";
            // 
            // textBox_toExt
            // 
            this.textBox_toExt.Location = new System.Drawing.Point(328, 76);
            this.textBox_toExt.Name = "textBox_toExt";
            this.textBox_toExt.Size = new System.Drawing.Size(100, 20);
            this.textBox_toExt.TabIndex = 3;
            this.textBox_toExt.Text = "png";
            // 
            // checkBox_modified
            // 
            this.checkBox_modified.AutoSize = true;
            this.checkBox_modified.Checked = true;
            this.checkBox_modified.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_modified.Location = new System.Drawing.Point(6, 19);
            this.checkBox_modified.Name = "checkBox_modified";
            this.checkBox_modified.Size = new System.Drawing.Size(66, 17);
            this.checkBox_modified.TabIndex = 4;
            this.checkBox_modified.Text = "Modified";
            this.checkBox_modified.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox_accessed);
            this.groupBox1.Controls.Add(this.checkBox_created);
            this.groupBox1.Controls.Add(this.checkBox_modified);
            this.groupBox1.Location = new System.Drawing.Point(15, 114);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(245, 47);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dates to trasfer";
            // 
            // checkBox_created
            // 
            this.checkBox_created.AutoSize = true;
            this.checkBox_created.Location = new System.Drawing.Point(82, 19);
            this.checkBox_created.Name = "checkBox_created";
            this.checkBox_created.Size = new System.Drawing.Size(63, 17);
            this.checkBox_created.TabIndex = 5;
            this.checkBox_created.Text = "Created";
            this.checkBox_created.UseVisualStyleBackColor = true;
            // 
            // checkBox_accessed
            // 
            this.checkBox_accessed.AutoSize = true;
            this.checkBox_accessed.Location = new System.Drawing.Point(151, 19);
            this.checkBox_accessed.Name = "checkBox_accessed";
            this.checkBox_accessed.Size = new System.Drawing.Size(73, 17);
            this.checkBox_accessed.TabIndex = 6;
            this.checkBox_accessed.Text = "Accessed";
            this.checkBox_accessed.UseVisualStyleBackColor = true;
            // 
            // button_trasfer
            // 
            this.button_trasfer.Location = new System.Drawing.Point(537, 142);
            this.button_trasfer.Name = "button_trasfer";
            this.button_trasfer.Size = new System.Drawing.Size(75, 23);
            this.button_trasfer.TabIndex = 5;
            this.button_trasfer.Text = "Trasfer";
            this.button_trasfer.UseVisualStyleBackColor = true;
            this.button_trasfer.Click += new System.EventHandler(this.button_trasfer_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.button_trasfer;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 177);
            this.Controls.Add(this.button_trasfer);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox_toExt);
            this.Controls.Add(this.textBox_fromExt);
            this.Controls.Add(this.textBox_toDir);
            this.Controls.Add(this.label_toDir);
            this.Controls.Add(this.textBox_fromDir);
            this.Controls.Add(this.label_toExt);
            this.Controls.Add(this.label_fromExt);
            this.Controls.Add(this.label_fromDir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trasfer Files Dates";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_fromDir;
        private System.Windows.Forms.TextBox textBox_fromDir;
        private System.Windows.Forms.Label label_toDir;
        private System.Windows.Forms.TextBox textBox_toDir;
        private System.Windows.Forms.Label label_fromExt;
        private System.Windows.Forms.TextBox textBox_fromExt;
        private System.Windows.Forms.Label label_toExt;
        private System.Windows.Forms.TextBox textBox_toExt;
        private System.Windows.Forms.CheckBox checkBox_modified;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox_accessed;
        private System.Windows.Forms.CheckBox checkBox_created;
        private System.Windows.Forms.Button button_trasfer;
    }
}

