using System;
using System.Collections.Generic;

namespace FinaPay.PayModels
{
    public partial class PayItemBaseSubUnit
    {
        public string ItemCode { get; set; } = null!;
        public string ItemCategory { get; set; } = null!;
        public string BaseCode { get; set; } = null!;
        public string SubUnitCode { get; set; } = null!;
        public decimal Rate { get; set; }
    }
}
