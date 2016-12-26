using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using PMS.Harrier.DataAccessLayer.Concrete;
using PMS.Harrier.DataAccessLayer.Models;
using PMS.Harrier.DataAccessLayer.Repository.AbstractRepository;
using PMS.Harrier.DataAccessLayer.Repository.Interfaces;

namespace PMS.Harrier.DataAccessLayer.Repository
{
    public class DeveloperRepository : Repository<Developer>, IDeveloperRepository
    {
        public DeveloperRepository(EfDbContext context) : base(context)
        {

        }

        public List<Developer> GetAllDevelopersByProjectId(int id)
        {
            return Context.ProjectDeveloper.Where(n => n.ProjectId == id).Select(n => n.Developer).ToList();
        }
    }
}