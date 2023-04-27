using System.Collections.Generic;
using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Text.RegularExpressions;
using CommunityToolkit.Mvvm.ComponentModel;

namespace RevitAddinManager
{
    public sealed partial class Addins : ObservableCollection<Addin>
    {
        private readonly string pattern = @"\d{4}";
        private static readonly string sufferfix = "addin";
        private static readonly string disabled = ".disabled";
        private readonly string[] folderPaths = new string[3]
        {
            Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Autodesk", "Revit", "Addins"),
            Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), "Autodesk", "Revit", "Addins"),
            Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), "Autodesk", "ApplicationPlugins"),
        };

        private IList<string> folderPathsList
        {
            get
            {
                IList<string> fullPaths = new List<string>();
                foreach (string folderPath in folderPaths)
                {
                    try
                    {
                        string[] f1 = Directory.GetFiles(folderPath, "*.addin", SearchOption.AllDirectories);
                        foreach (string f in f1)
                        {
                            fullPaths.Add(f);
                        }
                        string[] f2 = Directory.GetFiles(folderPath, "*.addin" + disabled, SearchOption.AllDirectories);
                        foreach (string f in f2)
                        {
                            fullPaths.Add(f);
                        }
                    }
                    catch
                    { }
                }
                return fullPaths;
            }
        }

        public Addins()
        {
            foreach (string file in folderPathsList)
            {
                string[] split = file.Split('\\');
                string version = "";
                string user = "no";
                foreach (string s in split)
                {
                    if (s.StartsWith("20") && s.Length == 4)
                    {
                        version = s;
                    }
                    if (s == Environment.UserName)
                    {
                        user = "yes";
                    }
                }

                //如果文件夹不包含年份，则在文件名中寻找年份
                if (version == "")
                {
                    var fileName = Path.GetFileNameWithoutExtension(file);
                    if (Regex.IsMatch(fileName, pattern))
                    {
                        var st = Regex.Match(fileName, pattern).Value.ToString();
                        if (int.TryParse(st, out int d) && 2010 < d && d < 2025)
                        {
                            version = d.ToString();
                        }
                    }
                }

                //if (!Versions.Contains(version))
                //{
                //    Versions.Add(version);
                //}

                string name = "";
                using (StreamReader sr = new StreamReader(file))
                {
                    string thisLine = "";
                    while (thisLine != null)
                    {
                        thisLine = sr.ReadLine();
                        if (thisLine == null)
                            break;

                        if (thisLine.Contains("<Name>") && thisLine.Contains("</Name>"))
                        {
                            name = thisLine.Replace("<Name>", "").Replace("</Name>", "");
                            continue;
                        }

                        if (thisLine.Contains("<Text>") && thisLine.Contains("</Text>"))
                        {
                            name = thisLine.Replace("<Text>", "").Replace("</Text>", "");
                            continue;
                        }
                    }
                }
                name = name.TrimStart('\t').TrimStart(' ').TrimEnd(' ');

                bool enabled = true;
                if (file.EndsWith(disabled))
                    enabled = false;

                Addin addin = new(name, version, file, enabled);
                Add(addin);
            }
        }
    }
}
