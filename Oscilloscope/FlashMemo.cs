using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oscilloscope
{
    public class FlashMemo
    {
        //  Used classes
        Channel Channel = new Channel();
        DeviceInterface DI = new DeviceInterface();
        CustomAppleHandlers CustomAppleHandlers = new CustomAppleHandlers();

        /// <summary>
        /// Get command for module RW
        /// </summary>
        /// <param name="module"></param>
        /// <param name="mode"></param>
        /// <param name="v"></param>
        /// <returns></returns>
        private string _GetCommandForModule_RW(object module, object mode, bool v)
        {
            String str_rez = "Calibre";
            return str_rez;
        }

        /// <summary>
        /// Read info from flash or file (selection)
        /// </summary>
        /// <param name="Module"></param>
        /// <param name="Mode"></param>
        void ReadInfoFromFlashOrFile(object Module, object Mode)
        {
            if( Mode == "tfmAdjust")
            {
                CustomAppleHandlers.Set_TheUnitInInitializationStage = true;
            }
        }

        /// <summary>
        /// Read info from flash or file
        /// </summary>
        /// <param name="Module">Flash module</param>
        /// <param name="Mode">Flash mode <br>
        /// (Calibrator, Adjustment, Initialization)</param>
        void _ReadInfoFromFlashOrFile(object Module, object Mode)
        {
            //  Mode = tfmCalibr, tfmAdjust, tfmInitial

            int i;
            String Command;
            Channel ch;

            Command = _GetCommandForModule_RW(Module, Mode, true);

            if( DI.PriborYra() )
            {
                i = DI.GetIntegerParameter(Command);
            }
        }
    }
}
