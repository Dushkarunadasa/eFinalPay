using System;
using System.Collections.Generic;

namespace FinaPay.PayModels
{
    public partial class PayItemBase
    {
        public string ItemCode { get; set; } = null!;
        public string ItemCategory { get; set; } = null!;
        public string BaseCode { get; set; } = null!;
        public string? SubUnitCode { get; set; }
        public decimal Rate { get; set; }

        public virtual PayBase BaseCodeNavigation { get; set; } = null!;
        public virtual PayItem ItemC { get; set; } = null!;
    }
}
