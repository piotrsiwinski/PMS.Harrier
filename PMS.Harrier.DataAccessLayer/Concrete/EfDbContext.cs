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

        //new entities
        public virtual DbSet<Account> Account { get; set; }
        public virtual DbSet<AccountAddress> AccountAdresses { get; set; }
        public virtual DbSet<Contact> Ccontact { get; set; }
        public virtual DbSet<Developer> Developer { get; set; }
        public virtual DbSet<Project> Project { get; set; }
        public virtual DbSet<ProjectData> ProjectData { get; set; }
        public virtual DbSet<ProjectDeveloper> ProjectDeveloper { get; set; }
        public virtual DbSet<ProjectStage> ProjectStage { get; set; }
        public virtual DbSet<ProjectTechnology> ProjectTechnology { get; set; }
        public virtual DbSet<Stage> Stage { get; set; }
        public virtual DbSet<StageTeam> StageTeam { get; set; }
        public virtual DbSet<Technology> Technology { get; set; }
        public virtual DbSet<TechnologyDeveloper> TechnologyDeveloper { get; set; }
    }
}