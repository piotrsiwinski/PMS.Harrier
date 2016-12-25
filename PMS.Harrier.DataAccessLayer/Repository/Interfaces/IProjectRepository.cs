using System.Collections.Generic;
using PMS.Harrier.DataAccessLayer.Models;
using PMS.Harrier.DataAccessLayer.Repository.AbstractRepository;

namespace PMS.Harrier.DataAccessLayer.Repository.Interfaces
{
    public interface IProjectRepository : IRepository<Project>
    {
        Project GetProjectByName(string name);
        List<Project> GetProjectsByDeveloperId(int id);
       
    }
}