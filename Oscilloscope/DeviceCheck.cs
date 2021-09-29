using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oscilloscope
{
    public enum Device
    {
        arrow   = 0,
        pico    = 1
    }

    //  ALL Arrow Registers for I2C and DAC
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

    public class DeviceCheck
    {
        GeneralCalculations GC;

        public const char V = 'T';
        string com = "Test:RgDAC:Response? %d'";
        public Device DeviceType;
        public dac_registers_arrow ArrowDac;

        public int I { get; private set; }

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

        private int GetI()
        {
            return I;
        }

        int getDacAdress(int i)
        {
            SendCommantToTheUnit(format(V, i));
            return 0;
        }

        internal double GetStringFromTheUnit()
        {
            throw new NotImplementedException();
        }

        public object format(char v, object p)
        {
            throw new NotImplementedException();
        }

        public void SendCommantToTheUnit(object p, Boolean WithoutTerminateSbor = false)
        {
            throw new NotImplementedException();
        }

        public void SetIntegerParameter(String Command, int Param, Boolean WithoutTerminateSbor = false)
        {
            SendCommantToTheUnit(Command + ' ' + Param.ToString());
        }

        public void SetFloatParameter(String Command, Double Param, Boolean WithoutTerminateSbor = false)
        {
            String StrParam;
            Byte poscom;
            int q;

            StrParam = FloatToStrF_Dot(Param, ffGeneral, 8, 0);
            poscom = Convert.ToByte(GC.Pos(",", StrParam));
            if ( poscom > 0 )
            {
                StrParam[poscom] = '.';
            }
            SendCommantToTheUnit(Command + ' ' + StrParam, WithoutTerminateSbor);
        }

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
    }
}
