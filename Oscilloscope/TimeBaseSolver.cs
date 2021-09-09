using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oscilloscope
{
    public class TimeBaseSolver
    {
        // Время на точку АЦП, всегда 2 нс!!!
        // В RT реальная резолюция в Множитель раз больше (1 .. 4 000 000 000)
        // В Random реальная резолюция в Делитель раз меньше (2 .. 20 000)

        uint cAbsMinSmplRate = (uint)0.125;  // Resolution   8 s
        uint cAbsMinRandonSmplRate = (uint)1e9;    // Resolution   1 ns  - Минимальный Smpl Rate для рандома
        ulong cAbsMidSmplRate = (ulong)20E9;   // Resolution  50 ps
        ulong cAbsMaxRandomSmplRate = (ulong)5E12;   // Resolution 200 fs - Для конкретного прибора вычисляется в GetMaxSmplRate
        ulong cAbsMaxSmplRateLJ = (ulong)25E12;  // 2020-09-22   Resolution 100 fs - только для LJ! Для конкретного прибора вычисляется в GetMaxSmplRate
        ulong cAbsMaxSmplRateLJKost = (ulong)25E12;  // 2020-09-22   Resolution 50 fs - только для LJ! Для конкретного прибора вычисляется в GetMaxSmplRate
        ulong cAbsMaxRollSmplRate = (ulong)62.5e3; // Resolution 16 us  -  ROll 100 ms/ 62500 точек

        // 2020-09-23 константы мин. шкалы для рандома убрал - вычисляю мин. значение в GetMinRandomScale
        //  cAbsMinScale          = 10E-12;   //  Для конкретного прибора и режима - см. GetMinRandomScale
        //  cAbsMinScaleLJKost    = 2E-12;    // 2020-09-22   2 ps/ - только для LJ! Для конкретного прибора и режима - см. GetMinRandomScale
        //  cAbsMinScaleLJ        = 5E-12;    // 2020-09-22   2 ps/ - только для LJ! Для конкретного прибора и режима - см. GetMinRandomScale
        ulong cAbsMinScaleRT = (ulong)10E-9;
        ulong cAbsMinScaleAutoRT = (ulong)100E-9;      //  Мин. развертка для RT в режиме Auto
        ulong cAbsMinScaleRoll = (ulong)100.000E-3;
        ulong cAbsMidScale = (ulong)10E-9;
        uint cAbsMaxScale = 1000;

        uint cAbsMinRecLenRt = 50;
        uint cAbsMinRecLenAutoRt = 500;
        uint cMinRandomRecordLength = 500; // Мин число точек для Random
        uint cAbsMidRecLen = 2000;

        // 2019-11-08  - НАВОДИМ  порядок в  Roll
        uint cAbsMinRecLenRoll = 2000;
        uint cAbsMaxRecLenRoll = 62500;         //  82500 - Для получения сбоя инферфейса при Roll RL > 64К и передергивании параметров

        const int cRealMultipliersCount = 126; // до 20 ноября 2019 было 125;
                                               // Массив мномителей (коэффициентов децимации) реального времени


        // Для устранения бага 123 от 20 ноября 2019 пришлось ввести значение 160,
        // ибо такой коэффициент децимации необходим для 62500 точек при 2 ms/дел

        uint[] cRealMultipliers = new uint[] { 1, 2,
        4, 8, 12, 15, 16, 18, 20, 25, 30, 35, 40, 45, 50, 60, 75, 80, 100, 125,
        150,  160, 175, 200, 250, 300, 350, 400, 450, 500, 625, 750, 800, 1000, 1250,
        1500, 1750, 2000, 2500, 3000, 3500, 4000, 4500, 5000, 6250, 7500, 8000,
        10000, 12500, 15000, 17500, 20000, 25000, 30000, 35000, 40000, 45000, 50000,
        62500, 75000, 80000, 100000, 125000, 150000, 175000, 200000, 250000, 300000,
        350000, 400000, 450000, 500000, 625000, 750000, 800000, 1000000, 1250000,
        1500000, 1750000, 2000000, 2500000, 3000000, 3500000, 4000000, 4500000,
        5000000, 6250000, 7500000, 8000000, 10000000, 12500000, 15000000, 17500000,
        20000000, 25000000, 30000000, 35000000, 40000000, 45000000, 50000000,
        62500000, 75000000, 80000000, 100000000, 125000000, 150000000, 175000000,
        200000000, 250000000, 300000000, 350000000, 400000000, 450000000, 500000000,
        625000000, 750000000, 800000000, 1000000000, 1250000000, 1500000000,
        1750000000, 2000000000, 2500000000, 3000000000, 3500000000, 4000000000};

        const int cLastcorrectedMultiplierIndex = 34;   // до 20 ноября 2019 было 33;
                                                        // последний индекс в таблице cRealMultipliers, указывающий на
                                                        // мультиплеер M = cRealMultipliers[cLastcorrectedMultiplierIndex] (1250, или 2.5 мкс/точку).
                                                        // Это самый большой Multiplier, кля которого в приборе проводится
                                                        // коррекция дефекта триггера. Другими словами, значения Multiplier
                                                        // <= М должны всегда быть равными значениям из таблицы cRealMultipliers!!!
                                                        //  Note !!!  Для проверки правильности выбранного коэффициента проверьте значение
                                                        //  переменной CheckMaxCorrectedREsolutionMks_Pnt в конце секции инициализации
                                                        //  этого модуля. Значение должно быть 2.5 (мкс/точку).

        const int cRealMultipliersForScaleCount = 69;

        // Массив мномителей (коэффициентов децимации) реального времени
        uint[] cRealMultipliersForScale = new uint[] { 1, 2, 4, 8, 16, 25, 40, 50, 100, 125, 200, 250, 400, 500,
        625, 1000, 1250, 2000, 2500, 3000, 3500, 4000, 4500, 5000, 6250, 7500, 8000,
        10000, 12500, 15000, 17500, 20000, 25000, 40000, 50000, 62500, 100000,
        125000, 200000, 250000, 400000, 500000, 625000, 1000000, 1250000, 2000000,
        2500000, 4000000, 5000000, 6250000, 10000000, 12500000, 20000000, 25000000,
        40000000, 50000000, 62500000, 100000000, 125000000, 200000000, 250000000,
        400000000, 500000000, 625000000, 1000000000, 1250000000, 2000000000,
        2500000000, 4000000000 };



        //  Делители периода дискретизации = 2 ns для получения круглых значений Sample Rate
        const int cRandomDividersCount = 57;
        uint[] cRandomDividers = new uint[] {2, 3, 4,
        5, 8, 10, 12, 15, 16, 20, 25, 30, 35, 40, 45, 50, 60, 75, 80, 100, 125, 150,
        175, 200, 250, 300, 350, 400, 450, 500, 625, 750, 800, 1000, 1250, 1500,
        1750, 2000, 2500, 3000, 3500, 4000, 4500, 5000, 6250, 7500, 8000, 10000,
        12500, 15000, 17500, 20000, 25000, 30000, 40000, 45000, 50000 };

        const int cRandomDividersForScaleCount = 38;
        uint[] cRandomDividersForScale = new uint[] { 2, 4, 5, 8, 10, 16, 20, 25, 40, 50, 60, 75, 80, 100, 125,
        200, 250, 320, 400, 500, 625, 800, 1000, 1250, 2000, 2500, 3200, 4000, 5000,
        6250, 8000, 10000, 12500, 20000, 25000, 32000, 40000, 50000 };

        const int cRecordLengthsCount = 54;
        uint[] cRecordLengths = new uint[]  {50, 60,
        75, 80, 100, 125, 150, 175, 200, 250, 300, 350, 400, 450, 500, 625, 750,
        800, 1000, 1250, 1500, 1750, 2000, 2500, 3000, 3500, 4000, 4500, 5000, 6250,
        7500, 8000, 10000, 12500, 15000, 17500, 20000, 25000, 30000, 35000, 40000,
        45000, 50000, 62500, 75000, 80000, 100000, 125000, 150000, 175000,
        200000, 250000, 500000, 1000000};

        const int cRecordLengthsForScaleCount = 29;
        uint[] cRecordLengthsForScale = new uint[]  {50, 80, 100, 125, 200, 250, 400, 500, 625, 800, 1000, 1250,
        2000, 2500, 4000, 5000, 6250, 8000, 10000, 12500, 20000, 40000, 50000,
        62500, 80000, 100000, 125000, 200000, 250000};

        /// <summary>
        /// Get maximum of sample rate
        /// </summary>
        /// <returns>Return maximum of sample rate</returns>
        //  2020-09-22  2020-06-25 Привели в соответствие со спецификацией для Pico (было 5 TS/s вместо 2.5 TS/s)
        //  Для Элтестовских приборов оставили 5 TS/s
        double GetMaxSmplRate()
        {
            double Result;
            Result = 2E10;

            if ( Result > cAbsMaxRandomSmplRate )
            {
                Result = cAbsMaxRandomSmplRate;
            }

            return Result;
        }

        /// <summary>
        /// Get minimum of random scale
        /// </summary>
        /// <returns>Return minimum of random scale</returns>
        //  Ранее тут просто была константа, но похоже эта функция ни на что не влияет
        //  похоже мин. шкала просто определяется в программе как мин. резолюшн и мин. длина сигнала
        //  Однако при неправильном значении (из-за моей ошибки давала вел. > Max) - даёт ошибку!!!
        double GetMinRandomScale()
        {
            double SR;
            ulong RL;

            SR = GetMaxSmplRate();
            RL = cMinRandomRecordLength;

            double Result;
            Result = RL / SR / 10;

            return Result;
        }
    }
}
