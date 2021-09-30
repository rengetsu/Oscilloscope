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
        //  TimeBase handlers variables
        private static double ttbpRecLen;       //  ttbRecLen - variable for TTB Record Length
        private static double ttbpSmplRate;     //  ttbSmplRate - variable for TTB Smpl Rate
        private static double ttbpScale;        //  ttbpScale - variable for TTB Scale

        //  Sampling modes handlers variables
        private static bool smsRealTime = false;
        private static bool smsRandom = false;
        private static bool smsRoll = false;
        private static bool smsFullAuto = false;

        //  Sampling Mode number variable
        private int samplingModenumber = 0;

        /// <summary>
        /// TTB Record Length Get and Set
        /// </summary>
        public double TtbpRecLen
        { 
            get => ttbpRecLen; 
            set => ttbpRecLen = value; 
        }

        /// <summary>
        /// TTB Sample Rate Get and Set
        /// </summary>
        public double TtbpSmplRate
        {
            get => ttbpSmplRate;
            set => ttbpSmplRate = value;
        }

        /// <summary>
        /// TTB Scale Get and Set
        /// </summary>
        public double TtbpScale
        {
            get => ttbpScale;
            set => ttbpScale = value;
        }

        /// <summary>
        /// Current Sampling Mode Get and Set
        /// </summary>
        public bool FCurrentSamplingMode_
        {
            get
            {
                return TSamplingModeSelector[samplingModenumber]; 
            } 
            set => TSamplingModeSelector[samplingModenumber] = true; 
        }

        public String FCurrentSamplingMode()
        {
            String FCurrentSamplingMode;
            if(TSamplingModeSelector[0] == true)
            {
                return "SmsRealTime";
            }
            else if(TSamplingModeSelector[1] == true)
            {
                return "SmsRandom";
            }
            else if(TSamplingModeSelector[2] == true)
            {
                return "SmsRoll";
            }
            else if(TSamplingModeSelector[3] == true)
            {
                return "SmsFullAuto";
            }
            return FCurrentSamplingMode;
        }

        public void FCurrentSamplingMode_Set(String samplingMode)
        {
            if( samplingMode == "SmsRealTime" )
            {
                //  Select Real Time mode
                SmsRealTime = true;
                //  Deselect others
                SmsRandom = false;
                SmsRoll = false;
                SmsFullAuto = false;
            }
            else if( samplingMode == "SmsRandom" )
            {
                //  Select Random mode
                SmsRandom = true;
                //  Deselect others
                SmsRoll = false;
                SmsFullAuto = false;
                SmsRealTime = false;
            }
            else if( samplingMode == "SmsRoll" )
            {
                //  Select Roll mode
                SmsRoll = true;
                //  Deselect others
                SmsRandom = false;
                SmsRealTime = false;
                SmsFullAuto = false;
            }
            else if( samplingMode == "SmsFullAuto" )
            {
                //  Select FullAuto mode
                SmsFullAuto = true;
                //  Deselect others
                SmsRandom = false;
                SmsRoll = false;
                SmsRealTime = false;
            }
        }

        /// <summary>
        /// TimeBase Parameters - Record Length, Sample Rate and Scale
        /// </summary>
        private readonly double[] TTB_Params = { ttbpRecLen, ttbpSmplRate, ttbpScale };

        /// <summary>
        /// Sampling Mode Selector - Real Time, Random ET, Roll, Auto
        /// </summary>
        public readonly bool[] TSamplingModeSelector = { SmsRealTime, SmsRandom, SmsRoll, SmsFullAuto };

        public Boolean TTBSmplMode;

        public bool SmsRealTime_Take = SmsRealTime;
        public bool SmsRandom_Take = SmsRandom;
        public bool SmsRoll_Take = SmsRoll;
        public bool SmsFullAuto_Take = SmsFullAuto;

        //  SmsRealTime, SmsRandom, SmsRoll, SmsFullAuto
        public static bool SmsRealTime { get => smsRealTime; set => smsRealTime = false; }
        public static bool SmsRandom { get => smsRandom; set => smsRandom = false; }
        public static bool SmsRoll { get => smsRoll; set => smsRoll = false; }
        public static bool SmsFullAuto { get => smsFullAuto; set => smsFullAuto = false; }

        /// <summary>
        /// Get Current Sampling Mode
        /// </summary>
        /// <returns></returns>
        public int GetFCurrentSamplingMode() => FCurrentSamplingMode_ ? 1 : 0;

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
