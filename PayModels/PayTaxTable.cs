using System;
using System.Collections.Generic;

namespace FinaPay.PayModels
{
    public partial class PayTaxTable
    {
        public string? TableNo { get; set; }
        public int? SubTableNo { get; set; }
        public decimal? FormTax { get; set; }
        public decimal? ToTax { get; set; }
        public string? PayType { get; set; }
        public decimal? PerRate { get; set; }
        public decimal? Amount { get; set; }
        public decimal? Above { get; set; }
    }
}
