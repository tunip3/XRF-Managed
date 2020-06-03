using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using XboxResearchFramework.Win32;

namespace XboxResearchFramework.Console
{
    public class ConsoleInfo
    {
        public string SerialNumber;
        public string ConsoleID;
        static internal bool HasInitializedXbla = false;

        public ConsoleInfo()
        {
            long Serial = 0;
            string ConsoleID = "";
            if (!HasInitializedXbla)
            {
                XblAuthConsoleExt.XblaInitialize();
            }
            System.Console.WriteLine($"Initialize XblaConsoleExt: {new Win32Exception(Marshal.GetLastWin32Error()).Message}");
            //XblAuthConsoleExt.XblaGetConsoleSerialNumber(out Serial);
            System.Console.WriteLine($"XblaGetSerial: {new Win32Exception(Marshal.GetLastWin32Error()).Message}");
            //XblAuthConsoleExt.XblaGetConsoleId(out ConsoleID);
            System.Console.WriteLine($"XblaGetConsoleID: {new Win32Exception(Marshal.GetLastWin32Error()).Message}");
            SerialNumber = Serial.ToString();
            ConsoleID = ConsoleID;
        }

        public static string GetConsoleSerialNumber()
        {
            if (!HasInitializedXbla)
            {
                XblAuthConsoleExt.XblaInitialize();
            }
            IntPtr SerialPtr = IntPtr.Zero;
            byte[] SerialBufferManaged = new byte[50];
            XblAuthConsoleExt.XblaGetConsoleSerialNumber(out SerialPtr);
            Marshal.Copy(SerialPtr, SerialBufferManaged, 0, 50);
            StringBuilder sb = new StringBuilder();
            Array.Reverse(SerialBufferManaged, 0, 50);
            foreach(byte b in SerialBufferManaged)
            {
                sb.Append(b);
            }
            string SerialNumber = Utilities.Converters.HexString2Ascii(sb.ToString());
            return SerialNumber.ToString();
            
        }
    }
}
