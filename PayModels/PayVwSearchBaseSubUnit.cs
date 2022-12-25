using System;
using System.Collections.Generic;

namespace FinaPay.PayModels
{
    public partial class PayVwSearchBaseSubUnit
    {
        public string BaseCode { get; set; } = null!;
        public string SubUnitCode { get; set; } = null!;
        public string SubUnitName { get; set; } = null!;
        public bool RiskArea { get; set; }
        public bool Ship { get; set; }
        public bool Active { get; set; }
        public string SubUnitNameSin { get; set; } = null!;
    }
}
