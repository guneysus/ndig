﻿namespace ndig.Native
{


#if DNS_KEY
    /// <summary>
    /// See http://msdn.microsoft.com/en-us/library/windows/desktop/ms682061(v=vs.85).aspx
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    internal struct DNS_KEY_DATA
    {
        public ushort wFlags;
        public byte chProtocol;
        public byte chAlgorithm;
        public IntPtr Key;        // BYTE Key[1];  
}
#endif
}