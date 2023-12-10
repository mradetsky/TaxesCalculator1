using System;
using System.Collections.Generic;
using System.Text;
using TaxesCalculator.DAL.Entities;

namespace TaxesCalculator.DAL.Repositories.Implementation
{
    public class BandRepository : BaseRepository<Band>, IBandRepository
    {
        public override IEnumerable<Band> GetAll()
        {
            return new List<Band>()
            {
                new Band(){ Id = 1, Order = 1, Name = "Band A", SalaryRangeFrom = null, SalaryRangeTo = 5000, IsActive = true },
                new Band(){ Id = 2, Order = 2, Name = "Band B", SalaryRangeFrom = 5000, SalaryRangeTo = 20000, IsActive = true },
                new Band(){ Id = 3, Order = 3, Name = "Band C", SalaryRangeFrom = 20000, SalaryRangeTo = null, IsActive = true },

            };
        }
    }
}
