using System.Runtime.InteropServices;

namespace ndig.Native
{


    [StructLayout(LayoutKind.Explicit)]
    public struct DataUnion
    {
        [FieldOffset(0)]
        public DNS_A_DATA A;

        [FieldOffset(0)]
        public DNS_SOA_DATA SOA, Soa; 

        [FieldOffset(0)]
        public DNS_PTR_DATA PTR, Ptr, NS, Ns, CNAME, Cname, DNAME, Dname, MB, Mb, MD, Md, MF, Mf, MG, Mg, MR, Mr;

        [FieldOffset(0)]
        public DNS_MINFO_DATA MINFO, Minfo, RP, Rp;


        [FieldOffset(0)]
        public DNS_MX_DATA MX, Mx, AFSDB, Afsdb, RT, Rt;

        [FieldOffset(0)]
        public DNS_TXT_DATA HINFO, Hinfo, ISDN, Isdn, TXT, Txt, X25;

        [FieldOffset(0)]
        public DNS_NULL_DATA Null;


        [FieldOffset(0)]
        public DNS_WKS_DATA WKS, Wks;

        [FieldOffset(0)]
        public DNS_AAAA_DATA AAAA; 

        [FieldOffset(0)]
        public DNS_KEY_DATA KEY, Key; 

        [FieldOffset(0)]
        public DNS_SIG_DATA SIG, Sig; 

        [FieldOffset(0)]
        public DNS_ATMA_DATA ATMA, Atma; 

        [FieldOffset(0)]
        public DNS_NXT_DATA NXT, Nxt; 

        [FieldOffset(0)]
        public DNS_SRV_DATA SRV, Srv;

        [FieldOffset(0)]
        public DNS_NAPTR_DATA NAPTR, Naptr;

        [FieldOffset(0)]
        public DNS_OPT_DATA OPT, Opt; 

        [FieldOffset(0)]
        public DNS_DS_DATA DS, Ds;

        [FieldOffset(0)]
        public DNS_RRSIG_DATA RRSIG, Rrsig;

        [FieldOffset(0)]
        public DNS_NSEC_DATA NSEC, Nsec;

        [FieldOffset(0)]
        public DNS_DNSKEY_DATA DNSKEY, Dnskey;

        [FieldOffset(0)]
        public DNS_TKEY_DATA TKEY, Tkey;

        [FieldOffset(0)]
        public DNS_TSIG_DATA TSIG, Tsig;

        [FieldOffset(0)]
        public DNS_WINS_DATA WINS, Wins; 

        [FieldOffset(0)]
        public DNS_WINSR_DATA WINSR, WinsR, NBSTAT, Nbstat;

        [FieldOffset(0)]
        public DNS_DHCID_DATA DHCID;

    }
}