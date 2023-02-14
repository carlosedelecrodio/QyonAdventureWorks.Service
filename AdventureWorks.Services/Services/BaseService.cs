using AdventureWorks.Domain.Interfaces.Services;
using AdventureWorks.Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdventureWorks.Services.Services
{
    public class BaseService<TEntity> : IBaseService<TEntity> where TEntity : class
    {
        private readonly IBaseRepository<TEntity> repository;

        public BaseService(IBaseRepository<TEntity> repository)
        {
            this.repository = repository;
        }

        public void Add(TEntity Object)
        {
            repository.Add(Object);
        }

        public void Delete(TEntity Object)
        {
            repository.Delete(Object);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return repository.GetAll();
        }

        public TEntity GetById(int id)
        {
            return repository.GetById(id);
        }

        public void Update(TEntity Object)
        {
            repository.Update(Object);
        }
    }

}

