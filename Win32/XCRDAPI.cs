using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace XboxResearchFramework.Win32
{
    internal static class XCRDAPI
    {
        [DllImport("xcrdapi.dll", SetLastError = true)]
        internal static extern void XCrdOpenAdapter(out IntPtr XcrdHandle);
        [DllImport("xcrdapi.dll", SetLastError = true)]
        internal static extern void XCrdCloseAdapter(ref IntPtr XcrdHandle);

    }
}
