using System.Net;
using System.Runtime.InteropServices;

namespace ndig.Native
{

    /// <summary>
    /// See http://msdn.microsoft.com/en-us/library/windows/desktop/ms682044(v=vs.85).aspx
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct DNS_A_DATA
    {
        public uint IpAddress;
        public IPAddress IPAddressObject { get { return new IPAddress((long)IpAddress); } }
    }
}