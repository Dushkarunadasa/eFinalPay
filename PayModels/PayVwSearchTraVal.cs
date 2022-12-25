using System;
using System.Collections.Generic;

namespace FinaPay.PayModels
{
    public partial class PayVwSearchTraVal
    {
        public string? SysCode { get; set; }
        public string? CatCode { get; set; }
        public string? OfficerCode { get; set; }
        public string? ItemCode { get; set; }
        public decimal? Amount { get; set; }
        public string? Remark { get; set; }
        public string? Name { get; set; }
        public string? Ip { get; set; }
    }
}
