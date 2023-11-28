using System;
using System.Windows.Forms;

namespace DateFormatter
{
    public partial class AmbiguousDateForm : Form
    {
        private int index = -1;
        private string[] interpretations;
        private string originalDate;

        public AmbiguousDateForm(string[] interpretations, string originalDate)
        {
            this.interpretations = interpretations;
            this.originalDate = originalDate;
            InitializeComponent();
        }

        private void AmbiguousDateForm_Load(object sender, EventArgs e)
        {
            label_question.Text = "By \"" + originalDate + "\", do you mean: ";

            listBox_choices.Items.Clear();
            foreach (string interpretation in interpretations)
            {
                listBox_choices.Items.Add(interpretation);
            }
        }

        private void listBox_choices_SelectedIndexChanged(object sender, EventArgs e)
        {
            index = listBox_choices.SelectedIndex;
            Close();
        }

        public int Index
        {
            get
            {
                return index;
            }
        }
    }
}
