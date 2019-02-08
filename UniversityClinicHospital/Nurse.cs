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
            string pay;
            if (SalaryPaid)
            {
                pay = "Yes";
            }
            else
            {
                pay = "No";
            }

            string info = "ID: " + EmployeeNumber + ", Name: " + Name + ", Salary: " + Salary + ", Paid: " + pay + ", Number of Patients: " + NumberOfPatients;
            return info;
        }

        public void DrawBlood(Patient patient)
        {
            patient.ChangeBloodLevel(5);
        }

        public void Care(Patient patient)
        {
            patient.ChangeHealthLevel(5);
        }
    }
}
