using FinaPay.Contract;
using FinaPay.Models;

namespace FinaPay.Services
{
    public interface IRecoveryServices
    {
        Task<IEnumerable<SubPayRecoveryContrat>> GetEnteredRecovertList(int? id);
        Task<IEnumerable<SubPayRecoveryContrat>> GetEnteredPayRecovertList(int? id);


        Task<IEnumerable<SubFinalPayItem>> AllItemsUnitWise(int UnitID);



        Task<IEnumerable<SubFinalPayItem>> AllPayItems();
        Task<IEnumerable<SubFinalPayItem>> AllPayItemFromLastPay(int TransId, int UnitID);

        Task<string> UpdateFinalPayItemList(int TransId, int UnitID, string ItemCode, decimal amount, string Remarks);

        Task<IEnumerable<SubPayRecoveryContrat>> DeleteRecovery(int TransId, string ItemCode);
        Task<IEnumerable<SubPayRecoveryContrat>> DeletePayRecovery(int TransId, string ItemCode);
        Task<string> DeleteProfile(int TransId);

        Task<string> ForwardSubRecovery(int TransId, int UnitId, int Ulevel);


        Task updateLog(SubFinalPayLogDetail lg);

        Task<IEnumerable<RecoveryCheckContract>> GetReceivedRec(int UnitId, string RollId);
        Task<IEnumerable<RecoveryCheckContract>> GetReceivedActionPending(int UnitId, string RollId);
        Task<IEnumerable<RecoveryCheckContract>> GetReceivedActionTaken(int UnitId, string RollId);

        Task<IEnumerable<RecoveryCheckContract>> GetReceivedRecSec(int UnitId, string RollId);

        Task<IEnumerable<RecoveryCheckContract>> GetReceivedRecAuth(int UnitId, string RollId, int uLevel);
        Task<IEnumerable<RecoveryCheckContract>> GetReceivedRecDDN(int UnitId, string RollId, int uLevel);
        Task<IEnumerable<RecoveryCheckContract>> GetForwardedRecDDN(int UnitId, string RollId, int uLevel);
        Task<IEnumerable<SubFinalPayHeadDetail>> GetReceived327DDN(Boolean Action);
        Task<IEnumerable<RecoveryCheckDetailContract>> GetReceiveRecDetails(int TransId);


        Task<List<int>> GetForwardedRecovertList(int? TransId);

        Task<IEnumerable<SubRoleAllowance>> GetUsers(int UnitId);

        Task<IEnumerable<SubRoleAllowance>> GetUsersDetails(int UnitId, string OfficialNo, string Role);


        Task UpdateRejectTrans(int TransId, int UnitId, string Reason);
        Task updateUserDetails(int UnitId, string OfficialNo, string Role, string SysCode, string CatCode);

        Task<string> GetUnitName(int UnitId);
    }
}
