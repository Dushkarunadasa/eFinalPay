using System;
using System.Collections.Generic;

namespace FinaPay.PayModels
{
    public partial class PayVwSearchServiceStatus
    {
        public string SysCode { get; set; } = null!;
        public string CatCode { get; set; } = null!;
        public string OfficerCode { get; set; } = null!;
        public string FullName { get; set; } = null!;
        public string SurName { get; set; } = null!;
        public bool? Status { get; set; }
        public DateTime? StatusEffectDate { get; set; }
    }
}
