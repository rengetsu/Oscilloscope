using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oscilloscope
{
    public class AWG
    {
        static int currentValue = 0;

        double cMinAmp = 0.01;
        int MaxHi = 10;
        int cMinLo = -10;
        private Double[] hnd_AWG_Period;
        private Double[] hnd_AWG_Width;
        private Boolean[] WidthIsSetted;
        private int[] WidthSettedValue;

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
        /// AWG Output
        /// </summary>
        private class TAWG_Out
        {
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

            public int ChangeValueFromProgram(int newVal)
            {
                return newVal;
            }
        }
    }
}
