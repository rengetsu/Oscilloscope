﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oscilloscope
{
    public class BaseTypes
    {
        ///  Constant values
        public double cADC_Period = 200E-12;      ///  200 ps ADC Period One Channel
        public double cFIP_Period = 3200E-12;     ///  3.2 ns Fine Interpolator Period

        //     В приборе имеются два цифровых интерполятора и плавный интерполятор.
        //
        //     Первым работает плавный интерполятор. Он меряет расстояние от точки триггера
        //  до второго такта 1 ГГц клока (так называемого опорного такта). Это время
        //  теоретически меняется от 1 нс до 2 нс.
        //
        //     Первый цифровой интерполятор меряет число тактов 1 ГГц клока между опорным
        //  тактом и концом пачки из 8 точек АЦП. Может принимать значения 0..7, 0..15,
        //  0..31 и 0..63 для режимов 8 и 12 бит и коэффициентах децимации 1:1, 1:2 и 1:4.
        //  Старшая часть обрабатывается в приборе, отбрасывая ненужные точки. А вом
        //  младшая при коэффициентах децимации 1:2 и 1:4 (на 8 битах) и 1:1, 1:2 и 1:4
        //  для 12 битаз дает расстояние в тактах 1 ГГц клока между опорным тактом и
        //  ближайшей к нему выборкрй АЦП. При коэффициенте децимации 1:1 на 8 битах
        //  (АЦП работают на частоте 1 ГГц!) интерполятор полностью обрабатывается в
        //  приборе, и в верхней программе не используется.
        //
        //    Второй цифровой интерполятор работает при коэффициенте децимации 1:10 и далее.
        //  Он показывает расстояние в выборках АЦП между опорным тактом и концом пачки
        //  из 8 точек АЦП. Обрабатывается в приборе, отбрасывая ненужные точки.


        //  Спец. коды будут передаваться 2-мя словами (или тремя и более), первым из которых будет "ключ" 0000.
        //  Далее следует слово команды, за которым (для определенных команд) - одно или несколько слов данных
        //
        // Список команд:         (взял значения из статьи википедии про код Хэмминга)
        //               (след. коды будут 2727; 2C2C; 3131; 3A3A; 4545; 4E4E; 5353; 5858; 6262; 6969; 7474 и 7F7F)

        /// SPECIAL CODES

        /// <summary>
        /// SpecCode_FR_FineInterpolator.
        /// Введён 2020-08-25 для Fast-Random сбора для замены SpecCode_Interpolator, так как в рандоме нужен только плавный интерполятор
        /// В следующем 16-битном слове MMMM  будет передано значение плавного интерполятора.
        /// Слово MMMM - код плавного интерполятора. Это напрямую код интерполятора,
        /// приведенный к 16-битному коду. 0=0 Вольт; 65536=3.3 Вольта.
        /// Однако если триггер флаг отсутствовал - то Слово MMMM будет иметь
        /// значение SpecCode_NotTriggerFlag!!!
        /// Значение:   7468  + 1 слово данных
        /// </summary>
        public const int SpecCode_FR_FineInterpolator = 0x1D2C;

        /// <summary>
        /// SpecCode_NotTriggerFlag.
        /// Применяется в слове MMMM (код плавного интерполятора)
        /// команд SpecCode_Interpolator или SpecCode_FR_FineInterpolator
        /// Значение:  65535  (данных не имеет)
        /// </summary>
        public const int SpecCode_NotTriggerFlag = 0xFFFF;

        /// <summary>
        /// SpecCode_SkipPoint1.
        /// В восьмибитном режиме первая точка сигнала может оказаться как первой, так и
        /// второй точкой в паре. Для индикации 2-го случая, чтобы программа проигнорировала
        /// первую точку, прибор перед сигналом посылает этот спец. код. Вроде не нужен,
        /// так как это обрабатывается в приборе...
        /// Значение:   10023  (данных не имеет)
        /// </summary>
        public const int SpecCode_SkipPoint1 = 0x2727;

        /// <summary>
        /// SpecCode_MemoAddr
        /// В следующих 2-х 16-битных словах: MLAD, STAD будет передано значение адреса.
        /// (сначала младшее слово адреса, затем старшее)
        /// Первое применение - в режиме Roll передается в каждом переданном из прибора
        /// блоке данных, если в нем не было собрано ни одной точки. Эта команда передается
        /// непосредственно перед SpecCode_Key/SpecCode_Wait
        /// Значение:   11308 + 2 слова данных
        /// </summary>
        public const int SpecCode_MemoAddr = 0x2C2C;

        /// <summary>
        /// SpecCode_UpData.
        /// (Old SpecCode_TestInfo)
        /// Код операции лежит в диапазоне  $3A00..$3AFF. Младший байт данных кодирует
        /// число слов - данных этой команды. Подразумевается, что первое слово данных
        /// будет код Up-данных, по которому будет понятно как следует интерпретировать
        /// остальные слова данных и сколько из них значащие (так как блок данных может быть чуть
        /// длиннее чем требуется).
        /// Число слов данных команды (1..1000000) кодируется мл. байтом кода операции по методу,
        /// разработанному мной для этого случая и проиллюстрированному в файле
        /// "Представление больших чисел байтом.xls" (табличка 4 бита порядок + 4 бита мантисса)
        /// Применяемые коды Up-данных описаны ниже в разделе "Коды операций в команде SpecCode_UpData"
        /// Значение:   кол.данных - мл. байт команды
        /// </summary>
        public const int SpecCode_UpData = 0x3A00;

        //  Сегментный сбор

        /// <summary>
        /// SpecCode_SegmentHot.
        /// В сегментном сборе информация обо всех сегментах передается
        /// перед передачей сигнала. Это позволяет (при медленном сборе)
        /// получать информацию о собранных сегментах в процессе сбора.
        /// Кроме этого это избавляет прибор от необходимости хранить в
        /// процессе сбора эту информацию в отдельных буферах.
        /// 
        /// Код передается для каждого сегмента, включая первый.
        /// В следующих 3-х 16-битных словах LOLO, MIDM, HIHI будет передано
        /// абсолютное значение времени срабатывания триггера сегмента (отн-но старта)
        /// Время измеряется шагами таймера (думаем, что это будет 4 ns)
        /// Полученное время будет равно HIHI << 32 + MIDM << 16 + LOLO.
        /// 
        /// Далее непосредственно следует SpecCode_Interpolator с данными
        /// 
        /// Сразу же после информации о последнем сегменте (а их может быть и менее
        /// заданного количества, или даже ни одного) начинается передача сегментов
        /// сигнала.
        /// Значение:   20046    + 3 слова данных
        /// </summary>
        public const int SpecCode_SegmentHot = 0x4E4E;

        /// <summary>
        /// SpecCode_NextSegment.
        /// В сегментном сборе передается во время передачи сегментов сигнала и
        /// служит для разделения сегментов сигнала.
        /// !!!  ДОЛЖЕН быть передан и перед первым сегментом  !!!
        /// Значение:   21331  (данных не имеет)
        /// </summary>
        public const int SpecCode_NextSegment = 0x5353;

        //  Обобщая вышеперечисленное, полный поток одного сегментного сбора будет таким:
        //
        //   - SpecCode_Key;
        //   - 4 слова SpecCode_SegmentHot 1-го сегмента;
        //   - SpecCode_Key;
        //   - 4 слова SpecCode_Interpolator 1-го сегмента;
        //   - SpecCode_Key;
        //   - 4 слова SpecCode_SegmentHot 2-го сегмента;
        //   - SpecCode_Key;
        //   - 4 слова SpecCode_Interpolator 2-го сегмента;
        //   - .......................
        //   - .......................
        //   - SpecCode_Key;
        //   - 4 слова SpecCode_SegmentHot последнего сегмента;
        //   - SpecCode_Key;
        //   - 4 слова SpecCode_Interpolator последнего сегмента;
        //   - SpecCode_Key;
        //   - 1 слово SpecCode_NextSegment;
        //   - коды точек 1-го сегмента;
        //   - SpecCode_Key;
        //   - 1 слово SpecCode_NextSegment;
        //   - коды точек 2-го сегмента;
        //   - .......................
        //   - .......................
        //   - SpecCode_Key;
        //   - 1 слово SpecCode_NextSegment;
        //   - коды точек последнего сегмента;
        //   - блок кодов команды окончания сигнала;

        /// <summary>
        /// Get ADC Period
        /// </summary>
        /// <returns>Returns ADC Period</returns>
        public double GetADC_Period()
        {
            double ADC_Period = cADC_Period;
            return ADC_Period;
        }

        /// <summary>
        /// Get FIP Period
        /// </summary>
        /// <returns>Returns FIP Period</returns>
        public double GetFIP_Period()
        {
            double FIP_Period = cFIP_Period;
            return FIP_Period;
        }

        /// <summary>
        /// Get Special Code - Not Trigger Flag
        /// </summary>
        /// <returns>Returns special code - not trigger flag</returns>
        public int GetSpecCode_NotTriggerFlag()
        {
            int NotTriggerFlag = SpecCode_NotTriggerFlag;
            return NotTriggerFlag;
        }
    }
}
