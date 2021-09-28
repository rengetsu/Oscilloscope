﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oscilloscope
{
    public class TimeBase
    {
        Channel CH = new Channel();

        //  Private
        private int samplingModenumber = 0;

        //  Public
        
        public bool[] TSamplingModeSelector = new bool[] { SmsRealTime, SmsRandom, SmsRoll, SmsFullAuto };
        public Boolean TTBSmplMode;
        private static bool smsRealTime = false;
        private static bool smsRandom = false;
        private static bool smsRoll = false;
        private static bool smsFullAuto = false;

        /// <summary>
        /// Current Sampling Mode Get and Set
        /// </summary>
        public bool FCurrentSamplingMode
        {
            get { return TSamplingModeSelector[samplingModenumber]; }
            private set { TSamplingModeSelector[samplingModenumber] = true; } 
        }

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
        private int GetFCurrentSamplingMode() => FCurrentSamplingMode ? 1 : 0;

        public UInt64 Get_ADC_Freq_ForCurrentResulution()
        {
            UInt64 Result;
            if( CH.GetCountOfAcquiredChannels() == 2 )
            {
                Result = 2500000000;    // 09/09/2021  Павел добавил 0
            }
            else
            {
                Result = 5000000000;
            }
            return Result;
        }

        public Double Get_TB_SampleRate()
        {
            Double Result = 0;
            return Result;
        }

        /// <summary>
        /// Get Current Sampling Mode Function 
        /// </summary>
        /// <param name="fCurrentSamplingMode"></param>
        /// <returns></returns>
        private bool GetCurrentSamplingMode(int fCurrentSamplingMode)
        {
            bool Result = TSamplingModeSelector[fCurrentSamplingMode];
            return Result;
        }

        /// <summary>
        /// Get TimeBase Sample Mode
        /// </summary>
        /// <returns></returns>
        public bool GET_TB_SampleMod()
        {
            // Выдает текущий режим ТВ - //  smsRealTime, smsRandom, smsRoll
            bool Result = GetCurrentSamplingMode(GetFCurrentSamplingMode());
            return Result;
        }
    }
}
