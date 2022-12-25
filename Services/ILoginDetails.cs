using FinaPay.Contract;
using System;

namespace FinaPay.Services
{
    public interface ILoginDetails
    {
        public void UpdateUserDetail(String sysCode, String catcode, String OfficialNo, string userName, string baseCode, int unitcode, string userRole);

        public string getUserName();


        public string getSysCode();

        public string getCatcode();

        public string getOfficialNo();

        public string getBaseCode();

        public int getUnitID();

        public string GetUserRoll();
       
    }
}
