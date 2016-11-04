using System;
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

        public Project GetProject(int id)
        {
            return _unitOfWork.Projects.Get(id);
        }

        public void AddNewProject(Project project)
        {
            if(project == null)
                throw new ArgumentNullException(nameof(project));
            _unitOfWork.Projects.Add(project);
            _unitOfWork.Complete();
        }

        public bool IsProjectNameAvailable(string name)
        {
            var result = _unitOfWork.Projects.GetProjectByName(name);
            return result == null;
        }
    }
}