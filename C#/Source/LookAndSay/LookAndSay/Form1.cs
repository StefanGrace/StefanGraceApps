using System;
using System.Windows.Forms;

namespace LookAndSay
{
    public partial class Form1 : Form
    {
        SequenceGenerator sg = new SequenceGenerator();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            try
            {
                int iterations = int.Parse(IterationsTextBox.Text);
                OutputTextBox.Lines = sg.GenerateSequence(StartTextBox.Text, iterations);
            }
            catch (StartEmptyException)
            {
                OutputTextBox.Text = "Start can't be empty";
            }
            catch (IterationsNotPositiveException)
            {
                OutputTextBox.Text = "Iterations must be positive";
            }
            catch (FormatException)
            {
                OutputTextBox.Text = "Iterations must be a number.";
            }



        }
    }
}
