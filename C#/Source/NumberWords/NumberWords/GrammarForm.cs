// GrammarForm.cs
// Stefan Grace
// Created: 2022-12-18
// Modified: 2022-12-20

using System;
using System.Windows.Forms;

namespace NumberWords
{
    public partial class GrammarForm : Form
    {
        private int letterCasing;
        private bool includeAnd;
        private bool commas;
        private bool zeroBeforePoint;
        private bool negativeMinus;
        private bool shortHand;

        public GrammarForm(int letterCasing, bool includeAnd, bool commas, bool zeroBeforePoint, bool negativeMinus, bool shortHand)
        {
            this.letterCasing = letterCasing;
            this.includeAnd = includeAnd;
            this.commas = commas;
            this.zeroBeforePoint = zeroBeforePoint;
            this.negativeMinus = negativeMinus;
            this.shortHand = shortHand;
            InitializeComponent();
        }

        private void GrammerForm_Load(object sender, EventArgs e)
        {
            LetterCasingComboBox.SelectedIndex = letterCasing;
            IncludeAndCheckBox.Checked = includeAnd;
            CommansCheckBox.Checked = commas;
            ZeroBeforePointCheckBox.Checked = zeroBeforePoint;
            NegitiaveMinusCheckBox.Checked = negativeMinus;
            ShortHandCheckBox.Checked = shortHand;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            letterCasing = LetterCasingComboBox.SelectedIndex;
            includeAnd = IncludeAndCheckBox.Checked;
            commas = CommansCheckBox.Checked;
            zeroBeforePoint = ZeroBeforePointCheckBox.Checked;
            negativeMinus = NegitiaveMinusCheckBox.Checked;
            shortHand = ShortHandCheckBox.Checked;
            Close();
        }

        public int LetterCasing
        {
            get
            {
                return letterCasing;
            }
        }

        public bool IncludeAnd
        {
            get
            {
                return includeAnd;
            }
        }

        public bool Commas
        {
            get
            {
                return commas;
            }
        }

        public bool ZeroBeforePoint
        {
            get
            {
                return zeroBeforePoint;
            }
        }

        public bool NegativeMinus
        {
            get
            {
                return negativeMinus;
            }
        }

        public bool ShortHand
        {
            get
            {
                return shortHand;
            }
        }
    }
}
