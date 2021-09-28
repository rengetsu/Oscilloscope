using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oscilloscope
{
    public class SignalAcqCalc
    {
        Handler HND = new Handler();
        const int cBeginValueOfDIP4 = 3;    //  Это мин. код нового цифрового интерполятора

        int[] AdditionalData = { 3, 14, 59, 26, 53, 0 };

        /// <summary>
        /// Decode Interpolator Data
        /// </summary>
        /// <param name="_FineIP">Fine Interpolator</param>
        /// <param name="_DigIP">Digital Interpolator</param>
        public void DecodeInterpolatorData(int _FineIP, int _DigIP)
        {
            // возвращает Плавный интьерполятор и Новый цифровой интерполятор  (FW ver. 02.02.03.00 or newer)
            // Выяснилось, что Саня иногда выдает код 9, а как было задумано - он должен быть не менее 10 (при этом cBeginValueOfDIP4 = 10)
            // Старая процедура превращала код 9 в 999. Новая будет превращать в 10010 - (код-cBeginValueOfDIP4). Таким образом,
            //  код 9 превратится в 99999, код 8 - в 99998 и т.д.
            int DP4 = AdditionalData[1] >> 16;
            if (DP4 == 0)
            {
                //  Если не было триггера - прибор возвращает 0 - превратим его в 555!!!
                _DigIP = 555;
            }
            else
            {
                if (DP4 < cBeginValueOfDIP4)
                {
                    //  Если не было триггера - прибор возвращает 0, может полуситься отрицательный результат!!!
                    _DigIP = 10000 + DP4;
                }
                else
                {
                    // Так как DP4 всегда > 3, раньше было > 10, это изменено для Arrow
                    _DigIP = DP4 - cBeginValueOfDIP4;
                }
            }
            // Плавный интерполятор
            _FineIP = AdditionalData[2];
        }

        /// <summary>
        /// Get Real Time Left Time of Screen
        /// </summary>
        /// <returns></returns>
        private double GetRT_LeftTimeOfScreen()
        {
            double Result = 1
                            + 1e-6
                            * HND.GetValueForProgram("hnd_CalibrTbTuneFreqCounter");
            return Result;
        }

        public void SetTimeOfFirstPointForAllRandomSignals(Double FirstPointTime)
        {
            //  2020-07-31 Устанавливает параметры собираемых пачек рандомного сбора по
            //  FirstPointTime - измеренному фактическому времени первой точки пачки
            //  Используется для быстрого Random-сбора

            //  Перменные используемые в процедуре
            Double LeftTimeOfScreen;
            Double PhysPeriodOfStrobe;
            Double aCorrFirstPointTime;
            Double FirstUsedPointTime;
            Double TimeBeforeLeftScrMargin;
            Double PeriodsBeforeLeftR;
            int aPntsBeforeLeft;
            Double RelativeTimeOfFirstUsedPoint;

            LeftTimeOfScreen = GetRT_LeftTimeOfScreen();

            PhysPeriodOfStrobe = 1;
        }
    }
}
