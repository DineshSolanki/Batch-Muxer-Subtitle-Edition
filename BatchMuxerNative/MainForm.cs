using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using BatchMuxerNative.Modules;
using BatchMuxerNative.Properties;
using DaveChambers.FolderBrowserDialogEx;

namespace BatchMuxerNative
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            btnCleanUp.Visible = Settings.Default.showCleanup;
        }

        private void txtFolderPath_TextChanged(object sender, EventArgs e)
        {
            if (Directory.Exists(txtFolderPath.Text))
            {
                btnMux.Enabled = true;
                var di = new DirectoryInfo(txtFolderPath.Text);
                try
                {
                    Globals.Fi = di.EnumerateFiles()
                        .Where(f => Globals.Extensions.Contains(f.Extension.ToLower()))
                        .ToArray();
                    Functions.RenameFile();
                }
                catch (UnauthorizedAccessException exception)
                {
                    MessageBox.Show(exception.Message);
                    btnMux.Enabled = false;
                }

            }
            else
            {
                btnMux.Enabled = false;
            }
        }

        private void btnMux_Click(object sender, EventArgs e)
        {
            if (Functions.CheckPathAndLanguage(null,null,true))
            {
                //txtFolderPath.Enabled = false;
                progressBar1.Step = 1;
                progressBar1.Style = ProgressBarStyle.Continuous;
                progressBar1.Maximum = Globals.Fi.Length;
                progressBar1.Minimum = 0;
                progressBar1.Visible=true;
                backgroundWorker1.RunWorkerAsync();
                progressBar1.Value = 0;
            }
          
        }

        private void btnCleanUp_Click(object sender, EventArgs e)
        {
            Functions.DeleteAndMove(txtFolderPath.Text);
        }

        private void txtFolderPath_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            FolderBrowserDialogEx dlg = new FolderBrowserDialogEx()
            {
                Title="Open Folder",
               ShowEditbox = true
            };
            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                txtFolderPath.Text = dlg.SelectedPath;
            }
        }

        private void MainForm_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.Data.GetDataPresent(DataFormats.FileDrop) ? DragDropEffects.Copy : DragDropEffects.None;
        }

        private void MainForm_DragDrop(object sender, DragEventArgs e)
        {
            var files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files != null && files.Length != 0)
                txtFolderPath.Text = files[0];
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            foreach (var fl in Globals.Fi)
            {
                Functions.ProcessFile(fl,txtFolderPath.Text);
                backgroundWorker1.ReportProgress(1);
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //txtFolderPath.Enabled = true;
            if (Settings.Default.autoClean)
                Functions.DeleteAndMove(txtFolderPath.Text);
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.PerformStep();
            progressBar1.Update();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SettingsForm s=new SettingsForm();
            s.ShowDialog();
            MainForm_Load(null,EventArgs.Empty);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        
    }
}
