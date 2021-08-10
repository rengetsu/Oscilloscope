using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oscilloscope
{
    public class WinUSBConnect
    {
        WinUsbDll WinUsbDll = new WinUsbDll();

        bool Initialized = false;

        /// <summary>
        /// Windows USB Initialization function
        /// </summary>
        void WinUSB_Initialize()
        {
            if (Initialized == false)
            {
                try
                {
                    //  Trying to load WinUSB Dll
                    WinUsbDll.LoadWinUSBDLL();
                    Initialized = true;
                }
                catch (Exception ex)
                {
                    //  Error loading WinUSB Dll
                    throw new Exception(String.Format("Error loading WinUSB.dll. Make sure device USB driver is installed."), ex);
                }
            }
        }

        /// <summary>
        /// Function to open USB connection
        /// </summary>
        /// <param name="DevicePath">Get a device path value</param>
        public void WinUSB_Open(string DevicePath)
        {
            WinUSB_Initialize();
        }

        /// <summary>
        /// Function to reset Pipe
        /// </summary>
        /// <param name="PipeID">Pipe ID</param>
        public void WinUSB_ResetPipe(Byte PipeID)
        {

        }

        public void WinUSB_ReadPipe(Byte PipeID, Byte A, int Size, int Timeout)
        {

        }
    }
}
