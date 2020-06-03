using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XboxResearchFramework.Win32;

namespace XboxResearchFramework.Console
{
    public class ConsoleInfo
    {
        public static string SerialNumber;
        public static string ConsoleID;

        ConsoleInfo()
        {
            string Serial = "";
            string ConsoleID = "";
            Native.XblaGetConsoleSerialNumber(out Serial);
            Native.XblaGetConsoleId(out ConsoleID);
            SerialNumber = Serial;
            ConsoleID = ConsoleID;
        }
    }
}
