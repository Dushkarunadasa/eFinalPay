using System;
using System.Collections.Generic;

namespace FinaPay.PayModels
{
    public partial class PayVwSearchCountry
    {
        public string Code { get; set; } = null!;
        public string Name { get; set; } = null!;
        public decimal CountryRate1 { get; set; }
    }
}
