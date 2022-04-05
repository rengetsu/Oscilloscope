using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oscilloscope
{
    /// <summary>
    /// Calibrations - class to calculate next big and small steps,  <br/>
    /// up and down for channels ant other calibrations.
    /// </summary>
    public class Calibrations
    {
        /// <summary>
        /// Channel standard text to return
        /// </summary>
        private string channel_txt = " mV/div";

        /// <summary>
        /// Channels standar values to change
        /// </summary>
        public double []channel = { 100, 100, 100, 100 };

        /// <summary>
        /// Channel Small Step Up
        /// </summary>
        /// <returns>Return next small step up in string format</returns>
        public string Channel_SmallStep_Up(int ch_nmbr)
        {
            // 10 mV .. 20 mV
            if (channel[ch_nmbr] >= 10 && channel[ch_nmbr] < 20)
            {
                channel[ch_nmbr] += 0.1;
            }
            // 20 mV .. 50 mV
            else if (channel[ch_nmbr] >= 20 && channel[ch_nmbr] < 50)
            {
                channel[ch_nmbr] += 0.2;
            }
            // 50 mV .. 100 mV
            else if (channel[ch_nmbr] >= 50 && channel[ch_nmbr] < 100)
            {
                channel[ch_nmbr] += 0.5;
            }
            // 100 mV .. 200 mV
            else if (channel[ch_nmbr] >= 100 && channel[ch_nmbr] < 200)
            {
                channel[ch_nmbr] += 1;
            }
            // 200 mV .. 250 mV
            else if (channel[ch_nmbr] >= 200 && channel[ch_nmbr] < 250)
            {
                channel[ch_nmbr] += 2;
            }
            //  Returning a new textbox value
            return channel[ch_nmbr].ToString() + channel_txt;
        }

        /// <summary>
        /// Channel Small Step Down
        /// </summary>
        /// <returns>Return next small step down in string format</returns>
        public string Channel_SmallStep_Down(int ch_nmbr)
        {
            // 10 mV .. 20 mV
            if (channel[ch_nmbr] > 10 && channel[ch_nmbr] <= 20)
            {
                channel[ch_nmbr] -= 0.1;
            }
            // 20 mV .. 50 mV
            else if (channel[ch_nmbr] > 20 && channel[ch_nmbr] <= 50)
            {
                channel[ch_nmbr] -= 0.2;
            }
            // 50 mV .. 100 mV
            else if (channel[ch_nmbr] > 50 && channel[ch_nmbr] <= 100)
            {
                channel[ch_nmbr] -= 0.5;
            }
            // 100 mV .. 200 mV
            else if (channel[ch_nmbr] > 100 && channel[ch_nmbr] <= 200)
            {
                channel[ch_nmbr] -= 1;
            }
            // 200 mV .. 250 mV
            else if (channel[ch_nmbr] > 200 && channel[ch_nmbr] <= 250)
            {
                channel[ch_nmbr] -= 2;
            }
            //  Returning a new textbox value
            return channel[ch_nmbr].ToString() + channel_txt;
        }

        /// <summary>
        /// Channel Big Step Up
        /// </summary>
        /// <returns>Return next big step up in string format</returns>
        public string Channel_BigStep_Up(int ch_nmbr)
        {
            // 10 mV .. 15 mV
            if (channel[ch_nmbr] >= 10 && channel[ch_nmbr] < 15)
            {
                channel[ch_nmbr] = 15;
            }
            // 15 mV .. 20 mV
            else if (channel[ch_nmbr] >= 15 && channel[ch_nmbr] < 20)
            {
                channel[ch_nmbr] = 20;
            }
            // 20 mV .. 25 mV
            else if (channel[ch_nmbr] >= 20 && channel[ch_nmbr] < 25)
            {
                channel[ch_nmbr] = 25;
            }
            // 25 mV .. 30 mV
            else if (channel[ch_nmbr] >= 25 && channel[ch_nmbr] < 30)
            {
                channel[ch_nmbr] = 30;
            }
            // 30 mV .. 40 mV
            else if (channel[ch_nmbr] >= 30 && channel[ch_nmbr] < 40)
            {
                channel[ch_nmbr] = 40;
            }
            // 40 mV .. 50 mV
            else if (channel[ch_nmbr] >= 40 && channel[ch_nmbr] < 50)
            {
                channel[ch_nmbr] = 50;
            }
            // 50 mV .. 60 mV
            else if (channel[ch_nmbr] >= 50 && channel[ch_nmbr] < 60)
            {
                channel[ch_nmbr] = 60;
            }
            // 60 mV .. 80 mV
            else if (channel[ch_nmbr] >= 60 && channel[ch_nmbr] < 80)
            {
                channel[ch_nmbr] = 80;
            }
            // 80 mV .. 100 mV
            else if (channel[ch_nmbr] >= 80 && channel[ch_nmbr] < 100)
            {
                channel[ch_nmbr] = 100;
            }
            // 100 mV .. 125 mV
            else if (channel[ch_nmbr] >= 100 && channel[ch_nmbr] < 125)
            {
                channel[ch_nmbr] = 125;
            }
            // 125 mV .. 150 mV
            else if (channel[ch_nmbr] >= 125 && channel[ch_nmbr] < 150)
            {
                channel[ch_nmbr] = 150;
            }
            // 150 mV .. 200 mV
            else if (channel[ch_nmbr] >= 150 && channel[ch_nmbr] < 200)
            {
                channel[ch_nmbr] = 200;
            }
            // 200 mV .. 250 mV
            else if (channel[ch_nmbr] >= 200 && channel[ch_nmbr] < 250)
            {
                channel[ch_nmbr] = 250;
            }
            //  Returning a new textbox value
            return channel[ch_nmbr].ToString() + channel_txt;
        }

        /// <summary>
        /// Channel Big Step Down
        /// </summary>
        /// <returns>Return next big step down in string format</returns>
        public string Channel_BigStep_Down(int ch_nmbr)
        {
            // 10 mV .. 15 mV
            if (channel[ch_nmbr] > 10 && channel[ch_nmbr] <= 15)
            {
                channel[ch_nmbr] = 10;
            }
            // 15 mV .. 20 mV
            else if (channel[ch_nmbr] > 15 && channel[ch_nmbr] <= 20)
            {
                channel[ch_nmbr] = 15;
            }
            // 20 mV .. 25 mV
            else if (channel[ch_nmbr] > 20 && channel[ch_nmbr] <= 25)
            {
                channel[ch_nmbr] = 20;
            }
            // 25 mV .. 30 mV
            else if (channel[ch_nmbr] > 25 && channel[ch_nmbr] <= 30)
            {
                channel[ch_nmbr] = 25;
            }
            // 30 mV .. 40 mV
            else if (channel[ch_nmbr] > 30 && channel[ch_nmbr] <= 40)
            {
                channel[ch_nmbr] = 30;
            }
            // 40 mV .. 50 mV
            else if (channel[ch_nmbr] > 40 && channel[ch_nmbr] <= 50)
            {
                channel[ch_nmbr] = 40;
            }
            // 50 mV .. 60 mV
            else if (channel[ch_nmbr] > 50 && channel[ch_nmbr] <= 60)
            {
                channel[ch_nmbr] = 50;
            }
            // 60 mV .. 80 mV
            else if (channel[ch_nmbr] > 60 && channel[ch_nmbr] <= 80)
            {
                channel[ch_nmbr] = 60;
            }
            // 80 mV .. 100 mV
            else if (channel[ch_nmbr] > 80 && channel[ch_nmbr] <= 100)
            {
                channel[ch_nmbr] = 80;
            }
            // 100 mV .. 125 mV
            else if (channel[ch_nmbr] > 100 && channel[ch_nmbr] <= 125)
            {
                channel[ch_nmbr] = 100;
            }
            // 125 mV .. 150 mV
            else if (channel[ch_nmbr] > 125 && channel[ch_nmbr] <= 150)
            {
                channel[ch_nmbr] = 125;
            }
            // 150 mV .. 200 mV
            else if (channel[ch_nmbr] > 150 && channel[ch_nmbr] <= 200)
            {
                channel[ch_nmbr] = 150;
            }
            // 200 mV .. 250 mV
            else if (channel[ch_nmbr] > 200 && channel[ch_nmbr] <= 250)
            {
                channel[ch_nmbr] = 200;
            }
            //  Returning a new textbox value
            return channel[ch_nmbr].ToString() + channel_txt;
        }
    }
}
