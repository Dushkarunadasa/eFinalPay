using System;
using System.Collections.Generic;

namespace FinaPay.PayModels
{
    public partial class PayRank
    {
        public string CatCode { get; set; } = null!;
        public string RankCode { get; set; } = null!;
        public string RankName { get; set; } = null!;
        public decimal StartSalary { get; set; }
        public string? RankNameSin { get; set; }
        public decimal? Woprate { get; set; }
        public string? RankSname { get; set; }
        public string RankGroup { get; set; } = null!;
    }
}
