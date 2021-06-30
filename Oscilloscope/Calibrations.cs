using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oscilloscope
{
    public class Calibrations
    {
        private string channel_txt = " mV/div";

        public double channel_one = 100;

        public string Channel_SmallStep_Up()
        {
            if( channel_one >= 100 && channel_one <= 200 )
            {
                channel_one += 1;
            }
            return channel_one.ToString() + channel_txt;
        }
    }
}
