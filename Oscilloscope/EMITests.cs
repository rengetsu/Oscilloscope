using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oscilloscope
{
    public class EMITests
    {
        static string cDigPort_0_7_Index = "8";
        static string cDigPort_10_17_Index = "9";

        //  Cycle variables
        public int zero = 0, cycle;

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
        /// Next are the sequences of objects for EMI tests
        /// </summary>

        // cSeq10bits  кнопка 10bit
        int cInit10bits = 15;

        Object[] cSeq10bits = new object[]
        {
            (I2C: false,    Address: "$08",                 Data: "$02"),
            (I2C: false,    Address: "$2A",                 Data: "$02"),
            (I2C: false,    Address: "$2A",                 Data: "$00"),
            (I2C: false,    Address: "$21",                 Data: "$81"),
            (I2C: false,    Address: "$20",                 Data: "$1508"),
            (I2C: true,     Address: cDigPort_10_17_Index,  Data: "$0C"),
            (I2C: true,     Address: cDigPort_0_7_Index,    Data: "$D3"),
            (I2C: false,    Address: "$21",                 Data: "$86"),
            (I2C: false,    Address: "$20",                 Data: "$02"),
            (I2C: true,     Address: cDigPort_10_17_Index,  Data: "$0C"),
            (I2C: true,     Address: cDigPort_0_7_Index,    Data: "$D3"),
            (I2C: false,    Address: "$2A",                 Data: "$08"),
            (I2C: false,    Address: "$2A",                 Data: "$00"),
            (I2C: false,    Address: "$2F",                 Data: "$10"),
            (I2C: false,    Address: int.MaxValue,          Data: int.MaxValue)    //  Конец
          };


        // cSeq2A10bits кнопка 10bit + Only A
        int cInit2A10bits = 35;

        Object[] cSeq2A10bits = new object[]
        {
            (I2C: false,    Address: "$08",                 Data: "$02"),
            (I2C: false,    Address: "$2A",                 Data: "$02"),
            (I2C: false,    Address: "$2A",                 Data: "$00"),
            (I2C: false,    Address: "$21",                 Data: "$81"),
            (I2C: false,    Address: "$20",                 Data: "$1508"),
            (I2C: true,     Address: cDigPort_10_17_Index,  Data: "$0C"),
            (I2C: true,     Address: cDigPort_0_7_Index,    Data: "$D3"),
            (I2C: false,    Address: "$21",                 Data: "$86"),
            (I2C: false,    Address: "$20",                 Data: "$02"),
            (I2C: true,     Address: cDigPort_10_17_Index,  Data: "$0C"),
            (I2C: true,     Address: cDigPort_0_7_Index,    Data: "$D3"),
            (I2C: false,    Address: "$2A",                 Data: "$08"),
            (I2C: false,    Address: "$2A",                 Data: "$00"),
            (I2C: false,    Address: "$2F",                 Data: "$10"),
            (I2C: true,     Address: "0",                   Data: "$8000"),
            (I2C: true,     Address: "1",                   Data: "$8000"),
            (I2C: true,     Address: "4",                   Data: "$8000"),
            (I2C: true,     Address: "5",                   Data: "$8000"),
            (I2C: false,    Address: "$28",                 Data: "$0240"),     //  Выключаем CH1 VGA
            (I2C: false,    Address: "$29",                 Data: "$0240"),     //  Выключаем CH2 VGA
            (I2C: false,    Address: "$21",                 Data: "$81"),
            (I2C: false,    Address: "$20",                 Data: "$0108"),     //  Установить FullBW 2-A-канальный режим HS ADC (5 Gbps)
            (I2C: false,    Address: "$84",                 Data: "$00"),
            (I2C: true,     Address: "22",                  Data: "$8A"),       //  0b10001010
            (I2C: true,     Address: "21",                  Data: "$08"),       //  0b00001000
            (I2C: false,    Address: "$2A",                 Data: "$00"),
            (I2C: false,    Address: "$2A",                 Data: "$00"),
            (I2C: true,     Address: "22",                  Data: "$85"),       //  0b10000101
            (I2C: true,     Address: "21",                  Data: "$08"),       //  0b00001000
            (I2C: false,    Address: "$28",                 Data: "$0220"),     //  Включаем CH1 VGA
            (I2C: false,    Address: "$29",                 Data: "$0220"),     //  Включаем CH2 VGA
            (I2C: true,     Address: "14",                  Data: "$00"),       //  0b000000000
            (I2C: true,     Address: "13",                  Data: "$5500"),
            (I2C: true,     Address: "12",                  Data: "$A000"),
            (I2C: false,    Address: int.MaxValue,          Data: int.MaxValue)    //  Конец
          };


        // cSeq2AD10bits 10bit + Only D
        int cInit1D10bits = 35;

        Object[] cSeq1D10bits = new object[]
        {
            (I2C: false,    Address: "$08",                 Data: "$02"),
            (I2C: false,    Address: "$2A",                 Data: "$02"),
            (I2C: false,    Address: "$2A",                 Data: "$00"),
            (I2C: false,    Address: "$21",                 Data: "$81"),
            (I2C: false,    Address: "$20",                 Data: "$1508"),
            (I2C: true,     Address: cDigPort_10_17_Index,  Data: "$0C"),
            (I2C: true,     Address: cDigPort_0_7_Index,    Data: "$D3"),
            (I2C: false,    Address: "$21",                 Data: "$86"),
            (I2C: false,    Address: "$20",                 Data: "$02"),
            (I2C: true,     Address: cDigPort_10_17_Index,  Data: "$0C"),
            (I2C: true,     Address: cDigPort_0_7_Index,    Data: "$D3"),
            (I2C: false,    Address: "$2A",                 Data: "$08"),
            (I2C: false,    Address: "$2A",                 Data: "$00"),
            (I2C: false,    Address: "$2F",                 Data: "$10"),
            (I2C: true,     Address: "0",                   Data: "$8000"),
            (I2C: true,     Address: "1",                   Data: "$8000"),
            (I2C: true,     Address: "4",                   Data: "$8000"),
            (I2C: true,     Address: "5",                   Data: "$8000"),
            (I2C: false,    Address: "$28",                 Data: "$0240"),     //  Выключаем CH1 VGA
            (I2C: false,    Address: "$29",                 Data: "$0240"),     //  Выключаем CH2 VGA
            (I2C: false,    Address: "$21",                 Data: "$81"),
            (I2C: false,    Address: "$20",                 Data: "$010B"),         //  Установить FullBW 1-D-канальный режим HS ADC (5 Gbps)
            (I2C: false,    Address: "$84",                 Data: "$00"),
            (I2C: true,     Address: "22",                  Data: "$8A"),       //  0b10001010
            (I2C: true,     Address: "21",                  Data: "$08"),       //  0b00001000
            (I2C: false,    Address: "$2A",                 Data: "$00"),
            (I2C: false,    Address: "$2A",                 Data: "$00"),
            (I2C: true,     Address: "22",                  Data: "$85"),       //  0b10000101
            (I2C: true,     Address: "21",                  Data: "$08"),       //  0b00001000
            (I2C: false,    Address: "$28",                 Data: "$0220"),     //  Включаем CH1 VGA
            (I2C: false,    Address: "$29",                 Data: "$0220"),     //  Включаем CH2 VGA
            (I2C: true,     Address: "14",                  Data: "$00"),       //  0b000000000
            (I2C: true,     Address: "13",                  Data: "$5500"),
            (I2C: true,     Address: "12",                  Data: "$A000"),
            (I2C: false,    Address: int.MaxValue,          Data: int.MaxValue)    //  Конец
          };


        // cSeq2AD10bits 10bit + 2AD
        int cInit2AD10bits = 35;

        Object[] cSeq2AD10bits = new object[]
        {
            (I2C: false,    Address: "$08",                 Data: "$02"),
            (I2C: false,    Address: "$2A",                 Data: "$02"),
            (I2C: false,    Address: "$2A",                 Data: "$00"),
            (I2C: false,    Address: "$21",                 Data: "$81"),
            (I2C: false,    Address: "$20",                 Data: "$1508"),
            (I2C: true,     Address: cDigPort_10_17_Index,  Data: "$0C"),
            (I2C: true,     Address: cDigPort_0_7_Index,    Data: "$D3"),
            (I2C: false,    Address: "$21",                 Data: "$86"),
            (I2C: false,    Address: "$20",                 Data: "$02"),
            (I2C: true,     Address: cDigPort_10_17_Index,  Data: "$0C"),
            (I2C: true,     Address: cDigPort_0_7_Index,    Data: "$D3"),
            (I2C: false,    Address: "$2A",                 Data: "$08"),
            (I2C: false,    Address: "$2A",                 Data: "$00"),
            (I2C: false,    Address: "$2F",                 Data: "$10"),
            (I2C: true,     Address: "0",                   Data: "$8000"),
            (I2C: true,     Address: "1",                   Data: "$8000"),
            (I2C: true,     Address: "4",                   Data: "$8000"),
            (I2C: true,     Address: "5",                   Data: "$8000"),
            (I2C: false,    Address: "$28",                 Data: "$0240"),     //  Выключаем CH1 VGA
            (I2C: false,    Address: "$29",                 Data: "$0240"),     //  Выключаем CH2 VGA
            (I2C: false,    Address: "$21",                 Data: "$81"),
            (I2C: false,    Address: "$20",                 Data: "$106"),     //  Установить FullBW 2AD-канальный режим HS ADC (2.5 Gbps)
            (I2C: false,    Address: "$84",                 Data: "$10"),
            (I2C: true,     Address: "22",                  Data: "$8A"),       //  0b10001010
            (I2C: true,     Address: "21",                  Data: "$08"),       //  0b00001000
            (I2C: false,    Address: "$2A",                 Data: "$00"),
            (I2C: false,    Address: "$2A",                 Data: "$00"),
            (I2C: true,     Address: "22",                  Data: "$85"),       //  0b10000101
            (I2C: true,     Address: "21",                  Data: "$08"),       //  0b00001000
            (I2C: false,    Address: "$28",                 Data: "$0220"),     //  Включаем CH1 VGA
            (I2C: false,    Address: "$29",                 Data: "$0220"),     //  Включаем CH2 VGA
            (I2C: true,     Address: "14",                  Data: "$00"),       //  0b000000000
            (I2C: true,     Address: "13",                  Data: "$5500"),
            (I2C: true,     Address: "12",                  Data: "$A000"),
            (I2C: false,    Address: int.MaxValue,          Data: int.MaxValue)    //  Конец
          };


        //  Кнопка Only A
        //  2A      Установить FullBW 2-A-канальный режим HS ADC (5 Gbps)
        int cInitOps2A = 21;   //  2A amount of elements

        Object[] cSeq2A = new object[]
        {
            (I2C: true,     Address: "0",                   Data: "$8000"),         //  Hold off
            (I2C: true,     Address: "1",                   Data: "$8000"),         //  Hold off
            (I2C: true,     Address: "4",                   Data: "$8000"),         //  Hold off
            (I2C: true,     Address: "5",                   Data: "$8000"),         //  Hold off
            (I2C: false,    Address: "$28",                 Data: "$0240"),         //  Выключаем CH1 VGA
            (I2C: false,    Address: "$29",                 Data: "$0240"),         //  Выключаем CH2 VGA
            (I2C: false,    Address: "$21",                 Data: "$0081"),
            (I2C: false,    Address: "$20",                 Data: "$0108"),         //  Установить FullBW 2-A-канальный режим HS ADC (5 Gbps)
            (I2C: true,     Address: "22",                  Data: "$8A"),           //  0b10001010
            (I2C: true,     Address: "21",                  Data: "$08"),           //  0b00001000
            (I2C: false,    Address: "$84",                 Data: "$00"),
            (I2C: false,    Address: "$2A",                 Data: "$00"),           //  Rg_WriteRegSlowly(_RG_Ctrl_HS_ADC, 0x08)
            (I2C: false,    Address: "$2A",                 Data: "$00"),           //  Rg_WriteRegSlowly(_RG_Ctrl_HS_ADC, 0x00)
            (I2C: true,     Address: "22",                  Data: "$85"),           //  0b10000101
            (I2C: true,     Address: "21",                  Data: "$08"),           //  0b00001000
            (I2C: false,    Address: "$28",                 Data: "$0220"),         //  Включаем CH1 VGA
            (I2C: false,    Address: "$29",                 Data: "$0220"),         //  Включаем CH2 VGA
            (I2C: true,     Address: "14",                  Data: "$00"),           //  0b000000000
            (I2C: true,     Address: "13",                  Data: "$5500"),
            (I2C: true,     Address: "12",                  Data: "$A000"),
            (I2C: false,    Address: int.MaxValue,          Data:   int.MaxValue)   //  Конец
        };


        //  Кнопка Only D
        //  1D      Установить FullBW 1-D-канальный режим HS ADC (5 Gbps)
        int cInitOps1D = 21;   //  1D amount of elements

        Object[] cSeq1D = new object[]
        {
            (I2C: true,     Address: "0",                   Data: "$8000"),         //  Hold off
            (I2C: true,     Address: "1",                   Data: "$8000"),         //  Hold off
            (I2C: true,     Address: "4",                   Data: "$8000"),         //  Hold off
            (I2C: true,     Address: "5",                   Data: "$8000"),         //  Hold off
            (I2C: false,    Address: "$28",                 Data: "$0240"),         //  Выключаем CH1 VGA
            (I2C: false,    Address: "$29",                 Data: "$0240"),         //  Выключаем CH2 VGA
            (I2C: false,    Address: "$21",                 Data: "$0081"),
            (I2C: false,    Address: "$20",                 Data: "$010B"),         //  Установить FullBW 1-D-канальный режим HS ADC (5 Gbps)
            (I2C: true,     Address: "22",                  Data: "$8A"),           //  0b10001010
            (I2C: true,     Address: "21",                  Data: "$08"),           //  0b00001000
            (I2C: false,    Address: "$84",                 Data: "$00"),
            (I2C: false,    Address: "$2A",                 Data: "$00"),           //  Rg_WriteRegSlowly(_RG_Ctrl_HS_ADC, 0x08)
            (I2C: false,    Address: "$2A",                 Data: "$00"),           //  Rg_WriteRegSlowly(_RG_Ctrl_HS_ADC, 0x00)
            (I2C: true,     Address: "22",                  Data: "$85"),           //  0b10000101
            (I2C: true,     Address: "21",                  Data: "$08"),           //  0b00001000
            (I2C: false,    Address: "$28",                 Data: "$0220"),         //  Включаем CH1 VGA
            (I2C: false,    Address: "$29",                 Data: "$0220"),         //  Включаем CH2 VGA
            (I2C: true,     Address: "14",                  Data: "$00"),           //  0b000000000
            (I2C: true,     Address: "13",                  Data: "$5500"),
            (I2C: true,     Address: "12",                  Data: "$A000"),
            (I2C: false,    Address: int.MaxValue,          Data:   int.MaxValue)   //  Конец
        };


        //  Кнопка 2AD
        //  2AD     Установить FullBW 2AD-канальный режим HS ADC (2.5 Gbps)
        int cInitOps2AD = 21;   //  2AD amount of elements

        Object[] cSeq2AD = new object[]
        {
            (I2C: true,     Address: "0",                   Data: "$8000"),         //  Hold off
            (I2C: true,     Address: "1",                   Data: "$8000"),         //  Hold off
            (I2C: true,     Address: "4",                   Data: "$8000"),         //  Hold off
            (I2C: true,     Address: "5",                   Data: "$8000"),         //  Hold off
            (I2C: false,    Address: "$28",                 Data: "$0240"),         //  Выключаем CH1 VGA
            (I2C: false,    Address: "$29",                 Data: "$0240"),         //  Выключаем CH2 VGA
            (I2C: false,    Address: "$21",                 Data: "$0081"),
            (I2C: false,    Address: "$20",                 Data: "$0106"),         //  Установить FullBW 2AD-канальный режим HS ADC (2.5 Gbps)
            (I2C: true,     Address: "22",                  Data: "$8A"),           //  0b10001010
            (I2C: true,     Address: "21",                  Data: "$08"),           //  0b00001000
            (I2C: false,    Address: "$2A",                 Data: "$00"),           //  Rg_WriteRegSlowly(_RG_Ctrl_HS_ADC, 0x08)
            (I2C: false,    Address: "$2A",                 Data: "$00"),           //  Rg_WriteRegSlowly(_RG_Ctrl_HS_ADC, 0x00)
            (I2C: false,    Address: "$84",                 Data: "$10"),
            (I2C: true,     Address: "22",                  Data: "$85"),           //  0b10000101
            (I2C: true,     Address: "21",                  Data: "$08"),           //  0b00001000
            (I2C: false,    Address: "$28",                 Data: "$0220"),         //  Включаем CH1 VGA
            (I2C: false,    Address: "$29",                 Data: "$0220"),         //  Включаем CH2 VGA
            (I2C: true,     Address: "14",                  Data: "$00"),           //  0b000000000
            (I2C: true,     Address: "13",                  Data: "$5500"),
            (I2C: true,     Address: "12",                  Data: "$A000"),
            (I2C: false,    Address: int.MaxValue,          Data:   int.MaxValue)   //  Конец
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
                    //  Load sequence for 10 bits button
                    DoSequenceCommand(cInit10bits, cSeq10bits);
                    break;
                case 10:
                    //  Load sequence for A button
                    DoSequenceCommand(cInitOps2A, cSeq2A);
                    break;
                case 12:
                    //  Load sequence for D button
                    DoSequenceCommand(cInitOps1D, cSeq1D);
                    break;
                case 14:
                    //  Load sequence for 2AD button
                    DoSequenceCommand(cInitOps2AD, cSeq2AD);
                    break;
                case 15:
                    //  Load sequence for 10 bits + A button
                    DoSequenceCommand(cInit2A10bits, cSeq2A10bits);
                    break;
                case 16:
                    //  Load sequence for 10 bits + D button
                    DoSequenceCommand(cInit1D10bits, cSeq1D10bits);
                    break;
                case 17:
                    //  Load sequence for 10 bits + 2AD button
                    DoSequenceCommand(cInit2AD10bits, cSeq2AD10bits);
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
            //  Sending a set of sequence array to a cycle
            for( cycle = zero; cycle < cSeqLength; cycle++ )
            {
                SeqStepNext(ArrayOfObjects[cycle]);
            }
        }

        /// <summary>
        /// Sequence next step
        /// </summary>
        /// <param name="currentSequence"></param>
        void SeqStepNext(Object currentSequence)
        {
            Sequence seq = new Sequence();
            //  Rewrite
            bool q2 = seq.isI2C;
            string qq = seq.Addr;
            string q3 = seq.Dat;
        }
    }
}
