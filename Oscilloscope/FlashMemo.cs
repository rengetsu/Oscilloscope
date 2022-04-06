using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oscilloscope
{
    public class FlashMemo
    {

        object camAll = "All";
        object camTB = "TimeBase";
        object camVertical = "Vertical";
        object camCalibrator = "Calibrator";

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

        enum Cam { Vertical, TimeBase, All }

        /// <summary>
        /// Read info from flash or file (selection)
        /// </summary>
        /// <param name="Module"></param>
        /// <param name="Mode"></param>
        void ReadInfoFromFlashOrFile(object Module, object Mode)
        {
            //  Adjustment
            if( Mode == "tfmAdjust")
                CustomAppleHandlers.Set_TheUnitInInitializationStage = true;

            if( Module == "camVertical" && Mode == "camAll" )
                _ReadInfoFromFlashOrFile(camVertical, camAll);
            if( Module == "camTimeBase" && Mode == "camAll" )
                _ReadInfoFromFlashOrFile(camTB, camAll);
            if ( Module == "camCalibrator" && Mode == "camAll" )
                _ReadInfoFromFlashOrFile(camCalibrator, camAll);
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
