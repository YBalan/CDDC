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
            this.SuspendLayout();
            // 
            // bDataFolder
            // 
            this.bDataFolder.Location = new System.Drawing.Point(13, 61);
            this.bDataFolder.Name = "bDataFolder";
            this.bDataFolder.Size = new System.Drawing.Size(75, 23);
            this.bDataFolder.TabIndex = 0;
            this.bDataFolder.Text = "Data";
            this.bDataFolder.UseVisualStyleBackColor = true;
            // 
            // tDataFolder
            // 
            this.tDataFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tDataFolder.Location = new System.Drawing.Point(111, 62);
            this.tDataFolder.Name = "tDataFolder";
            this.tDataFolder.Size = new System.Drawing.Size(672, 20);
            this.tDataFolder.TabIndex = 1;
            // 
            // lDataLength
            // 
            this.lDataLength.AutoSize = true;
            this.lDataLength.Location = new System.Drawing.Point(14, 24);
            this.lDataLength.Name = "lDataLength";
            this.lDataLength.Size = new System.Drawing.Size(66, 13);
            this.lDataLength.TabIndex = 2;
            this.lDataLength.Text = "Data Length";
            // 
            // CD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lDataLength);
            this.Controls.Add(this.tDataFolder);
            this.Controls.Add(this.bDataFolder);
            this.Name = "CD";
            this.Text = "CD (compressing)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bDataFolder;
        private System.Windows.Forms.TextBox tDataFolder;
        private System.Windows.Forms.Label lDataLength;
    }
}

