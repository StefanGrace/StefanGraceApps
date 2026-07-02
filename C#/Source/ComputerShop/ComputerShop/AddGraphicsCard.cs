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
    public partial class AddGraphicsCard : Form
    {
        private GraphicsCard gpu = null;

        private string name;
        private decimal price;
        private bool inStock;

        public AddGraphicsCard(string name, decimal price, bool inStock)
        {
            this.name = name;
            this.price = price;
            this.inStock = inStock;

            InitializeComponent();
        }

        internal GraphicsCard GPU { get => gpu; }

        private void AddGraphicsCard_Load(object sender, EventArgs e)
        {
            comboBox_vram.SelectedIndex = 1;
        }

        private void button_add_Click(object sender, EventArgs e)
        {
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

            gpu = new GraphicsCard(name, price, inStock, vramBytes);

            Close();
        }

        private void textBox_vram_Enter(object sender, EventArgs e)
        {
            textBox_vram.SelectAll();
        }
    }
}
