﻿using System;
using System.Runtime.InteropServices;

namespace ndig.Native
{
    /// <summary>
    /// See http://msdn.microsoft.com/en-us/library/windows/desktop/ms682080(v=vs.85).aspx
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    internal struct DNS_PTR_DATA
    {
        public IntPtr pNameHost;    // string  
    }
}