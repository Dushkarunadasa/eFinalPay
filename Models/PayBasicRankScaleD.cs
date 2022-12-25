using System;
using System.Collections.Generic;

namespace FinaPay.Models
{
    public partial class PayBasicRankScaleD
    {
        public string RankCode { get; set; } = null!;
        public int ScaleCode { get; set; }
        public decimal ConsolidatedSal { get; set; }
        public int Sequence { get; set; }
        public decimal Adjustment { get; set; }
        public string? RankCat { get; set; }
    }
}
