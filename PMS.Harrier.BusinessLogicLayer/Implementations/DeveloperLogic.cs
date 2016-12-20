using System;
using System.Collections.Generic;
using PMS.Harrier.BusinessLogicLayer.Abstract;
using PMS.Harrier.DataAccessLayer.Models;
using PMS.Harrier.DataAccessLayer.UnitOfWork;

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
            return _unitOfWork.DeveloperRepository.GetAllDevelopers();
        }

        public Developer Get(int id)
        {
            return _unitOfWork.DeveloperRepository.Get(id);
        }
    }
}