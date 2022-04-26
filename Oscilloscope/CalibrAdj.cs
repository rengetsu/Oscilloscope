using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oscilloscope
{
    public class CalibrAdj
    {
        public string[] FlashMnemonicForModules = {
            "Flash:Vertical:",  // camVertival   //  Только для COM! Запрещено для общения с прибором (low-level Intrfs)
            "Flash:TB:",        // camTB
            "Flash:Calibrat:",  // camTrigger
            "Flash:All" };      // camAll

        /// <summary>
        /// Get flash mnemonic by module
        /// </summary>
        /// <param name="Module"></param>
        /// <returns></returns>
        public string GetFlashMnemonicByModule(object Module)
        {
            int ResultIndex;
            switch (Module)
            {
                case "Vertical":
                    //  Vertical
                    ResultIndex = 0;
                    break;
                case "TB":
                    //  TimeBase
                    ResultIndex = 1;
                    break;
                case "Calibrat":
                    //  Calibrat
                    ResultIndex = 2;
                    break;
                case "All":
                    //  All
                    ResultIndex = 3;
                    break;
                default:
                    //  All by default
                    ResultIndex = 3;
                    break;
            }
            string Result = FlashMnemonicForModules[ResultIndex];
            return Result;
        }
    }
}
