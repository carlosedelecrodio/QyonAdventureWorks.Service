using AdventureWorks.Data.Config;
using AdventureWorks.Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdventureWorks.Data.Repository
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        private readonly ContextBase contextBase;

        public BaseRepository(ContextBase contextBase)
        {
            this.contextBase = contextBase;
        }

        public void Add(TEntity Object)
        {
            try
            {
                contextBase.Set<TEntity>().Add(Object);
                contextBase.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Delete(TEntity Object)
        {
            try
            {
                contextBase.Set<TEntity>().Remove(Object);
                contextBase.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<TEntity> GetAll()
        {
            return contextBase.Set<TEntity>().ToList();
        }

        public TEntity GetById(int id)
        {
            return contextBase.Set<TEntity>().Find(id);
        }

        public void Update(TEntity Object)
        {
            try
            {
                contextBase.Entry(Object).State = EntityState.Modified;
                contextBase.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
