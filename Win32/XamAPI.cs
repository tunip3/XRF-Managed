using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace XboxResearchFramework.Win32
{
    internal static class XamAPI
    {
        [DllImport("xamapi.dll", SetLastError = true)]
        internal static extern void GetDefaultScaleFactor(ref int ScaleFactor);
    }
}
