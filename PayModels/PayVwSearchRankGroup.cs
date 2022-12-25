using System;
using System.Collections.Generic;

namespace FinaPay.PayModels
{
    public partial class PayVwSearchRankGroup
    {
        public string CatCode { get; set; } = null!;
        public string RankGroup { get; set; } = null!;
        public string? RgroupName { get; set; }
    }
}
