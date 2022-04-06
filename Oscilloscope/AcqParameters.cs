using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oscilloscope
{
    /// <summary>
    /// Acquire parameters
    /// </summary>
    public class AcqParameters
    {
        //  Variables 
        private double percent_start = 0, percent_end = 0;

        /// <summary>
        /// Return acquire parameter number
        /// </summary>
        /// <param name="FFine">Getting current number in the interpolator</param>
        /// <returns></returns>
        public int getAcqParameter_Number(int FFine)
        {
            int acqnumber = 0;

            if (FFine > 0 && FFine < 4095)
            {
                acqnumber = 1;
            }
            else if (FFine > 4095 && FFine < 8190)
            {
                acqnumber = 2;
            }
            else if (FFine > 8190 && FFine < 12285)
            {
                acqnumber = 3;
            }
            else if (FFine > 12286 && FFine < 16380)
            {
                acqnumber = 4;
            }
            else if (FFine > 16381 && FFine < 20475)
            {
                acqnumber = 5;
            }
            else if (FFine > 20476 && FFine < 24570)
            {
                acqnumber = 6;
            }
            else if (FFine > 24571 && FFine < 28665)
            {
                acqnumber = 7;
            }
            else if (FFine > 28666 && FFine < 32760)
            {
                acqnumber = 8;
            }
            else if (FFine > 32761 && FFine < 36855)
            {
                acqnumber = 9;
            }
            else if (FFine > 36856 && FFine < 40950)
            {
                acqnumber = 10;
            }
            else if (FFine > 40951 && FFine < 45045)
            {
                acqnumber = 11;
            }
            else if (FFine > 45046 && FFine < 49140)
            {
                acqnumber = 12;
            }
            else if (FFine > 49141 && FFine < 53235)
            {
                acqnumber = 13;
            }
            else if (FFine > 53236 && FFine < 57330)
            {
                acqnumber = 14;
            }
            else if (FFine > 57331 && FFine < 61425)
            {
                acqnumber = 15;
            }
            else if (FFine > 61426)
            {
                acqnumber = 16;
            }
            
            return acqnumber;
        }

        /// <summary>
        /// Return acquire parameter percent
        /// </summary>
        /// <param name="percent">Getting a percent</param>
        /// <param name="current">Getting current number in the interpolator</param>
        /// <param name="percent_end_cur">Getting current from acquisition parametr number percent end</param>
        /// <param name="percent_start_cur">Getting current from acquisition parametr number percent start</param>
        /// <returns></returns>
        public double getAcqParameter_Percents(int percent, double current, double percent_end_cur, double percent_start_cur)
        {
                percent_start   = current - percent_start_cur;
                percent_end     = percent_end_cur - percent_start_cur;
        
            double percent_ans = 100 / percent_end * (percent_end - percent_start);
            return percent_ans;
        }
    }
}
