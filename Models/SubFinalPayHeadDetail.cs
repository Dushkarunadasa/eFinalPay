using System;
using System.Collections.Generic;

namespace FinaPay.Models
{
    public partial class SubFinalPayHeadDetail
    {
        public int TransId { get; set; }
        public string SysCode { get; set; } = null!;
        public string CatCode { get; set; } = null!;
        public string OfficialNo { get; set; } = null!;
        public string? Type { get; set; }
        public string? NgReference { get; set; }
        public DateTime? DischargeDt { get; set; }
        public bool PForm { get; set; }
        public string? PFormPath { get; set; }
        public string? BaseCode { get; set; }
        public int? BankCode { get; set; }
        public int? BranchCode { get; set; }
        public int? AccountNo { get; set; }
        public string? VoucherNo { get; set; }
        public string? VoucherDes { get; set; }
        public string? ChequeNo { get; set; }
        public DateTime? ChequeDt { get; set; }
        public DateTime? PaymentDt { get; set; }
        public bool? ActionComplete { get; set; }
        public string? Remarks { get; set; }
        public bool? Ddnpay { get; set; }
        public bool? PaySubClerk { get; set; }
        public bool? PaySsailor { get; set; }
        public bool? AuditSubClerk { get; set; }
        public bool? AuditSsailor { get; set; }
        public bool? AuditOfficer { get; set; }
        public bool? Ssopay { get; set; }
        public bool? PenSailor { get; set; }
        public bool? PenSsailor { get; set; }
        public bool? Reject { get; set; }
        public string? RejectedReason { get; set; }
        public string? RejectedBy { get; set; }
        public DateTime? RejectedOn { get; set; }
        public bool? CheckPayment { get; set; }
        public bool? SubjectClerk { get; set; }
        public bool? Authorized { get; set; }
        public int? Unit { get; set; }
    }
}
