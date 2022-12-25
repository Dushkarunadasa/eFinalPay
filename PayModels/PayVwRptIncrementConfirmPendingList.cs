using System;
using System.Collections.Generic;

namespace FinaPay.PayModels
{
    public partial class PayVwRptIncrementConfirmPendingList
    {
        public string? SysCode { get; set; }
        public string? CatCode { get; set; }
        public string? OfficerCode { get; set; }
        public DateTime? DateJoin { get; set; }
        public decimal? Increment { get; set; }
        public decimal? Bsalary { get; set; }
        public int? UserId { get; set; }
        public string Datauser { get; set; } = null!;
    }
}
