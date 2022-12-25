using System;
using System.Collections.Generic;

namespace FinaPay.PayModels
{
    public partial class PayBankBranch
    {
        public string BankCode { get; set; } = null!;
        public string BranchCode { get; set; } = null!;
        public string BranchName { get; set; } = null!;
        public string? Address { get; set; }
        public string? Telephone { get; set; }
        public string? Fax { get; set; }
        public string? Email { get; set; }
        public bool Etrans { get; set; }
        public string? BranchSname { get; set; }

        public virtual PayBank BankCodeNavigation { get; set; } = null!;
    }
}
