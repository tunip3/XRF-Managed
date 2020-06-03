using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XboxResearchFramework.Win32;

namespace XboxResearchFramework.Console
{
    public class Xam
    {
        public static void SetDefaultScaleFactor() { throw new NotImplementedException("Not yet implemented in xamapi.dll"); }
        public static int GetDefaultScaleFactor() 
        {
            int scalefactor = 0;
            XamAPI.GetDefaultScaleFactor(ref scalefactor);
            return scalefactor;
        }
    }
}
