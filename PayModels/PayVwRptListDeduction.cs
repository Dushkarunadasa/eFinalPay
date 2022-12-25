using System;
using System.Collections.Generic;

namespace FinaPay.PayModels
{
    public partial class PayVwRptListDeduction
    {
        public string ItemCode { get; set; } = null!;
        public string Category { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string? Type { get; set; }
        public decimal? Rate { get; set; }
        public string GrossPay { get; set; } = null!;
        public string NoPay { get; set; } = null!;
        public string Wop { get; set; } = null!;
        public string? Bank { get; set; }
        public string? Branch { get; set; }
        public string? AccVo { get; set; }
        public string Cheque { get; set; } = null!;
        public string? ArePayCode { get; set; }
        public string? ArePayCat { get; set; }
    }
}
