namespace NoteBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.noteArea = new System.Windows.Forms.TextBox();
            this.notesListBox = new System.Windows.Forms.ListBox();
            this.addNoteButton = new System.Windows.Forms.Button();
            this.noteTitleTextBox = new System.Windows.Forms.TextBox();
            this.modifiedLabel = new System.Windows.Forms.Label();
            this.createdLabel = new System.Windows.Forms.Label();
            this.noteTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // noteArea
            // 
            this.noteArea.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.noteArea.BackColor = System.Drawing.SystemColors.Info;
            this.noteArea.ForeColor = System.Drawing.SystemColors.Info;
            this.noteArea.Location = new System.Drawing.Point(265, 12);
            this.noteArea.MaxLength = 1;
            this.noteArea.Multiline = true;
            this.noteArea.Name = "noteArea";
            this.noteArea.Size = new System.Drawing.Size(692, 522);
            this.noteArea.TabIndex = 0;
            this.noteArea.TabStop = false;
            // 
            // notesListBox
            // 
            this.notesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.notesListBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.notesListBox.FormattingEnabled = true;
            this.notesListBox.Location = new System.Drawing.Point(12, 72);
            this.notesListBox.Name = "notesListBox";
            this.notesListBox.Size = new System.Drawing.Size(247, 459);
            this.notesListBox.TabIndex = 1;
            this.notesListBox.SelectedIndexChanged += new System.EventHandler(this.notesListBox_SelectedIndexChanged);
            // 
            // addNoteButton
            // 
            this.addNoteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNoteButton.Location = new System.Drawing.Point(13, 12);
            this.addNoteButton.Name = "addNoteButton";
            this.addNoteButton.Size = new System.Drawing.Size(246, 54);
            this.addNoteButton.TabIndex = 2;
            this.addNoteButton.Text = "+ New";
            this.addNoteButton.UseVisualStyleBackColor = true;
            this.addNoteButton.Click += new System.EventHandler(this.addNoteButton_Click);
            // 
            // noteTitleTextBox
            // 
            this.noteTitleTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.noteTitleTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.noteTitleTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.noteTitleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noteTitleTextBox.Location = new System.Drawing.Point(279, 21);
            this.noteTitleTextBox.Name = "noteTitleTextBox";
            this.noteTitleTextBox.Size = new System.Drawing.Size(494, 24);
            this.noteTitleTextBox.TabIndex = 3;
            this.noteTitleTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // modifiedLabel
            // 
            this.modifiedLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.modifiedLabel.AutoSize = true;
            this.modifiedLabel.BackColor = System.Drawing.SystemColors.Info;
            this.modifiedLabel.Location = new System.Drawing.Point(779, 36);
            this.modifiedLabel.Name = "modifiedLabel";
            this.modifiedLabel.Size = new System.Drawing.Size(0, 13);
            this.modifiedLabel.TabIndex = 4;
            this.modifiedLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // createdLabel
            // 
            this.createdLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.createdLabel.AutoSize = true;
            this.createdLabel.BackColor = System.Drawing.SystemColors.Info;
            this.createdLabel.Location = new System.Drawing.Point(782, 21);
            this.createdLabel.Name = "createdLabel";
            this.createdLabel.Size = new System.Drawing.Size(0, 13);
            this.createdLabel.TabIndex = 5;
            this.createdLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // noteTextBox
            // 
            this.noteTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.noteTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.noteTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.noteTextBox.Location = new System.Drawing.Point(279, 72);
            this.noteTextBox.Multiline = true;
            this.noteTextBox.Name = "noteTextBox";
            this.noteTextBox.Size = new System.Drawing.Size(660, 437);
            this.noteTextBox.TabIndex = 6;
            this.noteTextBox.TextChanged += new System.EventHandler(this.NoteTextBox_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 546);
            this.Controls.Add(this.noteTextBox);
            this.Controls.Add(this.createdLabel);
            this.Controls.Add(this.modifiedLabel);
            this.Controls.Add(this.noteTitleTextBox);
            this.Controls.Add(this.addNoteButton);
            this.Controls.Add(this.notesListBox);
            this.Controls.Add(this.noteArea);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Note Book";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox noteArea;
        private System.Windows.Forms.ListBox notesListBox;
        private System.Windows.Forms.Button addNoteButton;
        private System.Windows.Forms.TextBox noteTitleTextBox;
        private System.Windows.Forms.Label modifiedLabel;
        private System.Windows.Forms.Label createdLabel;
        private System.Windows.Forms.TextBox noteTextBox;
    }
}

