using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace FinaPay.Contract
{
   
    
    public class UserSettingContract
    {    


        public ESysCode SysCode { get; set; }
        public ECatCode CatCode { get; set; }

        public string OfficialNo { get; set; }


        [Required]
        public int Unit { get; set; }

        [Required]
        public string Role   { get; set; }

        public DateTime ActiveOn { get; set; }
    }
}
