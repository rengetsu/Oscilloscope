using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oscilloscope
{
    public class SignalAcqRun
    {
        String LastPointFineIP;  //  Для отладки

        double Get_Physical_SampleRate()
        {
            double Result;
            return Result;
        }

        Int64 Get_RT_ACQ_Period_ns()
        {
            //  Возвращает установленный период сбора реально-временных режимов в наносекундах
            Int64 Result = Math.Round(1e10 / Get_Physical_SampleRate());
            return Result;
        }

        /// <summary>
        /// Calculating First Point Time Traditional Interpolator
        /// </summary>
        /// <param name="DIP4"></param>
        /// <param name="FineIP_Val">Interpolator Value</param>
        /// <param name="WO_Interpol"></param>
        /// <returns></returns>
        double CalcFirstPointTime_TraditionalInterpolator(ulong DIP4, string FineIP_Val, bool WO_Interpol = false)
        {
            //  Обрабатывает коды интерполяторов - вычисляет Измеренное фактическое время первой точки сигнала -
            //  сдвиг конкретного сигнала относительно теоретического места по сигналам интерполятора,
            //  !!!  Должна обязательно вызываться ПОСЛЕ (!!!) CalculateParamsOfStartForAllChannels.
            //  2017-06-07 при WO_Interpol интерполятор не учитывается, например при усреднении!!!
            double Result = 0;
            double dTime;
            uint Period_ns;
            uint FineIP_Min;
            uint FineIP_Scale;
            Int32 StrobesBetweenPeriods;    //  число стробов АЦП между двумя выборками (медленные развертки)
            double PhysPeriodOfStrobe;
            double Fine_dTime;
            double FloatFineIP;
            Boolean InverseInterpolator;

            LastPointFineIP = FineIP_Val;

            Period_ns = Get_RT_ACQ_Period_ns;

            dTime= 0;

            if TaktInterpolatorNotUse OR WO_Interpol then
    // Цифрофой интерполятор между выборками НЕ истпользуем!
    //  2020-06-02  как я понял (вспомнил), что при коэфф. децимации (или
    //  StrobesBetweenPeriods) = 1 (что соответствует 500 MHz частоте стробирования)
    //  цифровой интерполятор учитывается в нижней программе при считывании сигнала
    //  из FPGA; тут же DigPart будет 0, так как StrobesBetweenPeriods = 1.
    //  а вот при децимациях (StrobesBetweenPeriods) > 1 в нижней программе отработается
    //  только старшая часть цифрового интерполятора (целая часть от DIP4 div
    //  StrobesBetweenPeriods), остаток же от деления (который равен числу периодов
    //  500 MHz клока между триггером и очередной выборкой AЦП)
            else
                begin
                  StrobesBetweenPeriods := Cardinal(Period_ns div 2);

            if FineIP_Val <> SpecCode_NotTriggerFlag then
              DigPart := DIP4 mod StrobesBetweenPeriods
      else
            DigPart:= Random(StrobesBetweenPeriods);

        dTime:= dTime + cADC_Period * DigPart
    end;

            // Время плавной части интерполятора (Теперь 2015-12-29 независимо от цифрового)
            if FineInterpolatorNotUse OR WO_Interpol  then
    // dTime не меняется!
  else
    if FineIP_Val <> SpecCode_NotTriggerFlag then
      begin
        AddFineInterpCodeToStats_ReturnInterpolatorValues(FineIP_Val, FineIP_Min, FineIP_Scale);

            if FineIP_Scale < 1000 then
              FineIP_Scale := 1000;

            //        {$IFDEF PULT}
            //          if Assigned(frmPultParamSbora) and frmPultParamSbora.Visible then
            //            frmPultParamSbora.SetInterpAmplitude(ScaleValue);
            //        {$ENDIF}



            //  2018-10-17
            if Interpol_Noice1bitDepressed then
              FloatFineIP := FineIP_Val             //  Нет добавления шума в 1 квант АЦП интерполятора
          else
        FloatFineIP:= FineIP_Val + Random;   //  Добавляется шума в 1 квант АЦП интерполятора
        // End 2018-10-17

        InverseInterpolator:= IsInterpolator_Inverse;
            if InverseInterpolator then
              Fine_dTime := cArrow_Period * (1 - (FloatFineIP - FineIP_Min) / FineIP_Scale)  // 2017-10-03 инверсия плавного интерполятора          //  2018-10-17
        else
            Fine_dTime:= cArrow_Period * (FloatFineIP - FineIP_Min) / FineIP_Scale;  // 2016-05-10 плавный интерполятор перекрывает 2 нс!                //  2018-10-17

        dTime:= dTime + Fine_dTime;
            end
    else
            //  Включаем рандом для имитации работы интерполятора при отсутствии синхронизации
            dTime:= dTime + cADC_Period * Random;  // 2016-05-10 Теперь плавный интерполятор перекрывает не 1 нс, а 2 нс!  FineCode := ZeroValue + Trunc(Analog/1e-9 * ScaleValue);


        PhysPeriodOfStrobe:= 1 / Get_Physical_SampleRate;  //  физическое значение периода точек, s  (Для Random - в каждом частном сборе)

        Result:= -(SettedPreTriggerPoints * PhysPeriodOfStrobe) + dTime;


            return Result;
        }
    }
}
