using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using TaxesCalculator.DAL.Entities;

namespace TaxesCalculator.DAL.Repositories.Implementation
{
    public class BandRepository : BaseRepository<Band>, IBandRepository
    {
        public BandRepository(TaxesDbContext context) : base(context)
        {

            
        }

        public async Task<List<Band>> GetActiveBandsForSalaryAsync(double salary)
        {
            return await GetAll().Where(x => x.IsActive &&
                (x.SalaryRangeFrom == null || x.SalaryRangeFrom <= salary)).ToListAsync();
        }

    }
}
