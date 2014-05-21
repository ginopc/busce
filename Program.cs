using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RAPIDemo
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static int Main(string[] args)
        {
            int result = 0;

            if (args.Length == 3)
            {
                Console.WriteLine("Ci sono {0} parametri", args.Length);
                DeviceCE device = new DeviceCE();

                // recupera i paramenti passati
                foreach (string arg in args)
                {
                    string par = arg.Split('=')[0];
                    string value = arg.Split('=')[1];
                    switch (par)
                    {
                        case "-lp":
                            device.localPath = value;
                            break;

                        case "-rp":
                            device.remotePath = value;
                            break;

                        case "-rf":
                            device.remoteFileSearch = value;
                            break;

                        default:
                            Console.WriteLine("Parametro {0} sconosciuto", arg);
                            result = -1;
                            break;
                    }
                }
                if ((device.localPath == null) && (device.remotePath == null) && (device.remoteFileSearch == null))
                    result = -1;
                else
                    result = device.getFiles();
            }
            else
            {
                Console.WriteLine("Argomenti non sufficienti. Apro la GUI");
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainForm());

                result = 0;
            }

            return result;
        }
    }
}
