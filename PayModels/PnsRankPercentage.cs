using System;
using System.Collections.Generic;

namespace FinaPay.PayModels
{
    public partial class PnsRankPercentage
    {
        public string RankCode { get; set; } = null!;
        public string CatCode { get; set; } = null!;
        public int MaxService { get; set; }
        public decimal YearsFrom { get; set; }
        public decimal YearsTo { get; set; }
        public decimal Percentage { get; set; }
    }
}
