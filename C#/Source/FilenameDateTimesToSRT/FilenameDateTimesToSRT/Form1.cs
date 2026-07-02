using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FilenameDateTimesToSRT
{
    public partial class Form1 : Form
    {
        private string[] args;
        private List<Exception> exceptions = new List<Exception>();
        private List<string> filenameExceptions = new List<string>();
        private string[] inputList = new string[0];

        public Form1(string[] args)
        {
            this.args = args;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (args.Length > 0)
            {
                inputFileTextBox.Text = args[0];
            }
        }

        private void ChangeSource()
        {
            inputFileTextBox.Enabled = inputFileRadioButton.Checked;
            inputSingleTextBox.Enabled = inputSingleRadioButton.Checked;
            editListButton.Enabled = inputListRadioButton.Checked;
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            exceptions.Clear();

            string[] filenames;

            if (inputFileRadioButton.Checked)
            {
                string path = inputFileTextBox.Text.Replace("\"", "");
                if (path == "")
                {
                    MessageBox.Show("Please enter filepath of TXT file contaning filenames.");
                    return;
                }
                try
                {
                    filenames = File.ReadAllLines(path);
                }
                catch
                {
                    MessageBox.Show("Cannot open \"" + path + "\"");
                    return;
                }
            }

            else if (inputSingleRadioButton.Checked)
            {
                if (inputSingleTextBox.Text == "")
                {
                    MessageBox.Show("Please enter signle filename.");
                    return;
                }
                filenames = new string[] { inputSingleTextBox.Text };
            }

            else
            {
                if (inputList.Length == 0)
                {
                    MessageBox.Show("Input list is empty.");
                    return;
                }
                filenames = inputList;
            }

            TimeSpan duration = new TimeSpan((int)hoursNumericUpDown.Value, (int)minutesNumericUpDown.Value, (int)secondsNumericUpDown.Value);

            foreach (string filename in filenames)
            {
                try
                {
                    SRTCreator.CreateSRTFromFilename(filename, duration);
                }
                catch (Exception ex)
                {
                    exceptions.Add(ex);
                    filenameExceptions.Add(filename);
                }
            }

            errorsLabel.Text = exceptions.Count + (exceptions.Count == 1 ? " error" : " errors");

        }

        private void inputFileRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            ChangeSource();
        }

        private void inputSingleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            ChangeSource();
        }

        private void inputListRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            ChangeSource();
            if (inputListRadioButton.Checked && inputList.Length == 0)
            {
                ShowInputListForm();
            }
        }

        private void ShowInputListForm()
        {
            InputListOfFilenamesForm inputListForm = new InputListOfFilenamesForm(inputList);
            inputListForm.ShowDialog();
            inputList = inputListForm.Filenames;
        }

        private void editListButton_Click(object sender, EventArgs e)
        {
            ShowInputListForm();
        }

        private void viewErrorsButton_Click(object sender, EventArgs e)
        {
            ErrorListForm errorListForm = new ErrorListForm(exceptions, filenameExceptions);
            errorListForm.ShowDialog();
        }
    }
}
