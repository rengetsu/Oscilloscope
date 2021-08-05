using OpenTK;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Oscilloscope
{
    public class Temperature
    {
        public const char V = 'T';

        DeviceCheck dvc;

        bool SilentMode = false;
        double rez = 55.55;

        //  Commands
        string comone = "INFO:GetTemp?'";
        string comtwo = "INFO:GetATemp?'";
        string comtri = "INFO:GetDTemp?'";

        double GetTemperatureOf(char c, bool reset, bool nostopsbor)
        {
            if (SilentMode == true)
            {
                return rez;
            }
            else if(SilentMode == false)
            {
                for (int i = 0; i < 10; i++)
                {
                    //  Отправляем команду
                    switch (c)
                    {
                        //  Get Temperature
                        case (char)1:
                            Console.WriteLine("INFO:GetTemp?");
                            dvc.SendCommantToTheUnit(dvc.format(V, i));
                            break;

                        //  Get ADC Temperature
                        case (char)2:
                            Console.WriteLine("INFO:GetATemp?");
                            dvc.SendCommantToTheUnit(dvc.format(V, i));
                            break;

                        //  Get Digital Temperature
                        case (char)3:
                            Console.WriteLine("INFO:GetDTemp?");
                            dvc.SendCommantToTheUnit(dvc.format(V, i));
                            break;

                        //  Get Temperature
                        default:
                            Console.WriteLine("INFO:GetTemp?");
                            dvc.SendCommantToTheUnit(dvc.format(V, i));
                            break;
                    }
                    rez = dvc.GetStringFromTheUnit();
                }
            }
            // Измеряем температуру со скользящим усреднением N=8.
            // При Reset - обнуляем усреднение (и тогда 1-ый раз выдает текущее значение)
            return 0;
        }
    }
}
