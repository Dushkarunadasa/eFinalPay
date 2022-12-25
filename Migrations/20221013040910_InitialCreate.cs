using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinaPay.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "failed_jobs",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    uuid = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    connection = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    queue = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    payload = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    exception = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    failed_at = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_failed_jobs", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "migrations",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    migration = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    batch = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_migrations", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "password_resets",
                columns: table => new
                {
                    email = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    token = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    created_at = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Pay_Basic_Rank_Scale_D",
                columns: table => new
                {
                    RankCode = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: false),
                    ScaleCode = table.Column<int>(type: "int", nullable: false),
                    Sequence = table.Column<int>(type: "int", nullable: false),
                    ConsolidatedSal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Adjustment = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    RankCat = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Basic_Rank_Scale_D", x => new { x.RankCode, x.ScaleCode, x.Sequence });
                });

            migrationBuilder.CreateTable(
                name: "Pay_Basic_Scale_D",
                columns: table => new
                {
                    Scale_Code = table.Column<int>(type: "int", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Month = table.Column<int>(type: "int", nullable: false),
                    Sequence = table.Column<int>(type: "int", nullable: true),
                    InsertedBy = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: true),
                    InsertOn = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    ApprovedBy = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true),
                    ApprovedOn = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Basic_Scale_D", x => x.Scale_Code);
                });

            migrationBuilder.CreateTable(
                name: "Pay_ProcessMonth",
                columns: table => new
                {
                    CurMonth = table.Column<string>(type: "varchar(6)", unicode: false, maxLength: 6, nullable: true),
                    PrevMonth = table.Column<string>(type: "varchar(6)", unicode: false, maxLength: 6, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Pay_Rank_D",
                columns: table => new
                {
                    CatCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    RankCode = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    RankName = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    RankGroup = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    RankNameSin = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NotEffectConsolidated = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    NoAnnualIncrement = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    NoPromIncPrevRank = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    NoProIncNewRank = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    ScaleTop = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    Order = table.Column<int>(type: "int", nullable: true),
                    ScaleRankCode = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    Position = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "personal_access_tokens",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tokenable_type = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    tokenable_id = table.Column<long>(type: "bigint", nullable: false),
                    name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    token = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    abilities = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    last_used_at = table.Column<DateTime>(type: "datetime", nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime", nullable: true),
                    updated_at = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_personal_access_tokens", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Sub_327_Action",
                columns: table => new
                {
                    TransId = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: false),
                    ActionOn = table.Column<DateTime>(type: "datetime", nullable: false),
                    Remarks = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    SysCode = table.Column<string>(type: "nchar(3)", fixedLength: true, maxLength: 3, nullable: true),
                    CatCode = table.Column<string>(type: "nchar(1)", fixedLength: true, maxLength: 1, nullable: true),
                    OfficialNo = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sub_327_Action", x => new { x.TransId, x.ActionOn });
                });

            migrationBuilder.CreateTable(
                name: "Sub_327Adjustment_Trans",
                columns: table => new
                {
                    TransId = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: false),
                    BaseCode = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: false),
                    UnitId = table.Column<int>(type: "int", nullable: false),
                    Remarks = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    FilePath = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    TSave = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    TConfirm = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    TForward = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    ACheck = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    AConfirm = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    AForward = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    DCheck = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    DConfirm = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    DForward = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    DDNPay = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    Subject = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    AuditStaff = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    AuditOfficer = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    SSO = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    Reject = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    DeductAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: true, defaultValueSql: "((0))"),
                    Total327 = table.Column<decimal>(type: "decimal(18,2)", nullable: true, defaultValueSql: "((0))"),
                    CurrentPayMonth = table.Column<string>(type: "char(6)", unicode: false, fixedLength: true, maxLength: 6, nullable: true),
                    PayAction = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    PayActionRemarks = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Des = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sub_327Adjustment_Trans", x => x.TransId);
                });

            migrationBuilder.CreateTable(
                name: "Sub_327Items",
                columns: table => new
                {
                    ItemCode = table.Column<string>(type: "varchar(4)", unicode: false, maxLength: 4, nullable: true),
                    ItemCategory = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    Type = table.Column<string>(type: "nchar(1)", fixedLength: true, maxLength: 1, nullable: true),
                    ArrearsCode = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    ArrearsCodeCat = table.Column<string>(type: "nchar(1)", fixedLength: true, maxLength: 1, nullable: true),
                    CatCode = table.Column<string>(type: "nchar(1)", fixedLength: true, maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Sub_Allowance_Areas",
                columns: table => new
                {
                    BaseCode = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    Area = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Sub_Allowance_Incentives",
                columns: table => new
                {
                    ItemCode = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    Method = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Sub_Allowances_ArrearsCodes",
                columns: table => new
                {
                    ItemCode = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    ArrearsCode = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Sub_Allowances_Branch",
                columns: table => new
                {
                    ItemCode = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    Branch = table.Column<string>(type: "nchar(3)", fixedLength: true, maxLength: 3, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Sub_Allowances_CAlGroup",
                columns: table => new
                {
                    ItemCode = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    ItemGroup = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Sub_Allowances_Conditions",
                columns: table => new
                {
                    ItemCode = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    Calculation = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Sub_Allowances_Group",
                columns: table => new
                {
                    ItemCode = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    ItemGroup = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    ItemOrder = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Sub_Allowances_Log",
                columns: table => new
                {
                    LUserId = table.Column<string>(type: "nchar(50)", fixedLength: true, maxLength: 50, nullable: false),
                    LDescription = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Log_on = table.Column<DateTime>(type: "datetime", nullable: false),
                    IPaddress = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sub_Allowances_Logs", x => new { x.LUserId, x.LDescription, x.Log_on });
                });

            migrationBuilder.CreateTable(
                name: "Sub_Allowances_OverPayCodes",
                columns: table => new
                {
                    ItemCode = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    OverPayCode = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Sub_Allowances_Ranks",
                columns: table => new
                {
                    ItemCode = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    RankCode = table.Column<string>(type: "nchar(3)", fixedLength: true, maxLength: 3, nullable: true),
                    CatCode = table.Column<string>(type: "nchar(1)", fixedLength: true, maxLength: 1, nullable: true),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Sub_Allowances_Restricted",
                columns: table => new
                {
                    ItemCode = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    Restricted = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Sub_Allowances_SubItems",
                columns: table => new
                {
                    SubjectID = table.Column<int>(type: "int", nullable: false),
                    ItemCode = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: false),
                    Type = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sub_Allowances_SubItems", x => new { x.SubjectID, x.ItemCode });
                });

            migrationBuilder.CreateTable(
                name: "Sub_Allowances_Subjects",
                columns: table => new
                {
                    Sub_Id = table.Column<int>(type: "int", nullable: false),
                    Subject = table.Column<string>(type: "nchar(35)", fixedLength: true, maxLength: 35, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sub_All_Subjects", x => x.Sub_Id);
                });

            migrationBuilder.CreateTable(
                name: "Sub_Allowances_SYS_CAT",
                columns: table => new
                {
                    ItemCode = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    SysCode = table.Column<string>(type: "nchar(3)", fixedLength: true, maxLength: 3, nullable: true),
                    CatCode = table.Column<string>(type: "nchar(1)", fixedLength: true, maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Sub_Allowances_Trans_Details",
                columns: table => new
                {
                    TransId = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: false),
                    ItemCode = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: false),
                    OfficialNo = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    ItemCategory = table.Column<string>(type: "nchar(1)", fixedLength: true, maxLength: 1, nullable: false),
                    BaseCode = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: false),
                    SysCode = table.Column<string>(type: "nchar(3)", fixedLength: true, maxLength: 3, nullable: false),
                    CatCode = table.Column<string>(type: "nchar(1)", fixedLength: true, maxLength: 1, nullable: false),
                    EffectDate = table.Column<DateTime>(type: "date", nullable: false),
                    Edit = table.Column<bool>(type: "bit", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValueSql: "((1))"),
                    ArrearsCode = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    ArrearsAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    OverPayCode = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    OverPayAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Remarks = table.Column<string>(type: "nchar(150)", fixedLength: true, maxLength: 150, nullable: true),
                    Reject = table.Column<bool>(type: "bit", nullable: false),
                    EditedBy = table.Column<string>(type: "nchar(50)", fixedLength: true, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sub_Allowances_Trans_Details", x => new { x.TransId, x.ItemCode, x.OfficialNo });
                });

            migrationBuilder.CreateTable(
                name: "Sub_Allowances_Trans_Details_History",
                columns: table => new
                {
                    TransId = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: false),
                    ItemCode = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: false),
                    OfficialNo = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    ItemCategory = table.Column<string>(type: "nchar(1)", fixedLength: true, maxLength: 1, nullable: false),
                    BaseCode = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: false),
                    SysCode = table.Column<string>(type: "nchar(3)", fixedLength: true, maxLength: 3, nullable: false),
                    CatCode = table.Column<string>(type: "nchar(1)", fixedLength: true, maxLength: 1, nullable: false),
                    EffectDate = table.Column<DateTime>(type: "date", nullable: false),
                    Edit = table.Column<bool>(type: "bit", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    ArrearsCode = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    ArrearsAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    OverPayCode = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    OverPayAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Remarks = table.Column<string>(type: "nchar(150)", fixedLength: true, maxLength: 150, nullable: true),
                    Reject = table.Column<bool>(type: "bit", nullable: false),
                    EditedBy = table.Column<string>(type: "nchar(50)", fixedLength: true, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sub_Allowances_Trans_Details_History", x => new { x.TransId, x.ItemCode, x.OfficialNo });
                });

            migrationBuilder.CreateTable(
                name: "Sub_Allowances_Trans_Details_History_1",
                columns: table => new
                {
                    TransId = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: false),
                    ItemCode = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: false),
                    OfficialNo = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    ItemCategory = table.Column<string>(type: "nchar(1)", fixedLength: true, maxLength: 1, nullable: false),
                    BaseCode = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: false),
                    SysCode = table.Column<string>(type: "nchar(3)", fixedLength: true, maxLength: 3, nullable: false),
                    CatCode = table.Column<string>(type: "nchar(1)", fixedLength: true, maxLength: 1, nullable: false),
                    Edit = table.Column<bool>(type: "bit", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    Remarks = table.Column<string>(type: "nchar(150)", fixedLength: true, maxLength: 150, nullable: true),
                    Reject = table.Column<bool>(type: "bit", nullable: false),
                    EditedBy = table.Column<string>(type: "nchar(50)", fixedLength: true, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sub_Allowances_Trans_Details_History_1", x => new { x.TransId, x.ItemCode, x.OfficialNo });
                });

            migrationBuilder.CreateTable(
                name: "Sub_Allowances_Trans_Master",
                columns: table => new
                {
                    TransId = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: false),
                    PayMonth = table.Column<double>(type: "float", nullable: false),
                    UnitCode = table.Column<int>(type: "int", nullable: false),
                    BaseCode = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: false),
                    Remarks = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TSave = table.Column<bool>(type: "bit", nullable: false),
                    TSaveSysCode = table.Column<string>(type: "nchar(3)", fixedLength: true, maxLength: 3, nullable: true),
                    TSaveCatCode = table.Column<string>(type: "nchar(1)", fixedLength: true, maxLength: 1, nullable: true),
                    TSaveBy = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    TSaveOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    TConfirm = table.Column<bool>(type: "bit", nullable: false),
                    TConfirmSysCode = table.Column<string>(type: "nchar(3)", fixedLength: true, maxLength: 3, nullable: true),
                    TConfirmCatCode = table.Column<string>(type: "nchar(1)", fixedLength: true, maxLength: 1, nullable: true),
                    TConfirmBy = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    TConfirmOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    TForward = table.Column<bool>(type: "bit", nullable: false),
                    TForwardSysCode = table.Column<string>(type: "nchar(3)", fixedLength: true, maxLength: 3, nullable: true),
                    TForwardCatCode = table.Column<string>(type: "nchar(1)", fixedLength: true, maxLength: 1, nullable: true),
                    TForwardBy = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    TForwardOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    TPayHead = table.Column<bool>(type: "bit", nullable: false),
                    TPayHeadSysCode = table.Column<string>(type: "nchar(3)", fixedLength: true, maxLength: 3, nullable: true),
                    TPayHeadCatCode = table.Column<string>(type: "nchar(1)", fixedLength: true, maxLength: 1, nullable: true),
                    THeadBy = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    TPayHeadOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    TSubject = table.Column<bool>(type: "bit", nullable: false),
                    TSubClarkSysCode = table.Column<string>(type: "nchar(3)", fixedLength: true, maxLength: 3, nullable: true),
                    TSubClarkCatCode = table.Column<string>(type: "nchar(1)", fixedLength: true, maxLength: 1, nullable: true),
                    TSubClarkBy = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    TSubClarkOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    TAuditStaff = table.Column<bool>(type: "bit", nullable: false),
                    TSAuditSysCode = table.Column<string>(type: "nchar(3)", fixedLength: true, maxLength: 3, nullable: true),
                    TSAuditCatCode = table.Column<string>(type: "nchar(1)", fixedLength: true, maxLength: 1, nullable: true),
                    TSAuditOfficialNo = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    TSAuditedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    TAudit = table.Column<bool>(type: "bit", nullable: false),
                    TAuditSysCode = table.Column<string>(type: "nchar(3)", fixedLength: true, maxLength: 3, nullable: true),
                    TAuditCatCode = table.Column<string>(type: "nchar(1)", fixedLength: true, maxLength: 1, nullable: true),
                    TAuditOfficialNo = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    TAuditedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    TSSO = table.Column<bool>(type: "bit", nullable: false),
                    TSSOSysCode = table.Column<string>(type: "nchar(3)", fixedLength: true, maxLength: 3, nullable: true),
                    TSSOCatCode = table.Column<string>(type: "nchar(1)", fixedLength: true, maxLength: 1, nullable: true),
                    TSSOBy = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    TSSOOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    TReject = table.Column<bool>(type: "bit", nullable: false),
                    TRejectSysCode = table.Column<string>(type: "nchar(3)", fixedLength: true, maxLength: 3, nullable: true),
                    TRejectCatCode = table.Column<string>(type: "nchar(1)", fixedLength: true, maxLength: 1, nullable: true),
                    TRejectby = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    TRejectOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    TRejectReason = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Path = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Allowances_Trans_Master", x => new { x.TransId, x.PayMonth, x.UnitCode, x.BaseCode });
                });

            migrationBuilder.CreateTable(
                name: "Sub_Allowances_TransId",
                columns: table => new
                {
                    SubjectID = table.Column<int>(type: "int", nullable: false),
                    TransId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Sub_Attachments",
                columns: table => new
                {
                    Trans_Id = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    TOrder = table.Column<int>(type: "int", nullable: true),
                    TAttachment = table.Column<string>(type: "nchar(25)", fixedLength: true, maxLength: 25, nullable: true),
                    TPath = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Sub_Base_Change",
                columns: table => new
                {
                    SysCode = table.Column<string>(type: "nchar(3)", fixedLength: true, maxLength: 3, nullable: true),
                    CatCode = table.Column<string>(type: "nchar(1)", fixedLength: true, maxLength: 1, nullable: true),
                    OfficialNo = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    HRMSBaseCode = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    PayBaseCode = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Sub_BaseMatching",
                columns: table => new
                {
                    BaseCode = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    PayBaseCode = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Sub_ExtraDuty_Master",
                columns: table => new
                {
                    TransId = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: false),
                    PayMonth = table.Column<double>(type: "float", nullable: false),
                    BaseCode = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: false),
                    TSave = table.Column<bool>(type: "bit", nullable: false),
                    TSaveSysCode = table.Column<string>(type: "nchar(3)", fixedLength: true, maxLength: 3, nullable: true),
                    TSaveCatCode = table.Column<string>(type: "nchar(1)", fixedLength: true, maxLength: 1, nullable: true),
                    TSaveBy = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    TSaveOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    TConfirm = table.Column<bool>(type: "bit", nullable: false),
                    TConfirmSysCode = table.Column<string>(type: "nchar(3)", fixedLength: true, maxLength: 3, nullable: true),
                    TConfirmCatCode = table.Column<string>(type: "nchar(1)", fixedLength: true, maxLength: 1, nullable: true),
                    TConfirmBy = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    TConfirmOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    TConfirmReject = table.Column<bool>(type: "bit", nullable: false),
                    TForward = table.Column<bool>(type: "bit", nullable: false),
                    TForwardSysCode = table.Column<string>(type: "nchar(3)", fixedLength: true, maxLength: 3, nullable: true),
                    TForwardCatCode = table.Column<string>(type: "nchar(1)", fixedLength: true, maxLength: 1, nullable: true),
                    TForwardBy = table.Column<string>(type: "nchar(25)", fixedLength: true, maxLength: 25, nullable: true),
                    TForwardOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    TPayHead = table.Column<bool>(type: "bit", nullable: false),
                    TPayHeadSysCode = table.Column<string>(type: "nchar(3)", fixedLength: true, maxLength: 3, nullable: true),
                    TPayHeadCatCode = table.Column<string>(type: "nchar(1)", fixedLength: true, maxLength: 1, nullable: true),
                    THead = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    TPayHeadOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    TSubject = table.Column<bool>(type: "bit", nullable: false),
                    TSubClarkSysCode = table.Column<string>(type: "nchar(3)", fixedLength: true, maxLength: 3, nullable: true),
                    TSubClarlCatCode = table.Column<string>(type: "nchar(1)", fixedLength: true, maxLength: 1, nullable: true),
                    TSubClark = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    TSubClarkOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    TReject = table.Column<bool>(type: "bit", nullable: false),
                    TRejectSysCode = table.Column<string>(type: "nchar(3)", fixedLength: true, maxLength: 3, nullable: true),
                    TRejectCatCode = table.Column<string>(type: "nchar(1)", fixedLength: true, maxLength: 1, nullable: true),
                    TRejectby = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    TRejectOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    TRejectReason = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ItemCode = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    TotalHours = table.Column<int>(type: "int", nullable: true),
                    Remarks = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sub_ExtraDuty_Master", x => new { x.TransId, x.PayMonth, x.BaseCode });
                });

            migrationBuilder.CreateTable(
                name: "Sub_ExtraDutyDetails",
                columns: table => new
                {
                    TransID = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: false),
                    EffectDt = table.Column<DateTime>(type: "date", nullable: false),
                    SFrom = table.Column<string>(type: "nchar(4)", fixedLength: true, maxLength: 4, nullable: false),
                    STo = table.Column<string>(type: "nchar(4)", fixedLength: true, maxLength: 4, nullable: true),
                    Hrs = table.Column<int>(type: "int", nullable: true),
                    Minutes = table.Column<int>(type: "int", nullable: true),
                    Details = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Remarks = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sub_ExtraDutyDetails", x => new { x.TransID, x.EffectDt, x.SFrom });
                });

            migrationBuilder.CreateTable(
                name: "Sub_ExtraDutyDetails_History",
                columns: table => new
                {
                    TransID = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: false),
                    EffectDt = table.Column<DateTime>(type: "date", nullable: false),
                    SFrom = table.Column<string>(type: "nchar(4)", fixedLength: true, maxLength: 4, nullable: false),
                    STo = table.Column<string>(type: "nchar(4)", fixedLength: true, maxLength: 4, nullable: true),
                    Hrs = table.Column<int>(type: "int", nullable: true),
                    Minutes = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Details = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Remarks = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sub_ExtraDutyDetails_History", x => new { x.TransID, x.EffectDt, x.SFrom });
                });

            migrationBuilder.CreateTable(
                name: "Sub_Final_Pay_327_List",
                columns: table => new
                {
                    TransId = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    PayMonth = table.Column<int>(type: "int", nullable: false),
                    _605606 = table.Column<int>(name: "605/606", type: "int", nullable: true, defaultValueSql: "((0))"),
                    _605A606A = table.Column<int>(name: "605A/606A", type: "int", nullable: true, defaultValueSql: "((0))"),
                    _610611 = table.Column<int>(name: "610/611", type: "int", nullable: true, defaultValueSql: "((0))"),
                    _612613 = table.Column<int>(name: "612/613", type: "int", nullable: true, defaultValueSql: "((0))"),
                    _615614 = table.Column<int>(name: "615/614", type: "int", nullable: true, defaultValueSql: "((0))"),
                    _690 = table.Column<int>(name: "690", type: "int", nullable: true, defaultValueSql: "((0))"),
                    _686687 = table.Column<int>(name: "686/687", type: "int", nullable: true, defaultValueSql: "((0))"),
                    _688689 = table.Column<int>(name: "688/689", type: "int", nullable: true, defaultValueSql: "((0))"),
                    _598 = table.Column<int>(name: "598", type: "int", nullable: true, defaultValueSql: "((0))"),
                    _596 = table.Column<int>(name: "596", type: "int", nullable: true, defaultValueSql: "((0))"),
                    _600 = table.Column<int>(name: "600", type: "int", nullable: true, defaultValueSql: "((0))"),
                    _630 = table.Column<int>(name: "630", type: "int", nullable: true, defaultValueSql: "((0))"),
                    _619 = table.Column<int>(name: "619", type: "int", nullable: true, defaultValueSql: "((0))"),
                    ItemCat = table.Column<string>(type: "nchar(1)", fixedLength: true, maxLength: 1, nullable: true),
                    ItemCode = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sub_Final_Pay_327_List", x => new { x.TransId, x.OrderId, x.PayMonth });
                });

            migrationBuilder.CreateTable(
                name: "Sub_Final_Pay_Details",
                columns: table => new
                {
                    Trans_ID = table.Column<int>(type: "int", nullable: false),
                    Unit_ID = table.Column<int>(type: "int", nullable: false),
                    ULevel = table.Column<int>(type: "int", nullable: false),
                    SubjectClerk = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    Secreatry = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    AuthorizedOfficer = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    Reject = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    RejectBy = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: true),
                    RejectReason = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    RejectSec = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    RejectAuth = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sub_Final_Pay_Details", x => new { x.Trans_ID, x.Unit_ID, x.ULevel });
                });

            migrationBuilder.CreateTable(
                name: "Sub_Final_Pay_Head_Details",
                columns: table => new
                {
                    TransID = table.Column<int>(type: "int", nullable: false),
                    SysCode = table.Column<string>(type: "nchar(3)", fixedLength: true, maxLength: 3, nullable: false),
                    CatCode = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    OfficialNo = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: false),
                    Type = table.Column<string>(type: "nchar(20)", fixedLength: true, maxLength: 20, nullable: true),
                    NG_Reference = table.Column<string>(type: "nchar(30)", fixedLength: true, maxLength: 30, nullable: true),
                    DischargeDt = table.Column<DateTime>(type: "date", nullable: true),
                    P_Form = table.Column<bool>(type: "bit", nullable: false),
                    P_Form_Path = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    BaseCode = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    BankCode = table.Column<int>(type: "int", nullable: true),
                    BranchCode = table.Column<int>(type: "int", nullable: true),
                    AccountNo = table.Column<int>(type: "int", nullable: true),
                    VoucherNo = table.Column<string>(type: "nchar(20)", fixedLength: true, maxLength: 20, nullable: true),
                    VoucherDes = table.Column<string>(type: "nchar(50)", fixedLength: true, maxLength: 50, nullable: true),
                    ChequeNo = table.Column<string>(type: "nchar(20)", fixedLength: true, maxLength: 20, nullable: true),
                    ChequeDt = table.Column<DateTime>(type: "date", nullable: true),
                    PaymentDt = table.Column<DateTime>(type: "date", nullable: true),
                    ActionComplete = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    Remarks = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sub_Final_Pay_Head_Details", x => new { x.TransID, x.SysCode, x.CatCode, x.OfficialNo });
                });

            migrationBuilder.CreateTable(
                name: "Sub_Final_Pay_Item_List",
                columns: table => new
                {
                    Trans_ID = table.Column<int>(type: "int", nullable: false),
                    Unit_ID = table.Column<int>(type: "int", nullable: false),
                    ItemCode = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: false),
                    Base = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    Qty = table.Column<int>(type: "int", nullable: true),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    FromGratuity = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    Remarks = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sub_Final_Pay_Item_List", x => new { x.Trans_ID, x.Unit_ID, x.ItemCode });
                });

            migrationBuilder.CreateTable(
                name: "Sub_Final_Pay_Items",
                columns: table => new
                {
                    ItemCode = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: false),
                    Unit = table.Column<int>(type: "int", nullable: false),
                    ItemCat = table.Column<string>(type: "nchar(1)", fixedLength: true, maxLength: 1, nullable: true),
                    ItemDescription = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    DaysCal = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sub_Final_Pay_Items", x => new { x.ItemCode, x.Unit });
                });

            migrationBuilder.CreateTable(
                name: "Sub_Final_Pay_Log_Details",
                columns: table => new
                {
                    Trans_ID = table.Column<int>(type: "int", nullable: false),
                    Unit_ID = table.Column<int>(type: "int", nullable: false),
                    UserID = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: false),
                    Logtime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    LogDetails = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    IP = table.Column<string>(type: "nchar(20)", fixedLength: true, maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sub_FinalPay_Log_Details", x => new { x.Trans_ID, x.Unit_ID, x.UserID, x.Logtime });
                });

            migrationBuilder.CreateTable(
                name: "Sub_Grade_Details",
                columns: table => new
                {
                    SysCode = table.Column<string>(type: "nchar(3)", fixedLength: true, maxLength: 3, nullable: false),
                    CatCode = table.Column<string>(type: "nchar(1)", fixedLength: true, maxLength: 1, nullable: false),
                    OfficialNo = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: false),
                    Grade = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: false),
                    EffectDt = table.Column<DateTime>(type: "date", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sub_Grade_Details", x => new { x.SysCode, x.CatCode, x.OfficialNo, x.Grade });
                });

            migrationBuilder.CreateTable(
                name: "Sub_Grade_Rates",
                columns: table => new
                {
                    Grade = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    Rate = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Type = table.Column<string>(type: "nchar(1)", fixedLength: true, maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Sub_Holidays",
                columns: table => new
                {
                    Holiday = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sub_Holidays", x => x.Holiday);
                });

            migrationBuilder.CreateTable(
                name: "Sub_Incentive_Forms",
                columns: table => new
                {
                    IID = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    SysCode = table.Column<string>(type: "nchar(3)", fixedLength: true, maxLength: 3, nullable: false),
                    CatCode = table.Column<string>(type: "nchar(1)", fixedLength: true, maxLength: 1, nullable: false),
                    OfficialNo = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: false),
                    ApplliedIncentive = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: false),
                    EffectDate = table.Column<DateTime>(type: "date", nullable: false),
                    DateofEnlistment = table.Column<DateTime>(type: "date", nullable: true),
                    NavalService = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    ServiceBreak = table.Column<bool>(type: "bit", nullable: true),
                    WarrantPunishment = table.Column<bool>(type: "bit", nullable: true),
                    CurrentIncentive = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Saveon = table.Column<DateTime>(type: "datetime", nullable: true),
                    DSysCode = table.Column<string>(type: "nchar(3)", fixedLength: true, maxLength: 3, nullable: true),
                    DCatCode = table.Column<string>(type: "nchar(1)", fixedLength: true, maxLength: 1, nullable: true),
                    DOfficialNo = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    Forward = table.Column<bool>(type: "bit", nullable: true),
                    Forwardon = table.Column<DateTime>(type: "datetime", nullable: true),
                    Remarks = table.Column<string>(type: "nchar(100)", fixedLength: true, maxLength: 100, nullable: true),
                    Reject = table.Column<bool>(type: "bit", nullable: true),
                    BaseCode = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    ActionTaken = table.Column<bool>(type: "bit", nullable: false),
                    PayAction = table.Column<bool>(type: "bit", nullable: false),
                    TransID = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sub_Incentive_Forms", x => new { x.IID, x.SysCode, x.CatCode, x.OfficialNo, x.ApplliedIncentive, x.EffectDate });
                });

            migrationBuilder.CreateTable(
                name: "Sub_Incentive_Forms_Receivers",
                columns: table => new
                {
                    IID = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    Unit = table.Column<int>(type: "int", nullable: false),
                    BaseCode = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    FOrder = table.Column<int>(type: "int", nullable: true),
                    SSysCode = table.Column<string>(type: "char(3)", unicode: false, fixedLength: true, maxLength: 3, nullable: true),
                    SCatCode = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    SOfficialNo = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    SAction = table.Column<bool>(type: "bit", nullable: true),
                    SOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    SecSysCode = table.Column<string>(type: "char(3)", unicode: false, fixedLength: true, maxLength: 3, nullable: true),
                    SecCatCode = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    SecOfficialNo = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    SecAction = table.Column<bool>(type: "bit", nullable: true),
                    SecOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    ASysCode = table.Column<string>(type: "nchar(3)", fixedLength: true, maxLength: 3, nullable: true),
                    ACatCode = table.Column<string>(type: "nchar(1)", fixedLength: true, maxLength: 1, nullable: true),
                    AOfficialNo = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    AAction = table.Column<bool>(type: "bit", nullable: true),
                    AOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    Rejected = table.Column<bool>(type: "bit", nullable: true),
                    RejectedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    Remarks = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sub_Incentive_Forms_Receivers", x => new { x.IID, x.Unit });
                });

            migrationBuilder.CreateTable(
                name: "Sub_Logs",
                columns: table => new
                {
                    LUserId = table.Column<string>(type: "nchar(50)", fixedLength: true, maxLength: 50, nullable: false),
                    LDescription = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: false),
                    Log_on = table.Column<DateTime>(type: "datetime", nullable: false),
                    IPaddress = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sub_Logs", x => new { x.LUserId, x.LDescription, x.Log_on });
                });

            migrationBuilder.CreateTable(
                name: "Sub_Maternity_Trans_Details",
                columns: table => new
                {
                    TransId = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: false),
                    ItemCode = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: false),
                    OfficialNo = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    ItemCategory = table.Column<string>(type: "nchar(1)", fixedLength: true, maxLength: 1, nullable: false),
                    BaseCode = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: false),
                    SysCode = table.Column<string>(type: "nchar(3)", fixedLength: true, maxLength: 3, nullable: false),
                    CatCode = table.Column<string>(type: "nchar(1)", fixedLength: true, maxLength: 1, nullable: false),
                    EffectDate = table.Column<DateTime>(type: "date", nullable: false),
                    Edit = table.Column<bool>(type: "bit", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Remarks = table.Column<string>(type: "nchar(150)", fixedLength: true, maxLength: 150, nullable: true),
                    Reject = table.Column<bool>(type: "bit", nullable: false),
                    EditedBy = table.Column<string>(type: "nchar(50)", fixedLength: true, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sub_Maternity_Trans_Details", x => new { x.TransId, x.ItemCode, x.OfficialNo });
                });

            migrationBuilder.CreateTable(
                name: "Sub_Maternity_Trans_Master",
                columns: table => new
                {
                    TransId = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: false),
                    PayMonth = table.Column<double>(type: "float", nullable: false),
                    UnitCode = table.Column<int>(type: "int", nullable: false),
                    BaseCode = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: false),
                    LeaveType = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: false),
                    SysCode = table.Column<string>(type: "nchar(3)", fixedLength: true, maxLength: 3, nullable: true),
                    CatCode = table.Column<string>(type: "nchar(1)", fixedLength: true, maxLength: 1, nullable: true),
                    OfficialNo = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    NOFLeaves = table.Column<int>(type: "int", nullable: true),
                    FromDt = table.Column<DateTime>(type: "date", nullable: true),
                    ToDt = table.Column<DateTime>(type: "date", nullable: true),
                    Remarks = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TSave = table.Column<bool>(type: "bit", nullable: false),
                    TSaveSysCode = table.Column<string>(type: "nchar(3)", fixedLength: true, maxLength: 3, nullable: true),
                    TSaveCatCode = table.Column<string>(type: "nchar(1)", fixedLength: true, maxLength: 1, nullable: true),
                    TSaveBy = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    TSaveOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    TConfirm = table.Column<bool>(type: "bit", nullable: false),
                    TConfirmSysCode = table.Column<string>(type: "nchar(3)", fixedLength: true, maxLength: 3, nullable: true),
                    TConfirmCatCode = table.Column<string>(type: "nchar(1)", fixedLength: true, maxLength: 1, nullable: true),
                    TConfirmBy = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    TConfirmOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    TForward = table.Column<bool>(type: "bit", nullable: false),
                    TForwardSysCode = table.Column<string>(type: "nchar(3)", fixedLength: true, maxLength: 3, nullable: true),
                    TForwardCatCode = table.Column<string>(type: "nchar(1)", fixedLength: true, maxLength: 1, nullable: true),
                    TForwardBy = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    TForwardOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    TPayHead = table.Column<bool>(type: "bit", nullable: false),
                    TPayHeadSysCode = table.Column<string>(type: "nchar(3)", fixedLength: true, maxLength: 3, nullable: true),
                    TPayHeadCatCode = table.Column<string>(type: "nchar(1)", fixedLength: true, maxLength: 1, nullable: true),
                    THeadBy = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    TPayHeadOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    TSubject = table.Column<bool>(type: "bit", nullable: false),
                    TSubClarkSysCode = table.Column<string>(type: "nchar(3)", fixedLength: true, maxLength: 3, nullable: true),
                    TSubClarkCatCode = table.Column<string>(type: "nchar(1)", fixedLength: true, maxLength: 1, nullable: true),
                    TSubClarkBy = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    TSubClarkOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    TAuditStaff = table.Column<bool>(type: "bit", nullable: false),
                    TSAuditSysCode = table.Column<string>(type: "nchar(3)", fixedLength: true, maxLength: 3, nullable: true),
                    TSAuditCatCode = table.Column<string>(type: "nchar(1)", fixedLength: true, maxLength: 1, nullable: true),
                    TSAuditOfficialNo = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    TSAuditedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    TAudit = table.Column<bool>(type: "bit", nullable: false),
                    TAuditSysCode = table.Column<string>(type: "nchar(3)", fixedLength: true, maxLength: 3, nullable: true),
                    TAuditCatCode = table.Column<string>(type: "nchar(1)", fixedLength: true, maxLength: 1, nullable: true),
                    TAuditOfficialNo = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    TAuditedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    TSSO = table.Column<bool>(type: "bit", nullable: false),
                    TSSOSysCode = table.Column<string>(type: "nchar(3)", fixedLength: true, maxLength: 3, nullable: true),
                    TSSOCatCode = table.Column<string>(type: "nchar(1)", fixedLength: true, maxLength: 1, nullable: true),
                    TSSOBy = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    TSSOOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    TReject = table.Column<bool>(type: "bit", nullable: false),
                    TRejectSysCode = table.Column<string>(type: "nchar(3)", fixedLength: true, maxLength: 3, nullable: true),
                    TRejectCatCode = table.Column<string>(type: "nchar(1)", fixedLength: true, maxLength: 1, nullable: true),
                    TRejectby = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    TRejectOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    TRejectReason = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Path = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sub_Maternity_Trans_Master", x => new { x.TransId, x.PayMonth, x.UnitCode, x.BaseCode, x.LeaveType });
                });

            migrationBuilder.CreateTable(
                name: "Sub_Role",
                columns: table => new
                {
                    SysCode = table.Column<string>(type: "nchar(3)", fixedLength: true, maxLength: 3, nullable: false),
                    CatCode = table.Column<string>(type: "nchar(1)", fixedLength: true, maxLength: 1, nullable: false),
                    OfficialNo = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: false),
                    Role = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    ActiveOn = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sub_Role", x => new { x.SysCode, x.CatCode, x.OfficialNo });
                });

            migrationBuilder.CreateTable(
                name: "Sub_Role_Allowances",
                columns: table => new
                {
                    SysCode = table.Column<string>(type: "nchar(3)", fixedLength: true, maxLength: 3, nullable: false),
                    CatCode = table.Column<string>(type: "nchar(1)", fixedLength: true, maxLength: 1, nullable: false),
                    OfficialNo = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: false),
                    ActiveOn = table.Column<DateTime>(type: "datetime", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    BaseCode = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    Unit = table.Column<int>(type: "int", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    DeactiveOn = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sub_Role_Allowances", x => new { x.SysCode, x.CatCode, x.OfficialNo, x.ActiveOn });
                });

            migrationBuilder.CreateTable(
                name: "Sub_SubItems",
                columns: table => new
                {
                    SubjectID = table.Column<int>(type: "int", nullable: false),
                    ItemCode = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: false),
                    BaseCode = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: false),
                    Log_Id = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sub_SubItems", x => new { x.SubjectID, x.ItemCode, x.BaseCode });
                });

            migrationBuilder.CreateTable(
                name: "Sub_Subjects",
                columns: table => new
                {
                    Sub_Id = table.Column<int>(type: "int", nullable: false),
                    Subject = table.Column<string>(type: "nchar(35)", fixedLength: true, maxLength: 35, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sub_Subjects", x => x.Sub_Id);
                });

            migrationBuilder.CreateTable(
                name: "Sub_Trans_Details",
                columns: table => new
                {
                    TransId = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: false),
                    PayMonth = table.Column<double>(type: "float", nullable: false),
                    SubjectCode = table.Column<int>(type: "int", nullable: false),
                    BaseCode = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: false),
                    Remarks = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TSave = table.Column<bool>(type: "bit", nullable: false),
                    TSaveSysCode = table.Column<string>(type: "nchar(3)", fixedLength: true, maxLength: 3, nullable: true),
                    TSaveCatCode = table.Column<string>(type: "nchar(1)", fixedLength: true, maxLength: 1, nullable: true),
                    TSaveBy = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    TSaveOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    TConfirm = table.Column<bool>(type: "bit", nullable: false),
                    TConfirmSysCode = table.Column<string>(type: "nchar(3)", fixedLength: true, maxLength: 3, nullable: true),
                    TConfirmCatCode = table.Column<string>(type: "nchar(1)", fixedLength: true, maxLength: 1, nullable: true),
                    TConfirmBy = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    TConfirmOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    TForward = table.Column<bool>(type: "bit", nullable: false),
                    TForwardSysCode = table.Column<string>(type: "nchar(3)", fixedLength: true, maxLength: 3, nullable: true),
                    TForwardCatCode = table.Column<string>(type: "nchar(1)", fixedLength: true, maxLength: 1, nullable: true),
                    TForwardBy = table.Column<string>(type: "nchar(25)", fixedLength: true, maxLength: 25, nullable: true),
                    TForwardOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    TPayHead = table.Column<bool>(type: "bit", nullable: false),
                    TPayHeadSysCode = table.Column<string>(type: "nchar(3)", fixedLength: true, maxLength: 3, nullable: true),
                    TPayHeadCatCode = table.Column<string>(type: "nchar(1)", fixedLength: true, maxLength: 1, nullable: true),
                    THead = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    TPayHeadOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    TSubject = table.Column<bool>(type: "bit", nullable: false),
                    TSubClarkSysCode = table.Column<string>(type: "nchar(3)", fixedLength: true, maxLength: 3, nullable: true),
                    TSubClarlCatCode = table.Column<string>(type: "nchar(1)", fixedLength: true, maxLength: 1, nullable: true),
                    TSubClark = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    TSubClarkOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    TReject = table.Column<bool>(type: "bit", nullable: false),
                    TRejectSysCode = table.Column<string>(type: "nchar(3)", fixedLength: true, maxLength: 3, nullable: true),
                    TRejectCatCode = table.Column<string>(type: "nchar(1)", fixedLength: true, maxLength: 1, nullable: true),
                    TRejectby = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    TRejectOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    TRejectReason = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sub_Trans_Details", x => new { x.TransId, x.PayMonth, x.SubjectCode, x.BaseCode });
                });

            migrationBuilder.CreateTable(
                name: "Sub_Transaction",
                columns: table => new
                {
                    TransId = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    SubjectId = table.Column<int>(type: "int", nullable: true),
                    PayMonth = table.Column<double>(type: "float", nullable: false),
                    SysCode = table.Column<string>(type: "nchar(3)", fixedLength: true, maxLength: 3, nullable: false),
                    CatCode = table.Column<string>(type: "nchar(1)", fixedLength: true, maxLength: 1, nullable: false),
                    OfficialNo = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: false),
                    BaseCode = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: false),
                    ItemCode = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: false),
                    ItemCategory = table.Column<string>(type: "nchar(1)", fixedLength: true, maxLength: 1, nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Process = table.Column<bool>(type: "bit", nullable: true),
                    PrcoessAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ProcessAmtChanged = table.Column<bool>(type: "bit", nullable: true),
                    Remarks = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Sub_Transaction_History",
                columns: table => new
                {
                    TransId = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    SubjectId = table.Column<int>(type: "int", nullable: true),
                    PayMonth = table.Column<double>(type: "float", nullable: false),
                    SysCode = table.Column<string>(type: "nchar(3)", fixedLength: true, maxLength: 3, nullable: false),
                    CatCode = table.Column<string>(type: "nchar(1)", fixedLength: true, maxLength: 1, nullable: false),
                    OfficialNo = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: false),
                    BaseCode = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: false),
                    ItemCode = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: false),
                    ItemCategory = table.Column<string>(type: "nchar(1)", fixedLength: true, maxLength: 1, nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Process = table.Column<bool>(type: "bit", nullable: true),
                    PrcoessAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ProcessAmtChanged = table.Column<bool>(type: "bit", nullable: true),
                    Remarks = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Sub_TransactionFile_Path_D",
                columns: table => new
                {
                    TransId = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    Path = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Sub_TransId",
                columns: table => new
                {
                    SubjectID = table.Column<int>(type: "int", nullable: false),
                    TransId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Sub_Units_D",
                columns: table => new
                {
                    UnitCode = table.Column<string>(type: "nchar(2)", fixedLength: true, maxLength: 2, nullable: true),
                    UnitName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Sub_Units_Details_Allowances",
                columns: table => new
                {
                    Unit = table.Column<string>(type: "nchar(20)", fixedLength: true, maxLength: 20, nullable: true),
                    AllowanceCode = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "SystemFreeze",
                columns: table => new
                {
                    Freeze = table.Column<bool>(type: "bit", nullable: false),
                    UpdateOn = table.Column<DateTime>(type: "datetime", nullable: false),
                    SysCode = table.Column<string>(type: "nchar(3)", fixedLength: true, maxLength: 3, nullable: false),
                    CatCode = table.Column<string>(type: "nchar(1)", fixedLength: true, maxLength: 1, nullable: false),
                    OfficialNo = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TempAllowanceTrans",
                columns: table => new
                {
                    BaseCode = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    SysCode = table.Column<string>(type: "nchar(3)", fixedLength: true, maxLength: 3, nullable: true),
                    CatCode = table.Column<string>(type: "nchar(1)", fixedLength: true, maxLength: 1, nullable: true),
                    OfficialNo = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    ItemCode = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TempAllowanceTransaction",
                columns: table => new
                {
                    SysCode = table.Column<string>(type: "nchar(3)", fixedLength: true, maxLength: 3, nullable: true),
                    CatCode = table.Column<string>(type: "nchar(1)", fixedLength: true, maxLength: 1, nullable: true),
                    OfficialNo = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    EffectDt = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TempTransaction",
                columns: table => new
                {
                    BaseCode = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    SysCode = table.Column<string>(type: "nchar(3)", fixedLength: true, maxLength: 3, nullable: true),
                    CatCode = table.Column<string>(type: "nchar(1)", fixedLength: true, maxLength: 1, nullable: true),
                    OfficialNo = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    ItemCode = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    email = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    email_verified_at = table.Column<DateTime>(type: "datetime", nullable: true),
                    password = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    remember_token = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime", nullable: true),
                    updated_at = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Sub_327_List",
                columns: table => new
                {
                    TransId = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    SysCode = table.Column<string>(type: "nchar(3)", fixedLength: true, maxLength: 3, nullable: false),
                    CatCode = table.Column<string>(type: "nchar(1)", fixedLength: true, maxLength: 1, nullable: false),
                    OfficialNo = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: false),
                    PayMonth = table.Column<int>(type: "int", nullable: false),
                    _605606 = table.Column<int>(name: "605/606", type: "int", nullable: true),
                    _605A606A = table.Column<int>(name: "605A/606A", type: "int", nullable: true),
                    _610611 = table.Column<int>(name: "610/611", type: "int", nullable: true),
                    _612613 = table.Column<int>(name: "612/613", type: "int", nullable: true),
                    _615614 = table.Column<int>(name: "615/614", type: "int", nullable: true),
                    _690 = table.Column<int>(name: "690", type: "int", nullable: true),
                    _686687 = table.Column<int>(name: "686/687", type: "int", nullable: true),
                    _688689 = table.Column<int>(name: "688/689", type: "int", nullable: true),
                    _598 = table.Column<int>(name: "598", type: "int", nullable: true),
                    _596 = table.Column<int>(name: "596", type: "int", nullable: true),
                    _600 = table.Column<int>(name: "600", type: "int", nullable: true),
                    _630 = table.Column<int>(name: "630", type: "int", nullable: true),
                    _619 = table.Column<int>(name: "619", type: "int", nullable: true),
                    ItemCat = table.Column<string>(type: "nchar(1)", fixedLength: true, maxLength: 1, nullable: true),
                    ItemCode = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sub_327_List_1", x => new { x.TransId, x.OrderId });
                    table.ForeignKey(
                        name: "FK_Sub_327_List_Sub_327_List",
                        column: x => x.TransId,
                        principalTable: "Sub_327Adjustment_Trans",
                        principalColumn: "TransId");
                });

            migrationBuilder.CreateIndex(
                name: "failed_jobs_uuid_unique",
                table: "failed_jobs",
                column: "uuid",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "password_resets_email_index",
                table: "password_resets",
                column: "email");

            migrationBuilder.CreateIndex(
                name: "personal_access_tokens_token_unique",
                table: "personal_access_tokens",
                column: "token",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "personal_access_tokens_tokenable_type_tokenable_id_index",
                table: "personal_access_tokens",
                columns: new[] { "tokenable_type", "tokenable_id" });

            migrationBuilder.CreateIndex(
                name: "NonClusteredIndex-20220106-152019",
                table: "Sub_Transaction",
                column: "TransId");

            migrationBuilder.CreateIndex(
                name: "users_email_unique",
                table: "users",
                column: "email",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "failed_jobs");

            migrationBuilder.DropTable(
                name: "migrations");

            migrationBuilder.DropTable(
                name: "password_resets");

            migrationBuilder.DropTable(
                name: "Pay_Basic_Rank_Scale_D");

            migrationBuilder.DropTable(
                name: "Pay_Basic_Scale_D");

            migrationBuilder.DropTable(
                name: "Pay_ProcessMonth");

            migrationBuilder.DropTable(
                name: "Pay_Rank_D");

            migrationBuilder.DropTable(
                name: "personal_access_tokens");

            migrationBuilder.DropTable(
                name: "Sub_327_Action");

            migrationBuilder.DropTable(
                name: "Sub_327_List");

            migrationBuilder.DropTable(
                name: "Sub_327Items");

            migrationBuilder.DropTable(
                name: "Sub_Allowance_Areas");

            migrationBuilder.DropTable(
                name: "Sub_Allowance_Incentives");

            migrationBuilder.DropTable(
                name: "Sub_Allowances_ArrearsCodes");

            migrationBuilder.DropTable(
                name: "Sub_Allowances_Branch");

            migrationBuilder.DropTable(
                name: "Sub_Allowances_CAlGroup");

            migrationBuilder.DropTable(
                name: "Sub_Allowances_Conditions");

            migrationBuilder.DropTable(
                name: "Sub_Allowances_Group");

            migrationBuilder.DropTable(
                name: "Sub_Allowances_Log");

            migrationBuilder.DropTable(
                name: "Sub_Allowances_OverPayCodes");

            migrationBuilder.DropTable(
                name: "Sub_Allowances_Ranks");

            migrationBuilder.DropTable(
                name: "Sub_Allowances_Restricted");

            migrationBuilder.DropTable(
                name: "Sub_Allowances_SubItems");

            migrationBuilder.DropTable(
                name: "Sub_Allowances_Subjects");

            migrationBuilder.DropTable(
                name: "Sub_Allowances_SYS_CAT");

            migrationBuilder.DropTable(
                name: "Sub_Allowances_Trans_Details");

            migrationBuilder.DropTable(
                name: "Sub_Allowances_Trans_Details_History");

            migrationBuilder.DropTable(
                name: "Sub_Allowances_Trans_Details_History_1");

            migrationBuilder.DropTable(
                name: "Sub_Allowances_Trans_Master");

            migrationBuilder.DropTable(
                name: "Sub_Allowances_TransId");

            migrationBuilder.DropTable(
                name: "Sub_Attachments");

            migrationBuilder.DropTable(
                name: "Sub_Base_Change");

            migrationBuilder.DropTable(
                name: "Sub_BaseMatching");

            migrationBuilder.DropTable(
                name: "Sub_ExtraDuty_Master");

            migrationBuilder.DropTable(
                name: "Sub_ExtraDutyDetails");

            migrationBuilder.DropTable(
                name: "Sub_ExtraDutyDetails_History");

            migrationBuilder.DropTable(
                name: "Sub_Final_Pay_327_List");

            migrationBuilder.DropTable(
                name: "Sub_Final_Pay_Details");

            migrationBuilder.DropTable(
                name: "Sub_Final_Pay_Head_Details");

            migrationBuilder.DropTable(
                name: "Sub_Final_Pay_Item_List");

            migrationBuilder.DropTable(
                name: "Sub_Final_Pay_Items");

            migrationBuilder.DropTable(
                name: "Sub_Final_Pay_Log_Details");

            migrationBuilder.DropTable(
                name: "Sub_Grade_Details");

            migrationBuilder.DropTable(
                name: "Sub_Grade_Rates");

            migrationBuilder.DropTable(
                name: "Sub_Holidays");

            migrationBuilder.DropTable(
                name: "Sub_Incentive_Forms");

            migrationBuilder.DropTable(
                name: "Sub_Incentive_Forms_Receivers");

            migrationBuilder.DropTable(
                name: "Sub_Logs");

            migrationBuilder.DropTable(
                name: "Sub_Maternity_Trans_Details");

            migrationBuilder.DropTable(
                name: "Sub_Maternity_Trans_Master");

            migrationBuilder.DropTable(
                name: "Sub_Role");

            migrationBuilder.DropTable(
                name: "Sub_Role_Allowances");

            migrationBuilder.DropTable(
                name: "Sub_SubItems");

            migrationBuilder.DropTable(
                name: "Sub_Subjects");

            migrationBuilder.DropTable(
                name: "Sub_Trans_Details");

            migrationBuilder.DropTable(
                name: "Sub_Transaction");

            migrationBuilder.DropTable(
                name: "Sub_Transaction_History");

            migrationBuilder.DropTable(
                name: "Sub_TransactionFile_Path_D");

            migrationBuilder.DropTable(
                name: "Sub_TransId");

            migrationBuilder.DropTable(
                name: "Sub_Units_D");

            migrationBuilder.DropTable(
                name: "Sub_Units_Details_Allowances");

            migrationBuilder.DropTable(
                name: "SystemFreeze");

            migrationBuilder.DropTable(
                name: "TempAllowanceTrans");

            migrationBuilder.DropTable(
                name: "TempAllowanceTransaction");

            migrationBuilder.DropTable(
                name: "TempTransaction");

            migrationBuilder.DropTable(
                name: "users");

            migrationBuilder.DropTable(
                name: "Sub_327Adjustment_Trans");
        }
    }
}
