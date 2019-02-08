using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicHospital
{
    public class Receptionist : Employee
    {
        public Receptionist(int id) : base(id)
        {
            Salary = 45000;
        }
    }
}
