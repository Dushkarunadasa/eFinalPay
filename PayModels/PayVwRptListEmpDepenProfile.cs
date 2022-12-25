using System;
using System.Collections.Generic;

namespace FinaPay.PayModels
{
    public partial class PayVwRptListEmpDepenProfile
    {
        public string SysCode { get; set; } = null!;
        public string CatCode { get; set; } = null!;
        public string OfficerCode { get; set; } = null!;
        public string? Name { get; set; }
        public string DepnId { get; set; } = null!;
        public string Surname { get; set; } = null!;
        public string Nicno { get; set; } = null!;
        public string Address { get; set; } = null!;
        public DateTime DateBirth { get; set; }
        public string DepnTypeCode { get; set; } = null!;
        public byte[]? Picture { get; set; }
        public string Telephone { get; set; } = null!;
        public string Fax { get; set; } = null!;
        public string Email { get; set; } = null!;
        public decimal PerOfSalary { get; set; }
        public string? FullNameSin { get; set; }
        public string? AddressSin { get; set; }
        public int? WOp { get; set; }
        public bool? Status { get; set; }
    }
}
