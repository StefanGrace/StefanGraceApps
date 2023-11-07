using System;
using System.Windows.Forms;

// Stefan Grace
// Uno
// NameInputForm.cs

namespace Uno
{
    public partial class NameInputForm : Form
    {
        private string userName;

        public NameInputForm()
        {
            InitializeComponent();
        }

        private void NameInputForm_Load(object sender, EventArgs e)
        {

        }

        public string getUserName()
        {
            return userName;
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text.Length > 20)
            {
                MessageBox.Show("Name is too long");
            }
            else if (nameTextBox.Text.Length > 0)
            {
                userName = nameTextBox.Text;
                Close();
            }
            else
            {
                MessageBox.Show("You must enter a name");
            }
        }
    }
}
