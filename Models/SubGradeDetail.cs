using System;
using System.Collections.Generic;

namespace FinaPay.Models
{
    public partial class SubGradeDetail
    {
        public string SysCode { get; set; } = null!;
        public string CatCode { get; set; } = null!;
        public string OfficialNo { get; set; } = null!;
        public string Grade { get; set; } = null!;
        public DateTime? EffectDt { get; set; }
        public bool? Active { get; set; }
    }
}
