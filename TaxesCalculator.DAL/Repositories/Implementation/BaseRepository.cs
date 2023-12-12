using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TaxesCalculator.DAL.Repositories.Implementation
{
    public class BaseRepository<T> : IBaseRepository<T>
        where T : class
    {
        private TaxesDbContext _context;
        public BaseRepository(TaxesDbContext context)
        {
            _context = context;
        }
        public virtual async Task AddAsync(T entity)
        {
            await _context.AddAsync(entity);
        }

        public virtual async Task<T> GetAsync(int id)
        {
            return await _context.FindAsync<T>(id);
        }

        public virtual IQueryable<T> GetAll()
        {
            return _context.Set<T>().AsNoTracking();
        }

        public virtual async Task RemoveAsync(T entity)
        {
            _context.Remove(entity);
        }
    }
}
