using System;
using Xunit;

namespace UniversityClinicHospital.Tests
{
    public class NurseTests
    {
        [Fact]
        public void Test1()
        {
            Nurse employee = new Nurse(1);
        }

        [Fact]
        public void Employee_Has_ID()
        {
            Nurse employee = new Nurse(1);

            Assert.Equal(1, employee.ID);
        }

        [Fact]
        public void Employee_Has_Salary()
        {
            Nurse employee = new Nurse(1);

            Assert.Equal(1, employee.ID);
        }
    }
}
