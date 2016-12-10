using PMS.Harrier.DataAccessLayer.ViewModels.ManageViewModels;

namespace PMS.Harrier.BusinessLogicLayer.Abstract
{
    public interface IAccountLogic
    {
        OverviewViewModel GetAccountDetails(string accountId);
    }
}