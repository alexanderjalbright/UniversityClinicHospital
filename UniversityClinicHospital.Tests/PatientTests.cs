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
    }
}
