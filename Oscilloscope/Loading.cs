using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

namespace Oscilloscope
{
    //  Main loading class
    public class Loading
    {
        /// <summary>
        /// Main loading method
        /// </summary>
        public void MainLoadMethod()
        {
            //  Including the bootloader class
            BootloaderLaunch BL = new BootloaderLaunch();

            //  Change mode to debug in bootloader
            BL.changeMode("Debug");

            //  Getting Loading Path in Bootloader and start program main process
            Process.Start(BL.getLoadPath());

            //  Including USB Interface
            USBInterface USBIntrf = new USBInterface();

            //  Start main USB
            if (USBIntrf.MainStartUsb() == true)
            {
                MessageBox.Show("Work");
            }
        }
    }
}
