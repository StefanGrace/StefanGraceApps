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
    public partial class AddHardDrive : Form
    {
        HardDrive hdd = null;

        private string name;
        private decimal price;
        private bool inStock;

        public AddHardDrive(string name, decimal price, bool inStock)
        {
            this.name = name;
            this.price = price;
            this.inStock = inStock;

            InitializeComponent();
        }

        internal HardDrive HDD { get => hdd; }

        private void AddHardDrive_Load(object sender, EventArgs e)
        {
            comboBox_capasity.SelectedIndex = 2;
        }

        private void button_add_Click(object sender, EventArgs e)
        {
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

            hdd = new HardDrive(name, price, inStock, capasityBytes, comboBox_formFactor.Text,
                comboBox_connector.Text, rpm);

            Close();
        }

        private void textBox_capasity_Enter(object sender, EventArgs e)
        {
            textBox_capasity.SelectAll();
        }

        private void textBox_rpm_Enter(object sender, EventArgs e)
        {
            textBox_rpm.SelectAll();
        }
    }
}
