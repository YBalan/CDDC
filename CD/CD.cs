using Models;
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

namespace CD
{
    public partial class CD : Form
    {
        private const string SETTINGS_FILE_NAME = "CD.ini";
        private SettingsModel Settings { get; set; }
        private readonly string SettingsFile;
        public CD()
        {
            InitializeComponent();
            SettingsFile = Path.Combine(Environment.CurrentDirectory, SETTINGS_FILE_NAME);
            Settings = SettingsModel.Deserialize(SettingsFile);

            UpdateSettingsControls();
        }

        private void bDataFolder_Click(object sender, EventArgs e)
        {
            dlgDataFolder.SelectedPath = Settings.DataFolder;
            if (dlgDataFolder.ShowDialog() == DialogResult.OK)
            {
                Settings.DataFolder = dlgDataFolder.SelectedPath;
                UpdateSettingsControls();
            }
        }

        private void UpdateSettingsControls()
        {
            tDataFolder.Text = Settings.DataFolder;
            tDataSize.Text = Settings.Size.ToString();
            chkChange.Checked = Settings.Change;
            chkSubtract.Checked = Settings.Subtract;
            chkArchive.Checked = Settings.Archive;
            chkStatistic.Checked = Settings.Statistic;
        }

        private void UpdateSettings()
        {
            Settings.DataFolder = tDataFolder.Text;
            
            Settings.Change = chkChange.Checked;
            Settings.Subtract = chkSubtract.Checked;
            Settings.Archive = chkArchive.Checked;
            Settings.Statistic = chkStatistic.Checked;
        }

        private void bRun_Click(object sender, EventArgs e)
        {

        }

        private void bCancel_Click(object sender, EventArgs e)
        {

        }

        private void tDataSize_Changed(object sender, EventArgs e)
        {
            if (int.TryParse(tDataSize.Text, out int value))
            {
                Settings.Size = value;
            }
        }

        private void chkSettingsChanged(object sender, EventArgs e)
        {
            UpdateSettings();
        }

        private void CD_FormClosing(object sender, FormClosingEventArgs e)
        {
            UpdateSettings();
            Settings.Serialize(SettingsFile);
        }
       
    }
}
