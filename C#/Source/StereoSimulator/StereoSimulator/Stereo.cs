using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StereoSimulator
{
    class Stereo
    {
        enum Function
        {
            CD,
            USB,
            Tape,
            AUX,
            Radio
        }

        enum Band
        {
            AM,
            FM
        }

        enum TapeDeck
        {
            TapeA,
            TapeB
        }

        enum OpenCDSlot
        {
            Left,
            Right,
        }

        private bool on;
        private Function currentFunction;
        private Band currentBand;
        private int currentCD;
        private int currentTape;
        private int currentAUX;
        private bool CDOpen;
        private bool tapeAOpen;
        private bool tapeBOpen;

        public void PressButton(Button button, bool longPress = false)
        {

        }

        public void TurnVolumeKnob(KnobDirection direction)
        {

        }

        public void TurnMicKnob(KnobDirection direction)
        {

        }
    }
}
