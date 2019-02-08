using System;
using Xunit;

namespace UniversityClinicHospital.Tests
{
    public class JanitorTests
    {
        [Fact]
        public void Create_Instance()
        {
            Janitor janitor = new Janitor(1, "Alex", true);
        }

        [Fact]
        public void Janitor_Has_ID()
        {
            Janitor janitor = new Janitor(1, "Alex", true);

            Assert.Equal(1, janitor.EmployeeNumber);
        }

        [Fact]
        public void Janitor_Has_Salary()
        {
            Janitor janitor = new Janitor(1, "Alex", true);

            Assert.Equal(1, janitor.EmployeeNumber);
        }

        [Fact]
        public void Janitor_Gets_Paid()
        {
            Janitor janitor = new Janitor(1, "Alex", true);

            janitor.PaySalary();

            Assert.True(janitor.SalaryPaid);
        }

        [Fact]
        public void Janitor_Has_Name()
        {
            Janitor janitor = new Janitor(1, "Alex", true);

            janitor.PaySalary();

            Assert.True(janitor.SalaryPaid);
        }

        [Fact]
        public void Janitor_Is_Sweeping()
        {
            Janitor janitor = new Janitor(1, "Alex", true);
            
            Assert.True(janitor.IsSweeping);
        }
    }
}
