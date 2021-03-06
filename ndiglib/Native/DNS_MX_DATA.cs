﻿namespace ndig.Native
{
    using System;
    using System.Runtime.InteropServices;

    /// <summary>
    /// See http://msdn.microsoft.com/en-us/library/windows/desktop/ms682070(v=vs.85).aspx
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct DNS_MX_DATA
    {
        public IntPtr pNameExchange;        // string
        public ushort wPreference;
        public ushort Pad;
        public string NameExchange { get { return Marshal.PtrToStringAuto(pNameExchange); } } 
    }
}