using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Library;

namespace Launcher
{
    static class Program
    {
        public const string PatcherFileName = @".\Patcher.exe";

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ConfigReader.Load();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new LauncherMain());

            ConfigReader.Save();
        }
    }
}
