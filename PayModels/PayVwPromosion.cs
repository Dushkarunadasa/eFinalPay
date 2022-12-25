using System;
using System.Collections.Generic;

namespace FinaPay.PayModels
{
    public partial class PayVwPromosion
    {
        public string? Syscode { get; set; }
        public string? Catcode { get; set; }
        public string? Officercode { get; set; }
        public DateTime? Fromdate { get; set; }
        public DateTime? Todate { get; set; }
        public string? Rankcode { get; set; }
        public string Rankname { get; set; } = null!;
    }
}
