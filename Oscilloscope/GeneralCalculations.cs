using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oscilloscope
{
    /// <summary>
    /// Class for General Calculations
    /// </summary>
    public class GeneralCalculations
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="SubStr"></param>
        /// <param name="Str"></param>
        /// <param name="Offset"></param>
        /// <returns></returns>
        public int Pos(String SubStr, String Str, int Offset = 0)
        {
            int I, LIterCnt, L, J, Result;
            Char PSubStr, PS;
            String PSS, PSSubStr;

            L = SubStr.Length;

            //  Calculate the number of possible iterations. Not valid if Offset < 1.
            LIterCnt = Str.Length - Offset - L + 1;

            //Only continue if the number of iterations is positive or zero(there is space to check)

            if ((Offset > 0) && (LIterCnt >= 0) && (L > 0))
            {
                PSubStr = @SubStr[1];
                PS  = @Str[1];
                PS = Convert.ToChar(((int)PS)+(Offset - 1));

                for (I = 0; I < LIterCnt; I++)
                {
                    J = 0;
                    while ((J >= 0) && (J < L))
                    {
                        PSS = PS.ToString();
                        PSSubStr = PSubStr.ToString();
                        if (PSS[I + J] == PSSubStr[J])
                        {
                            J++;
                        }
                        else
                        {
                            J = -1;
                        }
                    }
                    if (J >= L)
                    {
                        return(I + Offset);
                    }
                }
            }
            Result = 0;
            return Result;
        }
    }
}
