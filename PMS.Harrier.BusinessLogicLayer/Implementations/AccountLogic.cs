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
            var account = _unitOfWork.AccountRepository.GetAccount(accountId);
            var result = new OverviewViewModel
            {
                FirstName = account.FirstName,
                LastName = account.LastName,
                City = account.AccountAdress.City,
                Country = account.AccountAdress.Country,
                Street = account.AccountAdress.Street,
                PhoneNumber = account.AccountAdress.PhoneNumber
            };
            return result;
        }
    }
}