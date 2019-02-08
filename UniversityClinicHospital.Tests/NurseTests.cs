using System;
using Xunit;

namespace UniversityClinicHospital.Tests
{
    public class NurseTests
    {
        [Fact]
        public void Create_Instance()
        {
            Nurse nurse = new Nurse(1, "Alex", 1);
        }

        [Fact]
        public void Nurse_Has_ID()
        {
            Nurse nurse = new Nurse(1, "Alex", 1);

            Assert.Equal(1, nurse.EmployeeNumber);
        }

        [Fact]
        public void Nurse_Has_Salary()
        {
            Nurse nurse = new Nurse(1, "Alex", 1);

            Assert.Equal(1, nurse.EmployeeNumber);
        }

        [Fact]
        public void Nurse_Gets_Paid()
        {
            Nurse nurse = new Nurse(1, "Alex", 1);

            nurse.PaySalary();

            Assert.True(nurse.SalaryPaid);
        }

        [Fact]
        public void Nurse_Has_Name()
        {
            Nurse nurse = new Nurse(1, "Alex", 1);

            nurse.PaySalary();

            Assert.True(nurse.SalaryPaid);
        }

        [Fact]
        public void Nurse_Has_Number_Of_Patients()
        {
            Nurse nurse = new Nurse(1, "Alex", 1);

            Assert.Equal(1, nurse.NumberOfPatients);
        }
    }
}
