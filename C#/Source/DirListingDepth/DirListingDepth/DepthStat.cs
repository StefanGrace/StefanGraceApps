using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirListingDepth
{
    class DepthStat
    {
        private int depth;
        private int folders;
        private int files;
        private long bytes;

        public DepthStat(int depth, int folders, int files, long bytes)
        {
            this.depth = depth;
            this.folders = folders;
            this.files = files;
            this.bytes = bytes;
        }

        public int Depth { get => depth; set => depth = value; }
        public int Folders { get => folders; set => folders = value; }
        public int Files { get => files; set => files = value; }
        public long Bytes { get => bytes; set => bytes = value; }
        public double BytesPerFile { get => (double)bytes / files; }
        public double BytesPerFolder { get => (double)bytes / folders; }
        public double FilesPerFolder { get => (double)files / folders; }
    }
}
