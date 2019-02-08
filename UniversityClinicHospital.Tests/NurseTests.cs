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

            Assert.Equal("Alex", nurse.Name);
        }

        [Fact]
        public void Nurse_Has_Number_Of_Patients()
        {
            Nurse nurse = new Nurse(1, "Alex", 1);

            Assert.Equal(1, nurse.NumberOfPatients);
        }

        [Fact]
        public void Nurse_Info()
        {
            Nurse nurse = new Nurse(1, "Alex", 1);

            string info = nurse.Info();
            Assert.Equal("ID: 1, Name: Alex, Salary: 50000, Paid: No, Number of Patients: 1", info);
        }

        [Fact]
        public void Nurse_Draw_Blood()
        {
            Nurse nurse = new Nurse(1, "Alex", 1);
            Patient patient = new Patient();

            nurse.DrawBlood(patient);

            Assert.Equal(15, patient.BloodLevel);
        }

        [Fact]
        public void Nurse_Cares()
        {
            Nurse nurse = new Nurse(1, "Alex", 1);
            Patient patient = new Patient();

            nurse.Care(patient);

            Assert.Equal(15, patient.HealthLevel);
        }
    }
}
