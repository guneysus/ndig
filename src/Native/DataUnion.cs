using System.Runtime.InteropServices;

namespace ndig.Native
{


    [StructLayout(LayoutKind.Explicit)]
    internal struct DataUnion
    {
        [FieldOffset(0)]
        public DNS_A_DATA A;

#if DNS_SOA
        [FieldOffset(0)]
        public DNS_SOA_DATA SOA, Soa; 
#endif

        [FieldOffset(0)]
        public DNS_PTR_DATA PTR, Ptr, NS, Ns, CNAME, Cname, DNAME, Dname, MB, Mb, MD, Md, MF, Mf, MG, Mg, MR, Mr;

#if DNS_MINFO
        [FieldOffset(0)]
        public DNS_MINFO_DATA MINFO, Minfo, RP, Rp;

#endif

#if DNS_MX
        [FieldOffset(0)]
        public DNS_MX_DATA MX, Mx, AFSDB, Afsdb, RT, Rt;
#endif

#if DNS_TXT
        [FieldOffset(0)]
        public DNS_TXT_DATA HINFO, Hinfo, ISDN, Isdn, TXT, Txt, X25;

#endif

#if DNS_NULL
        [FieldOffset(0)]
        public DNS_NULL_DATA Null;

#endif

#if DNS_WKS
        [FieldOffset(0)]
        public DNS_WKS_DATA WKS, Wks;
#endif

#if DNS_AAAA
        [FieldOffset(0)]
        public DNS_AAAA_DATA AAAA; 
#endif

#if DNS_KEY
        [FieldOffset(0)]
        public DNS_KEY_DATA KEY, Key; 
#endif

#if DNS_SIG
        [FieldOffset(0)]
        public DNS_SIG_DATA SIG, Sig; 
#endif

#if DNS_ATMA
        [FieldOffset(0)]
        public DNS_ATMA_DATA ATMA, Atma; 
#endif

#if DNS_NXT
        [FieldOffset(0)]
        public DNS_NXT_DATA NXT, Nxt; 
#endif

#if DNS_SRV
        [FieldOffset(0)]
        public DNS_SRV_DATA SRV, Srv;

#endif

#if DNS_NAPTR
        [FieldOffset(0)]
        public DNS_NAPTR_DATA NAPTR, Naptr;
#endif

#if DNS_OPT
        [FieldOffset(0)]
        public DNS_OPT_DATA OPT, Opt; 
#endif

#if DNS_DS
        [FieldOffset(0)]
        public DNS_DS_DATA DS, Ds;
#endif

#if DNS_RRSIG
        [FieldOffset(0)]
        public DNS_RRSIG_DATA RRSIG, Rrsig;
#endif

#if DNS_NSEC
        [FieldOffset(0)]
        public DNS_NSEC_DATA NSEC, Nsec;
#endif

#if DNS_DNSKEY
        [FieldOffset(0)]
        public DNS_DNSKEY_DATA DNSKEY, Dnskey;
#endif

#if DNS_TKEY
        [FieldOffset(0)]
        public DNS_TKEY_DATA TKEY, Tkey;
#endif

#if DNS_TSIG
        [FieldOffset(0)]
        public DNS_TSIG_DATA TSIG, Tsig;
#endif

#if DNS_WINS
        [FieldOffset(0)]
        public DNS_WINS_DATA WINS, Wins; 
#endif

#if DNS_WINSR
        [FieldOffset(0)]
        public DNS_WINSR_DATA WINSR, WinsR, NBSTAT, Nbstat;
#endif

#if DNS_DHCID
        [FieldOffset(0)]
        public DNS_DHCID_DATA DHCID;
#endif

    }
}