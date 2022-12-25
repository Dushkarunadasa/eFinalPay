using System;
using System.Collections.Generic;

namespace FinaPay.PayModels
{
    public partial class PayVwRptAutoIncrementConfirm
    {
        public string Syscode { get; set; } = null!;
        public string Catcode { get; set; } = null!;
        public string Officercode { get; set; } = null!;
        public string? Name { get; set; }
        public decimal Increment { get; set; }
        public decimal? Arreas { get; set; }
        public DateTime EffectDate { get; set; }
        public decimal? Bsalary { get; set; }
        public string? NewRankCode { get; set; }
        public int? NewRankStage { get; set; }
        public DateTime? DateConfirm { get; set; }
        public string? RankGroup { get; set; }
    }
}
