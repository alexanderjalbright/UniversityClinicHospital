﻿using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicHospital
{
    public class Janitor : Employee
    {
        public Janitor(int id) : base(id)
        {
            Salary = 40000;
        }
    }
}