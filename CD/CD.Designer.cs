namespace CD
{
    partial class CD
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bDataFolder = new System.Windows.Forms.Button();
            this.tDataFolder = new System.Windows.Forms.TextBox();
            this.lDataLength = new System.Windows.Forms.Label();
            this.pProgress = new System.Windows.Forms.ProgressBar();
            this.bCancel = new System.Windows.Forms.Button();
            this.bRun = new System.Windows.Forms.Button();
            this.lTime = new System.Windows.Forms.Label();
            this.lPercentage = new System.Windows.Forms.Label();
            this.tDataSize = new System.Windows.Forms.MaskedTextBox();
            this.lSize = new System.Windows.Forms.Label();
            this.gSettings = new System.Windows.Forms.GroupBox();
            this.chkStatistic = new System.Windows.Forms.CheckBox();
            this.chkArchive = new System.Windows.Forms.CheckBox();
            this.chkSubtract = new System.Windows.Forms.CheckBox();
            this.chkChange = new System.Windows.Forms.CheckBox();
            this.dlgDataFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.gSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // bDataFolder
            // 
            this.bDataFolder.Location = new System.Drawing.Point(13, 61);
            this.bDataFolder.Name = "bDataFolder";
            this.bDataFolder.Size = new System.Drawing.Size(75, 23);
            this.bDataFolder.TabIndex = 0;
            this.bDataFolder.Text = "Data Folder";
            this.bDataFolder.UseVisualStyleBackColor = true;
            this.bDataFolder.Click += new System.EventHandler(this.bDataFolder_Click);
            // 
            // tDataFolder
            // 
            this.tDataFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tDataFolder.Location = new System.Drawing.Point(111, 62);
            this.tDataFolder.Name = "tDataFolder";
            this.tDataFolder.ReadOnly = true;
            this.tDataFolder.Size = new System.Drawing.Size(671, 20);
            this.tDataFolder.TabIndex = 1;
            // 
            // lDataLength
            // 
            this.lDataLength.AutoSize = true;
            this.lDataLength.Location = new System.Drawing.Point(14, 24);
            this.lDataLength.Name = "lDataLength";
            this.lDataLength.Size = new System.Drawing.Size(69, 13);
            this.lDataLength.TabIndex = 2;
            this.lDataLength.Text = "Data Length:";
            // 
            // pProgress
            // 
            this.pProgress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pProgress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pProgress.Location = new System.Drawing.Point(13, 322);
            this.pProgress.Name = "pProgress";
            this.pProgress.Size = new System.Drawing.Size(769, 47);
            this.pProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pProgress.TabIndex = 3;
            // 
            // bCancel
            // 
            this.bCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bCancel.Location = new System.Drawing.Point(12, 389);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(374, 42);
            this.bCancel.TabIndex = 4;
            this.bCancel.Text = "Cancel";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // bRun
            // 
            this.bRun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bRun.Location = new System.Drawing.Point(408, 389);
            this.bRun.Name = "bRun";
            this.bRun.Size = new System.Drawing.Size(374, 42);
            this.bRun.TabIndex = 4;
            this.bRun.Text = "Run";
            this.bRun.UseVisualStyleBackColor = true;
            this.bRun.Click += new System.EventHandler(this.bRun_Click);
            // 
            // lTime
            // 
            this.lTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lTime.AutoSize = true;
            this.lTime.Location = new System.Drawing.Point(13, 303);
            this.lTime.Name = "lTime";
            this.lTime.Size = new System.Drawing.Size(30, 13);
            this.lTime.TabIndex = 5;
            this.lTime.Text = "Time";
            // 
            // lPercentage
            // 
            this.lPercentage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lPercentage.AutoSize = true;
            this.lPercentage.Location = new System.Drawing.Point(767, 303);
            this.lPercentage.Name = "lPercentage";
            this.lPercentage.Size = new System.Drawing.Size(15, 13);
            this.lPercentage.TabIndex = 5;
            this.lPercentage.Text = "%";
            // 
            // tDataSize
            // 
            this.tDataSize.Location = new System.Drawing.Point(111, 21);
            this.tDataSize.Name = "tDataSize";
            this.tDataSize.Size = new System.Drawing.Size(132, 20);
            this.tDataSize.TabIndex = 6;
            this.tDataSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tDataSize.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt;
            this.tDataSize.ValidatingType = typeof(int);
            this.tDataSize.TextChanged += new System.EventHandler(this.tDataSize_Changed);
            // 
            // lSize
            // 
            this.lSize.AutoSize = true;
            this.lSize.Location = new System.Drawing.Point(250, 24);
            this.lSize.Name = "lSize";
            this.lSize.Size = new System.Drawing.Size(32, 13);
            this.lSize.TabIndex = 7;
            this.lSize.Text = "bytes";
            // 
            // gSettings
            // 
            this.gSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gSettings.Controls.Add(this.chkStatistic);
            this.gSettings.Controls.Add(this.chkArchive);
            this.gSettings.Controls.Add(this.chkSubtract);
            this.gSettings.Controls.Add(this.chkChange);
            this.gSettings.Location = new System.Drawing.Point(13, 91);
            this.gSettings.Name = "gSettings";
            this.gSettings.Size = new System.Drawing.Size(769, 95);
            this.gSettings.TabIndex = 8;
            this.gSettings.TabStop = false;
            this.gSettings.Text = "Settings";
            // 
            // chkStatistic
            // 
            this.chkStatistic.AutoSize = true;
            this.chkStatistic.Location = new System.Drawing.Point(98, 42);
            this.chkStatistic.Name = "chkStatistic";
            this.chkStatistic.Size = new System.Drawing.Size(63, 17);
            this.chkStatistic.TabIndex = 0;
            this.chkStatistic.Text = "Statistic";
            this.chkStatistic.UseVisualStyleBackColor = true;
            this.chkStatistic.Click += new System.EventHandler(this.chkSettingsChanged);
            // 
            // chkArchive
            // 
            this.chkArchive.AutoSize = true;
            this.chkArchive.Location = new System.Drawing.Point(6, 65);
            this.chkArchive.Name = "chkArchive";
            this.chkArchive.Size = new System.Drawing.Size(62, 17);
            this.chkArchive.TabIndex = 0;
            this.chkArchive.Text = "Archive";
            this.chkArchive.UseVisualStyleBackColor = true;
            this.chkArchive.Click += new System.EventHandler(this.chkSettingsChanged);
            // 
            // chkSubtract
            // 
            this.chkSubtract.AutoSize = true;
            this.chkSubtract.Location = new System.Drawing.Point(6, 42);
            this.chkSubtract.Name = "chkSubtract";
            this.chkSubtract.Size = new System.Drawing.Size(66, 17);
            this.chkSubtract.TabIndex = 0;
            this.chkSubtract.Text = "Subtract";
            this.chkSubtract.UseVisualStyleBackColor = true;
            this.chkSubtract.Click += new System.EventHandler(this.chkSettingsChanged);
            // 
            // chkChange
            // 
            this.chkChange.AutoSize = true;
            this.chkChange.Location = new System.Drawing.Point(6, 19);
            this.chkChange.Name = "chkChange";
            this.chkChange.Size = new System.Drawing.Size(63, 17);
            this.chkChange.TabIndex = 0;
            this.chkChange.Text = "Change";
            this.chkChange.UseVisualStyleBackColor = true;
            this.chkChange.Click += new System.EventHandler(this.chkSettingsChanged);
            // 
            // dlgDataFolder
            // 
            this.dlgDataFolder.ShowNewFolderButton = false;
            // 
            // CD
            // 
            this.AcceptButton = this.bRun;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 449);
            this.Controls.Add(this.gSettings);
            this.Controls.Add(this.lSize);
            this.Controls.Add(this.tDataSize);
            this.Controls.Add(this.lPercentage);
            this.Controls.Add(this.lTime);
            this.Controls.Add(this.bRun);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.pProgress);
            this.Controls.Add(this.lDataLength);
            this.Controls.Add(this.tDataFolder);
            this.Controls.Add(this.bDataFolder);
            this.MinimumSize = new System.Drawing.Size(815, 488);
            this.Name = "CD";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CD (compressing)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CD_FormClosing);
            this.gSettings.ResumeLayout(false);
            this.gSettings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bDataFolder;
        private System.Windows.Forms.TextBox tDataFolder;
        private System.Windows.Forms.Label lDataLength;
        private System.Windows.Forms.ProgressBar pProgress;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Button bRun;
        private System.Windows.Forms.Label lTime;
        private System.Windows.Forms.Label lPercentage;
        private System.Windows.Forms.MaskedTextBox tDataSize;
        private System.Windows.Forms.Label lSize;
        private System.Windows.Forms.GroupBox gSettings;
        private System.Windows.Forms.FolderBrowserDialog dlgDataFolder;
        private System.Windows.Forms.CheckBox chkStatistic;
        private System.Windows.Forms.CheckBox chkArchive;
        private System.Windows.Forms.CheckBox chkSubtract;
        private System.Windows.Forms.CheckBox chkChange;
    }
}

