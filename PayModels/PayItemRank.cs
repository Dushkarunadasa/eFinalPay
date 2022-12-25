using System;
using System.Collections.Generic;

namespace FinaPay.PayModels
{
    public partial class PayItemRank
    {
        public string ItemCode { get; set; } = null!;
        public string ItemCategory { get; set; } = null!;
        public string RankCode { get; set; } = null!;
        public string CatCode { get; set; } = null!;
        public decimal Rate { get; set; }

        public virtual PayItem ItemC { get; set; } = null!;
    }
}
