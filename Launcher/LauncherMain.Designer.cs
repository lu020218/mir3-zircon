namespace Launcher
{
    partial class LauncherMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LauncherMain));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.RepairButton = new System.Windows.Forms.Button();
            this.StartGameButton = new System.Windows.Forms.Button();
            this.TotalProgressBar = new System.Windows.Forms.ProgressBar();
            this.labelControl3 = new System.Windows.Forms.Label();
            this.DownloadSizeLabel = new System.Windows.Forms.Label();
            this.labelControl1 = new System.Windows.Forms.Label();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.labelControl6 = new System.Windows.Forms.Label();
            this.DownloadSpeedLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(5, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(716, 308);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // RepairButton
            // 
            this.RepairButton.Location = new System.Drawing.Point(613, 332);
            this.RepairButton.Name = "RepairButton";
            this.RepairButton.Size = new System.Drawing.Size(101, 32);
            this.RepairButton.TabIndex = 1;
            this.RepairButton.Text = "Repair";
            this.RepairButton.UseVisualStyleBackColor = true;
            this.RepairButton.Click += new System.EventHandler(this.RepairButton_Click);
            // 
            // StartGameButton
            // 
            this.StartGameButton.Location = new System.Drawing.Point(614, 370);
            this.StartGameButton.Name = "StartGameButton";
            this.StartGameButton.Size = new System.Drawing.Size(100, 32);
            this.StartGameButton.TabIndex = 2;
            this.StartGameButton.Text = "Start Game";
            this.StartGameButton.UseVisualStyleBackColor = true;
            this.StartGameButton.Click += new System.EventHandler(this.StartGameButton_Click);
            // 
            // TotalProgressBar
            // 
            this.TotalProgressBar.Location = new System.Drawing.Point(5, 384);
            this.TotalProgressBar.Name = "TotalProgressBar";
            this.TotalProgressBar.Size = new System.Drawing.Size(599, 18);
            this.TotalProgressBar.TabIndex = 3;
            // 
            // labelControl3
            // 
            this.labelControl3.AutoSize = true;
            this.labelControl3.Location = new System.Drawing.Point(12, 369);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(59, 12);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Download:";
            // 
            // DownloadSizeLabel
            // 
            this.DownloadSizeLabel.AutoSize = true;
            this.DownloadSizeLabel.Location = new System.Drawing.Point(84, 369);
            this.DownloadSizeLabel.Name = "DownloadSizeLabel";
            this.DownloadSizeLabel.Size = new System.Drawing.Size(0, 12);
            this.DownloadSizeLabel.TabIndex = 5;
            // 
            // labelControl1
            // 
            this.labelControl1.AutoSize = true;
            this.labelControl1.Location = new System.Drawing.Point(24, 342);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(47, 12);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "Status:";
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(84, 342);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(0, 12);
            this.StatusLabel.TabIndex = 7;
            // 
            // labelControl6
            // 
            this.labelControl6.AutoSize = true;
            this.labelControl6.Location = new System.Drawing.Point(427, 369);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(95, 12);
            this.labelControl6.TabIndex = 8;
            this.labelControl6.Text = "Download Speed:";
            // 
            // DownloadSpeedLabel
            // 
            this.DownloadSpeedLabel.AutoSize = true;
            this.DownloadSpeedLabel.Location = new System.Drawing.Point(528, 369);
            this.DownloadSpeedLabel.Name = "DownloadSpeedLabel";
            this.DownloadSpeedLabel.Size = new System.Drawing.Size(0, 12);
            this.DownloadSpeedLabel.TabIndex = 9;
            // 
            // LauncherMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 414);
            this.Controls.Add(this.DownloadSpeedLabel);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.DownloadSizeLabel);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.TotalProgressBar);
            this.Controls.Add(this.StartGameButton);
            this.Controls.Add(this.RepairButton);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LauncherMain";
            this.Text = "Launcher";
            this.Load += new System.EventHandler(this.LauncherMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button RepairButton;
        private System.Windows.Forms.Button StartGameButton;
        private System.Windows.Forms.ProgressBar TotalProgressBar;
        private System.Windows.Forms.Label labelControl3;
        private System.Windows.Forms.Label DownloadSizeLabel;
        private System.Windows.Forms.Label labelControl1;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Label labelControl6;
        private System.Windows.Forms.Label DownloadSpeedLabel;
    }
}