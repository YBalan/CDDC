using CDDC.Compress;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CD
{
    public partial class CD : Form
    {
        private const string SETTINGS_FILE_NAME = "CD.config";
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

        private async void bRun_Click(object sender, EventArgs e)
        {
            //IProgress<float> progress = new Progress<float>(value => { pProgress.Value = (int)value; lPercentage.Text = value.ToString() + "%"; });
            //await Task.Run(() =>
            //{
            //    for (float i = 0; i <= 100; i++)
            //    {
            //        Thread.Sleep(25);
            //        if (pProgress.InvokeRequired)
            //        {
            //            pProgress.Invoke(new Action(() => pProgress.Value = (int)i));
            //            pProgress.Invoke(new MethodInvoker(() => pProgress.Value = (int)i));
            //        }
            //        progress.Report(i);
            //    }
            //});

            if (ValidateSettings())
            {
                var recursivly = false;
                var files = Directory.GetFiles(Settings.DataFolder, "*.txt", recursivly ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly).
                            Select(f => new FileInfo(f)).Where(fi => fi.Length <= Settings.DataSize).AsParallel();

                var cts = new CancellationTokenSource();
                var token = cts.Token;

                var options = new ParallelOptions
                {
                    CancellationToken = cts.Token,
                    MaxDegreeOfParallelism = int.MaxValue,
                };


                await Task.Run(async () =>
                {                    
                    var parallelLoopResult = Parallel.ForEach(files, options,
                        (fi, ls, index) =>
                        {
                            
                        }
                        );

                    if (parallelLoopResult.IsCompleted && !token.IsCancellationRequested)
                    {
                        IProgress<CD7ZipProgress> archiveProgress = new Progress<CD7ZipProgress>(p => { pProgress.Value = (int)p.PercentDone; lPercentage.Text = p.PercentDone.ToString() + "%"; });
                        await Task.Run(() =>
                        {
                            using (var archive = new FileStream("CD.dat", FileMode.OpenOrCreate))
                            {
                                CD7Zip.CompressFiles(archive, files.Select(fi => fi.FullName).ToArray(), archiveProgress);
                            }
                        }, cts.Token);
                    }
                }, cts.Token);
            }
            //
        }

        private bool ValidateSettings()
        {
            throw new NotImplementedException();
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            pProgress.Value = 0;
            lPercentage.Text = "%";
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
