using System;
using System.Collections.Generic;

namespace FinaPay.PayModels
{
    public partial class PayVwRptIncrementDuplicateList
    {
        public string? SysCode { get; set; }
        public string? CatCode { get; set; }
        public string? OfficerCode { get; set; }
        public string Mname { get; set; } = null!;
    }
}
