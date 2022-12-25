using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;


namespace FinaPay.PayModels
{
    public partial class Payroll_SLNavyContext : DbContext
    {
        public Payroll_SLNavyContext()
        {
        }

        public Payroll_SLNavyContext(DbContextOptions<Payroll_SLNavyContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AtestBank> AtestBanks { get; set; } = null!;
        public virtual DbSet<GrtVwAllowanceSetup> GrtVwAllowanceSetups { get; set; } = null!;
        public virtual DbSet<GrtVwRptListGrtTransaction> GrtVwRptListGrtTransactions { get; set; } = null!;
        public virtual DbSet<GrtVwSearchGrtMaster> GrtVwSearchGrtMasters { get; set; } = null!;
        public virtual DbSet<GrtVwSearchGrtTransaction> GrtVwSearchGrtTransactions { get; set; } = null!;
        public virtual DbSet<PayArea> PayAreas { get; set; } = null!;
        public virtual DbSet<PayBank> PayBanks { get; set; } = null!;
        public virtual DbSet<PayBankAcc> PayBankAccs { get; set; } = null!;
        public virtual DbSet<PayBankBranch> PayBankBranches { get; set; } = null!;
        public virtual DbSet<PayBase> PayBases { get; set; } = null!;
        public virtual DbSet<PayBaseSubUnit> PayBaseSubUnits { get; set; } = null!;
        public virtual DbSet<PayBranch> PayBranches { get; set; } = null!;
        public virtual DbSet<PayCategory> PayCategories { get; set; } = null!;
        public virtual DbSet<PayCountry> PayCountries { get; set; } = null!;
        public virtual DbSet<PayFormMaster> PayFormMasters { get; set; } = null!;
        public virtual DbSet<PayGcbdetail> PayGcbdetails { get; set; } = null!;
        public virtual DbSet<PayGcbtype> PayGcbtypes { get; set; } = null!;
        public virtual DbSet<PayItem> PayItems { get; set; } = null!;
        public virtual DbSet<PayItemBase> PayItemBases { get; set; } = null!;
        public virtual DbSet<PayItemBaseSubUnit> PayItemBaseSubUnits { get; set; } = null!;
        public virtual DbSet<PayItemGroup> PayItemGroups { get; set; } = null!;
        public virtual DbSet<PayItemMonthlyTran> PayItemMonthlyTrans { get; set; } = null!;
        public virtual DbSet<PayItemRank> PayItemRanks { get; set; } = null!;
        public virtual DbSet<PayItemRestric> PayItemRestrics { get; set; } = null!;
        public virtual DbSet<PayLoanDetail> PayLoanDetails { get; set; } = null!;
        public virtual DbSet<PayPerInfo> PayPerInfos { get; set; } = null!;
        public virtual DbSet<PayPerInfoForEmail> PayPerInfoForEmails { get; set; } = null!;
        public virtual DbSet<PayProcessMonth> PayProcessMonths { get; set; } = null!;
        public virtual DbSet<PayQpay> PayQpays { get; set; } = null!;
        public virtual DbSet<PayQpayDetail> PayQpayDetails { get; set; } = null!;
        public virtual DbSet<PayRank> PayRanks { get; set; } = null!;
        public virtual DbSet<PayRankGroup> PayRankGroups { get; set; } = null!;
        public virtual DbSet<PayRankHistory> PayRankHistories { get; set; } = null!;
        public virtual DbSet<PayRptVwTransactionSheduleDetail> PayRptVwTransactionSheduleDetails { get; set; } = null!;
        public virtual DbSet<PaySalaryProcess> PaySalaryProcesses { get; set; } = null!;
        public virtual DbSet<PaySpRptListBankAccountsTransaction> PaySpRptListBankAccountsTransactions { get; set; } = null!;
        public virtual DbSet<PayStatus> PayStatuses { get; set; } = null!;
        public virtual DbSet<PayStatusDetail> PayStatusDetails { get; set; } = null!;
        public virtual DbSet<PaySysCategory> PaySysCategories { get; set; } = null!;
        public virtual DbSet<PaySysSetup> PaySysSetups { get; set; } = null!;
        public virtual DbSet<PayTax> PayTaxes { get; set; } = null!;
        public virtual DbSet<PayTaxTable> PayTaxTables { get; set; } = null!;
        public virtual DbSet<PayViewRptSelectNoOfPersonPayslip> PayViewRptSelectNoOfPersonPayslips { get; set; } = null!;
        public virtual DbSet<PayViewRptSelectSalaryReturn> PayViewRptSelectSalaryReturns { get; set; } = null!;
        public virtual DbSet<PayVwBankdetail> PayVwBankdetails { get; set; } = null!;
        public virtual DbSet<PayVwBoderLine> PayVwBoderLines { get; set; } = null!;
        public virtual DbSet<PayVwFinalPayAllowance> PayVwFinalPayAllowances { get; set; } = null!;
        public virtual DbSet<PayVwFinalPayDeduction> PayVwFinalPayDeductions { get; set; } = null!;
        public virtual DbSet<PayVwPensionSetup> PayVwPensionSetups { get; set; } = null!;
        public virtual DbSet<PayVwPreProcessErrList> PayVwPreProcessErrLists { get; set; } = null!;
        public virtual DbSet<PayVwPromosion> PayVwPromosions { get; set; } = null!;
        public virtual DbSet<PayVwRptAdvanceAccount> PayVwRptAdvanceAccounts { get; set; } = null!;
        public virtual DbSet<PayVwRptAdvanceAccount40Per> PayVwRptAdvanceAccount40Pers { get; set; } = null!;
        public virtual DbSet<PayVwRptAutoIncrement> PayVwRptAutoIncrements { get; set; } = null!;
        public virtual DbSet<PayVwRptAutoIncrementConfirm> PayVwRptAutoIncrementConfirms { get; set; } = null!;
        public virtual DbSet<PayVwRptBankAdvice> PayVwRptBankAdvices { get; set; } = null!;
        public virtual DbSet<PayVwRptBankAdviceFinalpay> PayVwRptBankAdviceFinalpays { get; set; } = null!;
        public virtual DbSet<PayVwRptBankAdviseSetup> PayVwRptBankAdviseSetups { get; set; } = null!;
        public virtual DbSet<PayVwRptBankDeductionsAmount> PayVwRptBankDeductionsAmounts { get; set; } = null!;
        public virtual DbSet<PayVwRptBankDeductionsAmountTextFile> PayVwRptBankDeductionsAmountTextFiles { get; set; } = null!;
        public virtual DbSet<PayVwRptBankDeductionsAmountTextFile2> PayVwRptBankDeductionsAmountTextFile2s { get; set; } = null!;
        public virtual DbSet<PayVwRptBankRemitanceBreakDown> PayVwRptBankRemitanceBreakDowns { get; set; } = null!;
        public virtual DbSet<PayVwRptBankSummary> PayVwRptBankSummaries { get; set; } = null!;
        public virtual DbSet<PayVwRptBankSummaryAreawise> PayVwRptBankSummaryAreawises { get; set; } = null!;
        public virtual DbSet<PayVwRptBankSummaryBasewise> PayVwRptBankSummaryBasewises { get; set; } = null!;
        public virtual DbSet<PayVwRptBankSummaryFinalPay> PayVwRptBankSummaryFinalPays { get; set; } = null!;
        public virtual DbSet<PayVwRptBasewisePaySummary> PayVwRptBasewisePaySummaries { get; set; } = null!;
        public virtual DbSet<PayVwRptComplementList> PayVwRptComplementLists { get; set; } = null!;
        public virtual DbSet<PayVwRptDepartmentPayLoanReport> PayVwRptDepartmentPayLoanReports { get; set; } = null!;
        public virtual DbSet<PayVwRptDepartmentPayReport> PayVwRptDepartmentPayReports { get; set; } = null!;
        public virtual DbSet<PayVwRptDibankloanAccount> PayVwRptDibankloanAccounts { get; set; } = null!;
        public virtual DbSet<PayVwRptDiletter> PayVwRptDiletters { get; set; } = null!;
        public virtual DbSet<PayVwRptIncrement> PayVwRptIncrements { get; set; } = null!;
        public virtual DbSet<PayVwRptIncrementConfirmPendingList> PayVwRptIncrementConfirmPendingLists { get; set; } = null!;
        public virtual DbSet<PayVwRptIncrementDuplicateList> PayVwRptIncrementDuplicateLists { get; set; } = null!;
        public virtual DbSet<PayVwRptListAllowence> PayVwRptListAllowences { get; set; } = null!;
        public virtual DbSet<PayVwRptListAppointment> PayVwRptListAppointments { get; set; } = null!;
        public virtual DbSet<PayVwRptListArear> PayVwRptListArears { get; set; } = null!;
        public virtual DbSet<PayVwRptListBank> PayVwRptListBanks { get; set; } = null!;
        public virtual DbSet<PayVwRptListBankAccountsTransaction> PayVwRptListBankAccountsTransactions { get; set; } = null!;
        public virtual DbSet<PayVwRptListBankAdvice> PayVwRptListBankAdvices { get; set; } = null!;
        public virtual DbSet<PayVwRptListBankBran> PayVwRptListBankBrans { get; set; } = null!;
        public virtual DbSet<PayVwRptListBaseVitit> PayVwRptListBaseVitits { get; set; } = null!;
        public virtual DbSet<PayVwRptListBasis> PayVwRptListBases { get; set; } = null!;
        public virtual DbSet<PayVwRptListBranch> PayVwRptListBranches { get; set; } = null!;
        public virtual DbSet<PayVwRptListCalander> PayVwRptListCalanders { get; set; } = null!;
        public virtual DbSet<PayVwRptListCategory> PayVwRptListCategories { get; set; } = null!;
        public virtual DbSet<PayVwRptListCountry> PayVwRptListCountries { get; set; } = null!;
        public virtual DbSet<PayVwRptListDeduction> PayVwRptListDeductions { get; set; } = null!;
        public virtual DbSet<PayVwRptListDepnType> PayVwRptListDepnTypes { get; set; } = null!;
        public virtual DbSet<PayVwRptListDisHardRationOfficer> PayVwRptListDisHardRationOfficers { get; set; } = null!;
        public virtual DbSet<PayVwRptListDisHardRationSailor> PayVwRptListDisHardRationSailors { get; set; } = null!;
        public virtual DbSet<PayVwRptListEmpBankAccount> PayVwRptListEmpBankAccounts { get; set; } = null!;
        public virtual DbSet<PayVwRptListEmpBasicSal> PayVwRptListEmpBasicSals { get; set; } = null!;
        public virtual DbSet<PayVwRptListEmpDepenProfile> PayVwRptListEmpDepenProfiles { get; set; } = null!;
        public virtual DbSet<PayVwRptListEmpGrpPayItem> PayVwRptListEmpGrpPayItems { get; set; } = null!;
        public virtual DbSet<PayVwRptListEmployeeProfile> PayVwRptListEmployeeProfiles { get; set; } = null!;
        public virtual DbSet<PayVwRptListGcbtype> PayVwRptListGcbtypes { get; set; } = null!;
        public virtual DbSet<PayVwRptListLeaveType> PayVwRptListLeaveTypes { get; set; } = null!;
        public virtual DbSet<PayVwRptListLoan> PayVwRptListLoans { get; set; } = null!;
        public virtual DbSet<PayVwRptListLoanRegister> PayVwRptListLoanRegisters { get; set; } = null!;
        public virtual DbSet<PayVwRptListOvsReason> PayVwRptListOvsReasons { get; set; } = null!;
        public virtual DbSet<PayVwRptListPaymentAnalysis> PayVwRptListPaymentAnalyses { get; set; } = null!;
        public virtual DbSet<PayVwRptListQpayType> PayVwRptListQpayTypes { get; set; } = null!;
        public virtual DbSet<PayVwRptListRank> PayVwRptListRanks { get; set; } = null!;
        public virtual DbSet<PayVwRptListReligion> PayVwRptListReligions { get; set; } = null!;
        public virtual DbSet<PayVwRptListStatus> PayVwRptListStatuses { get; set; } = null!;
        public virtual DbSet<PayVwRptListSubUnit> PayVwRptListSubUnits { get; set; } = null!;
        public virtual DbSet<PayVwRptListSysCategory> PayVwRptListSysCategories { get; set; } = null!;
        public virtual DbSet<PayVwRptListTotalSalaryCashPayment> PayVwRptListTotalSalaryCashPayments { get; set; } = null!;
        public virtual DbSet<PayVwRptListWoprate> PayVwRptListWoprates { get; set; } = null!;
        public virtual DbSet<PayVwRptMonBankSumm> PayVwRptMonBankSumms { get; set; } = null!;
        public virtual DbSet<PayVwRptMonBankSummArea> PayVwRptMonBankSummAreas { get; set; } = null!;
        public virtual DbSet<PayVwRptMonBranchSumm> PayVwRptMonBranchSumms { get; set; } = null!;
        public virtual DbSet<PayVwRptMonBranchSummArea> PayVwRptMonBranchSummAreas { get; set; } = null!;
        public virtual DbSet<PayVwRptMonBranchSummBase> PayVwRptMonBranchSummBases { get; set; } = null!;
        public virtual DbSet<PayVwRptMonCoinAnnArea> PayVwRptMonCoinAnnAreas { get; set; } = null!;
        public virtual DbSet<PayVwRptMonCoinAnnBase> PayVwRptMonCoinAnnBases { get; set; } = null!;
        public virtual DbSet<PayVwRptMonPayRegArea> PayVwRptMonPayRegAreas { get; set; } = null!;
        public virtual DbSet<PayVwRptMonPayRegBase> PayVwRptMonPayRegBases { get; set; } = null!;
        public virtual DbSet<PayVwRptMonPayRegBranch> PayVwRptMonPayRegBranches { get; set; } = null!;
        public virtual DbSet<PayVwRptMonPayRegOfficer> PayVwRptMonPayRegOfficers { get; set; } = null!;
        public virtual DbSet<PayVwRptMonPayRegRank> PayVwRptMonPayRegRanks { get; set; } = null!;
        public virtual DbSet<PayVwRptMonPayRegSubUnit> PayVwRptMonPayRegSubUnits { get; set; } = null!;
        public virtual DbSet<PayVwRptMonPayRegister> PayVwRptMonPayRegisters { get; set; } = null!;
        public virtual DbSet<PayVwRptMonPaySumm> PayVwRptMonPaySumms { get; set; } = null!;
        public virtual DbSet<PayVwRptMonPaySummary> PayVwRptMonPaySummaries { get; set; } = null!;
        public virtual DbSet<PayVwRptMonSalRecon> PayVwRptMonSalRecons { get; set; } = null!;
        public virtual DbSet<PayVwRptMonSalReconDet> PayVwRptMonSalReconDets { get; set; } = null!;
        public virtual DbSet<PayVwRptMonSalReconDetAll> PayVwRptMonSalReconDetAlls { get; set; } = null!;
        public virtual DbSet<PayVwRptMonSalReconDetSum> PayVwRptMonSalReconDetSums { get; set; } = null!;
        public virtual DbSet<PayVwRptMonSalReconDetSumAll> PayVwRptMonSalReconDetSumAlls { get; set; } = null!;
        public virtual DbSet<PayVwRptMonSalReconSum> PayVwRptMonSalReconSums { get; set; } = null!;
        public virtual DbSet<PayVwRptNoOfPerson> PayVwRptNoOfPersons { get; set; } = null!;
        public virtual DbSet<PayVwRptPaySlip> PayVwRptPaySlips { get; set; } = null!;
        public virtual DbSet<PayVwRptPaySlipEmail> PayVwRptPaySlipEmails { get; set; } = null!;
        public virtual DbSet<PayVwRptPaySlipNewEmail> PayVwRptPaySlipNewEmails { get; set; } = null!;
        public virtual DbSet<PayVwRptPreProcessErrList> PayVwRptPreProcessErrLists { get; set; } = null!;
        public virtual DbSet<PayVwRptProcessUnprocessList> PayVwRptProcessUnprocessLists { get; set; } = null!;
        public virtual DbSet<PayVwRptProcessUnprocessListXml> PayVwRptProcessUnprocessListXmls { get; set; } = null!;
        public virtual DbSet<PayVwRptProcessUnprocessListXmlObf> PayVwRptProcessUnprocessListXmlObfs { get; set; } = null!;
        public virtual DbSet<PayVwRptProcessUnprocessListXmlOld> PayVwRptProcessUnprocessListXmlOlds { get; set; } = null!;
        public virtual DbSet<PayVwRptProcessUnprocessListXmlRnbf> PayVwRptProcessUnprocessListXmlRnbfs { get; set; } = null!;
        public virtual DbSet<PayVwRptProcessUnprocessListXmlVnbf> PayVwRptProcessUnprocessListXmlVnbfs { get; set; } = null!;
        public virtual DbSet<PayVwRptProcessUnprocessListXmlnew> PayVwRptProcessUnprocessListXmlnews { get; set; } = null!;
        public virtual DbSet<PayVwRptSalaryValidation> PayVwRptSalaryValidations { get; set; } = null!;
        public virtual DbSet<PayVwRptSelectPaymentVoucher> PayVwRptSelectPaymentVouchers { get; set; } = null!;
        public virtual DbSet<PayVwRptSelectWop> PayVwRptSelectWops { get; set; } = null!;
        public virtual DbSet<PayVwRptStopSalary> PayVwRptStopSalaries { get; set; } = null!;
        public virtual DbSet<PayVwRptYearlyBasewisePaySummary> PayVwRptYearlyBasewisePaySummaries { get; set; } = null!;
        public virtual DbSet<PayVwSalTextTran> PayVwSalTextTrans { get; set; } = null!;
        public virtual DbSet<PayVwSearchAppoDetail> PayVwSearchAppoDetails { get; set; } = null!;
        public virtual DbSet<PayVwSearchAppointment> PayVwSearchAppointments { get; set; } = null!;
        public virtual DbSet<PayVwSearchArea> PayVwSearchAreas { get; set; } = null!;
        public virtual DbSet<PayVwSearchBank> PayVwSearchBanks { get; set; } = null!;
        public virtual DbSet<PayVwSearchBankAccount> PayVwSearchBankAccounts { get; set; } = null!;
        public virtual DbSet<PayVwSearchBankBranch> PayVwSearchBankBranches { get; set; } = null!;
        public virtual DbSet<PayVwSearchBankDeduction> PayVwSearchBankDeductions { get; set; } = null!;
        public virtual DbSet<PayVwSearchBankDeduction1> PayVwSearchBankDeductions1 { get; set; } = null!;
        public virtual DbSet<PayVwSearchBase> PayVwSearchBases { get; set; } = null!;
        public virtual DbSet<PayVwSearchBaseSubUnit> PayVwSearchBaseSubUnits { get; set; } = null!;
        public virtual DbSet<PayVwSearchBranch> PayVwSearchBranches { get; set; } = null!;
        public virtual DbSet<PayVwSearchCategory> PayVwSearchCategories { get; set; } = null!;
        public virtual DbSet<PayVwSearchCommonItemEntry> PayVwSearchCommonItemEntries { get; set; } = null!;
        public virtual DbSet<PayVwSearchConmmonitemGroup> PayVwSearchConmmonitemGroups { get; set; } = null!;
        public virtual DbSet<PayVwSearchCountry> PayVwSearchCountries { get; set; } = null!;
        public virtual DbSet<PayVwSearchDepnProfile> PayVwSearchDepnProfiles { get; set; } = null!;
        public virtual DbSet<PayVwSearchDepnType> PayVwSearchDepnTypes { get; set; } = null!;
        public virtual DbSet<PayVwSearchFinalPay> PayVwSearchFinalPays { get; set; } = null!;
        public virtual DbSet<PayVwSearchForginAllowance> PayVwSearchForginAllowances { get; set; } = null!;
        public virtual DbSet<PayVwSearchGcbtype> PayVwSearchGcbtypes { get; set; } = null!;
        public virtual DbSet<PayVwSearchItemAllowance> PayVwSearchItemAllowances { get; set; } = null!;
        public virtual DbSet<PayVwSearchItemDeduction> PayVwSearchItemDeductions { get; set; } = null!;
        public virtual DbSet<PayVwSearchItemGroup> PayVwSearchItemGroups { get; set; } = null!;
        public virtual DbSet<PayVwSearchItemGroupsFinalPay> PayVwSearchItemGroupsFinalPays { get; set; } = null!;
        public virtual DbSet<PayVwSearchItemGroupsValidation> PayVwSearchItemGroupsValidations { get; set; } = null!;
        public virtual DbSet<PayVwSearchItemLoan> PayVwSearchItemLoans { get; set; } = null!;
        public virtual DbSet<PayVwSearchLeaveType> PayVwSearchLeaveTypes { get; set; } = null!;
        public virtual DbSet<PayVwSearchLoanDetail> PayVwSearchLoanDetails { get; set; } = null!;
        public virtual DbSet<PayVwSearchOvsReason> PayVwSearchOvsReasons { get; set; } = null!;
        public virtual DbSet<PayVwSearchPerInfo> PayVwSearchPerInfos { get; set; } = null!;
        public virtual DbSet<PayVwSearchPerInfoGrativity> PayVwSearchPerInfoGrativities { get; set; } = null!;
        public virtual DbSet<PayVwSearchPerInfoPension> PayVwSearchPerInfoPensions { get; set; } = null!;
        public virtual DbSet<PayVwSearchPerInfoPensionRevice> PayVwSearchPerInfoPensionRevices { get; set; } = null!;
        public virtual DbSet<PayVwSearchPerInfoRevice> PayVwSearchPerInfoRevices { get; set; } = null!;
        public virtual DbSet<PayVwSearchQpay> PayVwSearchQpays { get; set; } = null!;
        public virtual DbSet<PayVwSearchRank> PayVwSearchRanks { get; set; } = null!;
        public virtual DbSet<PayVwSearchRankGroup> PayVwSearchRankGroups { get; set; } = null!;
        public virtual DbSet<PayVwSearchRankIncrement> PayVwSearchRankIncrements { get; set; } = null!;
        public virtual DbSet<PayVwSearchReligion> PayVwSearchReligions { get; set; } = null!;
        public virtual DbSet<PayVwSearchServiceStatus> PayVwSearchServiceStatuses { get; set; } = null!;
        public virtual DbSet<PayVwSearchStatus> PayVwSearchStatuses { get; set; } = null!;
        public virtual DbSet<PayVwSearchStatusChange> PayVwSearchStatusChanges { get; set; } = null!;
        public virtual DbSet<PayVwSearchSysCategory> PayVwSearchSysCategories { get; set; } = null!;
        public virtual DbSet<PayVwSearchTax> PayVwSearchTaxes { get; set; } = null!;
        public virtual DbSet<PayVwSearchTraVal> PayVwSearchTraVals { get; set; } = null!;
        public virtual DbSet<PayVwSearchUserGroup> PayVwSearchUserGroups { get; set; } = null!;
        public virtual DbSet<PayVwSearchUserMaster> PayVwSearchUserMasters { get; set; } = null!;
        public virtual DbSet<PayVwSearchWoprate> PayVwSearchWoprates { get; set; } = null!;
        public virtual DbSet<PayVwSelectCashRecociliation> PayVwSelectCashRecociliations { get; set; } = null!;
        public virtual DbSet<PayVwSelectForginDetail> PayVwSelectForginDetails { get; set; } = null!;
        public virtual DbSet<PayVwSelectStopbank> PayVwSelectStopbanks { get; set; } = null!;
        public virtual DbSet<PayVwTransactionSheduleDetail> PayVwTransactionSheduleDetails { get; set; } = null!;
        public virtual DbSet<PenVwPensionReportSinhala> PenVwPensionReportSinhalas { get; set; } = null!;
        public virtual DbSet<PnsCatPercentage> PnsCatPercentages { get; set; } = null!;
        public virtual DbSet<PnsRankPercentage> PnsRankPercentages { get; set; } = null!;
        public virtual DbSet<PnsSetUp> PnsSetUps { get; set; } = null!;
        public virtual DbSet<PnsVwSearchPerInfoGrativity> PnsVwSearchPerInfoGrativities { get; set; } = null!;
        public virtual DbSet<PnsVwWnoptotal> PnsVwWnoptotals { get; set; } = null!;
        public virtual DbSet<TempRentCeiling> TempRentCeilings { get; set; } = null!;
        public virtual DbSet<TempViewAutoIncrement> TempViewAutoIncrements { get; set; } = null!;
        public virtual DbSet<VwRptSalaryReconcile> VwRptSalaryReconciles { get; set; } = null!;
        public virtual DbSet<VwRptSalaryReconcileSummary> VwRptSalaryReconcileSummaries { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=10.10.1.232; Database=Payroll_SLNavy; User Id=sa; Password=SDUAdmin@2019;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AtestBank>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ATestBank");

                entity.Property(e => e.CatCode)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.OfficialNo)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.SysCode)
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<GrtVwAllowanceSetup>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Grt_Vw_AllowanceSetup", "SLIS_Pay");

                entity.Property(e => e.CatCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.MaxYears1022Grt).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.MaxYearsDeathGrt).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.MinYears1022Grt).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.MinYearsDeathGrt).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.MinYearsPensonGrt).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.UnChildMinYears).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.UnSibLingsYears).HasColumnType("numeric(18, 2)");
            });

            modelBuilder.Entity<GrtVwRptListGrtTransaction>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Grt_Vw_Rpt_ListGrtTransactions", "SLIS_Pay");

                entity.Property(e => e.Accno)
                    .HasMaxLength(15)
                    .IsFixedLength();

                entity.Property(e => e.AgeDays)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.AgeMonth)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.AgeYear)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CatCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.ChildCount).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.DonNo)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.GetPer).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.GrtAmount).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.GrtDate).HasColumnType("datetime");

                entity.Property(e => e.GrtStartDate).HasColumnType("datetime");

                entity.Property(e => e.GrtType)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Grtname)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .HasColumnName("NAME");

                entity.Property(e => e.OfficerCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.SerDays)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.SerMonth)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.SerYear)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.SysCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.TotAllowance).HasColumnType("numeric(18, 2)");
            });

            modelBuilder.Entity<GrtVwSearchGrtMaster>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Grt_Vw_SearchGrtMaster", "SLIS_Pay");

                entity.Property(e => e.Code)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GrtVwSearchGrtTransaction>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Grt_Vw_SearchGrtTransactions", "SLIS_Pay");

                entity.Property(e => e.AgeDays)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.AgeMonth)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.AgeYear)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CatCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.ChildCount).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.DonNo)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.GetPer).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.GrtAmount).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.GrtDate).HasColumnType("datetime");

                entity.Property(e => e.GrtStartDate).HasColumnType("datetime");

                entity.Property(e => e.GrtType)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(210)
                    .IsUnicode(false);

                entity.Property(e => e.OfficerCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.SerDays)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.SerMonth)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.SerYear)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.SysCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.TotAllowance).HasColumnType("numeric(18, 2)");
            });

            modelBuilder.Entity<PayArea>(entity =>
            {
                entity.HasKey(e => e.AreaCode);

                entity.ToTable("Pay_Area", "SLIS_Pay");

                entity.Property(e => e.AreaCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.AreaEmail)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AreaName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AreaStName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PayBank>(entity =>
            {
                entity.HasKey(e => e.BankCode);

                entity.ToTable("Pay_Bank", "SLIS_Pay");

                entity.Property(e => e.BankCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.BankName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BankSname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BankSName");
            });

            modelBuilder.Entity<PayBankAcc>(entity =>
            {
                entity.HasKey(e => new { e.SysCode, e.CatCode, e.OfficerCode, e.AccCat, e.AccPriority, e.BankCode, e.BranchCode, e.AccNo, e.DepnId });

                entity.ToTable("Pay_BankAcc", "SLIS_Pay");

                entity.Property(e => e.SysCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CatCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.OfficerCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.AccCat)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BankCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.BranchCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.AccNo)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.DepnId)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("DepnID")
                    .HasComment("''");

                entity.Property(e => e.Amount)
                    .HasColumnType("numeric(18, 2)")
                    .HasComment("If not salary account the amount should be percentage and >=100");

                entity.Property(e => e.LoanAmt).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.PayMonth).HasColumnType("datetime");

                entity.Property(e => e.Remark)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Trorder)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<PayBankBranch>(entity =>
            {
                entity.HasKey(e => new { e.BankCode, e.BranchCode });

                entity.ToTable("Pay_BankBranch", "SLIS_Pay");

                entity.Property(e => e.BankCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.BranchCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Address)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.BranchName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BranchSname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BranchSName");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Etrans).HasColumnName("ETrans");

                entity.Property(e => e.Fax)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Telephone)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.HasOne(d => d.BankCodeNavigation)
                    .WithMany(p => p.PayBankBranches)
                    .HasForeignKey(d => d.BankCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Pay_BankBranch_Pay_Bank");
            });

            modelBuilder.Entity<PayBase>(entity =>
            {
                entity.HasKey(e => new { e.BaseCode, e.AreaCode });

                entity.ToTable("Pay_Base", "SLIS_Pay");

                entity.HasIndex(e => e.BaseCode, "IX_Pay_Base")
                    .IsUnique();

                entity.HasIndex(e => e.BaseCode, "IX_Pay_Base_1")
                    .IsUnique();

                entity.Property(e => e.BaseCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.AreaCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.BaseEmail)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BaseName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BaseNameSin)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BaseSname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BaseSName");

                entity.HasOne(d => d.AreaCodeNavigation)
                    .WithMany(p => p.PayBases)
                    .HasForeignKey(d => d.AreaCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Pay_Base_Pay_Area");
            });

            modelBuilder.Entity<PayBaseSubUnit>(entity =>
            {
                entity.HasKey(e => new { e.SubUnitCode, e.BaseCode });

                entity.ToTable("Pay_BaseSubUnit", "SLIS_Pay");

                entity.Property(e => e.SubUnitCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.BaseCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.SubUnitName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SubUnitNameSin)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SubUnitSname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SubUnitSName");

                entity.HasOne(d => d.BaseCodeNavigation)
                    .WithMany(p => p.PayBaseSubUnits)
                    .HasPrincipalKey(p => p.BaseCode)
                    .HasForeignKey(d => d.BaseCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Pay_BaseSubUnit_Pay_Base");
            });

            modelBuilder.Entity<PayBranch>(entity =>
            {
                entity.HasKey(e => e.BranchCode);

                entity.ToTable("Pay_Branch", "SLIS_Pay");

                entity.Property(e => e.BranchCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.BranchName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BranchSname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BranchSName");

                entity.Property(e => e.CatCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.HasOne(d => d.CatCodeNavigation)
                    .WithMany(p => p.PayBranches)
                    .HasForeignKey(d => d.CatCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Pay_Branch_Pay_Category");
            });

            modelBuilder.Entity<PayCategory>(entity =>
            {
                entity.HasKey(e => e.CatCode);

                entity.ToTable("Pay_Category", "SLIS_Pay");

                entity.Property(e => e.CatCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CatName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CatSname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CatSName");

                entity.Property(e => e.SalDispAmt).HasColumnType("numeric(18, 2)");
            });

            modelBuilder.Entity<PayCountry>(entity =>
            {
                entity.HasKey(e => e.CountryCode);

                entity.ToTable("Pay_Country", "SLIS_Pay");

                entity.Property(e => e.CountryCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CountryName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CountryRate1).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CountryRate2).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.MessCharges).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Persentage).HasColumnType("numeric(18, 2)");
            });

            modelBuilder.Entity<PayFormMaster>(entity =>
            {
                entity.HasKey(e => e.FrmId);

                entity.ToTable("Pay_FormMaster", "SLIS_Pay");

                entity.HasIndex(e => e.FrmId, "IX_Pay_FormMaster")
                    .IsUnique();

                entity.Property(e => e.FrmId).ValueGeneratedNever();

                entity.Property(e => e.FrmCode).HasMaxLength(50);

                entity.Property(e => e.FrmDesc).HasMaxLength(50);

                entity.Property(e => e.FrmOptions).HasMaxLength(20);

                entity.Property(e => e.FrmType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<PayGcbdetail>(entity =>
            {
                entity.HasKey(e => new { e.SysCode, e.CatCode, e.OfficerCode, e.Gcbcode });

                entity.ToTable("Pay_GCBDetails", "SLIS_Pay");

                entity.Property(e => e.SysCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CatCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.OfficerCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Gcbcode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("GCBCode");

                entity.Property(e => e.GcbapDate)
                    .HasColumnType("datetime")
                    .HasColumnName("GCBApDate");

                entity.Property(e => e.Trorder)
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("TRORDER");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.GcbcodeNavigation)
                    .WithMany(p => p.PayGcbdetails)
                    .HasForeignKey(d => d.Gcbcode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Pay_GCBDetails_Pay_GCBType");

                entity.HasOne(d => d.PayPerInfo)
                    .WithMany(p => p.PayGcbdetails)
                    .HasForeignKey(d => new { d.SysCode, d.CatCode, d.OfficerCode })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Pay_GCBDetails_Pay_PerInfo");
            });

            modelBuilder.Entity<PayGcbtype>(entity =>
            {
                entity.HasKey(e => e.Gcbcode);

                entity.ToTable("Pay_GCBType", "SLIS_Pay");

                entity.Property(e => e.Gcbcode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("GCBCode");

                entity.Property(e => e.Amount).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.ArreasCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Gcbgroup)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("GCBGroup");

                entity.Property(e => e.Gcbname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GCBName");
            });

            modelBuilder.Entity<PayItem>(entity =>
            {
                entity.HasKey(e => new { e.ItemCode, e.ItemCategory })
                    .HasName("PK_Pay_PayItems");

                entity.ToTable("Pay_Item", "SLIS_Pay");

                entity.Property(e => e.ItemCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.ItemCategory)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AccNoVotNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AreasOverPayItemCategory)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AreasOverPayItemCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Bank)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.BankBranch)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.BasicYearMonth)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.GrossPay).HasDefaultValueSql("('')");

                entity.Property(e => e.GrossPdu).HasColumnName("GrossPDu");

                entity.Property(e => e.ItemAltName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ItemName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Nopay).HasDefaultValueSql("('')");

                entity.Property(e => e.Percentage).HasColumnType("numeric(18, 5)");

                entity.Property(e => e.Rate)
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Type)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.ValidateNav32).HasDefaultValueSql("((0))");

                entity.Property(e => e.Wop)
                    .HasColumnName("WOP")
                    .HasDefaultValueSql("('')");

                entity.HasMany(d => d.PayPerInfos)
                    .WithMany(p => p.ItemCs)
                    .UsingEntity<Dictionary<string, object>>(
                        "PayItemOfficer",
                        l => l.HasOne<PayPerInfo>().WithMany().HasForeignKey("SysCode", "CatCode", "OfficesrCode").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_Pay_ItemOfficers_Pay_PerInfo"),
                        r => r.HasOne<PayItem>().WithMany().HasForeignKey("ItemCode", "ItemCategory").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_Pay_ItemOfficers_Pay_Item"),
                        j =>
                        {
                            j.HasKey("ItemCode", "ItemCategory", "SysCode", "CatCode", "OfficesrCode").HasName("PK_Pay_PayItemsOfficers");

                            j.ToTable("Pay_ItemOfficers", "SLIS_Pay");

                            j.IndexerProperty<string>("ItemCode").HasMaxLength(4).IsUnicode(false);

                            j.IndexerProperty<string>("ItemCategory").HasMaxLength(1).IsUnicode(false).IsFixedLength();

                            j.IndexerProperty<string>("SysCode").HasMaxLength(4).IsUnicode(false);

                            j.IndexerProperty<string>("CatCode").HasMaxLength(4).IsUnicode(false);

                            j.IndexerProperty<string>("OfficesrCode").HasMaxLength(15).IsUnicode(false);
                        });
            });

            modelBuilder.Entity<PayItemBase>(entity =>
            {
                entity.HasKey(e => new { e.ItemCode, e.ItemCategory, e.BaseCode })
                    .HasName("PK_Pay_ItemBase_1");

                entity.ToTable("Pay_ItemBase", "SLIS_Pay");

                entity.Property(e => e.ItemCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.ItemCategory)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BaseCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Rate).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.SubUnitCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.HasOne(d => d.BaseCodeNavigation)
                    .WithMany(p => p.PayItemBases)
                    .HasPrincipalKey(p => p.BaseCode)
                    .HasForeignKey(d => d.BaseCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Pay_ItemBase_Pay_Base");

                entity.HasOne(d => d.ItemC)
                    .WithMany(p => p.PayItemBases)
                    .HasForeignKey(d => new { d.ItemCode, d.ItemCategory })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Pay_ItemBase_Pay_Item");
            });

            modelBuilder.Entity<PayItemBaseSubUnit>(entity =>
            {
                entity.HasKey(e => new { e.ItemCode, e.ItemCategory, e.BaseCode, e.SubUnitCode });

                entity.ToTable("Pay_ItemBaseSubUnit", "SLIS_Pay");

                entity.Property(e => e.ItemCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.ItemCategory)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BaseCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.SubUnitCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Rate).HasColumnType("numeric(18, 2)");
            });

            modelBuilder.Entity<PayItemGroup>(entity =>
            {
                entity.HasKey(e => new { e.ItemCode, e.ItemCategory });

                entity.ToTable("Pay_ItemGroup", "SLIS_Pay");

                entity.Property(e => e.ItemCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.ItemCategory)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.GroupCategory)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.GroupItemCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.HasOne(d => d.ItemC)
                    .WithOne(p => p.PayItemGroup)
                    .HasForeignKey<PayItemGroup>(d => new { d.ItemCode, d.ItemCategory })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Pay_ItemGroup_Pay_Item");
            });

            modelBuilder.Entity<PayItemMonthlyTran>(entity =>
            {
                entity.HasKey(e => new { e.SysCode, e.CatCode, e.OfficerCode, e.ItemCode, e.ItemCategory });

                entity.ToTable("Pay_ItemMonthlyTrans", "SLIS_Pay");

                entity.Property(e => e.SysCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CatCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.OfficerCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.ItemCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.ItemCategory)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Amount).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.EffectFrom)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.EffectTo)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Torder)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("TORDER");

                entity.Property(e => e.Trdarte)
                    .HasColumnType("datetime")
                    .HasColumnName("TRDarte");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.CatCodeNavigation)
                    .WithMany(p => p.PayItemMonthlyTrans)
                    .HasForeignKey(d => d.CatCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Pay_ItemMonthlyTrans_Pay_Category");

                entity.HasOne(d => d.ItemC)
                    .WithMany(p => p.PayItemMonthlyTrans)
                    .HasForeignKey(d => new { d.ItemCode, d.ItemCategory })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Pay_ItemMonthlyTrans_Pay_Item");

                entity.HasOne(d => d.PayPerInfo)
                    .WithMany(p => p.PayItemMonthlyTrans)
                    .HasForeignKey(d => new { d.SysCode, d.CatCode, d.OfficerCode })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Pay_ItemMonthlyTrans_Pay_PerInfo");
            });

            modelBuilder.Entity<PayItemRank>(entity =>
            {
                entity.HasKey(e => new { e.ItemCode, e.ItemCategory, e.RankCode, e.CatCode })
                    .HasName("PK_Pay_PayItemRank");

                entity.ToTable("Pay_ItemRank", "SLIS_Pay");

                entity.Property(e => e.ItemCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.ItemCategory)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RankCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CatCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Rate).HasColumnType("numeric(18, 2)");

                entity.HasOne(d => d.ItemC)
                    .WithMany(p => p.PayItemRanks)
                    .HasForeignKey(d => new { d.ItemCode, d.ItemCategory })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Pay_ItemRank_Pay_Item");
            });

            modelBuilder.Entity<PayItemRestric>(entity =>
            {
                entity.HasKey(e => new { e.ItemCode, e.ItemCategory, e.ItemCodeRes, e.ItemCategoryRes })
                    .HasName("PK_Pay_PayItemsRestric");

                entity.ToTable("Pay_ItemRestric", "SLIS_Pay");

                entity.Property(e => e.ItemCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.ItemCategory)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ItemCodeRes)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.ItemCategoryRes)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.ItemC)
                    .WithMany(p => p.PayItemRestrics)
                    .HasForeignKey(d => new { d.ItemCode, d.ItemCategory })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Pay_ItemRestric_Pay_Item");
            });

            modelBuilder.Entity<PayLoanDetail>(entity =>
            {
                entity.HasKey(e => new { e.SysCode, e.OfficerCode, e.CatCode, e.ItemCode, e.ItemCategory });

                entity.ToTable("Pay_LoanDetails", "SLIS_Pay");

                entity.Property(e => e.SysCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.OfficerCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.CatCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.ItemCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.ItemCategory)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LoanAmount).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.LoanDate).HasColumnType("datetime");

                entity.Property(e => e.MonthInstall).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.NoInstall).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.RecAmount).HasColumnType("numeric(18, 2)");

                entity.HasOne(d => d.ItemC)
                    .WithMany(p => p.PayLoanDetails)
                    .HasForeignKey(d => new { d.ItemCode, d.ItemCategory })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Pay_LoanDetails_Pay_PayItems");

                entity.HasOne(d => d.PayPerInfo)
                    .WithMany(p => p.PayLoanDetails)
                    .HasForeignKey(d => new { d.SysCode, d.CatCode, d.OfficerCode })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Pay_LoanDetails_Pay_PerInfo");
            });

            modelBuilder.Entity<PayPerInfo>(entity =>
            {
                entity.HasKey(e => new { e.SysCode, e.CatCode, e.OfficerCode });

                entity.ToTable("Pay_PerInfo", "SLIS_Pay");

                entity.Property(e => e.SysCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CatCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.OfficerCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.AddressSin)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.BaseCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.BranchCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Bsalary)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("BSalary")
                    .HasDefaultValueSql("((0))")
                    .HasComment("");

                entity.Property(e => e.CivilStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DateBirth).HasColumnType("datetime");

                entity.Property(e => e.DateJoin).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EMail");

                entity.Property(e => e.Fax)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.FullName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.FullNameSin)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Gender)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Initials)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IntnameSin)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("INTNameSin");

                entity.Property(e => e.NavyId)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("NavyID");

                entity.Property(e => e.NavyIdsin)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("NavyIDSin");

                entity.Property(e => e.Nicnumber)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("NICNumber");

                entity.Property(e => e.NkinAdd)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("NKinAdd");

                entity.Property(e => e.NkinBaseCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("NKinBaseCode");

                entity.Property(e => e.NkinBaseSubCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("NKinBaseSubCode");

                entity.Property(e => e.NkinName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("NKinName");

                entity.Property(e => e.NkinRelation)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NKinRelation");

                entity.Property(e => e.OfficerCodeSin)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.OtherAdd)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PermanentAdd)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Picture).HasColumnType("image");

                entity.Property(e => e.Policino)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("POLICINO");

                entity.Property(e => e.RankCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.RankGroup)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.ReEngPay)
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ReligCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.SalDispAmt)
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Status)
                    .HasDefaultValueSql("((1))")
                    .HasComment("");

                entity.Property(e => e.StatusEffectDate).HasColumnType("datetime");

                entity.Property(e => e.SubUnitCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.SurName)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.SysType)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TaxTable)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Tel)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.VotId).HasColumnName("VotID");

                entity.Property(e => e.WOp)
                    .HasColumnName("W_OP")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<PayPerInfoForEmail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Pay_PerInfo-FOR EMAILS", "SLIS_Pay");

                entity.Property(e => e.CatCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EMail");

                entity.Property(e => e.OfficerCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.SysCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PayProcessMonth>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Pay_ProcessMonth", "SLIS_Pay");

                entity.Property(e => e.CurMonth)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.PrevMonth)
                    .HasMaxLength(6)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PayQpay>(entity =>
            {
                entity.HasKey(e => e.QpayCode);

                entity.ToTable("Pay_QPay", "SLIS_Pay");

                entity.Property(e => e.QpayCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("QPayCode");

                entity.Property(e => e.Amount).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.ArreasCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.QpayName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("QPayName");
            });

            modelBuilder.Entity<PayQpayDetail>(entity =>
            {
                entity.HasKey(e => new { e.SysCode, e.CatCode, e.OfficerCode, e.QpayCode });

                entity.ToTable("Pay_QPayDetails", "SLIS_Pay");

                entity.Property(e => e.SysCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CatCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.OfficerCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.QpayCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("QPayCode");

                entity.Property(e => e.QpayApDate)
                    .HasColumnType("datetime")
                    .HasColumnName("QPayApDate");

                entity.Property(e => e.Trorder)
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("TRORDER");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.QpayCodeNavigation)
                    .WithMany(p => p.PayQpayDetails)
                    .HasForeignKey(d => d.QpayCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Pay_QPayDetails_Pay_QPay");

                entity.HasOne(d => d.PayPerInfo)
                    .WithMany(p => p.PayQpayDetails)
                    .HasForeignKey(d => new { d.SysCode, d.CatCode, d.OfficerCode })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Pay_QPayDetails_Pay_PerInfo");
            });

            modelBuilder.Entity<PayRank>(entity =>
            {
                entity.HasKey(e => new { e.CatCode, e.RankCode, e.RankGroup });

                entity.ToTable("Pay_Rank", "SLIS_Pay");

                entity.Property(e => e.CatCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.RankCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.RankGroup)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.RankName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RankNameSin)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RankSname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RankSName");

                entity.Property(e => e.StartSalary).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Woprate)
                    .HasColumnType("numeric(6, 2)")
                    .HasColumnName("WOPRate");
            });

            modelBuilder.Entity<PayRankGroup>(entity =>
            {
                entity.HasKey(e => new { e.CatCode, e.RankGroup, e.RgroupName });

                entity.ToTable("Pay_RankGroups", "SLIS_Pay");

                entity.Property(e => e.CatCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.RankGroup)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.RgroupName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RGroupName");
            });

            modelBuilder.Entity<PayRankHistory>(entity =>
            {
                entity.HasKey(e => new { e.SysCode, e.CatCode, e.OfficerCode, e.RankCode, e.DateEffect, e.TrNo, e.RankGroup });

                entity.ToTable("Pay_RankHistory", "SLIS_Pay");

                entity.Property(e => e.SysCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CatCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.OfficerCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.RankCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.DateEffect).HasColumnType("datetime");

                entity.Property(e => e.TrNo)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("Tr_no");

                entity.Property(e => e.RankGroup)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.DateConfirmed).HasColumnType("datetime");

                entity.Property(e => e.Picture).HasColumnType("image");

                entity.Property(e => e.Referance)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<PayRptVwTransactionSheduleDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pay_RPT_Vw_Transaction_Shedule_Details", "SLIS_Pay");

                entity.Property(e => e.Amount).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CatCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.ItemCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(165)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.OfficerCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.SysCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PaySalaryProcess>(entity =>
            {
                entity.HasKey(e => new { e.SysCode, e.CatCode, e.OfficerCode, e.ItemCode, e.ItemCategory });

                entity.ToTable("Pay_SalaryProcess", "SLIS_Pay");

                entity.Property(e => e.SysCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CatCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.OfficerCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.ItemCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.ItemCategory)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Amount)
                    .HasColumnType("numeric(18, 2)")
                    .HasComment("");

                entity.Property(e => e.Area)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.BaseCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Rate).HasColumnType("numeric(9, 2)");

                entity.Property(e => e.SubUnitCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Torder)
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("TORDER");

                entity.Property(e => e.Units).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.ItemC)
                    .WithMany(p => p.PaySalaryProcesses)
                    .HasForeignKey(d => new { d.ItemCode, d.ItemCategory })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Pay_SalaryProcess_Pay_Item");

                entity.HasOne(d => d.PayPerInfo)
                    .WithMany(p => p.PaySalaryProcesses)
                    .HasForeignKey(d => new { d.SysCode, d.CatCode, d.OfficerCode })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Pay_SalaryProcess_Pay_PerInfo");
            });

            modelBuilder.Entity<PaySpRptListBankAccountsTransaction>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pay_SP_Rpt_ListBankAccounts_transaction", "SLIS_Pay");

                entity.Property(e => e.AccCat)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AccNo)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Amount).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.BankCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.BranchCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CatCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.DepnId)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("DepnID");

                entity.Property(e => e.LoanAmt).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Mtype)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("MType");

                entity.Property(e => e.OfficerCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.PayMonth).HasColumnType("datetime");

                entity.Property(e => e.SysCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PayStatus>(entity =>
            {
                entity.HasKey(e => e.StatusCode);

                entity.ToTable("Pay_Status", "SLIS_Pay");

                entity.Property(e => e.StatusCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.NavCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("Nav_Code");

                entity.Property(e => e.SalCalcMethod)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.StatusName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PayStatusDetail>(entity =>
            {
                entity.HasKey(e => new { e.SysCode, e.CatCode, e.OfficerCode, e.StatusCode, e.DateEffect });

                entity.ToTable("Pay_StatusDetail", "SLIS_Pay");

                entity.Property(e => e.SysCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CatCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.OfficerCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.StatusCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.DateEffect).HasColumnType("datetime");

                entity.Property(e => e.CountryCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.DateRemove).HasColumnType("datetime");

                entity.Property(e => e.DtgrefEffect)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DTGRefEffect");

                entity.Property(e => e.DtgrefRemove)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DTGRefRemove");

                entity.Property(e => e.PayMonth)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.PunishDays).HasColumnType("numeric(6, 2)");

                entity.Property(e => e.Reason)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.RemarkEffect)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.RemarkRemove)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Trorder)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.StatusCodeNavigation)
                    .WithMany(p => p.PayStatusDetails)
                    .HasForeignKey(d => d.StatusCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Pay_StatusDetail_Pay_Status");

                entity.HasOne(d => d.PayPerInfo)
                    .WithMany(p => p.PayStatusDetails)
                    .HasForeignKey(d => new { d.SysCode, d.CatCode, d.OfficerCode })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Pay_StatusDetail_Pay_PerInfo");
            });

            modelBuilder.Entity<PaySysCategory>(entity =>
            {
                entity.HasKey(e => e.SysCode);

                entity.ToTable("Pay_SysCategory", "SLIS_Pay");

                entity.Property(e => e.SysCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.SysCatName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'Data Not Entered')");

                entity.Property(e => e.SysType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<PaySysSetup>(entity =>
            {
                entity.HasKey(e => e.SysCode)
                    .HasName("PK_SysSetup");

                entity.ToTable("Pay_SysSetup", "SLIS_Pay");

                entity.Property(e => e.SysCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.AccNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Address)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.BankAddress)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.BankCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BranchCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cfcoins).HasColumnName("CFCoins");

                entity.Property(e => e.CfminusPay).HasColumnName("CFMinusPay");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NextOfficerCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Tel)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.SysCodeNavigation)
                    .WithOne(p => p.PaySysSetup)
                    .HasForeignKey<PaySysSetup>(d => d.SysCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Pay_SysSetup_Pay_SysCategory");
            });

            modelBuilder.Entity<PayTax>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Pay_Tax", "SLIS_Pay");

                entity.Property(e => e.TableName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Table_Name");

                entity.Property(e => e.TableNo)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("Table_NO");
            });

            modelBuilder.Entity<PayTaxTable>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Pay_TaxTable", "SLIS_Pay");

                entity.Property(e => e.Above).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Amount).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.FormTax)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("Form_Tax");

                entity.Property(e => e.PayType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Pay_type")
                    .IsFixedLength();

                entity.Property(e => e.PerRate)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("Per_Rate");

                entity.Property(e => e.SubTableNo).HasColumnName("SubTable_no");

                entity.Property(e => e.TableNo)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("Table_NO");

                entity.Property(e => e.ToTax)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("To_tax");
            });

            modelBuilder.Entity<PayViewRptSelectNoOfPersonPayslip>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pay_VIEW_Rpt_Select_NoOfPerson_Payslip", "SLIS_Pay");

                entity.Property(e => e.Area)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.AreaName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BaseCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.BaseName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Syscode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("SYSCODE");
            });

            modelBuilder.Entity<PayViewRptSelectSalaryReturn>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pay_view_Rpt_Select_SalaryReturns", "SLIS_Pay");

                entity.Property(e => e.Amount).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Basecode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Basename)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BASENAME");

                entity.Property(e => e.CatCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Initials)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.OfficerCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.PayMonth)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.ReturnMonth)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SalaryMonth)
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.Surname)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.SysCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PayVwBankdetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pay_Vw_bankdetails", "SLIS_Pay");

                entity.Property(e => e.Accno)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.AmtToSend).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.BankCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.BankName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BranchCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.BranchName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CatCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.OfficerCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.SysCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PayVwBoderLine>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pay_Vw_BoderLines", "SLIS_Pay");

                entity.Property(e => e.Code)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Line)
                    .HasMaxLength(6)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PayVwFinalPayAllowance>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pay_Vw_FInalPayAllowance", "SLIS_Pay");

                entity.Property(e => e.Amount).HasColumnType("numeric(38, 2)");

                entity.Property(e => e.Catcode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.GroupItemCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.GroupName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Officercode)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("officercode");

                entity.Property(e => e.Syscode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("syscode");
            });

            modelBuilder.Entity<PayVwFinalPayDeduction>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pay_Vw_FInalPayDeduction", "SLIS_Pay");

                entity.Property(e => e.Amount).HasColumnType("numeric(38, 2)");

                entity.Property(e => e.Catcode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.GroupItemCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.GroupName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Officercode)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("officercode");

                entity.Property(e => e.Syscode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("syscode");
            });

            modelBuilder.Entity<PayVwPensionSetup>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pay_Vw_PensionSetup", "SLIS_Pay");

                entity.Property(e => e.CatCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CatName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DepAgeLimitFemale).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.DepAgeLimitMale).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.DepAmountFemaleA).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.DepAmountFemaleB).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.DepAmountMaleA).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.DepAmountMaleB).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.GrReductionPerc).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.GrReductionYears).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.MinServiceLimit).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.SpecialAmountA).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.SpecialAmountB).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.WidowPensionPerc).HasColumnType("numeric(18, 2)");
            });

            modelBuilder.Entity<PayVwPreProcessErrList>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pay_Vw_PreProcessErrList", "SLIS_Pay");

                entity.Property(e => e.CatCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.ErrDesc)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FullName)
                    .HasMaxLength(77)
                    .IsUnicode(false);

                entity.Property(e => e.ItemCategory)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ItemCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.OfficerCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.SysCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PayVwPromosion>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pay_Vw_Promosion", "SLIS_Pay");

                entity.Property(e => e.Catcode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("catcode");

                entity.Property(e => e.Fromdate)
                    .HasColumnType("datetime")
                    .HasColumnName("fromdate");

                entity.Property(e => e.Officercode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("officercode");

                entity.Property(e => e.Rankcode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("rankcode");

                entity.Property(e => e.Rankname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("rankname");

                entity.Property(e => e.Syscode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("syscode");

                entity.Property(e => e.Todate)
                    .HasColumnType("datetime")
                    .HasColumnName("todate");
            });

            modelBuilder.Entity<PayVwRptAdvanceAccount>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pay_Vw_Rpt_AdvanceAccount", "SLIS_Pay");

                entity.Property(e => e.Accno)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Amount).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.BankCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.BankName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BranchCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.BranchName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CatCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.ItemCategory)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ItemCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.ItemGroup)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ItemName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Mname)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.OfficerCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.RankName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SysCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<PayVwRptAdvanceAccount40Per>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pay_Vw_Rpt_AdvanceAccount40Per", "SLIS_Pay");

                entity.Property(e => e.BalanceLoanAmt)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("balanceLoanAmt");

                entity.Property(e => e.Bankloan).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CatCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Grosspay).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.LnternalLoan).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Mname)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.OfficerCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Per40)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("per40");

                entity.Property(e => e.Rankname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("rankname");

                entity.Property(e => e.SysCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PayVwRptAutoIncrement>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pay_VW_RPT_AutoINCREMENT", "SLIS_Pay");

                entity.Property(e => e.Arreas).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Bsalary)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("BSalary");

                entity.Property(e => e.Catcode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("CATCODE");

                entity.Property(e => e.DateConfirm).HasColumnType("datetime");

                entity.Property(e => e.DateEffect).HasColumnType("datetime");

                entity.Property(e => e.Increment).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Ip)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("IP")
                    .IsFixedLength();

                entity.Property(e => e.Name)
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .HasColumnName("NAME");

                entity.Property(e => e.NewRankCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("newRankCode");

                entity.Property(e => e.NewRankStage).HasColumnName("newRankStage");

                entity.Property(e => e.Officercode)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("OFFICERCODE");

                entity.Property(e => e.RankGroup)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Rankcode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.RefCode).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Syscode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("SYSCODE");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<PayVwRptAutoIncrementConfirm>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pay_VW_RPT_AutoINCREMENT_Confirm", "SLIS_Pay");

                entity.Property(e => e.Arreas).HasColumnType("numeric(19, 2)");

                entity.Property(e => e.Bsalary)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("BSalary");

                entity.Property(e => e.Catcode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("CATCODE");

                entity.Property(e => e.DateConfirm).HasColumnType("datetime");

                entity.Property(e => e.EffectDate).HasColumnType("datetime");

                entity.Property(e => e.Increment).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Name)
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .HasColumnName("NAME");

                entity.Property(e => e.NewRankCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("newRankCode");

                entity.Property(e => e.NewRankStage).HasColumnName("newRankStage");

                entity.Property(e => e.Officercode)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("OFFICERCODE");

                entity.Property(e => e.RankGroup)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Syscode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("SYSCODE");
            });

            modelBuilder.Entity<PayVwRptBankAdvice>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pay_Vw_Rpt_BankAdvice", "SLIS_Pay");

                entity.Property(e => e.AccNo)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.AmtToSend).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.BankCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.BankName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BarnchCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.BranchName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Desc1).HasMaxLength(200);

                entity.Property(e => e.Desc2).HasMaxLength(200);

                entity.Property(e => e.Desc3).HasMaxLength(200);

                entity.Property(e => e.Desc4).HasMaxLength(200);

                entity.Property(e => e.Desc5).HasMaxLength(200);

                entity.Property(e => e.Etrans).HasColumnName("ETrans");

                entity.Property(e => e.Name)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.OfficerCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.SysCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Year)
                    .HasMaxLength(4)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PayVwRptBankAdviceFinalpay>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pay_Vw_Rpt_BankAdviceFinalpay", "SLIS_Pay");

                entity.Property(e => e.AccNo)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.AmtToSend).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.BankCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.BankName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BranchCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.BranchName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Desc1).HasMaxLength(200);

                entity.Property(e => e.Desc2).HasMaxLength(200);

                entity.Property(e => e.Desc3).HasMaxLength(200);

                entity.Property(e => e.Desc4).HasMaxLength(200);

                entity.Property(e => e.Desc5).HasMaxLength(200);

                entity.Property(e => e.Etrans).HasColumnName("ETrans");

                entity.Property(e => e.Name)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.OfficerCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.SysCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Year)
                    .HasMaxLength(4)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PayVwRptBankAdviseSetup>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pay_Vw_Rpt_BankAdviseSetup", "SLIS_Pay");

                entity.Property(e => e.Desc1).HasMaxLength(200);

                entity.Property(e => e.Desc2).HasMaxLength(200);

                entity.Property(e => e.Desc3).HasMaxLength(200);

                entity.Property(e => e.Desc4).HasMaxLength(200);

                entity.Property(e => e.Desc5).HasMaxLength(200);
            });

            modelBuilder.Entity<PayVwRptBankDeductionsAmount>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pay_Vw_Rpt_BankDeductionsAmount", "SLIS_Pay");

                entity.Property(e => e.Amount).HasColumnType("numeric(38, 2)");

                entity.Property(e => e.BankAccountNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BankCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.BankDeductionCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.BankDeductionName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BranchCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.ItemCategory)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ItemCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Syscode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("SYSCODE");

                entity.Property(e => e.TransactionCode)
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PayVwRptBankDeductionsAmountTextFile>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pay_Vw_Rpt_BankDeductionsAmountTextFile", "SLIS_Pay");

                entity.Property(e => e.Amount).HasColumnType("numeric(38, 2)");

                entity.Property(e => e.BankAccountNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BankCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.BankDeductionCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.BankDeductionName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BranchCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.ItemCategory)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Syscode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("SYSCODE");

                entity.Property(e => e.TransactionCode)
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PayVwRptBankDeductionsAmountTextFile2>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pay_Vw_Rpt_BankDeductionsAmountTextFile2", "SLIS_Pay");

                entity.Property(e => e.Amount).HasColumnType("numeric(38, 2)");

                entity.Property(e => e.BankAccountNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BankCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.BankDeductionCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.BankDeductionName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BranchCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Syscode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("SYSCODE");

                entity.Property(e => e.TransactionCode)
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PayVwRptBankRemitanceBreakDown>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pay_VW_RPT_BankRemitanceBreakDown", "SLIS_Pay");

                entity.Property(e => e.Amt).HasColumnType("numeric(38, 2)");

                entity.Property(e => e.Description)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.SysCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PayVwRptBankSummary>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pay_Vw_Rpt_BankSummary", "SLIS_Pay");

                entity.Property(e => e.Amount).HasColumnType("numeric(38, 2)");

                entity.Property(e => e.BankCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.BankName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BranchCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.BranchName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Etrans).HasColumnName("ETrans");

                entity.Property(e => e.NoOfPersons).HasColumnName("No Of Persons");

                entity.Property(e => e.SysCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PayVwRptBankSummaryAreawise>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pay_Vw_Rpt_BankSummary_Areawise", "SLIS_Pay");

                entity.Property(e => e.Amount).HasColumnType("numeric(38, 2)");

                entity.Property(e => e.AreaName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Areacode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.BankCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.BankName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BranchCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.BranchName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Etrans).HasColumnName("ETrans");

                entity.Property(e => e.NoOfPersons).HasColumnName("No Of Persons");

                entity.Property(e => e.SysCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PayVwRptBankSummaryBasewise>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pay_Vw_Rpt_BankSummary_Basewise", "SLIS_Pay");

                entity.Property(e => e.Amount).HasColumnType("numeric(38, 2)");

                entity.Property(e => e.BankCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.BankName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BaseName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Basecode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.BranchCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.BranchName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Etrans).HasColumnName("ETrans");

                entity.Property(e => e.NoOfPersons).HasColumnName("No Of Persons");

                entity.Property(e => e.SysCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PayVwRptBankSummaryFinalPay>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pay_Vw_Rpt_BankSummaryFinalPay", "SLIS_Pay");

                entity.Property(e => e.Amount).HasColumnType("numeric(38, 2)");

                entity.Property(e => e.BankCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.BankName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BranchCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.BranchName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Etrans).HasColumnName("ETrans");

                entity.Property(e => e.NoOfPersons).HasColumnName("No Of Persons");

                entity.Property(e => e.SysCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PayVwRptBasewisePaySummary>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pay_VW_Rpt_BasewisePaySummary", "SLIS_Pay");

                entity.Property(e => e.BaseCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.BaseName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Consol)
                    .HasColumnType("numeric(38, 2)")
                    .HasColumnName("consol");

                entity.Property(e => e.Fixall)
                    .HasColumnType("numeric(38, 2)")
                    .HasColumnName("fixall");

                entity.Property(e => e.Fixdeduct)
                    .HasColumnType("numeric(38, 2)")
                    .HasColumnName("fixdeduct");

                entity.Property(e => e.Gross).HasColumnType("numeric(38, 2)");

                entity.Property(e => e.NetSalary).HasColumnType("numeric(38, 2)");

                entity.Property(e => e.Noofperson).HasColumnName("noofperson");

                entity.Property(e => e.Varall)
                    .HasColumnType("numeric(38, 2)")
                    .HasColumnName("varall");

                entity.Property(e => e.Vardeduct)
                    .HasColumnType("numeric(38, 2)")
                    .HasColumnName("vardeduct");
            });

            modelBuilder.Entity<PayVwRptComplementList>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pay_VW_RPT_ComplementList", "SLIS_Pay");

                entity.Property(e => e.Basecode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("basecode");

                entity.Property(e => e.Basename)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("basename");

                entity.Property(e => e.BranchCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Catcode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("catcode");

                entity.Property(e => e.Initials)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("initials");

                entity.Property(e => e.Officercode)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("officercode");

                entity.Property(e => e.Rankname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("rankname");

                entity.Property(e => e.Surname)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("surname");

                entity.Property(e => e.Syscode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("syscode");
            });

            modelBuilder.Entity<PayVwRptDepartmentPayLoanReport>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pay_VW_Rpt_DepartmentPay_LoanReport", "SLIS_Pay");

                entity.Property(e => e.AddressSin)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Amount)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("amount");

                entity.Property(e => e.Amt)
                    .HasColumnType("numeric(38, 2)")
                    .HasColumnName("AMT");

                entity.Property(e => e.BankAccountNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BankCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.BankDeductionName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BranchCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Catcode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("catcode");

                entity.Property(e => e.CurMonth)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.FullNameSin)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.GroupCategory)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.GroupItemCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.IntnameSin)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("INTNameSin");

                entity.Property(e => e.ItemCategory)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ItemCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Nicnumber)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("NICNumber");

                entity.Property(e => e.OfficerCodeSin)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Officercode)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("officercode");

                entity.Property(e => e.RankCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.RankNameSin)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Syscode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("syscode");
            });

            modelBuilder.Entity<PayVwRptDepartmentPayReport>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pay_VW_Rpt_DepartmentPayReport", "SLIS_Pay");

                entity.Property(e => e.AddressSin)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Amount)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("amount");

                entity.Property(e => e.Amt)
                    .HasColumnType("numeric(38, 2)")
                    .HasColumnName("AMT");

                entity.Property(e => e.BankAccountNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BankCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.BankDeductionName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BranchCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Catcode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("catcode");

                entity.Property(e => e.CurMonth)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.FullNameSin)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.GroupCategory)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.GroupItemCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.IntnameSin)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("INTNameSin");

                entity.Property(e => e.ItemCategory)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ItemCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.OfficerCodeSin)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Officercode)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("officercode");

                entity.Property(e => e.RankCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.RankNameSin)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Syscode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("syscode");
            });

            modelBuilder.Entity<PayVwRptDibankloanAccount>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pay_Vw_Rpt_DIBankloanAccount", "SLIS_Pay");

                entity.Property(e => e.Accno)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("accno");

                entity.Property(e => e.AmtToSend).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.BankName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Bankcode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("bankcode");

                entity.Property(e => e.BarnchCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.BranchName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Catcode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("catcode");

                entity.Property(e => e.DepnId)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("DepnID");

                entity.Property(e => e.Dmane)
                    .HasMaxLength(65)
                    .IsUnicode(false);

                entity.Property(e => e.Mname)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Officercode)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("officercode");

                entity.Property(e => e.RankName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Syscode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("syscode");
            });

            modelBuilder.Entity<PayVwRptDiletter>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pay_VW_Rpt_DILetter", "SLIS_Pay");

                entity.Property(e => e.Accno)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.AddressD)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.AddressSinD)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Amttosend).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Bankcode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Bankname)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Barnchcode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.BranchName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Catcode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("catcode");

                entity.Property(e => e.CurMonth)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Depnid)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.FullName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.FullNameSin)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.FullNameSinD)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.InitialsD)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.OfficerCodeSin)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Officercode)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("officercode");

                entity.Property(e => e.PerOfSalary).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.RankNameSin)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SurName)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.SurnameD)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Syscode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("syscode");
            });

            modelBuilder.Entity<PayVwRptIncrement>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pay_VW_RPT_INCREMENT", "SLIS_Pay");

                entity.Property(e => e.Bsalary)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("BSALARY");

                entity.Property(e => e.Catcode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("CATCODE");

                entity.Property(e => e.Curmonthincr)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("CURMONTHINCR");

                entity.Property(e => e.Dateeffect)
                    .HasColumnType("datetime")
                    .HasColumnName("DATEEFFECT");

                entity.Property(e => e.Frankcode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("FRANKCODE");

                entity.Property(e => e.Frankstage).HasColumnName("FRANKSTAGE");

                entity.Property(e => e.Increment)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("INCREMENT");

                entity.Property(e => e.Name)
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .HasColumnName("NAME");

                entity.Property(e => e.Officercode)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("OFFICERCODE");

                entity.Property(e => e.Rankcode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("RANKCODE");

                entity.Property(e => e.Rankgroup)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("RANKGROUP");

                entity.Property(e => e.Rankstage).HasColumnName("RANKSTAGE");

                entity.Property(e => e.Syscode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("SYSCODE");

                entity.Property(e => e.TrNo)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("TR_NO");

                entity.Property(e => e.Userid).HasColumnName("USERID");
            });

            modelBuilder.Entity<PayVwRptIncrementConfirmPendingList>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pay_Vw_Rpt_IncrementConfirmPendingList", "SLIS_Pay");

                entity.Property(e => e.Bsalary)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("BSalary");

                entity.Property(e => e.CatCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Datauser)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.DateJoin).HasColumnType("datetime");

                entity.Property(e => e.Increment).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.OfficerCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.SysCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<PayVwRptIncrementDuplicateList>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pay_Vw_Rpt_IncrementDuplicateList", "SLIS_Pay");

                entity.Property(e => e.CatCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Mname)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.OfficerCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.SysCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PayVwRptListAllowence>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pay_Vw_Rpt_ListAllowence", "SLIS_Pay");

                entity.Property(e => e.AccVo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ArePayCat)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ArePayCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Bank)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Branch)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Category)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Cheque)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.GrossPay)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ItemCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NoPay)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Rate).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Type)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Wop)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("WOP");
            });

            modelBuilder.Entity<PayVwRptListAppointment>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pay_Vw_Rpt_ListAppointment", "SLIS_Pay");

                entity.Property(e => e.Code)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PayVwRptListArear>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pay_Vw_Rpt_ListArears", "SLIS_Pay");

                entity.Property(e => e.Code)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PayVwRptListBank>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pay_Vw_Rpt_ListBanks", "SLIS_Pay");

                entity.Property(e => e.Code)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Descr)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PayVwRptListBankAccountsTransaction>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pay_Vw_Rpt_ListBankAccounts_transaction", "SLIS_Pay");

                entity.Property(e => e.AccCat)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AccNo)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Amount).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.BankCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.BranchCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CatCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.DepnId)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("DepnID");

                entity.Property(e => e.LoanAmt).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Mdepname)
                    .HasMaxLength(65)
                    .IsUnicode(false)
                    .HasColumnName("MDepname");

                entity.Property(e => e.Mname)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("MNAME");

                entity.Property(e => e.Mtype)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.OfficerCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.PayMonth).HasColumnType("datetime");

                entity.Property(e => e.Remark)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SysCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PayVwRptListBankAdvice>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pay_Vw_Rpt_ListBankAdvice", "SLIS_Pay");

                entity.Property(e => e.AccNo)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Amount).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.BankCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.BankName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BarnchCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.BranchName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CatCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.OfficerCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.SysCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PayVwRptListBankBran>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pay_Vw_Rpt_ListBankBran", "SLIS_Pay");

                entity.Property(e => e.BankCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.BankName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BranCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.BranName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PayVwRptListBaseVitit>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pay_Vw_Rpt_ListBaseVitit", "SLIS_Pay");

                entity.Property(e => e.BaseCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.BaseSubCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Basename)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BASENAME");

                entity.Property(e => e.CatCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.DisitDateTo).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("NAME");

                entity.Property(e => e.OfficerCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.OldBaseCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Oldbasename)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OLDBASENAME");

                entity.Property(e => e.PayMonth)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Signal)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SysCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Torder).HasColumnName("TORDER");

                entity.Property(e => e.Userid).HasColumnName("userid");

                entity.Property(e => e.VisitDateFrom).HasColumnType("datetime");
            });

            modelBuilder.Entity<PayVwRptListBasis>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pay_Vw_Rpt_ListBases", "SLIS_Pay");

                entity.Property(e => e.Acode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("ACode");

                entity.Property(e => e.Active)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Aname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AName");

                entity.Property(e => e.ArtiArea)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.BaseNameSin)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Bcode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("BCode");

                entity.Property(e => e.Bname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BName");

                entity.Property(e => e.RiskArea)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Ship)
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PayVwRptListBranch>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pay_Vw_Rpt_ListBranches", "SLIS_Pay");

                entity.Property(e => e.Bcode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("BCode");

                entity.Property(e => e.Bname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BName");

                entity.Property(e => e.CatName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ccode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("CCode");
            });

            modelBuilder.Entity<PayVwRptListCalander>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pay_Vw_Rpt_ListCalander", "SLIS_Pay");

                entity.Property(e => e.BaseName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Basecode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.C735)
                    .HasColumnType("numeric(38, 2)")
                    .HasColumnName("c735");

                entity.Property(e => e.C735A)
                    .HasColumnType("numeric(38, 2)")
                    .HasColumnName("c735A");

                entity.Property(e => e.C763).HasColumnType("numeric(38, 2)");

                entity.Property(e => e.C841)
                    .HasColumnType("numeric(38, 2)")
                    .HasColumnName("c841");

                entity.Property(e => e.C872)
                    .HasColumnType("numeric(38, 2)")
                    .HasColumnName("c872");

                entity.Property(e => e.C884)
                    .HasColumnType("numeric(38, 2)")
                    .HasColumnName("c884");

                entity.Property(e => e.C963)
                    .HasColumnType("numeric(38, 2)")
                    .HasColumnName("c963");

                entity.Property(e => e.C963A)
                    .HasColumnType("numeric(38, 2)")
                    .HasColumnName("c963A");

                entity.Property(e => e.CatCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.OfficerCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.SysCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PayVwRptListCategory>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pay_Vw_Rpt_ListCategory", "SLIS_Pay");

                entity.Property(e => e.Code)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Descr)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SalDisAmnt).HasColumnType("numeric(18, 2)");
            });

            modelBuilder.Entity<PayVwRptListCountry>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pay_Vw_Rpt_ListCountries", "SLIS_Pay");

                entity.Property(e => e.Code)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Descr)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ExRate).HasColumnType("numeric(18, 2)");
            });

            modelBuilder.Entity<PayVwRptListDeduction>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pay_Vw_Rpt_ListDeductions", "SLIS_Pay");

                entity.Property(e => e.AccVo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ArePayCat)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ArePayCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Bank)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Branch)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Category)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Cheque)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.GrossPay)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ItemCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NoPay)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Rate).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Type)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Wop)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("WOP");
            });

            modelBuilder.Entity<PayVwRptListDepnType>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pay_Vw_Rpt_ListDepnTypes", "SLIS_Pay");

                entity.Property(e => e.Code)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Descr)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PayVwRptListDisHardRationOfficer>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pay_Vw_Rpt_List_DisHardRationOfficers", "SLIS_Pay");

                entity.Property(e => e.A601).HasColumnType("numeric(38, 2)");

                entity.Property(e => e.A602).HasColumnType("numeric(38, 2)");

                entity.Property(e => e.A603).HasColumnType("numeric(38, 2)");

                entity.Property(e => e.A604).HasColumnType("numeric(38, 2)");

                entity.Property(e => e.BaseCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.BaseName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.C601)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.C602)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.C603)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.C604)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Catcode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("catcode");

                entity.Property(e => e.Name)
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .HasColumnName("NAME");

                entity.Property(e => e.Officercode)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("officercode");

                entity.Property(e => e.Syscode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("syscode");

                entity.Property(e => e.U601).HasColumnType("numeric(38, 2)");

                entity.Property(e => e.U602).HasColumnType("numeric(38, 2)");

                entity.Property(e => e.U603).HasColumnType("numeric(38, 2)");

                entity.Property(e => e.U604).HasColumnType("numeric(38, 2)");
            });

            modelBuilder.Entity<PayVwRptListDisHardRationSailor>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pay_Vw_Rpt_List_DisHardRationSailor", "SLIS_Pay");

                entity.Property(e => e.A601).HasColumnType("numeric(38, 2)");

                entity.Property(e => e.A602).HasColumnType("numeric(38, 2)");

                entity.Property(e => e.A603).HasColumnType("numeric(38, 2)");

                entity.Property(e => e.A604).HasColumnType("numeric(38, 2)");

                entity.Property(e => e.BaseCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.BaseName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.C601)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.C602)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.C603)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.C604)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Catcode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("catcode");

                entity.Property(e => e.Name)
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .HasColumnName("NAME");

                entity.Property(e => e.Officercode)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("officercode");

                entity.Property(e => e.Syscode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("syscode");

                entity.Property(e => e.U601).HasColumnType("numeric(38, 2)");

                entity.Property(e => e.U602).HasColumnType("numeric(38, 2)");

                entity.Property(e => e.U603).HasColumnType("numeric(38, 2)");

                entity.Property(e => e.U604).HasColumnType("numeric(38, 2)");
            });

            modelBuilder.Entity<PayVwRptListEmpBankAccount>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pay_Vw_Rpt_ListEmpBankAccounts", "SLIS_Pay");

                entity.Property(e => e.AccCat)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AccNo)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Active)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Amount).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.BankCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.BankName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BranchCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.BranchName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CatCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.DepnId)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("DepnID");

                entity.Property(e => e.LoanAcc)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.LoanAmt).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Name)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.OfficerCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.PayMonth).HasColumnType("datetime");

                entity.Property(e => e.Remark)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SysCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Trorder)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<PayVwRptListEmpBasicSal>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pay_Vw_Rpt_ListEmpBasicSal", "SLIS_Pay");

                entity.Property(e => e.Bsalary)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("BSalary");

                entity.Property(e => e.CatCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CatName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FullName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(76)
                    .IsUnicode(false);

                entity.Property(e => e.OfficerCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.RankCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.RankName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SysCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.SysName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PayVwRptListEmpDepenProfile>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pay_Vw_Rpt_ListEmpDepenProfile", "SLIS_Pay");

                entity.Property(e => e.Address)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.AddressSin)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.CatCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.DateBirth).HasColumnType("datetime");

                entity.Property(e => e.DepnId)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("DepnID");

                entity.Property(e => e.DepnTypeCode)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.FullNameSin)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Nicno)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("NICNo");

                entity.Property(e => e.OfficerCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.PerOfSalary).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Picture).HasColumnType("image");

                entity.Property(e => e.Surname)
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.SysCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Telephone)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.WOp).HasColumnName("W_OP");
            });

            modelBuilder.Entity<PayVwRptListEmpGrpPayItem>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pay_Vw_Rpt_ListEmpGrpPayItems", "SLIS_Pay");

                entity.Property(e => e.CatCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.EmpName)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.ItemCategory)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ItemCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.ItemName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OfficerCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.SysCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PayVwRptListEmployeeProfile>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pay_Vw_Rpt_ListEmployeeProfile", "SLIS_Pay");

                entity.Property(e => e.AddressSin)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.BaseCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.BaseName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BranchCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Branchname)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Bsalary)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("BSalary");

                entity.Property(e => e.CatCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CatName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CivilStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DateBirth).HasColumnType("datetime");

                entity.Property(e => e.DateConfirmed).HasColumnType("datetime");

                entity.Property(e => e.DateJoin).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EMail");

                entity.Property(e => e.Fax)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.FullName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.FullNameSin)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Gender)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Name)
                    .HasMaxLength(81)
                    .IsUnicode(false);

                entity.Property(e => e.NavyId)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("NavyID");

                entity.Property(e => e.NavyIdsin)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("NavyIDSin");

                entity.Property(e => e.Nicnumber)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("NICNumber");

                entity.Property(e => e.NkinAdd)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("NKinAdd");

                entity.Property(e => e.NkinBaseCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("NKinBaseCode");

                entity.Property(e => e.NkinBaseSubCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("NKinBaseSubCode");

                entity.Property(e => e.NkinName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("NKinName");

                entity.Property(e => e.NkinRelation)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NKinRelation");

                entity.Property(e => e.OfficerCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.OfficerCodeSin)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.OtherAdd)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PermanentAdd)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Picture).HasColumnType("image");

                entity.Property(e => e.RankCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.RankName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReEngPay).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.ReligCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.SalDispAmt).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.SubUnitCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.SysCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.SysName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Tel)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.WOp).HasColumnName("W_OP");
            });

            modelBuilder.Entity<PayVwRptListGcbtype>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pay_Vw_Rpt_ListGCBTypes", "SLIS_Pay");

                entity.Property(e => e.Amount).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Code)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Descr)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PayVwRptListLeaveType>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pay_Vw_Rpt_ListLeaveTypes", "SLIS_Pay");

                entity.Property(e => e.Code)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Descr)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PayVwRptListLoan>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pay_Vw_Rpt_ListLoans", "SLIS_Pay");

                entity.Property(e => e.AccVo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ArePayCat)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ArePayCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Bank)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Branch)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Category)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Cheque)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.GrossPay)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ItemCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NoPay)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Rate).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Type)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Wop)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("WOP");
            });

            modelBuilder.Entity<PayVwRptListLoanRegister>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pay_Vw_Rpt_ListLoanRegister", "SLIS_Pay");

                entity.Property(e => e.BaseCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Item)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.ItemName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LoanAmount).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.LoanDate).HasColumnType("datetime");

                entity.Property(e => e.MonthInstall).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Name)
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.NoInstall).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.OfficerCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.RecAmount).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.SysCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PayVwRptListOvsReason>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pay_Vw_Rpt_ListOvsReason", "SLIS_Pay");

                entity.Property(e => e.Code)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Descr)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PayVwRptListPaymentAnalysis>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pay_Vw_Rpt_ListPaymentAnalysis", "SLIS_Pay");

                entity.Property(e => e.AccNo)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.AmtToSend).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.BankCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.BankName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BranchCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.BranchName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CatCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Initials)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.LoanAmt).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.OfficerCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.SurName)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.SysCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PayVwRptListQpayType>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pay_Vw_Rpt_ListQPayTypes", "SLIS_Pay");

                entity.Property(e => e.Amount).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Code)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Descr)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PayVwRptListRank>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pay_Vw_Rpt_ListRanks", "SLIS_Pay");

                entity.Property(e => e.CatCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CatName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RankCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.RankName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SinName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StartSal).HasColumnType("numeric(18, 2)");
            });

            modelBuilder.Entity<PayVwRptListReligion>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pay_Vw_Rpt_ListReligions", "SLIS_Pay");

                entity.Property(e => e.Code)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Descr)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PayVwRptListStatus>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pay_Vw_Rpt_ListStatus", "SLIS_Pay");

                entity.Property(e => e.Code)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Descr)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PayVwRptListSubUnit>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pay_Vw_Rpt_ListSubUnits", "SLIS_Pay");

                entity.Property(e => e.Active)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Bcode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("BCode");

                entity.Property(e => e.Bname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BName");

                entity.Property(e => e.RiskArea)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Scode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("SCode");

                entity.Property(e => e.Ship)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Sname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SName");
            });

            modelBuilder.Entity<PayVwRptListSysCategory>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pay_Vw_Rpt_ListSysCategory", "SLIS_Pay");

                entity.Property(e => e.Code)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PayVwRptListTotalSalaryCashPayment>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pay_Vw_Rpt_ListTotalSalaryCashPayment", "SLIS_Pay");

                entity.Property(e => e.Area)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.BaseCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Basename)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cashpay).HasColumnType("numeric(38, 2)");

                entity.Property(e => e.CatCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Initials)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OfficerCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.SubUnitCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.SurName)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.SysCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Unpaid)
                    .HasColumnType("numeric(38, 2)")
                    .HasColumnName("unpaid");
            });

            modelBuilder.Entity<PayVwRptListWoprate>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pay_Vw_Rpt_ListWOPRates", "SLIS_Pay");

                entity.Property(e => e.EffectDate).HasColumnType("datetime");

                entity.Property(e => e.Rate).HasColumnType("numeric(18, 2)");
            });

            modelBuilder.Entity<PayVwRptMonBankSumm>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pay_Vw_Rpt_MonBankSumm", "SLIS_Pay");

                entity.Property(e => e.Amnt).HasColumnType("numeric(38, 2)");

                entity.Property(e => e.AreaCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.AreaName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BankCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.BankName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BaseCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.BaseName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CatCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("catCode");

                entity.Property(e => e.Syscode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("syscode");
            });

            modelBuilder.Entity<PayVwRptMonBankSummArea>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pay_Vw_Rpt_MonBankSummArea", "SLIS_Pay");

                entity.Property(e => e.Amnt).HasColumnType("numeric(38, 2)");

                entity.Property(e => e.AreaCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.AreaName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BankCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.BankName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Offcode).HasColumnName("offcode");
            });

            modelBuilder.Entity<PayVwRptMonBranchSumm>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pay_Vw_Rpt_MonBranchSumm", "SLIS_Pay");

                entity.Property(e => e.Amnt).HasColumnType("numeric(38, 2)");

                entity.Property(e => e.AreaCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.AreaName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BankCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.BankName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BaseCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.BaseName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BranchCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.BranchName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CatCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("catCode");

                entity.Property(e => e.Syscode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("syscode");
            });

            modelBuilder.Entity<PayVwRptMonBranchSummArea>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pay_Vw_Rpt_MonBranchSummArea", "SLIS_Pay");

                entity.Property(e => e.Amnt).HasColumnType("numeric(38, 2)");

                entity.Property(e => e.AreaCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.AreaName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BankName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Bankcode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.BranchCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.BranchName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Offcode).HasColumnName("offcode");
            });

            modelBuilder.Entity<PayVwRptMonBranchSummBase>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pay_Vw_Rpt_MonBranchSummBase", "SLIS_Pay");

                entity.Property(e => e.Amnt).HasColumnType("numeric(38, 2)");

                entity.Property(e => e.BankName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Bankcode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.BaseCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.BaseName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BranchCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.BranchName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Offcode).HasColumnName("offcode");
            });

            modelBuilder.Entity<PayVwRptMonCoinAnnArea>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pay_Vw_Rpt_MonCoinAnnArea", "SLIS_Pay");

                entity.Property(e => e.Amount).HasColumnType("numeric(38, 2)");

                entity.Property(e => e.Area)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Areaname)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BaseCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.BaseName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Mmonth).HasColumnName("MMonth");

                entity.Property(e => e.Myear)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("MYear");
            });

            modelBuilder.Entity<PayVwRptMonCoinAnnBase>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pay_Vw_Rpt_MonCoinAnnBase", "SLIS_Pay");

                entity.Property(e => e.Amount).HasColumnType("numeric(38, 2)");

                entity.Property(e => e.BaseCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.BaseName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Mmonth).HasColumnName("MMonth");

                entity.Property(e => e.Myear)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("MYear");
            });

            modelBuilder.Entity<PayVwRptMonPayRegArea>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pay_Vw_Rpt_MonPayRegArea", "SLIS_Pay");

                entity.Property(e => e.Amount).HasColumnType("numeric(38, 2)");

                entity.Property(e => e.AreaCode).HasMaxLength(10);

                entity.Property(e => e.AreaName).HasMaxLength(50);

                entity.Property(e => e.BaseCode).HasMaxLength(10);

                entity.Property(e => e.BaseName).HasMaxLength(50);

                entity.Property(e => e.ItemAltName).HasMaxLength(50);
            });

            modelBuilder.Entity<PayVwRptMonPayRegBase>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pay_Vw_Rpt_MonPayRegBase", "SLIS_Pay");

                entity.Property(e => e.Amount).HasColumnType("numeric(38, 2)");

                entity.Property(e => e.BaseName).HasMaxLength(50);

                entity.Property(e => e.Basecode).HasMaxLength(10);

                entity.Property(e => e.ItemAltName).HasMaxLength(50);

                entity.Property(e => e.OfficerCode).HasMaxLength(10);

                entity.Property(e => e.OfficerName).HasMaxLength(100);
            });

            modelBuilder.Entity<PayVwRptMonPayRegBranch>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pay_Vw_Rpt_MonPayRegBranch", "SLIS_Pay");

                entity.Property(e => e.Amount).HasColumnType("numeric(38, 2)");

                entity.Property(e => e.AreaCode).HasMaxLength(10);

                entity.Property(e => e.AreaName).HasMaxLength(50);

                entity.Property(e => e.BranchCode).HasMaxLength(10);

                entity.Property(e => e.BranchName).HasMaxLength(50);

                entity.Property(e => e.ItemAltName).HasMaxLength(50);
            });

            modelBuilder.Entity<PayVwRptMonPayRegOfficer>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pay_Vw_Rpt_MonPayRegOfficer", "SLIS_Pay");

                entity.Property(e => e.Amount).HasColumnType("numeric(38, 2)");

                entity.Property(e => e.ItemAltName).HasMaxLength(50);

                entity.Property(e => e.OfficerCode).HasMaxLength(10);

                entity.Property(e => e.OfficerName).HasMaxLength(100);
            });

            modelBuilder.Entity<PayVwRptMonPayRegRank>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pay_Vw_Rpt_MonPayRegRank", "SLIS_Pay");

                entity.Property(e => e.Amount).HasColumnType("numeric(38, 2)");

                entity.Property(e => e.ItemAltName).HasMaxLength(50);

                entity.Property(e => e.RankName).HasMaxLength(50);

                entity.Property(e => e.Rankcode).HasMaxLength(10);
            });

            modelBuilder.Entity<PayVwRptMonPayRegSubUnit>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pay_Vw_Rpt_MonPayRegSubUnit", "SLIS_Pay");

                entity.Property(e => e.Amount).HasColumnType("numeric(38, 2)");

                entity.Property(e => e.AreaCode).HasMaxLength(10);

                entity.Property(e => e.AreaName).HasMaxLength(50);

                entity.Property(e => e.ItemAltName).HasMaxLength(50);

                entity.Property(e => e.SubUnitCode).HasMaxLength(10);

                entity.Property(e => e.SubUnitName).HasMaxLength(50);
            });

            modelBuilder.Entity<PayVwRptMonPayRegister>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pay_Vw_Rpt_MonPayRegister", "SLIS_Pay");

                entity.Property(e => e.Amount).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.AreaCode).HasMaxLength(10);

                entity.Property(e => e.AreaName).HasMaxLength(50);

                entity.Property(e => e.BaseCode).HasMaxLength(10);

                entity.Property(e => e.BaseName).HasMaxLength(50);

                entity.Property(e => e.BranchCode).HasMaxLength(10);

                entity.Property(e => e.BranchName).HasMaxLength(50);

                entity.Property(e => e.CatCode).HasMaxLength(10);

                entity.Property(e => e.CatName).HasMaxLength(10);

                entity.Property(e => e.ItemAltName).HasMaxLength(50);

                entity.Property(e => e.ItemCategory).HasMaxLength(10);

                entity.Property(e => e.ItemCode).HasMaxLength(10);

                entity.Property(e => e.OfficerCode).HasMaxLength(10);

                entity.Property(e => e.OfficerName).HasMaxLength(100);

                entity.Property(e => e.RankCode).HasMaxLength(10);

                entity.Property(e => e.RankName).HasMaxLength(50);

                entity.Property(e => e.RowId).HasColumnName("RowID");

                entity.Property(e => e.SubUnitCode).HasMaxLength(10);

                entity.Property(e => e.SubUnitName).HasMaxLength(50);

                entity.Property(e => e.SysCatName).HasMaxLength(50);

                entity.Property(e => e.SysCode).HasMaxLength(10);
            });

            modelBuilder.Entity<PayVwRptMonPaySumm>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pay_Vw_Rpt_MonPaySumm", "SLIS_Pay");

                entity.Property(e => e.Amount).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.AreaCode).HasMaxLength(10);

                entity.Property(e => e.AreaName).HasMaxLength(50);

                entity.Property(e => e.BaseCode).HasMaxLength(10);

                entity.Property(e => e.BaseName).HasMaxLength(50);

                entity.Property(e => e.BranchCode).HasMaxLength(10);

                entity.Property(e => e.BranchName).HasMaxLength(50);

                entity.Property(e => e.CatCode).HasMaxLength(10);

                entity.Property(e => e.CatName).HasMaxLength(10);

                entity.Property(e => e.ItemAltName).HasMaxLength(50);

                entity.Property(e => e.ItemCategory).HasMaxLength(10);

                entity.Property(e => e.ItemCode).HasMaxLength(10);

                entity.Property(e => e.OfficerCode).HasMaxLength(10);

                entity.Property(e => e.OfficerName).HasMaxLength(100);

                entity.Property(e => e.RankCode).HasMaxLength(10);

                entity.Property(e => e.RankName).HasMaxLength(50);

                entity.Property(e => e.RowId).HasColumnName("RowID");

                entity.Property(e => e.SubUnitCode).HasMaxLength(10);

                entity.Property(e => e.SubUnitName).HasMaxLength(50);

                entity.Property(e => e.SysCatName).HasMaxLength(50);

                entity.Property(e => e.SysCode).HasMaxLength(10);
            });

            modelBuilder.Entity<PayVwRptMonPaySummary>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pay_Vw_Rpt_MonPaySummary", "SLIS_Pay");

                entity.Property(e => e.Amount).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.AreaCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.AreaName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BaseCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.BaseName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BranchCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.BranchName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CatCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CatName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ItemAltName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ItemCategory)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ItemCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.OfficerCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.OfficerName)
                    .HasMaxLength(76)
                    .IsUnicode(false);

                entity.Property(e => e.RankCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.RankName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RowId).HasColumnName("RowID");

                entity.Property(e => e.SubUnitCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.SubUnitName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SysCatName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SysCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PayVwRptMonSalRecon>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pay_Vw_Rpt_MonSalRecon", "SLIS_Pay");

                entity.Property(e => e.Amount).HasColumnType("numeric(38, 2)");

                entity.Property(e => e.Amt).HasColumnType("numeric(38, 2)");

                entity.Property(e => e.Area)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.AreaName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BaseName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Basecode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CatCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Category)
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.OfficerCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.OfficerfName)
                    .HasMaxLength(76)
                    .IsUnicode(false)
                    .HasColumnName("Officerf_Name");

                entity.Property(e => e.SysCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.YearMonth)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("Year_Month")
                    .IsFixedLength();
            });

            modelBuilder.Entity<PayVwRptMonSalReconDet>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pay_Vw_Rpt_MonSalReconDet", "SLIS_Pay");

                entity.Property(e => e.Amount).HasColumnType("numeric(38, 2)");

                entity.Property(e => e.Amt).HasColumnType("numeric(38, 2)");

                entity.Property(e => e.Area)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.BaseCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CatCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Category)
                    .HasMaxLength(28)
                    .IsUnicode(false);

                entity.Property(e => e.OfficerCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.OfficerfName)
                    .HasMaxLength(76)
                    .IsUnicode(false)
                    .HasColumnName("officerf_Name");

                entity.Property(e => e.SysCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.YearMonth)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("Year_Month")
                    .IsFixedLength();
            });

            modelBuilder.Entity<PayVwRptMonSalReconDetAll>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pay_Vw_Rpt_MonSalReconDetAll", "SLIS_Pay");

                entity.Property(e => e.Amount).HasColumnType("numeric(38, 2)");

                entity.Property(e => e.Amt).HasColumnType("numeric(38, 2)");

                entity.Property(e => e.Area)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.BaseCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CatCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Category)
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.OfficerCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.OfficerfName)
                    .HasMaxLength(76)
                    .IsUnicode(false)
                    .HasColumnName("officerf_Name");

                entity.Property(e => e.SysCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.YearMonth)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("Year_Month")
                    .IsFixedLength();
            });

            modelBuilder.Entity<PayVwRptMonSalReconDetSum>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pay_Vw_Rpt_MonSalReconDetSum", "SLIS_Pay");

                entity.Property(e => e.Amount).HasColumnType("numeric(38, 2)");

                entity.Property(e => e.Amt).HasColumnType("numeric(38, 2)");

                entity.Property(e => e.Area)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.BaseCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CatCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Category)
                    .HasMaxLength(28)
                    .IsUnicode(false);

                entity.Property(e => e.OfficerCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.OfficerfName)
                    .HasMaxLength(76)
                    .IsUnicode(false)
                    .HasColumnName("officerf_Name");

                entity.Property(e => e.SysCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.YearMonth)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("Year_Month")
                    .IsFixedLength();
            });

            modelBuilder.Entity<PayVwRptMonSalReconDetSumAll>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pay_Vw_Rpt_MonSalReconDetSumAll", "SLIS_Pay");

                entity.Property(e => e.Amount).HasColumnType("numeric(38, 2)");

                entity.Property(e => e.Amt).HasColumnType("numeric(38, 2)");

                entity.Property(e => e.Area)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.BaseCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CatCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Category)
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.OfficerCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.OfficerfName)
                    .HasMaxLength(76)
                    .IsUnicode(false)
                    .HasColumnName("officerf_Name");

                entity.Property(e => e.SysCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.YearMonth)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("Year_Month")
                    .IsFixedLength();
            });

            modelBuilder.Entity<PayVwRptMonSalReconSum>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pay_Vw_Rpt_MonSalReconSum", "SLIS_Pay");

                entity.Property(e => e.Amount).HasColumnType("numeric(38, 2)");

                entity.Property(e => e.Amt).HasColumnType("numeric(38, 2)");

                entity.Property(e => e.Area)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.AreaName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BaseName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Basecode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CatCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Category)
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.OfficerCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.OfficerfName)
                    .HasMaxLength(76)
                    .IsUnicode(false)
                    .HasColumnName("Officerf_Name");

                entity.Property(e => e.SysCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.YearMonth)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("Year_Month")
                    .IsFixedLength();
            });

            modelBuilder.Entity<PayVwRptNoOfPerson>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pay_Vw_Rpt_NoOfPersons", "SLIS_Pay");

                entity.Property(e => e.CatDesc)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.SysCatName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SysCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PayVwRptPaySlip>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pay_Vw_Rpt_PaySlip", "SLIS_Pay");

                entity.Property(e => e.Amount).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.AreaCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.BaseCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CatCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Descrip)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ItemCategory)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ItemCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.OfficerCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Rate).HasColumnType("numeric(9, 2)");

                entity.Property(e => e.RowId).HasColumnName("RowID");

                entity.Property(e => e.SysCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Units).HasColumnType("numeric(18, 2)");
            });

            modelBuilder.Entity<PayVwRptPaySlipEmail>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pay_Vw_Rpt_PaySlip_Email", "SLIS_Pay");

                entity.Property(e => e.Amount).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.AreaCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.BaseCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CatCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Descrip)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ItemCategory)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ItemCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.OfficerCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Rate).HasColumnType("numeric(9, 2)");

                entity.Property(e => e.SysCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Units).HasColumnType("numeric(18, 2)");
            });

            modelBuilder.Entity<PayVwRptPaySlipNewEmail>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pay_Vw_Rpt_PaySlip_NewEmail", "SLIS_Pay");

                entity.Property(e => e.Amount).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.AreaCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.BaseCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CatCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Descrip)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ItemCategory)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ItemCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.OfficerCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Rate).HasColumnType("numeric(9, 2)");

                entity.Property(e => e.RowId).HasColumnName("RowID");

                entity.Property(e => e.SysCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Units).HasColumnType("numeric(18, 2)");
            });

            modelBuilder.Entity<PayVwRptPreProcessErrList>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pay_Vw_Rpt_PreProcessErrList", "SLIS_Pay");

                entity.Property(e => e.CatCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.ErrDesc)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FullName)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.ItemCategory)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ItemCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.OfficerCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Rate).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.SysCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PayVwRptProcessUnprocessList>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pay_Vw_Rpt_Process_Unprocess_List", "SLIS_Pay");

                entity.Property(e => e.Amount).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.BaseCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.BaseName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CatCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Flag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ItemCategory)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ItemCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.ItemName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.OfficerCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Policino)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("POLICINO");

                entity.Property(e => e.RankCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.RankName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Remarks)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SysCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PayVwRptProcessUnprocessListXml>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pay_Vw_Rpt_Process_Unprocess_List_XML", "SLIS_Pay");

                entity.Property(e => e.Amount).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.BaseCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.BaseName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CatCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Flag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ItemCategory)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ItemCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.ItemName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.OfficerCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Policino)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("POLICINO");

                entity.Property(e => e.RankCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.RankName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Remarks)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StatusCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.SysCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.SysType)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<PayVwRptProcessUnprocessListXmlObf>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pay_Vw_Rpt_Process_Unprocess_List_XML_OBF", "SLIS_Pay");

                entity.Property(e => e.Amount).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.BaseCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.BaseName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CatCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Flag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ItemCategory)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ItemCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.ItemName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.OfficerCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Policino)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("POLICINO");

                entity.Property(e => e.RankCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.RankName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Remarks)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StatusCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.SysCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.SysType)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<PayVwRptProcessUnprocessListXmlOld>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pay_Vw_Rpt_Process_Unprocess_List_XML_old", "SLIS_Pay");

                entity.Property(e => e.Amount).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.BaseCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.BaseName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CatCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Flag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ItemCategory)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ItemCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.ItemName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.OfficerCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Policino)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("POLICINO");

                entity.Property(e => e.RankCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.RankName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Remarks)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SysCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.SysType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<PayVwRptProcessUnprocessListXmlRnbf>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pay_Vw_Rpt_Process_Unprocess_List_XML_RNBF", "SLIS_Pay");

                entity.Property(e => e.Amount).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.BaseCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.BaseName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CatCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Flag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ItemCategory)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ItemCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.ItemName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.OfficerCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Policino)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("POLICINO");

                entity.Property(e => e.RankCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.RankName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Remarks)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StatusCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.SysCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.SysType)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<PayVwRptProcessUnprocessListXmlVnbf>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pay_Vw_Rpt_Process_Unprocess_List_XML_VNBF", "SLIS_Pay");

                entity.Property(e => e.Amount).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.BaseCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.BaseName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CatCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Flag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ItemCategory)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ItemCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.ItemName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.OfficerCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Policino)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("POLICINO");

                entity.Property(e => e.RankCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.RankName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Remarks)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StatusCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.SysCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.SysType)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<PayVwRptProcessUnprocessListXmlnew>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pay_Vw_Rpt_Process_Unprocess_List_XMLnew", "SLIS_Pay");

                entity.Property(e => e.Amount).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.BaseCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.BaseName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CatCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Flag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ItemCategory)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ItemCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.ItemName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.OfficerCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Policino)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("POLICINO");

                entity.Property(e => e.RankCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.RankName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Remarks)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StatusCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.SysCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.SysType)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<PayVwRptSalaryValidation>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pay_Vw_Rpt_SalaryValidation", "SLIS_Pay");

                entity.Property(e => e.Amount).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CatCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.ItemCategory)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ItemCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.ItemName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.OfficerCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.PayAmount).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.RankCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.RankGroup)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.RankName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SysCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PayVwRptSelectPaymentVoucher>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pay_Vw_Rpt_Select_PaymentVoucher", "SLIS_Pay");

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.CancelledDate).HasColumnType("datetime");

                entity.Property(e => e.CatCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentDate).HasColumnType("datetime");

                entity.Property(e => e.DocumentNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OfficerCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.OfficerName)
                    .HasMaxLength(76)
                    .IsUnicode(false);

                entity.Property(e => e.SysCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PayVwRptSelectWop>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pay_VW_Rpt_select_WOP", "SLIS_Pay");

                entity.Property(e => e.Amount).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CatCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CurMonth)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ItemCategory)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ItemCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.OfficerCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.SysCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PayVwRptStopSalary>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pay_Vw_Rpt_StopSalary", "SLIS_Pay");

                entity.Property(e => e.AccNo)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.BankCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.BranchCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CatCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.EffectDate).HasColumnType("datetime");

                entity.Property(e => e.Etrans).HasColumnName("ETrans");

                entity.Property(e => e.Name)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.OfficerCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.OldAccNo)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.OldAmount).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.OldBankCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.OldBranchCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.SysCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PayVwRptYearlyBasewisePaySummary>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pay_VW_Rpt_YearlyBasewisePaySummary", "SLIS_Pay");

                entity.Property(e => e.Amount).HasColumnType("numeric(38, 2)");

                entity.Property(e => e.Amttype)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.BaseCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.BaseName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Mmonth)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("MMonth");
            });

            modelBuilder.Entity<PayVwSalTextTran>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pay_Vw_SalTextTrans", "SLIS_Pay");

                entity.Property(e => e.Cl5)
                    .HasMaxLength(138)
                    .IsUnicode(false)
                    .HasColumnName("cl5");

                entity.Property(e => e.Cl6)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("cl6");

                entity.Property(e => e.Cl7)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("cl7");
            });

            modelBuilder.Entity<PayVwSearchAppoDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pay_Vw_SearchAppoDetails", "SLIS_Pay");

                entity.Property(e => e.AppCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.AppFroom).HasColumnType("datetime");

                entity.Property(e => e.AppTo).HasColumnType("datetime");

                entity.Property(e => e.CatCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.ConfirmDate).HasColumnType("datetime");

                entity.Property(e => e.OfficerCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.SysCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PayVwSearchAppointment>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pay_Vw_SearchAppointment", "SLIS_Pay");

                entity.Property(e => e.Code)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PayVwSearchArea>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pay_Vw_SearchArea", "SLIS_Pay");

                entity.Property(e => e.Code)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PayVwSearchBank>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pay_Vw_SearchBank", "SLIS_Pay");

                entity.Property(e => e.Code)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PayVwSearchBankAccount>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pay_Vw_SearchBankAccounts", "SLIS_Pay");

                entity.Property(e => e.AccCat)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Accno)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.CatCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.DepnId)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("DepnID");

                entity.Property(e => e.OfficerCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.SysCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PayVwSearchBankBranch>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pay_Vw_SearchBankBranch", "SLIS_Pay");

                entity.Property(e => e.BankCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.BranchCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.BranchName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PayVwSearchBankDeduction>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pay_Vw_Search_BankDeductions", "SLIS_Pay");

                entity.Property(e => e.BankAccountNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BankDeductionCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.BankDeductionName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BankName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BranchName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PayVwSearchBankDeduction1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pay_Vw_SearchBankDeductions", "SLIS_Pay");

                entity.Property(e => e.AddressSin)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.BankAccountNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BankCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.BankDeductionCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.BankDeductionName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BankName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BranchCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.BranchName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionCode)
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PayVwSearchBase>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pay_Vw_SearchBase", "SLIS_Pay");

                entity.Property(e => e.AreaCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.BaseCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.BaseName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BaseNameSin)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BaseSname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BaseSName");
            });

            modelBuilder.Entity<PayVwSearchBaseSubUnit>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pay_Vw_SearchBaseSubUnit", "SLIS_Pay");

                entity.Property(e => e.BaseCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.SubUnitCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.SubUnitName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SubUnitNameSin)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PayVwSearchBranch>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pay_Vw_SearchBranch", "SLIS_Pay");

                entity.Property(e => e.CatCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PayVwSearchCategory>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pay_Vw_SearchCategory", "SLIS_Pay");

                entity.Property(e => e.Code)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SalDispAmt).HasColumnType("numeric(18, 2)");
            });

            modelBuilder.Entity<PayVwSearchCommonItemEntry>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pay_Vw_SearchCommonItemEntry", "SLIS_Pay");

                entity.Property(e => e.ItemCategoty)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ItemCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.ItemName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PayVwSearchConmmonitemGroup>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pay_Vw_SearchConmmonitem_Groups", "SLIS_Pay");

                entity.Property(e => e.Code)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PayVwSearchCountry>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pay_Vw_SearchCountry", "SLIS_Pay");

                entity.Property(e => e.Code)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CountryRate1).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PayVwSearchDepnProfile>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pay_Vw_SearchDepnProfile", "SLIS_Pay");

                entity.Property(e => e.CatCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.DepnId)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("DepnID");

                entity.Property(e => e.Initials)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.OfficerCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.SurName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SysCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PayVwSearchDepnType>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pay_Vw_SearchDepnType", "SLIS_Pay");

                entity.Property(e => e.Code)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.RelationShip)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PayVwSearchFinalPay>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pay_Vw_SearchFinalPay", "SLIS_Pay");

                entity.Property(e => e.CatCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Initials)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OfficerCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.SurName)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.SysCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PayVwSearchForginAllowance>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pay_Vw_SearchForginAllowance", "SLIS_Pay");

                entity.Property(e => e.Code)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PayVwSearchGcbtype>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pay_Vw_SearchGCBType", "SLIS_Pay");

                entity.Property(e => e.Amount).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Code)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PayVwSearchItemAllowance>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pay_Vw_SearchItemAllowance", "SLIS_Pay");

                entity.Property(e => e.Code)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.ItemAltName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PayVwSearchItemDeduction>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pay_Vw_SearchItemDeduction", "SLIS_Pay");

                entity.Property(e => e.Code)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.ItemAltName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PayVwSearchItemGroup>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pay_Vw_SearchItemGroups", "SLIS_Pay");

                entity.Property(e => e.Code)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PayVwSearchItemGroupsFinalPay>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pay_Vw_SearchItemGroupsFinalPay", "SLIS_Pay");

                entity.Property(e => e.GroupItemCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.GroupName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PayVwSearchItemGroupsValidation>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pay_Vw_SearchItemGroupsValidation", "SLIS_Pay");

                entity.Property(e => e.Code)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PayVwSearchItemLoan>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pay_Vw_SearchItemLoans", "SLIS_Pay");

                entity.Property(e => e.Code)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.ItemAltName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PayVwSearchLeaveType>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pay_Vw_SearchLeaveType", "SLIS_Pay");

                entity.Property(e => e.Code)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PayVwSearchLoanDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pay_Vw_SearchLoanDetails", "SLIS_Pay");

                entity.Property(e => e.CatCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Fullname)
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .HasColumnName("fullname");

                entity.Property(e => e.Itemcode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.LoanAmount).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Loandate)
                    .HasColumnType("datetime")
                    .HasColumnName("loandate");

                entity.Property(e => e.Officercode)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("officercode");

                entity.Property(e => e.SysCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PayVwSearchOvsReason>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pay_Vw_SearchOvsReason", "SLIS_Pay");

                entity.Property(e => e.OvsCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.OvsName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PayVwSearchPerInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pay_Vw_SearchPerInfo", "SLIS_Pay");

                entity.Property(e => e.CatCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Initials)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.SurName)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.SysCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PayVwSearchPerInfoGrativity>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pay_Vw_SearchPerInfoGrativity", "SLIS_Pay");

                entity.Property(e => e.CatCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.PensionType)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("pensionType");

                entity.Property(e => e.SysCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PayVwSearchPerInfoPension>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pay_Vw_SearchPerInfoPension", "SLIS_Pay");

                entity.Property(e => e.CatCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.PensionType)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("pensionType");

                entity.Property(e => e.SysCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PayVwSearchPerInfoPensionRevice>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pay_Vw_SearchPerInfoPensionRevice", "SLIS_Pay");

                entity.Property(e => e.CatCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.PensionType)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("pensionType");

                entity.Property(e => e.SysCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PayVwSearchPerInfoRevice>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pay_Vw_SearchPerInfoRevice", "SLIS_Pay");

                entity.Property(e => e.CatCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Initials)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SurName)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.SysCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PayVwSearchQpay>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pay_Vw_SearchQPay", "SLIS_Pay");

                entity.Property(e => e.Amount).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Code)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PayVwSearchRank>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pay_Vw_SearchRank", "SLIS_Pay");

                entity.Property(e => e.CatCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.RankCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.RankGroup)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.RankName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RankNameSin)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StartSalary).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Woprate)
                    .HasColumnType("numeric(6, 2)")
                    .HasColumnName("WOPRate");
            });

            modelBuilder.Entity<PayVwSearchRankGroup>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pay_Vw_SearchRankGroup", "SLIS_Pay");

                entity.Property(e => e.CatCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.RankGroup)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.RgroupName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RGroupName");
            });

            modelBuilder.Entity<PayVwSearchRankIncrement>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pay_Vw_SearchRankIncrement", "SLIS_Pay");

                entity.Property(e => e.CatCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.OfficerCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.RankCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.SysCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PayVwSearchReligion>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pay_Vw_SearchReligion", "SLIS_Pay");

                entity.Property(e => e.Code)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PayVwSearchServiceStatus>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pay_Vw_SearchServiceStatus", "SLIS_Pay");

                entity.Property(e => e.CatCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.FullName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.OfficerCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.StatusEffectDate).HasColumnType("datetime");

                entity.Property(e => e.SurName)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.SysCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PayVwSearchStatus>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pay_Vw_SearchStatus", "SLIS_Pay");

                entity.Property(e => e.Code)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PayVwSearchStatusChange>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pay_Vw_SearchStatusChange", "SLIS_Pay");

                entity.Property(e => e.CatCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CountryCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.DateEffect).HasColumnType("datetime");

                entity.Property(e => e.DateRemove).HasColumnType("datetime");

                entity.Property(e => e.DtgrefEffect)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DTGRefEffect");

                entity.Property(e => e.DtgrefRemove)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DTGRefRemove");

                entity.Property(e => e.OfficerCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.PunishDays).HasColumnType("numeric(6, 2)");

                entity.Property(e => e.Reason)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.RemarkEffect)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.RemarkRemove)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.StatusCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.SysCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PayVwSearchSysCategory>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pay_Vw_SearchSysCategory", "SLIS_Pay");

                entity.Property(e => e.Code)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PayVwSearchTax>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pay_Vw_SearchTax", "SLIS_Pay");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PayVwSearchTraVal>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pay_Vw_SearchTraVal", "SLIS_Pay");

                entity.Property(e => e.Amount).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CatCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Ip)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("IP")
                    .IsFixedLength();

                entity.Property(e => e.ItemCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.OfficerCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Remark)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SysCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PayVwSearchUserGroup>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pay_Vw_SearchUserGroups", "SLIS_Pay");

                entity.Property(e => e.Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PayVwSearchUserMaster>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pay_Vw_SearchUserMaster", "SLIS_Pay");

                entity.Property(e => e.UserName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PayVwSearchWoprate>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pay_Vw_SearchWOPRate", "SLIS_Pay");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Rate).HasColumnType("numeric(18, 2)");
            });

            modelBuilder.Entity<PayVwSelectCashRecociliation>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pay_Vw_Select_Cash_Recociliation", "SLIS_Pay");

                entity.Property(e => e.Amount).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Area)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.BaseCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CashReturn).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CatCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.OfficerCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.SubUnitCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.SysCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PayVwSelectForginDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pay_Vw_Select_ForginDetails", "SLIS_Pay");

                entity.Property(e => e.FileNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TrancationDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<PayVwSelectStopbank>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pay_Vw_Select_Stopbank", "SLIS_Pay");

                entity.Property(e => e.CatCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.OfficerCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.SysCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PayVwTransactionSheduleDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pay_Vw_Transaction_Shedule_Details", "SLIS_Pay");

                entity.Property(e => e.Amount).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CatCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.ItemCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(165)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.OfficerCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.SysCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PenVwPensionReportSinhala>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pen_Vw_PensionReport_Sinhala", "SLIS_Pay");

                entity.Property(e => e.AmountPerChild).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.BranchCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.BranchName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CatCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.ChildCount).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ConSalary).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.GratuityAmount).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.LaspPaidDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.OfficerCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.OtherAmount1).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.OtherAmount2).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.PensionAfter).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.PensionBefore).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.PensionPerc).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.PensionStartDate).HasColumnType("datetime");

                entity.Property(e => e.PensionType)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.RankCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.RankName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReEngageDate).HasColumnType("datetime");

                entity.Property(e => e.Reason)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Regulation)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Seniority).HasColumnType("datetime");

                entity.Property(e => e.ServiceEndDate).HasColumnType("datetime");

                entity.Property(e => e.SysCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.TotGcb)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("TotGCB");

                entity.Property(e => e.TotQpay)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("TotQPay");

                entity.Property(e => e.TotRationMoney).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.TotReEngage).HasColumnType("numeric(18, 2)");
            });

            modelBuilder.Entity<PnsCatPercentage>(entity =>
            {
                entity.HasKey(e => new { e.CatCode, e.NoOfYear })
                    .HasName("PK_Pns_Percentage");

                entity.ToTable("Pns_CatPercentage", "SLIS_Pay");

                entity.Property(e => e.CatCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.NoOfYear).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Percentage).HasColumnType("numeric(18, 2)");

                entity.HasOne(d => d.CatCodeNavigation)
                    .WithMany(p => p.PnsCatPercentages)
                    .HasForeignKey(d => d.CatCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Pns_Percentage_Pay_Category");
            });

            modelBuilder.Entity<PnsRankPercentage>(entity =>
            {
                entity.HasKey(e => new { e.RankCode, e.CatCode, e.YearsFrom });

                entity.ToTable("Pns_RankPercentage", "SLIS_Pay");

                entity.Property(e => e.RankCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CatCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.YearsFrom).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Percentage).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.YearsTo).HasColumnType("numeric(18, 2)");
            });

            modelBuilder.Entity<PnsSetUp>(entity =>
            {
                entity.HasKey(e => e.CatCode);

                entity.ToTable("Pns_SetUp", "SLIS_Pay");

                entity.Property(e => e.CatCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.DepAgeLimit).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.PriServLimit).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Reduction).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.ReductionYear).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.ServLimit).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.WidowPenson).HasColumnType("numeric(18, 2)");

                entity.HasOne(d => d.CatCodeNavigation)
                    .WithOne(p => p.PnsSetUp)
                    .HasForeignKey<PnsSetUp>(d => d.CatCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Pns_SetUp_Pay_Category");
            });

            modelBuilder.Entity<PnsVwSearchPerInfoGrativity>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pns_Vw_SearchPerInfoGrativity", "SLIS_Pay");

                entity.Property(e => e.CatCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.PensionType)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("pensionType");

                entity.Property(e => e.SysCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PnsVwWnoptotal>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pns_Vw_WNOPTOTAL", "SLIS_Pay");

                entity.Property(e => e.Amount).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CatCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.OfficerCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.SysCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Zyear)
                    .HasMaxLength(4)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TempRentCeiling>(entity =>
            {
                entity.HasKey(e => e.Rccode)
                    .HasName("PK_Pay_RCType");

                entity.ToTable("Temp_RentCeiling", "SLIS_Pay");

                entity.Property(e => e.Rccode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("RCCode");

                entity.Property(e => e.Rcgroup)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("RCGroup");
            });

            modelBuilder.Entity<TempViewAutoIncrement>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("tempView_AutoIncrement", "SLIS_Pay");

                entity.Property(e => e.AutoIncrementDt).HasColumnType("datetime");

                entity.Property(e => e.CatCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.OfficerCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.RankName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SysCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwRptSalaryReconcile>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_Rpt_Salary_Reconcile", "SLIS_Pay");

                entity.Property(e => e.Area)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CatCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Consol)
                    .HasColumnType("numeric(38, 2)")
                    .HasColumnName("consol");

                entity.Property(e => e.Fixall)
                    .HasColumnType("numeric(38, 2)")
                    .HasColumnName("fixall");

                entity.Property(e => e.Fixdeduct)
                    .HasColumnType("numeric(38, 2)")
                    .HasColumnName("fixdeduct");

                entity.Property(e => e.Gross).HasColumnType("numeric(38, 2)");

                entity.Property(e => e.NetSalary).HasColumnType("numeric(38, 2)");

                entity.Property(e => e.OfficerCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.SenttoBank).HasColumnType("numeric(38, 2)");

                entity.Property(e => e.SysCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Varall)
                    .HasColumnType("numeric(38, 2)")
                    .HasColumnName("varall");

                entity.Property(e => e.Vardeduct)
                    .HasColumnType("numeric(38, 2)")
                    .HasColumnName("vardeduct");
            });

            modelBuilder.Entity<VwRptSalaryReconcileSummary>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_Rpt_Salary_Reconcile_Summary", "SLIS_Pay");

                entity.Property(e => e.Area)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.AreaName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Consol)
                    .HasColumnType("numeric(38, 2)")
                    .HasColumnName("consol");

                entity.Property(e => e.Fixall)
                    .HasColumnType("numeric(38, 2)")
                    .HasColumnName("fixall");

                entity.Property(e => e.Fixdeduct)
                    .HasColumnType("numeric(38, 2)")
                    .HasColumnName("fixdeduct");

                entity.Property(e => e.Gross).HasColumnType("numeric(38, 2)");

                entity.Property(e => e.NetSalary).HasColumnType("numeric(38, 2)");

                entity.Property(e => e.Nofoperson).HasColumnName("nofoperson");

                entity.Property(e => e.SenttoBank).HasColumnType("numeric(38, 2)");

                entity.Property(e => e.SysCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Varall)
                    .HasColumnType("numeric(38, 2)")
                    .HasColumnName("varall");

                entity.Property(e => e.Vardeduct)
                    .HasColumnType("numeric(38, 2)")
                    .HasColumnName("vardeduct");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
