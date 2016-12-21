using System;
using System.Collections.Generic;
using PMS.Harrier.BusinessLogicLayer.Abstract;
using PMS.Harrier.DataAccessLayer.Models;
using PMS.Harrier.DataAccessLayer.UnitOfWork;
using PMS.Harrier.DataAccessLayer.ViewModels.ProjectViewModels;

namespace PMS.Harrier.BusinessLogicLayer.Implementations
{
    public class ProjectLogic : IProjectLogic
    {
        private readonly IUnitOfWork _unitOfWork;

        public ProjectLogic(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<Project> GetAllProjects()
        {
            return _unitOfWork.ProjectRepository.GetAllProjects();
        }

        public Project GetProject(int id)
        {
            return _unitOfWork.ProjectRepository.Get(id);
        }

        public void AddNewProject(Project project)
        {
            if(project == null)
                throw new ArgumentNullException(nameof(project));
            _unitOfWork.ProjectRepository.Add(project);
            _unitOfWork.Complete();
        }

        public bool IsProjectNameAvailable(string name)
        {
            var result = _unitOfWork.ProjectRepository.GetProjectByName(name);
            return result == null;
        }

        public void AddDevelopersToProject(List<ProjectDeveloperViewModel> developers)
        {
            _unitOfWork.DeveloperRepository.AddDevelopersToProject(developers);
        }
    }
}