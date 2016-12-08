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
                new Project {ProjectId = 1, ProjectName = "Jira", StartDate = DateTime.Today, Description = "System do zarządzania projektami"},
                new Project {ProjectId = 2, ProjectName = "PMS", StartDate = DateTime.Today, Description = "Inny system do zarządzania projektami" },
                new Project {ProjectId = 3, ProjectName = "Windows", StartDate = DateTime.Today, Description = "System operacyjny"}
            };

            projects.ForEach(n => context.Projects.Add(n));

            context.SaveChanges();
            base.Seed(context);
        }
    }
}