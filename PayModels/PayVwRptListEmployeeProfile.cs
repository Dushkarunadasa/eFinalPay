using System;
using System.Collections.Generic;

namespace FinaPay.PayModels
{
    public partial class PayVwRptListEmployeeProfile
    {
        public string SysCode { get; set; } = null!;
        public string? SysName { get; set; }
        public string CatCode { get; set; } = null!;
        public string? CatName { get; set; }
        public string OfficerCode { get; set; } = null!;
        public string RankCode { get; set; } = null!;
        public string? RankName { get; set; }
        public string Name { get; set; } = null!;
        public string FullName { get; set; } = null!;
        public string BaseCode { get; set; } = null!;
        public string? BaseName { get; set; }
        public string? SubUnitCode { get; set; }
        public string? BranchCode { get; set; }
        public string? Branchname { get; set; }
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
        public int? WOp { get; set; }
        public DateTime? DateConfirmed { get; set; }
    }
}
