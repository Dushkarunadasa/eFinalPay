using FinaPay.Contract;
using FinaPay.Models;
using FinaPay.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FinaPay.Controllers
{
    public class RecSecController : Controller


    {
        private readonly IMainServices _Iss;
        private readonly IPayDetails _IPayIss;
        private readonly ILoginDetails _ILog;
        private readonly IRecoveryServices _IRec;
        private IHttpContextAccessor _accessor;
        public RecSecController(IMainServices Iss, IPayDetails IPayIss, ILoginDetails ILog, IRecoveryServices IRec, IHttpContextAccessor accessor)
        {
            _Iss = Iss;
            _IPayIss = IPayIss;
            _ILog = ILog;
            _IRec = IRec;
            _accessor = accessor;
        }
       
        public async Task<IActionResult> RecoveryPendingList()
        {
            IEnumerable<SubFinalPayHeadDetail> AllTrans = await _Iss.GetPendingTransRecSec(_ILog.getUnitID());
            return View(AllTrans);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            @ViewBag.Message = id;
            if (id == null || id == 0)
            {
                return NotFound();
            }

            IEnumerable<SubPayRecoveryContrat> ListRec = await _IRec.GetEnteredRecovertList(id);
            return View(ListRec);
        }

        public async Task<IActionResult> ForwardRecovery(int id)
        {

            var recresult = await _IRec.GetEnteredRecovertList(id);

            if (recresult == null || recresult.Count() <= 0)
            {
                ViewBag.Error = "Please enter recovery before forward to Secretary.If no recoveries, then Nil report is required";
                // return NotFound();
            }
            else
            {
                var result = await _IRec.ForwardSubRecovery(id, _ILog.getUnitID(), 1);
                string IP = GetIPAddress();
                await _IRec.updateLog(new SubFinalPayLogDetail { TransId = id, UnitId = _ILog.getUnitID(), UserId = _ILog.getUserName().ToString(), LogDetails = _ILog.GetUserRoll().ToString() + " forwarded tansaction to Authorized Officer", Logtime = DateTime.Now, Ip = IP });
                
            }
            return RedirectToAction("RecoveryPendingList");
        }
        public async Task<IActionResult> RecoveryEntry(int? id)
        {

            if (id == null || id == 0)
            {
                return NotFound();
            }

            IEnumerable<SubFinalPayItem> ItemList = await _IRec.AllItemsUnitWise(_ILog.getUnitID());
            var FormDetails = new SubRecoveryEntryContract();
            FormDetails.ItemCode = new List<SelectListItem>();
            FormDetails.ItemCode.Add(new SelectListItem
            {
                Text = "Select Item Code",
                Value = "0"

            });
            foreach (var IList in ItemList)
            {
                FormDetails.ItemCode.Add(new SelectListItem { Text = IList.ItemDescription, Value = IList.ItemCode.ToString() });
            }
            FormDetails.TransId = id;


            return View(FormDetails);



        }


        public async Task<IActionResult> RecoveryInsert(Contract.SubRecoveryEntryContract obj)
        {

            Boolean formvalid = true;
            int TransId = (int)obj.TransId;
            string ItemCode = obj.ItemName;

            if ("001" == obj.ItemName.ToString().Trim())
            {
                if (obj.Amount != 0)
                {
                    ViewBag.Message = "Amount must be zero if item selected as nill report";
                    formvalid = false;
                }
            }
            else if (obj.Amount <= 0)
            {
                ViewBag.Message = "Please enter amount";
                formvalid = false;
            }
            else if (obj.ItemName == "0")
            {
                ViewBag.Message = "First select the Recovery Item";
                formvalid = false;
            }


            decimal TransAmount = obj.Amount;
            string remarks = obj.Remarks;
            if (formvalid == true)
            {
                ViewBag.Message = await _IRec.UpdateFinalPayItemList(TransId, _ILog.getUnitID(), ItemCode.Trim(), TransAmount, remarks);
                string IP = GetIPAddress();
                await _IRec.updateLog(new SubFinalPayLogDetail { TransId = TransId, UnitId = _ILog.getUnitID(), UserId = _ILog.getUserName().ToString(), LogDetails = _ILog.GetUserRoll().ToString() + " Inserted :" + ItemCode + "Amount :" + TransAmount, Logtime = DateTime.Now, Ip = IP });

            }

            if (formvalid == false)
            {
                IEnumerable<SubFinalPayItem> ItemList = await _IRec.AllItemsUnitWise(_ILog.getUnitID());
                var FormDetails = new SubRecoveryEntryContract();
                FormDetails.ItemCode = new List<SelectListItem>();
                FormDetails.ItemCode.Add(new SelectListItem
                {
                    Text = "Select Item Code",
                    Value = "0"

                });
                foreach (var IList in ItemList)
                {
                    FormDetails.ItemCode.Add(new SelectListItem { Text = IList.ItemDescription, Value = IList.ItemCode.ToString() });
                }
                FormDetails.TransId = TransId;
                return View("RecoveryEntry", FormDetails);
            }
            else
            {
                return RedirectToAction("Edit", new { id = TransId });
            }




        }


        public async Task<IActionResult> RecSDelete(int id, string ItemCode)
        {
            var result = await _IRec.DeleteRecovery(id, ItemCode.Trim());
            string IP = GetIPAddress();
            await _IRec.updateLog(new SubFinalPayLogDetail { TransId = id, UnitId = _ILog.getUnitID(), UserId = _ILog.getUserName().ToString(), LogDetails = _ILog.GetUserRoll().ToString() + " deleted " + ItemCode, Logtime = DateTime.Now, Ip = IP });

            return RedirectToAction("Edit", new { id });
        }
        private string GetIPAddress()
        {
            string ipAddress = _accessor.HttpContext.Connection.RemoteIpAddress.ToString();
            return ipAddress;
        }

    }
}
