using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oscilloscope
{
    public class EMITests
    {
        public int zero = 0;

        /// <summary>
        /// Sequence structure
        /// </summary>
        public struct Sequence
        {
            public Boolean isI2C;
            public String Addr;
            public String Dat;

            public Sequence(Boolean i2c, String adr, String dat)
            {
                isI2C = i2c;
                Addr = adr;
                Dat = dat;
            }
        }

        /// <summary>
        /// 2 AD Button Sequence
        /// </summary>
        Object[] ArrayOfObjects = new object[]
        {
            (I2C: false,    Address: "$28",         Data: "$0240"),         //  Выключаем CH1 VGA
            (I2C: false,    Address: "$29",         Data: "$0240"),         //  Выключаем CH2 VGA
            
            (I2C: false,    Address: "$2A",         Data: "$02"),           //  Rg_WriteRegSlowly(_RG_Ctrl_HS_ADC, 0x02)  
            (I2C: false,    Address: "$2A",         Data: "$00"),           //  Rg_WriteRegSlowly(_RG_Ctrl_HS_ADC, 0x00)

            (I2C: false,    Address: "21",          Data: "$0081"),
            (I2C: false,    Address: "20",          Data: "$0906"),         //  Установить FullBW 2AD-канальный режим HS ADC (2.5 Gbps)

            (I2C: true,     Address: "22",          Data: "$8A"),           //  0b10001010
            (I2C: true,     Address: "21",          Data: "$08"),           //  0b00001000

            (I2C: false,    Address: "$2A",         Data: "$08"),           //  Rg_WriteRegSlowly(_RG_Ctrl_HS_ADC, 0x08)
            (I2C: false,    Address: "$2A",         Data: "$00"),           //  Rg_WriteRegSlowly(_RG_Ctrl_HS_ADC, 0x00)

            (I2C: true,     Address: "22",          Data: "$85"),           //  0b10000101
            (I2C: true,     Address: "21",          Data: "$08"),           //  0b00001000

            (I2C: false,    Address: "$2A",         Data: "$00"),           //  Rg_WriteRegSlowly(0x2F, 0x10)

            (I2C: false,    Address: "$28",         Data: "$0220"),         //  Включаем CH1 VGA
            (I2C: false,    Address: "$29",         Data: "$0220"),         //  Включаем CH2 VGA

            (I2C: true,     Address: "14",          Data: "$00"),           //  0b000000000

            (I2C: true,     Address: "13",          Data: "$5500"),
            (I2C: true,     Address: "12",          Data: "$A000"),

            (I2C: false,    Address: int.MaxValue,  Data:   int.MaxValue)   //  Конец
        };

        /// <summary>
        /// Selects which sequence to do next 
        /// </summary>
        /// <param name="bitsSeqNmbr">Sequence number</param>
        public void DoNextSeq(int bitsSeqNmbr)
        {
            switch (bitsSeqNmbr)
            {
                case 8:
                    //  Load sequence for 8 bits button
                    DoSequenceCommand(0, ArrayOfObjects);
                    break;
                case 10:
                    //  Load sequence for 10 bits button
                    DoSequenceCommand(0, ArrayOfObjects);
                    break;
                case 12:
                    //  Load sequence for 12 bits button
                    DoSequenceCommand(0, ArrayOfObjects);
                    break;
                case 14:
                    //  Load sequence for I2C button
                    DoSequenceCommand(0, ArrayOfObjects);
                    break;
                case 15:
                    //  Load sequence for 2AD button
                    DoSequenceCommand(0, ArrayOfObjects);
                    break;
                case 16:
                    //  Load sequence for 2AD + 10 bits button
                    DoSequenceCommand(0, ArrayOfObjects);
                    break;
                default:
                    //  Didn't find the sequence 
                    throw new ArgumentOutOfRangeException("There is no such sequence");
            }
        }

        /// <summary>
        /// Executes all commands in sequence 
        /// </summary>
        /// <param name="cSeqLength">Number of commands in sequence</param>
        /// <param name="ArrayOfObjects">A set of sequence array objects</param>
        void DoSequenceCommand(int cSeqLength, Object[] ArrayOfObjects)
        {
            for( int i = zero; i < cSeqLength; i++ )
            {
                StepOp(ArrayOfObjects[i]);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="currentSequence"></param>
        void StepOp(Object currentSequence)
        {
            Sequence seq = new Sequence();
            bool q2 = seq.isI2C;
            string qq = seq.Addr;
            string q3 = seq.Dat;

            
        }
    }
}
