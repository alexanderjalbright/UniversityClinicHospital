using System;

namespace UniversityClinicHospital
{
    class Program
    {
        static void Main(string[] args)
        {
            Doctor theDoctor = new Doctor(1, "Donald Faison", "Head");
            Nurse theNurse = new Nurse(2, "Judy Reyes", 1);
            Receptionist theReceptionist = new Receptionist(3, "Jenna Fischer", true);
            Janitor theJanitor = new Janitor(4, "Neil Flynn", false);

            

        }

        static void PrintEmployees(Doctor theDoctor, Nurse theNurse, Receptionist theReceptionist, Janitor theJanitor)
        {
           
        }
    }
}
