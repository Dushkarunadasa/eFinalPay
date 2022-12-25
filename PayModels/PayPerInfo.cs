using System;
using System.Collections.Generic;

namespace FinaPay.PayModels
{
    public partial class PayPerInfo
    {
        public PayPerInfo()
        {
            PayGcbdetails = new HashSet<PayGcbdetail>();
            PayItemMonthlyTrans = new HashSet<PayItemMonthlyTran>();
            PayLoanDetails = new HashSet<PayLoanDetail>();
            PayQpayDetails = new HashSet<PayQpayDetail>();
            PaySalaryProcesses = new HashSet<PaySalaryProcess>();
            PayStatusDetails = new HashSet<PayStatusDetail>();
            ItemCs = new HashSet<PayItem>();
        }

        public string SysCode { get; set; } = null!;
        public string CatCode { get; set; } = null!;
        public string OfficerCode { get; set; } = null!;
        public string RankCode { get; set; } = null!;
        public string Initials { get; set; } = null!;
        public string SurName { get; set; } = null!;
        public string FullName { get; set; } = null!;
        public string BaseCode { get; set; } = null!;
        public string? SubUnitCode { get; set; }
        public string? BranchCode { get; set; }
        public string Nicnumber { get; set; } = null!;
        public string NavyId { get; set; } = null!;
        public string PermanentAdd { get; set; } = null!;
        public string OtherAdd { get; set; } = null!;
        public string Gender { get; set; } = null!;
        public string CivilStatus { get; set; } = null!;
        public string? ReligCode { get; set; }
        public DateTime DateBirth { get; set; }
        public DateTime DateJoin { get; set; }
        public string Tel { get; set; } = null!;
        public string Fax { get; set; } = null!;
        public string Email { get; set; } = null!;
        public byte[]? Picture { get; set; }
        public int RankStage { get; set; }
        public decimal? Bsalary { get; set; }
        public bool? Status { get; set; }
        public decimal? ReEngPay { get; set; }
        public string NkinName { get; set; } = null!;
        public string NkinAdd { get; set; } = null!;
        public string NkinRelation { get; set; } = null!;
        public string NkinBaseCode { get; set; } = null!;
        public string NkinBaseSubCode { get; set; } = null!;
        public string? FullNameSin { get; set; }
        public string? NavyIdsin { get; set; }
        public string? OfficerCodeSin { get; set; }
        public string? AddressSin { get; set; }
        public bool ProcessStatus { get; set; }
        public decimal? SalDispAmt { get; set; }
        public DateTime? StatusEffectDate { get; set; }
        public bool? PaySalary { get; set; }
        public string? RankGroup { get; set; }
        public int? VotId { get; set; }
        public int? WOp { get; set; }
        public string? Policino { get; set; }
        public string? IntnameSin { get; set; }
        public string? SysType { get; set; }
        public string? TaxTable { get; set; }

        public virtual ICollection<PayGcbdetail> PayGcbdetails { get; set; }
        public virtual ICollection<PayItemMonthlyTran> PayItemMonthlyTrans { get; set; }
        public virtual ICollection<PayLoanDetail> PayLoanDetails { get; set; }
        public virtual ICollection<PayQpayDetail> PayQpayDetails { get; set; }
        public virtual ICollection<PaySalaryProcess> PaySalaryProcesses { get; set; }
        public virtual ICollection<PayStatusDetail> PayStatusDetails { get; set; }

        public virtual ICollection<PayItem> ItemCs { get; set; }
    }
}
