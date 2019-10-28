using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplicateForm
{
    /// <summary>
    /// Comapre Directories
    /// </summary>
    public static class Directories
    {
        /// <summary>
        /// Copy folder and files to destination
        /// </summary>
        /// <param name="sourceFolder"></param>
        /// <param name="destFolder"></param>
        /// <param name="includeSubDir"></param>
        public static async Task CopyFolder(string sourceFolder, string destFolder, bool includeSubDir)
        {
            try
            {

                if (Directory.Exists(destFolder) && !Directory.Exists(sourceFolder))
                {
                    Directory.Delete(destFolder);
                }

                if (!Directory.Exists(destFolder))
                {
                    Directory.CreateDirectory(destFolder);
                }

                if (includeSubDir)
                {

                    string[] folders = Directory.GetDirectories(sourceFolder);
                    foreach (string folder in folders)
                    {
                        string name = Path.GetFileName(folder);
                        string dest = Path.Combine(destFolder, name);

                        LogControl.Write($"Copy from: {folder} To: {dest}");
                        await CopyFolder(folder, dest, includeSubDir);
                    }
                }

                if (File.Exists(destFolder) && !File.Exists(sourceFolder))
                {
                    File.Delete(destFolder);

                }

                CopyFile(sourceFolder, destFolder);
            }
            catch (Exception ex)
            {
                LogControl.Write($"Error! {ex.Message}");
            }

        }

        public static void CopyFile(string sourceFile, string destinationFile) => File.Copy(sourceFile, destinationFile, true);

    }
}
