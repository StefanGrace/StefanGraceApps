namespace UnitConverter
{
    partial class VolumeLengthFunctionForm
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
            this.radioButton_sidesOfCube = new System.Windows.Forms.RadioButton();
            this.radioButton_radiusOfSphere = new System.Windows.Forms.RadioButton();
            this.radioButton_diameterOfSphere = new System.Windows.Forms.RadioButton();
            this.button_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // radioButton_sidesOfCube
            // 
            this.radioButton_sidesOfCube.AutoSize = true;
            this.radioButton_sidesOfCube.Location = new System.Drawing.Point(13, 13);
            this.radioButton_sidesOfCube.Name = "radioButton_sidesOfCube";
            this.radioButton_sidesOfCube.Size = new System.Drawing.Size(136, 17);
            this.radioButton_sidesOfCube.TabIndex = 0;
            this.radioButton_sidesOfCube.TabStop = true;
            this.radioButton_sidesOfCube.Text = "Length of sides of cube";
            this.radioButton_sidesOfCube.UseVisualStyleBackColor = true;            // 
            // radioButton_radiusOfSphere
            // 
            this.radioButton_radiusOfSphere.AutoSize = true;
            this.radioButton_radiusOfSphere.Location = new System.Drawing.Point(13, 36);
            this.radioButton_radiusOfSphere.Name = "radioButton_radiusOfSphere";
            this.radioButton_radiusOfSphere.Size = new System.Drawing.Size(105, 17);
            this.radioButton_radiusOfSphere.TabIndex = 0;
            this.radioButton_radiusOfSphere.TabStop = true;
            this.radioButton_radiusOfSphere.Text = "Radius of sphere";
            this.radioButton_radiusOfSphere.UseVisualStyleBackColor = true;
            // 
            // radioButton_diameterOfSphere
            // 
            this.radioButton_diameterOfSphere.AutoSize = true;
            this.radioButton_diameterOfSphere.Location = new System.Drawing.Point(13, 59);
            this.radioButton_diameterOfSphere.Name = "radioButton_diameterOfSphere";
            this.radioButton_diameterOfSphere.Size = new System.Drawing.Size(114, 17);
            this.radioButton_diameterOfSphere.TabIndex = 0;
            this.radioButton_diameterOfSphere.TabStop = true;
            this.radioButton_diameterOfSphere.Text = "Diameter of sphere";
            this.radioButton_diameterOfSphere.UseVisualStyleBackColor = true;            // 
            // button_cancel
            // 
            this.button_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_cancel.Location = new System.Drawing.Point(106, 92);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(70, 23);
            this.button_cancel.TabIndex = 1;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // VolumeLengthFunctionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button_cancel;
            this.ClientSize = new System.Drawing.Size(279, 127);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.radioButton_diameterOfSphere);
            this.Controls.Add(this.radioButton_radiusOfSphere);
            this.Controls.Add(this.radioButton_sidesOfCube);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VolumeLengthFunctionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.VolumeLengthFunctionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton_sidesOfCube;
        private System.Windows.Forms.RadioButton radioButton_radiusOfSphere;
        private System.Windows.Forms.RadioButton radioButton_diameterOfSphere;
        private System.Windows.Forms.Button button_cancel;
    }
}