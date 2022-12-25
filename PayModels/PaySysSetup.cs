using System;
using System.Collections.Generic;

namespace FinaPay.PayModels
{
    public partial class PaySysSetup
    {
        public string SysCode { get; set; } = null!;
        public string Address { get; set; } = null!;
        public string Tel { get; set; } = null!;
        public string Fax { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string AccNo { get; set; } = null!;
        public string BankCode { get; set; } = null!;
        public string BranchCode { get; set; } = null!;
        public string BankAddress { get; set; } = null!;
        public bool RndOffNetPay { get; set; }
        public int RndOffNetPayNearest { get; set; }
        public bool OfficerCodeAutoGen { get; set; }
        public string NextOfficerCode { get; set; } = null!;
        public bool CfminusPay { get; set; }
        public bool Cfcoins { get; set; }
        public bool AutoIncrement { get; set; }

        public virtual PaySysCategory SysCodeNavigation { get; set; } = null!;
    }
}
