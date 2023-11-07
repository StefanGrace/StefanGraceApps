using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI_Calculator
{
    public partial class Form1 : Form
    {
        Calculator calc = new Calculator();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            weightUnitComboBox.Text = "kg";
            heightUnitComboBox.Text = "cm";
        }

        private void update()
        {
            outputLabel.Text = calc.calculateBMI(weightTextBox.Text, heightTextBox.Text, weightUnitComboBox.Text, heightUnitComboBox.Text);
        }

        private void weightTextBox_TextChanged(object sender, EventArgs e)
        {
            update();
        }

        private void heightTextBox_TextChanged(object sender, EventArgs e)
        {
            update();
        }

        private void weightUnitComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            update();
        }

        private void heightUnitComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            update();
        }
    }
}
