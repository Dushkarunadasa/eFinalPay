using System;
using System.Collections.Generic;

namespace FinaPay.PayModels
{
    public partial class PayVwPensionSetup
    {
        public string CatCode { get; set; } = null!;
        public string CatName { get; set; } = null!;
        public decimal MinServiceLimit { get; set; }
        public decimal GrReductionPerc { get; set; }
        public decimal GrReductionYears { get; set; }
        public decimal WidowPensionPerc { get; set; }
        public decimal DepAgeLimitMale { get; set; }
        public decimal DepAgeLimitFemale { get; set; }
        public decimal DepAmountMaleA { get; set; }
        public decimal DepAmountMaleB { get; set; }
        public decimal DepAmountFemaleA { get; set; }
        public decimal DepAmountFemaleB { get; set; }
        public decimal SpecialAmountA { get; set; }
        public decimal SpecialAmountB { get; set; }
    }
}
