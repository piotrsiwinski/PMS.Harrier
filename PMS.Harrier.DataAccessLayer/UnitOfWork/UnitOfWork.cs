using System.Data.Entity;
using PMS.Harrier.DataAccessLayer.Concrete;
using PMS.Harrier.DataAccessLayer.Repository;
using PMS.Harrier.DataAccessLayer.Repository.Interfaces;

namespace PMS.Harrier.DataAccessLayer.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly EfDbContext _dbContext;

        public UnitOfWork(EfDbContext context, IProjectRepository projectRepository, IAccountRepository accountRepository)
        {
            _dbContext = context;
            Projects = projectRepository;
            Accounts = accountRepository;
        }

        public IProjectRepository Projects { get; }
        public IAccountRepository Accounts { get; }

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