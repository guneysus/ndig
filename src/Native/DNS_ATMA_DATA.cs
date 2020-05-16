
namespace ndig.Native
{

    //public const int DNS_ATMA_MAX_ADDR_LENGTH = 20;
    //public const int DNS_ATMA_FORMAT_E164 = 1;
    //public const int DNS_ATMA_FORMAT_AESA = 2;

#if DNS_ATMA

    /// <summary>
    /// See http://msdn.microsoft.com/en-us/library/windows/desktop/ms682041(v=vs.85).aspx
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    internal struct DNS_ATMA_DATA
    {
        public byte AddressType;
        // BYTE Address[DNS_ATMA_MAX_ADDR_LENGTH];
        // This isn't ideal, but it should work without using the fixed and unsafe keywords
        public byte Address0;
        public byte Address1;
        public byte Address2;
        public byte Address3;
        public byte Address4;
        public byte Address5;
        public byte Address6;
        public byte Address7;
        public byte Address8;
        public byte Address9;
        public byte Address10;
        public byte Address11;
        public byte Address12;
        public byte Address13;
        public byte Address14;
        public byte Address15;
        public byte Address16;
        public byte Address17;
        public byte Address18;
        public byte Address19; 
}
#endif
}