using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TaxesCalculator.DAL.Entities
{
    public class Band
    {
        public int Id { get; set; }
        [Required]
        public int Order { get; set; }
        [Required]
        public string Name { get; set; }
        public int? SalaryRangeFrom { get; set;  }
        public int? SalaryRangeTo { get; set; }
        [Required]
        public double TaxRate { get; set; }
        public bool IsActive { get; set; }

        public override string ToString()
        {
            return Id.ToString(); // for tests.
        }

    }
}
