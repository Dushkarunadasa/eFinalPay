using System;
using System.Collections.Generic;

namespace FinaPay.PayModels
{
    public partial class PayItemGroup
    {
        public string GroupCategory { get; set; } = null!;
        public string GroupItemCode { get; set; } = null!;
        public string ItemCode { get; set; } = null!;
        public string ItemCategory { get; set; } = null!;

        public virtual PayItem ItemC { get; set; } = null!;
    }
}
