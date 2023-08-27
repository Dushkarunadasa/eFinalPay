using FinaPay.Contract;
using FinaPay.Migrations;
using FinaPay.Models;
using FinaPay.Repositary;
using FinaPay.Services;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Newtonsoft.Json;
using System.Data;
using Microsoft.AspNetCore.HttpOverrides;
using System.Diagnostics.Contracts;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.ServiceModel;
using System.Web;
using System.Net;
using FinaPay.HRMSModels;
using Newtonsoft.Json.Linq;
using Microsoft.Extensions.Caching.Memory;
using static System.Net.Mime.MediaTypeNames;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;

namespace FinaPay.Controllers
{

    public class LoginController : Controller
    {
        private readonly ILoginServices _Iss;
        private readonly IRepositary _Ips;
        private readonly ILoginDetails _ILog;
        private readonly IHrmsDetails _Ihrms;
        private IHttpContextAccessor _accessor;

        public LoginController(ILoginServices ISS, IRepositary Ips, ILoginDetails iLog, IHrmsDetails Ihrms, IHttpContextAccessor accessor)
        {
            _Iss = ISS;
            _Ips = Ips;
            _ILog = iLog;
            _Ihrms = Ihrms;
            _accessor = accessor;
        }

        public IActionResult Index()
        {
            return View();
        }




        [HttpGet]
        public async Task<IActionResult> Login()
        {


            //this.ViewBag.ArtistId = new SelectList(this.db.Artists, "ArtistId", "Name", album.ArtistId);


            IEnumerable<SubAllowancesSubject> units = await _Iss.GetAllUnits();
            //this.ViewBag.Units = units;

            var loginHome = new SubLoginContract();
            loginHome.Units = new List<SelectListItem>();

            loginHome.Units.Add(new SelectListItem

            {

                Text = "Select Department",

                Value = "0"

            });
            foreach (var unit in units)
            {
                loginHome.Units.Add(new SelectListItem { Text = unit.Subject, Value = unit.SubId.ToString() });
            }

            return View(loginHome);

        }



        [HttpPost]
        // [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(SubLoginContract obj)
        {
            Boolean pagevalidity = false;
            string SysCode = String.Empty;
            string CatCode = String.Empty;
            string officialNo = String.Empty;
            var result = "0";
            var email = obj.UserName.ToString();
            var password = obj.Password.ToString();

            if (obj.UnitId > 0 && obj.RollId > 0)
            {
                SysCode = String.Empty;
                CatCode = String.Empty;
                officialNo = String.Empty;
                result = "0";
                email = obj.UserName.ToString();
                password = obj.Password.ToString();
                DataTable dt = new DataTable();
                using (var Client = new HttpClient())
                {

                    var client = await _Ips.GetInstanceAsync();
                    result = await _Ips.LoginAsync(email, password);

                }
                if (result == "1")
                {
                    // _ILog.UpdateUserDetail()

                    IEnumerable<HrisTPersonalDatum> Data = await _Ihrms.GetHRMSDateils(email);
                    foreach (var Detail in Data)
                    {
                        SysCode = Detail.ServiceType;
                        CatCode = Detail.OfficerSailor;
                        officialNo = Detail.OfficialNo.ToString();
                    }
                    if (officialNo == "")
                    {
                        pagevalidity = false;
                    }
                    else
                    {
                        string baseCode = string.Empty;
                        var baseCode1 = await _Iss.getRights(SysCode, CatCode, officialNo, obj.UnitId, obj.RollId);
                        if (baseCode1 != "")
                        {
                            _ILog.UpdateUserDetail(SysCode, CatCode, officialNo, email, baseCode1.ToString().Trim(), obj.UnitId, obj.RollId.ToString());





                            CookieOptions options = new CookieOptions();
                            options.Expires = DateTime.Now.AddDays(1);

                            _accessor.HttpContext.Response.Cookies.Append("SysCode", SysCode, options);
                            _accessor.HttpContext.Response.Cookies.Append("CatCode", CatCode, options);
                            _accessor.HttpContext.Response.Cookies.Append("officialNo", officialNo, options);
                            _accessor.HttpContext.Response.Cookies.Append("UserName", email, options);
                            _accessor.HttpContext.Response.Cookies.Append("baseCode", baseCode1, options);
                            _accessor.HttpContext.Response.Cookies.Append("UnitID", obj.UnitId.ToString(), options);
                            _accessor.HttpContext.Response.Cookies.Append("UserRoll", obj.RollId.ToString(), options);


                            string s = _accessor.HttpContext.Request.Cookies["SysCode"];
                            int unitss = obj.UnitId;
                            pagevalidity = true;
                        }
                        else
                        {
                            pagevalidity = false;
                        }
                    }
                }
                else
                {
                    pagevalidity = false;
                }
            }
            else
            {
                pagevalidity = false;

            }
            if (pagevalidity == true)
            {
                string IP = GetIPAddress();

                await _Iss.updateLog(new SubAllowancesLog { Ipaddress = IP, Ldescription = obj.UnitId.ToString() + "- Unit  " + obj.RollId.ToString() + " - Roll Login", LogOn = DateTime.Now, LuserId = email });



                return RedirectToAction("Index", "Home");

            }
            IEnumerable<SubAllowancesSubject> units = await _Iss.GetAllUnits();
            obj.Units = new List<SelectListItem>();

            obj.Units.Add(new SelectListItem

            {

                Text = "Select Department/Unit",

                Value = "0"

            });


            foreach (var unit in units)
            {
                obj.Units.Add(new SelectListItem { Text = unit.Subject, Value = unit.SubId.ToString() });
            }

            @ViewBag.Message = "Invalid user Name or Password";
            return View(obj);

        }



        public async Task<JsonResult> GetRoll(int UnitId)
        {
            var userTypes = await _Iss.GetAllUser(UnitId);
            return Json(userTypes);
        }


        public async Task<IActionResult> Logout()
        {
            if (HttpContext.Request.Cookies["FinalPay.Cookie"] != null)
            {
                var siteCookies = HttpContext.Request.Cookies.Where(c => c.Key.StartsWith("FinalPay.Cookie"));
                foreach (var cookie in siteCookies)
                {
                    Response.Cookies.Delete(cookie.Key);
                }
            }
            return RedirectToAction("Login");
        }
        private string GetIPAddress()
        {
            string ipAddress = _accessor.HttpContext.Connection.RemoteIpAddress.ToString();
            return ipAddress;
        }
        //protected string GetIPAddress()
        //{
        //    System.Web.HttpContext context = System.Web.HttpContext.Current;
        //    string ipAddress = context.Request.ServerVariables["HTTP_X_FORWARDED_FOR"];

        //    if (!string.IsNullOrEmpty(ipAddress))
        //    {
        //        string[] addresses = ipAddress.Split(',');
        //        if (addresses.Length != 0)
        //        {
        //            return addresses[0];
        //        }
        //    }
        //    return context.Request.ServerVariables["REMOTE_ADDR"];

        //}
    }
}
