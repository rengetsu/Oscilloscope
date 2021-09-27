using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oscilloscope
{
    public class TimeBaseSolver
    {
        Channel CH = new Channel();
        BugFinderSearch BFS = new BugFinderSearch();

        //  Variables that we will use outside class
        public String FCurrentSamplingMode = "smsRandom";
        public double Resolution = 2E-10;
        public const double cADC_Period = 200E-12;

        // Текущее значение 2-х настоящих параметров
        double[] FParams = new double[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

        //
        //(************************************************************************)
        //(************************************************************************)
        //(**                                                                    **)
        //(**                                                                    **)
        //(**                           IMPLEMENTATION                           **)
        //(**                                                                    **)
        //(**                                                                    **)
        //(************************************************************************)
        //(************************************************************************)

        // Время на точку АЦП, всегда 2 нс!!!
        // В RT реальная резолюция в Множитель раз больше (1 .. 4 000 000 000)
        // В Random реальная резолюция в Делитель раз меньше (2 .. 20 000)

        const double cAbsMinSmplRate = 0.125;  // Resolution   8 s
        const double cAbsMinRandonSmplRate = 1e9;    // Resolution   1 ns  - Минимальный Smpl Rate для рандома
        const double cAbsMidSmplRate = 20E9;   // Resolution  50 ps
        const double cAbsMaxRandomSmplRate = 5E12;   // Resolution 200 fs - Для конкретного прибора вычисляется в GetMaxSmplRate
        const double cAbsMaxSmplRateLJ = 25E12;  // 2020-09-22   Resolution 100 fs - только для LJ! Для конкретного прибора вычисляется в GetMaxSmplRate
        const double cAbsMaxSmplRateLJKost = 25E12;  // 2020-09-22   Resolution 50 fs - только для LJ! Для конкретного прибора вычисляется в GetMaxSmplRate
        const double cAbsMaxRollSmplRate = 62.5e3; // Resolution 16 us  -  ROll 100 ms/ 62500 точек

        // 2020-09-23 константы мин. шкалы для рандома убрал - вычисляю мин. значение в GetMinRandomScale
        //  cAbsMinScale          = 10E-12;   //  Для конкретного прибора и режима - см. GetMinRandomScale
        //  cAbsMinScaleLJKost    = 2E-12;    // 2020-09-22   2 ps/ - только для LJ! Для конкретного прибора и режима - см. GetMinRandomScale
        //  cAbsMinScaleLJ        = 5E-12;    // 2020-09-22   2 ps/ - только для LJ! Для конкретного прибора и режима - см. GetMinRandomScale
        const double cAbsMinScaleRT = 10E-9;
        const double cAbsMinScaleAutoRT = 100E-9;      //  Мин. развертка для RT в режиме Auto
        const double cAbsMinScaleRoll = 100.000E-3;
        const double cAbsMidScale = 10E-9;
        const double cAbsMaxScale = 1000;

        const uint cAbsMinRecLenRt = 50;
        const uint cAbsMinRecLenAutoRt = 500;
        const uint cMinRandomRecordLength = 500; // Мин число точек для Random
        const uint cAbsMidRecLen = 2000;

        // 2019-11-08  - НАВОДИМ  порядок в  Roll
        const uint cAbsMinRecLenRoll = 2000;
        const uint cAbsMaxRecLenRoll = 62500;         //  82500 - Для получения сбоя инферфейса при Roll RL > 64К и передергивании параметров

        const int cRealMultipliersCount = 126; // до 20 ноября 2019 было 125;
                                               // Массив мномителей (коэффициентов децимации) реального времени


        // Для устранения бага 123 от 20 ноября 2019 пришлось ввести значение 160,
        // ибо такой коэффициент децимации необходим для 62500 точек при 2 ms/дел

        uint[] cRealMultipliers = new uint[] { 1, 2,
        4, 8, 16, 32, 33, 34, 35, 36, 38, 39, 40, 45, 50, 60, 75, 80, 100, 125,             //  4, 10, 12, 15, 16, 18, 20, 25, 30, 35, 40, 45, 50, 60, 75, 80, 100, 125
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
        uint[] cRealMultipliersForScale = new uint[] { 1, 2, 4, 8, 16, 32, 40, 50, 100, 125, 200, 250, 400, 500, // 1, 2, 4, 10, 20, 25, 40, 50, 100, 125, 200, 250, 400, 500,
        625, 1000, 1250, 2000, 2500, 3000, 3500, 4000, 4500, 5000, 6250, 7500, 8000,
        10000, 12500, 15000, 17500, 20000, 25000, 40000, 50000, 62500, 100000,
        125000, 200000, 250000, 400000, 500000, 625000, 1000000, 1250000, 2000000,
        2500000, 4000000, 5000000, 6250000, 10000000, 12500000, 20000000, 25000000,
        40000000, 50000000, 62500000, 100000000, 125000000, 200000000, 250000000,
        400000000, 500000000, 625000000, 1000000000, 1250000000, 2000000000,
        2500000000, 4000000000 };


        //  Делители периода дискретизации = 2 ns для получения круглых значений Sample Rate

        //  Random Dividers Count
        const int cRandomDividersCount = 57;
        uint[] cRandomDividers = new uint[] {2, 3, 4,
        5, 8, 10, 12, 15, 16, 20, 25, 30, 35, 40, 45, 50, 60, 75, 80, 100, 125, 150,
        175, 200, 250, 300, 350, 400, 450, 500, 625, 750, 800, 1000, 1250, 1500,
        1750, 2000, 2500, 3000, 3500, 4000, 4500, 5000, 6250, 7500, 8000, 10000,
        12500, 15000, 17500, 20000, 25000, 30000, 40000, 45000, 50000 };

        //  Random Dividers For Scale Count
        const int cRandomDividersForScaleCount = 38;
        uint[] cRandomDividersForScale = new uint[] { 2, 4, 5, 8, 10, 16, 20, 25, 40, 50, 60, 75, 80, 100, 125,
        200, 250, 320, 400, 500, 625, 800, 1000, 1250, 2000, 2500, 3200, 4000, 5000,
        6250, 8000, 10000, 12500, 20000, 25000, 32000, 40000, 50000 };

        //  Record Lengths Count
        const int cRecordLengthsCount = 54;
        uint[] cRecordLengths = new uint[]  {50, 60,
        75, 80, 100, 125, 150, 175, 200, 250, 300, 350, 400, 450, 500, 625, 750,
        800, 1000, 1250, 1500, 1750, 2000, 2500, 3000, 3500, 4000, 4500, 5000, 6250,
        7500, 8000, 10000, 12500, 15000, 17500, 20000, 25000, 30000, 35000, 40000,
        45000, 50000, 62500, 75000, 80000, 100000, 125000, 150000, 175000,
        200000, 250000, 500000, 1000000};

        //  Record Lengths For Scale Count
        const int cRecordLengthsForScaleCount = 29;
        uint[] cRecordLengthsForScale = new uint[]  {50, 80, 100, 125, 200, 250, 400, 500, 625, 800, 1000, 1250,
        2000, 2500, 4000, 5000, 6250, 8000, 10000, 12500, 20000, 40000, 50000,
        62500, 80000, 100000, 125000, 200000, 250000};

        public int TtbSmplRate { get; set; } = (int)_CalcSmpl_Rate(1, 1);

        /// Main function to calculate Scale, Record Length and Sample Rate

        /// <summary>
        /// Main function to calculate scale
        /// </summary>
        /// <param name="Rec_Len">Record Length</param>
        /// <param name="Smpl_Rate">Sample Rate</param>
        /// <returns>Returning calculcated Scale</returns>
        static double _CalcScale(ulong Rec_Len, Double Smpl_Rate)
        {
            double Result = Rec_Len / (Smpl_Rate * 10);

            //  Returns the result 
            return Result;
        }

        /// <summary>
        /// Main function to calcucale record length
        /// </summary>
        /// <param name="Scale">Scale</param>
        /// <param name="Smpl_Rate">Sample Rate</param>
        /// <returns>Returning calculated Record Length</returns>
        static double _CalcRec_Len(Double Scale, Double Smpl_Rate)
        {
            double Result = Scale * Smpl_Rate * 10;

            //  Returns the result 
            return Result;
        }

        /// <summary>
        /// Main function to calculate Sample Rate
        /// </summary>
        /// <param name="Rec_Len">Record Length</param>
        /// <param name="Scale">Scale</param>
        /// <returns>Returning calculated Sample Rate</returns>
        public static double _CalcSmpl_Rate(ulong Rec_Len, Double Scale)
        {
            double Result = Rec_Len / (Scale * 10);

            //  Returns the result 
            return Result;
        }

        /// <summary>
        /// Get maximum of sample rate
        /// </summary>
        /// <returns>Return maximum of sample rate</returns>
        //  2020-09-22  2020-06-25 Привели в соответствие со спецификацией для Pico (было 5 TS/s вместо 2.5 TS/s)
        //  Для Элтестовских приборов оставили 5 TS/s
        double GetMaxSmplRate()
        {
            //  Variables used in this function
            double Result;
            Result = 2E10;

            if ( Result > cAbsMaxRandomSmplRate )
            {
                Result = cAbsMaxRandomSmplRate;
            }
            //  Returns the result 
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
            //  Variables used in this function
            double SR;
            ulong RL;

            SR = GetMaxSmplRate();
            RL = cMinRandomRecordLength;

            double Result;
            Result = RL / SR / 10;
            //  Returns the result 
            return Result;
        }

        /// <summary>
        /// Calculating index
        /// </summary>
        /// <param name="Val">Value</param>
        /// <param name="M">M parametr, for now same for all</param>
        /// <returns>returning index</returns>
        int CalcIndex(Double Val, uint M)
        {
            //  Variables used in this function
            int iMin, iMax, i, i0, i1;
            double vi, v0, v1;
            
            iMin = 0;
            iMax = (int)M;

            i0 = iMin;
            i1 = iMax;
            i = iMax / 2;

            do
            {
                v0 = M;
                vi = M;

                if (Val < vi)
                {
                    i1 = i;
                    i = (i0 + i) / 2;
                }
                else
                {
                    i0 = i;

                    i = (i1 + i + 1) / 2;
                }
            } while (i1 - i0 <= 1);
            return i;
        }

        /// <summary>
        /// Get nearest multiplier
        /// </summary>
        /// <param name="Multiplier">Current multiplier</param>
        /// <param name="RealMultipliersIndex">Real index of current multiplier</param>
        /// <returns></returns>
        double GetNearMultiplier(double Multiplier)
        {
            //  Variables used in this function
            double Index, i0, Result;

            Index = CalcIndex(Multiplier, cRealMultipliers[cLastcorrectedMultiplierIndex]);

            i0 = Math.Truncate(Index + 0.01);

            int i0index = (int)Math.Round(i0);

            if (Index - i0 > 0.4)
            {
                Result = cRealMultipliers[i0index];
            }
            Result = Multiplier;

            //  Returns the result 
            return Result;
        }

        /// <summary>
        /// Resolution Corrected
        /// </summary>
        void ResolutionCorrected()
        {
            //  Variables used in this function
            Boolean Random;
            Double vDivider;
            int Divider;
            double vMultiplier;
            double Multiplier;
            ulong MaxTableMultiplier;
            Boolean OnlyFromTBTable;
            Boolean LimCorrected;
            Boolean Result;

            //  Random := Resolution < 1.42E-9;
            //  Assert(Random = (FCurrentSamplingMode = smsRandom), 'Резолюция конфликтует с Sample Mode');

            //  2019-02-27 Резолюция и будет конфликтовать с Cемпл моде при переключении семпл моды!
            if (FCurrentSamplingMode == "smsRandom")
            {
                Random = true;
            }
            else
            {
                Random = false;
            }
            FCurrentSamplingMode = "smsRandom";

            if(Random)
            {
                if (CH.GetCountOfAcquiredChannels() == 2)
                {
                    LimCorrected = Resolution > 5.01E-9;   
                }
                else
                {
                    LimCorrected = Resolution > 1.01E-10;   //  10/09/2021 Изменено Павлом для Arrow, было 1.01E-10
                }
                
                if (LimCorrected)                           //  2019-02-27
                {
                    if(CH.GetCountOfAcquiredChannels() == 2)
                    {
                        Resolution = 5E-9;                 
                    }
                    else
                    {
                        Resolution = 1E-10;                 //  10/09/2021 Изменено Павлом для Arrow, было 1E-10
                    }
                }

                vDivider = cADC_Period / Resolution;
                double forCheck = Math.Round(vDivider);
                Divider = (int)forCheck;
                if(Divider == 1)
                {
                    Divider++;
                }

                //  Returns the result
                Result = LimCorrected;
            }
            else
            {
                if (CH.GetCountOfAcquiredChannels() == 2)
                {
                    LimCorrected = Resolution < 0.99E-10;
                }
                else
                {
                    LimCorrected = Resolution < 1.99E-10;   //  10/09/2021 Изменено Павлом для Arrow, было 1.99E-10
                }

                if(LimCorrected)
                {
                    if (CH.GetCountOfAcquiredChannels() == 2)
                    {
                        Resolution = 1E-10;
                    }
                    else
                    {
                        Resolution = 2E-10;                 //  10/09/2021 Изменено Павлом для Arrow, было 2E-10
                    }
                    LimCorrected = true;
                }

                vMultiplier = Resolution / cADC_Period;
                //  Round(vMultiplier) - При малых Multiplier в половине случаев округлял резолюцию в бОльшую сторону, что уменьшало
                if (CH.GetCountOfAcquiredChannels() == 2)
                {
                    Multiplier = (uint)Math.Truncate(vMultiplier + 5e-4);
                }
                else
                {
                    Multiplier = (uint)Math.Truncate(vMultiplier + 1e-5);
                }

                if(Multiplier == 0)
                {
                    //BFS.BugFinderCall("");
                    Multiplier = 1;
                }

                //  Для отработки коррекции момента триггера по таблице MTriggerDefects
                //  Multiplier должен соответствовать точно значениям из cRealMultipliersCount
                //  (Это касается значений Multiplier менее или равному
                //  cRealMultipliersCount[cLastcorrectedMultiplierIndex])!

                MaxTableMultiplier = cRealMultipliers[cLastcorrectedMultiplierIndex];
                // последний индекс в таблице cRealMultipliers, указывающий на
                // мультиплеер M = cRealMultipliers[cLastcorrectedMultiplierIndex].
                // Это самый большой Multiplier, кля которого в приборе проводится
                // коррекция дефекта триггера. Другими словами, значения Multiplier
                // <= М должны всегда быть равными значениям из таблицы cRealMultipliers!!!

                OnlyFromTBTable = Multiplier <= MaxTableMultiplier;

                if(OnlyFromTBTable)
                {
                    Multiplier = GetNearMultiplier(Multiplier);
                }

                //Это Пятов писал ранее, без учета необходимости коррекции дефекта триггера
                //if (Multiplier > 2) and(Multiplier < 7) then
                //Multiplier := 4
                //else if (Multiplier >= 7) and(Multiplier < 11) then
                //Multiplier := 10;

                Result = LimCorrected;
                if(Result)
                {
                    Resolution = cADC_Period * Multiplier;
                }
            }
        }

        /// <summary>
        /// Check if difference is more than something
        /// </summary>
        /// <param name="V1">First parameter</param>
        /// <param name="V2">Second parameter</param>
        /// <param name="Diff">Difference between this two parameters</param>
        /// <returns>Returning a difference between this parameters as a result as answer yes/no like true/false</returns>
        private bool DifferMoreThan(double V1, double V2, double Diff)
        {
            bool Result;
            Result = Math.Abs(V1 - V2) > Diff;
            //  Returns the result
            return Result;
        }

        /// <summary>
        /// Check if difference if more than something in percents
        /// </summary>
        /// <param name="V1">First parameter</param>
        /// <param name="V2">Second parameter</param>
        /// <param name="Perc">Percent value</param>
        /// <returns>Returning a difference between this parameters as a result in percents as answer yes/no like true/false</returns>
        private bool DifferMoreThanPerc(double V1, double V2, double Perc)
        {
            bool Result;
            double differ;
            differ = Math.Max(Math.Abs(V1), Math.Abs(V2) * Perc / 100);
            //  Sending the difference to another function 
            Result = DifferMoreThan(V1, V2, differ);
            //  Returns the result 
            return Result;
        }

        /// <summary>
        /// Checking if solver related to sampling mode
        /// </summary>
        /// <returns>Return true/false if solver related or not</returns>
        Boolean CheckSolverSvjaznostj()
        {
            //  Variables used in this function
            Boolean Result;
            if ( FCurrentSamplingMode == "smsRandom" )
            {
                Result = FParams[TtbSmplRate] > 99999999990;
            }
            else
            {
                Result = FParams[(int)TtbSmplRate] < 50000000010;
            }

            if ( Result == true )
            {
                Result = DifferMoreThanPerc(FParams[TtbSmplRate] / 10 *
             (1 / FParams[TtbSmplRate]), FParams[TtbSmplRate], 1e-5);
            }
            //  Returns the result 
            return Result;
        }
    }
}
