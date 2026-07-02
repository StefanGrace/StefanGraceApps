using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerShop
{
    public partial class Form1 : Form
    {
        Store store;

        public Form1()
        {
            store = new Store();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox_product.SelectedIndex = 0;
        }

        private void comboBox_product_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateSortingOptions();
        }

        private void UpdateSortingOptions()
        {
            int sortBy = comboBox_sort.SelectedIndex;
            comboBox_sort.Items.Clear();
            comboBox_sort.Items.Add("Date added");
            switch (comboBox_product.SelectedIndex)
            {
                case 0: // All
                    comboBox_sort.Items.AddRange(Product.SortingOptions);
                    break;
                case 1: // CPUs
                    comboBox_sort.Items.AddRange(CPU.SortingOptions);
                    break;
                case 2: // Graphics cards
                    comboBox_sort.Items.AddRange(GraphicsCard.SortingOptions);
                    break;
                case 3: // Hard drives
                    comboBox_sort.Items.AddRange(HardDrive.SortingOptions);
                    break;
                case 4: // Monitors
                    comboBox_sort.Items.AddRange(Monitor.SortingOptions);
                    break;

            }
            if (sortBy == 1 || sortBy == 2)
            {
                comboBox_sort.SelectedIndex = sortBy;
            }
            else
            {
                comboBox_sort.SelectedIndex = 0;
            }
            store.ProductFilter = comboBox_product.SelectedIndex;
            UpdateHTML();
        }

        private void UpdateHTML()
        {
            string css = "<head><style>body {font-family: \"Arial\", sans-serif;} table {width: 100%; border-collapse: collapse; } " +
               ".name {font-weight: bold; width: 25%;} .price {width: 25%; text-align: right; padding-right: 20px} .info {width: 50%} " +
               ".odd {background-color: #EAEAEA;} .even {background-color: #E0E0E06;}</style></head>";

            webBrowser1.DocumentText = css + store.GetHTML(comboBox_sort.SelectedItem.ToString(), radioButton_descending.Checked);
        }

        private void comboBox_sort_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateHTML();
        }

        private void button_removeProduct_Click(object sender, EventArgs e)
        {
            SelectProduct productSelect = new SelectProduct(store.GetProductNames(), "remove");
            productSelect.ShowDialog();
            if (productSelect.SelectedIndex != -1)
            {
                store.RemoveProduct(productSelect.SelectedIndex);
                UpdateHTML();
            }
        }

        private void button_addProduct_Click(object sender, EventArgs e)
        {
            AddProduct productAdd = new AddProduct(store.GetProductNames());
            productAdd.ShowDialog();
            if (productAdd.Product != null)
            {
                store.AddProduct(productAdd.Product);
                UpdateHTML();
            }
        }

        private void button_editProduct_Click(object sender, EventArgs e)
        {
            SelectProduct productSelect = new SelectProduct(store.GetProductNames(), "edit");
            productSelect.ShowDialog();
            Product selectedProduct = store.GetProducts()[productSelect.SelectedIndex];
            switch (selectedProduct.GetType().Name)
            {
                case "CPU":
                    EditCPU cpuEdit = new EditCPU((CPU)selectedProduct);
                    cpuEdit.ShowDialog();
                    store.GetProducts()[productSelect.SelectedIndex] = cpuEdit.CPU;
                    break;

                case "GraphicsCard":
                    EditGraphicsCard gpuEdit = new EditGraphicsCard((GraphicsCard)selectedProduct);
                    gpuEdit.ShowDialog();
                    store.GetProducts()[productSelect.SelectedIndex] = gpuEdit.GraphicsCard;
                    break;

                case "HardDrive":
                    EditHardDrive hddEdit = new EditHardDrive((HardDrive)selectedProduct);
                    hddEdit.ShowDialog();
                    store.GetProducts()[productSelect.SelectedIndex] = hddEdit.HardDrive;
                    break;

                case "Monitor":
                    EditMonitor monitorEdit = new EditMonitor((Monitor)selectedProduct);
                    monitorEdit.ShowDialog();
                    store.GetProducts()[productSelect.SelectedIndex] = monitorEdit.Monitor;
                    break;
            }
            UpdateHTML();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            UpdateHTML();
        }

        private void radioButton_descending_CheckedChanged(object sender, EventArgs e)
        {
            UpdateHTML();
        }

        private void textBox_filter_TextChanged(object sender, EventArgs e)
        {
            store.NameFilter = textBox_filter.Text;
            button_clearFilter.Enabled = textBox_filter.Text != ""; // Disable the Clear button if the textbox is empty
            UpdateHTML();
        }

        private void button_clearFilter_Click(object sender, EventArgs e)
        {
            textBox_filter.Clear();
        }

        private void checkBox_inStock_CheckedChanged(object sender, EventArgs e)
        {
            store.InStockFilter = checkBox_inStock.Checked;
            UpdateHTML();
        }
    }
}
