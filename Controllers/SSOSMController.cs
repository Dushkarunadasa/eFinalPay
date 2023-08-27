using FinaPay.Contract;
using FinaPay.Models;
using FinaPay.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FinaPay.Controllers
{
    public class SSOSMController : Controller
    {
 
        private readonly IPayDetails _IPayIss;
        private readonly ILoginDetails _ILog;
        private readonly IRecoveryServices _IRec;
        private IHttpContextAccessor _accessor;
        public SSOSMController(IMainServices Iss,  ILoginDetails ILog, IRecoveryServices IRec, IHttpContextAccessor accessor)
        {  
            _ILog = ILog;
            _IRec = IRec;
            _accessor = accessor;
            _ILog.UpdateUserDetail(_accessor.HttpContext.Request.Cookies["SysCode"], _accessor.HttpContext.Request.Cookies["CatCode"], _accessor.HttpContext.Request.Cookies["officialNo"], _accessor.HttpContext.Request.Cookies["UserName"], _accessor.HttpContext.Request.Cookies["baseCode"], Convert.ToInt32(_accessor.HttpContext.Request.Cookies["UnitID"].ToString()), _accessor.HttpContext.Request.Cookies["UserRoll"]);

        }
        public async Task<IActionResult> RecoveryPendingList()
        {
            IEnumerable<RecoveryCheckContract> AllTrans = await _IRec.GetReceivedRec(_ILog.getUnitID(), _ILog.GetUserRoll());
            return View(AllTrans);
        }
        public async Task<IActionResult> ActionPendingSSOSM()
        {
            IEnumerable<RecoveryCheckContract> AllTrans = await _IRec.GetReceivedActionPending(_ILog.getUnitID(), _ILog.GetUserRoll());
            return View(AllTrans);
        }


        public async Task<IActionResult> ActionTakenSSOSM()
        {
            IEnumerable<RecoveryCheckContract> AllTrans = await _IRec.GetReceivedActionTaken(_ILog.getUnitID(),_ILog.GetUserRoll());
            return View(AllTrans);
        }
        public async Task<IActionResult> RecoveryPendingListSec()
        {
            IEnumerable<RecoveryCheckContract> AllTrans = await _IRec.GetReceivedRecSec(_ILog.getUnitID(), _ILog.GetUserRoll());
            return View(AllTrans);
        }
        
        public async Task<IActionResult> RecoveryPendingListAuth()
        {
            IEnumerable<RecoveryCheckContract> AllTrans = await _IRec.GetReceivedRecAuth(_ILog.getUnitID(), _ILog.GetUserRoll(),2);
            return View(AllTrans);
        }

        public async Task<IActionResult> EditAuth(int id)
        {
            @ViewBag.Message = id;
            if (id == null || id == 0)
            {
                return NotFound();
            }
            IEnumerable<RecoveryCheckDetailContract> AllTrans = await _IRec.GetReceiveRecDetails(id);
            return View(AllTrans);

        }

        public async Task<IActionResult> EditSec(int id)
        {
            @ViewBag.Message = id;
            if (id == null || id == 0)
            {
                return NotFound();
            }
            IEnumerable<RecoveryCheckDetailContract> AllTrans = await _IRec.GetReceiveRecDetails(id);
            return View(AllTrans);

        }

        public async Task<IActionResult> Details(int id)
        {
            @ViewBag.Message = id;
            if (id == null || id == 0)
            {
                return NotFound();
            }
            IEnumerable<RecoveryCheckDetailContract> AllTrans = await _IRec.GetReceiveRecDetails(id);
            return View(AllTrans);

        }

        public async Task <IActionResult> Edit(int id)
        {
            @ViewBag.Message = id;
            if (id == null || id == 0)
            {
                return NotFound();
            }
            IEnumerable<RecoveryCheckDetailContract> AllTrans = await _IRec.GetReceiveRecDetails(id);
            return View(AllTrans);
         
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> RecoveryReject(Contract.SubRejectContract obj)
        {

            Boolean formvalid = true;
            int TransId = (int)obj.TransId;
            int UnitId = obj.UnitId;
            string reason=obj.RejectReason;

            if (reason.Trim() == "")
            {
                ViewBag.Message = "Reject Reason cannot be null or empty";
                formvalid = false;
            }
            else if (TransId == null)
            {
                ViewBag.Message = "TrasId Cannot be null or empty";
                formvalid = false;
            }
            else if (UnitId == null)
            {
                ViewBag.Message = "Unit Id Cannot be null";
                formvalid = false;
            }      
          
            if (formvalid == true)
            {
                await _IRec.UpdateRejectTrans(TransId, UnitId, reason);
                string IP = GetIPAddress();
                await _IRec.updateLog(new SubFinalPayLogDetail { TransId = TransId, UnitId = _ILog.getUnitID(), UserId = _ILog.getUserName().ToString(), LogDetails = obj.Unit + "frowarded recoveries rejected", Logtime = DateTime.Now, Ip = IP });

            }

           
            
                return RedirectToAction("Edit", new { id = TransId });
            

        }



        [Route("[Action]/{id}/{UnitId}")]
        public async Task<IActionResult> RecReject(int id, int UnitId)
        {
            @ViewBag.Message = id;
            if (id == null || id == 0)
            {
                return NotFound();
            }
            
            string unit=await _IRec.GetUnitName(UnitId);
            SubRejectContract obj=new SubRejectContract();
            obj.TransId = id;
            obj.UnitId = UnitId;
            obj.Unit = unit;
            return View(obj);



        
        }
        private string GetIPAddress()
        {
            string ipAddress = _accessor.HttpContext.Connection.RemoteIpAddress.ToString();
            return ipAddress;
        }

        public async Task<IActionResult> ForwardRecovery(int id)
        {

            var recresult = await _IRec.GetForwardedRecovertList(id);

            if (recresult.Count() > 0)
            {
                ViewBag.Error = "Pending Recoveries found,Pls check again";

                IEnumerable<RecoveryCheckDetailContract> AllTrans = await _IRec.GetReceiveRecDetails(id);
                          return RedirectToAction("Edit", "SSOSM",new {id});
               
            }
            else
            {
                var result = await _IRec.ForwardSubRecovery(id, _ILog.getUnitID(), 2);
                string IP = GetIPAddress();
                await _IRec.updateLog(new SubFinalPayLogDetail { TransId = id, UnitId = _ILog.getUnitID(), UserId = _ILog.getUserName().ToString(), LogDetails = _ILog.GetUserRoll().ToString() + " transactio forward to SSO(SM)sec", Logtime = DateTime.Now, Ip = IP });

                return RedirectToAction("RecoveryPendingList");
            }
            
        }


        public async Task<IActionResult> ForwardRecoverySec(int id)
        {

            
                var result = await _IRec.ForwardSubRecovery(id, _ILog.getUnitID(), 2);
                string IP = GetIPAddress();
            await _IRec.updateLog(new SubFinalPayLogDetail { TransId = id, UnitId = _ILog.getUnitID(), UserId = _ILog.getUserName().ToString(), LogDetails = _ILog.GetUserRoll().ToString() + " transaction forward to SSO(SM)", Logtime = DateTime.Now, Ip = IP });

            return RedirectToAction("RecoveryPendingListSec");
            

        }

        public async Task<IActionResult> ForwardRecoveryAuth(int id)
        {
            var result = await _IRec.ForwardSubRecovery(id, _ILog.getUnitID(), 2);
            string IP = GetIPAddress();
            await _IRec.updateLog(new SubFinalPayLogDetail { TransId = id, UnitId = _ILog.getUnitID(), UserId = _ILog.getUserName().ToString(), LogDetails = _ILog.GetUserRoll().ToString() + " transaction forward to DDN(Pay)", Logtime = DateTime.Now, Ip = IP });
            return RedirectToAction("RecoveryPendingListAuth");


        }
    }
}
