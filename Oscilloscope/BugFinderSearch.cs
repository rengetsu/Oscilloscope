using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oscilloscope
{
    /// <summary>
    /// Bug finder search
    /// </summary>
    public class BugFinderSearch
    {
        /// <summary>
        /// Bug finder call
        /// </summary>
        /// <param name="errorMessage"></param>
        /// <returns>return error message</returns>
        public String BugFinderCall(String errorMessage)
        {
            return errorMessage;
        }

        /// <summary>
        /// Bug finder error message
        /// </summary>
        /// <param name="errorMessage">Error message</param>
        void BugFinderErrorMessage(String errorMessage)
        {
            MessageBox.Show(errorMessage);
        }
    }
}
