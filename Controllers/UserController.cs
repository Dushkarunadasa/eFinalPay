using Microsoft.AspNetCore.Mvc;
using FinaPay.Models;
using FinaPay.PayModels;
using FinaPay.Services;
using FinaPay.Contract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FinaPay.Controllers
{
    public class UserController : Controller
    {
        private readonly IPayDetails _Ipay;
        private readonly IRecoveryServices _IRec;
        private readonly ILoginDetails _ILog;
        private IHttpContextAccessor _accessor;

        public UserController(IPayDetails pay, IRecoveryServices rec, ILoginDetails log, IHttpContextAccessor accessor)
        {
            _Ipay = pay;
            _IRec = rec;
            _ILog = log;
            _accessor = accessor;

        }
        public async Task<IActionResult> Index()
        {
            int unit = _ILog.getUnitID();
            IEnumerable<SubRoleAllowance> Rolls = await _IRec.GetUsers(unit);
            return View(Rolls);
        }

        public async Task<IActionResult> Edit(int UnitId, string OfficialNo, string Role)
        {


            IEnumerable<SubRoleAllowance> roll = await _IRec.GetUsersDetails(UnitId, OfficialNo.Trim(), Role);
            UserSettingContract obj = new UserSettingContract();
            foreach (var item in roll)
            {
                obj.OfficialNo = item.OfficialNo;
                obj.Role = item.Role;
                obj.Unit = item.Unit;

            }

            return View(obj);
        }

        [HttpPost]
        public async Task<IActionResult> Update(FinaPay.Contract.UserSettingContract obj)
        {
            Boolean validity = true;
            if (!(obj.SysCode.ToString() == "RNF") )
            {
                if (!(obj.SysCode.ToString() == "VNF"))
                {
                    validity = false;
                    TempData["success"] = "First select the SysCode";
                }
            }
            else if (!(obj.SysCode.ToString() == "VNF"))
            {
                if (!(obj.SysCode.ToString() == "RNF"))
                {
                    validity = false;
                    TempData["success"] = "First select the SysCode";
                }
            }
            if (!(obj.CatCode.ToString() == "O")  )
            {
                if (!(obj.CatCode.ToString() == "S")  )
                {
                    validity = false;
                    TempData["success"] = "First select the CatCode";
                }
            }
            else if (!(obj.CatCode.ToString() == "S"))
            {
                if (!(obj.CatCode.ToString() == "O"))
                {
                    validity = false;
                    TempData["success"] = "First select the CatCode";
                }
            }
            if (obj.OfficialNo == null)
            {
                validity = false;
                TempData["success"] = "Official No cannot be empty";
            }
            else if (obj.OfficialNo.ToString().Trim() == "")
            {
                validity = false;
                TempData["success"] = "Official No cannot be empty";
            }
            else
            {
                var result = _Ipay.GetPerInfo(obj.SysCode.ToString(), obj.CatCode.ToString(), obj.OfficialNo.ToString());
                if ((result == null) || (result.Count() == 0))
                {
                    validity = false;
                    TempData["success"] = "Invalid Official No,Please Check the Official No";
                }
                else if ((obj.Role.Trim() == "Secretary") && (obj.CatCode.ToString().Trim() == "S"))
                {
                    validity = false;
                    TempData["success"] = "Secreatry Cannot be sailor";
                }
                else if ((obj.Role.Trim() == "Authorized") && (obj.CatCode.ToString().Trim() == "S"))
                {
                    validity = false;
                    TempData["success"] = "Authorized Officer Cannot be sailor";
                }
                string BaseCode = "";
                foreach (var Item in result)
                {
                    BaseCode = Item.BaseCode.ToString();
                }


                if (BaseCode.Trim() != _ILog.getBaseCode().Trim())
                {
                    validity = false;
                    TempData["success"] = "Selected naval person is out of the Base/Pls check again";
                }

                if (validity == true)
                {
                    await _IRec.updateUserDetails(obj.Unit, obj.OfficialNo, obj.Role, obj.SysCode.ToString(), obj.CatCode.ToString());
                    int unit = _ILog.getUnitID();
                    IEnumerable<SubRoleAllowance> Rolls = await _IRec.GetUsers(unit);
                    TempData["success"] = "User change setting has been updated";
                    return View("Index", Rolls);

                }
                else
                {

                    return View("Edit", obj);
                }

            }


            if (obj.OfficialNo == null)
            {
                return ViewBag.Error = "First Search the naval person";
            }

            return View("Edit", obj);
        }


        private string GetIPAddress()
        {
            string ipAddress = _accessor.HttpContext.Connection.RemoteIpAddress.ToString();
            return ipAddress;
        }
    }
}
