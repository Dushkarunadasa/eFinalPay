using System;
using System.Collections.Generic;

namespace FinaPay.PayModels
{
    public partial class PayVwRptSelectPaymentVoucher
    {
        public string DocumentNo { get; set; } = null!;
        public DateTime DocumentDate { get; set; }
        public string SysCode { get; set; } = null!;
        public string CatCode { get; set; } = null!;
        public string OfficerCode { get; set; } = null!;
        public string Description { get; set; } = null!;
        public decimal Amount { get; set; }
        public bool Cancelled { get; set; }
        public DateTime? CancelledDate { get; set; }
        public string OfficerName { get; set; } = null!;
    }
}
