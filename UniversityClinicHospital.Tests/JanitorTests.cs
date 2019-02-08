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

            Assert.Equal("Alex", janitor.Name);
        }

        [Fact]
        public void Janitor_Is_Sweeping()
        {
            Janitor janitor = new Janitor(1, "Alex", true);
            
            Assert.True(janitor.IsSweeping);
        }

        [Fact]
        public void Janitor_Info()
        {
            Janitor janitor = new Janitor(1, "Alex", true);

            string info = janitor.Info();
            Assert.Equal("ID: 1, Name: Alex, Salary: 40000, Paid: No, Sweeping: Yes", info);
        }

        [Fact]
        public void Sweeping_Toggles()
        {
            Janitor janitor = new Janitor(1, "Alex", true);

            janitor.ToggleSweeping();

            Assert.False(janitor.IsSweeping);
        }
    }
}
