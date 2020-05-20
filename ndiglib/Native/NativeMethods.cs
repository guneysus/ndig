namespace ndig.Native
{
    using System;
    using System.Runtime.InteropServices;

    public static class NativeMethods
    {
        private const string DNSAPI = "dnsapi";
        private const string DNSQUERY_W = "DnsQuery_W";

        /// <summary>
        /// Provides a DNS query resolution interface
        /// See http://msdn.microsoft.com/en-us/library/windows/desktop/ms682016(v=vs.85).aspx
        /// </summary>
        /// <param name="lpstrName">A pointer to a string that represents the DNS name to query</param>
        /// <param name="wType">A value that represents the Resource Record DNS Record Type that is queried</param>
        /// <param name="Options">A value that contains a bitmap of the DNS Query Options to use in the DNS query</param>
        /// <param name="pExtra">Reserved for future use and must be set to NULL</param>
        /// <param name="ppQueryResultsSet">A pointer to a pointer that points to the list of RRs that comprise the response</param>
        /// <param name="pReserved">Reserved for future use and must be set to NULL</param>
        /// <returns>Success (0), or the DNS-specific error defined in Winerror.h</returns>
        [DllImport(DNSAPI, EntryPoint = DNSQUERY_W, CharSet = CharSet.Unicode, SetLastError = true, ExactSpelling = true)]
        public static extern int DnsQuery(string lpstrName, DnsRecordTypes wType, DnsQueryOptions Options, IntPtr pExtra, ref IntPtr ppQueryResultsSet, IntPtr pReserved);

        /// <summary>
        /// Frees memory allocated for DNS records obtained by using the DnsQuery function
        /// See http://msdn.microsoft.com/en-us/library/windows/desktop/ms682021(v=vs.85).aspx
        /// </summary>
        /// <param name="pRecordList">A pointer to the DNS_RECORD structure that contains the list of DNS records to be freed</param>
        /// <param name="FreeType">A specifier of how the record list should be freed</param>
        [DllImport(DNSAPI, CharSet = CharSet.Auto, SetLastError = true)]
        public static extern void DnsRecordListFree(IntPtr pRecordList, DNS_FREE_TYPE FreeType);
    }
}