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
    public partial class AddMonitor : Form
    {
        Monitor monitor = null;

        private string name;
        private decimal price;
        private bool inStock;

        public AddMonitor(string name, decimal price, bool inStock)
        {
            this.name = name;
            this.price = price;
            this.inStock = inStock;

            InitializeComponent();
        }

        internal Monitor Monitor { get => monitor; }

        private void AddMonitor_Load(object sender, EventArgs e)
        {
            
        }

        private void button_add_Click(object sender, EventArgs e)
        {
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

            monitor = new Monitor(name, price, inStock, new Resolution(resolutionX, resolutionY), size, refreshRate, textBox_panelType.Text, textBox_inputs.Lines, textBox_usbHub.Text);

            Close();
        }

        private void textBox_resolutionX_Enter(object sender, EventArgs e)
        {
            textBox_resolutionX.SelectAll();
        }

        private void textBox_resolutionY_Enter(object sender, EventArgs e)
        {
            textBox_resolutionY.SelectAll();
        }

        private void textBox_size_Enter(object sender, EventArgs e)
        {
            textBox_size.SelectAll();
        }

        private void textBox_refreshRate_Enter(object sender, EventArgs e)
        {
            textBox_refreshRate.SelectAll();
        }

        private void textBox_panelType_Enter(object sender, EventArgs e)
        {
            textBox_panelType.SelectAll();
        }

        private void textBox_usbHub_Enter(object sender, EventArgs e)
        {
            textBox_usbHub.SelectAll();
        }
    }
}
