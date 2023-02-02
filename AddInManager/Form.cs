using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace AddInManager
{
    public partial class Form: System.Windows.Forms.Form
    {
        public static string disabled = ".disabled";
        /// <summary>
        /// <see cref="https://learn.microsoft.com/zh-cn/dotnet/standard/base-types/character-classes-in-regular-expressions"/>
        /// 匹配三个十进制数字：\d{4}
        /// 匹配零个、一个或多个非十进制字符：\D*
        /// </summary>
        string pattern = @"\d{4}\D*";
        public Form()
        {
            InitializeComponent();

            cboVersion.Items.Add("<all>");
            cboVersion.SelectedIndex = 0;
            buildGrid();
        }

        private void buildGrid()
        {
            dataGridView1.Rows.Clear();
            IList<string> paths = new List<string>();
            paths.Add(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), "Autodesk", "Revit", "Addins"));
            paths.Add(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), "Autodesk", "ApplicationPlugins"));
            paths.Add(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Autodesk", "Revit", "Addins"));
            IList<string> files = new List<string>();
            foreach (string path in paths)
            {
                try
                {
                    string[] foo = Directory.GetFiles(path, "*.addin", SearchOption.AllDirectories);
                    foreach (string f in foo)
                    {
                        files.Add(f);
                    }
                }
                catch
                { }
            }
            foreach (string path in paths)
            {
                try
                {
                    string[] foo = Directory.GetFiles(path, "*.addin" + disabled, SearchOption.AllDirectories);
                    foreach (string f in foo)
                    {
                        files.Add(f);
                    }
                }
                catch
                { }
            }
            foreach (string file in files)
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
                            break;
                        }

                        if (thisLine.Contains("<Text>") && thisLine.Contains("</Text>"))
                        {
                            name = thisLine.Replace("<Text>", "").Replace("</Text>", "");
                            break;
                        }
                    }
                }
                name = name.TrimStart(' ').TrimEnd(' ');

                string enabled = "";
                if (file.EndsWith(disabled))
                    enabled = "no";
                else
                    enabled = "yes";

                if (version == cboVersion.Text || cboVersion.Text == "<all>")
                    dataGridView1.Rows.Add(new string[] { name, enabled, version, user, file });

                if (!cboVersion.Items.Contains(version))
                {
                    cboVersion.Items.Add(version);
                }
            }


        }

        private void btnEnDis_Click(object sender, EventArgs e)
        {

            string readonlyfiles = "";
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                string filename = row.Cells["AddinPath"].Value.ToString();
                if (File.Exists(filename))
                {
                    FileInfo fi = new FileInfo(filename);
                    if (fi.IsReadOnly)
                    {
                        readonlyfiles += filename + Environment.NewLine;
                    }
                    else
                    {
                        try
                        {
                            if (filename.EndsWith(disabled))
                            {
                                string nodis = filename.Replace(disabled, "");
                                File.Copy(filename, nodis);
                                File.Delete(filename);
                            }
                            else
                            {
                                File.Copy(filename, filename + disabled);
                                File.Delete(filename);
                            }
                        }
                        catch
                        {
                            readonlyfiles += filename + Environment.NewLine;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("File does not exist: " + filename);
                }
            }
            if (readonlyfiles != "")
            {
                MessageBox.Show("Cannot rename these files." + Environment.NewLine + readonlyfiles);
            }
            buildGrid();
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Selected = true;
            }
        }

        private void btnInvert_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Selected)
                    row.Selected = false;
                else
                    row.Selected = true;
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            List<string> dirs = new List<string>();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Selected)
                {
                    //var dir = Path.GetDirectoryName(row.Cells[4].Value.ToString());
                    //System.Diagnostics.Process.Start("explorer.exe", dir);
                    var dir = row.Cells[4].Value.ToString();
                    dirs.Add(dir);
                }
            }
            OpenExplorer.OpenFolderAndSelectedFiles(dirs);
        }

        private void btnSelEnabled_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                string enabled = row.Cells["IsEnabled"].Value.ToString();
                if (enabled == "yes")
                    row.Selected = true;
                else
                    row.Selected = false;
            }
        }

        private void btnSelDis_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                string enabled = row.Cells["IsEnabled"].Value.ToString();
                if (enabled == "no")
                    row.Selected = true;
                else
                    row.Selected = false;
            }
        }

        private void cboVersion_SelectedIndexChanged(object sender, EventArgs e)
        {
            buildGrid();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            using (FormAbout form = new FormAbout())
            {
                form.ShowDialog();
            }
        }
    }
}
