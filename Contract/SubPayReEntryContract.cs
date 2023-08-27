using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;


namespace FinaPay.Contract
{
    public class SubPayReEntryContract
    {
        public int? TransId { get; set; }
    
        public List<SelectListItem> ItemCode { get; set; }      
        public string ItemName { get; set; }
        public decimal Amount { get; set; }
        public int NofDays { get; set; }

        [Precision(18, 2)]
        public decimal IAmount { get; set; }

        

      

    }
}
