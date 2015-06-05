using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV204_HW7
{
    class CourseInformation
    {
        public string CourseName { get; set; }
        public int Credits { get; set; }
        public int DurationInWeeks { get; set; }

        /// the ArrayList is already deprecated in C# .NET >= 2.0 in favor of List<T>
        public List<StudentInformation> Students { get; set; }
        public TeacherInformation Teacher { get; set; }

        public CourseInformation(string name)
        {
            CourseName = name;

            Students = new List<StudentInformation>();
        }

        public void ListStudents()
        {
            Students.ForEach(delegate(StudentInformation student)
            {
                Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
            });
        }

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
}
