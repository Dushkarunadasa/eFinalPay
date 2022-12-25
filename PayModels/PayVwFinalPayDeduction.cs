using System;
using System.Collections.Generic;

namespace FinaPay.PayModels
{
    public partial class PayVwFinalPayDeduction
    {
        public string Syscode { get; set; } = null!;
        public string Catcode { get; set; } = null!;
        public string Officercode { get; set; } = null!;
        public string GroupItemCode { get; set; } = null!;
        public string GroupName { get; set; } = null!;
        public decimal? Amount { get; set; }
    }
}
