using System;
using System.Collections.Generic;
using System.Text;

namespace TaxesCalculator.DAL.Repositories.Implementation
{
    public class BaseRepository<T> : IBaseRepository<T>
    {
        public void Add(T entity)
        {
            throw new NotImplementedException();
        }

        public T Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Remove(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
