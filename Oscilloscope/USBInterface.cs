using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oscilloscope
{
    /// <summary>
    /// USB Interface Class
    /// </summary>
    public class USBInterface
    {
        //  Call WinUSB Class
        WinUSBConnect WinUSB = new WinUSBConnect();

        //  Result check
        bool result = false;

        //  Variable for reading pipe timeout
        int timeoutVar = 50;

        //  Device Path
        const string DevicePath = "usb#vid_0ce9&pid_1014#PS9400-2019#{15ad01f2-440d-4ca6-8867-3f9d1a960ead}";

        //  Pipe IDs
        byte PipeIDRead     =   0x81;       //  Pipe ID Byte to Read
        byte PipeIDWrite    =   0x01;       //  Pipe ID Byte to Write

        //  Byte array
        public byte A { get; private set; }

        public void ConnectionOn()
        {
            do
            {
                MainStartUsb();
            }
            while (true);
        }

        /// <summary>
        /// Get A array
        /// </summary>
        /// <returns></returns>
        private byte GetA()
        {
            A.Equals(InitializeByteArray(A));
            return A;
        }

        /// <summary>
        /// Initialize byte array
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        byte InitializeByteArray(byte a)
        {
            var A = new byte[65576];
            for (int i = 0; i < A.Length; i++)
            {
                A[i] = 0x20;
            }
            return a;
        }

        /// <summary>
        /// Function to get device path
        /// public string DevicePath    Device path const variable
        /// </summary>
        /// <returns>Return a device path value</returns>
        string getDevicePath()
        {
            string devicePath = DevicePath;
            return devicePath;
        }

        /// <summary>
        /// Function to return size of A
        /// </summary>
        /// <param name="A">Returning syze of A</param>
        /// <returns></returns>
        int getSyzeOfA(Byte A)
        {
            return 65576;
        }

        /// <summary>
        /// Main function to connect with USB
        /// </summary>
        /// <returns>Returning a true or false depending on whether it turned out to be connected via USB or not</returns>
        public bool MainStartUsb()
        {
            GetA();         //  Get A array
            result = true;  //  Give a positive result

            try
            {
                WinUSB.WinUSB_Open(getDevicePath());
                WinUSB.WinUSB_ResetPipe(PipeIDRead);
                WinUSB.WinUSB_ResetPipe(PipeIDWrite);
                try
                {
                    WinUSB.WinUSB_ReadPipe(PipeIDRead, A, getSyzeOfA(A), timeoutVar);
                }
                catch(Exception ex)
                {
                    //  If we failed to read the pipe
                    throw new Exception(String.Format("Can't read Windows USB Pipe!"), ex);
                }
            }
            catch(Exception ex)
            {
                //  If we failed to connect to USB
                result = false;     //  Give a negative result

                throw new Exception(String.Format("Can't read Windows USB Pipe!"), ex);
            }
            ConnectionOn();
            //  Returning a result
            return result;
        }
    }
}
