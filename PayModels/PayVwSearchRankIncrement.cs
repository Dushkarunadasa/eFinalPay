using System;
using System.Collections.Generic;

namespace FinaPay.PayModels
{
    public partial class PayVwSearchRankIncrement
    {
        public string SysCode { get; set; } = null!;
        public string CatCode { get; set; } = null!;
        public string OfficerCode { get; set; } = null!;
        public string RankCode { get; set; } = null!;
        public string Name { get; set; } = null!;
        public bool? ArearsPaid { get; set; }
    }
}
