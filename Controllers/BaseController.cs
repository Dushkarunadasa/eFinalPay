using FinaPay.Contract;
using FinaPay.Models;
using FinaPay.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using Microsoft.AspNetCore.Http;

namespace FinaPay.Controllers
{
    public class BaseController : Controller
    {

        private readonly IMainServices _Iss;
        private readonly IPayDetails _IPayIss;
        private readonly ILoginDetails _ILog;
        private readonly IBaseRecovery _IBaseRecoveries;
        private readonly IRecoveryServices _RecoveryServices;
        private IHttpContextAccessor _accessor;
        public BaseController(IMainServices Iss, IPayDetails IPayIss, ILoginDetails ILog, IBaseRecovery iBaseRecoveries, IRecoveryServices recoveryServices, IHttpContextAccessor accessor)
        {
            _Iss = Iss;
            _IPayIss = IPayIss;
            _ILog = ILog;
            _IBaseRecoveries = iBaseRecoveries;
            _RecoveryServices = recoveryServices;
            _accessor = accessor;
            _ILog.UpdateUserDetail(_accessor.HttpContext.Request.Cookies["SysCode"], _accessor.HttpContext.Request.Cookies["CatCode"], _accessor.HttpContext.Request.Cookies["officialNo"], _accessor.HttpContext.Request.Cookies["UserName"], _accessor.HttpContext.Request.Cookies["baseCode"], Convert.ToInt32(_accessor.HttpContext.Request.Cookies["UnitID"].ToString()), _accessor.HttpContext.Request.Cookies["UserRoll"]);

           
        }
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Edit()
        {
            string Base = _ILog.getBaseCode();
            IEnumerable<SubFinalPayHeadDetail> AllTrans = await _IBaseRecoveries.GetPendingTransactions(Base);
            return View(AllTrans);

        }

        public async Task<IActionResult> RecoveryPendingList(int? id)
        {
            @ViewBag.Message = id;
            if (id == null || id == 0)
            {
                return NotFound();
            }

            IEnumerable<SubFinalPay327List> ListRec = await _IBaseRecoveries.GetEnteredRecovertList(id);
            return View(ListRec);


        }
        public async Task<IActionResult> RecoveryEntry(int id)
        {

            if (id == 0)
            {
                return NotFound();
            }

            var FormDetails = new SubFinalPay327List();
            FormDetails.TransId = id.ToString();
            int OrderId = _IBaseRecoveries.GetOrderID(id);
            FormDetails.OrderId = OrderId;
            return View(FormDetails);
        }

        public async Task<IActionResult> RecoveryInsert(SubFinalPay327List obj)
        {
            string TransId = obj.TransId.ToString();
            int OrderId = obj.OrderId;
            int TID = Convert.ToInt32(obj.TransId);
            string remarks = string.Empty;


            string userRole = _ILog.GetUserRoll();
            if (userRole == "1")
            {
                remarks = " Inserted 327 Details Subj";
            }
            else if (userRole == "2")
            {
                remarks = " Inserted 327 Details Sec";
            }
            else if (userRole == "3")
            {
                remarks = "  Inserted 327 Details CO";
            }



            ViewBag.Message = await _IBaseRecoveries.UpdateFinalPay327ItemList(obj);
            string IP = GetIPAddress();
            await _RecoveryServices.updateLog(new SubFinalPayLogDetail { TransId = TID, UnitId = _ILog.getUnitID(), UserId = _ILog.getUserName().ToString(), LogDetails = _ILog.GetUserRoll().ToString() + remarks, Logtime = DateTime.Now, Ip = IP });


            return RedirectToAction("RecoveryPendingList", new { id = TID });






        }



        private string GetIPAddress()
        {
            string ipAddress = _accessor.HttpContext.Connection.RemoteIpAddress.ToString();
            return ipAddress;
        }


        [Route("[Action]/{Tid}/{OrderId}")]
        public async Task<IActionResult> RecordDelete(String Tid, int OrderId)
        {
            int Transid = Convert.ToInt32(Tid);
            var result = await _IBaseRecoveries.Delete327Recovery(Tid, OrderId);
            string IP = GetIPAddress();
            string remarks = string.Empty;
            string userRole = _ILog.GetUserRoll();
            if (userRole == "1")
            {
                remarks = "  Delete 327 record by Subj";
            }
            else if (userRole == "2")
            {
                remarks = "  Delete 327 record by Sec";
            }
            else if (userRole == "3")
            {
                remarks = "  Delete 327 record by CO";
            }

            await _RecoveryServices.updateLog(new SubFinalPayLogDetail { TransId = Transid, UnitId = _ILog.getUnitID(), UserId = _ILog.getUserName().ToString(), LogDetails = _ILog.GetUserRoll().ToString() + remarks+ " Order ID " + OrderId, Logtime = DateTime.Now, Ip = IP });

            return RedirectToAction("RecoveryPendingList", new { id = Tid });
        }

        public async Task<IActionResult> Forward327ToSec(int id)
        {

            var recresult = await _IBaseRecoveries.GetEnteredRecovertList(id);

            if (recresult == null || recresult.Count() <= 0)
            {
                ViewBag.Error = "Please enter recovery before forward to Secretary.If no recoveries, then Nil report is required";
                // return NotFound();
            }
            else
            {

                var result = await _IBaseRecoveries.Forward327Recovery(id, _ILog.getUnitID(), 1);
                string IP = GetIPAddress();
                string remarks = string.Empty;
                string userRole = _ILog.GetUserRoll();
                if (userRole == "1")
                {
                    remarks = "  Forwarded 327 records by Subj";
                }
                else if (userRole == "2")
                {
                    remarks = "  Forwarded 327 records by Sec";
                }
                else if (userRole == "3")
                {
                    remarks = "  Forwarded 327 records by CO";
                }

                await _RecoveryServices.updateLog(new SubFinalPayLogDetail { TransId = id, UnitId = _ILog.getUnitID(), UserId = _ILog.getUserName().ToString(), LogDetails = _ILog.GetUserRoll().ToString() +  remarks, Logtime = DateTime.Now, Ip = IP });

                }
            return RedirectToAction("Edit");
        }
        public async Task<IActionResult> List(Boolean ActionTaken)
        {
            string Base = _ILog.getBaseCode();
            IEnumerable<SubFinalPayHeadDetail> AllTrans = await _IBaseRecoveries.Get327Transactions(Base,ActionTaken);
            return View(AllTrans);

        }
        public async Task<IActionResult> Details(int? id)
        {
            @ViewBag.Message = id;
            if (id == null || id == 0)
            {
                return NotFound();
            }

            IEnumerable<SubFinalPay327List> ListRec = await _IBaseRecoveries.GetEnteredRecovertList(id);
            return View(ListRec);

        }

    }
}
