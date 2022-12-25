using Microsoft.AspNetCore.Mvc.Rendering;

namespace FinaPay.Contract
{
    public class SubRecoveryEntryContract
    {
        public int? TransId { get; set; }

   
        public List<SelectListItem> ItemCode { get; set; }
      
        public string ItemName { get; set; }


        public decimal Amount { get; set; }
        public string Remarks { get; set; }

    }
}
