using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oscilloscope
{
    internal class CustomAppleHandlers
    {
        /// <summary>
        /// Введено 25 авг 2009 для реализации горячего перетыкания прибора
        /// Когда true - ChangeValueFromProgram вызывает FAfterChange даже если значение не меняется
        /// Взведено во время считывания сетап-файлов и во время MakeAllPostInitActions
        /// Если же надо подавить обработку только на время сетап-файла -
        /// используй Unit_Strong_InInitializationStage (PS93__) !!!!! в основной программе
        /// </summary>
        Boolean TheUnitInInitializationStage;

        public bool Set_TheUnitInInitializationStage { get => TheUnitInInitializationStage; set => TheUnitInInitializationStage = value; }
    }
}
