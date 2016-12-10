using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using PMS.Harrier.DataAccessLayer.Concrete;

namespace PMS.Harrier.DataAccessLayer.Repository.AbstractRepository
{
    public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly EfDbContext EfContext;

        protected Repository(EfDbContext context)
        {
            EfContext = context;
        }
        public TEntity Get(int id)
        {
            return EfContext.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return EfContext.Set<TEntity>().ToList();
        }

        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return EfContext.Set<TEntity>().Where(predicate);
        }

        public void Add(TEntity entity)
        {
            EfContext.Set<TEntity>().Add(entity);
        }

        public void AddRange(IEnumerable<TEntity> entities)
        {
            EfContext.Set<TEntity>().AddRange(entities);
        }

        public void Remove(TEntity entity)
        {
            EfContext.Set<TEntity>().Remove(entity);
        }

        public void RemoveRange(IEnumerable<TEntity> entities)
        {
            EfContext.Set<TEntity>().RemoveRange(entities);
        }
        protected EfDbContext EfDbContext => EfContext as EfDbContext;
    }
}