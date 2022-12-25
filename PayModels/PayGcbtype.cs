using System;
using System.Collections.Generic;

namespace FinaPay.PayModels
{
    public partial class PayGcbtype
    {
        public PayGcbtype()
        {
            PayGcbdetails = new HashSet<PayGcbdetail>();
        }

        public string Gcbcode { get; set; } = null!;
        public string Gcbname { get; set; } = null!;
        public string ArreasCode { get; set; } = null!;
        public decimal Amount { get; set; }
        public string? Gcbgroup { get; set; }

        public virtual ICollection<PayGcbdetail> PayGcbdetails { get; set; }
    }
}
