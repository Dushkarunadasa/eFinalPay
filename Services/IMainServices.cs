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
        Task<IEnumerable<SubFinalPayHeadDetail>> LoadExistingTransDetail(int TransId);
        Task<IEnumerable<SubFinalPayHeadDetail>> GetAllTrans(int UnitId,Boolean Authorized);
        Task<IEnumerable<SubFinalPayHeadDetail>> GetAllClients();

        Task<string> CreateInitialTransaction(Contract.SubInitiateContract obj, int TransId, int UnitId);
        Task<string> UpdateProfile(Contract.ProfileUpdateBasicContract obj, int TransId);

        Task<string> ApproveProfile( int TransId);
        Task<IEnumerable<SubFinalPayHeadDetail>> GetPendingTransUnit(int UnitId);

        Task<IEnumerable<SubFinalPayHeadDetail>> GetActionPendingTrans(int UnitId);
        Task<IEnumerable<SubFinalPayHeadDetail>> GetActionTakenTrans(int UnitId);

        Task<IEnumerable<SubFinalPayHeadDetail>> GetPendingTransRecSec(int UnitId);
        Task<IEnumerable<SubFinalPayHeadDetail>> GetPendingTransRecAuth(int UnitId);





    }
}
