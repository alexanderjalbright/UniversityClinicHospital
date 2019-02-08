using System;
using Xunit;

namespace UniversityClinicHospital.Tests
{
    public class JanitorTests
    {
        [Fact]
        public void Test1()
        {
            Janitor employee = new Janitor(1);
        }

        [Fact]
        public void Employee_Has_ID()
        {
            Janitor employee = new Janitor(1);

            Assert.Equal(1, employee.ID);
        }

        [Fact]
        public void Employee_Has_Salary()
        {
            Janitor employee = new Janitor(1);

            Assert.Equal(1, employee.ID);
        }
    }
}
