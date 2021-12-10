using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oscilloscope
{
    /// <summary>
    /// Devices
    /// </summary>
    public enum Device
    {
        arrow   = 0,
        pico    = 1
    }

    //  ALL Arrow Registers for I2C and DAC

    /// <summary>
    /// DAC registers for Arrow
    /// </summary>
    public enum dac_registers_arrow
    {
        ad5625r_d36     = 0x18,
        ad5625r_d41     = 0x1E,
        ad5625r_d47     = 0x1E,
        ad5625r_d50     = 0x18,
        ad5645r_d831    = 0x18,
        dac80501_d55    = 0x90,
        pca9555ahf_d99  = 0x40,
        pca955abs_d97   = 0x72,
        nct218_d76      = 0x90,
        p49v5901_d801   = 0xD0
    }

    /// <summary>
    /// Device check class. <br/>
    /// All stuff to check device, send commands, get responses and much more. <br/>
    /// If everything works, it's better not to touch. <br/>
    /// </summary>
    public class DeviceCheck
    {
        DeviceInterface DI;
        GeneralCalculations GC;

        public const string V = "Check";
        string com = "Test:RgDAC:Response? %d'";
        public Device DeviceType;
        public dac_registers_arrow ArrowDac;

        public enum TFloatFormat { ffGeneral, ffExponent, ffFixed, ffNumber, ffCurrency };

        public int I { get => 0; private set => value = 1; }

        void Check_I2C_Regs_DACs()
        {
            for (int adressNumber = 0; adressNumber < 8; adressNumber++)
            {
                int dacAdress;

                if (CheckDevice() == true)
                {
                    dacAdress = getDacAdress(GetI());
                    foreach (dac_registers_arrow val in Enum.GetValues(typeof(dac_registers_arrow)))
                    {
                        if (val.Equals(dacAdress))
                        {
                            //  OK
                        }
                        else { showMessage(true, dacAdress); }
                    }
                }
                else { }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        bool CheckDevice()
        {
            //  Arrow
            if      (DeviceType == Device.arrow)
            {
                return true;
            }
            //  Pico
            else if (DeviceType == Device.pico)
            {
                return false;
            }
            return false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private int GetI()
        {
            return I;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        int getDacAdress(int i)
        {
            SendCommandToTheUnit(format(V, i));
            return 0;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        internal double GetStringFromTheUnit()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="v"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public String format(string v, object p)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Send Command to the Unit
        /// </summary>
        /// <param name="p"></param>
        /// <param name="WithoutTerminateSbor"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void SendCommandToTheUnit(String command, Boolean WithoutTerminateSbor = false)
        {
            DI.SendCommantToTheUnit(command, WithoutTerminateSbor);
        }

        /// <summary>
        /// Set integer parameter
        /// </summary>
        /// <param name="Command"></param>
        /// <param name="Param"></param>
        /// <param name="WithoutTerminateSbor"></param>
        public void SetIntegerParameter(String Command, int Param, Boolean WithoutTerminateSbor = false)
        {
            String newCommand = Command + ' ' + Param.ToString();
            SendCommandToTheUnit(newCommand, WithoutTerminateSbor);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Command"></param>
        /// <param name="Param"></param>
        /// <param name="WithoutTerminateSbor"></param>
        public void SetFloatParameter(String Command, Double Param, Boolean WithoutTerminateSbor = false)
        {
            String StrParam;
            Byte poscom;
            int q;

            StrParam = FloatToStrF_Dot(Param, TFloatFormat.ffGeneral, 8, 0);
            poscom = Convert.ToByte(GC.Pos(",", StrParam));
            if ( poscom > 0 )
            {
                StrParam = StrParam.Insert(poscom,".");
            }
            //  Creating new command to send it to sendCommand
            String newCommand = Command + ' ' + StrParam;
            SendCommandToTheUnit(newCommand, WithoutTerminateSbor);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="check"></param>
        /// <param name="dacName"></param>
        void showMessage(bool check, int dacName)
        {
            if (check == true)
            {
                Console.WriteLine("Next equipment: \r\n" + dacName + "not responded");
            }
            else
            {
                Console.WriteLine("Next equipment: \r\n" + dacName + "not responded. Vse rabotayet!");
            }
        }

        /// <summary>
        /// Float to str
        /// </summary>
        /// <param name="Value">Value</param>
        /// <param name="Format">Format</param>
        /// <param name="Precision">Precision</param>
        /// <param name="Digits">Digits</param>
        /// <returns>Return string str</returns>
        /// <exception cref="NotImplementedException"></exception>
        private string FloatToStrF_Dot(double Value, TFloatFormat Format, int Precision, int Digits)
        {
            throw new NotImplementedException();
        }
    }
}
