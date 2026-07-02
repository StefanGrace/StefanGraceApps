using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StereoSimulator
{
    class CDROM : CD
    {
        private FileSystem fs;

        public CDROM(FileSystem fs)
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
