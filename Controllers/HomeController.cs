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



namespace FinaPay.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMainServices _Iss;
        private readonly IPayDetails _IPayIss;
        private readonly ILoginDetails _ILog;
        public HomeController(IMainServices Iss, IPayDetails IPayIss, ILoginDetails ILog)
        {
            _Iss = Iss;
            _IPayIss = IPayIss;
            _ILog = ILog;
        }

        [Authorize]
        public IActionResult Index()
        {
           
           return View();
        }
        public IActionResult Authenticate()
        {
            // Login Process
            var userType=string.Empty;
            var Unit = _ILog.getUnitID();
            var Role = _ILog.GetUserRoll();
            if (Unit==14 || Unit==15 || Unit ==16 || Unit == 17 ||  Unit == 2 || Unit == 8 || Unit == 12)
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
                if (Unit==16)
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
            if (Unit==9)
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


            var claims = new List<Claim>();
            claims.Add(new Claim(ClaimTypes.Email, _ILog.getUserName()));      
            claims.Add(new Claim(ClaimTypes.Role , userType));
            claims.Add(new Claim(ClaimTypes.Actor , _ILog.getUnitID().ToString()));
            //Claims identity
            var idenitity = new ClaimsIdentity(claims, "Final login");
            //Claims Pricipls
            var userPrincipal = new ClaimsPrincipal(new[] { idenitity });
            HttpContext.SignInAsync(userPrincipal);
            return RedirectToAction("Index");
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
       
    
        [Authorize(Roles = "SMSubClerk,RecSubClerk")]
        
        public IActionResult RecoveryEntry()
        {
            return RedirectToAction("RecoveryPendingList", "Recovery");
        }
      
        [Authorize(Roles = "SMSec,RecSec")] 
        public IActionResult RecoveryForwardSec()
        {
            return RedirectToAction("RecoveryPendingList","RecSec");
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
        [Authorize(Roles = "DDNPay")]
        public IActionResult RecoveryForwardedListDDNP()
        {
            return RedirectToAction("RecoveryForwardedListDDN", "PayOffice");
        }
        [Authorize(Roles = "DDNPay")]
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



    }

}