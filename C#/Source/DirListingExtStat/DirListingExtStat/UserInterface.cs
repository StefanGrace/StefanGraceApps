using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DirListingExtStat
{
    class UserInterface
    {
        private string inputFilepath;
        string[] dirListings = null;
        private int maxRows = 20;
        private bool caseSensitive = false;
        private bool dispLowercase = false;
        private bool showTotals = true;
        private int maxExtLength = 10;
        private string numberFormat = "N0";
        private string sortBy = "bytes";
        private string find = "*";
        private int bytesInKB = 1000;
        private bool showTypes = false;
        private string path = "";
        private List<FileType> extStats = null;
        private List<FileType> sortedExtStats;
        private ExtTypes types;
        private int typeFilter = 0;
        string typeDefsDir = "DirListingExtStat_settings";


        public UserInterface(string[] args)
        {
            try
            {
                types = new ExtTypes(File.ReadAllLines(typeDefsDir + @"\TypeDefs.txt"));
            }
            catch
            {
                types = new ExtTypes();
            }

            if (args.Length > 0)
            {
                inputFilepath = args[0];
                ReadData();
                DisplayTable();
            }
            else
            {
                PromptInputPath();
                if (extStats == null)
                {
                    return;
                }
            }

            UserInput();
        }

        private void UserInput()
        {
            while (true)
            {
                Console.WriteLine();
                Console.Write("Enter command: ");
                string userInput = Console.ReadLine().ToLower();

                switch (userInput)
                {
                    case "":
                        DisplayTable();
                        break;

                    case "help":
                    case "h":
                    case "?":
                        DisplayHelp();
                        break;

                    case "order":
                    case "o":
                        sortBy = "order";
                        SortExt();
                        break;

                    case "extension":
                    case "ext":
                    case "e":
                        sortBy = "ext";
                        SortExt();
                        break;

                    case "files":
                    case "f":
                        sortBy = "ext";
                        SortExt();
                        sortBy = "files";
                        SortExt();
                        break;

                    case "size":
                    case "bytes":
                    case "b":
                        sortBy = "ext";
                        SortExt();
                        sortBy = "bytes";
                        SortExt();
                        break;

                    case "average":
                    case "ave":
                    case "a":
                        sortBy = "ext";
                        SortExt();
                        sortBy = "bytes per file";
                        SortExt();
                        break;

                    case "total":
                    case "t":
                        showTotals = !showTotals;
                        break;

                    case "case":
                    case "c":
                        caseSensitive = !caseSensitive;
                        ReadData();
                        break;

                    case "display":
                    case "disp":
                    case "d":
                        if (caseSensitive)
                        {
                            Console.WriteLine("Display case not applicable when case sensitivity is turned on.");
                        }
                        else
                        {
                            dispLowercase = !dispLowercase;
                            ApplyDispCase();
                            SortExt();
                        }
                        break;

                    case "limit":
                    case "l":
                        while (true)
                        {
                            Console.Write("Enter limit for maximum extention length (0 = all): ");
                            string userInputValue = Console.ReadLine();
                            if (userInputValue == "")
                            {
                                break;
                            }
                            try
                            {
                                int userInputInt = int.Parse(userInputValue);
                                if (userInputInt == 0)
                                {
                                    maxExtLength = int.MaxValue;
                                    break;
                                }
                                else if (userInputInt < 3)
                                {
                                    throw new ArgumentOutOfRangeException();
                                }
                                maxExtLength = userInputInt;
                                break;
                            }
                            catch
                            {
                                Console.WriteLine("Invalid value. Must be an integer 3 or larger.");
                                Console.WriteLine();
                            }
                        }
                        break;

                    case "find":
                    case "q":
                        showTypes = false;
                        Console.Write("Enter file extention (* for all): ");
                        string userInputExt = Console.ReadLine();
                        typeFilter = 0;
                        if (userInputExt == "*")
                        {
                            find = "*";
                            SortExt();
                            break;
                        }
                        if (!caseSensitive)
                        {
                            userInputExt = userInputExt.ToUpper();
                        }
                        FileType foundExt = null;
                        foreach (FileType ext in sortedExtStats)
                        {
                            if (ext.Extention == userInputExt)
                            {
                                foundExt = ext;
                                break;
                            }
                        }
                        if (foundExt == null)
                        {
                            Console.WriteLine("Cannot find \"" + userInputExt + "\"");
                        }
                        else
                        {
                            sortedExtStats.Remove(foundExt);
                            sortedExtStats.Insert(0, foundExt);
                            find = userInputExt;
                            DisplayTable();
                        }
                        break;

                    case "type":
                    case "y":
                        typeFilter = 0;
                        find = "*";
                        showTypes = !showTypes;
                        break;

                    case "filter":
                    case "r":
                        showTypes = false;
                        Console.WriteLine("0 - All (clear filter)" + (typeFilter == 0 ? " (current)" : ""));
                        for (int i = 0; i < types.Types.Count; i++)
                        {
                            Console.WriteLine((i + 1) + " - " + types.Types[i].Type + (typeFilter == (i + 1) ? " (current)" : ""));
                        }
                        Console.WriteLine((types.Types.Count + 1) + " - Other" + (typeFilter == (types.Types.Count + 1) ? " (current)" : ""));
                        int userCoice = 0;
                        while (true)
                        {
                            Console.WriteLine();
                            Console.Write("Enter number: ");
                            string userCoiceText = Console.ReadLine();
                            if (userCoiceText == "")
                            {
                                break;
                            }
                            else
                            {
                                try
                                {
                                    userCoice = int.Parse(userCoiceText);
                                    if (userCoice < 0 || userCoice > types.Types.Count + 1)
                                    {
                                        throw new ArgumentOutOfRangeException();
                                    }
                                    break;
                                }
                                catch
                                {
                                    if (userCoiceText.ToLower() == "other")
                                    {
                                        userCoice = types.Types.Count + 1;
                                        break;
                                    }
                                    else
                                    {
                                        bool validChoice = false;
                                        for (int i = 0; i < types.Types.Count; i++)
                                        {
                                            if (userCoiceText.ToLower() == types.Types[i].Type.ToLower())
                                            {
                                                userCoice = i + 1;
                                                validChoice = true;
                                                break;
                                            }
                                        }

                                        if (validChoice)
                                        {
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Invalid choice.");
                                        }
                                    }
                                }
                            }
                        }

                        find = "*";
                        typeFilter = userCoice;
                        break;

                    case "definitions":
                    case "definition":
                    case "def":
                    case "n":
                        Console.WriteLine();
                        foreach (string line in types.ToStringArray())
                        {
                            Console.WriteLine(line);
                        }
                        Console.WriteLine();
                        break;

                    case "edit":
                    case "z":
                        EditTypeDefs();
                        break;

                    case "path":
                    case "p":
                        while (true)
                        {
                            if (path != "")
                            {
                                Console.WriteLine("Current path: " + path);
                            }
                            Console.Write("Enter folder path (leave blank to clear): ");
                            try
                            {
                                string path = Console.ReadLine().Replace("\"", "");
                                if (DirListingReader.IsPathInDirListings(dirListings, path))
                                {
                                    this.path = path;
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Dir listings do not contain \"" + path + "\".");
                                    Console.WriteLine();
                                }
                            }
                            catch (ArgumentException ex)
                            {
                                Console.WriteLine(ex.Message);
                                Console.WriteLine();
                            }
                        }
                        Console.WriteLine();
                        ReadData();
                        DisplayTable();
                        break;

                    case "input":
                    case "i":
                        PromptInputPath();
                        break;

                    case "unit":
                    case "u":
                        if (bytesInKB == 1000)
                        {
                            bytesInKB = 1024;
                            Console.WriteLine("TXT input file size unit set to binary.");
                        }
                        else
                        {
                            bytesInKB = 1000;
                            Console.WriteLine("TXT input file size unit set to decimal.");
                        }
                        Console.WriteLine();
                        ReadData();
                        break;

                    case "save":
                    case "s":
                        SaveTable();
                        break;

                    case "csv":
                    case "v":
                        SaveCSV();
                        break;

                    case "exit":
                    case "x":
                        return;

                    default:
                        try
                        {
                            maxRows = int.Parse(userInput);
                            if (maxRows == 0)
                            {
                                maxRows = int.MaxValue;
                            }
                            else if (maxRows < 0)
                            {
                                throw new ArgumentOutOfRangeException();
                            }
                        }
                        catch
                        {
                            Console.WriteLine("Invalid command. Type \"help\" for a list of commands.");
                        }
                        break;
                }
            }
        }

        private void ReadData()
        {  
            try
            {
                dirListings = File.ReadAllLines(inputFilepath);
            }
            catch
            {
                Console.WriteLine("Can not find \"" + inputFilepath + "\"");
                PromptInputPath();
                return;
            }
            Console.WriteLine("Reading data...");
            try
            {
                extStats = DirListingReader.GetExtStats(dirListings, caseSensitive, bytesInKB, path);
                if (!caseSensitive && dispLowercase)
                {
                    ApplyDispCase();
                }
                SortExt();
            }
            catch
            {
                Console.WriteLine("TXT data is not formatted correctly.");
                PromptInputPath();
                return;
            }
        }

        private void SortExt()
        {
            switch (sortBy)
            {
                case "order":
                    sortedExtStats = extStats;
                    break;

                case "ext":
                    sortedExtStats = extStats.OrderBy(ext => ext.Extention).ToList();
                    break;

                case "files":
                    sortedExtStats = extStats.OrderByDescending(ext => ext.Files).ToList();
                    break;

                case "bytes":
                    sortedExtStats = extStats.OrderByDescending(ext => ext.Bytes).ToList();
                    break;

                case "bytes per file":
                    sortedExtStats = extStats.OrderByDescending(ext => ext.BytesPerFile).ToList();
                    break;

                default:
                    throw new ArgumentOutOfRangeException();
            }
            find = "*";
        }

        private void DisplayTable()
        {
            int maxExtLength = showTypes ? int.MaxValue : this.maxExtLength;
            int MaxRowsToShow = showTypes ? int.MaxValue : this.MaxRowsToShow;

            string[] table = DataFormatter.MakeExtStatTable(SortedAndFilteredExtStats, numberFormat, showTotals, maxExtLength, MaxRowsToShow, showTypes);

            foreach (string row in table)
            {
                Console.WriteLine(row);
            }
            if (!showTypes)
            {
                Console.WriteLine("Unique file extensions: " + SortedAndFilteredExtStats.Count);
            }
        }

        private void SaveTable()
        {
            int maxExtLength = showTypes ? int.MaxValue : this.maxExtLength;
            int MaxRowsToShow = showTypes ? int.MaxValue : this.MaxRowsToShow;
            string[] table = DataFormatter.MakeExtStatTable(SortedAndFilteredExtStats, numberFormat, showTotals, maxExtLength, MaxRowsToShow, showTypes);
            try
            {
                File.WriteAllLines("Table.txt", table);
                if (!showTypes)
                {
                    File.AppendAllLines("Table.txt", new string[] { "Unique file extensions: " + SortedAndFilteredExtStats.Count });
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine();
            }
        }

        private void SaveCSV()
        {
            int MaxRowsToShow = showTypes ? int.MaxValue : this.MaxRowsToShow;
            string[] csv = DataFormatter.MakeExtStatCSV(SortedAndFilteredExtStats, showTotals, maxRows, showTypes);
            try
            {
                File.WriteAllLines("Data.csv", csv);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine();
            }
        }

        private void PromptInputPath()
        {
            Console.Write("Enter path of dir listing TXT input file: ");
            string userInput = Console.ReadLine().Replace("\"", "");
            if (userInput == "")
            {
                return;
            }
            inputFilepath = userInput;
            Console.WriteLine();
            ReadData();
            DisplayTable();
        }

        private void ApplyDispCase()
        {
            for (int i = 0; i < extStats.Count; i++)
            {
                if (dispLowercase)
                {
                    extStats[i].Extention = extStats[i].Extention.ToLower();
                }
                else
                {
                    extStats[i].Extention = extStats[i].Extention.ToUpper();
                }
            }
        }

        private void DisplayHelp()
        {
            Console.WriteLine("Commands:");
            Console.WriteLine("help (h) - show this information");
            Console.WriteLine("order (o) - sort extensions in the order that they appear in the input file" + IsCurrentSort("order"));
            Console.WriteLine("ext (e) - sort extensions alphabetically" + IsCurrentSort("ext"));
            Console.WriteLine("files (f) - sort by number of files" + IsCurrentSort("files"));
            Console.WriteLine("size (b) - sort by number of bytes" + IsCurrentSort("bytes"));
            Console.WriteLine("average (a) - sort by bytes per file" + IsCurrentSort("bytes per file"));
            Console.WriteLine("total (t) - toggle whether to show totals row" + GetSettingState(showTotals));
            Console.WriteLine("case (c) - toggle file extension case sensitivity" + GetSettingState(caseSensitive));
            Console.WriteLine("disp (d) - toggle file extension display case" + (dispLowercase ? " (lower)" : " (UPPER)"));
            Console.WriteLine("limit (l) - set the maximum extension length that will be displayed" + GetLimitState(maxExtLength));
            Console.WriteLine("find (q) - find a particular file extension" + (find == "*" ? "" : " (" + find + ")"));
            Console.WriteLine("type (y) - display the file type rather than the extension" + GetSettingState(showTypes));
            Console.WriteLine("filter (r) - filter extentions by type" + FilterTypeName);
            Console.WriteLine("definitions (n) - view type definitions");
            Console.WriteLine("edit (z) - edit type definitions");
            Console.WriteLine("path (p) - only show stats about extensions in a particular subfolder");
            Console.WriteLine("input (i) - enter new path for input file");
            Console.WriteLine("unit (u) - toggle TXT input file size unit between decimal and binary" + GetUnitType());
            Console.WriteLine("save (s) - save table to TXT file");
            Console.WriteLine("csv (v) - save table to CSV file");
            Console.WriteLine("exit (x) - quit the program");
            Console.WriteLine("Type a number to set the max number of extensions to be displayed (0 = all)" + GetLimitState(maxRows));
            Console.WriteLine("Press Enter to generate table");
            Console.WriteLine();
        }

        private string IsCurrentSort(string sort)
        {
            return sortBy == sort ? " (current)" : "";
        }

        private string GetSettingState(bool setting)
        {
            return setting ? " (on)" : " (off)";
        }

        private string GetLimitState(int limit)
        {
            return limit == int.MaxValue ? " (all)" : " (" + limit + ")";
        }

        private string GetUnitType()
        {
            switch (bytesInKB)
            {
                case 1000:
                    return " (decimal)";

                case 1024:
                    return " (binary)";

                default:
                    return "";
            }
        }

        private string FilterTypeName
        {
            get
            {
                if (typeFilter == 0)
                {
                    return "";
                }
                else if (typeFilter == types.Types.Count + 1)
                {
                    return " (other)";
                }
                else
                {
                    return " (" + types.Types[typeFilter - 1].Type.ToLower() + ")";
                }
            }
        }

        private List<FileType> FilterExtentions()
        {
            List<FileType> filteredExtStats = new List<FileType>();

            if (typeFilter == 0)
            {
                filteredExtStats = sortedExtStats;
            }
            else if (typeFilter == types.Types.Count + 1)
            {
                foreach (FileType extStat in sortedExtStats)
                {
                    bool extFound = false;
                    foreach (ExtType type in types.Types)
                    {
                        foreach (string ext in type.Extentions)
                        {
                            if (extStat.Extention == ext)
                            {
                                extFound = true;
                                break;
                            }
                        }
                        if (extFound)
                        {
                            break;
                        }
                    }
                    if (!extFound)
                    {
                        filteredExtStats.Add(extStat);
                    }
                }
            }
            else
            {
                string[] extFilter = types.Types[typeFilter - 1].Extentions;
                foreach (FileType extStat in sortedExtStats)
                {
                    foreach (string ext in extFilter)
                    {
                        if (extStat.Extention.ToUpper() == ext.ToUpper())
                        {
                            filteredExtStats.Add(extStat);
                            break;
                        }
                    }
                }
            }

            return filteredExtStats;
        }

        private List<FileType> SortedAndFilteredExtStats
        {
            get
            {
                if (showTypes)
                {
                    List<FileType> extTypeStats = new List<FileType>();
                    foreach(ExtType type in types.Types)
                    {
                        extTypeStats.Add(new FileType(type.Type, 0, 0));
                    }
                    extTypeStats.Add(new FileType("Other", 0, 0));
                    foreach (FileType ext in extStats)
                    {
                        foreach(FileType type in extTypeStats)
                        {
                            if (type.Extention == types.GetExtType(caseSensitive ? ext.Extention.ToUpper() : ext.Extention))
                            {
                                type.Files += ext.Files;
                                type.Bytes += ext.Bytes;
                            }        
                        }
                    }
                    
                    // Sort
                    switch (sortBy)
                    {
                        case "files":
                            extTypeStats = extTypeStats.OrderByDescending(type => type.Files).ToList();
                            break;

                        case "bytes":
                            extTypeStats = extTypeStats.OrderByDescending(type => type.Bytes).ToList();
                            break;

                        case "bytes per file":
                            extTypeStats = extTypeStats.OrderByDescending(type => type.BytesPerFile).ToList();
                            break;

                        default:
                            extTypeStats = extTypeStats.OrderBy(type => type.Extention).ToList();
                            break;
                    }

                    // Move "Other" to the end
                    FileType otherType = null;
                    for (int i = 0; i < extTypeStats.Count; i++)
                    {
                        if (extTypeStats[i].Extention == "Other")
                        {
                            otherType = extTypeStats[i];
                            extTypeStats.RemoveAt(i);
                            break;
                        }
                    }
                    if (otherType != null)
                    {
                        extTypeStats.Add(otherType);
                    }

                    // Remove empty entries
                    for (int i = 0; i < extTypeStats.Count; i++)
                    {
                        if (extTypeStats[i].Files == 0)
                        {
                            extTypeStats.RemoveAt(i);
                            i--;
                        }
                        
                    }
                    
                    return extTypeStats;
                }

                return FilterExtentions();
            }
        }


        private void EditTypeDefs()
        {
            Console.WriteLine();
            Console.WriteLine("1 - Add new type");
            Console.WriteLine("2 - Edit existing type");
            Console.WriteLine("3 - Rename existing type");
            Console.WriteLine("4 - Delete existing type");
            Console.WriteLine("5 - Save type definitons");
            Console.WriteLine("0 - Cancel");

            while (true)
            {
                Console.WriteLine();
                Console.Write("Enter choice: ");
                string userTypeEditChoice = Console.ReadLine();
                switch (userTypeEditChoice.ToLower())
                {
                    case "1":
                    case "add":
                        while (true)
                        {
                            Console.Write("Enter type name to add: ");
                            string newTypeName = Console.ReadLine();
                            if (newTypeName == "")
                            {
                                break;
                            }
                            try
                            {
                                types.AddType(newTypeName);
                                break;
                            }
                            catch (ArgumentException ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                        }
                        EditTypeDefs();
                        return;

                    case "2":
                    case "edit":
                        for (int i = 0; i < types.Types.Count; i++)
                        {
                            Console.WriteLine((i + 1) + " - " + types.Types[i].Type);
                        }
                        while (true)
                        {
                            Console.WriteLine();
                            Console.Write("Choose type to edit: ");
                            string userEditChoice = Console.ReadLine();
                            if (userEditChoice == "")
                            {
                                break;
                            }
                            else
                            {
                                try
                                {
                                    int typeToEdit = int.Parse(userEditChoice);

                                    if (typeToEdit < 1 || typeToEdit > types.Types.Count)
                                    {
                                        throw new ArgumentOutOfRangeException();
                                    }
                                    string typeName = types.Types[typeToEdit - 1].Type;
                                    Console.Write("Enter existing extention to remove it, enter new extention to add it: ");
                                    string enteredExt = Console.ReadLine().ToUpper();
                                    if (types.DoesExtExist(typeName, enteredExt))
                                    {
                                        types.RemoveExt(typeName, enteredExt);
                                    }
                                    else
                                    {
                                        try
                                        {
                                            types.AddExt(typeName, enteredExt);
                                        }
                                        catch (ArgumentException ex)
                                        {
                                            Console.WriteLine(ex.Message);
                                        }
                                    }

                                    break;
                                }
                                catch
                                {
                                    Console.WriteLine("Invalid choice.");
                                }
                            }
                        }
                        EditTypeDefs();
                        return;

                    case "3":
                    case "rename":
                        for (int i = 0; i < types.Types.Count; i++)
                        {
                            Console.WriteLine((i + 1) + " - " + types.Types[i].Type);
                        }
                        while (true)
                        {
                            Console.WriteLine();
                            Console.Write("Choose type to rename: ");
                            string userRenameChoice = Console.ReadLine();
                            if (userRenameChoice == "")
                            {
                                break;
                            }
                            else
                            {
                                try
                                {
                                    int typeToRename = int.Parse(userRenameChoice);

                                    if (typeToRename < 1 || typeToRename > types.Types.Count)
                                    {
                                        throw new ArgumentOutOfRangeException();
                                    }

                                    Console.Write("Enter new name: ");
                                    string newName = Console.ReadLine();

                                    types.RenameType(types.Types[typeToRename - 1].Type, newName);
                                }
                                catch
                                {
                                    Console.WriteLine("Invalid choice.");
                                }
                            }
                        }
                        EditTypeDefs();
                        return;

                    case "4":
                    case "delete":
                        for (int i = 0; i < types.Types.Count; i++)
                        {
                            Console.WriteLine((i + 1) + " - " + types.Types[i].Type);
                        }
                        while (true)
                        {
                            Console.WriteLine();
                            Console.Write("Choose type to delete: ");
                            string userDeleteChoice = Console.ReadLine();
                            if (userDeleteChoice == "")
                            {
                                break;
                            }
                            else
                            {
                                try
                                {
                                    int typeToDelete = int.Parse(userDeleteChoice);

                                    if (typeToDelete < 1 || typeToDelete > types.Types.Count)
                                    {
                                        throw new ArgumentOutOfRangeException();
                                    }

                                    types.Types.RemoveAt(typeToDelete - 1);

                                    break;
                                }
                                catch
                                {
                                    Console.WriteLine("Invalid choice.");
                                }
                            }
                        }

                        EditTypeDefs();
                        return;

                    case "5":
                    case "save":
                        Directory.CreateDirectory(typeDefsDir);
                        File.WriteAllLines(typeDefsDir + @"\TypeDefs.txt", types.ToStringArray());
                        return;

                    case "0":
                    case "":
                        return;

                    default:
                        Console.Write("Invalid choice.");
                        break;

                }
            }
        }

        private int MaxRowsToShow
        {
            get
            {
                if (find == "*")
                {
                    return maxRows;
                }
                else
                {
                    return 1;
                }
            }
        }

    }
}
