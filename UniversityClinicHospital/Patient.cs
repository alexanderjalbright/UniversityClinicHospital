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

        public void ChangeBloodLevel(int delta)
        {
            if(BloodLevel > 0)
            {
                BloodLevel -= delta;
            }
        }

        public void ChangeHealthLevel(int delta)
        {            
            HealthLevel += delta;
        }

        public string Info()
        {
            string info = "Name: CONFIDENTIAL, Blood Level: " + BloodLevel + ", Health Level: " + HealthLevel;
            return info;
        }
    }
}
