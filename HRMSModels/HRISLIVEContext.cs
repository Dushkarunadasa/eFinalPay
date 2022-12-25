using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace FinaPay.HRMSModels
{
    public partial class HRISLIVEContext : DbContext
    {
        public HRISLIVEContext()
        {
        }

        public HRISLIVEContext(DbContextOptions<HRISLIVEContext> options)
            : base(options)
        {
        }

        public virtual DbSet<HrisTPersonalDatum> HrisTPersonalData { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("server=10.10.1.215;user=sa;password=SDUAdmin@2019;database=HRISLIVE");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HrisTPersonalDatum>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("HRIS_T_personalData");

                entity.Property(e => e.AutherizedBy)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("autherizedBy");

                entity.Property(e => e.AutherizedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("autherizedDate");

                entity.Property(e => e.BaseActiveType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("baseActiveType");

                entity.Property(e => e.BranchCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("branchCode");

                entity.Property(e => e.BranchCodeOld)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("branchCodeOld");

                entity.Property(e => e.CivilStatus)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("civilStatus");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("createdDate");

                entity.Property(e => e.CreatedUser)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("createdUser");

                entity.Property(e => e.DateOfBirth)
                    .HasColumnType("date")
                    .HasColumnName("dateOfBirth");

                entity.Property(e => e.DateOfEnlistment)
                    .HasColumnType("date")
                    .HasColumnName("dateOfEnlistment");

                entity.Property(e => e.DivoceDate)
                    .HasColumnType("date")
                    .HasColumnName("divoceDate");

                entity.Property(e => e.DogTagNumber).HasColumnName("dogTagNumber");

                entity.Property(e => e.EmailAddress)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("emailAddress");

                entity.Property(e => e.EnlistRefDate)
                    .HasColumnType("date")
                    .HasColumnName("enlistRefDate");

                entity.Property(e => e.EnlistReference)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("enlistReference");

                entity.Property(e => e.EntryCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("entryCode");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("firstName");

                entity.Property(e => e.FullName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("fullName");

                entity.Property(e => e.Gender)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("gender");

                entity.Property(e => e.Image)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("image");

                entity.Property(e => e.Initials)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("initials");

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.IsGetUpdateList).HasColumnName("isGetUpdateList");

                entity.Property(e => e.IsUniformStaff).HasColumnName("isUniformStaff");

                entity.Property(e => e.Last327BaseCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("last327BaseCode");

                entity.Property(e => e.LastModifiedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("lastModifiedDate");

                entity.Property(e => e.LastModifiedUser)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("lastModifiedUser");

                entity.Property(e => e.MarriageDate)
                    .HasColumnType("date")
                    .HasColumnName("marriageDate");

                entity.Property(e => e.MobileTp)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("mobileTP");

                entity.Property(e => e.NavyIdExpireDate)
                    .HasColumnType("date")
                    .HasColumnName("navyIdExpireDate");

                entity.Property(e => e.NavyIdNumber)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("navyIdNumber");

                entity.Property(e => e.NicNoSsid)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("nicNo_SSID");

                entity.Property(e => e.OfficerSailor)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("officerSailor");

                entity.Property(e => e.OfficialNo).HasColumnName("officialNo");

                entity.Property(e => e.PermanentAreaCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("permanentAreaCode");

                entity.Property(e => e.PermanentBaseCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("permanentBaseCode");

                entity.Property(e => e.PermanentSubunitCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("permanentSubunitCode");

                entity.Property(e => e.PermanentTp)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("permanentTP");

                entity.Property(e => e.PersonnelEmailAddress)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("personnel_emailAddress");

                entity.Property(e => e.PresentTp)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("presentTP");

                entity.Property(e => e.RaceCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("raceCode");

                entity.Property(e => e.RankRateCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("rankRateCode");

                entity.Property(e => e.ReligionCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("religionCode");

                entity.Property(e => e.ResignType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceType)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("serviceType");

                entity.Property(e => e.SpecialisationCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("specialisationCode");

                entity.Property(e => e.StructureId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("structureId");

                entity.Property(e => e.Surename)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("surename");

                entity.Property(e => e.TemporaryAreaCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("temporaryAreaCode");

                entity.Property(e => e.TemporaryBaseCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("temporaryBaseCode");

                entity.Property(e => e.TemporarySubunitCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("temporarySubunitCode");

                entity.Property(e => e._327baseCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("327BaseCode");

                entity.Property(e => e._327subUnitCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("327SubUnitCode");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
