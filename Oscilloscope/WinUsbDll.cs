using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oscilloscope
{
    public class WinUsbDll
    {
        bool DLLLoaded = false;

        public void LoadWinUSBDLL()
        {
            if (DLLLoaded == false)
            {
                DLLLoaded = true;
            }
        }
    }
}
