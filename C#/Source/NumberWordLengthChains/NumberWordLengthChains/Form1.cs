using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberWordLengthChains
{
    public partial class Form1 : Form
    {
        ChainGenerator chainGenerator = new ChainGenerator();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_go_Click(object sender, EventArgs e)
        {
            if (textBox_input.Text == "")
            {
                MessageBox.Show("Please enter an input number.");
                return;
            }            
        }

        private void textBox_input_TextChanged(object sender, EventArgs e)
        {
            UpdateOutput();
        }

        private void UpdateOutput()
        {
            if (textBox_input.Text == "")
            {
                richTextBox_output.Clear();
                label_chainLength.Text = "Chain length:";
                return;
            }

            string[] chain = chainGenerator.GenerateChain(textBox_input.Text);
            richTextBox_output.Text = string.Join("\n", chain);
            label_chainLength.Text = "Chain length: " + chain.Length;
        }

        private void button_grammar_Click(object sender, EventArgs e)
        {
            GrammarForm gf = new GrammarForm(chainGenerator.Converter.LetterCasing, chainGenerator.Converter.IncludeAnd, chainGenerator.Converter.Commas, chainGenerator.Converter.ZeroBeforePoint, chainGenerator.Converter.NegativeMinus, chainGenerator.Converter.ShortHand);
            gf.ShowDialog();
            chainGenerator.Converter.SetVariables(gf.LetterCasing, gf.IncludeAnd, gf.Commas, gf.ZeroBeforePoint, gf.NegativeMinus, gf.ShortHand);
            UpdateOutput();
        }

        private void checkBox_excludeNonLetters_CheckedChanged(object sender, EventArgs e)
        {
            chainGenerator.ExcudeNonLetters = checkBox_excludeNonLetters.Checked;
            UpdateOutput();
        }
    }
}
