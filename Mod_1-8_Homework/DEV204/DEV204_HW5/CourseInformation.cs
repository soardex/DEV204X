using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV204_HW5
{
    class CourseInformation
    {
        public string CourseName { get; set; }
        public int Credits { get; set; }
        public int DurationInWeeks { get; set; }

        public StudentInformation[] Students { get; set; }
        public TeacherInformation Teacher { get; set; }

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
