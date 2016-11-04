using System.Collections.Generic;
using PMS.Harrier.DataAccessLayer.Models;

namespace PMS.Harrier.BusinessLogicLayer.Abstract
{
    public interface IProjectLogic
    {
        IEnumerable<Project> GetAllProjects();
        void AddNewProject(Project project);

        bool IsProjectNameAvailable(string name);
    }
}