using System;
using System.Collections.Generic;

namespace FinaPay.Models
{
    public partial class SubIncentiveForm
    {
        public decimal Iid { get; set; }
        public string SysCode { get; set; } = null!;
        public string CatCode { get; set; } = null!;
        public string OfficialNo { get; set; } = null!;
        public DateTime? DateofEnlistment { get; set; }
        public string? NavalService { get; set; }
        public bool? ServiceBreak { get; set; }
        public bool? WarrantPunishment { get; set; }
        public string? CurrentIncentive { get; set; }
        public string ApplliedIncentive { get; set; } = null!;
        public DateTime EffectDate { get; set; }
        public DateTime? Saveon { get; set; }
        public string? DsysCode { get; set; }
        public string? DcatCode { get; set; }
        public string? DofficialNo { get; set; }
        public bool? Forward { get; set; }
        public DateTime? Forwardon { get; set; }
        public string? Remarks { get; set; }
        public bool? Reject { get; set; }
        public string? BaseCode { get; set; }
        public bool ActionTaken { get; set; }
        public bool PayAction { get; set; }
        public long? TransId { get; set; }
    }
}
