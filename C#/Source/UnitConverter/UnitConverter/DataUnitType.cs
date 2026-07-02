using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnitConverter
{
    class DataUnitType
    {
        private TextBox inputTextBox;
        private TextBox outputTextBox;
        private ComboBox inputPrefixComboBox;
        private ComboBox outputPrefixComboBox;
        private Label outputLabel;
        private string unit;

        public DataUnitType(TextBox inputTextBox, TextBox outputTextBox, ComboBox inputPrefixComboBox, ComboBox outputPrefixComboBox, 
            Label outputLabel, string unit)
        {
            this.inputTextBox = inputTextBox;
            this.outputTextBox = outputTextBox;
            this.inputPrefixComboBox = inputPrefixComboBox;
            this.outputPrefixComboBox = outputPrefixComboBox;
            this.outputLabel = outputLabel;
            this.unit = unit;
        }

        public TextBox InputTextBox { get => inputTextBox; set => inputTextBox = value; }
        public TextBox OutputTextBox { get => outputTextBox; set => outputTextBox = value; }
        public ComboBox InputPrefixComboBox { get => inputPrefixComboBox; set => inputPrefixComboBox = value; }
        public ComboBox OutputPrefixComboBox { get => outputPrefixComboBox; set => outputPrefixComboBox = value; }
        public Label OutputLabel { get => outputLabel; set => outputLabel = value; }
        public string Unit { get => unit; set => unit = value; }
    }
}
