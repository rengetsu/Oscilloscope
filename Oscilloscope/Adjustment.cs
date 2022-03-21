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
    }

    /// <summary>
    /// Adjustment - Vertical ADC Class
    /// </summary>
    class VerticalADC : Adjustment
    {
        String VertMnem_ADCRef = "ADCREF";

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
