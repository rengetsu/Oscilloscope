using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oscilloscope
{
    /// <summary>
    /// Class for General Calculations. <br/>
    /// Here are the calculation functions that are not present in the standard libraries. <br/>
    /// </summary>
    public class GeneralCalculations
    {
        /// <summary>
        /// Pos looks for the first complete occurrence of the specified String. generally offered literally, in single quotes — in Source. <br/>
        /// The Source is usually some variable. If Pos finds the string, it returns the character position in Source <br/>
        /// of the first character in Str as an integer value, otherwise it returns 0. The String and the Source must both be strings. <br/>
        /// </summary>
        /// <param name="SubStr">Sub Str</param>
        /// <param name="Str">Str</param>
        /// <param name="Offset">Offset.May not be declared, so by default equal to zero</param>
        /// <returns>Returns an integer specifying the position of the first occurrence of one string within another.</returns>
        public int Pos(String SubStr, String Str, int Offset = 0)
        {
            //  Variables used to store intermediate values 
            int I, LIterCnt, L, J, Result;
            Char PSubStr, PS;
            String PSS, PSSubStr;

            //  We save the length of the part of the incoming string (SubStr)
            L = SubStr.Length;

            //  Calculate the number of possible iterations. Not valid if Offset < 1.
            LIterCnt = Str.Length - Offset - L + 1;

            //Only continue if the number of iterations is positive or zero(there is space to check)
            if ((Offset > 0) && (LIterCnt >= 0) && (L > 0))
            {
                PSubStr = @SubStr[1];
                PS  = @Str[1];
                PS = Convert.ToChar(((int)PS)+(Offset - 1));

                //  In this loop we calculate the value
                for (I = 0; I < LIterCnt; I++)
                {
                    J = 0;
                    //  Will be executed until J becomes the size of the incoming string (L) 
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
                        //  Option one, returns character position in Source of the first character in Str as an integer value
                        return (I + Offset);
                    }
                }
            }
            //  Option two, returns zero
            Result = 0;
            return Result;
        }
    }
}
