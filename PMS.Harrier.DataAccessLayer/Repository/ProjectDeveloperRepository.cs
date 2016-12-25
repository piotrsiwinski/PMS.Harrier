using System.Collections.Generic;
using System.Linq;
using PMS.Harrier.DataAccessLayer.Models;
using PMS.Harrier.DataAccessLayer.Repository.Interfaces;
using PMS.Harrier.DataAccessLayer.Concrete;
using PMS.Harrier.DataAccessLayer.Repository.AbstractRepository;

namespace PMS.Harrier.DataAccessLayer.Repository
{
    public class ProjectDeveloperRepository : Repository<ProjectDeveloper>, IProjectDeveloperRepository
    {
        public ProjectDeveloperRepository(EfDbContext context) : base(context)
        {
        }
        
    }
}