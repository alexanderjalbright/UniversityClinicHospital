using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicHospital
{
    public class Nurse : Employee
    {
        public Nurse(int id) : base(id)
        {
            Salary = 50000;
        }
    }
}
