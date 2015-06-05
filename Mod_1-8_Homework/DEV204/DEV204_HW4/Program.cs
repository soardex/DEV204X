using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV204_HW4
{
    public struct StudentInformation
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Country { get; set; }

        public void PrintData()
        {
            Console.WriteLine("Student Information Registry");
            Console.WriteLine(
                "First Name: ........................ {0}\n" +
                "Last Name: ......................... {1}\n" +
                "Birth Date: ........................ {2:D}\n" +
                "Address Line 1: .................... {3}\n" +
                "Address Line 2: .................... {4}\n" +
                "City: .............................. {5}\n" +
                "State: ............................. {6}\n" +
                "Zip: ............................... {7}\n" +
                "Country: ........................... {8}\n",
                FirstName,
                LastName,
                BirthDate,
                AddressLine1,
                AddressLine2,
                City,
                State,
                Zip,
                Country);
        }
    }

    public struct TeacherInformation
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Country { get; set; }

        public void PrintData()
        {
            Console.WriteLine("Teacher Information Registry");
            Console.WriteLine(
                "First Name: ........................ {0}\n" +
                "Last Name: ......................... {1}\n" +
                "Birth Date: ........................ {2:D}\n" +
                "Address Line 1: .................... {3}\n" +
                "Address Line 2: .................... {4}\n" +
                "City: .............................. {5}\n" +
                "State: ............................. {6}\n" +
                "Zip: ............................... {7}\n" +
                "Country: ........................... {8}\n",
                FirstName,
                LastName,
                BirthDate,
                AddressLine1,
                AddressLine2,
                City,
                State,
                Zip,
                Country);
        }
    }

    public struct UProgramInformation
    {
        public string ProgramName { get; set; }
        public string DepartmentHead { get; set; }
        public string Degrees { get; set; }

        public void PrintData()
        {
            Console.WriteLine("University Program Information Registry");
            Console.WriteLine(
                "Program Name: ...................... {0}\n" +
                "Department Head: ................... {1}\n" +
                "Degrees: ........................... {2}\n",
                ProgramName,
                DepartmentHead,
                Degrees);
        }
    }

    public struct DegreeInformation
    {
        public string DegreeName { get; set; }
        public int CreditsRequired { get; set; }
        
        public void PrintData()
        {
            Console.WriteLine("Degree Information Registry");
            Console.WriteLine(
                "Degree Name: ....................... {0}\n" +
                "Credits Required: .................. {1}\n",
                DegreeName,
                CreditsRequired);
        }
    }

    public struct CourseInformation
    {
        public string CourseName { get; set; }
        public int Credits { get; set; }
        public int DurationInWeeks { get; set; }
        public string Teacher { get; set; }

        public void PrintData()
        {
            Console.WriteLine("Course Information Registry");
            Console.WriteLine(
                "Course Name: ....................... {0}\n" +
                "Credits: ........................... {1}\n" +
                "Duration In Weeks: ................. {2}\n" +
                "Teacher: ........................... {3}\n",
                CourseName,
                Credits,
                DurationInWeeks,
                Teacher);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            StudentInformation[] sis = new StudentInformation[5];
            sis[0].FirstName = "John";
            sis[0].LastName = "Doe";

            sis[1].FirstName = "Mary";
            sis[1].LastName = "Jones";

            sis[2].FirstName = "Andrew";
            sis[2].LastName = "Scott";

            sis[3].FirstName = "John";
            sis[3].LastName = "Harvard";

            sis[4].FirstName = "David";
            sis[4].LastName = "Farhnam";

            for (int i = 0; i < sis.Length; i++)
            {
                sis[i].PrintData();
                Console.WriteLine();
            }
        }
    }
}
