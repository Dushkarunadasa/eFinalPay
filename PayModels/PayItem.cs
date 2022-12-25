using System;
using System.Collections.Generic;

namespace FinaPay.PayModels
{
    public partial class PayItem
    {
        public PayItem()
        {
            PayItemBases = new HashSet<PayItemBase>();
            PayItemMonthlyTrans = new HashSet<PayItemMonthlyTran>();
            PayItemRanks = new HashSet<PayItemRank>();
            PayItemRestrics = new HashSet<PayItemRestric>();
            PayLoanDetails = new HashSet<PayLoanDetail>();
            PaySalaryProcesses = new HashSet<PaySalaryProcess>();
            PayPerInfos = new HashSet<PayPerInfo>();
        }

        public string ItemCode { get; set; } = null!;
        public string ItemCategory { get; set; } = null!;
        public string ItemName { get; set; } = null!;
        public string ItemAltName { get; set; } = null!;
        public string? Type { get; set; }
        public decimal? Rate { get; set; }
        public bool? GrossPay { get; set; }
        public bool? Nopay { get; set; }
        public bool? Wop { get; set; }
        public bool? OnBasicSalary { get; set; }
        public string? Bank { get; set; }
        public string? BankBranch { get; set; }
        public string? AccNoVotNo { get; set; }
        public bool? Cheque { get; set; }
        public bool? BasedOnDays { get; set; }
        public string? AreasOverPayItemCode { get; set; }
        public string? AreasOverPayItemCategory { get; set; }
        public string? BasicYearMonth { get; set; }
        public decimal? Percentage { get; set; }
        public bool? Special { get; set; }
        public bool? GrossPdu { get; set; }
        public bool? BaseValidation { get; set; }
        public bool? ValidateNav32 { get; set; }
        public bool? HalfPay { get; set; }
        public bool? Tax { get; set; }

        public virtual PayItemGroup? PayItemGroup { get; set; }
        public virtual ICollection<PayItemBase> PayItemBases { get; set; }
        public virtual ICollection<PayItemMonthlyTran> PayItemMonthlyTrans { get; set; }
        public virtual ICollection<PayItemRank> PayItemRanks { get; set; }
        public virtual ICollection<PayItemRestric> PayItemRestrics { get; set; }
        public virtual ICollection<PayLoanDetail> PayLoanDetails { get; set; }
        public virtual ICollection<PaySalaryProcess> PaySalaryProcesses { get; set; }

        public virtual ICollection<PayPerInfo> PayPerInfos { get; set; }
    }
}
