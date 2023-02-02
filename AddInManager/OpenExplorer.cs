using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AddInManager
{
    internal class OpenExplorer
    {
        /// <summary>
        /// 打开目录
        /// </summary>
        /// <param name="folderPath">目录路径（比如：C:\Users\Administrator\）</param>
        static void OpenFolder(string folderPath)
        {
            if (string.IsNullOrEmpty(folderPath)) return;

            Process process = new Process();
            ProcessStartInfo psi = new ProcessStartInfo("Explorer.exe");
            psi.Arguments = folderPath;
            process.StartInfo = psi;

            try
            {
                process.Start();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                process?.Close();

            }

        }

        /// <summary>
        /// 打开目录且选中文件
        /// </summary>
        /// <param name="filePathAndName">文件的路径和名称（比如：C:\Users\Administrator\test.txt）</param>
        public static void OpenFolderAndSelectedFile(string filePathAndName)
        {
            if (string.IsNullOrEmpty(filePathAndName)) return;

            Process process = new Process();
            ProcessStartInfo psi = new ProcessStartInfo("Explorer.exe");
            psi.Arguments = "/e,/select," + filePathAndName;
            process.StartInfo = psi;

            //process.StartInfo.UseShellExecute = true;
            try
            {
                process.Start();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                process?.Close();
            }
        }

        /// <summary>
        /// 打开目录且选中多个文件
        /// </summary>
        /// <param name="filePathsAndNames">文件的路径和名称（比如：C:\Users\Administrator\test1.txt、C:\Users\Administrator\test2.txt）</param>
        public static void OpenFolderAndSelectedFiles(List<string> filePathsAndNames)
        {
            if (!filePathsAndNames.Any()) return;
            //if (string.IsNullOrEmpty(filePathsAndNames)) return;
            //List<string> directories = new List<string>();
            //foreach (string filePath in filePathsAndNames) { if (string.IsNullOrEmpty(filePath)) continue; directories.Add(Path.GetDirectoryName(filePath)); }

            var dictionary = filePathsAndNames.GroupBy(x => Path.GetDirectoryName(x)).ToDictionary(x => x.Key, x => x.ToList());
            Process process = new Process();
            ProcessStartInfo psi = new ProcessStartInfo("Explorer.exe");

            for (int i = 0; i < dictionary.Keys.Count; i++)
            {
                psi.Arguments = "/e,/select," + string.Join(",",dictionary.ElementAt(i).Value);
                process.StartInfo = psi;

                //process.StartInfo.UseShellExecute = true;
                try
                {
                    process.Start();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    process?.Close();
                }
            }
        }

        /// <summary>
        /// 打开文件
        /// </summary>
        /// <param name="filePathAndName">文件的路径和名称（比如：C:\Users\Administrator\test.txt）</param>
        /// <param name="isWaitFileClose">是否等待文件关闭（true：表示等待）</param>
        static void OpenFile(string filePathAndName, bool isWaitFileClose = true)
        {
            Process process = new Process();
            ProcessStartInfo psi = new ProcessStartInfo(filePathAndName);
            process.StartInfo = psi;

            process.StartInfo.UseShellExecute = true;

            try
            {
                process.Start();

                //等待打开的程序关闭
                if (isWaitFileClose)
                {
                    process.WaitForExit();
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                process?.Close();

            }
        }
    }
}
