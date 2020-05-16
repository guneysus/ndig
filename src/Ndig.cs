using ndig.Native;
using System;
using System.Collections.Generic;
using System.Net;
using System.Runtime.InteropServices;

namespace ndig
{
    internal static class Ndig
    {
        private const DnsQueryOptions DEFAULT_QUERY_OPTIONS = DnsQueryOptions.DNS_QUERY_BYPASS_CACHE;

        internal static List<IPAddress> GetARecords(string domain, DnsQueryOptions options = DEFAULT_QUERY_OPTIONS)
        {
            var recordsArray = IntPtr.Zero;
            var records = new List<IPAddress>();
            const DnsRecordTypes queryType = DnsRecordTypes.DNS_TYPE_A;

            try
            {
                var result = NativeMethods.DnsQuery(
                    domain,
                    queryType,
                    options,
                    IntPtr.Zero, 
                    ref recordsArray,
                    IntPtr.Zero);

                if (result != 0)
                {
                    return records;
                }

                DNS_RECORD record;

                for (var recordPtr = recordsArray; !recordPtr.Equals(IntPtr.Zero); recordPtr = record.pNext)
                {
                    record = (DNS_RECORD)Marshal.PtrToStructure(recordPtr, typeof(DNS_RECORD));
                    if (record.wType == (int)queryType)
                    {
                        var ip = record.Data.A.IPAddressObject;
                        records.Add(ip);
                    }
                }
            }
            finally
            {
                if (recordsArray != IntPtr.Zero)
                {
                    NativeMethods.DnsRecordListFree(recordsArray, DNS_FREE_TYPE.DnsFreeFlat);
                }
            }

            return records;
        }

        internal static List<uint> GetAAAARecords(string domain, DnsQueryOptions options = DEFAULT_QUERY_OPTIONS)
        {
            var recordsArray = IntPtr.Zero;
            var records = new List<uint>();
            const DnsRecordTypes queryType = DnsRecordTypes.DNS_TYPE_AAAA;

            try
            {
                var result = NativeMethods.DnsQuery(
                    domain,
                    queryType,
                    options,
                    IntPtr.Zero,
                    ref recordsArray,
                    IntPtr.Zero);

                if (result != 0)
                {
                    return records;
                }

                DNS_RECORD record;

                for (var recordPtr = recordsArray; !recordPtr.Equals(IntPtr.Zero); recordPtr = record.pNext)
                {
                    record = (DNS_RECORD)Marshal.PtrToStructure(recordPtr, typeof(DNS_RECORD));
                    if (record.wType == (int)queryType)
                    {
                        throw new NotImplementedException();
                    }
                }
            }
            finally
            {
                if (recordsArray != IntPtr.Zero)
                {
                    NativeMethods.DnsRecordListFree(recordsArray, DNS_FREE_TYPE.DnsFreeFlat);
                }
            }

            return records;
        }


        internal static List<string> GetRecords(string domain, 
            DnsRecordTypes recordType, 
            DnsQueryOptions options = DEFAULT_QUERY_OPTIONS)
        {
            var recordsArray = IntPtr.Zero;
            var records = new List<string>();

            try
            {
                var result = NativeMethods.DnsQuery(
                    domain,
                    recordType,
                    options,
                    IntPtr.Zero,
                    ref recordsArray,
                    IntPtr.Zero);

                if (result != 0)
                {
                    return records;
                }

                DNS_RECORD record;

                for (var recordPtr = recordsArray; !recordPtr.Equals(IntPtr.Zero); recordPtr = record.pNext)
                {
                    record = (DNS_RECORD)Marshal.PtrToStructure(recordPtr, typeof(DNS_RECORD));
                    if (record.wType == (int)recordType)
                    {
                        var item = Marshal.PtrToStringAuto(record.Data.PTR.pNameHost);
                        records.Add(item);
                    }
                }
            }
            finally
            {
                if (recordsArray != IntPtr.Zero)
                {
                    NativeMethods.DnsRecordListFree(recordsArray, DNS_FREE_TYPE.DnsFreeFlat);
                }
            }

            return records;
        }

        internal static List<string> GetMXRecords(string domain,
            DnsQueryOptions options = DEFAULT_QUERY_OPTIONS)
        {
            var recordsArray = IntPtr.Zero;
            var records = new List<string>();
            var queryType = DnsRecordTypes.DNS_TYPE_MX;
            try
            {
                var result = NativeMethods.DnsQuery(
                    domain,
                    queryType,
                    options,
                    IntPtr.Zero,
                    ref recordsArray,
                    IntPtr.Zero);

                if (result != 0)
                {
                    return records;
                }

                DNS_RECORD record;

                for (var recordPtr = recordsArray; !recordPtr.Equals(IntPtr.Zero); recordPtr = record.pNext)
                {
                    record = (DNS_RECORD)Marshal.PtrToStructure(recordPtr, typeof(DNS_RECORD));
                    if (record.wType == (int)queryType)
                    {
                        var item = record.Data.MX.NameExchange;
                        records.Add(item);
                    }
                }
            }
            finally
            {
                if (recordsArray != IntPtr.Zero)
                {
                    NativeMethods.DnsRecordListFree(recordsArray, DNS_FREE_TYPE.DnsFreeFlat);
                }
            }

            return records;
        }

        internal static List<string> GetTXTRecords(string domain,
            DnsQueryOptions options = DEFAULT_QUERY_OPTIONS)
        {
            var recordsArray = IntPtr.Zero;
            var records = new List<string>();
            var queryType = DnsRecordTypes.DNS_TYPE_TXT;
            try
            {
                var result = NativeMethods.DnsQuery(
                    domain,
                    queryType,
                    options,
                    IntPtr.Zero,
                    ref recordsArray,
                    IntPtr.Zero);

                if (result != 0)
                {
                    return records;
                }

                DNS_RECORD record;

                for (var recordPtr = recordsArray; !recordPtr.Equals(IntPtr.Zero); recordPtr = record.pNext)
                {
                    record = (DNS_RECORD)Marshal.PtrToStructure(recordPtr, typeof(DNS_RECORD));
                    if (record.wType == (int)queryType)
                    {
                        records.AddRange(record.Data.TXT.Strings);
                    }
                }
            }
            finally
            {
                if (recordsArray != IntPtr.Zero)
                {
                    NativeMethods.DnsRecordListFree(recordsArray, DNS_FREE_TYPE.DnsFreeFlat);
                }
            }

            return records;
        }
    }
}
