using System;
using System.Collections.Generic;

namespace FinaPay.PayModels
{
    public partial class PayVwRptListQpayType
    {
        public string Code { get; set; } = null!;
        public string Descr { get; set; } = null!;
        public decimal Amount { get; set; }
    }
}
