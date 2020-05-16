using CommandLine;
using ndig.Native;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

namespace ndig
{
    public class Options
    {
        [Option('t', "type", Required = true, HelpText = "Record Type, [A|CNAME|TXT|MX]")]
        public DnsRecordType DnsRecordType { get; set; }

        [Option('d', "domain", Required = true, HelpText = "Domain")]
        public string Domain { get; set; }

        [Option('f', "format", Required = false, HelpText = "Format. [Plain]")]
        public Format Format { get; set; }
    }

    public enum Format { 
        Plain = 0,
        Json = 1,
        CSV = 2
    }

    public enum DnsRecordType
    {
        A = DnsRecordTypes.DNS_TYPE_A,
        AAAA = DnsRecordTypes.DNS_TYPE_AAAA,
        CNAME = DnsRecordTypes.DNS_TYPE_CNAME,
        MX = DnsRecordTypes.DNS_TYPE_MX,
        TXT = DnsRecordTypes.DNS_TYPE_TXT,
        NS = DnsRecordTypes.DNS_TYPE_NS,
    }
}

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
