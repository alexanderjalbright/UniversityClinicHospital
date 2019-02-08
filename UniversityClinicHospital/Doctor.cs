using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicHospital
{
    public class Doctor : Employee
    {
        public Doctor(int id, string name, string specialty) : base(id, name)
        {
            Salary = 90000;
            SpecialtyArea = specialty;
        }

        public string SpecialtyArea { get; private set; }

        public override void PaySalary()
        {
            SalaryPaid = true;
        }

        public override string Info()
        {
            string info = "";
            return info;
        }


    }
}
