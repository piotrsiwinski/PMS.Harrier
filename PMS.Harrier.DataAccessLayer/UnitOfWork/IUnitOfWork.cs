using System;
using PMS.Harrier.DataAccessLayer.Repository;

namespace PMS.Harrier.DataAccessLayer.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IProjectRepository Projects { get; }
        int Complete();
    }
}