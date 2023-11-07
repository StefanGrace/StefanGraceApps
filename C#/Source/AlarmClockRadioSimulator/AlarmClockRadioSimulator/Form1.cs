using System;
using System.Drawing;
using System.Windows.Forms;

namespace AlarmClockRadioSimulator
{
    public partial class Form1 : Form
    {
        CanvasHandler canvasHandler;
        Display disp;
        TempSensor ts;
        RhSensor rh;
        USB usb;
        Battery batt;
        Speaker speaker;
        HeadphoneJack hpj;
        AlarmClockRadio alc;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Graphics canvas = DisplayPictureBox.CreateGraphics();
            canvasHandler = new CanvasHandler(canvas);
            disp = new Display(canvasHandler);
            ts = new TempSensor();
            rh = new RhSensor();
            usb = new USB();
            batt = new Battery();
            speaker = new Speaker();
            hpj = new HeadphoneJack();
            alc = new AlarmClockRadio(disp, ts, rh, usb, batt, speaker, hpj);
            brightnessTrackBar.Value = 10;
            timeFormatListBox.SelectedIndex = 0;
            alarm1ListBox.SelectedIndex = 0;
            alarm2ListBox.SelectedIndex = 0;
            functionListBox.SelectedIndex = 0;
            tempUnitListBox.SelectedIndex = 0;
            speaker.Volume = (byte) volumeTrackBar.Value;
            hpj.Volume = (byte) volumeTrackBar.Value;
            timer1.Start();
            flashTimer.Start();
            alc.updateDisplay();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            alc.tick();
        }

        private void snoozeButton_Click(object sender, EventArgs e)
        {
            if (ModifierKeys.HasFlag(Keys.Shift))
            {
                alc.longPressSnoozeButton();
            }
            else
            {
                alc.pressSnoozeButton();
            }
            
        }

        private void upButton_Click(object sender, EventArgs e)
        {
            if (ModifierKeys.HasFlag(Keys.Shift))
            {
                alc.longPressUpButton();
            }
            else
            {
                alc.pressUpButton();
            } 
        }

        private void downButton_Click(object sender, EventArgs e)
        {
            if (ModifierKeys.HasFlag(Keys.Shift))
            {
                alc.longPressDownButton();
            }
            else
            {
                alc.pressDownButton();
            }    
        }

        private void sleepButton_Click(object sender, EventArgs e)
        {
            alc.pressSleepButton();
        }

        private void SetButton_Click(object sender, EventArgs e)
        {
            if (ModifierKeys.HasFlag(Keys.Shift))
            {
                alc.longPressSetButton();
            }
            else
            {
                alc.pressSetButton();
            }
        }

        private void timeFormatListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            alc.setTimeFormat((byte) timeFormatListBox.SelectedIndex);
        }

        private void alarm1ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            alc.setAlarm1((byte)alarm1ListBox.SelectedIndex);
        }

        private void alarm2ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            alc.setAlarm2((byte)alarm2ListBox.SelectedIndex);
        }

        private void functionListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            alc.setFuncion((byte)functionListBox.SelectedIndex);
        }

        private void tempUnitListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            alc.setTempUnit((byte)tempUnitListBox.SelectedIndex);
        }

        private void brightnessTrackBar_Scroll(object sender, EventArgs e)
        {
            alc.setBrihgtness(brightnessTrackBar.Value);
        }

        private void flashTimer_Tick(object sender, EventArgs e)
        {
            alc.flashTick();
            buzzLabel.Visible = speaker.Buzzing || hpj.Buzzing;
            updateSpeaker();
        }

        private void environmentalVariablesButton_Click(object sender, EventArgs e)
        {
            EnvironmentalVariablesForm evf = new EnvironmentalVariablesForm();
            evf.setVariables(ts.TempC, rh.Rh, alc.PluggedIn, batt.Low, hpj.HeadphonesPluggedIn, usb.State);
            evf.ShowDialog();
            ts.TempC = evf.TempC;
            rh.Rh = evf.RH;
            usb.State = evf.USBstate;
            batt.Low = evf.LowBatt;
            alc.PluggedIn = evf.PluggedIn;
            hpj.HeadphonesPluggedIn = evf.HPJ;
            speaker.Volume = (byte)volumeTrackBar.Value;
            hpj.Volume = (byte)volumeTrackBar.Value;
        }

        private void volumeTrackBar_Scroll(object sender, EventArgs e)
        {
            speaker.Volume = (byte) volumeTrackBar.Value;
            hpj.Volume = (byte) volumeTrackBar.Value;
        }

        private void updateSpeaker()
        {
            speakerProgressBar.Value = speaker.Volume * 10;
            hpjProgressBar.Value = hpj.Volume * 10;
        }
    }
}
