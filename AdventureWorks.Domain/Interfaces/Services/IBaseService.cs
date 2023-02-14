using System;
using System.Collections.Generic;
using System.Text;

namespace AdventureWorks.Domain.Interfaces.Services
{
    public interface IBaseService<TEntity> where TEntity : class
    {
        TEntity GetById(int id);

        IEnumerable<TEntity> GetAll();

        void Add(TEntity Object);

        void Update(TEntity Object);

        void Delete(TEntity Object);
    }
}
