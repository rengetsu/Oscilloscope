using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oscilloscope
{
    /// <summary>
    /// Arbitary Waveform Generator Class
    /// </summary>
    public class AWG
    {
        public DeviceInterface DevInt;

        //  Current value
        static int currentValue = 0;

        //  Min, Max, MinLower
        double cMinAmp = 0.01;
        int MaxHi = 10;
        int cMinLo = -10;

        //  Handlers for AWG Period and Width
        private Double[] hnd_AWG_Period;
        private Double[] hnd_AWG_Width;
        private Boolean[] WidthIsSetted;
        private int[] WidthSettedValue;

        public Boolean AWG_Checker = false;

        /// <summary>
        /// Function to get AWG Period
        /// </summary>
        /// <param name="aOut">AWG Output</param>
        /// <returns>Return current AWG Period</returns>
        Double GetAWG_Period(TAWG_Out aOut)
        {
            Double rez = hnd_AWG_Period[aOut.GetValueForProgram()];
            return rez;
        }

        Double GetAWG_Width(TAWG_Out aOut)
        {
            Double rez = 0;
            return rez;
        }

        /// <summary>
        /// Correcting width limits for AWG
        /// </summary>
        /// <param name="aOut">AWG Output</param>
        void CorrectWidthLimits(TAWG_Out aOut)
        {
            Double cMinPause = 25e-9;
            Double Period;
            Double Lim;
            Double Width;
            Boolean WidthNoUser;    //  "желаемую" длит. установить не удалось из-за ограничений периода

            //  Сохраняем полученный результат в локальную переменную
            int aOut_val = aOut.GetValueForProgram();

            Period = GetAWG_Period(aOut);
            Lim = Period - cMinPause;

            hnd_AWG_Width[aOut.GetValueForProgram()] = Lim;

            //  Если была запомнена "желанная" Width - попробуем её установить
            if ( WidthIsSetted[aOut_val])
            {
                hnd_AWG_Width[aOut_val] = WidthSettedValue[aOut_val];
            }

            //  Если не получилось - красим в бордовый!
            Width = GetAWG_Width(aOut);

            WidthNoUser = WidthIsSetted[aOut_val];

            //  Надо будет не забыть обновить хэндлер (щас обновляем его в другом месте)
        }

        /// <summary>
        /// AWG Check
        /// </summary>
        /// <returns></returns>
        public bool AWG_Check()
        {
            return AWG_Checker;
        }

        /// <summary>
        /// AWG main waveform menu update function after click
        /// </summary>
        /// <param name="ItemIndex">Number of clicked item in AWG menu</param>
        public void AWG_WaveformUpdate(int ItemIndex)
        {
            //  OFF
            if (ItemIndex == 1)
            {
                DevInt.SendCommantToTheUnit("GEN:AWG:WAV? OFF", false);
            }
            //  SINE
            else if (ItemIndex == 2)
            {
                DevInt.SendCommantToTheUnit("GEN:AWG:WAV? SINE", false);
            }
            //  SQUARE
            else if (ItemIndex == 3)
            {
                DevInt.SendCommantToTheUnit("GEN:AWG:WAV? SQUARE", false);
            }
            //  PULSE
            else if (ItemIndex == 4)
            {
                DevInt.SendCommantToTheUnit("GEN:AWG:WAV? PULSE", false);
            }
            //  RAMP
            else if (ItemIndex == 5)
            {
                DevInt.SendCommantToTheUnit("GEN:AWG:WAV? RAMP", false);
            }
            //  DC
            else if (ItemIndex == 6)
            {
                DevInt.SendCommantToTheUnit("GEN:AWG:WAV? DC", false);
            }
            //  PRBS
            else if (ItemIndex == 7)
            {
                DevInt.SendCommantToTheUnit("GEN:AWG:WAV? PRBS", false);
            }
            //  ARBITARY
            else if (ItemIndex == 8)
            {
                DevInt.SendCommantToTheUnit("GEN:AWG:WAV? ARBITARY", false);
            }
        }

        /// <summary>
        /// AWG Output
        /// </summary>
        private class TAWG_Out
        {
            /// <summary>
            /// Get Value For Program
            /// </summary>
            /// <returns>Returns value for program</returns>
            public int GetValueForProgram()
            {
                if (currentValue != 0)
                {
                    return currentValue;

                }
                else
                {
                    return 0;
                }
            }

            /// <summary>
            /// Change Value From Program
            /// </summary>
            /// <param name="newVal"></param>
            /// <returns>Returns value from program</returns>
            public int ChangeValueFromProgram(int newVal)
            {
                return newVal;
            }
        }
    }
}
