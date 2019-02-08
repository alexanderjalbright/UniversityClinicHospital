using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicHospital
{
    public abstract class Employee
    {
        public Employee(int id)
        {
            ID = id;
        }

        public int ID { get; protected set; }

        public int Salary { get; protected set; }
    }
}
