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
    public partial class InputListOfFilenamesForm : Form
    {
        private string[] filenames;

        public InputListOfFilenamesForm(string[] filenames)
        {
            this.filenames = filenames;
            InitializeComponent();
        }

        public string[] Filenames { get => filenames; set => filenames = value; }

        private void ListOfFilenames_Load(object sender, EventArgs e)
        {
            filenamesTextBox.Lines = filenames;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            filenames = filenamesTextBox.Lines;
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
