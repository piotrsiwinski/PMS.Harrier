using System;
using System.Collections.Generic;
using PMS.Harrier.BusinessLogicLayer.Abstract;
using PMS.Harrier.DataAccessLayer.Models;
using PMS.Harrier.DataAccessLayer.UnitOfWork;
using PMS.Harrier.DataAccessLayer.ViewModels.ProjectViewModels;

namespace PMS.Harrier.BusinessLogicLayer.Implementations
{
    public class DeveloperLogic : IDeveloperLogic
    {
        private readonly IUnitOfWork _unitOfWork;

        public DeveloperLogic(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public List<DeveloperViewModel> GetAllDevelopers()
        {
            
            return _unitOfWork.DeveloperRepository.GetAllDevelopers();
        }

        public DeveloperViewModel Get(int id)
        {
            return _unitOfWork.DeveloperRepository.GetDeveloper(id);
        }
    }
}