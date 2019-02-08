using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicHospital
{
    public class Doctor : Employee
    {
        public Doctor(int id): base(id)
        {
            Salary = 90000;
        }
    }
}
