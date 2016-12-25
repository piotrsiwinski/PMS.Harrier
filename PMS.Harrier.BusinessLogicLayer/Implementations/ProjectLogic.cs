using System;
using System.Collections.Generic;
using System.Linq;
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

        public List<Project> GetAllProjects()
        {
            return _unitOfWork.ProjectRepository.GetAll().ToList();
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

        public void AddDeveloperToProject(ProjectDeveloper entity)
        {
            _unitOfWork.ProjectDeveloperRepository.Add(entity);
            _unitOfWork.Complete();
        }

        public void AddDevelopersToProject(List<ProjectDeveloper> entities)
        {
            _unitOfWork.ProjectDeveloperRepository.AddRange(entities);
            _unitOfWork.Complete();
        }

        public List<Project> GetProjectsByDeveloperId(int id)
        {
            return _unitOfWork.ProjectRepository.GetProjectsByDeveloperId(id);
        }
    }
}