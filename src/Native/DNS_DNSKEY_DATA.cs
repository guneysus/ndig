namespace ndig.Native
{

#if DNS_DNSKEY
    /// <summary>
    /// See http://msdn.microsoft.com/en-us/library/windows/desktop/dd392295(v=vs.85).aspx
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    internal struct DNS_DNSKEY_DATA
    {
        public ushort wFlags;
        public byte chProtocol;
        public byte chAlgorithm;
        public ushort wKeyLength;
        public ushort wPad;
        public IntPtr Key;        // BYTE Key[1];  
}
#endif
}