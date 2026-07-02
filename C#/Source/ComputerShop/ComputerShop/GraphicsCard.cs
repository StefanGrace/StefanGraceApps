using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerShop
{
    public class GraphicsCard : Product
    {
        private ulong vRamBytes;

        public GraphicsCard(string name, decimal price, bool inStock, ulong vRamBytes)
            : base(name, price, inStock)
        {
            this.vRamBytes = vRamBytes;
        }

        public override string GetHTML()
        {
            return "<b>V RAM:</b> " + FormatBytes(vRamBytes);
        }

        public new static string[] SortingOptions
        {
            get
            {
                return Product.SortingOptions.Concat(new string[] { "V RAM" }).ToArray();
            }
        }

        public ulong VRamBytes { get => vRamBytes; set => vRamBytes = value; }
    }
}
