using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordToNumber
{
    public partial class Form1 : Form
    {
        private Converter converter = new Converter();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void inputTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateOutput();
        }

        private void digitGroupingCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            UpdateOutput();
        }

        private void UpdateOutput()
        {
            if (inputTextBox.Text.Length > 0)
            {
                string outputFormat = "#,##0.############################";
                if (!digitGroupingCheckBox.Checked)
                {
                    outputFormat = outputFormat.Replace(",", "");
                }

                try
                {
                    
                    outputTextBox.Text = converter.WordToNumber(inputTextBox.Text).ToString(outputFormat);
                }
                catch (InvalidInputException)
                {
                    outputTextBox.Text = "Invalid input";
                }
                catch(OverflowException)
                {
                    outputTextBox.Text = "Max number is " + decimal.MaxValue.ToString(outputFormat);
                }
            }
            else
            {
                outputTextBox.Text = "";
            }
        }
    }
}
