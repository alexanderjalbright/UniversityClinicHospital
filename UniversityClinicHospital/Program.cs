using System;
using System.Collections.Generic;

namespace UniversityClinicHospital
{
    class Program
    {
        static void Main(string[] args)
        {
            MainMenu();
        }

        private static Patient thePatient = new Patient();

        static void MainMenu()
        {
            List<Employee> employees = new List<Employee>()
            {
                new Doctor(1, "Donald Faison", "Head"),
                new Nurse(2, "Judy Reyes", 1),
                new Receptionist(3, "Jenna Fischer", false),
                new Janitor(4, "Neil Flynn", false)
            };

            Patient thePatient = new Patient();

            bool run = true;
            do
            {
                Console.Clear();
                Console.WriteLine("University Clinic Hospital\n");
                Console.WriteLine("Main Menu:");
                Console.WriteLine("Press 1 to Print List of Employees");
                Console.WriteLine("Press 2 to Pay Employees");
                Console.WriteLine("Press 3 to Direct Employees");
                Console.WriteLine("Press 4 for Patient Stats");
                Console.WriteLine("Press Q to Quit");


                ConsoleKeyInfo keyPressed = Console.ReadKey();
                Console.WriteLine("");

                switch (keyPressed.Key)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        Console.WriteLine("Employee Information:");
                        PrintEmployees(employees);
                        Console.ReadKey();
                        break;
                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        PayEmployees(employees);
                        break;
                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        DirectEmployee(employees);
                        break;
                    case ConsoleKey.D4:
                    case ConsoleKey.NumPad4:
                        PatientStats();
                        break;
                    case ConsoleKey.Q:
                        run = false;
                        Console.WriteLine("Goodbye!");
                        return;
                    default:
                        break;
                }
            } while (run);
        }
                
        static void PrintEmployees(List<Employee> employees)
        {
            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee.Info());
            }
        }

        static void PayEmployees(List<Employee> employees)
        {
            Console.WriteLine("Employee Payment:");

            int index = SelectEmployee(employees);

            if ( index != -1)
            {
                employees[index].PaySalary();
                Console.WriteLine(employees[index].Name + " got paid!");
                Console.ReadKey();
            }        
        }

        static int SelectEmployee(List<Employee> employees)
        {
            PrintEmployees(employees);

            Console.Write("Enter the ID number of the employee you would like to select: ");
            bool error;
            int index = -1;
            do
            {
                error = false;
                if (int.TryParse(Console.ReadLine(), out int idNum))
                {
                    if (idNum > employees.Count)
                    {
                        Console.WriteLine("ID doesn't exist. Canceled. Returning to Main Menu.");
                        Console.ReadKey();
                        return -1;
                    }
                    index = idNum - 1;
                }
                else
                {
                    error = true;
                }
            } while (error);

            return index;
        }

        private static void DirectEmployee(List<Employee> employees)
        {
            int index = SelectEmployee(employees);

            Doctor theDoctor = employees[index] as Doctor;
            Nurse theNurse = employees[index] as Nurse;
            Receptionist theReceptionist = employees[index] as Receptionist;
            Janitor theJanitor = employees[index] as Janitor;
            
            if(theDoctor != null || theNurse != null)
            {
                bool error;
                do
                {
                    error = false;
                    Console.WriteLine("Press 1 to Draw Blood");
                    Console.WriteLine("Press 2 to Care for Patient");
                    Console.WriteLine("Press any other number to cancel");
                    if (!int.TryParse(Console.ReadLine(), out int number))
                    {
                        Console.WriteLine("Try again.");
                        error = true;
                    }

                    switch(number)
                    {
                        case 1:
                            if(theDoctor != null)
                            {
                                theDoctor.DrawBlood(thePatient);
                                Console.WriteLine("The doctor drew the patients blood!");
                                Console.ReadKey();
                            }
                            else if (theNurse != null)
                            {
                                theNurse.DrawBlood(thePatient);
                                Console.WriteLine("The nurse drew the patients blood!");
                                Console.ReadKey();
                            }                            
                            break;
                        case 2:
                            if (theDoctor != null)
                            {
                                theDoctor.Care(thePatient);
                                Console.WriteLine("The doctor cared for the patient!");
                                Console.ReadKey();
                            }
                            else if (theNurse != null)
                            {
                                theNurse.Care(thePatient);
                                Console.WriteLine("The nurse cared for the patient!");
                                Console.ReadKey();
                            }
                            break;
                        default:
                            break;
                    }

                } while (error);
            }            
            else if (theJanitor != null)
            {
                theJanitor.ToggleSweeping();
                if (theJanitor.IsSweeping)
                {
                    Console.WriteLine("You told the janitor to sweep!");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("You told the janitor to stop sweeping!");
                    Console.ReadKey();
                }
            }
            else if (theReceptionist != null)
            {
                theReceptionist.TogglePhone();
                if (theReceptionist.OnThePhone)
                {
                    Console.WriteLine("You told the receptionist to order you food!");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("You told the receptionist to GET OFF THE PHONE!\n...because you were displacing repressed anger from your childhood.");
                    Console.ReadKey();
                }
            }
        }

        static void PatientStats()
        {
            Console.WriteLine("Patient Stats:");
            Console.WriteLine(thePatient.Info());
            Console.ReadKey();
        }
    }
}
