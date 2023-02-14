using System;
using System.Collections.Generic;
using System.Text;

namespace AdventureWorks.Domain.Interfaces.Repositories
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        TEntity GetById(int id);

        IEnumerable<TEntity> GetAll();

        void Add(TEntity Object);

        void Update(TEntity Object);

        void Delete(TEntity Object);

    }
}
