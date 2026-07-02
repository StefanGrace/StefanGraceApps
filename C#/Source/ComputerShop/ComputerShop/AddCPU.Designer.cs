namespace ComputerShop
{
    partial class AddCPU
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
            this.button_add = new System.Windows.Forms.Button();
            this.button_back = new System.Windows.Forms.Button();
            this.textBox_socket = new System.Windows.Forms.TextBox();
            this.comboBox_baseClock = new System.Windows.Forms.ComboBox();
            this.comboBox_boostClock = new System.Windows.Forms.ComboBox();
            this.comboBox_cach = new System.Windows.Forms.ComboBox();
            this.label_watts = new System.Windows.Forms.Label();
            this.label_cores = new System.Windows.Forms.Label();
            this.label_threads = new System.Windows.Forms.Label();
            this.label_baseClock = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_cache = new System.Windows.Forms.Label();
            this.label_socket = new System.Windows.Forms.Label();
            this.label_tpd = new System.Windows.Forms.Label();
            this.textBox_baseClock = new System.Windows.Forms.TextBox();
            this.textBox_cache = new System.Windows.Forms.TextBox();
            this.textBox_boostClock = new System.Windows.Forms.TextBox();
            this.textBox_threads = new System.Windows.Forms.TextBox();
            this.textBox_cores = new System.Windows.Forms.TextBox();
            this.textBox_tpd = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(197, 226);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(75, 23);
            this.button_add.TabIndex = 10;
            this.button_add.Text = "Add";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_back
            // 
            this.button_back.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_back.Location = new System.Drawing.Point(116, 226);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(75, 23);
            this.button_back.TabIndex = 11;
            this.button_back.Text = "< Back";
            this.button_back.UseVisualStyleBackColor = true;
            // 
            // textBox_socket
            // 
            this.textBox_socket.Location = new System.Drawing.Point(80, 142);
            this.textBox_socket.MaxLength = 20;
            this.textBox_socket.Name = "textBox_socket";
            this.textBox_socket.Size = new System.Drawing.Size(133, 20);
            this.textBox_socket.TabIndex = 5;
            this.textBox_socket.Enter += new System.EventHandler(this.textBox_socket_Enter);
            // 
            // comboBox_baseClock
            // 
            this.comboBox_baseClock.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_baseClock.FormattingEnabled = true;
            this.comboBox_baseClock.Items.AddRange(new object[] {
            "MHz",
            "GHz"});
            this.comboBox_baseClock.Location = new System.Drawing.Point(154, 63);
            this.comboBox_baseClock.Name = "comboBox_baseClock";
            this.comboBox_baseClock.Size = new System.Drawing.Size(59, 21);
            this.comboBox_baseClock.TabIndex = 7;
            // 
            // comboBox_boostClock
            // 
            this.comboBox_boostClock.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_boostClock.FormattingEnabled = true;
            this.comboBox_boostClock.Items.AddRange(new object[] {
            "MHz",
            "GHz"});
            this.comboBox_boostClock.Location = new System.Drawing.Point(154, 90);
            this.comboBox_boostClock.Name = "comboBox_boostClock";
            this.comboBox_boostClock.Size = new System.Drawing.Size(59, 21);
            this.comboBox_boostClock.TabIndex = 8;
            // 
            // comboBox_cach
            // 
            this.comboBox_cach.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_cach.FormattingEnabled = true;
            this.comboBox_cach.Items.AddRange(new object[] {
            "kB",
            "MB"});
            this.comboBox_cach.Location = new System.Drawing.Point(154, 115);
            this.comboBox_cach.Name = "comboBox_cach";
            this.comboBox_cach.Size = new System.Drawing.Size(59, 21);
            this.comboBox_cach.TabIndex = 9;
            // 
            // label_watts
            // 
            this.label_watts.AutoSize = true;
            this.label_watts.Location = new System.Drawing.Point(153, 173);
            this.label_watts.Name = "label_watts";
            this.label_watts.Size = new System.Drawing.Size(18, 13);
            this.label_watts.TabIndex = 4;
            this.label_watts.Text = "W";
            // 
            // label_cores
            // 
            this.label_cores.AutoSize = true;
            this.label_cores.Location = new System.Drawing.Point(12, 14);
            this.label_cores.Name = "label_cores";
            this.label_cores.Size = new System.Drawing.Size(37, 13);
            this.label_cores.TabIndex = 5;
            this.label_cores.Text = "Cores:";
            // 
            // label_threads
            // 
            this.label_threads.AutoSize = true;
            this.label_threads.Location = new System.Drawing.Point(12, 40);
            this.label_threads.Name = "label_threads";
            this.label_threads.Size = new System.Drawing.Size(49, 13);
            this.label_threads.TabIndex = 5;
            this.label_threads.Text = "Threads:";
            // 
            // label_baseClock
            // 
            this.label_baseClock.AutoSize = true;
            this.label_baseClock.Location = new System.Drawing.Point(12, 66);
            this.label_baseClock.Name = "label_baseClock";
            this.label_baseClock.Size = new System.Drawing.Size(63, 13);
            this.label_baseClock.TabIndex = 5;
            this.label_baseClock.Text = "Base clock:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Boost clock:";
            // 
            // label_cache
            // 
            this.label_cache.AutoSize = true;
            this.label_cache.Location = new System.Drawing.Point(12, 118);
            this.label_cache.Name = "label_cache";
            this.label_cache.Size = new System.Drawing.Size(41, 13);
            this.label_cache.TabIndex = 5;
            this.label_cache.Text = "Cache:";
            // 
            // label_socket
            // 
            this.label_socket.AutoSize = true;
            this.label_socket.Location = new System.Drawing.Point(12, 145);
            this.label_socket.Name = "label_socket";
            this.label_socket.Size = new System.Drawing.Size(44, 13);
            this.label_socket.TabIndex = 5;
            this.label_socket.Text = "Socket:";
            // 
            // label_tpd
            // 
            this.label_tpd.AutoSize = true;
            this.label_tpd.Location = new System.Drawing.Point(12, 170);
            this.label_tpd.Name = "label_tpd";
            this.label_tpd.Size = new System.Drawing.Size(32, 13);
            this.label_tpd.TabIndex = 5;
            this.label_tpd.Text = "TPD:";
            // 
            // textBox_baseClock
            // 
            this.textBox_baseClock.Location = new System.Drawing.Point(80, 63);
            this.textBox_baseClock.MaxLength = 8;
            this.textBox_baseClock.Name = "textBox_baseClock";
            this.textBox_baseClock.Size = new System.Drawing.Size(65, 20);
            this.textBox_baseClock.TabIndex = 2;
            this.textBox_baseClock.Enter += new System.EventHandler(this.textBox_baseClock_Enter);
            // 
            // textBox_cache
            // 
            this.textBox_cache.Location = new System.Drawing.Point(80, 116);
            this.textBox_cache.MaxLength = 3;
            this.textBox_cache.Name = "textBox_cache";
            this.textBox_cache.Size = new System.Drawing.Size(65, 20);
            this.textBox_cache.TabIndex = 4;
            this.textBox_cache.Enter += new System.EventHandler(this.textBox_cache_Enter);
            // 
            // textBox_boostClock
            // 
            this.textBox_boostClock.Location = new System.Drawing.Point(80, 89);
            this.textBox_boostClock.MaxLength = 8;
            this.textBox_boostClock.Name = "textBox_boostClock";
            this.textBox_boostClock.Size = new System.Drawing.Size(65, 20);
            this.textBox_boostClock.TabIndex = 3;
            this.textBox_boostClock.Enter += new System.EventHandler(this.textBox_boostClock_Enter);
            // 
            // textBox_threads
            // 
            this.textBox_threads.Location = new System.Drawing.Point(80, 37);
            this.textBox_threads.MaxLength = 4;
            this.textBox_threads.Name = "textBox_threads";
            this.textBox_threads.Size = new System.Drawing.Size(65, 20);
            this.textBox_threads.TabIndex = 1;
            this.textBox_threads.Enter += new System.EventHandler(this.textBox_threads_Enter);
            // 
            // textBox_cores
            // 
            this.textBox_cores.Location = new System.Drawing.Point(80, 11);
            this.textBox_cores.MaxLength = 4;
            this.textBox_cores.Name = "textBox_cores";
            this.textBox_cores.Size = new System.Drawing.Size(65, 20);
            this.textBox_cores.TabIndex = 0;
            this.textBox_cores.Enter += new System.EventHandler(this.textBox_cores_Enter);
            // 
            // textBox_tpd
            // 
            this.textBox_tpd.Location = new System.Drawing.Point(80, 168);
            this.textBox_tpd.MaxLength = 4;
            this.textBox_tpd.Name = "textBox_tpd";
            this.textBox_tpd.Size = new System.Drawing.Size(65, 20);
            this.textBox_tpd.TabIndex = 6;
            this.textBox_tpd.Enter += new System.EventHandler(this.textBox_tpd_Enter);
            // 
            // AddCPU
            // 
            this.AcceptButton = this.button_add;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button_back;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.textBox_boostClock);
            this.Controls.Add(this.textBox_tpd);
            this.Controls.Add(this.textBox_cache);
            this.Controls.Add(this.textBox_cores);
            this.Controls.Add(this.textBox_threads);
            this.Controls.Add(this.textBox_baseClock);
            this.Controls.Add(this.label_tpd);
            this.Controls.Add(this.label_socket);
            this.Controls.Add(this.label_cache);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_baseClock);
            this.Controls.Add(this.label_threads);
            this.Controls.Add(this.label_cores);
            this.Controls.Add(this.label_watts);
            this.Controls.Add(this.comboBox_cach);
            this.Controls.Add(this.comboBox_boostClock);
            this.Controls.Add(this.comboBox_baseClock);
            this.Controls.Add(this.textBox_socket);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.button_add);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddCPU";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add CPU";
            this.Load += new System.EventHandler(this.AddCPU_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.TextBox textBox_socket;
        private System.Windows.Forms.ComboBox comboBox_baseClock;
        private System.Windows.Forms.ComboBox comboBox_boostClock;
        private System.Windows.Forms.ComboBox comboBox_cach;
        private System.Windows.Forms.Label label_watts;
        private System.Windows.Forms.Label label_cores;
        private System.Windows.Forms.Label label_threads;
        private System.Windows.Forms.Label label_baseClock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_cache;
        private System.Windows.Forms.Label label_socket;
        private System.Windows.Forms.Label label_tpd;
        private System.Windows.Forms.TextBox textBox_baseClock;
        private System.Windows.Forms.TextBox textBox_cache;
        private System.Windows.Forms.TextBox textBox_boostClock;
        private System.Windows.Forms.TextBox textBox_threads;
        private System.Windows.Forms.TextBox textBox_cores;
        private System.Windows.Forms.TextBox textBox_tpd;
    }
}