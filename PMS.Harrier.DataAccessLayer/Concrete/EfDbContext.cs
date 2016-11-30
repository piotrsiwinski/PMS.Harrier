using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using PMS.Harrier.DataAccessLayer.Initializers;
using PMS.Harrier.DataAccessLayer.Models;

namespace PMS.Harrier.DataAccessLayer.Concrete
{
    public class EfDbContext : DbContext
    {
        public EfDbContext() : base("name=DefaultConnection")
        {
            Database.SetInitializer(new CustomDbInitializer());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Project> Projects { get; set; }
    }
}