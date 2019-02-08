using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicHospital
{
    public class Nurse : Employee
    {
        public Nurse(int id, string name, int numPats) : base(id, name)
        {
            Salary = 50000;
            NumberOfPatients = numPats;
        }

        public int NumberOfPatients { get; private set; }

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
