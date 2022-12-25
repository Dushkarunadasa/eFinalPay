using System;
using System.Collections.Generic;

namespace FinaPay.PayModels
{
    public partial class PayVwSearchPerInfoRevice
    {
        public string SysCode { get; set; } = null!;
        public string CatCode { get; set; } = null!;
        public int? OfficerCode { get; set; }
        public string Initials { get; set; } = null!;
        public string SurName { get; set; } = null!;
    }
}
