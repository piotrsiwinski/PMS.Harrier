using System;
using System.Collections.Generic;
using System.Data.Entity;
using PMS.Harrier.DataAccessLayer.Concrete;
using PMS.Harrier.DataAccessLayer.Models;

namespace PMS.Harrier.DataAccessLayer.Initializers
{
    public class CustomDbInitializer : DropCreateDatabaseIfModelChanges<EfDbContext>
    {
        public CustomDbInitializer()
        {
        }

        protected override void Seed(EfDbContext context)
        {
            
            List<Project> projects = new List<Project>
            {
                new Project {Id = 1, Name = "Jira", CreationDateTime = DateTime.Today},
                new Project {Id = 2, Name = "PMS", CreationDateTime = DateTime.Today},
                new Project {Id = 3, Name = "Windows", CreationDateTime = DateTime.Today}
            };

            projects.ForEach(n => context.Projects.Add(n));

            context.SaveChanges();
            base.Seed(context);
        }
    }
}