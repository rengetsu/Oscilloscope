using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oscilloscope
{
    public class Instruments
    {
        //  Constants for determining the current mode of the device 
        public readonly string cintUSB = "USB";
        public readonly string cintLAN = "LAN";
        public readonly string cintAuto = "AutoDetect";
        public readonly string cintDemo = "Demo";

        //  Until the automatic mode is created, the variable will be false
        public Boolean AutoCreated = false;
    }
}
