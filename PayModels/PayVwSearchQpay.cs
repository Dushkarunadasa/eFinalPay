using System;
using System.Collections.Generic;

namespace FinaPay.PayModels
{
    public partial class PayVwSearchQpay
    {
        public string Code { get; set; } = null!;
        public string Name { get; set; } = null!;
        public decimal Amount { get; set; }
    }
}
