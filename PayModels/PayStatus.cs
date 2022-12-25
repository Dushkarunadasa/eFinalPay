using System;
using System.Collections.Generic;

namespace FinaPay.PayModels
{
    public partial class PayStatus
    {
        public PayStatus()
        {
            PayStatusDetails = new HashSet<PayStatusDetail>();
        }

        public string StatusCode { get; set; } = null!;
        public string StatusName { get; set; } = null!;
        public string? SalCalcMethod { get; set; }
        public bool? StopCalc { get; set; }
        public string? NavCode { get; set; }

        public virtual ICollection<PayStatusDetail> PayStatusDetails { get; set; }
    }
}
