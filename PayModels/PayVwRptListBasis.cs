using System;
using System.Collections.Generic;

namespace FinaPay.PayModels
{
    public partial class PayVwRptListBasis
    {
        public string Bcode { get; set; } = null!;
        public string Bname { get; set; } = null!;
        public string Acode { get; set; } = null!;
        public string Aname { get; set; } = null!;
        public string? BaseNameSin { get; set; }
        public string RiskArea { get; set; } = null!;
        public string ArtiArea { get; set; } = null!;
        public string Ship { get; set; } = null!;
        public string Active { get; set; } = null!;
    }
}
