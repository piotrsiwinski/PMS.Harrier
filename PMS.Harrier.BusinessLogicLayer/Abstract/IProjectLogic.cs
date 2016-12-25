using System.Collections.Generic;
using PMS.Harrier.DataAccessLayer.Models;
using PMS.Harrier.DataAccessLayer.ViewModels.ProjectViewModels;

namespace PMS.Harrier.BusinessLogicLayer.Abstract
{
    public interface IProjectLogic
    {
        List<Project> GetAllProjects();
        Project GetProject(int id);

        
        void AddNewProject(Project project);

        bool IsProjectNameAvailable(string name);

        void AddDeveloperToProject(ProjectDeveloper entity);
        void AddDevelopersToProject(List<ProjectDeveloper> result);
        List<Project> GetProjectsByDeveloperId(int id);
        void EditProject(Project entity);
    }
}