using System;
using System.Collections.Generic;

namespace FinaPay.PayModels
{
    public partial class PayBank
    {
        public PayBank()
        {
            PayBankBranches = new HashSet<PayBankBranch>();
        }

        public string BankCode { get; set; } = null!;
        public string BankName { get; set; } = null!;
        public string? BankSname { get; set; }

        public virtual ICollection<PayBankBranch> PayBankBranches { get; set; }
    }
}
