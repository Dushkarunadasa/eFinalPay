using System;
using System.Collections.Generic;

namespace FinaPay.PayModels
{
    public partial class PayVwRptIncrement
    {
        public string? Syscode { get; set; }
        public string? Catcode { get; set; }
        public string? Officercode { get; set; }
        public string? Name { get; set; }
        public decimal? Increment { get; set; }
        public decimal? Curmonthincr { get; set; }
        public DateTime? Dateeffect { get; set; }
        public decimal? Bsalary { get; set; }
        public string? Rankcode { get; set; }
        public int? Rankstage { get; set; }
        public string? Frankcode { get; set; }
        public int? Frankstage { get; set; }
        public string? Rankgroup { get; set; }
        public decimal? TrNo { get; set; }
        public int? Userid { get; set; }
    }
}
