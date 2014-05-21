using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using OpenNETCF.Desktop.Communication;

namespace RAPIDemo
{
    class DeviceCE
    {
        public string localPath { get; set; }
        public string remotePath { get; set; }
        public string remoteFileSearch { get; set; }

        private RAPI myRAPI;

        public DeviceCE() {
            this.localPath = @"c:\";
            this.remotePath = @"\";
            this.remoteFileSearch = "*.DDD";
        }

        public DeviceCE(string localPath, string remotePath, string removeFileSearch)
        {
            this.localPath = localPath;
            this.remotePath = remotePath;
            this.remoteFileSearch = removeFileSearch;
        }

        public int getFiles(string localPath, string remotePath, string remoteFileSearch)
        {
            this.localPath = localPath;
            this.remotePath = remotePath;
            this.remoteFileSearch = remoteFileSearch;
            return getFiles();
        }

        public int getFiles()
        {
            this.myRAPI = new RAPI();

            try
            {
                // Controllo se esiste la cartella di destinazione locale
                if (!Directory.Exists(localPath))
                    Directory.CreateDirectory(localPath);

                // Creo l'oggetto di cotrollo remoto
                if (myRAPI.DevicePresent)
                {
                    myRAPI.Connect();
                    var fileNames = myRAPI.EnumerateFiles(Path.Combine(remotePath, remoteFileSearch));

                    // Conta i file trovati
                    int numFiles = 0;
                    foreach (var item in fileNames)
                        numFiles++;

                    if (numFiles == 0)
                        return 0;

                    foreach (FileInformation file in fileNames)
                    {
                        /*
                        if (file.FileAttributes == Convert.ToInt16((int) RAPI.RAPIFileAttributes.Normal));
                        {
                         * */
                        myRAPI.CopyFileFromDevice(
                            Path.Combine(localPath, file.FileName), // desktop path
                            Path.Combine(remotePath, file.FileName), // device path
                            true    // overwrite existing file
                        );
                        /*}*/
                        myRAPI.DeleteDeviceFile(file.FileName);
                    }
                }
            }
            catch
            {
                return 0;
            }
            return 0;
        }

        public bool isConnected()
        {
            bool result = false;

            if (myRAPI != null)
                result = myRAPI.DevicePresent;

            return result;
        }
    }
}
