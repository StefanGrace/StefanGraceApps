using System;
using System.Windows.Forms;

namespace Clock
{
    public partial class CustomMonthNamesForm : Form
    {
        string[] customMonths;

        public string[] CustomMonths { get => customMonths; }

        public CustomMonthNamesForm(string[] customMonths)
        {
            this.customMonths = customMonths;
            InitializeComponent();
        }

        private void CustomMonthNamesForm_Load(object sender, EventArgs e)
        {
            // Put the existing custom month names (if any) into the text boxes
            textBox_month1.Text = customMonths[0];
            textBox_month2.Text = customMonths[1];
            textBox_month3.Text = customMonths[2];
            textBox_month4.Text = customMonths[3];
            textBox_month5.Text = customMonths[4];
            textBox_month6.Text = customMonths[5];
            textBox_month7.Text = customMonths[6];
            textBox_month8.Text = customMonths[7];
            textBox_month9.Text = customMonths[8];
            textBox_month10.Text = customMonths[9];
            textBox_month11.Text = customMonths[10];
            textBox_month12.Text = customMonths[11];
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            string[] enteredMonths = new string[12];
            enteredMonths[0] = textBox_month1.Text;
            enteredMonths[1] = textBox_month2.Text;
            enteredMonths[2] = textBox_month3.Text;
            enteredMonths[3] = textBox_month4.Text;
            enteredMonths[4] = textBox_month5.Text;
            enteredMonths[5] = textBox_month6.Text;
            enteredMonths[6] = textBox_month7.Text;
            enteredMonths[7] = textBox_month8.Text;
            enteredMonths[8] = textBox_month9.Text;
            enteredMonths[9] = textBox_month10.Text;
            enteredMonths[10] = textBox_month11.Text;
            enteredMonths[11] = textBox_month12.Text;
            
            foreach(string month in enteredMonths)
            {
                if (month == "")
                {
                    MessageBox.Show("Enter a custom month name into each box.");
                    return;
                }
            }

            customMonths = enteredMonths;

            Close();
        }
    }
}
