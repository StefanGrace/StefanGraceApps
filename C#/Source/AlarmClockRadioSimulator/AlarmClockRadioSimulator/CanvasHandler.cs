using System.Drawing;

namespace AlarmClockRadioSimulator
{
    class CanvasHandler
    {
        private Graphics canvas;

        public CanvasHandler(Graphics canvas)
        {
            this.canvas = canvas;
        }

        public Graphics Canvas
        {
            get
            {
                return canvas;
            }
        }
    }
}
