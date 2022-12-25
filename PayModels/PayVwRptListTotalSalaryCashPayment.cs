using System;
using System.Collections.Generic;

namespace FinaPay.PayModels
{
    public partial class PayVwRptListTotalSalaryCashPayment
    {
        public string? SysCode { get; set; }
        public string? CatCode { get; set; }
        public string? OfficerCode { get; set; }
        public string? Initials { get; set; }
        public string? SurName { get; set; }
        public decimal? Cashpay { get; set; }
        public string? BaseCode { get; set; }
        public string? SubUnitCode { get; set; }
        public string? Area { get; set; }
        public decimal? Unpaid { get; set; }
        public string Basename { get; set; } = null!;
    }
}
