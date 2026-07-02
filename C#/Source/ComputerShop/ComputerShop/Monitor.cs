using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerShop
{
    public class Monitor : Product
    {
        private Resolution resolution;
        private double diagonalSizeInches;
        private uint refreshRateHz;
        private string panelType;
        private string[] inputs;
        private string usbHub;

        public Monitor(string name, decimal price, bool inStock, Resolution resolution, double diagonalSizeInches, uint refreshRateHz, string panelType, string[] inputs, string usbHub) 
            : base(name, price, inStock)
        {
            this.resolution = resolution;
            this.diagonalSizeInches = diagonalSizeInches;
            this.refreshRateHz = refreshRateHz;
            this.panelType = panelType;
            this.inputs = inputs;
            this.usbHub = usbHub;
        }

        public override string GetHTML()
        {
            return "<b>Sise:</b> " + diagonalSizeInches + " inch" + "<br>" +
                 "<b>Resolution:</b> " + resolution + "<br>" +
                 "<b>Aspect ratio:</b> " + AR + "<br>" +
                 "<b>Refresh rate:</b> " + FormatFrequency(refreshRateHz) + "<br>" +
                 "<b>Panel type:</b> " + panelType + "<br>" +
                 "<b>Inputs:</b> " + InputsString + "<br>" +
                 "<b>USB hub:</b> " + usbHub;
        }

        public AspectRatio AR
        {
            get
            {
                return new AspectRatio(resolution.Width, resolution.Height);
            }
        }

        private string InputsString
        {
            get
            {
                string output = "";
                foreach(string input in inputs)
                {
                    output += input + ", ";
                }
                return output.TrimEnd(new char[] { ' ', ',' });
            }
        }

        public new static string[] SortingOptions
        {
            get
            {
                return Product.SortingOptions.Concat(new string[] { "Size", "Resolution", "Aspect ratio", "Refresh rate", "Panel type" }).ToArray();
            }
        }

        internal Resolution Resolution { get => resolution; set => resolution = value; }
        public double DiagonalSizeInches { get => diagonalSizeInches; set => diagonalSizeInches = value; }
        public uint RefreshRateHz { get => refreshRateHz; set => refreshRateHz = value; }
        public string PanelType { get => panelType; set => panelType = value; }
        public string[] Inputs { get => inputs; set => inputs = value; }
        public string UsbHub { get => usbHub; set => usbHub = value; }
    }
}
