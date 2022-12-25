using System;
using System.Collections.Generic;

namespace FinaPay.PayModels
{
    public partial class GrtVwSearchGrtTransaction
    {
        public string SysCode { get; set; } = null!;
        public string CatCode { get; set; } = null!;
        public string OfficerCode { get; set; } = null!;
        public string? GrtType { get; set; }
        public DateTime? GrtStartDate { get; set; }
        public DateTime? GrtDate { get; set; }
        public string? SerYear { get; set; }
        public string? SerMonth { get; set; }
        public string? SerDays { get; set; }
        public string? AgeYear { get; set; }
        public string? AgeMonth { get; set; }
        public string? AgeDays { get; set; }
        public decimal? TotAllowance { get; set; }
        public decimal? GrtAmount { get; set; }
        public decimal? GetPer { get; set; }
        public decimal? ChildCount { get; set; }
        public string? DonNo { get; set; }
        public string Name { get; set; } = null!;
    }
}
