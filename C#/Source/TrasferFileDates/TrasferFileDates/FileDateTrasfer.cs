using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrasferFileDates
{
    class FileDateTrasfer
    {
        public void TrasferFileDates(string fromDir, string toDir, string fromExt, string toExt, bool modified, bool created, bool accessed)
        {
            string[] files = System.IO.Directory.GetFiles(fromDir, "*." + fromExt);

            foreach (string file in files)
            {
                string filename = System.IO.Path.GetFileNameWithoutExtension(file);
                string targetFilePath = toDir + @"\" + filename + "." + toExt;
                if (System.IO.File.Exists(targetFilePath))
                {
                    if (modified)
                    {
                        System.IO.File.SetLastWriteTime(targetFilePath, System.IO.File.GetLastWriteTime(file));
                    }
                    if (created)
                    {
                        System.IO.File.SetCreationTime(targetFilePath, System.IO.File.GetCreationTime(file));
                    }
                    if (accessed)
                    {
                        System.IO.File.SetLastAccessTime(targetFilePath, System.IO.File.GetLastAccessTime(file));
                    }
                }
            }
        }
    }
}
