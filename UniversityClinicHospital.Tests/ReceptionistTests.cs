using System;
using Xunit;

namespace UniversityClinicHospital.Tests
{
    public class ReceptionistTests
    {
        [Fact]
        public void Create_Instance()
        {
            Receptionist receptionist = new Receptionist(1, "Alex", true);
        }

        [Fact]
        public void Receptionist_Has_ID()
        {
            Receptionist receptionist = new Receptionist(1, "Alex", true);

            Assert.Equal(1, receptionist.EmployeeNumber);
        }

        [Fact]
        public void Receptionist_Has_Salary()
        {
            Receptionist receptionist = new Receptionist(1, "Alex", true);

            Assert.Equal(1, receptionist.EmployeeNumber);
        }

        [Fact]
        public void Receptionist_Gets_Paid()
        {
            Receptionist receptionist = new Receptionist(1, "Alex", true);

            receptionist.PaySalary();

            Assert.True(receptionist.SalaryPaid);
        }

        [Fact]
        public void Receptionist_Has_Name()
        {
            Receptionist receptionist = new Receptionist(1, "Alex", true);

            receptionist.PaySalary();

            Assert.True(receptionist.SalaryPaid);
        }

        [Fact]
        public void Receptionist_Is_On_Phone()
        {
            Receptionist receptionist = new Receptionist(1, "Alex", true);

            Assert.True(receptionist.OnThePhone);
        }
    }
}
