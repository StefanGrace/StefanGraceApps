using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirListingExtStat
{
    class ExtType
    {
        private string type;
        private List<string> extentions;

        public ExtType(string type, string[] extentions)
        {
            this.type = type;
            this.extentions = extentions.ToList();
        }

        public ExtType(string type) : this(type, new string[] { }) { }

        public void AddExt(string ext)
        {
            extentions.Add(ext);
        }

        public void RemoveExt(string ext)
        {
            for (int i = 0; i < extentions.Count; i++)
            {
                if (extentions[i] == ext)
                {
                    extentions.RemoveAt(i);
                    return;
                }
            }

            throw new ArgumentOutOfRangeException(ext + " does not exist.");
        }

        public bool DoesExtExist(string ext)
        {
            foreach (string extention in extentions)
            {
                if (extention == ext)
                {
                    return true;
                }
            }

            return false;
        }

        public string Type { get => type; set => type = value; }
        public string[] Extentions { get => extentions.ToArray(); set => extentions = value.ToList(); }
    }
}
