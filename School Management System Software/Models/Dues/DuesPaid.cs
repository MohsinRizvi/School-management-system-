﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace School_Management_System_Software.Models.Dues
{
    public class DuesPaid
    {
        public int GRNumber { get; set; }
        public string MonthName { get; set; }
        public string Year { get; set; }
        public bool IsPaid { get; set; }
    }
}
