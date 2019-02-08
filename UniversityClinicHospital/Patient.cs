using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicHospital
{
    public class Patient
    {
        public Patient()
        {
            BloodLevel = 20;
            HealthLevel = 10;
        }

        public int BloodLevel { get; private set; }

        public int HealthLevel { get; private set; }
    }
}
