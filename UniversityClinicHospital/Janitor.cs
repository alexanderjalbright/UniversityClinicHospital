using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicHospital
{
    public class Janitor : Employee
    {
        public Janitor(int id, string name, bool isSweeping) : base(id, name)
        {
            Salary = 40000;
            IsSweeping = isSweeping;
        }

        public bool IsSweeping { get; private set; }

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
