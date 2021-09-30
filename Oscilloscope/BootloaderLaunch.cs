using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oscilloscope
{
    public class BootloaderLaunch
    {
        //  Mode checkers  
        private static Boolean ModeDebug;
        private static Boolean ModeRelease;

        /// <summary>
        /// Get Current Mode. <br/>
        /// Now this function is used only in some DeviceInterface elements. <br/>
        /// It's bad way to check is device is connected or not, so need to rewrite it for something better later <br/>
        /// </summary>
        /// <returns>It returns 'R' if now we work with real device that connected and work <br/>
        /// and 'D' if we working in demo mode (if device is not connected or not recognized).</returns>
        public char GetCurrentMode()
        {
            if(ModeRelease == true || ModeDebug == true)
            {
                return 'R';
            }    
            else
            {
                return 'D';
            }
        }

        /// <summary>
        /// Mode change function
        /// New modes may be added in the future
        /// </summary>
        /// <param name="newModeCommand">The command with the name of the mode that we want to set</param>
        public void changeMode(string newModeCommand)
        {
            switch( newModeCommand )
            {
                //  Set Release Mode
                case "Relase":
                    ModeDebug = false;
                    ModeRelease = true;
                    break;
                //  Set Debug Mode
                case "Debug":
                    ModeDebug = true;
                    ModeRelease = false;
                    break;
                //  Set Debug Mode by default
                default:
                    ModeDebug = true;
                    ModeRelease = false;
                    break;
            }
        }

        /// <summary>
        /// The function that creates the path to the current version
        /// from the path and the name of the selected version 
        /// </summary>
        /// <returns>Returns selected version load path</returns>
        public string getLoadPath()
        {
            //  loadPath - A variable that returns the path to the program in the current run version 
            string loadPath = GetDirectoryPath() + GetModePath();
            return loadPath;
        }

        /// <summary>
        /// The function that gets the path to the current directory
        /// </summary>
        /// <returns>Returns current directory path</returns>
        private static string GetDirectoryPath()
        {
            string path = Directory.GetCurrentDirectory();
            return path;
        }

        /// <summary>
        /// The function that gets the path of current mode
        /// </summary>
        /// <returns>Returns the path of current mode</returns>
        private static string GetModePath()
        {
            string versionPref = "//";
            string versionName = ".";
            string versionType = ".exe";

            //  Debug
            if( ModeDebug ) {
                versionName = "PicoSample5";
            }
            //  Release
            else {
                versionName = "PicoSample5";
            }
            string ModePath = versionPref + versionName + versionType;
            return ModePath;
        }
    }
}
