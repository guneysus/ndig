namespace ndig.Native
{
#if DNS_WINS
    /// <summary>
    /// See http://msdn.microsoft.com/en-us/library/windows/desktop/ms682114(v=vs.85).aspx
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    internal struct DNS_WINS_DATA
    {
        public uint dwMappingFlag;
        public uint dwLookupTimeout;
        public uint dwCacheTimeout;
        public uint cWinsServerCount;
        public uint WinsServers;    // IP4_ADDRESS WinsServers[1];  
    }
#endif
}