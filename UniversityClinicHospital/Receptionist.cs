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
            string phone;
            if (OnThePhone)
            {
                phone = "Yes";
            }
            else
            {
                phone = "No";
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

            string info = "ID: " + EmployeeNumber + ", Name: " + Name + ", Salary: " + Salary + ", Paid: " + pay + ", On the Phone: " + phone;
            return info;
        }

        public void TogglePhone()
        {
            if (OnThePhone)
            {
                OnThePhone = false;
            }
            else
            {
                OnThePhone = true;
            }
        }
    }
}
