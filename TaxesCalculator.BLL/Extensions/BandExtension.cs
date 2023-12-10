using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TaxesCalculator.DAL.Entities;

namespace TaxesCalculator.BLL.Extensions
{
    public static class BandExtension
    {
        public static double CalculateBandTaxes(this Band band, double salary)
        {
            
            if (salary < band.SalaryRangeFrom)
            {
                return 0;
            }
            if (band.SalaryRangeFrom > 0)
            {
                salary -= band.SalaryRangeFrom ?? 0;
            }
            if (salary > band.SalaryRangeTo)
            {
                salary = band.SalaryRangeTo ?? 0 - band.SalaryRangeFrom ?? 0;
            }
            return salary * band.TaxRate;
        }

        public static void ValidateBands(this IEnumerable<Band> bands)
        {
            int? prevlimit = null;
            if (bands.OrderBy(x => x.Order).FirstOrDefault()?.SalaryRangeFrom != null)
            {
                throw new Exception("SalaryRangeFrom or first band should be null!");
            }
            if (bands.OrderByDescending(x => x.Order).FirstOrDefault()?.SalaryRangeTo != null)
            {
                throw new Exception("SalaryRangeTo or last band should be null!");
            }
            foreach (var band in bands.OrderBy(x => x.Order))
            {
                if (prevlimit != band.SalaryRangeFrom)
                {
                    throw new Exception("SalaryRangeFrom should be equal of SalaryRangeTo of previous band");
                }
            }
            

        }
    }
}
