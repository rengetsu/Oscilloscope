using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oscilloscope
{
    public class RandomGenerator
    {
        // Instantiate random number generator using system-supplied value as seed.
        Random rand = new Random();

        /// <summary>
        /// Generate random double
        /// </summary>
        /// <returns>Returns random double</returns>
        public double RandomGenDouble()
        {
            return rand.NextDouble();
        }

        /// <summary>
        /// Generate random number between min and max values
        /// </summary>
        /// <param name="MinVal">Minimum value</param>
        /// <param name="MaxVal">Maximum value</param>
        /// <returns>Returns a random number from a given interval</returns>
        public int RandomGen(int MinVal, int MaxVal)
        {
            return rand.Next(MinVal, MaxVal);
        }
    }
}
