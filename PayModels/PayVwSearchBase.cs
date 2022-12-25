using System;
using System.Collections.Generic;

namespace FinaPay.PayModels
{
    public partial class PayVwSearchBase
    {
        public string BaseCode { get; set; } = null!;
        public string BaseName { get; set; } = null!;
        public string AreaCode { get; set; } = null!;
        public bool RiskArea { get; set; }
        public bool ArtiArea { get; set; }
        public bool Ship { get; set; }
        public bool Active { get; set; }
        public string BaseNameSin { get; set; } = null!;
        public string? BaseSname { get; set; }
    }
}
