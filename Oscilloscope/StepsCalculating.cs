using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oscilloscope
{
    public class StepsCalculating
    {
        //  Step Type
        public enum StepType { tasmValueAbs, tasmValueRel, tasmAccurasy, tasm12510, tasm3456810, tasm24816, tasmNewScale};

        /// <summary>
        /// Increase Step
        /// </summary>
        /// <param name="step">Step type</param>
        public Double Increase(StepType step)
        {
            Double NewVal = 0;
            switch (step)
            {
                case StepType.tasmValueAbs:
                {
                    break;
                }
                case StepType.tasmValueRel:
                {
                    break;
                }
                case StepType.tasmAccurasy:
                {
                    break;
                }
                case StepType.tasm12510:
                {
                    break;
                }
                case StepType.tasm3456810:
                {
                    break;
                }
                case StepType.tasm24816:
                {
                    break;
                }
                case StepType.tasmNewScale:
                {
                    break;
                }
            }
            return NewVal;
        }

        /// <summary>
        /// Decrease Step
        /// </summary>
        /// <param name="step">Step type</param>
        public Double Decrease(Double CurrVal, StepType step)
        {
            Double NewVal = 0;
            switch(step)
            {
                case StepType.tasmValueAbs:
                {
                    break;
                }
                case StepType.tasmValueRel:
                {
                    break;
                }
                case StepType.tasmAccurasy:
                {
                    break;
                }
                case StepType.tasm12510:
                {
                    break;
                }
                case StepType.tasm3456810:
                {
                    break;
                }
                case StepType.tasm24816:
                {
                    break;
                }
                case StepType.tasmNewScale:
                {
                    if (CurrVal >= 0.1)
                    {
                        NewVal = ((Math.Round(CurrVal / 0.1)) - 1) * 0.1;
                    }
                    else
                    {
                        NewVal = ((Math.Round(CurrVal / 0.01)) - 1) * 0.01;
                    }
                    break;
                }
            }
            return NewVal;
        }
    }
}
