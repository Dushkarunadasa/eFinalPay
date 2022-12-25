using System;
using System.Collections.Generic;

namespace FinaPay.PayModels
{
    public partial class PayVwTransactionSheduleDetail
    {
        public string SysCode { get; set; } = null!;
        public string CatCode { get; set; } = null!;
        public string OfficerCode { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string ItemCode { get; set; } = null!;
        public decimal Amount { get; set; }
        public int? NumofIns { get; set; }
    }
}
