namespace BusCE
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.DeviceStatus = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LocalPath = new System.Windows.Forms.TextBox();
            this.RemotePath = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.RemoteFileFilter = new System.Windows.Forms.TextBox();
            this.btnLocalPath = new System.Windows.Forms.Button();
            this.btnRemotePath = new System.Windows.Forms.Button();
            this.btnGetFiles = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.statusImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.statusImage)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Stato Terminale:";
            // 
            // DeviceStatus
            // 
            this.DeviceStatus.AutoSize = true;
            this.DeviceStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeviceStatus.Location = new System.Drawing.Point(133, 13);
            this.DeviceStatus.Name = "DeviceStatus";
            this.DeviceStatus.Size = new System.Drawing.Size(94, 13);
            this.DeviceStatus.TabIndex = 1;
            this.DeviceStatus.Text = "Non disponibile";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Percorso Locale:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Percorso Device:";
            // 
            // LocalPath
            // 
            this.LocalPath.Location = new System.Drawing.Point(106, 35);
            this.LocalPath.Name = "LocalPath";
            this.LocalPath.Size = new System.Drawing.Size(330, 20);
            this.LocalPath.TabIndex = 4;
            // 
            // RemotePath
            // 
            this.RemotePath.Location = new System.Drawing.Point(107, 62);
            this.RemotePath.Name = "RemotePath";
            this.RemotePath.Size = new System.Drawing.Size(330, 20);
            this.RemotePath.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Filtro Ricerca:";
            // 
            // RemoteFileFilter
            // 
            this.RemoteFileFilter.Location = new System.Drawing.Point(107, 88);
            this.RemoteFileFilter.Name = "RemoteFileFilter";
            this.RemoteFileFilter.Size = new System.Drawing.Size(100, 20);
            this.RemoteFileFilter.TabIndex = 7;
            // 
            // btnLocalPath
            // 
            this.btnLocalPath.Location = new System.Drawing.Point(444, 33);
            this.btnLocalPath.Name = "btnLocalPath";
            this.btnLocalPath.Size = new System.Drawing.Size(25, 23);
            this.btnLocalPath.TabIndex = 8;
            this.btnLocalPath.Text = "...";
            this.btnLocalPath.UseVisualStyleBackColor = true;
            this.btnLocalPath.Click += new System.EventHandler(this.btnLocalPath_Click);
            // 
            // btnRemotePath
            // 
            this.btnRemotePath.Location = new System.Drawing.Point(444, 62);
            this.btnRemotePath.Name = "btnRemotePath";
            this.btnRemotePath.Size = new System.Drawing.Size(25, 23);
            this.btnRemotePath.TabIndex = 9;
            this.btnRemotePath.Text = "...";
            this.btnRemotePath.UseVisualStyleBackColor = true;
            this.btnRemotePath.Click += new System.EventHandler(this.btnRemotePath_Click);
            // 
            // btnGetFiles
            // 
            this.btnGetFiles.Location = new System.Drawing.Point(16, 114);
            this.btnGetFiles.Name = "btnGetFiles";
            this.btnGetFiles.Size = new System.Drawing.Size(453, 57);
            this.btnGetFiles.TabIndex = 10;
            this.btnGetFiles.Text = "Ricevi Files";
            this.btnGetFiles.UseVisualStyleBackColor = true;
            this.btnGetFiles.Click += new System.EventHandler(this.btnGetFiles_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(213, 88);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(256, 20);
            this.progressBar.TabIndex = 11;
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "led-wait.png");
            this.imageList.Images.SetKeyName(1, "led-on.png");
            this.imageList.Images.SetKeyName(2, "led-off.png");
            // 
            // statusImage
            // 
            this.statusImage.Location = new System.Drawing.Point(107, 9);
            this.statusImage.Name = "statusImage";
            this.statusImage.Size = new System.Drawing.Size(20, 20);
            this.statusImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.statusImage.TabIndex = 12;
            this.statusImage.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(482, 177);
            this.Controls.Add(this.statusImage);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.btnGetFiles);
            this.Controls.Add(this.btnRemotePath);
            this.Controls.Add(this.btnLocalPath);
            this.Controls.Add(this.RemoteFileFilter);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.RemotePath);
            this.Controls.Add(this.LocalPath);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DeviceStatus);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "BusCE";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.statusImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label DeviceStatus;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox LocalPath;
        private System.Windows.Forms.TextBox RemotePath;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox RemoteFileFilter;
        private System.Windows.Forms.Button btnLocalPath;
        private System.Windows.Forms.Button btnRemotePath;
        private System.Windows.Forms.Button btnGetFiles;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.PictureBox statusImage;
    }
}

