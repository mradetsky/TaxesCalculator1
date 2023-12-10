using System;
using System.Collections.Generic;
using System.Text;

namespace TaxesCalculator.DAL.Repositories
{
    public interface IBaseRepository<T>
    {
    
        T Get(int id);
        void Add(T entity);
        void Remove(T entity);
        IEnumerable<T> GetAll();

        // + какие-то специфичные вещи навроде
        
    }
}
