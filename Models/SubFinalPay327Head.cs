using System;
using System.Collections.Generic;

namespace FinaPay.Models
{
    public partial class SubFinalPay327Head
    {
        public string TransId { get; set; } = null!;
        public string BaseCode { get; set; } = null!;
        public int UnitId { get; set; }
        public bool? Tsave { get; set; }
        public bool? Tconfirm { get; set; }
        public bool? Tforward { get; set; }
        public bool? Ddnpay { get; set; }
        public bool? Subject { get; set; }
        public bool? AuditStaff { get; set; }
        public bool? AuditOfficer { get; set; }
        public bool? Sso { get; set; }
        public bool? Reject { get; set; }
        public decimal? DeductAmount { get; set; }
        public decimal? Total327 { get; set; }
        public string? CurrentPayMonth { get; set; }
        public bool? FinalPayAction { get; set; }
    }
}
