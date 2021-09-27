using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oscilloscope
{
    public class Channel
    {
        private const int channel_number = 2;   //  В Arrow 2 канала

        private Channels[] channels;

        bool[] ch = new bool[2];

        public Channel()
        {
            foreach (bool res in ch)
            {
                ch[ch.Length - 1] = true;
            }
        }

        /// <summary>
        /// Channel constructor
        /// </summary>
        /// <param name="acquired"></param>
        /// <param name="names"></param>
        public Channel(Boolean acquired, params string[] names)
        {
            channels = new Channels[names.Length];
            for (int i = 0; i < names.Length; i++)
            {
                channels[i] = new Channels(names[i], acquired);
            }
        }

        /// <summary>
        /// Get Count Of Acquired Channels function
        /// </summary>
        /// <returns>Returns integer number of acquired channels</returns>
        public int GetCountOfAcquiredChannels()
        {
            int Result = 0;
            for ( int current_channel = 0; current_channel < channel_number; current_channel++ )
            {
                if( ch[current_channel] == true)
                {
                    Result++;
                }
            }
            //  RecordLengthToPribor(PriborRecLength);
            return Result;
        }
    }

    internal class Channels
    {
        /// <summary>
        /// Channels constructor
        /// </summary>
        /// <param name="ch_name">Channel name as main parameter</param>
        /// <param name="acquired">Acquired or not now</param>
        public Channels(string ch_name, bool acquired)
        {
            CH_Name = ch_name;
            Acquired = acquired;
        }

        public string CH_Name { get; }
        public bool Acquired { get; }
    }
}
