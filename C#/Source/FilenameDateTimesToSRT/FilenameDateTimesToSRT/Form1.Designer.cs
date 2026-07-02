namespace FilenameDateTimesToSRT
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
            this.inputFileTextBox = new System.Windows.Forms.TextBox();
            this.inputFileRadioButton = new System.Windows.Forms.RadioButton();
            this.inputSingleRadioButton = new System.Windows.Forms.RadioButton();
            this.inputSingleTextBox = new System.Windows.Forms.TextBox();
            this.inputListRadioButton = new System.Windows.Forms.RadioButton();
            this.editListButton = new System.Windows.Forms.Button();
            this.durationLabel = new System.Windows.Forms.Label();
            this.hoursNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.minutesNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.secondsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.hoursLabel = new System.Windows.Forms.Label();
            this.minutesLabel = new System.Windows.Forms.Label();
            this.secondsLabel = new System.Windows.Forms.Label();
            this.errorsLabel = new System.Windows.Forms.Label();
            this.viewErrorsButton = new System.Windows.Forms.Button();
            this.createButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.hoursNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutesNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondsNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // inputFileTextBox
            // 
            this.inputFileTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputFileTextBox.Location = new System.Drawing.Point(151, 13);
            this.inputFileTextBox.Name = "inputFileTextBox";
            this.inputFileTextBox.Size = new System.Drawing.Size(362, 20);
            this.inputFileTextBox.TabIndex = 1;
            // 
            // inputFileRadioButton
            // 
            this.inputFileRadioButton.AutoSize = true;
            this.inputFileRadioButton.Checked = true;
            this.inputFileRadioButton.Location = new System.Drawing.Point(13, 13);
            this.inputFileRadioButton.Name = "inputFileRadioButton";
            this.inputFileRadioButton.Size = new System.Drawing.Size(132, 17);
            this.inputFileRadioButton.TabIndex = 0;
            this.inputFileRadioButton.TabStop = true;
            this.inputFileRadioButton.Text = "Read list from TXT file:";
            this.inputFileRadioButton.UseVisualStyleBackColor = true;
            this.inputFileRadioButton.CheckedChanged += new System.EventHandler(this.inputFileRadioButton_CheckedChanged);
            // 
            // inputSingleRadioButton
            // 
            this.inputSingleRadioButton.AutoSize = true;
            this.inputSingleRadioButton.Location = new System.Drawing.Point(13, 42);
            this.inputSingleRadioButton.Name = "inputSingleRadioButton";
            this.inputSingleRadioButton.Size = new System.Drawing.Size(125, 17);
            this.inputSingleRadioButton.TabIndex = 2;
            this.inputSingleRadioButton.Text = "Enter single filename:";
            this.inputSingleRadioButton.UseVisualStyleBackColor = true;
            this.inputSingleRadioButton.CheckedChanged += new System.EventHandler(this.inputSingleRadioButton_CheckedChanged);
            // 
            // inputSingleTextBox
            // 
            this.inputSingleTextBox.Enabled = false;
            this.inputSingleTextBox.Location = new System.Drawing.Point(151, 39);
            this.inputSingleTextBox.Name = "inputSingleTextBox";
            this.inputSingleTextBox.Size = new System.Drawing.Size(362, 20);
            this.inputSingleTextBox.TabIndex = 3;
            // 
            // inputListRadioButton
            // 
            this.inputListRadioButton.AutoSize = true;
            this.inputListRadioButton.Location = new System.Drawing.Point(13, 69);
            this.inputListRadioButton.Name = "inputListRadioButton";
            this.inputListRadioButton.Size = new System.Drawing.Size(127, 17);
            this.inputListRadioButton.TabIndex = 4;
            this.inputListRadioButton.Text = "Enter list of filenames:";
            this.inputListRadioButton.UseVisualStyleBackColor = true;
            this.inputListRadioButton.CheckedChanged += new System.EventHandler(this.inputListRadioButton_CheckedChanged);
            // 
            // editListButton
            // 
            this.editListButton.Location = new System.Drawing.Point(151, 66);
            this.editListButton.Name = "editListButton";
            this.editListButton.Size = new System.Drawing.Size(75, 23);
            this.editListButton.TabIndex = 5;
            this.editListButton.Text = "Edit...";
            this.editListButton.UseVisualStyleBackColor = true;
            this.editListButton.Click += new System.EventHandler(this.editListButton_Click);
            // 
            // durationLabel
            // 
            this.durationLabel.AutoSize = true;
            this.durationLabel.Location = new System.Drawing.Point(13, 119);
            this.durationLabel.Name = "durationLabel";
            this.durationLabel.Size = new System.Drawing.Size(84, 13);
            this.durationLabel.TabIndex = 3;
            this.durationLabel.Text = "Duration per file:";
            // 
            // hoursNumericUpDown
            // 
            this.hoursNumericUpDown.Location = new System.Drawing.Point(104, 117);
            this.hoursNumericUpDown.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.hoursNumericUpDown.Name = "hoursNumericUpDown";
            this.hoursNumericUpDown.Size = new System.Drawing.Size(41, 20);
            this.hoursNumericUpDown.TabIndex = 6;
            // 
            // minutesNumericUpDown
            // 
            this.minutesNumericUpDown.Location = new System.Drawing.Point(170, 117);
            this.minutesNumericUpDown.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.minutesNumericUpDown.Name = "minutesNumericUpDown";
            this.minutesNumericUpDown.Size = new System.Drawing.Size(41, 20);
            this.minutesNumericUpDown.TabIndex = 7;
            this.minutesNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // secondsNumericUpDown
            // 
            this.secondsNumericUpDown.Location = new System.Drawing.Point(246, 117);
            this.secondsNumericUpDown.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.secondsNumericUpDown.Name = "secondsNumericUpDown";
            this.secondsNumericUpDown.Size = new System.Drawing.Size(41, 20);
            this.secondsNumericUpDown.TabIndex = 8;
            // 
            // hoursLabel
            // 
            this.hoursLabel.AutoSize = true;
            this.hoursLabel.Location = new System.Drawing.Point(151, 119);
            this.hoursLabel.Name = "hoursLabel";
            this.hoursLabel.Size = new System.Drawing.Size(13, 13);
            this.hoursLabel.TabIndex = 3;
            this.hoursLabel.Text = "h";
            // 
            // minutesLabel
            // 
            this.minutesLabel.AutoSize = true;
            this.minutesLabel.Location = new System.Drawing.Point(217, 119);
            this.minutesLabel.Name = "minutesLabel";
            this.minutesLabel.Size = new System.Drawing.Size(23, 13);
            this.minutesLabel.TabIndex = 3;
            this.minutesLabel.Text = "min";
            // 
            // secondsLabel
            // 
            this.secondsLabel.AutoSize = true;
            this.secondsLabel.Location = new System.Drawing.Point(293, 119);
            this.secondsLabel.Name = "secondsLabel";
            this.secondsLabel.Size = new System.Drawing.Size(12, 13);
            this.secondsLabel.TabIndex = 3;
            this.secondsLabel.Text = "s";
            // 
            // errorsLabel
            // 
            this.errorsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.errorsLabel.AutoSize = true;
            this.errorsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorsLabel.Location = new System.Drawing.Point(13, 179);
            this.errorsLabel.Name = "errorsLabel";
            this.errorsLabel.Size = new System.Drawing.Size(50, 13);
            this.errorsLabel.TabIndex = 5;
            this.errorsLabel.Text = "0 errors";
            // 
            // viewErrorsButton
            // 
            this.viewErrorsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.viewErrorsButton.Location = new System.Drawing.Point(89, 173);
            this.viewErrorsButton.Name = "viewErrorsButton";
            this.viewErrorsButton.Size = new System.Drawing.Size(75, 23);
            this.viewErrorsButton.TabIndex = 9;
            this.viewErrorsButton.Text = "View...";
            this.viewErrorsButton.UseVisualStyleBackColor = true;
            this.viewErrorsButton.Click += new System.EventHandler(this.viewErrorsButton_Click);
            // 
            // createButton
            // 
            this.createButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.createButton.Location = new System.Drawing.Point(438, 174);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(75, 23);
            this.createButton.TabIndex = 10;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.createButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 209);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.viewErrorsButton);
            this.Controls.Add(this.errorsLabel);
            this.Controls.Add(this.secondsNumericUpDown);
            this.Controls.Add(this.minutesNumericUpDown);
            this.Controls.Add(this.hoursNumericUpDown);
            this.Controls.Add(this.secondsLabel);
            this.Controls.Add(this.minutesLabel);
            this.Controls.Add(this.hoursLabel);
            this.Controls.Add(this.durationLabel);
            this.Controls.Add(this.editListButton);
            this.Controls.Add(this.inputListRadioButton);
            this.Controls.Add(this.inputSingleRadioButton);
            this.Controls.Add(this.inputFileRadioButton);
            this.Controls.Add(this.inputSingleTextBox);
            this.Controls.Add(this.inputFileTextBox);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filename date/times to SRT";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hoursNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutesNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondsNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputFileTextBox;
        private System.Windows.Forms.RadioButton inputFileRadioButton;
        private System.Windows.Forms.RadioButton inputSingleRadioButton;
        private System.Windows.Forms.TextBox inputSingleTextBox;
        private System.Windows.Forms.RadioButton inputListRadioButton;
        private System.Windows.Forms.Button editListButton;
        private System.Windows.Forms.Label durationLabel;
        private System.Windows.Forms.NumericUpDown hoursNumericUpDown;
        private System.Windows.Forms.NumericUpDown minutesNumericUpDown;
        private System.Windows.Forms.NumericUpDown secondsNumericUpDown;
        private System.Windows.Forms.Label hoursLabel;
        private System.Windows.Forms.Label minutesLabel;
        private System.Windows.Forms.Label secondsLabel;
        private System.Windows.Forms.Label errorsLabel;
        private System.Windows.Forms.Button viewErrorsButton;
        private System.Windows.Forms.Button createButton;
    }
}

