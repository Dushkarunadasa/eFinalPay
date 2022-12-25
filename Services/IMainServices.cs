using FinaPay.Contract;
using FinaPay.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FinaPay.Services
{
    public interface IMainServices
    {

        public int GetTransID();

        Task<IEnumerable<SubFinalPayHeadDetail>> GetExistingTransDetails(String SysCode, String CatCode, String OfficialNo);

        Task<IEnumerable<SubFinalPayHeadDetail>> GetAllTrans();
        Task<IEnumerable<SubFinalPayHeadDetail>> GetAllClients();

        Task<string> CreateInitialTransaction(Contract.SubInitiateContract obj, int TransId);

        Task<IEnumerable<SubFinalPayHeadDetail>> GetPendingTransUnit(int UnitId);

        Task<IEnumerable<SubFinalPayHeadDetail>> GetActionPendingTrans(int UnitId);
        Task<IEnumerable<SubFinalPayHeadDetail>> GetActionTakenTrans(int UnitId);

        Task<IEnumerable<SubFinalPayHeadDetail>> GetPendingTransRecSec(int UnitId);
        Task<IEnumerable<SubFinalPayHeadDetail>> GetPendingTransRecAuth(int UnitId);





    }
}
