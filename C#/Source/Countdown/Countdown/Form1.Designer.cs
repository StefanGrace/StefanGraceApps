namespace Countdown
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
            this.components = new System.ComponentModel.Container();
            this.currentDateLabel = new System.Windows.Forms.Label();
            this.untilLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.hoursLabel = new System.Windows.Forms.Label();
            this.minutesLabel = new System.Windows.Forms.Label();
            this.secondsLabel = new System.Windows.Forms.Label();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.monthTextBox = new System.Windows.Forms.TextBox();
            this.dayTextBox = new System.Windows.Forms.TextBox();
            this.hourTextBox = new System.Windows.Forms.TextBox();
            this.minuteTextBox = new System.Windows.Forms.TextBox();
            this.secondTextBox = new System.Windows.Forms.TextBox();
            this.yearInputLabel = new System.Windows.Forms.Label();
            this.monthInputLabel = new System.Windows.Forms.Label();
            this.dayInputLabel = new System.Windows.Forms.Label();
            this.hourInputLabel = new System.Windows.Forms.Label();
            this.minuteInputLabel = new System.Windows.Forms.Label();
            this.secondInputLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.InvalidDateLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // currentDateLabel
            // 
            this.currentDateLabel.AutoSize = true;
            this.currentDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentDateLabel.Location = new System.Drawing.Point(66, 27);
            this.currentDateLabel.Name = "currentDateLabel";
            this.currentDateLabel.Size = new System.Drawing.Size(232, 37);
            this.currentDateLabel.TabIndex = 0;
            this.currentDateLabel.Text = "Current Date: ";
            // 
            // untilLabel
            // 
            this.untilLabel.AutoSize = true;
            this.untilLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.untilLabel.Location = new System.Drawing.Point(284, 313);
            this.untilLabel.Name = "untilLabel";
            this.untilLabel.Size = new System.Drawing.Size(86, 37);
            this.untilLabel.TabIndex = 1;
            this.untilLabel.Text = "Until";
            this.untilLabel.Click += new System.EventHandler(this.untilLabel_Click);
            // 
            // timeLabel
            // 
            this.timeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.Location = new System.Drawing.Point(139, 155);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(59, 25);
            this.timeLabel.TabIndex = 0;
            this.timeLabel.Text = "Time";
            this.timeLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // hoursLabel
            // 
            this.hoursLabel.AutoSize = true;
            this.hoursLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoursLabel.Location = new System.Drawing.Point(139, 204);
            this.hoursLabel.Name = "hoursLabel";
            this.hoursLabel.Size = new System.Drawing.Size(69, 25);
            this.hoursLabel.TabIndex = 0;
            this.hoursLabel.Text = "Hours";
            // 
            // minutesLabel
            // 
            this.minutesLabel.AutoSize = true;
            this.minutesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minutesLabel.Location = new System.Drawing.Point(139, 229);
            this.minutesLabel.Name = "minutesLabel";
            this.minutesLabel.Size = new System.Drawing.Size(88, 25);
            this.minutesLabel.TabIndex = 0;
            this.minutesLabel.Text = "Minutes";
            // 
            // secondsLabel
            // 
            this.secondsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.secondsLabel.AutoSize = true;
            this.secondsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondsLabel.Location = new System.Drawing.Point(139, 254);
            this.secondsLabel.Name = "secondsLabel";
            this.secondsLabel.Size = new System.Drawing.Size(96, 25);
            this.secondsLabel.TabIndex = 0;
            this.secondsLabel.Text = "Seconds";
            // 
            // yearTextBox
            // 
            this.yearTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearTextBox.Location = new System.Drawing.Point(144, 380);
            this.yearTextBox.MaxLength = 4;
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(83, 40);
            this.yearTextBox.TabIndex = 0;
            this.yearTextBox.Text = "2100";
            this.yearTextBox.TextChanged += new System.EventHandler(this.yearTextBox_TextChanged);
            // 
            // monthTextBox
            // 
            this.monthTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthTextBox.Location = new System.Drawing.Point(233, 380);
            this.monthTextBox.MaxLength = 2;
            this.monthTextBox.Name = "monthTextBox";
            this.monthTextBox.Size = new System.Drawing.Size(39, 40);
            this.monthTextBox.TabIndex = 1;
            this.monthTextBox.Text = "01";
            this.monthTextBox.TextChanged += new System.EventHandler(this.monthTextBox_TextChanged);
            // 
            // dayTextBox
            // 
            this.dayTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayTextBox.Location = new System.Drawing.Point(278, 380);
            this.dayTextBox.MaxLength = 2;
            this.dayTextBox.Name = "dayTextBox";
            this.dayTextBox.Size = new System.Drawing.Size(39, 40);
            this.dayTextBox.TabIndex = 2;
            this.dayTextBox.Text = "01";
            this.dayTextBox.TextChanged += new System.EventHandler(this.monthTextBox_TextChanged);
            // 
            // hourTextBox
            // 
            this.hourTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hourTextBox.Location = new System.Drawing.Point(352, 380);
            this.hourTextBox.MaxLength = 2;
            this.hourTextBox.Name = "hourTextBox";
            this.hourTextBox.Size = new System.Drawing.Size(39, 40);
            this.hourTextBox.TabIndex = 3;
            this.hourTextBox.Text = "00";
            this.hourTextBox.TextChanged += new System.EventHandler(this.monthTextBox_TextChanged);
            // 
            // minuteTextBox
            // 
            this.minuteTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minuteTextBox.Location = new System.Drawing.Point(397, 380);
            this.minuteTextBox.MaxLength = 2;
            this.minuteTextBox.Name = "minuteTextBox";
            this.minuteTextBox.Size = new System.Drawing.Size(39, 40);
            this.minuteTextBox.TabIndex = 4;
            this.minuteTextBox.Text = "00";
            this.minuteTextBox.TextChanged += new System.EventHandler(this.monthTextBox_TextChanged);
            // 
            // secondTextBox
            // 
            this.secondTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondTextBox.Location = new System.Drawing.Point(442, 380);
            this.secondTextBox.MaxLength = 2;
            this.secondTextBox.Name = "secondTextBox";
            this.secondTextBox.Size = new System.Drawing.Size(39, 40);
            this.secondTextBox.TabIndex = 5;
            this.secondTextBox.Text = "00";
            this.secondTextBox.TextChanged += new System.EventHandler(this.monthTextBox_TextChanged);
            // 
            // yearInputLabel
            // 
            this.yearInputLabel.AutoSize = true;
            this.yearInputLabel.Location = new System.Drawing.Point(173, 423);
            this.yearInputLabel.Name = "yearInputLabel";
            this.yearInputLabel.Size = new System.Drawing.Size(29, 13);
            this.yearInputLabel.TabIndex = 3;
            this.yearInputLabel.Text = "Year";
            // 
            // monthInputLabel
            // 
            this.monthInputLabel.AutoSize = true;
            this.monthInputLabel.Location = new System.Drawing.Point(233, 423);
            this.monthInputLabel.Name = "monthInputLabel";
            this.monthInputLabel.Size = new System.Drawing.Size(37, 13);
            this.monthInputLabel.TabIndex = 3;
            this.monthInputLabel.Text = "Month";
            // 
            // dayInputLabel
            // 
            this.dayInputLabel.AutoSize = true;
            this.dayInputLabel.Location = new System.Drawing.Point(282, 423);
            this.dayInputLabel.Name = "dayInputLabel";
            this.dayInputLabel.Size = new System.Drawing.Size(26, 13);
            this.dayInputLabel.TabIndex = 3;
            this.dayInputLabel.Text = "Day";
            // 
            // hourInputLabel
            // 
            this.hourInputLabel.AutoSize = true;
            this.hourInputLabel.Location = new System.Drawing.Point(356, 423);
            this.hourInputLabel.Name = "hourInputLabel";
            this.hourInputLabel.Size = new System.Drawing.Size(30, 13);
            this.hourInputLabel.TabIndex = 3;
            this.hourInputLabel.Text = "Hour";
            // 
            // minuteInputLabel
            // 
            this.minuteInputLabel.AutoSize = true;
            this.minuteInputLabel.Location = new System.Drawing.Point(394, 423);
            this.minuteInputLabel.Name = "minuteInputLabel";
            this.minuteInputLabel.Size = new System.Drawing.Size(39, 13);
            this.minuteInputLabel.TabIndex = 3;
            this.minuteInputLabel.Text = "Minute";
            // 
            // secondInputLabel
            // 
            this.secondInputLabel.AutoSize = true;
            this.secondInputLabel.Location = new System.Drawing.Point(442, 423);
            this.secondInputLabel.Name = "secondInputLabel";
            this.secondInputLabel.Size = new System.Drawing.Size(44, 13);
            this.secondInputLabel.TabIndex = 3;
            this.secondInputLabel.Text = "Second";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // InvalidDateLabel
            // 
            this.InvalidDateLabel.AutoSize = true;
            this.InvalidDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvalidDateLabel.ForeColor = System.Drawing.Color.Red;
            this.InvalidDateLabel.Location = new System.Drawing.Point(287, 460);
            this.InvalidDateLabel.Name = "InvalidDateLabel";
            this.InvalidDateLabel.Size = new System.Drawing.Size(94, 20);
            this.InvalidDateLabel.TabIndex = 6;
            this.InvalidDateLabel.Text = "Invalid date!";
            this.InvalidDateLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 521);
            this.Controls.Add(this.InvalidDateLabel);
            this.Controls.Add(this.secondInputLabel);
            this.Controls.Add(this.minuteInputLabel);
            this.Controls.Add(this.hourInputLabel);
            this.Controls.Add(this.dayInputLabel);
            this.Controls.Add(this.monthInputLabel);
            this.Controls.Add(this.yearInputLabel);
            this.Controls.Add(this.secondTextBox);
            this.Controls.Add(this.minuteTextBox);
            this.Controls.Add(this.hourTextBox);
            this.Controls.Add(this.dayTextBox);
            this.Controls.Add(this.monthTextBox);
            this.Controls.Add(this.yearTextBox);
            this.Controls.Add(this.untilLabel);
            this.Controls.Add(this.secondsLabel);
            this.Controls.Add(this.minutesLabel);
            this.Controls.Add(this.hoursLabel);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.currentDateLabel);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(690, 560);
            this.MinimumSize = new System.Drawing.Size(690, 560);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Countdown";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label currentDateLabel;
        private System.Windows.Forms.Label untilLabel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label hoursLabel;
        private System.Windows.Forms.Label minutesLabel;
        private System.Windows.Forms.Label secondsLabel;
        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.TextBox monthTextBox;
        private System.Windows.Forms.TextBox dayTextBox;
        private System.Windows.Forms.TextBox hourTextBox;
        private System.Windows.Forms.TextBox minuteTextBox;
        private System.Windows.Forms.TextBox secondTextBox;
        private System.Windows.Forms.Label yearInputLabel;
        private System.Windows.Forms.Label monthInputLabel;
        private System.Windows.Forms.Label dayInputLabel;
        private System.Windows.Forms.Label hourInputLabel;
        private System.Windows.Forms.Label minuteInputLabel;
        private System.Windows.Forms.Label secondInputLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label InvalidDateLabel;
    }
}

