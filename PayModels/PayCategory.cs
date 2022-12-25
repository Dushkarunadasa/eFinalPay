using System;
using System.Collections.Generic;

namespace FinaPay.PayModels
{
    public partial class PayCategory
    {
        public PayCategory()
        {
            PayBranches = new HashSet<PayBranch>();
            PayItemMonthlyTrans = new HashSet<PayItemMonthlyTran>();
            PnsCatPercentages = new HashSet<PnsCatPercentage>();
        }

        public string CatCode { get; set; } = null!;
        public string CatName { get; set; } = null!;
        public decimal SalDispAmt { get; set; }
        public string? CatSname { get; set; }

        public virtual PnsSetUp? PnsSetUp { get; set; }
        public virtual ICollection<PayBranch> PayBranches { get; set; }
        public virtual ICollection<PayItemMonthlyTran> PayItemMonthlyTrans { get; set; }
        public virtual ICollection<PnsCatPercentage> PnsCatPercentages { get; set; }
    }
}
