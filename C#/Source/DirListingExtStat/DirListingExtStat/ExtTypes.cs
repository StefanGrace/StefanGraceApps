using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirListingExtStat
{
    class ExtTypes
    {
        private List<ExtType> extTypes = new List<ExtType>();

        public ExtTypes()
        {
            extTypes.Add(new ExtType("3D models", new string[] { "BLEND", "DES", "GLB", "OBJ", "SKP" }));
            extTypes.Add(new ExtType("Archives", new string[] { "7Z", "BZ2", "CAB", "GZ", "RAR", "TAR", "XZ", "ZIP" }));
            extTypes.Add(new ExtType("Audio", new string[] { "AC3", "AMR", "FLAC", "M4A", "MID", "MIDI", "MP1", "MP2", "MP3", "MPC", "OGG", "OPUS", "WAV", "WMA" }));
            extTypes.Add(new ExtType("Camera RAWs", new string[] { "ARW", "CR2", "CR3", "CRW", "DNG", "NEF", "ORF", "RAF", "RW2" }));
            extTypes.Add(new ExtType("Data", new string[] { "ACCDB", "CSV", "JSON", "ODB", "SQL", "SQLITE", "XML" }));
            extTypes.Add(new ExtType("Documents", new string[] { "ABW", "DOC", "DOCX", "DOT", "ISF", "MD", "ODP", "ODS", "ODT", "OXPS", "PDF", "PPT", "PPTX", "PUB", "RTF", "TXT", "XLS", "XSLM", "XLSX", "XPS" }));
            extTypes.Add(new ExtType("Graphics", new string[] { "AI", "ODG", "PDN", "PSD", "PTG", "SVG", "SVGZ", "XCF" }));
            extTypes.Add(new ExtType("Images", new string[] { "AVIF", "BMP", "GIF", "HEIC", "HEIF", "HIF", "JP2", "JPEG", "JPG", "JXL", "JXR", "PNG", "QOI", "TIF", "TIFF", "WEBP" }));
            extTypes.Add(new ExtType("Programming", new string[] { "AIA", "GMK", "SB", "SB2", "SB3", "YPR" }));
            extTypes.Add(new ExtType("Programs", new string[] { "APK", "APKS", "APP", "APPIMAGE", "APPX", "APPXBUNDLE", "COM", "DEB", "EXE", "FLATPAK", "IPA", "JAR", "MSI", "MSIX", "PKG", "RUN", "SCR", "SWF" }));
            extTypes.Add(new ExtType("Source code", new string[] { "AHK", "ASM", "BAT", "C", "CPP", "CS", "GML", "GO", "H", "INO", "JAVA", "JS", "LUA", "PHP", "PY", "R", "RB", "SH" }));
            extTypes.Add(new ExtType("System", new string[] { "DLL", "INI", "LNK", "SYS" }));
            extTypes.Add(new ExtType("Video", new string[] { "3GP", "AVI", "FLV", "M4V", "MKV", "MOD", "MOV", "MP4", "MPEG", "MPG", "MTS", "MXF", "OGV", "WEBM", "WMV" }));
            extTypes.Add(new ExtType("Video projects", new string[] { "DRP", "KDENLIVE", "MSDVD", "MSWMM", "PRPROJ", "VEG", "WLMP" }));
            extTypes.Add(new ExtType("Video subtitles", new string[] { "ASS", "SRT" }));
            extTypes.Add(new ExtType("Virtual disks", new string[] { "FD", "FLP", "IMA", "IMG", "ISO", "NRG", "QCOW", "VDI", "VHD", "VMDK" }));
        }

        public ExtTypes(string[] typeDefs)
        {
            foreach (string line in typeDefs)
            {
                string[] typeAndExts = line.Replace(" ", "").Split(':');
                string typeName = typeAndExts[0];
                string[] exts = typeAndExts[1].Split(',');
                for (int i = 0; i < exts.Length; i++)
                {
                    exts[i] = exts[i].ToUpper();
                }
                extTypes.Add(new ExtType(typeName, exts));
            }
        }

        public List<ExtType> Types { get => extTypes; }

        public void AddType(string extType)
        {
            foreach (ExtType type in extTypes)
            {
                if (type.Type == extType)
                {
                    throw new ArgumentException("\"" + extType + "\" already exists.");
                }
            }
            extTypes.Add(new ExtType(extType));
        }

        public void RenameType(string currentName, string newName)
        {
            foreach (ExtType type in extTypes)
            {
                if (type.Type == currentName)
                {
                    type.Type = newName;
                    return;
                }
            }

            throw new ArgumentOutOfRangeException("\"" + currentName + "\" does not exist.");
        }

        public void AddExt(string type, string ext)
        {
            foreach (ExtType extType in extTypes)
            {
                if (extType.Type == type)
                {
                    foreach(ExtType typeToCheck in extTypes)
                    {
                        if (typeToCheck.DoesExtExist(ext))
                        {
                            throw new ArgumentException("The \"" + ext + "\" extention already exists under the \"" + typeToCheck.Type + "\" type.");
                        }
                    }
                    extType.AddExt(ext);
                    return;
                }
            }

            throw new ArgumentOutOfRangeException("\"" + type + "\" does not exist.");
        }

        public void RemoveExt(string type, string ext)
        {
            foreach (ExtType extType in extTypes)
            {
                if (extType.Type == type)
                {
                    extType.RemoveExt(ext);
                    return;
                }
            }

            throw new ArgumentOutOfRangeException("\"" + type + "\" does not exist.");
        }

        public bool DoesExtExist(string type, string ext)
        {
            foreach (ExtType extType in extTypes)
            {
                if (extType.Type == type)
                {
                    return extType.DoesExtExist(ext);
                }
            }

            return false;
        }


        public string[] ToStringArray()
        {
            List<string> output = new List<String>();

            foreach(ExtType extType in extTypes)
            {
                output.Add(extType.Type + ": " + string.Join(", ", extType.Extentions));
            }

            return output.ToArray();
        }

        public override string ToString()
        {
            return string.Join("\r\n", ToStringArray());
        }

        public string GetExtType(string extention)
        {
            foreach (ExtType extType in extTypes)
            {
                foreach(string ext in extType.Extentions)
                {
                    if (extention == ext)
                    {
                        return extType.Type;
                    }
                }
            }

            return "Other";
        }
    }
}
