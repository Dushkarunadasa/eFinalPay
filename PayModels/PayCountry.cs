using System;
using System.Collections.Generic;

namespace FinaPay.PayModels
{
    public partial class PayCountry
    {
        public string CountryCode { get; set; } = null!;
        public string CountryName { get; set; } = null!;
        public decimal CountryRate1 { get; set; }
        public decimal? CountryRate2 { get; set; }
        public decimal? MessCharges { get; set; }
        public decimal? Persentage { get; set; }
    }
}
