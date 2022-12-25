using System;
using System.Collections.Generic;

namespace FinaPay.PayModels
{
    public partial class PayBaseSubUnit
    {
        public string SubUnitCode { get; set; } = null!;
        public string SubUnitName { get; set; } = null!;
        public string BaseCode { get; set; } = null!;
        public bool RiskArea { get; set; }
        public bool Ship { get; set; }
        public bool Active { get; set; }
        public string? SubUnitNameSin { get; set; }
        public string? SubUnitSname { get; set; }

        public virtual PayBase BaseCodeNavigation { get; set; } = null!;
    }
}
