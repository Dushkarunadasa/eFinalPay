using FinaPay.Contract;
using FinaPay.Models;
using FinaPay.PayModels;
using FinaPay.Services;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Options;
using System.Diagnostics;
using System.Reflection.Metadata;
using System.Security.Claims;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authentication.Cookies;


namespace FinaPay.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMainServices _Iss;
        private readonly IPayDetails _IPayIss;
        private readonly ILoginDetails _ILog;
        private readonly IBaseRecovery _Base;
        private IHttpContextAccessor _accessor;

        public HomeController(IMainServices Iss, IPayDetails IPayIss, ILoginDetails ILog, IBaseRecovery _base, IHttpContextAccessor accessor)
        {
            _Iss = Iss;
            _IPayIss = IPayIss;
            _ILog = ILog;
            _Base = _base;
            _accessor = accessor;
            _ILog.UpdateUserDetail(_accessor.HttpContext.Request.Cookies["SysCode"], _accessor.HttpContext.Request.Cookies["CatCode"], _accessor.HttpContext.Request.Cookies["officialNo"], _accessor.HttpContext.Request.Cookies["UserName"], _accessor.HttpContext.Request.Cookies["baseCode"], Convert.ToInt32(_accessor.HttpContext.Request.Cookies["UnitID"].ToString()), _accessor.HttpContext.Request.Cookies["UserRoll"]);

        }

        [Authorize]
        public IActionResult Index()
        {

            return View();
        }
        public IActionResult Authenticate()
        {
            // Login Process
            var userType = string.Empty;
            var Unit = _ILog.getUnitID();
            var Role = _ILog.GetUserRoll();
            if (Unit == 14 || Unit == 15 || Unit == 16 || Unit == 17 || Unit == 2 || Unit == 8 || Unit == 12 || Unit == 13 || Unit == 15 || Unit == 24||Unit==25||Unit==26)
            {
                if (Role == "1")
                {
                    userType = "RecSubClerk";
                }
                else if (Role == "2")
                {
                    userType = "RecSec";
                }
                else if (Role == "3")
                {
                    userType = "RecAuthorized";

                }
                if (Unit == 16)
                {
                    if (Role == "1")
                    {
                        userType = "SMSubClerk";

                    }
                    else if (Role == "2")
                    {
                        userType = "SMSec";
                    }
                    else if (Role == "3")
                    {

                        userType = "SMAuthorized";
                    }

                }

            }
            if (Unit == 9)
            {
                if (Role == "1")
                {
                    userType = "DDNPay";
                }
                if (Role == "2")
                {
                    userType = "PaySubClerk";
                }
                else if (Role == "3")
                {
                    userType = "PaySSailor";
                }
                else if (Role == "4")
                {
                    userType = "AuditSubClerk";
                }
                else if (Role == "5")
                {
                    userType = "AuditSSailor";
                }
                else if (Role == "6")
                {
                    userType = "AuditOfficer";
                }
                else if (Role == "7")
                {
                    userType = "SSOPay";
                }

                else if (Role == "8")
                {
                    userType = "PenSailor";
                }
                else if (Role == "9")
                {
                    userType = "PenSSailor";
                }
                else if (Role == "10")
                {
                    userType = "PenSSO";
                }

            }
            if (Unit == 4)
            {
                if (Role == "1")
                {
                    userType = "BaseSubClerk";

                }
                else if (Role == "2")
                {
                    userType = "BaseSec";
                }
                else if (Role == "3")
                {
                    userType = "BaseAuthorized";

                }
            }
            if (Unit == 3 || Unit == 5 || Unit == 6 || Unit == 19 || Unit == 20 || Unit == 21 || Unit == 22 || Unit == 23)
            {
                if (Role == "1")
                {
                    userType = "SubClerk";
                }

                else if (Role == "2")
                {
                    userType = "Authorized";
                }
            }


            //var claims = new List<Claim>();
            //claims.Add(new Claim(ClaimTypes.Email, _ILog.getUserName()));      
            //claims.Add(new Claim(ClaimTypes.Role , userType));
            //claims.Add(new Claim(ClaimTypes.Actor , _ILog.getUnitID().ToString()));
            ////Claims identity
            //var idenitity = new ClaimsIdentity(claims, "Final login");
            ////Claims Pricipls
            //var userPrincipal = new ClaimsPrincipal(new[] { idenitity });
            //HttpContext.SignInAsync(userPrincipal);
            //return RedirectToAction("Index");

            var claims = new List<Claim>();
            claims.Add(new Claim(ClaimTypes.Email, _ILog.getUserName()));
            claims.Add(new Claim(ClaimTypes.Role, userType));
            claims.Add(new Claim(ClaimTypes.Actor, _ILog.getUnitID().ToString()));
            var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
            var principle = new ClaimsPrincipal(identity);
            var props = new AuthenticationProperties();
            HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principle, props).Wait();
            return RedirectToAction("Index", "Home");
        }
        [HttpGet]
        [AllowAnonymous]
        public IActionResult AccessDenied()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        [HttpGet]

        [Authorize(Roles = "SMSubClerk")]
        public IActionResult RecoveryCheck()
        {
            return RedirectToAction("RecoveryPendingList", "SSOSM");
        }


        [Authorize(Roles = "SMSubClerk,SMSec,SMAuthorized")]
        public IActionResult PendingSSOSM()
        {
            return RedirectToAction("ActionPendingSSOSM", "SSOSM");
        }
        [Authorize(Roles = "SMSubClerk,SMSec,SMAuthorized")]
        public IActionResult ActionTakenSSOSM()
        {
            return RedirectToAction("ActionTakenSSOSM", "SSOSM");
        }

        [Authorize(Roles = "SMSec")]
        public IActionResult RecoveryCheckSec()
        {
            return RedirectToAction("RecoveryPendingListSec", "SSOSM");
        }
        [Authorize(Roles = "SMAuthorized")]
        public IActionResult RecoveryCheckAuth()
        {
            return RedirectToAction("RecoveryPendingListAuth", "SSOSM");
        }

        [Authorize(Roles = "PaySubClerk")]
        public IActionResult InitialEntry()
        {
            return RedirectToAction("Index", "PayOffice");
        }

        [Authorize(Roles = "PaySubClerk")]
        public IActionResult PayRecovery()
        {
            return RedirectToAction("PayRecovery", "PayOffice");
        }
        [Authorize(Roles = "PaySubClerk,SubClerk")]
        public IActionResult MasterData()
        {
            return RedirectToAction("EnteredList", "PayOffice");
        }

        [Authorize(Roles = "Authorized")]
        public IActionResult MasterDataApprove()
        {
            return RedirectToAction("EnteredListApprove", "PayOffice");
        }

        [Authorize(Roles = "SubClerk,Authorized")]
        public IActionResult ProfileApprovedList()
        {
            return RedirectToAction("EnteredListApproved", "PayOffice");
        }


        [Authorize(Roles = "SMSubClerk,RecSubClerk")]

        public IActionResult RecoveryEntry()
        {
            return RedirectToAction("RecoveryPendingList", "Recovery");
        }

        [Authorize(Roles = "SMSec,RecSec")]
        public IActionResult RecoveryForwardSec()
        {
            return RedirectToAction("RecoveryPendingList", "RecSec");
        }


        [Authorize(Roles = "SMAuthorized,RecAuthorized")]
        public IActionResult RecoveryForwardAuth()
        {
            return RedirectToAction("RecoveryPendingList", "RecAuthorize");
        }
        [Authorize(Roles = "SMSec,RecSec")]
        public IActionResult UserSetting()
        {
            return RedirectToAction("Index", "User");
        }


        [Authorize(Roles = "DDNPay")]
        public IActionResult RecoveryPendingListDDNP()
        {
            return RedirectToAction("RecoveryPendingListDDN", "PayOffice");
        }
        [Authorize(Roles = "DDNPay,SSOPay,PaySubClerk,PaySSailor,AuditSubClerk,AuditSSailor,AuditOfficer")]
        public IActionResult RecoveryForwardedListDDNP()
        {
            return RedirectToAction("RecoveryForwardedListDDN", "PayOffice");
        }
        [Authorize(Roles = "DDNPay,SSOPay,PaySubClerk,PaySSailor,AuditSubClerk,AuditSSailor,AuditOfficer")]
        public IActionResult RecoveryPendingList()
        {
            return RedirectToAction("RecoveryPendingList", "PayOffice");
        }
        [Authorize(Roles = "SMSubClerk,SMSec,SMAuthorized,RecSubClerk,RecSec,RecAuthorized")]
        public IActionResult ActionPending()
        {
            return RedirectToAction("ActionPending", "Recovery");
        }
        [Authorize(Roles = "SMSubClerk,SMSec,SMAuthorized,RecSubClerk,RecSec,RecAuthorized")]
        public IActionResult ActionTaken()
        {
            return RedirectToAction("ActionTaken", "Recovery");
        }


        [Authorize(Roles = "BaseSubClerk")]
        public IActionResult RecoveryEntry327()
        {
            return RedirectToAction("Edit", "Base");
        }


        [Authorize(Roles = "BaseSec")]
        public IActionResult RecoverySecEntry327()
        {
            return RedirectToAction("Edit", "Base");
        }


        [Authorize(Roles = "BaseAuthorized")]
        public IActionResult RecoveryAuthEntry327()
        {
            return RedirectToAction("Edit", "Base");
        }

        [Authorize(Roles = "BaseSec,BaseSubClerk,BaseAuthorized")]
        public IActionResult ActionPending327()
        {
            return RedirectToAction("List", "Base", new { @ActionTaken = false });
        }

        [Authorize(Roles = "BaseSubClerk,BaseSec,BaseAuthorized")]
        public IActionResult ActionTaken327()
        {
            return RedirectToAction("List", "Base", new { @ActionTaken = true });
        }
        [Authorize(Roles = "DDNPay")]
        public IActionResult RecoveryPendingList327DDNP()
        {
            return RedirectToAction("Allowance327DDN", "PayOffice");
        }

    }

}