using System.Collections.Generic;
using PMS.Harrier.DataAccessLayer.Repository.Abstract;

namespace PMS.Harrier.DataAccessLayer.Repository.Interfaces
{
    public interface IProjectRepository : IRepository<Models.Project>
    {
        IEnumerable<Models.Project> GetAllProjects();
        void GetProjectsWithProjectManagers();

        Models.Project GetProjectByName(string name);
    }
}