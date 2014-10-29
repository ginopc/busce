using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using OpenNETCF.Desktop.Communication;

namespace BusCE
{
    public partial class MainForm : Form
    {
        // constanti locati
        private string localDestination = @"C:\scs\ordini";
        private string deviceSourceFolder = @"\";
        private string deviceFileSearchCriteria = "ORD*.TXT";
        private RAPI myRapi;

        public MainForm()
        {
            InitializeComponent();
            LocalPath.Text = localDestination;
            RemotePath.Text = deviceSourceFolder;
            RemoteFileFilter.Text = deviceFileSearchCriteria;
            progressBar.Maximum = 1;
            progressBar.Hide();
            DeviceStatus.Text = "waiting";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Abilito il check continuo dello stato del terminale
            statusImage.Image = imageList.Images[0];
            timer1.Enabled = true;
            myRapi = new RAPI();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (myRapi.DevicePresent)
            {
                DeviceStatus.Text = "CONNESSO";
                btnGetFiles.Enabled = true;
                statusImage.Image = imageList.Images[1]; // led verde
            }
            else
            {
                DeviceStatus.Text = "NON CONNESSO";
                btnGetFiles.Enabled = false;
                statusImage.Image = imageList.Images[2];
            }
        }

        private void btnGetFiles_Click(object sender, EventArgs e)
        {
            try
            {
                // Controllo se esiste la cartella di destinazione locale
                if (!Directory.Exists(LocalPath.Text))
                    Directory.CreateDirectory(LocalPath.Text);

                // Creo l'oggetto di cotrollo remoto
                if (myRapi.DevicePresent)
                {
                    myRapi.Connect();
                    var fileNames = myRapi.EnumerateFiles(Path.Combine(RemotePath.Text, RemoteFileFilter.Text));

                    // Conta i file trovati
                    int numFiles = 0;
                    foreach (var item in fileNames)
                        numFiles++;

                    if (numFiles == 0) {
                        MessageBox.Show("Nessun file da ricevere!");
                        return;
                    }

                    progressBar.Maximum = numFiles;
                    progressBar.Show();
                    foreach (FileInformation file in fileNames)
                    {
                        /*
                        if (file.FileAttributes == Convert.ToInt16((int) RAPI.RAPIFileAttributes.Normal));
                        {
                         * */
                            myRapi.CopyFileFromDevice(
                                Path.Combine(LocalPath.Text, file.FileName), // desktop path
                                Path.Combine(RemotePath.Text, file.FileName), // device path
                                true    // overwrite existing file
                            );
                        /*}*/
                        progressBar.Increment(1);
                        myRapi.DeleteDeviceFile(file.FileName);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Errore nell'accesso ai file locali");
                return;
            }
        }

        private void btnLocalPath_Click(object sender, EventArgs e)
        {
            LocalPath.Text = findPath();
        }

        private string findPath()
        {
            string result = "";
            FolderBrowserDialog dialog = new FolderBrowserDialog();

            if (dialog.ShowDialog() == DialogResult.Cancel) return result;

            if (dialog.SelectedPath.Length > 0)
            {
                return dialog.SelectedPath;
            }

            return result;
        }

        private void btnRemotePath_Click(object sender, EventArgs e)
        {
            RemotePath.Text = findPath();
        }
    }
}
