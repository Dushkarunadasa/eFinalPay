using FinaPay.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Net.Http;
using System.Threading;
using System.Collections.Generic;
using System.Linq;

using System.Diagnostics.CodeAnalysis;

namespace FinaPay.Services
{
    public class LoginServices : ILoginServices
    {
        private readonly PaySubjectsContext _db;
        public LoginServices(PaySubjectsContext db)
        {
            _db = db;
        }

        async Task<IEnumerable<SubAllowancesSubject>> ILoginServices.GetAllUnits()
        {

            var list = new List<int>() { 2,3,4,5,6,8,9,12,13,14,15,16,17 };

            var PendingList = new List<Test1>();
            decimal total = 0;

            IEnumerable<SubAllowancesSubject> units = await _db.SubAllowancesSubjects.Where(s=>list.Contains(s.SubId)).Select(s => s).ToListAsync();
            return units;// _db.SubAllowancesSubjects.Select(s => s).ToList();
        }

        async Task<IEnumerable<SubRoleTypeAllowance>> ILoginServices.GetAllUser(int ID)
        {
            IEnumerable<SubRoleTypeAllowance> UsersRole;

            var groupId = await _db.SubAllowancesSubjects.Where(s => s.SubId == ID).Select(s => s.Type).SingleOrDefaultAsync();
            UsersRole = await _db.SubRoleTypeAllowances.Where(s => s.RoleGroup == groupId).OrderBy(s => s.RoleOrder).ToListAsync();
            return UsersRole;

        }
        async Task<string> ILoginServices.getRights(string SysCode, string catCode, string OfficialNo, int unitId, int Roll)
        {
            string BaseCode=string.Empty;
            //var result1 = _db.SubRoleTypeAllowances.Join(
            //    _db.SubAllowancesSubjects,
            //    o => new { o.RoleGroup },
            //    i => new { i.Type },
            //    (o, i) => i);

            var result1 = await (from D in _db.SubRoleTypeAllowances
                                 join E in _db.SubAllowancesSubjects on D.RoleGroup equals E.Type

                                 join E2 in _db.SubRoleAllowances on new { a = E.SubId, b = D.Role } equals new { a = E2.Unit, b = E2.Role }

                                 where E2.SysCode == SysCode && E2.CatCode == catCode && E2.OfficialNo == OfficialNo && E2.Active == true && E.SubId == unitId && D.RoleOrder == Roll
                                 select new { BaseCode = E2.BaseCode }).FirstOrDefaultAsync();             
                
                
            if (!ReferenceEquals(result1, null))
            {
               
                    BaseCode = result1.BaseCode;
                
            }
            return BaseCode;
        }

        async Task ILoginServices.updateLog(SubAllowancesLog lg)
        {
           await _db.SubAllowancesLogs.AddAsync(lg);
           await _db.SaveChangesAsync();
        }
        //async Task<string> GetRoll(string SysCode)
        //{
        //  var resul=  await _db.SubRoleTypeAllowances
        //}


    }
}
