using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oscilloscope
{
    public class RandomGenerator
    {
        //  Random Class
        Random rand = new Random();


        public double randomGen()
        {
            return rand.NextDouble();
        }
    }
}
