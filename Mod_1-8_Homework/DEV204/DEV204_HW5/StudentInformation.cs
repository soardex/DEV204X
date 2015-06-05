using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV204_HW5
{
    class StudentInformation
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
}
