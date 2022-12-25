using System;
using System.Collections.Generic;

namespace FinaPay.Models
{
    public partial class Sub327adjustmentTran
    {
        public Sub327adjustmentTran()
        {
            Sub327Lists = new HashSet<Sub327List>();
        }

        public string TransId { get; set; } = null!;
        public string BaseCode { get; set; } = null!;
        public int UnitId { get; set; }
        public string? Remarks { get; set; }
        public string? FilePath { get; set; }
        public bool? Tsave { get; set; }
        public bool? Tconfirm { get; set; }
        public bool? Tforward { get; set; }
        public bool? Acheck { get; set; }
        public bool? Aconfirm { get; set; }
        public bool? Aforward { get; set; }
        public bool? Dcheck { get; set; }
        public bool? Dconfirm { get; set; }
        public bool? Dforward { get; set; }
        public bool? Ddnpay { get; set; }
        public bool? Subject { get; set; }
        public bool? AuditStaff { get; set; }
        public bool? AuditOfficer { get; set; }
        public bool? Sso { get; set; }
        public bool? Reject { get; set; }
        public decimal? DeductAmount { get; set; }
        public decimal? Total327 { get; set; }
        public string? CurrentPayMonth { get; set; }
        public bool? PayAction { get; set; }
        public string? PayActionRemarks { get; set; }
        public string? Des { get; set; }

        public virtual ICollection<Sub327List> Sub327Lists { get; set; }
    }
}
