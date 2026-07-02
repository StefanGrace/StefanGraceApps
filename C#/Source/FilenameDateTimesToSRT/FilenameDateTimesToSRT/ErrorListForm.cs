using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilenameDateTimesToSRT
{
    public partial class ErrorListForm : Form
    {
        private List<Exception> errors;
        private List<string> filenames;

        public ErrorListForm(List<Exception> errors, List<string> filenames)
        {
            this.errors = errors;
            this.filenames = filenames;
            InitializeComponent();
        }

        public List<Exception> Errors { get => errors; set => errors = value; }

        private void ErrorListForm_Load(object sender, EventArgs e)
        {
            DisplayErrorMessages();
        }

        private void filenamesRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (filenamesRadioButton.Checked)
            {
                DisplayFilenames();
            }
        }

        private void DisplayErrorMessages()
        {
            List<string> errorStrings = new List<string>();
            int i = 0;
            foreach (Exception error in errors)
            {
                errorStrings.Add(filenames[i]);
                errorStrings.Add(error.Message);
                errorStrings.Add("");
                i++;
            }

            errorsTextBox.Lines = errorStrings.ToArray();
        }

        private void DisplayFilenames()
        {
            errorsTextBox.Lines = filenames.ToArray();
        }

        private void exceptionsRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (exceptionsRadioButton.Checked)
            {
                DisplayErrorMessages();
            }
        }
    }
}
