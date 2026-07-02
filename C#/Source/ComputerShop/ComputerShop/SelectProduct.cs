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
    public partial class SelectProduct : Form
    {
        private string[] productNames;
        private string action;
        private int selectedIndex = -1;

        public int SelectedIndex { get => selectedIndex; }

        public SelectProduct(string[] productNames, string action)
        {
            this.productNames = productNames;
            this.action = action;
            InitializeComponent();
        }

        private void SelectProduct_Load(object sender, EventArgs e)
        {
            label_selectProdutTo.Text = "Select product to " + action + ":";
            for (int i = 0; i < productNames.Length; i++)
            {
                if (productNames[i] != null)
                {
                    listBox_products.Items.Add(productNames[i]);
                }
            }
            
        }

        private void listBox_products_SelectedIndexChanged(object sender, EventArgs e)
        {
            button_ok.Enabled = true;
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            selectedIndex = listBox_products.SelectedIndex;
            Close();
        }
    }
}
