using System;
using System.Collections.Generic;
using System.Text;

namespace TaxesCalculator.DAL.Repositories.Implementation
{
    public class BaseRepository<T> : IBaseRepository<T>
    {
        public virtual void Add(T entity)
        {
            throw new NotImplementedException();
        }

        public virtual T Get(int id)
        {
            throw new NotImplementedException();
        }

        public virtual IEnumerable<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public virtual void Remove(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
