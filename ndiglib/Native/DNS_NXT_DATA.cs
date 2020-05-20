namespace ndig.Native
{

#if DNS_NXT
    /// <summary>
    /// See http://msdn.microsoft.com/en-us/library/windows/desktop/ms682076(v=vs.85).aspx
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct DNS_NXT_DATA
    {
        public IntPtr pNameNext;    // string
        public ushort wNumTypes;
        public IntPtr wTypes;       // WORD  wTypes[1];  
    }
#endif
}