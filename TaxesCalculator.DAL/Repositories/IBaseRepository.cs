using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxesCalculator.DAL.Repositories
{
    public interface IBaseRepository<T>
    {
    
        Task<T> GetAsync(int id);
        Task AddAsync(T entity);
        Task RemoveAsync(T entity);
        IQueryable<T> GetAll();

    }
}
