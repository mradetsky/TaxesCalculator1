using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxesCalculator.DAL.Entities;
using TaxesCalculator.DAL.Repositories.Implementation;
using TaxesCalculator.DAL.Repositories;

namespace TaxesCalculator.Tests.Fake
{
    public class BandRepositoryFake : IBandRepository
    {
        public async Task<List<Band>> GetActiveBandsForSalaryAsync(double salary)
        {
            var res = new List<Band>()
            {
                new Band(){ Id = 1, Order = 1, Name = "Band A", SalaryRangeFrom = null, SalaryRangeTo = 5000, TaxRate = 0, IsActive = true },
                new Band(){ Id = 2, Order = 2, Name = "Band B", SalaryRangeFrom = 5000, SalaryRangeTo = 20000, TaxRate = 20, IsActive = true },
                new Band(){ Id = 3, Order = 3, Name = "Band C", SalaryRangeFrom = 20000, SalaryRangeTo = null, TaxRate = 40, IsActive = true },

            };
            return res.Where(x => x.IsActive &&
                (x.SalaryRangeFrom == null || x.SalaryRangeFrom <= salary)).ToList();
        }
        public Task AddAsync(Band entity)
        {
            throw new NotImplementedException();
        }

        public Task<Band> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task RemoveAsync(Band entity)
        {
            throw new NotImplementedException();
        }


        public IQueryable<Band> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
