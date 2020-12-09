using School_Management_System_Software.Models.Fees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Management_System_Software.Models.Students
{
    public class Students
    {
        //private StudentFees _StudentFees;
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string FatherName { get; set; }
        public int ClassId { get; set; }
        public byte[] StudentImage { get; set; }
        public string Address { get; set; }
        public string Telephone { get; set; } 
        public string CreatedBy { get; set; }
        public string Cnic { get; set; }
        public string Occupation { get; set; }
        public string Religion { get; set; }
        public int GenderId { get; set; }
        public string MotherName { get; set; }
        public string LastSchool { get; set; }
        public string LastClass { get; set; }
        public string DOB { get; set; }
        public string PlaceOfBirth { get; set; }
        public int Fees { get; set; }
        public int AnnualFees { get; set; }
        public int ExtraFeesAmount { get; set; }
        public int ExtraFeesName { get; set; }
        public bool IsExtraFees { get; set; }
        public int AnnualFeesYear { get; set; }
        //public StudentFees FeesObj { get; set; }
        //public StudentFees FeesObj
        //{
        //    get { return _StudentFees; }
        //    set { _StudentFees = value; }

        //}

    }
}
