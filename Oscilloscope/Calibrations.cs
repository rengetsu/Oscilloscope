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
            if( channel_one >= 100 && channel_one < 200 )
            {
                channel_one += 1;
            }
            return channel_one.ToString() + channel_txt;
        }

        public string Channel_SmallStep_Down()
        {
            if (channel_one > 100 && channel_one <= 200)
            {
                channel_one -= 1;
            }
            return channel_one.ToString() + channel_txt;
        }

        public string Channel_BigStep_Up()
        {
            if (channel_one >= 100 && channel_one < 125)
            {
                channel_one = 125;
            }
            else if (channel_one >= 125 && channel_one < 150)
            {
                channel_one = 150;
            }
            else if (channel_one >= 150 && channel_one < 200)
            {
                channel_one = 200;
            }
            else if (channel_one >= 200 && channel_one < 250)
            {
                channel_one = 250;
            }
            return channel_one.ToString() + channel_txt;
        }

        public string Channel_BigStep_Down()
        {
            if (channel_one > 100 && channel_one <= 125)
            {
                channel_one = 100;
            }
            else if (channel_one > 125 && channel_one <= 150)
            {
                channel_one = 125;
            }
            else if (channel_one > 150 && channel_one <= 200)
            {
                channel_one = 150;
            }
            else if (channel_one > 200 && channel_one <= 250)
            {
                channel_one = 200;
            }
            return channel_one.ToString() + channel_txt;
        }
    }
}
