using System;
using System.Collections.Generic;

namespace FinaPay.PayModels
{
    public partial class PayVwRptDiletter
    {
        public string Syscode { get; set; } = null!;
        public string Catcode { get; set; } = null!;
        public string Officercode { get; set; } = null!;
        public string Bankcode { get; set; } = null!;
        public string Barnchcode { get; set; } = null!;
        public decimal? Amttosend { get; set; }
        public string? Depnid { get; set; }
        public string? Accno { get; set; }
        public string Bankname { get; set; } = null!;
        public string BranchName { get; set; } = null!;
        public string InitialsD { get; set; } = null!;
        public string SurnameD { get; set; } = null!;
        public string AddressD { get; set; } = null!;
        public string? FullNameSinD { get; set; }
        public string? AddressSinD { get; set; }
        public string SurName { get; set; } = null!;
        public string FullName { get; set; } = null!;
        public string? FullNameSin { get; set; }
        public string? OfficerCodeSin { get; set; }
        public string? RankNameSin { get; set; }
        public string CurMonth { get; set; } = null!;
        public decimal PerOfSalary { get; set; }
    }
}
