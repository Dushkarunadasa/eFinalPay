using System;
using System.Collections.Generic;

namespace FinaPay.PayModels
{
    public partial class PayItemRestric
    {
        public string ItemCode { get; set; } = null!;
        public string ItemCategory { get; set; } = null!;
        public string ItemCodeRes { get; set; } = null!;
        public string ItemCategoryRes { get; set; } = null!;

        public virtual PayItem ItemC { get; set; } = null!;
    }
}
