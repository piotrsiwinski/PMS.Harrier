using System.Collections.Generic;
using PMS.Harrier.DataAccessLayer.Concrete;
using PMS.Harrier.DataAccessLayer.Models;

namespace PMS.Harrier.DataAccessLayer.Repository
{
    public class ProjectRepository : IProjectRepository
    {
        private EfDbContext _context = new EfDbContext();
        public IEnumerable<Project> Projects => _context.Projects;

        public void AddProject(Project project)
        {
            _context.Projects.Add(project);
            _context.SaveChanges();
        }

        public Project DeleteProject(int projectId)
        {
            var dbEntry = _context.Projects.Find(projectId);
            if (dbEntry != null)
            {
                _context.Projects.Remove(dbEntry);
                _context.SaveChanges();
            }
            return dbEntry;
        }
    }
}