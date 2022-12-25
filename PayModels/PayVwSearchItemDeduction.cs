using System;
using System.Collections.Generic;

namespace FinaPay.PayModels
{
    public partial class PayVwSearchItemDeduction
    {
        public string Code { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string ItemAltName { get; set; } = null!;
    }
}
