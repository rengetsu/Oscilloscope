using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oscilloscope
{
    public class SignalAcqRun
    {
        //  Calling Classes
        TimeBase TB = new TimeBase();                   //  TimeBase Class
        BaseTypes BT = new BaseTypes();                 //  BaseTypes Class
        TimeBaseSolver TBS = new TimeBaseSolver();      //  TimeBaseSolver Class
        RandomGenerator RG = new RandomGenerator();     //  Random Generator

        //  Variables for Debug
        public double DIG_dTime;    //  Вывод в TextBox DIG_dTime
        public double FIG_dTime;    //  Вывод в TextBox FIG_dTime
        public double   FIP_Float;  //  Вывод в TextBox FIP_Float
        public long     FIP_Min;    //  Вывод в FIP_Min
        public long     FIP_Scale;  //  Вывод в FIP_Scale

        Boolean TaktInterpolatorNotUse = false;
        Boolean Interpol_Noice1bitDepressed = true;

        UInt16 LastPointFineIP;  //  Для отладки


        int SettedPreTriggerPoints;
        readonly int cBeginValueOfDIP4 = 3;
        int[] AdditionalData = { 3, 14, 59, 26, 53, 0 };

        public bool IsRandomTB { get; private set; }

        /// <summary>
        /// Get ADC Frequency For Current Resolution
        /// case GetCurrentResolution of
        /// tres8bits:     Result := 1000000000;
        /// tres12bits:    Result :=  500000000;
        /// else {tres14bits}  Result :=  500000000; // Пока...
        /// </summary>
        /// <returns></returns>
        long Get_ADC_Freq_ForCurrentResolution()
        {
            long Result = 5000000000;       // 09/09/2021  Павел добавил 0
            return Result;
        }

        /// <summary>
        /// Get Physical Sample Rate
        /// </summary>
        /// <returns></returns>
        long Get_Physical_SampleRate()
        {
            long Result;
            if( TB.GET_TB_SampleMod() == TB.SmsRandom_Take )
            {
                Result = Get_ADC_Freq_ForCurrentResolution();
            }
            else
            {
                Result = TBS.TtbSmplRate;
            }
            return Result;
        }

        /// <summary>
        /// Get Real Time acquire period in nanoseconds
        /// </summary>
        /// <returns>Returns real time acquire period in nanoseconds</returns>
        Int64 Get_RT_ACQ_Period_ns()
        {
            //  Возвращает установленный период сбора реально-временных режимов в наносекундах
            Int64 Result = (long)Math.Round(1e10 / Get_Physical_SampleRate());
            return Result;
        }

        /// <summary>
        /// Check if device in fast random mode or not
        /// </summary>
        /// <returns>Returns true or false as an answer</returns>
        Boolean Device_In_FastRandom_Mode()
        {
            Boolean Result = IsRandomTB;
            return Result;
        }

        /// <summary>
        /// This function add fine interpolator code to Stats and returns interpolator values
        /// </summary>
        /// <param name="fineIP_Val"></param>
        /// <param name="fineIP_Min"></param>
        /// <param name="fineIP_Scale"></param>
        private long AddFineInterpCodeToStats_ReturnInterpolatorValues(ushort FineIP_Code, long FineIP_Low, long FineIP_Scale)
        {
            // Если задан режим авто-аджаст интерполятора либо проводится калибровка TB -
            // то Делает 2 задачи:
            // 1. Каждое новое значение интерполятора NewCode добавляет к статистике интерполятора;
            // 2. Когда статистики собрано достаточно и Если задан режим авто-аджаст интерполятора
            //    - то вычисляет по ней границы интерполятора,
            //    решает - приемлемы ли полученные новые значения, и если да - то
            //    вписывает их в хандлеры границ.
            // Далее считывает значения границ (новые или, если обновления не было - то старые),
            // и возвращает параметры интерполятора (нижнюю границу и размах)
            int FineIP_High = 0;
            int Part556;
            Boolean MustAcceptNewValuew;

            if(Device_In_FastRandom_Mode())
            {
                throw new NotImplementedException();
            }
            else
            {
                //  В ДАННЫЙ МОМЕНТ ПЕРЕПИСЫВАЮ ПРОЦЕДУРУ НО ОНА ВОЗВРАЩЯЕТ ПРАВИЛЬНЫЕ ЗНАЧЕНИЯ
            }

            FineIP_Scale = FineIP_High - FineIP_Low;
            return FineIP_Scale;
        }

        /// <summary>
        /// Check if interpolator is inverse
        /// </summary>
        /// <returns>Returns true or false if interpolator is inverse or not</returns>
        private bool IsInterpolator_Inverse()
        {
            bool Result = false;
            return Result;
        }

        /// <summary>
        /// Calculating First Point Time Traditional Interpolator
        /// </summary>
        /// <param name="DIP4"></param>
        /// <param name="FineIP_Val">Interpolator Value</param>
        /// <param name="WO_Interpol"></param>
        /// <returns></returns>
        double CalcFirstPointTime_TraditionalInterpolator(ulong DIP4, UInt16 FineIP_Val, bool WO_Interpol = false)
        {
            //  Обрабатывает коды интерполяторов - вычисляет Измеренное фактическое время первой точки сигнала -
            //  сдвиг конкретного сигнала относительно теоретического места по сигналам интерполятора,
            //  !!!  Должна обязательно вызываться ПОСЛЕ (!!!) CalculateParamsOfStartForAllChannels.
            //  2017-06-07 при WO_Interpol интерполятор не учитывается, например при усреднении!!!
            double Result = 0;
            double dTime;
            double Period_ns;
            double DigPart;  //  2016-01-28 - было byte - Работа с DIP4 "вешалась при времени на точку 1 мкс или более
            long FineIP_Min = 0;
            long FineIP_Scale = 0;
            int StrobesBetweenPeriods;    //  число стробов АЦП между двумя выборками (медленные развертки)
            double PhysPeriodOfStrobe;
            double Fine_dTime;
            double FloatFineIP;
            Boolean InverseInterpolator;
            
            LastPointFineIP = FineIP_Val;

            Period_ns = Get_RT_ACQ_Period_ns();

            dTime = 0;

            //  Обнуляем переменные служажие для вывода значений в TextBox
            DIG_dTime = 0;
            FIG_dTime = 0;

            if (TaktInterpolatorNotUse)
            {
                //  В случае попадания в отсутствие такта интерполятора приравниваем значение к 555
                DIG_dTime = 555;

                // Цифрофой интерполятор между выборками НЕ истпользуем!
                //  2020-06-02  как я понял (вспомнил), что при коэфф. децимации (или
                //  StrobesBetweenPeriods) = 1 (что соответствует 500 MHz частоте стробирования)
                //  цифровой интерполятор учитывается в нижней программе при считывании сигнала
                //  из FPGA; тут же DigPart будет 0, так как StrobesBetweenPeriods = 1.
                //  а вот при децимациях (StrobesBetweenPeriods) > 1 в нижней программе отработается
                //  только старшая часть цифрового интерполятора (целая часть от DIP4 div
                //  StrobesBetweenPeriods), остаток же от деления (который равен числу периодов
                //  500 MHz клока между триггером и очередной выборкой AЦП)
            }
            else
            {
                StrobesBetweenPeriods = (int)(Period_ns / (BT.GetADC_Period() * 1E9)); //  (0.2) ADC Period in nanoseconds

                if (FineIP_Val != BT.GetSpecCode_NotTriggerFlag())
                {
                    DigPart = (Int32)DIP4 % StrobesBetweenPeriods;
                }
                else
                {
                    DigPart = RG.RandomGen(0, StrobesBetweenPeriods);
                }
                
                //  Set dTime
                DIG_dTime = BT.GetFIP_Period() * DigPart;
                dTime = dTime + DIG_dTime;

                //  16/09/2021  Отправка в вывод в TextBox DIG_dTime
                DIG_dTime = dTime;
            }

            // Время плавной части интерполятора (Теперь 2015-12-29 независимо от цифрового)
            if (TaktInterpolatorNotUse)
            {
                // dTime не меняется!

                //  В случае попадания в отсутствие такта интерполятора приравниваем значение к 555
                FIG_dTime = 777;
            }
            else
            {
                if (FineIP_Val != BT.GetSpecCode_NotTriggerFlag())
                {
                    AddFineInterpCodeToStats_ReturnInterpolatorValues(FineIP_Val, FineIP_Min, FineIP_Scale);

                    if (FineIP_Scale < 1000)
                    {
                        FineIP_Scale = 1000;
                    }

                    //        {$IFDEF PULT}
                    //          if Assigned(frmPultParamSbora) and frmPultParamSbora.Visible then
                    //            frmPultParamSbora.SetInterpAmplitude(ScaleValue);
                    //        {$ENDIF}

                    //  2018-10-17
                    if (Interpol_Noice1bitDepressed)
                    {
                        FloatFineIP = FineIP_Val;             //  Нет добавления шума в 1 квант АЦП интерполятора
                    }
                    else
                    {
                        FloatFineIP = FineIP_Val + RG.RandomGenDouble();   //  Добавляется шума в 1 квант АЦП интерполятора
                        // End 2018-10-17
                    }

                    InverseInterpolator = IsInterpolator_Inverse();

                    if (InverseInterpolator)
                    {
                        // 2017-10-03 инверсия плавного интерполятора          //  2018-10-17
                    Fine_dTime = BT.GetFIP_Period() * ( 1 - (FloatFineIP - FineIP_Min) / FineIP_Scale);
                    }
                    else
                    {
                        // 2016-05-10 плавный интерполятор перекрывает 2 нс!                //  2018-10-17
                        Fine_dTime = (BT.GetFIP_Period() * (FloatFineIP - FineIP_Min) / FineIP_Scale);
                    }

                    //  16/09/2021  Вывод для проверки
                    FIP_Float = FloatFineIP;
                    FIP_Min   = FineIP_Min;
                    FIP_Scale = FineIP_Scale;

                    dTime = dTime + Fine_dTime;

                    //  16/09/2021  Отправка в вывод в TextBox FIG_dTime
                    FIG_dTime = Fine_dTime;
                }
                else
                {
                    //  Включаем рандом для имитации работы интерполятора при отсутствии синхронизации
                    // 2016-05-10 Теперь плавный интерполятор перекрывает не 1 нс, а 2 нс!  FineCode := ZeroValue + Trunc(Analog/1e-9 * ScaleValue);
                    dTime = dTime + BT.GetADC_Period() * RG.RandomGenDouble();
                }
            }
            //  физическое значение периода точек, s  (Для Random - в каждом частном сборе)
            PhysPeriodOfStrobe = 1 / Get_Physical_SampleRate();
            DIG_dTime = dTime;
            Result = -(SettedPreTriggerPoints * PhysPeriodOfStrobe) + dTime;
            //  Returns the result 
            return Result;
        }
        
        /// <summary>
        /// Decode Interpolator Data
        /// </summary>
        /// <param name="_FineIP">Fine Interpolator</param>
        /// <param name="_DigIP">Digital Interpolator</param>
        void DecodeInterpolatorData(int _FineIP, int _DigIP)
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
    }
}
