using System;
using System.Collections.Generic;

namespace FinaPay.PayModels
{
    public partial class PayVwRptMonPayRegRank
    {
        public int? RowId { get; set; }
        public string? Rankcode { get; set; }
        public string? RankName { get; set; }
        public string? ItemAltName { get; set; }
        public decimal? Amount { get; set; }
        public int? BorderTopLine { get; set; }
        public int? BorderBottomLine { get; set; }
    }
}
