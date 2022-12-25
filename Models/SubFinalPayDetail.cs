using System;
using System.Collections.Generic;

namespace FinaPay.Models
{
    public partial class SubFinalPayDetail
    {
        public int TransId { get; set; }
        public int UnitId { get; set; }
        public bool? SubjectClerk { get; set; }
        public bool? Secreatry { get; set; }
        public bool? AuthorizedOfficer { get; set; }
        public bool? Reject { get; set; }
        public string? RejectBy { get; set; }
        public string? RejectReason { get; set; }
        public int Ulevel { get; set; }
        public bool? RejectSec { get; set; }
        public bool? RejectAuth { get; set; }
    }
}
