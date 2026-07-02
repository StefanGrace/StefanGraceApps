using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirListingDepth
{
    class DepthStats
    {
        private int maxFolderDepth;

        private List<DepthStat> depthStats = new List<DepthStat>();

        public void AddFolder(int depth)
        {
            foreach(DepthStat depthStat in depthStats)
            {
                if (depthStat.Depth == depth)
                {
                    depthStat.Folders++;
                    return;
                }
            }
            depthStats.Add(new DepthStat(depth, 1, 0, 0));
        }

        public void AddFiles(int depth, int files)
        {
            foreach (DepthStat depthStat in depthStats)
            {
                if (depthStat.Depth == depth)
                {
                    depthStat.Files += files;
                    return;
                }
            }
            depthStats.Add(new DepthStat(depth, 0, files, 0));
        }

        public void AddBytes(int depth, long bytes)
        {
            foreach (DepthStat depthStat in depthStats)
            {
                if (depthStat.Depth == depth)
                {
                    depthStat.Bytes += bytes;
                    return;
                }
            }
            depthStats.Add(new DepthStat(depth, 0, 0, bytes));
        }

        public string[] ToStringArray()
        {
            string[] lines = new string[depthStats.Count];
            for (int i = 0; i < depthStats.Count; i++)
            {
                lines[i] = depthStats[i].Depth + ": " + depthStats[i].Folders + " folders, " 
                    + depthStats[i].Files + " files, " + depthStats[i].Bytes + " bytes";
            }
            return lines;
        }

        public override string ToString()
        {
            string output = "";
            string[] lines = ToStringArray();
            foreach(string line in lines)
            {
                output += line + "\r\n";
            }
            return output;
        }

        public int MaxFolderDepth { get => maxFolderDepth; set => maxFolderDepth = value; }
    }
}
