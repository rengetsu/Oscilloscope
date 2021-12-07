using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oscilloscope
{
    /// <summary>
    /// Main Channel Class.
    /// </summary>
    public class Channel
    {
        /// <summary>
        /// Importing other classes which are needed for the channels to work 
        /// </summary>
        Handlers HND;
        BaseTypes BT;
        DeviceCheck DC;

        //  Scale Steps Int Value for first and second channel
        public int ScaleStepsIntValueChOne = 1;
        public int ScaleStepsIntValueChTwo = 1;

        //  Creating channels
        Channels ChannelOne = new Channels("1", true);
        Channels ChannelTwo = new Channels("2", true);

        public double[] Channels_VoltsByScale;

        private const int channel_number = 2;   //  В Arrow 2 канала

        private Channels[] channels;

        bool[] ch = new bool[2];

        /// <summary>
        /// The function that changes after changing the channel scale
        /// </summary>
        public void AfterChsScaleChangeA(String ActiveChName)
        {
            bool Ch1 = false;
            if (ActiveChName == "Ch1") { Ch1 = true; }
            else { Ch1 = false; }
            Double QS;
            
            QS = Channels_VoltsByScale[channel_number];

            //  (0.01 V, s10, Step1)
            if ((QS >= 0.0099) && (QS < 0.010001))
            {
                //  First channel
                if (Ch1)
                {
                    DC.SendCommandToTheUnit("CH1:SCALE s10");
                    ScaleStepsIntValueChOne = 1;
                }
                //  Second channel
                else
                {
                    DC.SendCommandToTheUnit("CH2:SCALE s10");
                    ScaleStepsIntValueChTwo = 1;
                }
            }
            //  (0.02 V, s20, Step2)
            else if ((QS >= 0.010001) && (QS <= 0.0201))
            {
                //  First channel
                if (Ch1)
                {
                    DC.SendCommandToTheUnit("CH1:SCALE s20");
                    ScaleStepsIntValueChOne = 2;
                }
                //  Second channel
                else
                {
                    DC.SendCommandToTheUnit("CH2:SCALE s20");
                    ScaleStepsIntValueChTwo = 2;
                }
            }
            //  (0.03 V, s30, Step3)
            else if ((QS >= 0.0201) && (QS <= 0.0301))
            {
                //  First channel
                if (Ch1)
                {
                    DC.SendCommandToTheUnit("CH1:SCALE s30");
                    ScaleStepsIntValueChOne = 3;
                }
                //  Second channel
                else
                {
                    DC.SendCommandToTheUnit("CH2:SCALE s30");
                    ScaleStepsIntValueChTwo = 3;
                }
            }
            //  (0.04 V, s40, Step4)
            else if ((QS >= 0.0301) && (QS < 0.0401))
            {
                //  First channel
                if (Ch1)
                {
                    DC.SendCommandToTheUnit("CH1:SCALE s40");
                    ScaleStepsIntValueChOne = 4;
                }
                //  Second channel
                else
                {
                    DC.SendCommandToTheUnit("CH2:SCALE s40");
                    ScaleStepsIntValueChTwo = 4;
                }
            }
            //  (0.05 V, s50, Step5)
            else if ((QS >= 0.0401) && (QS < 0.0501))
            {
                //  First channel
                if (Ch1)
                {
                    DC.SendCommandToTheUnit("CH1:SCALE s50");
                    ScaleStepsIntValueChOne = 5;
                }
                //  Second channel
                else
                {
                    DC.SendCommandToTheUnit("CH2:SCALE s50");
                    ScaleStepsIntValueChTwo = 5;
                }
            }
            //  (0.06 V, s60, Step6)
            else if ((QS >= 0.0501) && (QS < 0.0601))
            {
                //  First channel
                if (Ch1)
                {
                    DC.SendCommandToTheUnit("CH1:SCALE s60");
                    ScaleStepsIntValueChOne = 6;
                }
                //  Second channel
                else
                {
                    DC.SendCommandToTheUnit("CH2:SCALE s60");
                    ScaleStepsIntValueChTwo = 6;
                }
            }
            //  (0.07 V, s70, Step7)
            else if ((QS >= 0.0601) && (QS < 0.0701))
            {
                //  First channel
                if (Ch1)
                {
                    DC.SendCommandToTheUnit("CH1:SCALE s70");
                    ScaleStepsIntValueChOne = 7;
                }
                //  Second channel
                else
                {
                    DC.SendCommandToTheUnit("CH2:SCALE s70");
                    ScaleStepsIntValueChTwo = 7;
                }
            }
            //  (0.08 V, s80, Step8)
            else if ((QS >= 0.0701) && (QS < 0.0801))
            {
                //  First channel
                if (Ch1)
                {
                    DC.SendCommandToTheUnit("CH1:SCALE s80");
                    ScaleStepsIntValueChOne = 8;
                }
                //  Second channel
                else
                {
                    DC.SendCommandToTheUnit("CH2:SCALE s80");
                    ScaleStepsIntValueChTwo = 8;
                }
            }
            //  (0.09 V, s90, Step9)
            else if ((QS >= 0.0801) && (QS < 0.0901))
            {
                //  First channel
                if (Ch1)
                {
                    DC.SendCommandToTheUnit("CH1:SCALE s90");
                    ScaleStepsIntValueChOne = 9;
                }
                //  Second channel
                else
                {
                    DC.SendCommandToTheUnit("CH2:SCALE s90");
                    ScaleStepsIntValueChTwo = 9;
                }
            }
            //  (0.1 V, s100, Step10)
            else if ((QS >= 0.0901) && (QS < 0.101))
            {
                //  First channel
                if (Ch1)
                {
                    DC.SendCommandToTheUnit("CH1:SCALE s100");
                    ScaleStepsIntValueChOne = 10;
                }
                //  Second channel
                else
                {
                    DC.SendCommandToTheUnit("CH2:SCALE s100");
                    ScaleStepsIntValueChTwo = 10;
                }
            }
            //  (0.2 V, s200, Step11)
            else if ((QS >= 0.101) && (QS < 0.201))
            {
                //  First channel
                if (Ch1)
                {
                    DC.SendCommandToTheUnit("CH1:SCALE s200");
                    ScaleStepsIntValueChOne = 11;
                }
                //  Second channel
                else
                {
                    DC.SendCommandToTheUnit("CH2:SCALE s200");
                    ScaleStepsIntValueChTwo = 11;
                }
            }
            //  (0.3 V, s300, Step12)
            else if ((QS >= 0.201) && (QS < 0.301))
            { 
                //  First channel
                if (Ch1)
                {
                    DC.SendCommandToTheUnit("CH1:SCALE s300");
                    ScaleStepsIntValueChOne = 12;
                }
                //  Second channel
                else
                {
                    DC.SendCommandToTheUnit("CH2:SCALE s300");
                    ScaleStepsIntValueChTwo = 12;
                }
            }
            //  (0.4 V, s400, Step13)
            else if((QS >= 0.301) && (QS < 0.401))
            {
                //  First channel
                if (Ch1)
                {
                    DC.SendCommandToTheUnit("CH2:SCALE s400");
                    ScaleStepsIntValueChOne = 13;
                }
                //  Second channel
                else
                {
                    DC.SendCommandToTheUnit("CH2:SCALE s400");
                    ScaleStepsIntValueChTwo = 13;
                }
            }
            //  (0.5 V, s500, Step14)
            else if((QS >= 0.401) && (QS < 0.501))
            {
                //  First channel
                if (Ch1)
                {
                    DC.SendCommandToTheUnit("CH2:SCALE s500");
                    ScaleStepsIntValueChOne = 14;
                }
                //  Second channel
                else
                {
                    DC.SendCommandToTheUnit("CH2:SCALE s500");
                    ScaleStepsIntValueChTwo = 14;
                }
            }
            //  (0.6 V, s600, Step15)
            else if ((QS >= 0.501) && (QS < 0.601))
            {
                //  First channel
                if (Ch1)
                {
                    DC.SendCommandToTheUnit("CH2:SCALE s600");
                    ScaleStepsIntValueChOne = 15;
                }
                //  Second channel
                else
                {
                    DC.SendCommandToTheUnit("CH2:SCALE s600");
                    ScaleStepsIntValueChTwo = 15;
                }
            }
            //  (0.7 V, s700, Step16)
            else if ((QS >= 0.601) && (QS < 0.701))
            {
                //  First channel
                if (Ch1)
                {
                    DC.SendCommandToTheUnit("CH2:SCALE s700");
                    ScaleStepsIntValueChOne = 16;
                }
                //  Second channel
                else
                {
                    DC.SendCommandToTheUnit("CH2:SCALE s700");
                    ScaleStepsIntValueChTwo = 16;
                }
            }
            //  (0.8 V, s800, Step17)
            else if ((QS >= 0.701) && (QS < 0.801))
            {
                //  First channel
                if (Ch1)
                {
                    DC.SendCommandToTheUnit("CH2:SCALE s800");
                    ScaleStepsIntValueChOne = 17;
                }
                //  Second channel
                else
                {
                    DC.SendCommandToTheUnit("CH2:SCALE s800");
                    ScaleStepsIntValueChTwo = 17;
                }
            }
            //  (0.9 V, s900, Step18)
            else if ((QS >= 0.801) && (QS < 0.901))
            {
                //  First channel
                if (Ch1)
                {
                    DC.SendCommandToTheUnit("CH2:SCALE s900");
                    ScaleStepsIntValueChOne = 18;
                }
                //  Second channel
                else
                {
                    DC.SendCommandToTheUnit("CH2:SCALE s900");
                    ScaleStepsIntValueChTwo = 18;
                }
            }
            //  (1.0 V, s1000, Step19)
            else if ((QS <= 1.099) && (QS >= 0.901))
            {
                //  First channel
                if (Ch1)
                {
                    DC.SendCommandToTheUnit("CH2:SCALE s1000");
                    ScaleStepsIntValueChOne = 19;
                }
                //  Second channel
                else
                {
                    DC.SendCommandToTheUnit("CH2:SCALE s1000");
                    ScaleStepsIntValueChTwo = 19;
                }
            }
        }

        /// <summary>
        /// Channel
        /// </summary>
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
        /// Make Channels post init actions
        /// </summary>
        public void MakeChannelsPostInitActions()
        {
            uint MidBandBit;
            uint NarBandBit;
            Boolean Invis;

            for (int Ch = 0; Ch < channel_number; Ch++)
            {
                //  непонятно зачем выбрана чувствительность максимальная на 25% больше чем максимальный коэффициент полного отклонения? 
                //  Женька говорит, что это я придумал для Масок. А нафига там такой?
                Channels_VoltsByScale[Ch] = Channels_VoltsByScale[Ch] / 8 * 1.25;
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

            if(Result == 2)
            {
                BT.cADC_Period = 400E-12;
            }
            else
            {
                BT.cADC_Period = 200E-12;
            }

            if( HND.FCurrentSamplingMode() == "smsRandom" )
            {
                BT.cADC_Period = 400E-12;
            }

            //  RecordLengthToPribor(PriborRecLength);
            return Result;
        }
    }

    /// <summary>
    /// Channels internal class to create new channel
    /// </summary>
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

        /// <summary>
        /// Channel name (ChannelOne etc)
        /// </summary>
        public string CH_Name { get; }

        /// <summary>
        /// Channel acquired or not (true/false)
        /// </summary>
        public bool Acquired { get; }
    }
}
