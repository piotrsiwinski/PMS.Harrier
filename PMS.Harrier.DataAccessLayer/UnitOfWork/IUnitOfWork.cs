using System;
using PMS.Harrier.DataAccessLayer.Repository;
using PMS.Harrier.DataAccessLayer.Repository.Interfaces;

namespace PMS.Harrier.DataAccessLayer.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IProjectRepository ProjectRepository { get; }
        IAccountRepository AccountRepository { get; }
        int Complete();
    }
}