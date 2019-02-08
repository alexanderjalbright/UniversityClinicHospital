using System;
using Xunit;

namespace UniversityClinicHospital.Tests
{
    public class ReceptionistTests
    {
        [Fact]
        public void Test1()
        {
            Receptionist employee = new Receptionist(1);
        }

        [Fact]
        public void Employee_Has_ID()
        {
            Receptionist employee = new Receptionist(1);

            Assert.Equal(1, employee.ID);
        }

        [Fact]
        public void Employee_Has_Salary()
        {
            Receptionist employee = new Receptionist(1);

            Assert.Equal(1, employee.ID);
        }
    }
}
