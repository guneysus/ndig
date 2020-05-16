namespace ndig.Native
{
#if DNS_DHCID

    /// <summary>
    /// See http://msdn.microsoft.com/en-us/library/windows/desktop/dd392294(v=vs.85).aspx
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    internal struct DNS_DHCID_DATA
    {
        public uint dwByteCount;
        public IntPtr DHCID;          // BYTE  DHCID[1];  
}
#endif
}