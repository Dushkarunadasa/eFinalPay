using System;
using System.Collections.Generic;

namespace FinaPay.PayModels
{
    public partial class PayVwSearchCategory
    {
        public string Code { get; set; } = null!;
        public string Name { get; set; } = null!;
        public decimal SalDispAmt { get; set; }
    }
}
