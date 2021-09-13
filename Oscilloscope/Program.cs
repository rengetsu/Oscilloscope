using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oscilloscope
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //  Including the bootloader class
            BootloaderLaunch BL = new BootloaderLaunch();

            //  Change mode to debug in bootloader
            BL.changeMode("Debug");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Process.Start(BL.getLoadPath());
            //Application.Run(new Load());
        }
    }
}
