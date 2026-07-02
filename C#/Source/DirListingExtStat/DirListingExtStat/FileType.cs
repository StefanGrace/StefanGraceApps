using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirListingExtStat
{
    class FileType
    {
        private string extention;
        private long files;
        private long bytes;

        public FileType(string extention, long files, long bytes)
        {
            this.extention = extention;
            this.files = files;
            this.bytes = bytes;
        }

        public string Extention { get => extention; set => extention = value; }
        public long Files { get => files; set => files = value; }
        public long Bytes { get => bytes; set => bytes = value; }
        public double BytesPerFile { get => (double)bytes / files; }
    }
}
