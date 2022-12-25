using System;
using System.Collections.Generic;

namespace FinaPay.Models
{
    public partial class PayRankD
    {
        public string? CatCode { get; set; }
        public string? RankCode { get; set; }
        public string? RankName { get; set; }
        public string? RankGroup { get; set; }
        public string? RankNameSin { get; set; }
        public bool? NotEffectConsolidated { get; set; }
        public bool? NoAnnualIncrement { get; set; }
        public bool? NoPromIncPrevRank { get; set; }
        public bool? NoProIncNewRank { get; set; }
        public bool? ScaleTop { get; set; }
        public int? Order { get; set; }
        public string? ScaleRankCode { get; set; }
        public int? Position { get; set; }
    }
}
