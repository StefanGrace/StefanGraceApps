using System;
using System.Windows.Forms;

namespace Clock
{
    public partial class CustomWeekdayNamesForm : Form
    {
        string[] customWeekdays;

        public string[] CustomWeekdays { get => customWeekdays; }

        public CustomWeekdayNamesForm(string[] customWeekdays)
        {
            this.customWeekdays = customWeekdays;
            InitializeComponent();
        }

        private void CustomWeekdayNamesForm_Load(object sender, EventArgs e)
        {
            // Put the existing custom weekday names (if any) into the text boxes
            textBox_monday.Text = customWeekdays[0];
            textBox_tuesday.Text = customWeekdays[1];
            textBox_wednesday.Text = customWeekdays[2];
            textBox_thursday.Text = customWeekdays[3];
            textBox_friday.Text = customWeekdays[4];
            textBox_saturday.Text = customWeekdays[5];
            textBox_sunday.Text = customWeekdays[6];
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            string[] enteredWeekdays = new string[7];
            enteredWeekdays[0] = textBox_monday.Text;
            enteredWeekdays[1] = textBox_tuesday.Text;
            enteredWeekdays[2] = textBox_wednesday.Text;
            enteredWeekdays[3] = textBox_thursday.Text;
            enteredWeekdays[4] = textBox_friday.Text;
            enteredWeekdays[5] = textBox_saturday.Text;
            enteredWeekdays[6] = textBox_sunday.Text;

            foreach (string weekday in enteredWeekdays)
            {
                if (weekday == "")
                {
                    MessageBox.Show("Enter a custom weekday name into each box.");
                    return;
                }
            }

            customWeekdays = enteredWeekdays;

            Close();
        }
    }
}