using System;
using System.Drawing;
using System.Windows.Forms;

// Originally written by Diana Adams in VisualBasic on 2017-02-13
// Re-written by Stefan Grace (OSFirstTimer NZ) in C# on 2018-10-30

namespace WageCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            double userwage;
            try
            {
                userwage = double.Parse(inputTextBox.Text.Trim("$".ToCharArray()));
            }
            catch
            {
                userwage = 0f;
            }
            inputTextBox.Text = "$" + Math.Round(userwage, 2);
            monthlyLabel.Text = "Monthly $" + Math.Round(userwage / 12, 2);
            weeklyLabel.Text = "Weekly $" + Math.Round(userwage / 52, 2);
            dailyLabel.Text = "Daily $" + Math.Round(userwage / 365, 2);
            if (userwage < 40000)
            {
                updateOutput(Color.Maroon, "Don't worry...there's more to life than just money!");
            }
            else if (userwage < 100000)
            {
                updateOutput(Color.Blue, "Keep up the good work!");
            }
            else
            {
                updateOutput(Color.Gold, "Donate to OSFirstTimer NOW!!!");
            }
        }

        private void updateOutput(Color color, string text)
        {
            monthlyLabel.ForeColor = color;
            weeklyLabel.ForeColor = color;
            dailyLabel.ForeColor = color;
            outputMessageLabel.Text = text;
            outputMessageLabel.Visible = true;
        }
    }
}
