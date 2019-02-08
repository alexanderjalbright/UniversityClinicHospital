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
            string sweep;
            if (IsSweeping)
            {
                sweep = "Yes";
            }
            else
            {
                sweep = "No";
            }

            string pay;
            if (SalaryPaid)
            {
                pay = "Yes";
            }
            else
            {
                pay = "No";
            }

            string info = "ID: " + EmployeeNumber + ", Name: " + Name + ", Salary: " + Salary + ", Paid: " + pay + ", Sweeping: " + sweep;
            return info;
        }

        public void ToggleSweeping()
        {
            if (IsSweeping)
            {
                IsSweeping = false;
            }
            else
            {
                IsSweeping = true;
            }
        }
    }
}
