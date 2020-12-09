using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Management_System_Software.Models.Fees
{
    public class FeesVouchersEntity
    {
        public int GRNNumber { get; set; }
        public string MonthName { get; set; }
        public Boolean IsAnnualFees { get; set; }
    }
}
