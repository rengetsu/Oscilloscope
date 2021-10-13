using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oscilloscope
{
    /// <summary>
    /// Adjust Interpolator Class. <br/>
    /// Объект автоподстройки интерполятора. <br/>
    /// Принцип его работы - меряется гистограмма кодов интерполятора, которые поступают через procedure AddValue(). <br/>
    /// При завершении каждого сбора вызывается procedure EndOfSignal. <br/>
    /// </summary>
    public class Adjust_Interpolator
    {
        // Объект автоподстройки интерполятора
        //
        // Принцип его работы - меряется гистограмма кодов интерполятора,
        // которые поступают через procedure AddValue().
        //
        // При завершении каждого сбора вызывается procedure EndOfSignal.
        //

        //  2017-10-25 теперь автоподстройщик интерполятора заполняется при включении от
        //  быстрого сигнала 500 кГц в рандомном режиме во время калибровки временной базы.
        //  Возможно, что после окончания калибровки заполнение автоподстройщика будет
        //  вообще заблокировано (в вызывающей программе??)
        //  В соответствии с этим, из интерполятора убрано время, введено обнуление
        //  (перед новой калибровкой) и критерий ResultReady


        // Периодически гистограмма анализируется и измеряются коды
        // самой левой и самой правой палок, кот. передаются в программу
        // через свойства LowIPCode и HighIPCode.
        //
        // Гистограмма заполняется "послойно" - когда достаточно накопилось в
        // одном слое (Lay)- происходит следующее:
        //    1. подсчитывается суммарная гистограмма всех слоев;
        //    2. по суммарной гистограмме вычисляются FLowIPCode и FHighIPCode
        //    3. слой, следующий (по кругу) за Lay, обнуляется, и теперь он будет Lay
        //
        // Каждая палка послойной гистограммы заполняется до значения 255, далее
        // данная палка не растет! Это предотвратит крах, если вдруг на вход подадут сигнал
        // когерентный клоку!!! При растяжке 2000 теоретически возможно за один сбор
        // получить сразу 2000 одинаковый кодов!!!
        //
        // Определение "конца" заполнения слоя определяется по нескольким критериям:
        //    a. через сTimeInterval после начала заполнения при условии, что в слое
        //       не менее 1000 точек и только что получен EndOfSignal;
        //    b. Максимальная палка в слое > 200 и только что получен
        //       EndOfSignal (очень быстрый сбор);
        //    с. В слое 12 000 точек и только что получен
        //       EndOfSignal (очень быстрый сбор);

        //  FOLLOWING A LIST OF PRIVATE VARIABLES THAT ARE USED INSIDE THE CLASS 
        //  ДАЛЕЕ ИДЕТ СПИСОК ПРИВАТНЫХ ПЕРЕМЕННЫХ КОТОРЫЕ ИСПОЛЬЗУЮТСЯ ВНУТРИ КЛАССА

        private const int cHighLayer = 4;   // Для начала 5 слоев (сHighLayer = 4). А быстрее отслеживает дрейф при 1 (сHighLayer = 0).
        private const int cTimeInterval = 1/24/60/60 * 30;  // 30 секунд

        private Boolean FEnable;
        private ushort FLowIPCode;
        private ushort FHighIPCode;

        private int FLyr;
        private Double FLyrStartTime;

        private int FFilledLyrs;
        private byte [,]FLyrHysts;
        private int FLyrSum;
        private int FLyrMax;
        private ushort[] FHyst;
        private ushort FHystLeft;           // Min. палка суммарной гистограммы
        private ushort FHystRight;          // Max. палка суммарной гистограммы
        private Double FHystMeanHeight;     // средняя высота НЕНУЛЕВЫХ палок

        /// <summary>
        /// Adding value
        /// </summary>
        /// <param name="IP_Val">Interpolator value</param>
        /// <param name="kat"></param>
        public void TInterpolAutoAdjust_AddValue(ushort IP_Val, int Krat = 1)
        {
            int Val;

            if (FLyrSum == 0)
            {
                FLyrStartTime = DateTime.UtcNow.Ticks;
            }

            Val = FLyrHysts[FLyr, IP_Val];

            if (Val == 255)
            {
                //  Exit
                return;
            }

            // Нужно добавить точку
            FLyrSum = FLyrSum + Krat;
            Val = Val + Krat;

            if (Val > 255)
            {
                Val = 255;
            }

            FLyrHysts[FLyr, IP_Val] = (byte)Val;

            if (Val > FLyrMax)
            {
                FLyrMax = Val;
            }
        }

        /// <summary>
        /// Calc Sum Sistogramm and its params
        /// </summary>
        public void TInterpolAutoAdjust_CalcSumSistogrammAndItsParams()
        {
            //  Вычисляем суммарную гистограмму и ее параметры:
            //  Минимальный и максимальный код интерполятора
            //  и среднюю высоту НЕНУЛЕВЫХ палок

            int I;
            int L;
            int si;             // Сумма i-ых палок во всех слоях
            int HystCount;      // Число ненулевых палок суммарной гистограммы
            int Hits;           // Общее число событий суммарной гистограммы

            FHystLeft = 65535;  // Min. палка суммарной гистограммы
            FHystRight = 0;     // Max. палка суммарной гистограммы
            HystCount = 0;      // Число ненулевых палок суммарной гистограммы
            Hits = 0;           // Общее число событий суммарной гистограммы

            for ( I = 0; I < 65535; I++ )
            {
                si = 0;
                for( L = 0; L < cHighLayer; L++ )
                {
                    si = si + FLyrHysts[L, I];
                }

                FHyst[I] = (ushort)si;

                if( si > 0 )
                {
                    HystCount++;
                    Hits = Hits + si;

                    FHystRight = (ushort)I;
                    if (I < FHystLeft)
                    {
                        FHystLeft = (ushort)I;
                    }    
                }
            }

            if( HystCount > 1000 )
            {
                //  средняя высота НЕНУЛЕВЫХ палок
                FHystMeanHeight = Hits / HystCount;
            }
            else
            {
                FHystMeanHeight = 0;
                FHystLeft = 55555;      // Min. палка суммарной гистограммы
                FHystRight = 55555;     // Max. палка суммарной гистограммы
            }
        }

        /// <summary>
        /// Calculating Low and High Interpolator Code
        /// </summary>
        public void TInterpolAutoAdjust_Calc_Low_High_IPCode()
        {
            //  Вычисляем крайние границы кодов интерполяторов

            const int cThreshPerc = 50;

            double thresh;
            int I;

            thresh = FHystMeanHeight * cThreshPerc / 100;

            for(I = FHystLeft; I < FHystRight; I++)
            {
                if( FHyst[I] > thresh )
                {
                    FLowIPCode = (ushort)I;
                    break;
                }
            }

            for (I = FHystRight; I < FHystLeft; I--)
            {
                if (FHyst[I] > thresh)
                {
                    FHighIPCode = (ushort)I;
                    break;
                }
            }
        }

        /// <summary>
        /// Clear Lyr
        /// </summary>
        /// <param name="Lyr">Lyr</param>
        public void TInterpolAutoAdjust_ClrLyr(int Lyr)
        {
            FLyrMax = 0;
            FLyrSum = 0;

            //  FillChar(FLyrHysts[FLyr], SizeOf(FLyrHysts[0]), 0);
            int arr_len = FLyrHysts.Length;
            for(int i = 0 ; i < arr_len; i++)
            {
                FLyrHysts[i, 0] = 0;
            }
        }

        /// <summary>
        /// Procedure for end of signal
        /// </summary>
        public void TInterpolAutoAdjust_EndOfSignal()
        {
            //    a. через сTimeInterval после начала заполнения при условии, что в слое
            //       не менее 1000 точек и только что получен EndOfSignal;
            //    b. Максимальная палка в слое > 200 и только что получен
            //       EndOfSignal (очень быстрый сбор);  - как выяснилось -
            //       при временной подсинхронизации   одна палка накапливается ну очень
            //       быстро. Пока это отключил!
            //    с. В слое 6 000 точек и только что получен
            //       EndOfSignal (очень быстрый сбор);

            Boolean Fin;
            Double Dur;
            int Part555;

            //  2018-01-26 - было  Fin := (FLyrSum >= 6000) OR (FLyrMax >= 200);
            Fin = (FLyrSum >= 6000);

                // Для отладки чтоб быстро!!!
                //Fin := (FLyrSum >= 600) OR (FLyrMax >= 200);

            if( (!Fin) && (FLyrSum >= 1000) )
            {
                Dur = DateTime.UtcNow.Ticks - FLyrStartTime;
                Fin = Dur > cTimeInterval;
            }

            if( !Fin )
            {
                //  Exit
                return;
            }

            //  Нужно перейти на другой слой
            FFilledLyrs++;

            Part555 = 555;
            if( TInterpolAutoAdjust_StatisticsReady(Part555) )
            {
                //  Вычисляем суммарную гистограмму и ее параметры
                TInterpolAutoAdjust_CalcSumSistogrammAndItsParams();

                if( FHystMeanHeight > 0 )
                {
                    //  Вычисляем крайние границы кодов интерполяторов
                    TInterpolAutoAdjust_Calc_Low_High_IPCode();
                }

                if( FHystMeanHeight == 0 )
                {
                    //  Exit
                    return;
                }
            }

            //  Только после вычисления статистики, так как ща самый старый слой обнулится
            TInterpolAutoAdjust_SwitchToNextLyr();
        }

        /// <summary>
        /// Restart functions
        /// </summary>
        public void TInterpolAutoAdjust_Restart()
        {
            int Lyr;

            for( Lyr = 0; Lyr < cHighLayer; Lyr++ )
            {
                TInterpolAutoAdjust_ClrLyr(FLyr);
            }

            FFilledLyrs = 0;
        }

        /// <summary>
        /// Set FEnable to new value
        /// </summary>
        /// <param name="Value">New FEnable value</param>
        public void TInterpolAutoAdjust_SetEnable(Boolean Value)
        {
            FEnable = Value;
        }

        /// <summary>
        /// Statistics Ready
        /// </summary>
        /// <param name="PartReady">Number of parts that ready to use</param>
        /// <returns>Returns if statistics ready or not as true or false</returns>
        public Boolean TInterpolAutoAdjust_StatisticsReady(int PartReady)
        {
            Boolean Result = FFilledLyrs > cHighLayer;
            double needtoroundone = FFilledLyrs / (cHighLayer + 1) * 100;
            PartReady = (int)Math.Round(needtoroundone);
            if( PartReady < 100 )
            {
                double needtoroundtwo = PartReady + (FLyrSum / 6000) * 100 * 1 / (cHighLayer + 1);
                PartReady = (int)Math.Round(needtoroundtwo);
            }
            return Result;
        }

        /// <summary>
        /// Switch Flyr index to next layer and makes it zero
        /// </summary>
        public void TInterpolAutoAdjust_SwitchToNextLyr()
        {
            //  Переключает индекс FLyr на след. слой и обнуляет его
            if( FLyr < cHighLayer )
            {
                FLyr++;
            }
            else
            {
                FLyr = 0;
            }

            TInterpolAutoAdjust_ClrLyr(FLyr);
        }
    }
}
