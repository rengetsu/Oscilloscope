using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oscilloscope
{
    public class TimeBase
    {
        Channel CH;
        Handlers HNDS;
        TimeBaseSolver TBS;

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
        /// Get TimeBase Sample Mode
        /// </summary>
        /// <returns>Returns TimeBase Sample Mode</returns>
        public bool GET_TB_SampleMod()
        {
            // Выдает текущий режим ТВ - //  smsRealTime, smsRandom, smsRoll
            bool Result = TBS.GetCurrentSamplingMode(HNDS.GetFCurrentSamplingMode());
            return Result;
        }
    }
}
