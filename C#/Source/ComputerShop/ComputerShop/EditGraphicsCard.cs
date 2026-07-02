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
    public partial class EditGraphicsCard : Form
    {
        private GraphicsCard gpu;

        public EditGraphicsCard(GraphicsCard gpu)
        {
            this.gpu = gpu;
            InitializeComponent();
        }

        public GraphicsCard GraphicsCard { get => gpu; }

        private void EditGraphicsCard_Load(object sender, EventArgs e)
        {
            textBox_productName.Text = gpu.Name;
            textBox_price.Text = gpu.Price.ToString("#,##0.00");
            checkBox_inStock.Checked = gpu.InStock;
            if (gpu.VRamBytes < 1_000_000_000)
            {
                comboBox_vram.SelectedIndex = 0;
                textBox_vram.Text = ((double)gpu.VRamBytes / 1_000_000).ToString();
            }
            else
            {
                comboBox_vram.SelectedIndex = 1;
                textBox_vram.Text = ((double)gpu.VRamBytes / 1_000_000_000).ToString();
            }
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

            double vram;
            try
            {
                vram = double.Parse(textBox_vram.Text);
                if (vram >= 10_000 || vram < 0)
                {
                    throw new Exception();
                }
            }
            catch
            {
                MessageBox.Show("VRAM bust be a positive number");
                return;
            }

            ulong vramBytes;
            switch (comboBox_vram.SelectedIndex)
            {
                case 0: vramBytes = (ulong)Math.Round(vram * 1_000_000); break;
                case 1: vramBytes = (ulong)Math.Round(vram * 1_000_000_000); break;
                default: vramBytes = (ulong)Math.Round(vram); break;
            }

            gpu = new GraphicsCard(textBox_productName.Text, price, checkBox_inStock.Checked, vramBytes);

            Close();
        }
    }
}
