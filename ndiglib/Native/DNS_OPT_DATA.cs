namespace ndig.Native
{
#if DNS_OPT
    /// <summary>
    /// See http://msdn.microsoft.com/en-us/library/windows/desktop/dd392298(v=vs.85).aspx
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct DNS_OPT_DATA
    {
        public ushort wDataLength;
        public ushort wPad;
        public IntPtr Data;           // BYTE Data[1];  
    }
#endif
}