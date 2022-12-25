using System;
using System.Collections.Generic;

namespace FinaPay.PayModels
{
    public partial class GrtVwAllowanceSetup
    {
        public string CatCode { get; set; } = null!;
        public decimal? MinYearsDeathGrt { get; set; }
        public decimal? MinYearsPensonGrt { get; set; }
        public decimal? MinYears1022Grt { get; set; }
        public decimal? MaxYears1022Grt { get; set; }
        public decimal? UnChildMinYears { get; set; }
        public decimal? UnSibLingsYears { get; set; }
        public decimal? MaxYearsDeathGrt { get; set; }
    }
}
