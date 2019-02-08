using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicHospital
{
    public class Receptionist : Employee
    {
        public Receptionist(int id, string name, bool onPhone) : base(id, name)
        {
            Salary = 45000;
            OnThePhone = onPhone;
        }

        public bool OnThePhone { get; private set; }

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
