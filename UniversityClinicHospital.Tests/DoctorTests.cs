using System;
using Xunit;

namespace UniversityClinicHospital.Tests
{
    public class DoctorTests
    {
        [Fact]
        public void Create_Instance()
        {
            Doctor doctor = new Doctor(1, "Alex", "Head");
        }

        [Fact]
        public void Doctor_Has_ID()
        {
            Doctor doctor = new Doctor(1, "Alex", "Head");

            Assert.Equal(1, doctor.EmployeeNumber);
        }

        [Fact]
        public void Doctor_Has_Salary()
        {
            Doctor doctor = new Doctor(1, "Alex", "Head");

            Assert.Equal(1, doctor.EmployeeNumber);
        }

        [Fact]
        public void Doctor_Gets_Paid()
        {
            Doctor doctor = new Doctor(1, "Alex", "Head");

            doctor.PaySalary();

            Assert.True(doctor.SalaryPaid);
        }

        [Fact]
        public void Doctor_Has_Name()
        {
            Doctor doctor = new Doctor(1, "Alex", "Head");

            doctor.PaySalary();

            Assert.True(doctor.SalaryPaid);
        }

        [Fact]
        public void Doctor_Has_Specialty_Area()
        {
            Doctor doctor = new Doctor(1, "Alex", "Head");

            Assert.Equal("Head", doctor.SpecialtyArea);
        }
    }
}
