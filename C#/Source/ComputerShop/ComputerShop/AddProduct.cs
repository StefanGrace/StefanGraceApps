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
    public partial class AddProduct : Form
    {
        private Product product = null;
        private string[] existingProductNames;

        public AddProduct(string[] productNames)
        {
            existingProductNames = productNames;
            InitializeComponent();
        }

        internal Product Product { get => product; }

        private void button_next_Click(object sender, EventArgs e)
        {
            textBox_productName.Text = textBox_productName.Text.Trim();

            if (textBox_productName.Text == "")
            {
                MessageBox.Show("Please enter a product name.");
                return;
            }

            foreach (string productName in existingProductNames)
            {
                if (textBox_productName.Text == productName)
                {
                    MessageBox.Show("A product with the name \"" + textBox_productName.Text + "\" already exists.", "Duplicate Product Name");
                    return;
                }
            }

            if (textBox_price.Text == "")
            {
                MessageBox.Show("Please enter a price.");
                return;
            }

            decimal price;

            try
            {
                price = decimal.Parse(textBox_price.Text.Replace("$", ""));
            }
            catch
            {
                MessageBox.Show("Price is not valid.");
                return;
            }

            if (price < 0)
            {
                MessageBox.Show("Price can't be negative.");
                return;
            }

            if (radioButton_CPU.Checked)
            {
                AddCPU cpuForm = new AddCPU(textBox_productName.Text, price, checkBox_inStock.Checked);
                cpuForm.ShowDialog();
                if (cpuForm.CPU != null)
                {
                    product = cpuForm.CPU;
                    Close();
                }
            }
            else if (radioButton_graphicsCard.Checked)
            {
                AddGraphicsCard gpuForm = new AddGraphicsCard(textBox_productName.Text, price, checkBox_inStock.Checked);
                gpuForm.ShowDialog();
                if (gpuForm.GPU != null)
                {
                    product = gpuForm.GPU;
                    Close();
                }
            }
            else if (radioButton_hardDrive.Checked)
            {
                AddHardDrive hddForm = new AddHardDrive(textBox_productName.Text, price, checkBox_inStock.Checked);
                hddForm.ShowDialog();
                if (hddForm.HDD != null)
                {
                    product = hddForm.HDD;
                    Close();
                }
            }
            else if (radioButton_monitor.Checked)
            {
                AddMonitor monitorForm = new AddMonitor(textBox_productName.Text, price, checkBox_inStock.Checked);
                monitorForm.ShowDialog();
                if (monitorForm.Monitor != null)
                {
                    product = monitorForm.Monitor;
                    Close();
                }
            }
        }
    }
}
