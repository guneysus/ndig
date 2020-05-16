namespace ndig.Native
{
#if DNS_NSEC
    /// <summary>
    /// See http://msdn.microsoft.com/en-us/library/windows/desktop/dd392297(v=vs.85).aspx
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    internal struct DNS_NSEC_DATA
    {
        public IntPtr pNextDomainName;    // string
        public ushort wTypeBitMapsLength;
        public ushort wPad;
        public IntPtr TypeBitMaps;    // BYTE  TypeBitMaps[1];  
    }
#endif
}