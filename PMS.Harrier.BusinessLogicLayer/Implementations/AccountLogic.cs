using PMS.Harrier.BusinessLogicLayer.Abstract;
using PMS.Harrier.DataAccessLayer.Models;
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
    }
}