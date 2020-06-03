using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace XboxResearchFramework.Win32
{
    internal static class XblAuthConsoleExt
    {
        [DllImport("XblAuthConsoleExt.dll", SetLastError = true)]
        internal static extern bool XblaGetConsoleSerialNumber(out IntPtr SerialPtr);
        [DllImport("XblAuthConsoleExt.dll", SetLastError = true)]
        internal static extern bool XblaGetConsoleId(out IntPtr ConsoleIDPtr);
        [DllImport("XblAuthConsoleExt.dll", SetLastError = true)]
        internal static extern void XblaInitialize();
    }
}
