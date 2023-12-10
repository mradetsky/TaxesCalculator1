using System;
using System.Collections.Generic;
using System.Text;

namespace TaxesCalculator.DAL.Entities
{
    public class Band
    {
        public int Id { get; set; }
        public int Order { get; set; }
        public int Name { get; set; }
        public int? SalaryRangeFrom { get; set;  }
        public int? SalaryRangeTo { get; set; }
        public double TaxRate { get; set; }
        public bool IsActive { get; set; }

    }
}
