using System;
using System.Runtime.InteropServices;

namespace ndig.Native
{


    /// <summary>
    /// See http://msdn.microsoft.com/en-us/library/windows/desktop/ms682082(v=vs.85).aspx
    /// These field offsets could be different depending on endianness and bitness
    /// </summary>

    [StructLayout(LayoutKind.Sequential)]

    public struct DNS_RECORD
    {
        public IntPtr pNext;    // DNS_RECORD*
        public IntPtr pName;    // string
        public ushort wType;
        public ushort wDataLength;
        public FlagsUnion Flags;
        public uint dwTtl;
        public uint dwReserved;
        public DataUnion Data;
    }
}