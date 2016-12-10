using PMS.Harrier.BusinessLogicLayer.Abstract;
using PMS.Harrier.DataAccessLayer.UnitOfWork;
using PMS.Harrier.DataAccessLayer.ViewModels.ManageViewModels;

namespace PMS.Harrier.BusinessLogicLayer.Implementations
{
    public class AccountLogic : IAccountLogic
    {
        private readonly IUnitOfWork _unitOfWork;

        public AccountLogic(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public OverviewViewModel GetAccountDetails(string accountId)
        {
            throw new System.NotImplementedException();
        }
    }
}