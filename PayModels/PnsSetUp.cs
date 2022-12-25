using System;
using System.Collections.Generic;

namespace FinaPay.PayModels
{
    public partial class PnsSetUp
    {
        public string CatCode { get; set; } = null!;
        public decimal ServLimit { get; set; }
        public decimal PriServLimit { get; set; }
        public decimal WidowPenson { get; set; }
        public decimal Reduction { get; set; }
        public decimal ReductionYear { get; set; }
        public decimal DepAgeLimit { get; set; }

        public virtual PayCategory CatCodeNavigation { get; set; } = null!;
    }
}
