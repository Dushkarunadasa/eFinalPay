using System;
using System.Collections.Generic;

namespace FinaPay.PayModels
{
    public partial class PayVwRptAutoIncrement
    {
        public string? Syscode { get; set; }
        public string? Catcode { get; set; }
        public string? Officercode { get; set; }
        public string? Name { get; set; }
        public decimal? Increment { get; set; }
        public decimal? Arreas { get; set; }
        public DateTime? DateEffect { get; set; }
        public bool? IncConfirm { get; set; }
        public decimal? Bsalary { get; set; }
        public string? NewRankCode { get; set; }
        public int? NewRankStage { get; set; }
        public DateTime? DateConfirm { get; set; }
        public decimal? RefCode { get; set; }
        public string? Ip { get; set; }
        public string? RankGroup { get; set; }
        public int? UserId { get; set; }
        public string? Rankcode { get; set; }
        public int? RankStage { get; set; }
    }
}
