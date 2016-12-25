using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using PMS.Harrier.DataAccessLayer.Concrete;
using PMS.Harrier.DataAccessLayer.Models;
using PMS.Harrier.DataAccessLayer.Repository.AbstractRepository;
using PMS.Harrier.DataAccessLayer.Repository.Interfaces;

namespace PMS.Harrier.DataAccessLayer.Repository
{
    public class ProjectRepository : Repository<Project>, IProjectRepository
    {
        public ProjectRepository(EfDbContext context) : base(context)
        {

        }
        public Project GetProjectByName(string name)
        {
            var result = Context.Projects.FirstOrDefault(p => p.ProjectName == name);
            return result;
        }

        public List<Project> GetProjectsByDeveloperId(int id)
        {
            return Context.ProjectDeveloper.Where(n => n.DeveloperId == id).Select(n => n.Project).ToList();
        }
    }
}