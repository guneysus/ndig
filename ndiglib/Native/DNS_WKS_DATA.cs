﻿using System;
using System.Runtime.InteropServices;

namespace ndig.Native
{

    /// <summary>
    /// See http://msdn.microsoft.com/en-us/library/windows/desktop/ms682120(v=vs.85).aspx
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct DNS_WKS_DATA
    {
        public uint IpAddress;      // IP4_ADDRESS IpAddress;
        public byte chProtocol;     // UCHAR       chProtocol;
        public IntPtr BitMask;        // BYTE    BitMask[1];  
    }
}