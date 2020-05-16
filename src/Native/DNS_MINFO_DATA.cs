namespace ndig.Native
{
#if DNS_MINFO

    /// <summary>
    /// See http://msdn.microsoft.com/en-us/library/windows/desktop/ms682067(v=vs.85).aspx
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    internal struct DNS_MINFO_DATA
    {
        public IntPtr pNameMailbox;     // string
        public IntPtr pNameErrorsMailbox;       // string  
}
#endif
}