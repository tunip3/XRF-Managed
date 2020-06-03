using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using static XboxResearchFramework.Win32.Native;
using static XboxResearchFramework.Utilities.Converters;

namespace XboxResearchFramework.Drivers
{
    internal class PSPSRA
    {
        internal static readonly string DEVICE_NAME_PSPSRA = @"\\.\pspsra";
        internal static readonly uint IOCTL_PSP_CONSOLE_SERIAL = 0x221028;
        internal static readonly uint IOCTL_PSP_CONSOLE_REGION = 0x2200D0;
        internal static readonly uint IOCTL_PSP_REVISION_ID = 0x22102C;
        internal static readonly uint IOCTL_PSP_CAPABILITIES = 0x221038;
        internal static readonly uint IOCTL_PSP_SYSTEM_VERSION = 0x222008;

        internal static readonly uint SIZE_PSP_CONSOLE_SERIAL = 0xC;
        internal static readonly uint SIZE_PSP_CONSOLE_REGION = 0x41C;
        internal static readonly uint SIZE_PSP_REVISION_ID = 0x4;
        internal static readonly uint SIZE_PSP_CAPABILITIES = 0x200;
        internal static readonly uint SIZE_PSP_SYSTEM_VERSION = 0x11;



        public static string GetSerialNumber()
        {
            uint lpBytesReturned = 0;
            IntPtr lpInBuffer = IntPtr.Zero;
            IntPtr outBuf = Marshal.AllocHGlobal((int)SIZE_PSP_CONSOLE_SERIAL);
            IntPtr handle = CreateFileW
                   (DEVICE_NAME_PSPSRA,
                   System.IO.FileAccess.ReadWrite,
                   System.IO.FileShare.None,
                   IntPtr.Zero,
                   System.IO.FileMode.Open,
                   System.IO.FileAttributes.Normal,
                   IntPtr.Zero);
            bool status = DeviceIoControl
           (
               handle,         // HANDLE
               IOCTL_PSP_CONSOLE_SERIAL,       // IOCTL   
               IntPtr.Zero,    // inBuffer
               0,              // inBufferSize
               out outBuf,         // outBuffer
               SIZE_PSP_CONSOLE_SERIAL,    // outBuffer Size
               out lpBytesReturned,       // bytesReturned
               IntPtr.Zero               // lpOverlapped
           );
            byte[] managedArray = new byte[SIZE_PSP_CONSOLE_SERIAL];
            Marshal.Copy(outBuf, managedArray, 0, (int)SIZE_PSP_CONSOLE_SERIAL);
            //Array.Reverse(managedArray, 0, managedArray.Length);
            string buffer = "";
            buffer = BitConverter.ToString(managedArray);
            buffer = buffer.Replace("-", "");
            buffer = HexString2Ascii(buffer);
            Marshal.FreeHGlobal(outBuf);
            return buffer;
        }

    }
}
