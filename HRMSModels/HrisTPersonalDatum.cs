using System;
using System.Collections.Generic;

namespace FinaPay.HRMSModels
{
    public partial class HrisTPersonalDatum
    {
        public string NicNoSsid { get; set; } = null!;
        public int OfficialNo { get; set; }
        public string ServiceType { get; set; } = null!;
        public string OfficerSailor { get; set; } = null!;
        public string? NavyIdNumber { get; set; }
        public DateTime? NavyIdExpireDate { get; set; }
        public string? StructureId { get; set; }
        public string? FullName { get; set; }
        public string? Initials { get; set; }
        public string? FirstName { get; set; }
        public string? Surename { get; set; }
        public string? BranchCode { get; set; }
        public string? BranchCodeOld { get; set; }
        public string? SpecialisationCode { get; set; }
        public string? RankRateCode { get; set; }
        public string? Gender { get; set; }
        public DateTime? DateOfEnlistment { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string? RaceCode { get; set; }
        public string? ReligionCode { get; set; }
        public string? CivilStatus { get; set; }
        public DateTime? MarriageDate { get; set; }
        public DateTime? DivoceDate { get; set; }
        public string? EntryCode { get; set; }
        public string? PresentTp { get; set; }
        public string? PermanentTp { get; set; }
        public string? MobileTp { get; set; }
        public string? EmailAddress { get; set; }
        public string? PermanentAreaCode { get; set; }
        public string? TemporaryAreaCode { get; set; }
        public string? PermanentBaseCode { get; set; }
        public string? TemporaryBaseCode { get; set; }
        public string? PermanentSubunitCode { get; set; }
        public string? TemporarySubunitCode { get; set; }
        public string? Image { get; set; }
        public bool? IsUniformStaff { get; set; }
        public bool? IsActive { get; set; }
        public string? CreatedUser { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? LastModifiedUser { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public string? AutherizedBy { get; set; }
        public DateTime? AutherizedDate { get; set; }
        public int? DogTagNumber { get; set; }
        public string? EnlistReference { get; set; }
        public DateTime? EnlistRefDate { get; set; }
        public string? BaseActiveType { get; set; }
        public string? _327baseCode { get; set; }
        public string? _327subUnitCode { get; set; }
        public string? Last327BaseCode { get; set; }
        public bool? IsGetUpdateList { get; set; }
        public string? PersonnelEmailAddress { get; set; }
        public string? ResignType { get; set; }
        public DateTime? FromDate { get; set; }
    }
}
