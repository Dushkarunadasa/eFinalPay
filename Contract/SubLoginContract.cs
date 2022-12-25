using FinaPay.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace FinaPay.Contract

{
    public class SubLoginContract
    {
        public List<SelectListItem>   Units { get; set; }
        public List<SelectListItem> Rolls { get; set; }

        public int UnitId { get; set; }
        public  int RollId { get; set; }
        [Required]
        [EmailAddress]      
        public string UserName { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }    


    }
}
