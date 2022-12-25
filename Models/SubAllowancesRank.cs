using System;
using System.Collections.Generic;

namespace FinaPay.Models
{
    public partial class SubAllowancesRank
    {
        public string? ItemCode { get; set; }
        public string? RankCode { get; set; }
        public string? CatCode { get; set; }
        public decimal? Amount { get; set; }
    }
}
