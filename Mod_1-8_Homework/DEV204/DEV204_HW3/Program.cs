using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV204_HW3
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
            FirstName = "Default";
            LastName = "Default";
            BirthDate = DateTime.Now;
            AddressLine1 = "Default";
            AddressLine2 = "Default";
            City = "Default";
            State = "Default";
            Zip = "Default";
            Country = "Default";
        }

        public void GetStudentInformation()
        {
            try
            {
                string type = "S";
                Console.WriteLine("Student Information Registry");
                Console.Write("({0}) First Name: ", type);
                FirstName = Console.ReadLine();
                Console.Write("({0}) Student's Last Name: ", type);
                LastName = Console.ReadLine();
                Console.Write("({0}) Birth Date (YYYY-MM-DD): ", type);
                string dateTimeInput = Console.ReadLine();
                BirthDate = DateTime.Parse(dateTimeInput);
                Console.Write("({0}) Primary Address: ", type);
                AddressLine1 = Console.ReadLine();
                Console.Write("({0}) Secondary Address: ", type);
                AddressLine2 = Console.ReadLine();
                Console.Write("({0}) City: ", type);
                City = Console.ReadLine();
                Console.Write("({0}) State / Province: ", type);
                State = Console.ReadLine();
                Console.Write("({0}) Zip / Postal Code: ", type);
                Zip = Console.ReadLine();
                Console.Write("({0}) Country: ", type);
                Country = Console.ReadLine();
            }
            catch (ArgumentNullException ane)
            {
                Console.WriteLine("Fatal Exception Occured: {0}", ane.Message);
            }
            catch (FormatException fe)
            {
                Console.WriteLine("Fatal Exception Occured: {0}", fe.Message);
            }
            catch (NotImplementedException nie)
            {
                Console.WriteLine("Fatal Exception Occured: {0}", nie.Message);
            }
        }

        public void ValidateStudentBirthDate()
        {
            throw new NotImplementedException();
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

    public class TeacherInformation
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

        public TeacherInformation()
        {
            FirstName = "Default";
            LastName = "Default";
            BirthDate = DateTime.Now;
            AddressLine1 = "Default";
            AddressLine2 = "Default";
            City = "Default";
            State = "Default";
            Zip = "Default";
            Country = "Default";
        }

        public void GetTeacherInformation()
        {
            try
            {
                string type = "T";
                Console.WriteLine("Teacher Information Registry");
                Console.Write("({0}) First Name: ", type);
                FirstName = Console.ReadLine();
                Console.Write("({0}) Student's Last Name: ", type);
                LastName = Console.ReadLine();
                Console.Write("({0}) Birth Date (YYYY-MM-DD): ", type);
                string dateTimeInput = Console.ReadLine();
                BirthDate = DateTime.Parse(dateTimeInput);
                Console.Write("({0}) Primary Address: ", type);
                AddressLine1 = Console.ReadLine();
                Console.Write("({0}) Secondary Address: ", type);
                AddressLine2 = Console.ReadLine();
                Console.Write("({0}) City: ", type);
                City = Console.ReadLine();
                Console.Write("({0}) State / Province: ", type);
                State = Console.ReadLine();
                Console.Write("({0}) Zip / Postal Code: ", type);
                Zip = Console.ReadLine();
                Console.Write("({0}) Country: ", type);
                Country = Console.ReadLine();
            }
            catch (ArgumentNullException ane)
            {
                Console.WriteLine("Fatal Exception Occured: {0}", ane.Message);
            }
            catch (FormatException fe)
            {
                Console.WriteLine("Fatal Exception Occured: {0}", fe.Message);
            }
            catch (NotImplementedException nie)
            {
                Console.WriteLine("Fatal Exception Occured: {0}", nie.Message);
            }
        }

        public void ValidateTeacherBirthDate()
        {
            throw new NotImplementedException();
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

    class UProgramInformation
    {
        public string ProgramName { get; set; }
        public string DepartmentHead { get; set; }
        public string Degrees { get; set; }

        public UProgramInformation()
        {
            ProgramName = "Default";
            DepartmentHead = "Default";
            Degrees = "Default";
        }
    }

    class DegreeInformation
    {
        public string DegreeName { get; set; }
        public int CreditsRequired { get; set; }

        public DegreeInformation()
        {
            DegreeName = "Default";
            CreditsRequired = 1;
        }
    }

    class CourseInformation
    {
        public string CourseName { get; set; }
        public int Credits { get; set; }
        public int DurationInWeeks { get; set; }
        public string Teacher { get; set; }

        public CourseInformation()
        {
            CourseName = "Default";
            Credits = 1;
            DurationInWeeks = 1;
            Teacher = "";
        }
    }

    class Program
    {
        static void PrintInformationDetails(string first, string last, string birthdate)
        {
            Console.WriteLine("{0} {1} was born on: {2}\n\n", first, last, birthdate);
        }

        static void PrintStudentInformationDetails(string first, string last, string birthdate)
        {
            PrintInformationDetails(first, last, birthdate);
        }

        static void PrintTeacherInformationDetails(string first, string last, string birthdate)
        {
            PrintInformationDetails(first, last, birthdate);
        }

        static void Main(string[] args)
        {
            try
            {
                StudentInformation si = new StudentInformation();
                si.GetStudentInformation();
                PrintStudentInformationDetails(si.FirstName, si.LastName, si.BirthDate.ToString());

                TeacherInformation ti = new TeacherInformation();
                ti.GetTeacherInformation();
                PrintTeacherInformationDetails(si.FirstName, si.LastName, si.BirthDate.ToString());

                /// exception sample like on homework
                si.ValidateStudentBirthDate();
            }
            catch (NotImplementedException nie)
            {
                Console.WriteLine("Fatal Exception Occured: {0}", nie.Message);
            }
        }
    }
}
