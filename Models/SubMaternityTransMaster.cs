using System;
using System.Collections.Generic;

namespace FinaPay.Models
{
    public partial class SubMaternityTransMaster
    {
        public string TransId { get; set; } = null!;
        public double PayMonth { get; set; }
        public string? SysCode { get; set; }
        public string? CatCode { get; set; }
        public string? OfficialNo { get; set; }
        public int UnitCode { get; set; }
        public string BaseCode { get; set; } = null!;
        public string LeaveType { get; set; } = null!;
        public int? Nofleaves { get; set; }
        public DateTime? FromDt { get; set; }
        public DateTime? ToDt { get; set; }
        public string? Remarks { get; set; }
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
        public bool Tforward { get; set; }
        public string? TforwardSysCode { get; set; }
        public string? TforwardCatCode { get; set; }
        public string? TforwardBy { get; set; }
        public DateTime? TforwardOn { get; set; }
        public bool TpayHead { get; set; }
        public string? TpayHeadSysCode { get; set; }
        public string? TpayHeadCatCode { get; set; }
        public string? TheadBy { get; set; }
        public DateTime? TpayHeadOn { get; set; }
        public bool Tsubject { get; set; }
        public string? TsubClarkSysCode { get; set; }
        public string? TsubClarkCatCode { get; set; }
        public string? TsubClarkBy { get; set; }
        public DateTime? TsubClarkOn { get; set; }
        public bool TauditStaff { get; set; }
        public string? TsauditSysCode { get; set; }
        public string? TsauditCatCode { get; set; }
        public string? TsauditOfficialNo { get; set; }
        public DateTime? TsauditedOn { get; set; }
        public bool Taudit { get; set; }
        public string? TauditSysCode { get; set; }
        public string? TauditCatCode { get; set; }
        public string? TauditOfficialNo { get; set; }
        public DateTime? TauditedOn { get; set; }
        public bool Tsso { get; set; }
        public string? TssosysCode { get; set; }
        public string? TssocatCode { get; set; }
        public string? Tssoby { get; set; }
        public DateTime? Tssoon { get; set; }
        public bool Treject { get; set; }
        public string? TrejectSysCode { get; set; }
        public string? TrejectCatCode { get; set; }
        public string? Trejectby { get; set; }
        public DateTime? TrejectOn { get; set; }
        public string? TrejectReason { get; set; }
        public string? Path { get; set; }
    }
}
