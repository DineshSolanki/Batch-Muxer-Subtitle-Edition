using System;
using System.IO;
using System.Windows.Forms;
using BatchMuxerNative.Modules;
using BatchMuxerNative.Properties;
using DaveChambers.FolderBrowserDialogEx;

namespace BatchMuxerNative
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            txtMkvPath.Text = Settings.Default.mkvmergePATH;
            chkAC.Checked = Settings.Default.autoClean;
            chkSC.Checked = Settings.Default.showCleanup;
            cmbSubLanguage.DataSource = Functions.CreateLanguageDt();
            cmbSubLanguage.DisplayMember = "Name";
            cmbSubLanguage.ValueMember = "Code";
            cmbSubLanguage.SelectedValue = Settings.Default.language;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!Functions.CheckPathAndLanguage(txtMkvPath.Text, cmbSubLanguage.SelectedValue.ToString())) return;
            Settings.Default.language = cmbSubLanguage.SelectedValue.ToString();
            Settings.Default.mkvmergePATH = txtMkvPath.Text;
            Settings.Default.autoClean = chkAC.Checked;
            Settings.Default.showCleanup = chkSC.Checked;
            Settings.Default.Save();
            Close();
        }

        private void txtMkvPath_MouseDoubleClick(object sender, MouseEventArgs e)
        {
           
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialogEx folder = new FolderBrowserDialogEx
            {
                Title = "locate mkvmerge.exe",
                ShowEditbox = true,
            };
            if (folder.ShowDialog(this) == DialogResult.OK)
            {
                if (!File.Exists(folder.SelectedPath + @"\mkvmerge.exe"))
                    MessageBox.Show("mkvmerge.exe not Found!");
                else
                {
                    txtMkvPath.Text = folder.SelectedPath;
                }
            }
        }
    }
}
