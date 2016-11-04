using PMS.Harrier.DataAccessLayer.Concrete;
using PMS.Harrier.DataAccessLayer.Repository;

namespace PMS.Harrier.DataAccessLayer.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly EfDbContext _dbContext;

        public UnitOfWork(EfDbContext context)
        {
            _dbContext = context;
            Projects = new ProjectRepository(_dbContext);
        }

        public IProjectRepository Projects { get; }
        public int Complete()
        {
            return _dbContext.SaveChanges();
        }
        public void Dispose()
        {
            _dbContext.Dispose();
        }
    }
}