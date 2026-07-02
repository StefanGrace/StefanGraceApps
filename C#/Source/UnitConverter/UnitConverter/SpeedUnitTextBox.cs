using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnitConverter
{
    class SpeedUnitTextBox : IUnitTextBox
    {
        private TextBox textBox;
        private string distanceUnit;
        private string timeUnit;
        private string distancePrefix;
        private string timePrefix;

        public SpeedUnitTextBox(TextBox textBox, string distanceUnit, string timeUnit, string distancePrefix = "", string timePrefix = "")
        {
            this.textBox = textBox;
            this.distanceUnit = distanceUnit;
            this.timeUnit = timeUnit;
            this.distancePrefix = distancePrefix;
            this.timePrefix = timePrefix;
        }

        public TextBox TextBox { get => textBox; }
        public string DistanceUnit { get => distanceUnit; }
        public string TimeUnit { get => timeUnit; }
        public string DistancePrefix { get => distancePrefix; }
        public string TimePrefix { get => timePrefix; }
    }
}
