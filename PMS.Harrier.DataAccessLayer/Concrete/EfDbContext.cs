using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Microsoft.AspNet.Identity.EntityFramework;
using PMS.Harrier.DataAccessLayer.Initializers;
using PMS.Harrier.DataAccessLayer.Models;

namespace PMS.Harrier.DataAccessLayer.Concrete
{
    public class EfDbContext : IdentityDbContext<Account>
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
        public static EfDbContext Create()
        {
            return new EfDbContext();
        }

        //public DbSet<Project> ProjectsOld { get; set; }
        //public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<AccountAddress> AccountAdresses { get; set; }
        public virtual DbSet<Contact> Contacts { get; set; }
        public virtual DbSet<Developer> Developers { get; set; }
        public virtual DbSet<Project> Projects { get; set; }
        public virtual DbSet<ProjectData> ProjectData { get; set; }
        public virtual DbSet<ProjectDeveloper> ProjectDeveloper { get; set; }
        public virtual DbSet<ProjectStage> ProjectStages { get; set; }
        public virtual DbSet<ProjectTechnology> ProjectTechnologies { get; set; }
        public virtual DbSet<Stage> Stages { get; set; }
        public virtual DbSet<StageTeam> StageTeams { get; set; }
        public virtual DbSet<Technology> Technologies { get; set; }
        public virtual DbSet<TechnologyDeveloper> TechnologyDeveloper { get; set; }
    }
}