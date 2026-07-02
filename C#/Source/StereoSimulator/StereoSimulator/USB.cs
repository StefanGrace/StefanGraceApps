using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StereoSimulator
{
    class USBDrive
    {
        private FileSystem fs;

        public USBDrive(FileSystem fs)
        {
            this.fs = fs;
        }

        public FileSystem FileSystem
        {
            get
            {
                return fs;
            }
        }
    }
}
