using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using PMS.Harrier.DataAccessLayer.Concrete;
using PMS.Harrier.DataAccessLayer.Models;
using PMS.Harrier.DataAccessLayer.Repository.Abstract;

namespace PMS.Harrier.DataAccessLayer.Repository
{
    public class ProjectRepository : Repository<Project>, IProjectRepository
    {
        public ProjectRepository(DbContext context) : base(context)
        {
        }


        public IEnumerable<Project> GetAllProjects()
        {
            return EfDbContext.Projects.ToList();
        }

        public void GetProjectsWithProjectManagers()
        {
            throw new System.NotImplementedException();
        }

        public EfDbContext EfDbContext => Context as EfDbContext;
    }
}