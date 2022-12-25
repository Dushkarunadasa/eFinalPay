using System;
using System.Collections.Generic;

namespace FinaPay.PayModels
{
    public partial class PnsCatPercentage
    {
        public string CatCode { get; set; } = null!;
        public decimal NoOfYear { get; set; }
        public decimal? Percentage { get; set; }

        public virtual PayCategory CatCodeNavigation { get; set; } = null!;
    }
}
