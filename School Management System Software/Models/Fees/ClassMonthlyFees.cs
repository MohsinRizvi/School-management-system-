using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Management_System_Software.Models.Fees
{
    public class ClassMonthlyFees
    {
        //public int Fees { get; set; }
        //public int AnnualFees { get; set; }
        //public int StudentId { get; set; }
        public int ClassId { get; set; }
        public string MonthName { get; set; }
        public bool IsPaid { get; set; }
    }
}
