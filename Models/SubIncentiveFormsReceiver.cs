using System;
using System.Collections.Generic;

namespace FinaPay.Models
{
    public partial class SubIncentiveFormsReceiver
    {
        public decimal Iid { get; set; }
        public int Unit { get; set; }
        public string? BaseCode { get; set; }
        public int? Forder { get; set; }
        public string? SsysCode { get; set; }
        public string? ScatCode { get; set; }
        public string? SofficialNo { get; set; }
        public bool? Saction { get; set; }
        public DateTime? Son { get; set; }
        public string? SecSysCode { get; set; }
        public string? SecCatCode { get; set; }
        public string? SecOfficialNo { get; set; }
        public bool? SecAction { get; set; }
        public DateTime? SecOn { get; set; }
        public string? AsysCode { get; set; }
        public string? AcatCode { get; set; }
        public string? AofficialNo { get; set; }
        public bool? Aaction { get; set; }
        public DateTime? Aon { get; set; }
        public bool? Rejected { get; set; }
        public DateTime? RejectedOn { get; set; }
        public string? Remarks { get; set; }
    }
}
