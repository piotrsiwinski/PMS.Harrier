using System.Collections.Generic;
using PMS.Harrier.BusinessLogicLayer.Abstract;
using PMS.Harrier.DataAccessLayer.Models;
using PMS.Harrier.DataAccessLayer.UnitOfWork;

namespace PMS.Harrier.BusinessLogicLayer.Implementations
{
    public class ProjectLogic : IProjectLogic
    {
        private IUnitOfWork _unitOfWork;

        public ProjectLogic(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<Project> GetAllProjects()
        {
            return _unitOfWork.Projects.GetAllProjects();
        }
    }
}