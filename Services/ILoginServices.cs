using FinaPay.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace FinaPay.Services
{
    public interface ILoginServices
    {


        Task <IEnumerable<SubAllowancesSubject>> GetAllUnits();
        Task <IEnumerable<SubRoleTypeAllowance>> GetAllUser(int ID);

        Task <string> getRights(string SysCode,String catCode,string OfficialNo,int unitId,int Roll);


        Task updateLog(SubAllowancesLog lg); 

        //Task<string>GetRoll(string SysCode);






    }
}
