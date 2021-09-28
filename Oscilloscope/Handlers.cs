using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oscilloscope
{
    /// <summary>
    /// Handlers class for work with all handlers in project. <br/>
    /// Very important file, edit only if you really need to! <br/>
    /// </summary>
    public class Handlers
    {
        //  TTB variables
        private static double ttbpRecLen;       //  ttbRecLen - variable for TTB Record Length
        private static double ttbpSmplRate;     //  ttbSmplRate - variable for TTB Smpl Rate
        private static double ttbpScale;        //  ttbpScale - variable for TTB Scale

        /// <summary>
        /// TTB Record Length Set and Get
        /// </summary>
        public double TtbpRecLen
        { 
            get => ttbpRecLen; 
            set => ttbpRecLen = value; 
        }

        /// <summary>
        /// TTB Sample Rate Set and Get
        /// </summary>
        public double TtbpSmplRate
        {
            get => ttbpSmplRate;
            set => ttbpSmplRate = value;
        }

        /// <summary>
        /// TTB Scale Set and Get
        /// </summary>
        public double TtbpScale
        {
            get => ttbpScale;
            set => ttbpScale = value;
        }

        /// <summary>
        /// TTB Parameters - Record Length, Sample Rate and Scale
        /// </summary>
        private double[] TTB_Params = { ttbpRecLen, ttbpSmplRate, ttbpScale };

        /// <summary>
        /// Get function for TTB Parameters - Record Length, Sample Rate and Scale
        /// </summary>
        /// <returns>Returns TTB Parameters - Record Length, Sample Rate and Scale</returns>
        public double[] TTB_Params_Get()
        {
            return TTB_Params;
        }
    }

    public class Handler
    {
        public Handler()
        {
        }

        public double GetValueForProgram(String Handler)
        {
            double Result = 1;
            if (Handler == "hnd_CalibrTbTuneFreqCounter")
            {
                Result = 0;
            }
            return Result;
        }
    }
}
