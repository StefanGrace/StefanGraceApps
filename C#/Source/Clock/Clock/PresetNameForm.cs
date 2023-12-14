using System;
using System.Windows.Forms;

namespace Clock
{
    public partial class PresetNameForm : Form
    {
        private string presetName = "";

        public string PresetName { get => presetName; set => presetName = value; }

        public PresetNameForm()
        {
            InitializeComponent();
        }

        private void PresetNameForm_Load(object sender, EventArgs e)
        {

        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            if (textBox_presetName.Text != "")
            {
                presetName = textBox_presetName.Text;
                Close();
            }
            else
            {
                MessageBox.Show("You must enter a name.");
            }
        }

        private void textBox_presetName_TextChanged(object sender, EventArgs e)
        {
            button_ok.Enabled = textBox_presetName.Text != "";
        }
    }
}
