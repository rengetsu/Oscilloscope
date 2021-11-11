using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oscilloscope
{
    /// <summary>
    /// All functions related to the operation of the PPG (pulse pattern generator) are located here
    /// </summary>
    public class Generator_PPG
    {
        //  Including Device Interface Class to send commands to device
        DeviceInterface DI;

        public int Period;
        public int Delay;
        public int Width;
        private int rbgWfmItemIndex = 0;

        /// <summary>
        /// RBG WFM Update function
        /// </summary>
        public void rbgWfmUpdateMe()
        {
            int hc;
            //  OFF
            if (rbgWfmItemIndex == 0)
            {
                DI.SendCommantToTheUnit("Test:FPGA:OnOff On", false);
                DI.SendCommantToTheUnit("Test:FPGA:Mode Manual", false);

                DI.SendCommantToTheUnit("Test:FPGA:Address 118", false);
                DI.SendCommantToTheUnit("Test:FPGA:OneRead", false);
                DI.SendCommantToTheUnit("Test:FPGA:Data 0", false);
                DI.SendCommantToTheUnit("Test:FPGA:OneWrire", false);
                DI.SendCommantToTheUnit("Test:FPGA:OnOff Off", false);

                //edFreqParam.ApplCompLabel.Caption = "Period";

                //  Enabled
                //edFreqParam.Enabled = false;
                //edppgDelay.Enabled = false;
                //edWidth.Enabled = false;
                //rbSlope.Enabled = false;
                //rbgLength.Enabled = false;
                //InternalTrigger.Enabled = false;

                //  Visible
                //edFreqParam.Visible = true;
                //edppgDelay.Visible = true;
                //edWidth.Visible = true;
                //rbSlope.Visible = true;
                //rbgLength.Visible = true;
                //InternalTrigger.Visible = true;

                hc = 1400;
            }
            //  Trigger out
            else if (rbgWfmItemIndex == 5)
            {
                DI.SendCommantToTheUnit("Test:FPGA:OnOff On", false);
                DI.SendCommantToTheUnit("Test:FPGA:Mode Manual", false);

                DI.SendCommantToTheUnit("Test:FPGA:Address 118", false);
                DI.SendCommantToTheUnit("Test:FPGA:OneRead", false);
                DI.SendCommantToTheUnit("Test:FPGA:Data 0", false);
                DI.SendCommantToTheUnit("Test:FPGA:OneWrire", false);

                DI.SendCommantToTheUnit("Test:FPGA:OnOff Off", false);

                DI.SendCommantToTheUnit("PPG:TRIGGEROUT:ON", false);

                //  Enabled
                //edFreqParam.Enabled := false;
                //edppgDelay.Enabled := false;
                //edWidth.Enabled := false;
                //rbSlope.Enabled := false;
                //rbgLength.Enabled := false;
                //InternalTrigger.Enabled := false;

                //  Visible
                //edFreqParam.Visible := true;
                //edppgDelay.Visible := true;
                //edWidth.Visible := true;
                //rbSlope.Visible := true;
                //rbgLength.Visible := true;
                //InternalTrigger.Visible := true;
                hc = 1430;
            }
            else
            { 
                hc= 1435;
            }
        }
    }
}
