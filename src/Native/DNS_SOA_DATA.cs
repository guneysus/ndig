namespace ndig.Native
{

#if DNS_SOA
    /// <summary>
    /// See http://msdn.microsoft.com/en-us/library/windows/desktop/ms682096(v=vs.85).aspx
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    internal struct DNS_SOA_DATA
    {
        public IntPtr pNamePrimaryServer;       // string
        public IntPtr pNameAdministrator;       // string
        public uint dwSerialNo;
        public uint dwRefresh;
        public uint dwRetry;
        public uint dwExpire;
        public uint dwDefaultTtl; 
    }
#endif
}