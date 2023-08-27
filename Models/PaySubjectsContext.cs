using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace FinaPay.Models
{
    public partial class PaySubjectsContext : DbContext
    {
        public PaySubjectsContext()
        {
        }

        public PaySubjectsContext(DbContextOptions<PaySubjectsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ConsolidatedSalForAllowance> ConsolidatedSalForAllowances { get; set; } = null!;
        public virtual DbSet<FailedJob> FailedJobs { get; set; } = null!;
        public virtual DbSet<Migration> Migrations { get; set; } = null!;
        public virtual DbSet<PasswordReset> PasswordResets { get; set; } = null!;
        public virtual DbSet<PayBasicRankScaleD> PayBasicRankScaleDs { get; set; } = null!;
        public virtual DbSet<PayBasicScaleD> PayBasicScaleDs { get; set; } = null!;
        public virtual DbSet<PayProcessMonth> PayProcessMonths { get; set; } = null!;
        public virtual DbSet<PayRankD> PayRankDs { get; set; } = null!;
        public virtual DbSet<PersonalAccessToken> PersonalAccessTokens { get; set; } = null!;
        public virtual DbSet<Sub327Action> Sub327Actions { get; set; } = null!;
        public virtual DbSet<Sub327List> Sub327Lists { get; set; } = null!;
        public virtual DbSet<Sub327adjustmentTran> Sub327adjustmentTrans { get; set; } = null!;
        public virtual DbSet<Sub327item> Sub327items { get; set; } = null!;
        public virtual DbSet<SubAllowanceArea> SubAllowanceAreas { get; set; } = null!;
        public virtual DbSet<SubAllowanceIncentive> SubAllowanceIncentives { get; set; } = null!;
        public virtual DbSet<SubAllowancesArrearsCode> SubAllowancesArrearsCodes { get; set; } = null!;
        public virtual DbSet<SubAllowancesBranch> SubAllowancesBranches { get; set; } = null!;
        public virtual DbSet<SubAllowancesCalGroup> SubAllowancesCalGroups { get; set; } = null!;
        public virtual DbSet<SubAllowancesCondition> SubAllowancesConditions { get; set; } = null!;
        public virtual DbSet<SubAllowancesGroup> SubAllowancesGroups { get; set; } = null!;
        public virtual DbSet<SubAllowancesLog> SubAllowancesLogs { get; set; } = null!;
        public virtual DbSet<SubAllowancesOverPayCode> SubAllowancesOverPayCodes { get; set; } = null!;
        public virtual DbSet<SubAllowancesRank> SubAllowancesRanks { get; set; } = null!;
        public virtual DbSet<SubAllowancesRestricted> SubAllowancesRestricteds { get; set; } = null!;
        public virtual DbSet<SubAllowancesSubItem> SubAllowancesSubItems { get; set; } = null!;
        public virtual DbSet<SubAllowancesSubject> SubAllowancesSubjects { get; set; } = null!;
        public virtual DbSet<SubAllowancesSysCat> SubAllowancesSysCats { get; set; } = null!;
        public virtual DbSet<SubAllowancesTransDetail> SubAllowancesTransDetails { get; set; } = null!;
        public virtual DbSet<SubAllowancesTransDetailsHistory> SubAllowancesTransDetailsHistories { get; set; } = null!;
        public virtual DbSet<SubAllowancesTransDetailsHistory1> SubAllowancesTransDetailsHistory1s { get; set; } = null!;
        public virtual DbSet<SubAllowancesTransId> SubAllowancesTransIds { get; set; } = null!;
        public virtual DbSet<SubAllowancesTransMaster> SubAllowancesTransMasters { get; set; } = null!;
        public virtual DbSet<SubAttachment> SubAttachments { get; set; } = null!;
        public virtual DbSet<SubBaseChange> SubBaseChanges { get; set; } = null!;
        public virtual DbSet<SubBaseMatching> SubBaseMatchings { get; set; } = null!;
        public virtual DbSet<SubExtraDutyDetail> SubExtraDutyDetails { get; set; } = null!;
        public virtual DbSet<SubExtraDutyDetailsHistory> SubExtraDutyDetailsHistories { get; set; } = null!;
        public virtual DbSet<SubExtraDutyMaster> SubExtraDutyMasters { get; set; } = null!;
        public virtual DbSet<SubFinalPay327Head> SubFinalPay327Heads { get; set; } = null!;
        public virtual DbSet<SubFinalPay327List> SubFinalPay327Lists { get; set; } = null!;
        public virtual DbSet<SubFinalPayDetail> SubFinalPayDetails { get; set; } = null!;
        public virtual DbSet<SubFinalPayDischargeType> SubFinalPayDischargeTypes { get; set; } = null!;
        public virtual DbSet<SubFinalPayHeadDetail> SubFinalPayHeadDetails { get; set; } = null!;
        public virtual DbSet<SubFinalPayItem> SubFinalPayItems { get; set; } = null!;
        public virtual DbSet<SubFinalPayItemList> SubFinalPayItemLists { get; set; } = null!;
        public virtual DbSet<SubFinalPayLogDetail> SubFinalPayLogDetails { get; set; } = null!;
        public virtual DbSet<SubGradeDetail> SubGradeDetails { get; set; } = null!;
        public virtual DbSet<SubGradeRate> SubGradeRates { get; set; } = null!;
        public virtual DbSet<SubHoliday> SubHolidays { get; set; } = null!;
        public virtual DbSet<SubIncentiveForm> SubIncentiveForms { get; set; } = null!;
        public virtual DbSet<SubIncentiveFormsReceiver> SubIncentiveFormsReceivers { get; set; } = null!;
        public virtual DbSet<SubLog> SubLogs { get; set; } = null!;
        public virtual DbSet<SubMaternityTransDetail> SubMaternityTransDetails { get; set; } = null!;
        public virtual DbSet<SubMaternityTransMaster> SubMaternityTransMasters { get; set; } = null!;
        public virtual DbSet<SubRole> SubRoles { get; set; } = null!;
        public virtual DbSet<SubRoleAllowance> SubRoleAllowances { get; set; } = null!;
        public virtual DbSet<SubRoleTypeAllowance> SubRoleTypeAllowances { get; set; } = null!;
        public virtual DbSet<SubSubItem> SubSubItems { get; set; } = null!;
        public virtual DbSet<SubSubject> SubSubjects { get; set; } = null!;
        public virtual DbSet<SubTransDetail> SubTransDetails { get; set; } = null!;
        public virtual DbSet<SubTransId> SubTransIds { get; set; } = null!;
        public virtual DbSet<SubTransaction> SubTransactions { get; set; } = null!;
        public virtual DbSet<SubTransactionFilePathD> SubTransactionFilePathDs { get; set; } = null!;
        public virtual DbSet<SubTransactionHistory> SubTransactionHistories { get; set; } = null!;
        public virtual DbSet<SubUnitsD> SubUnitsDs { get; set; } = null!;
        public virtual DbSet<SubUnitsDetailsAllowance> SubUnitsDetailsAllowances { get; set; } = null!;
        public virtual DbSet<SystemFreeze> SystemFreezes { get; set; } = null!;
        public virtual DbSet<TempAllowanceTran> TempAllowanceTrans { get; set; } = null!;
        public virtual DbSet<TempAllowanceTransaction> TempAllowanceTransactions { get; set; } = null!;
        public virtual DbSet<TempTransaction> TempTransactions { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;
        public virtual DbSet<View1> View1s { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=10.10.1.232;Database=PaySubjects;User ID=sa;Password=SDUAdmin@2019;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ConsolidatedSalForAllowance>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Consolidated_Sal_For_Allowances");

                entity.Property(e => e.CatCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.OfficerCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Rate).HasColumnType("numeric(23, 6)");

                entity.Property(e => e.SysCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FailedJob>(entity =>
            {
                entity.ToTable("failed_jobs");

                entity.HasIndex(e => e.Uuid, "failed_jobs_uuid_unique")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Connection).HasColumnName("connection");

                entity.Property(e => e.Exception).HasColumnName("exception");

                entity.Property(e => e.FailedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("failed_at")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Payload).HasColumnName("payload");

                entity.Property(e => e.Queue).HasColumnName("queue");

                entity.Property(e => e.Uuid)
                    .HasMaxLength(255)
                    .HasColumnName("uuid");
            });

            modelBuilder.Entity<Migration>(entity =>
            {
                entity.ToTable("migrations");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Batch).HasColumnName("batch");

                entity.Property(e => e.Migration1)
                    .HasMaxLength(255)
                    .HasColumnName("migration");
            });

            modelBuilder.Entity<PasswordReset>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("password_resets");

                entity.HasIndex(e => e.Email, "password_resets_email_index");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at");

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .HasColumnName("email");

                entity.Property(e => e.Token)
                    .HasMaxLength(255)
                    .HasColumnName("token");
            });

            modelBuilder.Entity<PayBasicRankScaleD>(entity =>
            {
                entity.HasKey(e => new { e.RankCode, e.ScaleCode, e.Sequence })
                    .HasName("PK_Basic_Rank_Scale_D");

                entity.ToTable("Pay_Basic_Rank_Scale_D");

                entity.Property(e => e.RankCode)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Adjustment).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ConsolidatedSal).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.RankCat)
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<PayBasicScaleD>(entity =>
            {
                entity.HasKey(e => e.ScaleCode)
                    .HasName("PK_Basic_Scale_D");

                entity.ToTable("Pay_Basic_Scale_D");

                entity.Property(e => e.ScaleCode)
                    .ValueGeneratedNever()
                    .HasColumnName("Scale_Code");

                entity.Property(e => e.ApprovedBy).HasMaxLength(12);

                entity.Property(e => e.ApprovedOn).HasColumnType("datetime");

                entity.Property(e => e.InsertOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsertedBy)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<PayProcessMonth>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Pay_ProcessMonth");

                entity.Property(e => e.CurMonth)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.PrevMonth)
                    .HasMaxLength(6)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PayRankD>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Pay_Rank_D");

                entity.Property(e => e.CatCode).HasMaxLength(50);

                entity.Property(e => e.NoAnnualIncrement).HasDefaultValueSql("((0))");

                entity.Property(e => e.NoProIncNewRank).HasDefaultValueSql("((0))");

                entity.Property(e => e.NoPromIncPrevRank).HasDefaultValueSql("((0))");

                entity.Property(e => e.NotEffectConsolidated).HasDefaultValueSql("((0))");

                entity.Property(e => e.RankCode).HasMaxLength(4);

                entity.Property(e => e.RankGroup)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.RankName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RankNameSin).HasMaxLength(50);

                entity.Property(e => e.ScaleRankCode).HasMaxLength(4);

                entity.Property(e => e.ScaleTop).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<PersonalAccessToken>(entity =>
            {
                entity.ToTable("personal_access_tokens");

                entity.HasIndex(e => e.Token, "personal_access_tokens_token_unique")
                    .IsUnique();

                entity.HasIndex(e => new { e.TokenableType, e.TokenableId }, "personal_access_tokens_tokenable_type_tokenable_id_index");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Abilities).HasColumnName("abilities");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at");

                entity.Property(e => e.LastUsedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_used_at");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.Token)
                    .HasMaxLength(64)
                    .HasColumnName("token");

                entity.Property(e => e.TokenableId).HasColumnName("tokenable_id");

                entity.Property(e => e.TokenableType)
                    .HasMaxLength(255)
                    .HasColumnName("tokenable_type");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<Sub327Action>(entity =>
            {
                entity.HasKey(e => new { e.TransId, e.ActionOn });

                entity.ToTable("Sub_327_Action");

                entity.Property(e => e.TransId)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.ActionOn).HasColumnType("datetime");

                entity.Property(e => e.CatCode)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.OfficialNo)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Remarks).HasMaxLength(100);

                entity.Property(e => e.SysCode)
                    .HasMaxLength(3)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Sub327List>(entity =>
            {
                entity.HasKey(e => new { e.TransId, e.OrderId })
                    .HasName("PK_Sub_327_List_1");

                entity.ToTable("Sub_327_List");

                entity.Property(e => e.TransId)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CatCode)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.ItemCat)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.ItemCode)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.OfficialNo)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.SysCode)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e._596).HasColumnName("596");

                entity.Property(e => e._598).HasColumnName("598");

                entity.Property(e => e._600).HasColumnName("600");

                entity.Property(e => e._605606).HasColumnName("605/606");

                entity.Property(e => e._605a606a).HasColumnName("605A/606A");

                entity.Property(e => e._610611).HasColumnName("610/611");

                entity.Property(e => e._612613).HasColumnName("612/613");

                entity.Property(e => e._615614).HasColumnName("615/614");

                entity.Property(e => e._619).HasColumnName("619");

                entity.Property(e => e._630).HasColumnName("630");

                entity.Property(e => e._686687).HasColumnName("686/687");

                entity.Property(e => e._688689).HasColumnName("688/689");

                entity.Property(e => e._690).HasColumnName("690");

                entity.HasOne(d => d.Trans)
                    .WithMany(p => p.Sub327Lists)
                    .HasForeignKey(d => d.TransId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Sub_327_List_Sub_327_List");
            });

            modelBuilder.Entity<Sub327adjustmentTran>(entity =>
            {
                entity.HasKey(e => e.TransId);

                entity.ToTable("Sub_327Adjustment_Trans");

                entity.Property(e => e.TransId)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Acheck)
                    .HasColumnName("ACheck")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Aconfirm)
                    .HasColumnName("AConfirm")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Aforward)
                    .HasColumnName("AForward")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AuditOfficer).HasDefaultValueSql("((0))");

                entity.Property(e => e.AuditStaff).HasDefaultValueSql("((0))");

                entity.Property(e => e.BaseCode)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.CurrentPayMonth)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Dcheck)
                    .HasColumnName("DCheck")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Dconfirm)
                    .HasColumnName("DConfirm")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Ddnpay)
                    .HasColumnName("DDNPay")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DeductAmount)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Des).HasMaxLength(300);

                entity.Property(e => e.Dforward)
                    .HasColumnName("DForward")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FilePath).HasMaxLength(300);

                entity.Property(e => e.PayAction).HasDefaultValueSql("((0))");

                entity.Property(e => e.PayActionRemarks).HasMaxLength(200);

                entity.Property(e => e.Reject).HasDefaultValueSql("((0))");

                entity.Property(e => e.Remarks).HasMaxLength(50);

                entity.Property(e => e.Sso)
                    .HasColumnName("SSO")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Subject).HasDefaultValueSql("((0))");

                entity.Property(e => e.Tconfirm)
                    .HasColumnName("TConfirm")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Tforward)
                    .HasColumnName("TForward")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Total327)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Tsave)
                    .HasColumnName("TSave")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Sub327item>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Sub_327Items");

                entity.Property(e => e.ArrearsCode)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.ArrearsCodeCat)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.CatCode)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.ItemCategory)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ItemCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasMaxLength(1)
                    .IsFixedLength();
            });

            modelBuilder.Entity<SubAllowanceArea>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Sub_Allowance_Areas");

                entity.Property(e => e.Area).HasMaxLength(200);

                entity.Property(e => e.BaseCode)
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<SubAllowanceIncentive>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Sub_Allowance_Incentives");

                entity.Property(e => e.ItemCode)
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<SubAllowancesArrearsCode>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Sub_Allowances_ArrearsCodes");

                entity.Property(e => e.ArrearsCode)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.ItemCode)
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<SubAllowancesBranch>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Sub_Allowances_Branch");

                entity.Property(e => e.Branch)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.ItemCode)
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<SubAllowancesCalGroup>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Sub_Allowances_CAlGroup");

                entity.Property(e => e.ItemCode)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.ItemGroup)
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<SubAllowancesCondition>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Sub_Allowances_Conditions");

                entity.Property(e => e.Calculation)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.ItemCode)
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<SubAllowancesGroup>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Sub_Allowances_Group");

                entity.Property(e => e.ItemCode)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.ItemGroup)
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<SubAllowancesLog>(entity =>
            {
                entity.HasKey(e => new { e.LuserId, e.Ldescription, e.LogOn })
                    .HasName("PK_Sub_Allowances_Logs");

                entity.ToTable("Sub_Allowances_Log");

                entity.Property(e => e.LuserId)
                    .HasMaxLength(50)
                    .HasColumnName("LUserId")
                    .IsFixedLength();

                entity.Property(e => e.Ldescription)
                    .HasMaxLength(50)
                    .HasColumnName("LDescription");

                entity.Property(e => e.LogOn)
                    .HasColumnType("datetime")
                    .HasColumnName("Log_on");

                entity.Property(e => e.Ipaddress)
                    .HasMaxLength(50)
                    .HasColumnName("IPaddress");
            });

            modelBuilder.Entity<SubAllowancesOverPayCode>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Sub_Allowances_OverPayCodes");

                entity.Property(e => e.ItemCode)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.OverPayCode)
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<SubAllowancesRank>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Sub_Allowances_Ranks");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CatCode)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.ItemCode)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.RankCode)
                    .HasMaxLength(3)
                    .IsFixedLength();
            });

            modelBuilder.Entity<SubAllowancesRestricted>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Sub_Allowances_Restricted");

                entity.Property(e => e.ItemCode)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Restricted)
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<SubAllowancesSubItem>(entity =>
            {
                entity.HasKey(e => new { e.SubjectId, e.ItemCode });

                entity.ToTable("Sub_Allowances_SubItems");

                entity.Property(e => e.SubjectId).HasColumnName("SubjectID");

                entity.Property(e => e.ItemCode)
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<SubAllowancesSubject>(entity =>
            {
                entity.HasKey(e => e.SubId)
                    .HasName("PK_Sub_All_Subjects");

                entity.ToTable("Sub_Allowances_Subjects");

                entity.Property(e => e.SubId)
                    .ValueGeneratedNever()
                    .HasColumnName("Sub_Id");

                entity.Property(e => e.Subject)
                    .HasMaxLength(35)
                    .IsFixedLength();
            });

            modelBuilder.Entity<SubAllowancesSysCat>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Sub_Allowances_SYS_CAT");

                entity.Property(e => e.CatCode)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.ItemCode)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.SysCode)
                    .HasMaxLength(3)
                    .IsFixedLength();
            });

            modelBuilder.Entity<SubAllowancesTransDetail>(entity =>
            {
                entity.HasKey(e => new { e.TransId, e.ItemCode, e.OfficialNo });

                entity.ToTable("Sub_Allowances_Trans_Details");

                entity.Property(e => e.TransId)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.ItemCode)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.OfficialNo).HasMaxLength(10);

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ArrearsAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ArrearsCode)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.BaseCode)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.CatCode)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.EditedBy)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.EffectDate).HasColumnType("date");

                entity.Property(e => e.ItemCategory)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.OverPayAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.OverPayCode)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Remarks)
                    .HasMaxLength(150)
                    .IsFixedLength();

                entity.Property(e => e.SysCode)
                    .HasMaxLength(3)
                    .IsFixedLength();
            });

            modelBuilder.Entity<SubAllowancesTransDetailsHistory>(entity =>
            {
                entity.HasKey(e => new { e.TransId, e.ItemCode, e.OfficialNo });

                entity.ToTable("Sub_Allowances_Trans_Details_History");

                entity.Property(e => e.TransId)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.ItemCode)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.OfficialNo).HasMaxLength(10);

                entity.Property(e => e.ArrearsAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ArrearsCode)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.BaseCode)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.CatCode)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.EditedBy)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.EffectDate).HasColumnType("date");

                entity.Property(e => e.ItemCategory)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.OverPayAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.OverPayCode)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Remarks)
                    .HasMaxLength(150)
                    .IsFixedLength();

                entity.Property(e => e.SysCode)
                    .HasMaxLength(3)
                    .IsFixedLength();
            });

            modelBuilder.Entity<SubAllowancesTransDetailsHistory1>(entity =>
            {
                entity.HasKey(e => new { e.TransId, e.ItemCode, e.OfficialNo });

                entity.ToTable("Sub_Allowances_Trans_Details_History_1");

                entity.Property(e => e.TransId)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.ItemCode)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.OfficialNo).HasMaxLength(10);

                entity.Property(e => e.BaseCode)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.CatCode)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.EditedBy)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.ItemCategory)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Remarks)
                    .HasMaxLength(150)
                    .IsFixedLength();

                entity.Property(e => e.SysCode)
                    .HasMaxLength(3)
                    .IsFixedLength();
            });

            modelBuilder.Entity<SubAllowancesTransId>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Sub_Allowances_TransId");

                entity.Property(e => e.SubjectId).HasColumnName("SubjectID");
            });

            modelBuilder.Entity<SubAllowancesTransMaster>(entity =>
            {
                entity.HasKey(e => new { e.TransId, e.PayMonth, e.UnitCode, e.BaseCode })
                    .HasName("PK_Allowances_Trans_Master");

                entity.ToTable("Sub_Allowances_Trans_Master");

                entity.Property(e => e.TransId)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.BaseCode)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Path).HasMaxLength(500);

                entity.Property(e => e.Remarks).HasMaxLength(50);

                entity.Property(e => e.Taudit).HasColumnName("TAudit");

                entity.Property(e => e.TauditCatCode)
                    .HasMaxLength(1)
                    .HasColumnName("TAuditCatCode")
                    .IsFixedLength();

                entity.Property(e => e.TauditOfficialNo)
                    .HasMaxLength(10)
                    .HasColumnName("TAuditOfficialNo")
                    .IsFixedLength();

                entity.Property(e => e.TauditStaff).HasColumnName("TAuditStaff");

                entity.Property(e => e.TauditSysCode)
                    .HasMaxLength(3)
                    .HasColumnName("TAuditSysCode")
                    .IsFixedLength();

                entity.Property(e => e.TauditedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("TAuditedOn");

                entity.Property(e => e.Tconfirm).HasColumnName("TConfirm");

                entity.Property(e => e.TconfirmBy)
                    .HasMaxLength(10)
                    .HasColumnName("TConfirmBy")
                    .IsFixedLength();

                entity.Property(e => e.TconfirmCatCode)
                    .HasMaxLength(1)
                    .HasColumnName("TConfirmCatCode")
                    .IsFixedLength();

                entity.Property(e => e.TconfirmOn)
                    .HasColumnType("datetime")
                    .HasColumnName("TConfirmOn");

                entity.Property(e => e.TconfirmSysCode)
                    .HasMaxLength(3)
                    .HasColumnName("TConfirmSysCode")
                    .IsFixedLength();

                entity.Property(e => e.Tforward).HasColumnName("TForward");

                entity.Property(e => e.TforwardBy)
                    .HasMaxLength(10)
                    .HasColumnName("TForwardBy")
                    .IsFixedLength();

                entity.Property(e => e.TforwardCatCode)
                    .HasMaxLength(1)
                    .HasColumnName("TForwardCatCode")
                    .IsFixedLength();

                entity.Property(e => e.TforwardOn)
                    .HasColumnType("datetime")
                    .HasColumnName("TForwardOn");

                entity.Property(e => e.TforwardSysCode)
                    .HasMaxLength(3)
                    .HasColumnName("TForwardSysCode")
                    .IsFixedLength();

                entity.Property(e => e.TheadBy)
                    .HasMaxLength(10)
                    .HasColumnName("THeadBy")
                    .IsFixedLength();

                entity.Property(e => e.TpayHead).HasColumnName("TPayHead");

                entity.Property(e => e.TpayHeadCatCode)
                    .HasMaxLength(1)
                    .HasColumnName("TPayHeadCatCode")
                    .IsFixedLength();

                entity.Property(e => e.TpayHeadOn)
                    .HasColumnType("datetime")
                    .HasColumnName("TPayHeadOn");

                entity.Property(e => e.TpayHeadSysCode)
                    .HasMaxLength(3)
                    .HasColumnName("TPayHeadSysCode")
                    .IsFixedLength();

                entity.Property(e => e.Treject).HasColumnName("TReject");

                entity.Property(e => e.TrejectCatCode)
                    .HasMaxLength(1)
                    .HasColumnName("TRejectCatCode")
                    .IsFixedLength();

                entity.Property(e => e.TrejectOn)
                    .HasColumnType("datetime")
                    .HasColumnName("TRejectOn");

                entity.Property(e => e.TrejectReason)
                    .HasMaxLength(50)
                    .HasColumnName("TRejectReason");

                entity.Property(e => e.TrejectSysCode)
                    .HasMaxLength(3)
                    .HasColumnName("TRejectSysCode")
                    .IsFixedLength();

                entity.Property(e => e.Trejectby)
                    .HasMaxLength(10)
                    .HasColumnName("TRejectby")
                    .IsFixedLength();

                entity.Property(e => e.TsauditCatCode)
                    .HasMaxLength(1)
                    .HasColumnName("TSAuditCatCode")
                    .IsFixedLength();

                entity.Property(e => e.TsauditOfficialNo)
                    .HasMaxLength(10)
                    .HasColumnName("TSAuditOfficialNo")
                    .IsFixedLength();

                entity.Property(e => e.TsauditSysCode)
                    .HasMaxLength(3)
                    .HasColumnName("TSAuditSysCode")
                    .IsFixedLength();

                entity.Property(e => e.TsauditedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("TSAuditedOn");

                entity.Property(e => e.Tsave).HasColumnName("TSave");

                entity.Property(e => e.TsaveBy)
                    .HasMaxLength(10)
                    .HasColumnName("TSaveBy")
                    .IsFixedLength();

                entity.Property(e => e.TsaveCatCode)
                    .HasMaxLength(1)
                    .HasColumnName("TSaveCatCode")
                    .IsFixedLength();

                entity.Property(e => e.TsaveOn)
                    .HasColumnType("datetime")
                    .HasColumnName("TSaveOn");

                entity.Property(e => e.TsaveSysCode)
                    .HasMaxLength(3)
                    .HasColumnName("TSaveSysCode")
                    .IsFixedLength();

                entity.Property(e => e.Tsso).HasColumnName("TSSO");

                entity.Property(e => e.Tssoby)
                    .HasMaxLength(10)
                    .HasColumnName("TSSOBy")
                    .IsFixedLength();

                entity.Property(e => e.TssocatCode)
                    .HasMaxLength(1)
                    .HasColumnName("TSSOCatCode")
                    .IsFixedLength();

                entity.Property(e => e.Tssoon)
                    .HasColumnType("datetime")
                    .HasColumnName("TSSOOn");

                entity.Property(e => e.TssosysCode)
                    .HasMaxLength(3)
                    .HasColumnName("TSSOSysCode")
                    .IsFixedLength();

                entity.Property(e => e.TsubClarkBy)
                    .HasMaxLength(10)
                    .HasColumnName("TSubClarkBy")
                    .IsFixedLength();

                entity.Property(e => e.TsubClarkCatCode)
                    .HasMaxLength(1)
                    .HasColumnName("TSubClarkCatCode")
                    .IsFixedLength();

                entity.Property(e => e.TsubClarkOn)
                    .HasColumnType("datetime")
                    .HasColumnName("TSubClarkOn");

                entity.Property(e => e.TsubClarkSysCode)
                    .HasMaxLength(3)
                    .HasColumnName("TSubClarkSysCode")
                    .IsFixedLength();

                entity.Property(e => e.Tsubject).HasColumnName("TSubject");
            });

            modelBuilder.Entity<SubAttachment>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Sub_Attachments");

                entity.Property(e => e.Tattachment)
                    .HasMaxLength(25)
                    .HasColumnName("TAttachment")
                    .IsFixedLength();

                entity.Property(e => e.Torder).HasColumnName("TOrder");

                entity.Property(e => e.Tpath).HasColumnName("TPath");

                entity.Property(e => e.TransId)
                    .HasMaxLength(10)
                    .HasColumnName("Trans_Id")
                    .IsFixedLength();
            });

            modelBuilder.Entity<SubBaseChange>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Sub_Base_Change");

                entity.Property(e => e.CatCode)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.HrmsbaseCode)
                    .HasMaxLength(10)
                    .HasColumnName("HRMSBaseCode")
                    .IsFixedLength();

                entity.Property(e => e.OfficialNo)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.PayBaseCode)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.SysCode)
                    .HasMaxLength(3)
                    .IsFixedLength();
            });

            modelBuilder.Entity<SubBaseMatching>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Sub_BaseMatching");

                entity.Property(e => e.BaseCode)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.PayBaseCode)
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<SubExtraDutyDetail>(entity =>
            {
                entity.HasKey(e => new { e.TransId, e.EffectDt, e.Sfrom });

                entity.ToTable("Sub_ExtraDutyDetails");

                entity.Property(e => e.TransId)
                    .HasMaxLength(10)
                    .HasColumnName("TransID")
                    .IsFixedLength();

                entity.Property(e => e.EffectDt).HasColumnType("date");

                entity.Property(e => e.Sfrom)
                    .HasMaxLength(4)
                    .HasColumnName("SFrom")
                    .IsFixedLength();

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Details).HasMaxLength(250);

                entity.Property(e => e.Remarks).HasMaxLength(250);

                entity.Property(e => e.Sto)
                    .HasMaxLength(4)
                    .HasColumnName("STo")
                    .IsFixedLength();
            });

            modelBuilder.Entity<SubExtraDutyDetailsHistory>(entity =>
            {
                entity.HasKey(e => new { e.TransId, e.EffectDt, e.Sfrom });

                entity.ToTable("Sub_ExtraDutyDetails_History");

                entity.Property(e => e.TransId)
                    .HasMaxLength(10)
                    .HasColumnName("TransID")
                    .IsFixedLength();

                entity.Property(e => e.EffectDt).HasColumnType("date");

                entity.Property(e => e.Sfrom)
                    .HasMaxLength(4)
                    .HasColumnName("SFrom")
                    .IsFixedLength();

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Details).HasMaxLength(250);

                entity.Property(e => e.Minutes).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Remarks).HasMaxLength(250);

                entity.Property(e => e.Sto)
                    .HasMaxLength(4)
                    .HasColumnName("STo")
                    .IsFixedLength();
            });

            modelBuilder.Entity<SubExtraDutyMaster>(entity =>
            {
                entity.HasKey(e => new { e.TransId, e.PayMonth, e.BaseCode });

                entity.ToTable("Sub_ExtraDuty_Master");

                entity.Property(e => e.TransId)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.BaseCode)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ItemCode)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Remarks).HasMaxLength(150);

                entity.Property(e => e.Tconfirm).HasColumnName("TConfirm");

                entity.Property(e => e.TconfirmBy)
                    .HasMaxLength(10)
                    .HasColumnName("TConfirmBy")
                    .IsFixedLength();

                entity.Property(e => e.TconfirmCatCode)
                    .HasMaxLength(1)
                    .HasColumnName("TConfirmCatCode")
                    .IsFixedLength();

                entity.Property(e => e.TconfirmOn)
                    .HasColumnType("datetime")
                    .HasColumnName("TConfirmOn");

                entity.Property(e => e.TconfirmReject).HasColumnName("TConfirmReject");

                entity.Property(e => e.TconfirmSysCode)
                    .HasMaxLength(3)
                    .HasColumnName("TConfirmSysCode")
                    .IsFixedLength();

                entity.Property(e => e.Tforward).HasColumnName("TForward");

                entity.Property(e => e.TforwardBy)
                    .HasMaxLength(25)
                    .HasColumnName("TForwardBy")
                    .IsFixedLength();

                entity.Property(e => e.TforwardCatCode)
                    .HasMaxLength(1)
                    .HasColumnName("TForwardCatCode")
                    .IsFixedLength();

                entity.Property(e => e.TforwardOn)
                    .HasColumnType("datetime")
                    .HasColumnName("TForwardOn");

                entity.Property(e => e.TforwardSysCode)
                    .HasMaxLength(3)
                    .HasColumnName("TForwardSysCode")
                    .IsFixedLength();

                entity.Property(e => e.Thead)
                    .HasMaxLength(10)
                    .HasColumnName("THead")
                    .IsFixedLength();

                entity.Property(e => e.TpayHead).HasColumnName("TPayHead");

                entity.Property(e => e.TpayHeadCatCode)
                    .HasMaxLength(1)
                    .HasColumnName("TPayHeadCatCode")
                    .IsFixedLength();

                entity.Property(e => e.TpayHeadOn)
                    .HasColumnType("datetime")
                    .HasColumnName("TPayHeadOn");

                entity.Property(e => e.TpayHeadSysCode)
                    .HasMaxLength(3)
                    .HasColumnName("TPayHeadSysCode")
                    .IsFixedLength();

                entity.Property(e => e.Treject).HasColumnName("TReject");

                entity.Property(e => e.TrejectCatCode)
                    .HasMaxLength(1)
                    .HasColumnName("TRejectCatCode")
                    .IsFixedLength();

                entity.Property(e => e.TrejectOn)
                    .HasColumnType("datetime")
                    .HasColumnName("TRejectOn");

                entity.Property(e => e.TrejectReason)
                    .HasMaxLength(50)
                    .HasColumnName("TRejectReason");

                entity.Property(e => e.TrejectSysCode)
                    .HasMaxLength(3)
                    .HasColumnName("TRejectSysCode")
                    .IsFixedLength();

                entity.Property(e => e.Trejectby)
                    .HasMaxLength(10)
                    .HasColumnName("TRejectby")
                    .IsFixedLength();

                entity.Property(e => e.Tsave).HasColumnName("TSave");

                entity.Property(e => e.TsaveBy)
                    .HasMaxLength(10)
                    .HasColumnName("TSaveBy")
                    .IsFixedLength();

                entity.Property(e => e.TsaveCatCode)
                    .HasMaxLength(1)
                    .HasColumnName("TSaveCatCode")
                    .IsFixedLength();

                entity.Property(e => e.TsaveOn)
                    .HasColumnType("datetime")
                    .HasColumnName("TSaveOn");

                entity.Property(e => e.TsaveSysCode)
                    .HasMaxLength(3)
                    .HasColumnName("TSaveSysCode")
                    .IsFixedLength();

                entity.Property(e => e.TsubClark)
                    .HasMaxLength(10)
                    .HasColumnName("TSubClark")
                    .IsFixedLength();

                entity.Property(e => e.TsubClarkOn)
                    .HasColumnType("datetime")
                    .HasColumnName("TSubClarkOn");

                entity.Property(e => e.TsubClarkSysCode)
                    .HasMaxLength(3)
                    .HasColumnName("TSubClarkSysCode")
                    .IsFixedLength();

                entity.Property(e => e.TsubClarlCatCode)
                    .HasMaxLength(1)
                    .HasColumnName("TSubClarlCatCode")
                    .IsFixedLength();

                entity.Property(e => e.Tsubject).HasColumnName("TSubject");
            });

            modelBuilder.Entity<SubFinalPay327Head>(entity =>
            {
                entity.HasKey(e => e.TransId)
                    .HasName("PK_Sub_FinalPay_327_Trans");

                entity.ToTable("Sub_Final_Pay_327_Head");

                entity.Property(e => e.TransId)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.AuditOfficer).HasDefaultValueSql("((0))");

                entity.Property(e => e.AuditStaff).HasDefaultValueSql("((0))");

                entity.Property(e => e.BaseCode)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.CurrentPayMonth)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Ddnpay)
                    .HasColumnName("DDNPay")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DeductAmount)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FinalPayAction).HasDefaultValueSql("((0))");

                entity.Property(e => e.Reject).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sso)
                    .HasColumnName("SSO")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Subject).HasDefaultValueSql("((0))");

                entity.Property(e => e.Tconfirm)
                    .HasColumnName("TConfirm")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Tforward)
                    .HasColumnName("TForward")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Total327)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Tsave)
                    .HasColumnName("TSave")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<SubFinalPay327List>(entity =>
            {
                entity.HasKey(e => new { e.TransId, e.OrderId, e.PayMonth });

                entity.ToTable("Sub_Final_Pay_327_List");

                entity.Property(e => e.TransId)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ItemCat)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.ItemCode)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e._596)
                    .HasColumnName("596")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e._598)
                    .HasColumnName("598")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e._600)
                    .HasColumnName("600")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e._605606)
                    .HasColumnName("605/606")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e._605a606a)
                    .HasColumnName("605A/606A")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e._610611)
                    .HasColumnName("610/611")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e._612613)
                    .HasColumnName("612/613")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e._615614)
                    .HasColumnName("615/614")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e._619)
                    .HasColumnName("619")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e._630)
                    .HasColumnName("630")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e._686687)
                    .HasColumnName("686/687")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e._688689)
                    .HasColumnName("688/689")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e._690)
                    .HasColumnName("690")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<SubFinalPayDetail>(entity =>
            {
                entity.HasKey(e => new { e.TransId, e.UnitId, e.Ulevel });

                entity.ToTable("Sub_Final_Pay_Details");

                entity.Property(e => e.TransId).HasColumnName("Trans_ID");

                entity.Property(e => e.UnitId).HasColumnName("Unit_ID");

                entity.Property(e => e.Ulevel).HasColumnName("ULevel");

                entity.Property(e => e.AuthorizedOfficer).HasDefaultValueSql("((0))");

                entity.Property(e => e.Reject).HasDefaultValueSql("((0))");

                entity.Property(e => e.RejectAuth).HasDefaultValueSql("((0))");

                entity.Property(e => e.RejectBy)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RejectReason)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.RejectSec).HasDefaultValueSql("((0))");

                entity.Property(e => e.Secreatry).HasDefaultValueSql("((0))");

                entity.Property(e => e.SubjectClerk).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<SubFinalPayDischargeType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Sub_Final_Pay_Discharge_Types");

                entity.Property(e => e.Des).HasMaxLength(100);

                entity.Property(e => e.Type)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<SubFinalPayHeadDetail>(entity =>
            {
                entity.HasKey(e => new { e.TransId, e.SysCode, e.CatCode, e.OfficialNo });

                entity.ToTable("Sub_Final_Pay_Head_Details");

                entity.Property(e => e.TransId).HasColumnName("TransID");

                entity.Property(e => e.SysCode)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.CatCode)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OfficialNo)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.ActionComplete).HasDefaultValueSql("((0))");

                entity.Property(e => e.AuditSsailor).HasColumnName("AuditSSailor");

                entity.Property(e => e.BaseCode)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.CheckPayment).HasDefaultValueSql("((0))");

                entity.Property(e => e.ChequeDt).HasColumnType("date");

                entity.Property(e => e.ChequeNo)
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.Ddnpay).HasColumnName("DDNPay");

                entity.Property(e => e.DischargeDt).HasColumnType("date");

                entity.Property(e => e.NgReference)
                    .HasMaxLength(30)
                    .HasColumnName("NG_Reference")
                    .IsFixedLength();

                entity.Property(e => e.PForm).HasColumnName("P_Form");

                entity.Property(e => e.PFormPath)
                    .HasMaxLength(200)
                    .HasColumnName("P_Form_Path");

                entity.Property(e => e.PaySsailor).HasColumnName("PaySSailor");

                entity.Property(e => e.PaymentDt).HasColumnType("date");

                entity.Property(e => e.PenSsailor).HasColumnName("PenSSailor");

                entity.Property(e => e.RejectedBy)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.RejectedOn).HasColumnType("datetime");

                entity.Property(e => e.RejectedReason).HasMaxLength(150);

                entity.Property(e => e.Remarks)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ssopay).HasColumnName("SSOPay");

                entity.Property(e => e.Type)
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.VoucherDes)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.VoucherNo)
                    .HasMaxLength(20)
                    .IsFixedLength();
            });

            modelBuilder.Entity<SubFinalPayItem>(entity =>
            {
                entity.HasKey(e => new { e.ItemCode, e.Unit });

                entity.ToTable("Sub_Final_Pay_Items");

                entity.Property(e => e.ItemCode)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ItemCat)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.ItemDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SubFinalPayItemList>(entity =>
            {
                entity.HasKey(e => new { e.TransId, e.UnitId, e.ItemCode });

                entity.ToTable("Sub_Final_Pay_Item_List");

                entity.Property(e => e.TransId).HasColumnName("Trans_ID");

                entity.Property(e => e.UnitId).HasColumnName("Unit_ID");

                entity.Property(e => e.ItemCode)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Base)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.FromGratuity).HasDefaultValueSql("((0))");

                entity.Property(e => e.Remarks).HasMaxLength(50);
            });

            modelBuilder.Entity<SubFinalPayLogDetail>(entity =>
            {
                entity.HasKey(e => new { e.TransId, e.UnitId, e.UserId, e.Logtime })
                    .HasName("PK_Sub_FinalPay_Log_Details");

                entity.ToTable("Sub_Final_Pay_Log_Details");

                entity.Property(e => e.TransId).HasColumnName("Trans_ID");

                entity.Property(e => e.UnitId).HasColumnName("Unit_ID");

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UserID")
                    .IsFixedLength();

                entity.Property(e => e.Logtime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .HasColumnName("IP")
                    .IsFixedLength();

                entity.Property(e => e.LogDetails)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SubGradeDetail>(entity =>
            {
                entity.HasKey(e => new { e.SysCode, e.CatCode, e.OfficialNo, e.Grade });

                entity.ToTable("Sub_Grade_Details");

                entity.Property(e => e.SysCode)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.CatCode)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.OfficialNo)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Grade)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.EffectDt).HasColumnType("date");
            });

            modelBuilder.Entity<SubGradeRate>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Sub_Grade_Rates");

                entity.Property(e => e.Grade)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Rate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Type)
                    .HasMaxLength(1)
                    .IsFixedLength();
            });

            modelBuilder.Entity<SubHoliday>(entity =>
            {
                entity.HasKey(e => e.Holiday);

                entity.ToTable("Sub_Holidays");

                entity.Property(e => e.Holiday).HasColumnType("date");
            });

            modelBuilder.Entity<SubIncentiveForm>(entity =>
            {
                entity.HasKey(e => new { e.Iid, e.SysCode, e.CatCode, e.OfficialNo, e.ApplliedIncentive, e.EffectDate });

                entity.ToTable("Sub_Incentive_Forms");

                entity.Property(e => e.Iid)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("IID");

                entity.Property(e => e.SysCode)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.CatCode)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.OfficialNo)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.ApplliedIncentive)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.EffectDate).HasColumnType("date");

                entity.Property(e => e.BaseCode)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.CurrentIncentive).HasMaxLength(50);

                entity.Property(e => e.DateofEnlistment).HasColumnType("date");

                entity.Property(e => e.DcatCode)
                    .HasMaxLength(1)
                    .HasColumnName("DCatCode")
                    .IsFixedLength();

                entity.Property(e => e.DofficialNo)
                    .HasMaxLength(10)
                    .HasColumnName("DOfficialNo")
                    .IsFixedLength();

                entity.Property(e => e.DsysCode)
                    .HasMaxLength(3)
                    .HasColumnName("DSysCode")
                    .IsFixedLength();

                entity.Property(e => e.Forwardon).HasColumnType("datetime");

                entity.Property(e => e.NavalService).HasMaxLength(150);

                entity.Property(e => e.Remarks)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.Saveon).HasColumnType("datetime");

                entity.Property(e => e.TransId).HasColumnName("TransID");
            });

            modelBuilder.Entity<SubIncentiveFormsReceiver>(entity =>
            {
                entity.HasKey(e => new { e.Iid, e.Unit });

                entity.ToTable("Sub_Incentive_Forms_Receivers");

                entity.Property(e => e.Iid)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("IID");

                entity.Property(e => e.Aaction).HasColumnName("AAction");

                entity.Property(e => e.AcatCode)
                    .HasMaxLength(1)
                    .HasColumnName("ACatCode")
                    .IsFixedLength();

                entity.Property(e => e.AofficialNo)
                    .HasMaxLength(10)
                    .HasColumnName("AOfficialNo")
                    .IsFixedLength();

                entity.Property(e => e.Aon)
                    .HasColumnType("datetime")
                    .HasColumnName("AOn");

                entity.Property(e => e.AsysCode)
                    .HasMaxLength(3)
                    .HasColumnName("ASysCode")
                    .IsFixedLength();

                entity.Property(e => e.BaseCode)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Forder).HasColumnName("FOrder");

                entity.Property(e => e.RejectedOn).HasColumnType("datetime");

                entity.Property(e => e.Remarks).HasMaxLength(50);

                entity.Property(e => e.Saction).HasColumnName("SAction");

                entity.Property(e => e.ScatCode)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SCatCode")
                    .IsFixedLength();

                entity.Property(e => e.SecCatCode)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SecOfficialNo)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.SecOn).HasColumnType("datetime");

                entity.Property(e => e.SecSysCode)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SofficialNo)
                    .HasMaxLength(10)
                    .HasColumnName("SOfficialNo")
                    .IsFixedLength();

                entity.Property(e => e.Son)
                    .HasColumnType("datetime")
                    .HasColumnName("SOn");

                entity.Property(e => e.SsysCode)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("SSysCode")
                    .IsFixedLength();
            });

            modelBuilder.Entity<SubLog>(entity =>
            {
                entity.HasKey(e => new { e.LuserId, e.Ldescription, e.LogOn });

                entity.ToTable("Sub_Logs");

                entity.Property(e => e.LuserId)
                    .HasMaxLength(50)
                    .HasColumnName("LUserId")
                    .IsFixedLength();

                entity.Property(e => e.Ldescription)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("LDescription");

                entity.Property(e => e.LogOn)
                    .HasColumnType("datetime")
                    .HasColumnName("Log_on");

                entity.Property(e => e.Ipaddress)
                    .HasMaxLength(50)
                    .HasColumnName("IPaddress");
            });

            modelBuilder.Entity<SubMaternityTransDetail>(entity =>
            {
                entity.HasKey(e => new { e.TransId, e.ItemCode, e.OfficialNo });

                entity.ToTable("Sub_Maternity_Trans_Details");

                entity.Property(e => e.TransId)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.ItemCode)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.OfficialNo).HasMaxLength(10);

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BaseCode)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.CatCode)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.EditedBy)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.EffectDate).HasColumnType("date");

                entity.Property(e => e.ItemCategory)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Remarks)
                    .HasMaxLength(150)
                    .IsFixedLength();

                entity.Property(e => e.SysCode)
                    .HasMaxLength(3)
                    .IsFixedLength();
            });

            modelBuilder.Entity<SubMaternityTransMaster>(entity =>
            {
                entity.HasKey(e => new { e.TransId, e.PayMonth, e.UnitCode, e.BaseCode, e.LeaveType });

                entity.ToTable("Sub_Maternity_Trans_Master");

                entity.Property(e => e.TransId)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.BaseCode)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.LeaveType)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.CatCode)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.FromDt).HasColumnType("date");

                entity.Property(e => e.Nofleaves).HasColumnName("NOFLeaves");

                entity.Property(e => e.OfficialNo)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Path).HasMaxLength(500);

                entity.Property(e => e.Remarks).HasMaxLength(50);

                entity.Property(e => e.SysCode)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Taudit).HasColumnName("TAudit");

                entity.Property(e => e.TauditCatCode)
                    .HasMaxLength(1)
                    .HasColumnName("TAuditCatCode")
                    .IsFixedLength();

                entity.Property(e => e.TauditOfficialNo)
                    .HasMaxLength(10)
                    .HasColumnName("TAuditOfficialNo")
                    .IsFixedLength();

                entity.Property(e => e.TauditStaff).HasColumnName("TAuditStaff");

                entity.Property(e => e.TauditSysCode)
                    .HasMaxLength(3)
                    .HasColumnName("TAuditSysCode")
                    .IsFixedLength();

                entity.Property(e => e.TauditedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("TAuditedOn");

                entity.Property(e => e.Tconfirm).HasColumnName("TConfirm");

                entity.Property(e => e.TconfirmBy)
                    .HasMaxLength(10)
                    .HasColumnName("TConfirmBy")
                    .IsFixedLength();

                entity.Property(e => e.TconfirmCatCode)
                    .HasMaxLength(1)
                    .HasColumnName("TConfirmCatCode")
                    .IsFixedLength();

                entity.Property(e => e.TconfirmOn)
                    .HasColumnType("datetime")
                    .HasColumnName("TConfirmOn");

                entity.Property(e => e.TconfirmSysCode)
                    .HasMaxLength(3)
                    .HasColumnName("TConfirmSysCode")
                    .IsFixedLength();

                entity.Property(e => e.Tforward).HasColumnName("TForward");

                entity.Property(e => e.TforwardBy)
                    .HasMaxLength(10)
                    .HasColumnName("TForwardBy")
                    .IsFixedLength();

                entity.Property(e => e.TforwardCatCode)
                    .HasMaxLength(1)
                    .HasColumnName("TForwardCatCode")
                    .IsFixedLength();

                entity.Property(e => e.TforwardOn)
                    .HasColumnType("datetime")
                    .HasColumnName("TForwardOn");

                entity.Property(e => e.TforwardSysCode)
                    .HasMaxLength(3)
                    .HasColumnName("TForwardSysCode")
                    .IsFixedLength();

                entity.Property(e => e.TheadBy)
                    .HasMaxLength(10)
                    .HasColumnName("THeadBy")
                    .IsFixedLength();

                entity.Property(e => e.ToDt).HasColumnType("date");

                entity.Property(e => e.TpayHead).HasColumnName("TPayHead");

                entity.Property(e => e.TpayHeadCatCode)
                    .HasMaxLength(1)
                    .HasColumnName("TPayHeadCatCode")
                    .IsFixedLength();

                entity.Property(e => e.TpayHeadOn)
                    .HasColumnType("datetime")
                    .HasColumnName("TPayHeadOn");

                entity.Property(e => e.TpayHeadSysCode)
                    .HasMaxLength(3)
                    .HasColumnName("TPayHeadSysCode")
                    .IsFixedLength();

                entity.Property(e => e.Treject).HasColumnName("TReject");

                entity.Property(e => e.TrejectCatCode)
                    .HasMaxLength(1)
                    .HasColumnName("TRejectCatCode")
                    .IsFixedLength();

                entity.Property(e => e.TrejectOn)
                    .HasColumnType("datetime")
                    .HasColumnName("TRejectOn");

                entity.Property(e => e.TrejectReason)
                    .HasMaxLength(50)
                    .HasColumnName("TRejectReason");

                entity.Property(e => e.TrejectSysCode)
                    .HasMaxLength(3)
                    .HasColumnName("TRejectSysCode")
                    .IsFixedLength();

                entity.Property(e => e.Trejectby)
                    .HasMaxLength(10)
                    .HasColumnName("TRejectby")
                    .IsFixedLength();

                entity.Property(e => e.TsauditCatCode)
                    .HasMaxLength(1)
                    .HasColumnName("TSAuditCatCode")
                    .IsFixedLength();

                entity.Property(e => e.TsauditOfficialNo)
                    .HasMaxLength(10)
                    .HasColumnName("TSAuditOfficialNo")
                    .IsFixedLength();

                entity.Property(e => e.TsauditSysCode)
                    .HasMaxLength(3)
                    .HasColumnName("TSAuditSysCode")
                    .IsFixedLength();

                entity.Property(e => e.TsauditedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("TSAuditedOn");

                entity.Property(e => e.Tsave).HasColumnName("TSave");

                entity.Property(e => e.TsaveBy)
                    .HasMaxLength(10)
                    .HasColumnName("TSaveBy")
                    .IsFixedLength();

                entity.Property(e => e.TsaveCatCode)
                    .HasMaxLength(1)
                    .HasColumnName("TSaveCatCode")
                    .IsFixedLength();

                entity.Property(e => e.TsaveOn)
                    .HasColumnType("datetime")
                    .HasColumnName("TSaveOn");

                entity.Property(e => e.TsaveSysCode)
                    .HasMaxLength(3)
                    .HasColumnName("TSaveSysCode")
                    .IsFixedLength();

                entity.Property(e => e.Tsso).HasColumnName("TSSO");

                entity.Property(e => e.Tssoby)
                    .HasMaxLength(10)
                    .HasColumnName("TSSOBy")
                    .IsFixedLength();

                entity.Property(e => e.TssocatCode)
                    .HasMaxLength(1)
                    .HasColumnName("TSSOCatCode")
                    .IsFixedLength();

                entity.Property(e => e.Tssoon)
                    .HasColumnType("datetime")
                    .HasColumnName("TSSOOn");

                entity.Property(e => e.TssosysCode)
                    .HasMaxLength(3)
                    .HasColumnName("TSSOSysCode")
                    .IsFixedLength();

                entity.Property(e => e.TsubClarkBy)
                    .HasMaxLength(10)
                    .HasColumnName("TSubClarkBy")
                    .IsFixedLength();

                entity.Property(e => e.TsubClarkCatCode)
                    .HasMaxLength(1)
                    .HasColumnName("TSubClarkCatCode")
                    .IsFixedLength();

                entity.Property(e => e.TsubClarkOn)
                    .HasColumnType("datetime")
                    .HasColumnName("TSubClarkOn");

                entity.Property(e => e.TsubClarkSysCode)
                    .HasMaxLength(3)
                    .HasColumnName("TSubClarkSysCode")
                    .IsFixedLength();

                entity.Property(e => e.Tsubject).HasColumnName("TSubject");
            });

            modelBuilder.Entity<SubRole>(entity =>
            {
                entity.HasKey(e => new { e.SysCode, e.CatCode, e.OfficialNo });

                entity.ToTable("Sub_Role");

                entity.Property(e => e.SysCode)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.CatCode)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.OfficialNo)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.ActiveOn).HasColumnType("datetime");

                entity.Property(e => e.Role).HasMaxLength(50);
            });

            modelBuilder.Entity<SubRoleAllowance>(entity =>
            {
                entity.HasKey(e => new { e.SysCode, e.CatCode, e.OfficialNo, e.ActiveOn });

                entity.ToTable("Sub_Role_Allowances");

                entity.Property(e => e.SysCode)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.CatCode)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.OfficialNo)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.ActiveOn).HasColumnType("datetime");

                entity.Property(e => e.BaseCode)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.DeactiveOn).HasColumnType("datetime");

                entity.Property(e => e.Role).HasMaxLength(50);
            });

            modelBuilder.Entity<SubRoleTypeAllowance>(entity =>
            {
                entity.HasKey(e => new { e.RoleGroup, e.RoleOrder });

                entity.ToTable("Sub_Role_Type_Allowances");

                entity.Property(e => e.Role).HasMaxLength(50);
            });

            modelBuilder.Entity<SubSubItem>(entity =>
            {
                entity.HasKey(e => new { e.SubjectId, e.ItemCode, e.BaseCode });

                entity.ToTable("Sub_SubItems");

                entity.Property(e => e.SubjectId).HasColumnName("SubjectID");

                entity.Property(e => e.ItemCode)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.BaseCode)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.LogId)
                    .HasMaxLength(50)
                    .HasColumnName("Log_Id");
            });

            modelBuilder.Entity<SubSubject>(entity =>
            {
                entity.HasKey(e => e.SubId);

                entity.ToTable("Sub_Subjects");

                entity.Property(e => e.SubId)
                    .ValueGeneratedNever()
                    .HasColumnName("Sub_Id");

                entity.Property(e => e.Subject)
                    .HasMaxLength(35)
                    .IsFixedLength();
            });

            modelBuilder.Entity<SubTransDetail>(entity =>
            {
                entity.HasKey(e => new { e.TransId, e.PayMonth, e.SubjectCode, e.BaseCode });

                entity.ToTable("Sub_Trans_Details");

                entity.Property(e => e.TransId)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.BaseCode)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Remarks).HasMaxLength(50);

                entity.Property(e => e.Tconfirm).HasColumnName("TConfirm");

                entity.Property(e => e.TconfirmBy)
                    .HasMaxLength(10)
                    .HasColumnName("TConfirmBy")
                    .IsFixedLength();

                entity.Property(e => e.TconfirmCatCode)
                    .HasMaxLength(1)
                    .HasColumnName("TConfirmCatCode")
                    .IsFixedLength();

                entity.Property(e => e.TconfirmOn)
                    .HasColumnType("datetime")
                    .HasColumnName("TConfirmOn");

                entity.Property(e => e.TconfirmSysCode)
                    .HasMaxLength(3)
                    .HasColumnName("TConfirmSysCode")
                    .IsFixedLength();

                entity.Property(e => e.Tforward).HasColumnName("TForward");

                entity.Property(e => e.TforwardBy)
                    .HasMaxLength(25)
                    .HasColumnName("TForwardBy")
                    .IsFixedLength();

                entity.Property(e => e.TforwardCatCode)
                    .HasMaxLength(1)
                    .HasColumnName("TForwardCatCode")
                    .IsFixedLength();

                entity.Property(e => e.TforwardOn)
                    .HasColumnType("datetime")
                    .HasColumnName("TForwardOn");

                entity.Property(e => e.TforwardSysCode)
                    .HasMaxLength(3)
                    .HasColumnName("TForwardSysCode")
                    .IsFixedLength();

                entity.Property(e => e.Thead)
                    .HasMaxLength(10)
                    .HasColumnName("THead")
                    .IsFixedLength();

                entity.Property(e => e.TpayHead).HasColumnName("TPayHead");

                entity.Property(e => e.TpayHeadCatCode)
                    .HasMaxLength(1)
                    .HasColumnName("TPayHeadCatCode")
                    .IsFixedLength();

                entity.Property(e => e.TpayHeadOn)
                    .HasColumnType("datetime")
                    .HasColumnName("TPayHeadOn");

                entity.Property(e => e.TpayHeadSysCode)
                    .HasMaxLength(3)
                    .HasColumnName("TPayHeadSysCode")
                    .IsFixedLength();

                entity.Property(e => e.Treject).HasColumnName("TReject");

                entity.Property(e => e.TrejectCatCode)
                    .HasMaxLength(1)
                    .HasColumnName("TRejectCatCode")
                    .IsFixedLength();

                entity.Property(e => e.TrejectOn)
                    .HasColumnType("datetime")
                    .HasColumnName("TRejectOn");

                entity.Property(e => e.TrejectReason)
                    .HasMaxLength(50)
                    .HasColumnName("TRejectReason");

                entity.Property(e => e.TrejectSysCode)
                    .HasMaxLength(3)
                    .HasColumnName("TRejectSysCode")
                    .IsFixedLength();

                entity.Property(e => e.Trejectby)
                    .HasMaxLength(10)
                    .HasColumnName("TRejectby")
                    .IsFixedLength();

                entity.Property(e => e.Tsave).HasColumnName("TSave");

                entity.Property(e => e.TsaveBy)
                    .HasMaxLength(10)
                    .HasColumnName("TSaveBy")
                    .IsFixedLength();

                entity.Property(e => e.TsaveCatCode)
                    .HasMaxLength(1)
                    .HasColumnName("TSaveCatCode")
                    .IsFixedLength();

                entity.Property(e => e.TsaveOn)
                    .HasColumnType("datetime")
                    .HasColumnName("TSaveOn");

                entity.Property(e => e.TsaveSysCode)
                    .HasMaxLength(3)
                    .HasColumnName("TSaveSysCode")
                    .IsFixedLength();

                entity.Property(e => e.TsubClark)
                    .HasMaxLength(10)
                    .HasColumnName("TSubClark")
                    .IsFixedLength();

                entity.Property(e => e.TsubClarkOn)
                    .HasColumnType("datetime")
                    .HasColumnName("TSubClarkOn");

                entity.Property(e => e.TsubClarkSysCode)
                    .HasMaxLength(3)
                    .HasColumnName("TSubClarkSysCode")
                    .IsFixedLength();

                entity.Property(e => e.TsubClarlCatCode)
                    .HasMaxLength(1)
                    .HasColumnName("TSubClarlCatCode")
                    .IsFixedLength();

                entity.Property(e => e.Tsubject).HasColumnName("TSubject");
            });

            modelBuilder.Entity<SubTransId>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Sub_TransId");

                entity.Property(e => e.SubjectId).HasColumnName("SubjectID");
            });

            modelBuilder.Entity<SubTransaction>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Sub_Transaction");

                entity.HasIndex(e => e.TransId, "NonClusteredIndex-20220106-152019");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BaseCode)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.CatCode)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.ItemCategory)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.ItemCode)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.OfficialNo)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.PrcoessAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Remarks).HasMaxLength(150);

                entity.Property(e => e.SysCode)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.TransId).HasMaxLength(10);
            });

            modelBuilder.Entity<SubTransactionFilePathD>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Sub_TransactionFile_Path_D");

                entity.Property(e => e.Path).HasMaxLength(300);

                entity.Property(e => e.TransId)
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<SubTransactionHistory>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Sub_Transaction_History");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BaseCode)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.CatCode)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.ItemCategory)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.ItemCode)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.OfficialNo)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.PrcoessAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Remarks).HasMaxLength(150);

                entity.Property(e => e.SysCode)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.TransId).HasMaxLength(10);
            });

            modelBuilder.Entity<SubUnitsD>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Sub_Units_D");

                entity.Property(e => e.UnitCode)
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.UnitName).HasMaxLength(150);
            });

            modelBuilder.Entity<SubUnitsDetailsAllowance>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Sub_Units_Details_Allowances");

                entity.Property(e => e.AllowanceCode)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Unit)
                    .HasMaxLength(20)
                    .IsFixedLength();
            });

            modelBuilder.Entity<SystemFreeze>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SystemFreeze");

                entity.Property(e => e.CatCode)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.OfficialNo)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.SysCode)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.UpdateOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<TempAllowanceTran>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BaseCode)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.CatCode)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.ItemCode)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.OfficialNo)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.SysCode)
                    .HasMaxLength(3)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TempAllowanceTransaction>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TempAllowanceTransaction");

                entity.Property(e => e.CatCode)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.EffectDt).HasColumnType("date");

                entity.Property(e => e.OfficialNo)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.SysCode)
                    .HasMaxLength(3)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TempTransaction>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TempTransaction");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BaseCode)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.CatCode)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.ItemCode)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.OfficialNo)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.SysCode)
                    .HasMaxLength(3)
                    .IsFixedLength();
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("users");

                entity.HasIndex(e => e.Email, "users_email_unique")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at");

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .HasColumnName("email");

                entity.Property(e => e.EmailVerifiedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("email_verified_at");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.Password)
                    .HasMaxLength(255)
                    .HasColumnName("password");

                entity.Property(e => e.RememberToken)
                    .HasMaxLength(100)
                    .HasColumnName("remember_token");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<View1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_1");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BaseCode)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.CatCode)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Expr1).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ItemCategory)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.ItemCode)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.OfficialNo)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.PrcoessAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Remarks).HasMaxLength(150);

                entity.Property(e => e.SysCode)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.TpayHead).HasColumnName("TPayHead");

                entity.Property(e => e.TransId).HasMaxLength(10);

                entity.Property(e => e.Tsubject).HasColumnName("TSubject");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
