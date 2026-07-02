using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnitConverter
{
    public partial class VolumeLengthFunctionForm : Form
    {
        VolumeLengthFunction function;

        public VolumeLengthFunctionForm(VolumeLengthFunction function)
        {
            this.function = function;
            InitializeComponent();
        }

        public VolumeLengthFunction Function { get => function; set => function = value; }

        private void VolumeLengthFunctionForm_Load(object sender, EventArgs e)
        {
            switch (function)
            {
                case VolumeLengthFunction.SidesOfCube:
                    radioButton_sidesOfCube.Checked = true;
                    break;

                case VolumeLengthFunction.RadiusOfSphere:
                    radioButton_radiusOfSphere.Checked = true;
                    break;

                case VolumeLengthFunction.DiameterOfSphere:
                    radioButton_diameterOfSphere.Checked = true;
                    break;
            }
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
