using System;
using XboxResearchFramework.Console;
using XboxResearchFramework.Win32;

namespace Oracle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Oracle");
            string Serial = ConsoleInfo.GetConsoleSerialNumber();
            Console.WriteLine(Serial);
            
        }
    }
}
