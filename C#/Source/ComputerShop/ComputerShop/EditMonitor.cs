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
    public partial class EditMonitor : Form
    {
        private Monitor monitor;

        public EditMonitor(Monitor monitor)
        {
            this.monitor = monitor;
            InitializeComponent();
        }

        public Monitor Monitor { get => monitor; }

        private void EditMonitor_Load(object sender, EventArgs e)
        {
            textBox_productName.Text = monitor.Name;
            textBox_price.Text = monitor.Price.ToString("#,##0.00");
            checkBox_inStock.Checked = monitor.InStock;
            textBox_resolutionX.Text = monitor.Resolution.Width.ToString();
            textBox_resolutionY.Text = monitor.Resolution.Height.ToString();
            textBox_size.Text = monitor.DiagonalSizeInches.ToString();
            textBox_refreshRate.Text = monitor.RefreshRateHz.ToString();
            textBox_panelType.Text = monitor.PanelType;
            textBox_inputs.Lines = monitor.Inputs;
            textBox_usbHub.Text = monitor.UsbHub;
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            if (textBox_productName.Text == "")
            {
                MessageBox.Show("Product name cannot be blank.");
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

            if (textBox_resolutionX.Text == "" || textBox_resolutionY.Text == "")
            {
                MessageBox.Show("Please enter a resolution.");
                return;
            }

            uint resolutionX;
            uint resolutionY;

            try
            {
                resolutionX = uint.Parse(textBox_resolutionX.Text);
                resolutionY = uint.Parse(textBox_resolutionY.Text);
            }
            catch
            {
                MessageBox.Show("Resolution is not valid.");
                return;
            }
            if (resolutionX == 0 || resolutionY == 0)
            {
                MessageBox.Show("Resolution cannot be 0.");
                return;
            }

            double size;
            try
            {
                size = double.Parse(textBox_size.Text);
                if (size < 0)
                {
                    throw new Exception();
                }
            }
            catch
            {
                MessageBox.Show("Diagonal size must be a positive number.");
                return;
            }

            uint refreshRate;
            try
            {
                refreshRate = uint.Parse(textBox_refreshRate.Text);
            }
            catch
            {
                MessageBox.Show("Refresh rate must be a positive interger.");
                return;
            }

            monitor = new Monitor(textBox_productName.Text, price, checkBox_inStock.Checked, new Resolution(resolutionX, resolutionY),
                size, refreshRate, textBox_panelType.Text, textBox_inputs.Lines, textBox_usbHub.Text);

            Close();
        }
    }
}
