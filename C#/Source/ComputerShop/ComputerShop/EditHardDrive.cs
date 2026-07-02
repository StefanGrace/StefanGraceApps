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
    public partial class EditHardDrive : Form
    {
        private HardDrive hdd;

        public EditHardDrive(HardDrive hdd)
        {
            this.hdd = hdd;
            InitializeComponent();
        }

        public HardDrive HardDrive { get => hdd; }

        private void EditHardDrive_Load(object sender, EventArgs e)
        {
            textBox_productName.Text = hdd.Name;
            textBox_price.Text = hdd.Price.ToString("#,##0.00");
            checkBox_inStock.Checked = hdd.InStock;
            if (hdd.CapasityBytes < 1_000_000_000) // MB
            {
                comboBox_capasity.SelectedIndex = 0;
                textBox_capasity.Text = ((double)hdd.CapasityBytes / 1_000_000).ToString();
            }
            else if (hdd.CapasityBytes < 1_000_000_000_000) // GB
            {
                comboBox_capasity.SelectedIndex = 1;
                textBox_capasity.Text = ((double)hdd.CapasityBytes / 1_000_000_000).ToString();
            }
            else if (hdd.CapasityBytes < 1_000_000_000_000_000) // TB
            {
                comboBox_capasity.SelectedIndex = 2;
                textBox_capasity.Text = ((double)hdd.CapasityBytes / 1_000_000_000_000).ToString();
            }
            else // PB
            {
                comboBox_capasity.SelectedIndex = 3;
                textBox_capasity.Text = ((double)hdd.CapasityBytes / 1_000_000_000_000_000).ToString();
            }
            comboBox_formFactor.Text = hdd.FormFactor;
            comboBox_connector.Text = hdd.Connector;
            textBox_rpm.Text = hdd.RotaitionalSpeedRPM.ToString();
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

            double capasity;
            try
            {
                capasity = double.Parse(textBox_capasity.Text);
                if (capasity >= 10_000 || capasity < 0)
                {
                    throw new Exception();
                }
            }
            catch
            {
                MessageBox.Show("Capasity must be a positive number.");
                return;
            }

            ushort rpm;
            try
            {
                rpm = ushort.Parse(textBox_rpm.Text);
            }
            catch
            {
                MessageBox.Show("RMP must be a non-negative number less than 65,536.");
                return;
            }

            ulong capasityBytes;
            switch (comboBox_capasity.SelectedIndex)
            {
                case 0: capasityBytes = (ulong)Math.Round(capasity * 1_000_000); break;
                case 1: capasityBytes = (ulong)Math.Round(capasity * 1_000_000_000); break;
                case 2: capasityBytes = (ulong)Math.Round(capasity * 1_000_000_000_000); break;
                case 3: capasityBytes = (ulong)Math.Round(capasity * 1_000_000_000_000_000); break;
                default: capasityBytes = (ulong)Math.Round(capasity); break;
            }

            hdd = new HardDrive(textBox_productName.Text, price, checkBox_inStock.Checked, capasityBytes, comboBox_formFactor.Text, comboBox_connector.Text, rpm);

            Close();
        }
    }
}
