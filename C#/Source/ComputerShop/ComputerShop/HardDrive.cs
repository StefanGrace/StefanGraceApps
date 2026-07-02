using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerShop
{
    public class HardDrive : Product
    {
        private ulong capasityBytes;
        private string formFactor;
        private string connector;
        private ushort rotaitionalSpeedRPM;

        public HardDrive(string name, decimal price, bool inStock, ulong capasityBytes, string formFactor, string connector, ushort rotaitionalSpeedRPM) 
            : base(name, price, inStock)
        {
            this.capasityBytes = capasityBytes;
            this.formFactor = formFactor;
            this.connector = connector;
            this.rotaitionalSpeedRPM = rotaitionalSpeedRPM;
        }

        public override string GetHTML()
        {
            return "<b>Capasity:</b> " + FormatBytes(capasityBytes) + "<br>" +
                "<b>Form factor:</b> " + formFactor + "<br>" +
                "<b>Connector:</b> " + connector + "<br>" +
                "<b>Rotaitional speed:</b> " + rotaitionalSpeedRPM + " RPM";
        }

        public new static string[] SortingOptions
        {
            get
            {
                return Product.SortingOptions.Concat(new string[] { "Capasity", "Cost per TB", "Form factor", "Connector", "Rotaitonal speed" }).ToArray();
            }
        }

        public decimal CostPerTB
        {
            get
            {
                return price / ((decimal)capasityBytes / 1_000_000_000_000);
            }
        }

        public ulong CapasityBytes { get => capasityBytes; set => capasityBytes = value; }
        public string FormFactor { get => formFactor; set => formFactor = value; }
        public string Connector { get => connector; set => connector = value; }
        public ushort RotaitionalSpeedRPM { get => rotaitionalSpeedRPM; set => rotaitionalSpeedRPM = value; }
    }
}
