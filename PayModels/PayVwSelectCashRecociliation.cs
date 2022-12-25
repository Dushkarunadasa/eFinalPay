using System;
using System.Collections.Generic;

namespace FinaPay.PayModels
{
    public partial class PayVwSelectCashRecociliation
    {
        public string SysCode { get; set; } = null!;
        public string CatCode { get; set; } = null!;
        public string OfficerCode { get; set; } = null!;
        public string? BaseCode { get; set; }
        public string? Area { get; set; }
        public string? SubUnitCode { get; set; }
        public decimal Amount { get; set; }
        public decimal CashReturn { get; set; }
    }
}
