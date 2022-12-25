using System;
using System.Collections.Generic;

namespace FinaPay.PayModels
{
    public partial class PayVwRptListRank
    {
        public string RankCode { get; set; } = null!;
        public string RankName { get; set; } = null!;
        public decimal StartSal { get; set; }
        public string? SinName { get; set; }
        public string CatCode { get; set; } = null!;
        public string CatName { get; set; } = null!;
    }
}
