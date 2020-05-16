using CommandLine;
using ndig.Native;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ndig
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            Parser.Default.ParseArguments<Options>(args)
                   .WithParsed(options =>
                   {
                       List<string> result = null;

                       switch (options.DnsRecordType)
                       {
                           case DnsRecordType.A:
                               result = Ndig.GetARecords(options.Domain).Select(x => x.ToString()).ToList();
                               break;
                           case DnsRecordType.AAAA:
                               throw new NotImplementedException();
                           case DnsRecordType.CNAME:
                           case DnsRecordType.NS:
                               result = Ndig.GetRecords(options.Domain, (DnsRecordTypes)options.DnsRecordType);
                               break;
                           case DnsRecordType.MX:
                               result = Ndig.GetMXRecords(options.Domain);
                               break;
                           case DnsRecordType.TXT:
                               result = Ndig.GetTXTRecords(options.Domain);
                               break;
                           default:
                               break;
                       }

                       switch (options.Format)
                       {
                           case Format.Plain:
                               var header = result != null && result.Any()
                               ? $@"Showing {options.DnsRecordType} records for {options.Domain}"
                               : $@"NO {options.DnsRecordType} records found for {options.Domain}"
                               ;

                               var message = $@"
{header}
{string.Join(Environment.NewLine, result)}
";
                               Console.WriteLine(message);
                               break;
                           case Format.Json:
                               throw new NotImplementedException();
                           case Format.CSV:
                               throw new NotImplementedException();
                           default:
                               break;
                       }
                   });
        }
    }
}