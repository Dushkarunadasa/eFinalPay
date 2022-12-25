using System;
using System.Collections.Generic;

namespace FinaPay.PayModels
{
    public partial class PayVwRptMonCoinAnnArea
    {
        public decimal? Amount { get; set; }
        public string? BaseCode { get; set; }
        public string? Area { get; set; }
        public string BaseName { get; set; } = null!;
        public string? Areaname { get; set; }
        public int? C1000 { get; set; }
        public int? C500 { get; set; }
        public int? C200 { get; set; }
        public int? C100 { get; set; }
        public int? C50 { get; set; }
        public int? C20 { get; set; }
        public int? C10 { get; set; }
        public int? Mmonth { get; set; }
        public string? Myear { get; set; }
    }
}
