using FinaPay.Models;
using FinaPay.PayModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using System.Resources;
using System.Xml.Linq;


namespace FinaPay.Contract
{
    public enum ESysCode
    {
        [Display(Name = "RNF")]
        RNF,

        [Display(Name = "VNF")]
        VNF
    }
    public enum ECatCode
    {
        [Display(Name = "O")]
        O,

        [Display(Name = "S")]
        S
    }

    public enum EType
    {
        [Display(Name = "Select")] Select, [Display(Name = "Retired")] Retired, [Display(Name = "Discharge")] Dischage, [Display(Name = "Death")] Death, [Display(Name ="Resicom")]Resicom,
        [Display(Name = "Payment Basic")] PaymentBasic, [Display(Name = "Discharge with disgrace")] DischargewithDisgrace, [Display(Name = "WithCom")] WithCom, [Display(Name = "CUL")] CUL
            , [Display(Name = "Medical Unfit")] MedicalUnfit, [Display(Name = "Other")] Other

    }
    public class SubInitiateContract
    {
        public int TransId { get; set; }
        public ESysCode SysCode { get; set; }

    

        public ECatCode CatCode { get; set; }
        [Required]
        public string OfficialNo { get; set; } = null!;
        [Required]
        public string? Type { get; set; }
        [Required]
        
        public string? NgReference { get; set; }
        [Required]
        [BindProperty, DataType(DataType.Date)]
        public DateTime? DischargeDt { get; set; }
        public bool PForm { get; set; }
        public string? PFormPath { get; set; }

        public List<SelectListItem> Bases { get; set; }
        [Required]
        public string BaseCode { get; set; }

        public List<SelectListItem> Bank { get; set; }
        [Required]
        public string BankCode { get; set; }

        public List<SelectListItem> Branch { get; set; }
        [Required]
        public string BranchCode { get; set; }

        public List<SelectListItem> Account { get; set; }
        [Required]
        public int? AccountNo { get; set; }
        public string? VoucherNo { get; set; }
        public string? VoucherDes { get; set; }
        public string? ChequeNo { get; set; }
        [BindProperty, DataType(DataType.Date)]
        public DateTime? ChequeDt { get; set; }
        [BindProperty, DataType(DataType.Date)]
        public DateTime? PaymentDt { get; set; }
        public bool ActionComplete { get; set; }
        public string? Remarks { get; set; }
    }
}
