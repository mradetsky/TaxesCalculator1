using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TaxesCalculator.DAL.Entities;

namespace TaxesCalculator.DAL.Repositories
{
    public interface IBandRepository : IBaseRepository<Band>
    {
        Task<List<Band>> GetActiveBandsForSalaryAsync(double salary);
    }
}
