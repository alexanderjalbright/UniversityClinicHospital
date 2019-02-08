using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicHospital
{
    public abstract class Employee
    {
        public Employee(int id, string name)
        {
            EmployeeNumber = id;
            Name = name;
            SalaryPaid = false;
        }

        public string Name { get; private set; }

        public int EmployeeNumber { get; protected set; }

        public int Salary { get; protected set; }

        public bool SalaryPaid { get; protected set; }

        public abstract void PaySalary();

        public abstract string Info();
    }
}
