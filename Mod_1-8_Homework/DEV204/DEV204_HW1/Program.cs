using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV204_HW1
{
    public class StudentInformation
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

        public StudentInformation()
        {
            FirstName = "Juan";
            LastName = "Dela Cruz";
            BirthDate = DateTime.Now;
            AddressLine1 = "BF Homes";
            AddressLine2 = "BF Homes";
            City = "Paranaque";
            State = "NCR";
            Zip = "1720";
            Country = "Philippines";
        }

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

    class TeacherInformation
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        DateTime BirthDate { get; set; }
        string AddressLine1 { get; set; }
        string AddressLine2 { get; set; }
        string City { get; set; }
        string State { get; set; }
        string Zip { get; set; }
        string Country { get; set; }
    }

    class UProgramInformation
    {
        string ProgramName { get; set; }
        string DepartmentHead { get; set; }
        string Degrees { get; set; }
    }

    class DegreeInformation
    {
        string DegreeName { get; set; }
        int CreditsRequired { get; set; }
    }

    class CourseInformation
    {
        string CourseName { get; set; }
        int Credits { get; set; }
        int DurationInWeeks { get; set; }
        string Teacher { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            StudentInformation si = new StudentInformation();
            si.FirstName = "John";
            si.LastName = "Doe";
            si.PrintData();
        }
    }
}
