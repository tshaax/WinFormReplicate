using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReplicateForm.Properties;

namespace ReplicateForm
{
    public partial class Replicate : Form
    {
        private FolderBrowserDialog folderBrowserDialog1;
        private static string _Path = string.Empty;

        public Replicate()
        {
            InitializeComponent();
            folderBrowserDialog1 = new FolderBrowserDialog();
        }  
     
        /// <summary>
        /// Source browse button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SourceBrowseBtn_Click(object sender, EventArgs e)
        {        
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {                              
                SetSourceText(folderBrowserDialog1.SelectedPath);
            }
        }

        /// <summary>
        /// Set the source file/folder
        /// </summary>
        /// <param name="text"></param>
        private void SetSourceText(string text)
        {
            sourcePathTxt.Text = text;
        }

        /// <summary>
        /// Set the destination file/folder
        /// </summary>
        /// <param name="text"></param>
        private void SetDestText(string text)
        {
            destPathTxt.Text = text;
        }

        /// <summary>
        /// Destination browse button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DestBrowseBtn_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                  SetDestText(folderBrowserDialog1.SelectedPath);
            }
        }

        /// <summary>
        /// button event to replicate
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReplicateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var source = sourcePathTxt.Text ?? Settings.Default.SourcePath;
                var dest = destPathTxt.Text ?? Settings.Default.DestPath;
                var progress = progressBar.BeginInvoke(

                 new Action(async () =>
                 {
                     progressBar.Style = ProgressBarStyle.Marquee;
                     progressBar.Value = 50;
                     await Directories.CopyFolder(source, dest, subDirchkBox.Checked);
                     progressBar.Value = 0;
                 }
                 ));

                Reset();
            }
            catch (Exception ex)
            {

                LogControl.Write($"Error! {ex.Message}");
            }
                
         
        }

        /// <summary>
        /// View log file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnViewlog_Click(object sender, EventArgs e)
        {
            try
            {
                _Path = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);

                string LoggerFileName = Path.Combine(
                    _Path, "log.txt");
                System.Diagnostics.Process.Start("notepad.exe", LoggerFileName);
            }
            catch (Exception ex)
            {

                LogControl.Write($"Error! {ex.Message}");
            }
          
        }

        /// <summary>
        /// Exit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnExit_Click(object sender, EventArgs e)
        {
            Replicate.ActiveForm.Close();
        }

        /// <summary>
        /// Close Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Replicate_FormClosing(object sender, FormClosingEventArgs e)
        {
            Settings.Default.Save();
        }

        private void Reset()
        {
            destPathTxt.Clear();
            sourcePathTxt.Clear();
            progressBar.Value = 0;

        }
    }
}
