using System;
using System.Collections.Generic;

namespace FinaPay.PayModels
{
    public partial class PayVwSearchAppoDetail
    {
        public string SysCode { get; set; } = null!;
        public string CatCode { get; set; } = null!;
        public string OfficerCode { get; set; } = null!;
        public string AppCode { get; set; } = null!;
        public DateTime AppFroom { get; set; }
        public DateTime? AppTo { get; set; }
        public bool? Confirmed { get; set; }
        public DateTime? ConfirmDate { get; set; }
        public bool Active { get; set; }
    }
}
