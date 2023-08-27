using FinaPay.Models;
using FinaPay.PayModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using System.Resources;
using System.Xml.Linq;


namespace FinaPay.Contract
{
   
 

 
    public class ProfileUpdateBasicContract
    {
        public int TransId { get; set; }
        public string SysCode { get; set; }
        public string CatCode { get; set; }
        [Required]
        public string OfficialNo { get; set; } = null!;
        [Required]
        public string? Type { get; set; }
        [Required]
        
        public string? NgReference { get; set; }
        [Required]
        //[BindProperty, DataType(DataType.Date)]
        public DateTime? DischargeDt { get; set; }
        public bool PForm { get; set; }
        public string? PFormPath { get; set; }

      
        public List<SelectListItem> Bases { get; set; }
        [Required]
        public string BaseCode { get; set; }

        public bool CheckPayment { get; set; }
        public List<SelectListItem> Bank { get; set; }
       
        public string BankCode { get; set; }

        public List<SelectListItem> Branch { get; set; }
       
        public string BranchCode { get; set; }

        public List<SelectListItem> Account { get; set; }
   
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
