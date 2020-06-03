using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace XboxResearchFramework.Win32
{
    internal static class XboxLicenseManagerExt
    {
        [DllImport("xboxlicensemanagerext.dll", SetLastError = true)]
        internal static extern IntPtr GetRequiredEkbFromContentId(string ContentID);
    }
}
