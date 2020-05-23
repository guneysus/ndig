#pragma warning disable S3261 // Namespaces should not be empty
using System.Runtime.InteropServices;

namespace ndig.Native
{


    /// <summary>
    /// See http://msdn.microsoft.com/en-us/library/windows/desktop/ms682035(v=vs.85).aspx
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct DNS_AAAA_DATA
    {
        // IP6_ADDRESS Ip6Address;
        // DWORD IP6Dword[4];
        // This isn't ideal, but it should work without using the fixed and unsafe keywords
        public uint Ip6Address0;
        public uint Ip6Address1;
        public uint Ip6Address2;
        public uint Ip6Address3; 
    }
}
#pragma warning restore S3261 // Namespaces should not be empty