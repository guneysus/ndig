using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace ndig.Native
{
    /// <summary>
    /// See http://msdn.microsoft.com/en-us/library/windows/desktop/ms682109(v=vs.85).aspx
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct DNS_TXT_DATA
    {
        public uint dwStringCount;

        public IntPtr pStringArray;

        public List<string> Strings
        {
            get
            {
                List<string> res = new List<string>((int)dwStringCount);
                for (int i = 0; i < dwStringCount; ++i)
                {
                    IntPtr ptr = IntPtr.Add(pStringArray, i);
                    string s = Marshal.PtrToStringUni(ptr);
                    res.Add(s);
                }

                return res;
            }
        } 
    }
}