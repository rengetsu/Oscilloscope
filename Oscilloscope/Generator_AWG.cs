using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oscilloscope
{
    /// <summary>
    /// All functions related to the operation of the AWG generator are located here
    /// </summary>
    public class Generator_AWG
    {
        //  Including Device Interface Class to send commands to device
        DeviceInterface DI;

        /// <summary>
        /// Further variables that are used in AWG
        /// </summary>

        //  A variable that tells the command whether to stop collection at runtime
        Boolean SborStatusCheck = false;

        //  Core command to send to AWG
        String CommandSpace = " ";
        String AWG_Calibration_Command = "GEN:AWG:AWGWR";

        //  AWG cycle variables
        int zero = 0;
        int calibration_cycle = 0;          //  Variable used in the cycle of sending commands to AWG 
        int number_of_calibrations = 160;   //  How many commands will need to be sent 

        /// <summary>
        /// Following are the addresses and data arrays to send to AWG Calibration function in cycle
        /// </summary>

        //  AWG adress array
        String[] AWG_AdressArray = 
        {
            "00", "01", "02", "03", "04", "05", "06", "07", "08", "09", //  1
            "0A", "0B", "0C", "0D", "0E", "0F", "10", "11", "12", "13", //  2
            "14", "15", "16", "17", "18", "19", "1A", "1B", "1C", "1D", //  3
            "1E", "1F", "20", "21", "22", "23", "24", "25", "26", "27", //  4
            "28", "29", "2A", "2B", "2C", "2D", "2E", "2F", "30", "31", //  5
            "32", "33", "34", "35", "36", "37", "38", "39", "3A", "3B", //  6
            "3C", "3D", "3E", "3F", "40", "41", "42", "43", "44", "45", //  7
            "46", "47", "48", "49", "4A", "4B", "4C", "4D", "4E", "4F", //  8
            "50", "51", "52", "53", "54", "55", "56", "57", "58", "59", //  9
            "5A", "5B", "5C", "5D", "5E", "5F", "60", "61", "62", "63", //  10
            "64", "65", "66", "67", "68", "69", "6A", "6B", "6C", "6D", //  11
            "6E", "6F", "70", "71", "72", "73", "74", "75", "76", "77", //  12
            "78", "79", "7A", "7B", "7C", "7D", "7E", "7F", "80", "81", //  13
            "82", "83", "84", "85", "86", "87", "88", "89", "8A", "8B", //  14
            "8C", "8D", "8E", "8F", "90", "91", "92", "93", "94", "95", //  15
            "96", "97", "98", "99", "9A", "9B", "9C", "9D", "9E", "9F"  //  16
        };

        //  AWG data array
        String[] AWG_DataArray =
        {
            "E1", "FF", "00", "00", "00", "00", "00", "00", "00", "FF", //  1
            "01", "C0", "00", "B6", "B4", "92", "80", "0C", "81", "80", //  2
            "00", "03", "8C", "06", "40", "00", "00", "00", "9F", "FF", //  3
            "E0", "80", "00", "81", "01", "00", "00", "00", "00", "00", //  4
            "00", "00", "04", "00", "00", "00", "60", "00", "00", "00", //  5
            "00", "00", "00", "00", "00", "00", "00", "00", "04", "00", //  6
            "00", "00", "00", "00", "00", "00", "00", "00", "00", "00", //  7
            "00", "00", "00", "00", "04", "00", "00", "00", "00", "00", //  8
            "00", "00", "00", "00", "00", "00", "00", "00", "00", "00", //  9
            "04", "00", "00", "00", "00", "00", "1B", "01", "BB", "00", //  10
            "BB", "00", "BB", "00", "FF", "44", "00", "00", "00", "00", //  11
            "00", "B0", "00", "60", "00", "00", "CE", "00", "E3", "01", //  12
            "01", "10", "02", "08", "60", "05", "14", "02", "00", "00", //  13
            "00", "00", "00", "00", "00", "00", "00", "00", "00", "00", //  14
            "00", "00", "00", "00", "00", "00", "00", "00", "00", "00", //  15
            "00", "00", "00", "64", "00", "00", "00", "10", "94", "B4"  //  16
        };

        //  AWG start adress array
        String[] AWG_Start_AdressArray =
        {
            "0x78", "0x77", "0x76", "0x75", "0x74", "0x76", "0x75", "0x76",
            "0x72", "0x72", "0x72", "0x01", "0x00", "0x00", "0x01", "0x01", "0x78", "0x77",
            "0x74", "0x73", "0x74", "0x76", "0x75", "0x76", "0x72", "0x72", "0x72", "0x01",
            "0x72", "0x72", "0x01", "0x78", "0x77", "0x74", "0x73", "0x74", "0x76", "0x75",
            "0x76", "0x72", "0x72", "0x72", "0x01", "0x78", "0x77", "0x74", "0x73", "0x74",
            "0x76", "0x75", "0x76", "0x72", "0x72", "0x72", "0x01", "0x01", "0x78", "0x77",
            "0x74", "0x73", "0x74", "0x76", "0x75", "0x76", "0x72", "0x72"
        };

        //  AWG start data array
        String[] AWG_Start_DataArray =
        {
            "0x01", "0x01", "0x00", "0x00", "0x4E", "0x00", "0x00", "0x63",
            "0x00", "0xF1", "0xF0", "0x00", "0xFF", "0x00", "0xFF", "0x00", "0x01", "0x01",
            "0x00", "0x0C", "0xCE", "0x00", "0x0C", "0xE3", "0x00", "0xF1", "0xF0", "0x00",
            "0xF1", "0xF0", "0x00", "0x01", "0x01", "0x00", "0x66", "0xCE", "0x00", "0x66",
            "0xE3", "0x00", "0xF1", "0xF0", "0x00", "0x01", "0x01", "0x00", "0x93", "0xCE",
            "0x00", "0x93", "0xE3", "0x00", "0xF1", "0xF1", "0x00", "0xFF", "0x01", "0x01",
            "0x00", "0x00", "0xCE", "0x00", "0x00", "0xE3", "0xF1", "0xF0"
    };

        //  AWG calibration functions

        /// <summary>
        /// Function to send AWG calibration commands in cycle
        /// </summary>
        /// <param name="CommandStart">Command Start</param>
        /// <param name="Address">Address</param>
        /// <param name="Data">Data</param>
        /// <param name="SborCheck">Sbor Check</param>
        private void SendAWGCalibrationCommand(String CommandStart, String Address, String Data, Boolean SborCheck)
        {
            String Command = CommandStart + CommandSpace + Address + CommandSpace + Data;
            DI.SendCommantToTheUnit(Command, SborCheck);
        }

        /// <summary>
        /// AWG calibration function
        /// </summary>
        public void AWG_Calibration()
        {
            //  The cycle of sending AWG calibation commands to the device 
            for (calibration_cycle = zero; calibration_cycle < number_of_calibrations; calibration_cycle++)
            {   
                //  Sending command with command start, address, data and status of terminate sbor
                SendAWGCalibrationCommand(
                    AWG_Calibration_Command,
                    AWG_AdressArray[calibration_cycle],
                    AWG_DataArray[calibration_cycle],
                    SborStatusCheck);
            }
        }

        /// <summary>
        /// PLL sequence send
        /// </summary>
        /// <param name="seq_nmbr">Sequence send</param>
        public void _PLL_SEQ_SEND(int seq_nmbr)
        {
            String Command = "GEN:AWG:TEST? " + seq_nmbr.ToString();
            DI.SendCommantToTheUnit(Command, false);
        }
    }
}
