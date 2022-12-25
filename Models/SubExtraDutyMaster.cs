using System;
using System.Collections.Generic;

namespace FinaPay.Models
{
    public partial class SubExtraDutyMaster
    {
        public string TransId { get; set; } = null!;
        public double PayMonth { get; set; }
        public string BaseCode { get; set; } = null!;
        public bool Tsave { get; set; }
        public string? TsaveSysCode { get; set; }
        public string? TsaveCatCode { get; set; }
        public string? TsaveBy { get; set; }
        public DateTime? TsaveOn { get; set; }
        public bool Tconfirm { get; set; }
        public string? TconfirmSysCode { get; set; }
        public string? TconfirmCatCode { get; set; }
        public string? TconfirmBy { get; set; }
        public DateTime? TconfirmOn { get; set; }
        public bool TconfirmReject { get; set; }
        public bool Tforward { get; set; }
        public string? TforwardSysCode { get; set; }
        public string? TforwardCatCode { get; set; }
        public string? TforwardBy { get; set; }
        public DateTime? TforwardOn { get; set; }
        public bool TpayHead { get; set; }
        public string? TpayHeadSysCode { get; set; }
        public string? TpayHeadCatCode { get; set; }
        public string? Thead { get; set; }
        public DateTime? TpayHeadOn { get; set; }
        public bool Tsubject { get; set; }
        public string? TsubClarkSysCode { get; set; }
        public string? TsubClarlCatCode { get; set; }
        public string? TsubClark { get; set; }
        public DateTime? TsubClarkOn { get; set; }
        public bool Treject { get; set; }
        public string? TrejectSysCode { get; set; }
        public string? TrejectCatCode { get; set; }
        public string? Trejectby { get; set; }
        public DateTime? TrejectOn { get; set; }
        public string? TrejectReason { get; set; }
        public string? ItemCode { get; set; }
        public decimal? Amount { get; set; }
        public int? TotalHours { get; set; }
        public string? Remarks { get; set; }
    }
}
