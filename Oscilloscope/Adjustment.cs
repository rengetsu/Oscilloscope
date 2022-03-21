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
    }

    /// <summary>
    /// Adjustment - Vertical ADC Class
    /// </summary>
    class VerticalADC : Adjustment
    {
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
