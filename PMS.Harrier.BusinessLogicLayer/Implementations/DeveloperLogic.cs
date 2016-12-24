using System;
using System.Collections.Generic;
using System.Linq;
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

        public List<Developer> GetAllDevelopers()
        {
            return _unitOfWork.DeveloperRepository.GetAll().ToList();
        }

        public Developer GetDeveloper(int id)
        {
            return _unitOfWork.DeveloperRepository.Get(id);
        }

        public void AddDeveloper(Developer developer)
        {
            throw new NotImplementedException();
           //_unitOfWork.DeveloperRepository.AddDeveloper(developer);
        }
    }
}