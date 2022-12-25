using System;
using System.Collections.Generic;

namespace FinaPay.PayModels
{
    public partial class PayVwSearchRank
    {
        public string CatCode { get; set; } = null!;
        public string RankCode { get; set; } = null!;
        public string? RankGroup { get; set; }
        public string RankName { get; set; } = null!;
        public decimal StartSalary { get; set; }
        public string RankNameSin { get; set; } = null!;
        public decimal? Woprate { get; set; }
    }
}
