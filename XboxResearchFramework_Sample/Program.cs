using System;
using XboxResearchFramework;
using XboxResearchFramework.Drivers;

namespace XboxResearchFramework_Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine($"Serial Number: {PSPSRA.GetSerialNumber()}");
            Console.ReadLine();
            
        }
    }
}
