namespace ndig.Native
{
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Explicit)]
    public struct FlagsUnion
    {
        [FieldOffset(0)]
        public uint DW;
        [FieldOffset(0)]
        public DNS_RECORD_FLAGS S;
    }
}