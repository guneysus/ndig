﻿using System;
using System.Runtime.InteropServices;

namespace ndig.Native
{

    /// <summary>
    /// See http://msdn.microsoft.com/en-us/library/windows/desktop/ms682113(v=vs.85).aspx
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct DNS_WINSR_DATA
    {
        public uint dwMappingFlag;
        public uint dwLookupTimeout;
        public uint dwCacheTimeout;
        public IntPtr pNameResultDomain;    // string  
    }
}