using System;
using System.Collections.Generic;

namespace FinaPay.PayModels
{
    public partial class PayVwSearchCommonItemEntry
    {
        public int SeqNo { get; set; }
        public string ItemCode { get; set; } = null!;
        public string ItemCategoty { get; set; } = null!;
        public string? ItemName { get; set; }
    }
}
