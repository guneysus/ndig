namespace ndig.Native
{
#if DNS_SRV
    /// <summary>
    /// See http://msdn.microsoft.com/en-us/library/windows/desktop/ms682097(v=vs.85).aspx
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    internal struct DNS_SRV_DATA
    {
        public IntPtr pNameTarget;      // string
        public ushort uPriority;
        public ushort wWeight;
        public ushort wPort;
        public ushort Pad; 
    }
#endif
}