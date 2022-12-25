using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace FinaPay.Contract
{
    public class SubPayRecoveryContrat
    {

        public int  TransID { get; set; }
  
        public string ItemCode { get; set; }
      
        public string ItemName { get; set; }

  
        public decimal Amount { get; set; }
        public string Remarks { get; set; }


    }
}
