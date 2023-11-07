using System;
using System.Windows.Forms;

namespace AlarmClockRadioSimulator
{
    public partial class EnvironmentalVariablesForm : Form
    {
        private float tempC = 20.4f;
        private byte rh = 75;
        private bool pluggedIn = true;
        private bool lowBatt = false;
        private bool hpj = false;
        private byte usbState = 2;
        

        public EnvironmentalVariablesForm()
        {
            InitializeComponent();
        }

        public void setVariables(float tempC, byte rh, bool pluggedIn, bool lowBatt, bool hpj, byte usbState)
        {
            this.tempC = tempC;
            this.rh = rh;
            this.pluggedIn = pluggedIn;
            this.lowBatt = lowBatt;
            this.usbState = usbState;
            this.hpj = hpj;

            tempTrackBar.Value = (int) tempC * 10;
            rhTrackBar.Value = rh;
            pluggedInCheckBox.Checked = pluggedIn;
            lowBattCheckBox.Checked = lowBatt;
            hpjCheckBox.Checked = hpj;
            usbStateComboBox.SelectedIndex = usbState;

            updateTempLable();
            updateRhLable();

        }

        private void EnvironmentalVariablesForm_Load(object sender, EventArgs e)
        {
            pluggedInCheckBox.Checked = pluggedIn;
            usbStateComboBox.SelectedIndex = usbState;
        }

        private void tempTrackBar_Scroll(object sender, EventArgs e)
        {
            tempC = tempTrackBar.Value / 10f;
            updateTempLable();
        }

        private int tempCtoTempF(float tempC)
        {
            return (int) Math.Round((tempC * 1.8f) + 32f);
        }

        private void rhTrackBar_Scroll(object sender, EventArgs e)
        {
            rh = (byte) rhTrackBar.Value;
            updateRhLable();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pluggedInCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            pluggedIn = pluggedInCheckBox.Checked;
        }

        private void lowBattCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            lowBatt = lowBattCheckBox.Checked;
        }

        private void usbStateComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            usbState = (byte) usbStateComboBox.SelectedIndex;
        }

        private void hpjCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            hpj = hpjCheckBox.Checked;
        }

        private void updateTempLable()
        {
            tempValueLabel.Text = tempC.ToString("N1") + "°C / " + tempCtoTempF(tempC) + "°F";
        }

        private void updateRhLable()
        {
            rhValueLabel.Text = rh + "%";
        }

        public float TempC
        {
            get
            {
                return tempC;
            }
        }

        public byte RH
        {
            get
            {
                return rh;
            }
        }

        public bool PluggedIn
        {
            get
            {
                return pluggedIn;
            }
        }

        public bool LowBatt
        {
            get
            {
                return lowBatt;
            }
        }

        public byte USBstate
        {
            get
            {
                return usbState;
            }
        }

        public bool HPJ
        {
            get
            {
                return hpj;
            }
        }
       
    }
}
