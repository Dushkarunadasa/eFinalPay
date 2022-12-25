using System;
using System.Collections.Generic;

namespace FinaPay.PayModels
{
    public partial class PayQpay
    {
        public PayQpay()
        {
            PayQpayDetails = new HashSet<PayQpayDetail>();
        }

        public string QpayCode { get; set; } = null!;
        public string QpayName { get; set; } = null!;
        public string ArreasCode { get; set; } = null!;
        public decimal Amount { get; set; }

        public virtual ICollection<PayQpayDetail> PayQpayDetails { get; set; }
    }
}
