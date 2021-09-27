using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oscilloscope
{
    public class Handlers
    {
        public double GetValueForProgram(String Handler)
        {
            double Result = 1;
            if(Handler == "hnd_CalibrTbTuneFreqCounter")
            {
                Result = 0;
            }
            return Result;
        }
    }
}
