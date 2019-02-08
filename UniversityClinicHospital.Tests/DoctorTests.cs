using System;
using Xunit;

namespace UniversityClinicHospital.Tests
{
    public class DoctorTests
    {
        [Fact]
        public void Test1()
        {
            Doctor employee = new Doctor(1);
        }

        [Fact]
        public void Employee_Has_ID()
        {
            Doctor employee = new Doctor(1);

            Assert.Equal(1, employee.ID);
        }

        [Fact]
        public void Employee_Has_Salary()
        {
            Doctor employee = new Doctor(1);

            Assert.Equal(1, employee.ID);
        }
    }
}
