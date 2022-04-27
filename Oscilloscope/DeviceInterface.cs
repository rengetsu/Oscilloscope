using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oscilloscope
{
    /// <summary>
    /// Device interface
    /// </summary>
    public class DeviceInterface
    {
        Instruments Instr;
        BootloaderLaunch BL;
        WinUSBConnect wUSBCon;

        Int64 AnswerLAN_Len;
        Char[] AnswerLAN;

        /// <summary>
        /// Get integer parameter
        /// </summary>
        /// <param name="command">Command</param>
        /// <returns>Return command</returns>
        /// <exception cref="NotImplementedException">Exception</exception>
        public int GetIntegerParameter(string command)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Function to check if device is connected or not
        /// </summary>
        /// <returns>Returns the answer in the format yes or no (device connected or not)</returns>
        public Boolean PriborYra()
        {
            String Intf;
            Boolean Result = false;
            Intf = CurrentInterface_Get();
            Result = (Intf == Instr.cintUSB) || (Intf == Instr.cintLAN);
            return Result;
        }

        /// <summary>
        /// Functiong to get current interface
        /// </summary>
        /// <returns>Return current interface</returns>
        private string CurrentInterface_Get()
        {
            if(BL.GetCurrentMode() == 'D')
            {
                //  We work in Demo mode
                return Instr.cintDemo;
            }
            else
            {
                //  30/09/2021  At the moment, we don't have an automatic mode 
                if(Instr.AutoCreated == false)
                {
                    if(wUSBCon.checkUSBConnection() == true)
                    {
                        //  We work with device using USB
                        return Instr.cintUSB;
                    }
                    else
                    {
                        //  We work with device using LAN
                        return Instr.cintLAN;
                    }
                }
                else
                {
                    //  We work with in auto
                    return Instr.cintAuto;
                }
            }
        }

        /// <summary>
        /// Sending Command to the Unit (Device)
        /// </summary>
        /// <param name="Command">Command in string format that we will send to device</param>
        /// <param name="WithoutTerminateSbor">True if we need to terminate (stop collection)</param>
        /// <returns>Returns whether the command was successfully executed or not</returns>
        public Boolean SendCommantToTheUnit(String Command, Boolean WithoutTerminateSbor)
        {
            String buf = null;
            AnswerLAN_Len = 0;

            // 2 May 2013 - в PS9200 не работало измерение джиттера во время паттерн lock (частотомер сбрасывал гистограмму)
            // Решил попробовать вместо того, чтобы в "непрерывабельных" командах вообще не вызывать ProcInterruptCurrentSborImmediat_ClrStat -
            // вызывать его с параметром (не стирать статистику)
            // В данном приборе статистика стирается в отдельной процедуре, но для подобия решил сделать как и в 9200.
            // Тем более, что прерывать незавершенный сбор тут надо тоже
            // if not WithoutClearStatistic then
            // ProcInterruptCurrentSborImmediat_ClrStat;

            buf = buf + "#13#10";

            Boolean Result = true;
            return Result;
        }
    }
}
