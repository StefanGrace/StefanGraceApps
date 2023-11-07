namespace Uno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.restartButton = new System.Windows.Forms.Button();
            this.pauseButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.playerScoreLabel = new System.Windows.Forms.Label();
            this.helpButton = new System.Windows.Forms.Button();
            this.redButton = new System.Windows.Forms.Button();
            this.blueButton = new System.Windows.Forms.Button();
            this.yellowButton = new System.Windows.Forms.Button();
            this.greenButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.resetScoresButton = new System.Windows.Forms.Button();
            this.resetHiScoresButton = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Green;
            this.pictureBox1.Location = new System.Drawing.Point(184, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 480);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            this.pictureBox1.Resize += new System.EventHandler(this.pictureBox1_Resize);
            // 
            // restartButton
            // 
            this.restartButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.restartButton.Location = new System.Drawing.Point(93, 437);
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(75, 23);
            this.restartButton.TabIndex = 3;
            this.restartButton.Text = "Restart";
            this.restartButton.UseVisualStyleBackColor = true;
            this.restartButton.Click += new System.EventHandler(this.restartButton_Click);
            // 
            // pauseButton
            // 
            this.pauseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pauseButton.Location = new System.Drawing.Point(12, 437);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(75, 23);
            this.pauseButton.TabIndex = 2;
            this.pauseButton.Text = "Pause";
            this.pauseButton.UseVisualStyleBackColor = true;
            this.pauseButton.Click += new System.EventHandler(this.pauseButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.exitButton.Location = new System.Drawing.Point(93, 466);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // playerScoreLabel
            // 
            this.playerScoreLabel.AutoSize = true;
            this.playerScoreLabel.Location = new System.Drawing.Point(9, 9);
            this.playerScoreLabel.Name = "playerScoreLabel";
            this.playerScoreLabel.Size = new System.Drawing.Size(10, 13);
            this.playerScoreLabel.TabIndex = 4;
            this.playerScoreLabel.Text = " ";
            // 
            // helpButton
            // 
            this.helpButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.helpButton.Location = new System.Drawing.Point(12, 466);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(75, 23);
            this.helpButton.TabIndex = 4;
            this.helpButton.Text = "Hi-Scores";
            this.helpButton.UseVisualStyleBackColor = true;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // redButton
            // 
            this.redButton.BackColor = System.Drawing.Color.Red;
            this.redButton.Location = new System.Drawing.Point(23, 137);
            this.redButton.Name = "redButton";
            this.redButton.Size = new System.Drawing.Size(64, 64);
            this.redButton.TabIndex = 8;
            this.redButton.UseVisualStyleBackColor = false;
            this.redButton.Visible = false;
            this.redButton.Click += new System.EventHandler(this.redButton_Click);
            // 
            // blueButton
            // 
            this.blueButton.BackColor = System.Drawing.Color.Blue;
            this.blueButton.Location = new System.Drawing.Point(93, 137);
            this.blueButton.Name = "blueButton";
            this.blueButton.Size = new System.Drawing.Size(64, 64);
            this.blueButton.TabIndex = 9;
            this.blueButton.UseVisualStyleBackColor = false;
            this.blueButton.Visible = false;
            this.blueButton.Click += new System.EventHandler(this.blueButton_Click);
            // 
            // yellowButton
            // 
            this.yellowButton.BackColor = System.Drawing.Color.Yellow;
            this.yellowButton.Location = new System.Drawing.Point(23, 207);
            this.yellowButton.Name = "yellowButton";
            this.yellowButton.Size = new System.Drawing.Size(64, 64);
            this.yellowButton.TabIndex = 10;
            this.yellowButton.UseVisualStyleBackColor = false;
            this.yellowButton.Visible = false;
            this.yellowButton.Click += new System.EventHandler(this.yellowButton_Click);
            // 
            // greenButton
            // 
            this.greenButton.BackColor = System.Drawing.Color.Lime;
            this.greenButton.Location = new System.Drawing.Point(93, 207);
            this.greenButton.Name = "greenButton";
            this.greenButton.Size = new System.Drawing.Size(64, 64);
            this.greenButton.TabIndex = 11;
            this.greenButton.UseVisualStyleBackColor = false;
            this.greenButton.Visible = false;
            this.greenButton.Click += new System.EventHandler(this.greenButton_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // resetScoresButton
            // 
            this.resetScoresButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.resetScoresButton.Location = new System.Drawing.Point(12, 395);
            this.resetScoresButton.Name = "resetScoresButton";
            this.resetScoresButton.Size = new System.Drawing.Size(75, 36);
            this.resetScoresButton.TabIndex = 6;
            this.resetScoresButton.Text = "Reset Total Scores";
            this.resetScoresButton.UseVisualStyleBackColor = true;
            this.resetScoresButton.Click += new System.EventHandler(this.resetScoresButton_Click);
            // 
            // resetHiScoresButton
            // 
            this.resetHiScoresButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.resetHiScoresButton.Location = new System.Drawing.Point(93, 395);
            this.resetHiScoresButton.Name = "resetHiScoresButton";
            this.resetHiScoresButton.Size = new System.Drawing.Size(75, 36);
            this.resetHiScoresButton.TabIndex = 7;
            this.resetHiScoresButton.Text = "Reset Top Hi-Score";
            this.resetHiScoresButton.UseVisualStyleBackColor = true;
            this.resetHiScoresButton.Click += new System.EventHandler(this.resetHiScoresButton_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 10;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 501);
            this.Controls.Add(this.resetHiScoresButton);
            this.Controls.Add(this.resetScoresButton);
            this.Controls.Add(this.greenButton);
            this.Controls.Add(this.yellowButton);
            this.Controls.Add(this.blueButton);
            this.Controls.Add(this.redButton);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.playerScoreLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.pauseButton);
            this.Controls.Add(this.restartButton);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1010, 540);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Uno";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button restartButton;
        private System.Windows.Forms.Button pauseButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label playerScoreLabel;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.Button redButton;
        private System.Windows.Forms.Button blueButton;
        private System.Windows.Forms.Button yellowButton;
        private System.Windows.Forms.Button greenButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button resetScoresButton;
        private System.Windows.Forms.Button resetHiScoresButton;
        private System.Windows.Forms.Timer timer2;
    }
}

