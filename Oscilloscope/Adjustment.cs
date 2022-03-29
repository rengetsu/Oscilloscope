using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oscilloscope
{
    /// <summary>
    /// Abstract class for all Adjustment parameters
    /// </summary>
    abstract class Adjustment
    {

        /// <summary>
        /// Adjustment abstract parameter for all adjustment classes
        /// </summary>
        public abstract void Parameter();

        /// <summary>
        /// Send adjustment command from mnemonic
        /// </summary>
        /// <param name="Mnemonic"></param>
        public void SendAdjustmentCommandFromMnemonic(String Mnemonic, Boolean StatusSbora)
        {
            DeviceInterface DI = new DeviceInterface();

            String Command = "COM" + Mnemonic;
            DI.SendCommantToTheUnit(Command, StatusSbora);
        }

        /// <summary>
        /// Scale create command to send after update Scale list box
        /// </summary>
        public String ScaleCreateCommand(int chNmbr, int rgAdjChannel)
        {
            //  Variables for command creation
            String ChLvl, ScaleStr, Scale = "SCALE";

            //  Channel number 
            ChLvl = "CH" + chNmbr.ToString() + ":";

            if (rgAdjChannel >= 1 && rgAdjChannel <= 10)
            {
                //  s10, s20, s30, s40, s50, s60, s70, s80, s90, s100
                ScaleStr = "s" + (rgAdjChannel * 10).ToString();
            }
            else
            {
                //  s200, s300, s400, s500, s600, s700, s800, s900, s1000
                ScaleStr = "s" + ((rgAdjChannel - 9) * 100).ToString();
            }

            //  Example: "CH1:SCALE:s900"
            String FinalCommand = ChLvl + Scale + ScaleStr;

            //  Returning scale command
            return FinalCommand;
        }
    }

    /// <summary>
    /// Adjustment - Vertical ADC Class
    /// </summary>
    class VerticalADC : Adjustment
    {
        public Boolean CalinOnOff_Status = false; 

        //  Channels On/Off status
        Boolean Ch1_OnOff_Status = false;
        Boolean Ch2_OnOff_Status = false;

        String VertMnem_ADCRef = "ADCREF";

        /// <summary>
        /// Get Calibrator Input On/Off current item index
        /// </summary>
        /// <returns>True if On, false if Off</returns>
        public Boolean getCalinOnOffItemIndex()
        {
            return CalinOnOff_Status;
        }

        /// <summary>
        /// Change Calin On/Off item index
        /// </summary>
        /// <param name="newStatus">New status to change</param>
        public void ChangeCalinOnOffItemIndex()
        {
            CalinOnOff_Status = !CalinOnOff_Status;
        }

        /// <summary>
        /// rg Adj Channel Sub Label Click
        /// </summary>
        public void rgAdjChannelSubLabelClick(int ItemIndex)
        {
            ChangeCalinOnOffItemIndex();
        }

        public override void Parameter()
        {
            throw new NotImplementedException();
        }
    }

    /// <summary>
    /// Adjustment - TB Delay
    /// </summary>
    class TB_Delay : Adjustment
    {
        public override void Parameter()
        {
            throw new NotImplementedException();
        }
    }
}
