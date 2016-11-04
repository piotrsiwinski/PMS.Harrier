using System.Collections.Generic;
using PMS.Harrier.DataAccessLayer.Models;
using PMS.Harrier.DataAccessLayer.Repository.Abstract;

namespace PMS.Harrier.DataAccessLayer.Repository
{
    public interface IProjectRepository : IRepository<Project>
    {
        IEnumerable<Project> GetAllProjects();
        void GetProjectsWithProjectManagers();
        

    }
}