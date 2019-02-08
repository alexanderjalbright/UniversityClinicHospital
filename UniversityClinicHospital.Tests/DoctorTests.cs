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
            
            Assert.Equal("Alex", doctor.Name);
        }

        [Fact]
        public void Doctor_Has_Specialty_Area()
        {
            Doctor doctor = new Doctor(1, "Alex", "Head");

            Assert.Equal("Head", doctor.SpecialtyArea);
        }

        [Fact]
        public void Doctor_Info()
        {
            Doctor doctor = new Doctor(1, "Alex", "Head");

            string info = doctor.Info();
            Assert.Equal("ID: 1, Name: Alex, Salary: 90000, Paid: No, Specialty Area: Head", info);
        }

        [Fact]
        public void Doctor_Draw_Blood()
        {
            Doctor doctor = new Doctor(1, "Alex", "Head");
            Patient patient = new Patient();

            doctor.DrawBlood(patient);

            Assert.Equal(10, patient.BloodLevel);
        }

        [Fact]
        public void Doctor_Cares()
        {
            Doctor doctor = new Doctor(1, "Alex", "Head");
            Patient patient = new Patient();

            doctor.Care(patient);

            Assert.Equal(20, patient.BloodLevel);
        }
    }
}
