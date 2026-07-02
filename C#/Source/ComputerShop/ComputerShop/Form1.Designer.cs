namespace ComputerShop
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
            this.comboBox_product = new System.Windows.Forms.ComboBox();
            this.comboBox_sort = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_sortBy = new System.Windows.Forms.Label();
            this.radioButton_ascening = new System.Windows.Forms.RadioButton();
            this.radioButton_descending = new System.Windows.Forms.RadioButton();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.button_addProduct = new System.Windows.Forms.Button();
            this.button_removeProduct = new System.Windows.Forms.Button();
            this.button_editProduct = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBox_filter = new System.Windows.Forms.TextBox();
            this.label_filter = new System.Windows.Forms.Label();
            this.checkBox_inStock = new System.Windows.Forms.CheckBox();
            this.button_clearFilter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox_product
            // 
            this.comboBox_product.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_product.FormattingEnabled = true;
            this.comboBox_product.Items.AddRange(new object[] {
            "All",
            "CPUs",
            "Graphics cards",
            "Hard dirves",
            "Monitors"});
            this.comboBox_product.Location = new System.Drawing.Point(73, 12);
            this.comboBox_product.Name = "comboBox_product";
            this.comboBox_product.Size = new System.Drawing.Size(121, 21);
            this.comboBox_product.TabIndex = 0;
            this.comboBox_product.SelectedIndexChanged += new System.EventHandler(this.comboBox_product_SelectedIndexChanged);
            // 
            // comboBox_sort
            // 
            this.comboBox_sort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_sort.FormattingEnabled = true;
            this.comboBox_sort.Location = new System.Drawing.Point(255, 12);
            this.comboBox_sort.Name = "comboBox_sort";
            this.comboBox_sort.Size = new System.Drawing.Size(121, 21);
            this.comboBox_sort.TabIndex = 1;
            this.comboBox_sort.SelectedIndexChanged += new System.EventHandler(this.comboBox_sort_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Shop for:";
            // 
            // label_sortBy
            // 
            this.label_sortBy.AutoSize = true;
            this.label_sortBy.Location = new System.Drawing.Point(206, 15);
            this.label_sortBy.Name = "label_sortBy";
            this.label_sortBy.Size = new System.Drawing.Size(43, 13);
            this.label_sortBy.TabIndex = 1;
            this.label_sortBy.Text = "Sort by:";
            // 
            // radioButton_ascening
            // 
            this.radioButton_ascening.AutoSize = true;
            this.radioButton_ascening.Checked = true;
            this.radioButton_ascening.Location = new System.Drawing.Point(383, 15);
            this.radioButton_ascening.Name = "radioButton_ascening";
            this.radioButton_ascening.Size = new System.Drawing.Size(78, 17);
            this.radioButton_ascening.TabIndex = 2;
            this.radioButton_ascening.TabStop = true;
            this.radioButton_ascening.Text = "Ascending ";
            this.radioButton_ascening.UseVisualStyleBackColor = true;
            // 
            // radioButton_descending
            // 
            this.radioButton_descending.AutoSize = true;
            this.radioButton_descending.Location = new System.Drawing.Point(457, 15);
            this.radioButton_descending.Name = "radioButton_descending";
            this.radioButton_descending.Size = new System.Drawing.Size(85, 17);
            this.radioButton_descending.TabIndex = 3;
            this.radioButton_descending.TabStop = true;
            this.radioButton_descending.Text = "Descending ";
            this.radioButton_descending.UseVisualStyleBackColor = true;
            this.radioButton_descending.CheckedChanged += new System.EventHandler(this.radioButton_descending_CheckedChanged);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser1.Location = new System.Drawing.Point(20, 66);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(520, 414);
            this.webBrowser1.TabIndex = 3;
            // 
            // button_addProduct
            // 
            this.button_addProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_addProduct.Location = new System.Drawing.Point(20, 489);
            this.button_addProduct.Name = "button_addProduct";
            this.button_addProduct.Size = new System.Drawing.Size(115, 23);
            this.button_addProduct.TabIndex = 7;
            this.button_addProduct.Text = "Add product...";
            this.button_addProduct.UseVisualStyleBackColor = true;
            this.button_addProduct.Click += new System.EventHandler(this.button_addProduct_Click);
            // 
            // button_removeProduct
            // 
            this.button_removeProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_removeProduct.Location = new System.Drawing.Point(141, 489);
            this.button_removeProduct.Name = "button_removeProduct";
            this.button_removeProduct.Size = new System.Drawing.Size(115, 23);
            this.button_removeProduct.TabIndex = 8;
            this.button_removeProduct.Text = "Remove product...";
            this.button_removeProduct.UseVisualStyleBackColor = true;
            this.button_removeProduct.Click += new System.EventHandler(this.button_removeProduct_Click);
            // 
            // button_editProduct
            // 
            this.button_editProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_editProduct.Location = new System.Drawing.Point(261, 489);
            this.button_editProduct.Name = "button_editProduct";
            this.button_editProduct.Size = new System.Drawing.Size(115, 23);
            this.button_editProduct.TabIndex = 9;
            this.button_editProduct.Text = "Edit product...";
            this.button_editProduct.UseVisualStyleBackColor = true;
            this.button_editProduct.Click += new System.EventHandler(this.button_editProduct_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // textBox_filter
            // 
            this.textBox_filter.Location = new System.Drawing.Point(73, 40);
            this.textBox_filter.Name = "textBox_filter";
            this.textBox_filter.Size = new System.Drawing.Size(141, 20);
            this.textBox_filter.TabIndex = 4;
            this.textBox_filter.TextChanged += new System.EventHandler(this.textBox_filter_TextChanged);
            // 
            // label_filter
            // 
            this.label_filter.AutoSize = true;
            this.label_filter.Location = new System.Drawing.Point(17, 43);
            this.label_filter.Name = "label_filter";
            this.label_filter.Size = new System.Drawing.Size(32, 13);
            this.label_filter.TabIndex = 1;
            this.label_filter.Text = "Filter:";
            // 
            // checkBox_inStock
            // 
            this.checkBox_inStock.AutoSize = true;
            this.checkBox_inStock.Location = new System.Drawing.Point(280, 43);
            this.checkBox_inStock.Name = "checkBox_inStock";
            this.checkBox_inStock.Size = new System.Drawing.Size(181, 17);
            this.checkBox_inStock.TabIndex = 6;
            this.checkBox_inStock.Text = "Only show items that are in-stock";
            this.checkBox_inStock.UseVisualStyleBackColor = true;
            this.checkBox_inStock.CheckedChanged += new System.EventHandler(this.checkBox_inStock_CheckedChanged);
            // 
            // button_clearFilter
            // 
            this.button_clearFilter.Enabled = false;
            this.button_clearFilter.Location = new System.Drawing.Point(220, 38);
            this.button_clearFilter.Name = "button_clearFilter";
            this.button_clearFilter.Size = new System.Drawing.Size(47, 23);
            this.button_clearFilter.TabIndex = 5;
            this.button_clearFilter.Text = "Clear";
            this.button_clearFilter.UseVisualStyleBackColor = true;
            this.button_clearFilter.Click += new System.EventHandler(this.button_clearFilter_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 521);
            this.Controls.Add(this.button_clearFilter);
            this.Controls.Add(this.checkBox_inStock);
            this.Controls.Add(this.textBox_filter);
            this.Controls.Add(this.button_editProduct);
            this.Controls.Add(this.button_removeProduct);
            this.Controls.Add(this.button_addProduct);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.radioButton_descending);
            this.Controls.Add(this.radioButton_ascening);
            this.Controls.Add(this.label_sortBy);
            this.Controls.Add(this.label_filter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_sort);
            this.Controls.Add(this.comboBox_product);
            this.MinimumSize = new System.Drawing.Size(576, 560);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stefan\'s Computer Shop";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_product;
        private System.Windows.Forms.ComboBox comboBox_sort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_sortBy;
        private System.Windows.Forms.RadioButton radioButton_ascening;
        private System.Windows.Forms.RadioButton radioButton_descending;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button button_addProduct;
        private System.Windows.Forms.Button button_removeProduct;
        private System.Windows.Forms.Button button_editProduct;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBox_filter;
        private System.Windows.Forms.Label label_filter;
        private System.Windows.Forms.CheckBox checkBox_inStock;
        private System.Windows.Forms.Button button_clearFilter;
    }
}

