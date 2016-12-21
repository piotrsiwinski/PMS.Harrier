using System.Collections.Generic;
using PMS.Harrier.DataAccessLayer.Models;
using PMS.Harrier.DataAccessLayer.ViewModels.ProjectViewModels;

namespace PMS.Harrier.BusinessLogicLayer.Abstract
{
    public interface IProjectLogic
    {
        IEnumerable<Project> GetAllProjects();
        Project GetProject(int id);

        
        void AddNewProject(Project project);

        bool IsProjectNameAvailable(string name);
        void AddDevelopersToProject(List<ProjectDeveloperViewModel> developers);
    }
}