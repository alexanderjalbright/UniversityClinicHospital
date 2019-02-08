using System;
using Xunit;

namespace UniversityClinicHospital.Tests
{
    public class PatientTests
    {
        [Fact]
        public void Create_Instance()
        {
            Patient patient = new Patient();
        }

        [Fact]
        public void Blood_Level_Twenty()
        {
            Patient patient = new Patient();

            Assert.Equal(20, patient.BloodLevel);
        }

        [Fact]
        public void Health_Level_Ten()
        {
            Patient patient = new Patient();

            Assert.Equal(10, patient.HealthLevel);
        }

        [Fact]
        public void Change_Blood_Level()
        {
            Patient patient = new Patient();

            patient.ChangeBloodLevel(10);

            Assert.Equal(10, patient.BloodLevel);
        }

        [Fact]
        public void Change_Health_Level()
        {
            Patient patient = new Patient();

            patient.ChangeHealthLevel(10);

            Assert.Equal(20, patient.HealthLevel);
        }

        [Fact]
        public void Info()
        {
            Patient patient = new Patient();

            Assert.Equal("Name: CONFIDENTIAL, Blood Level: 20, Health Level: 10", patient.Info());
        }
    }
}
