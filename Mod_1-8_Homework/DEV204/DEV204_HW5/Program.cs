using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV204_HW5
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentInformation[] sis = new StudentInformation[3];
            sis[0] = new StudentInformation();
            sis[0].FirstName = "John";
            sis[0].LastName = "Harvard";

            sis[1] = new StudentInformation();
            sis[1].FirstName = "Tom";
            sis[1].LastName = "Riddles";

            sis[2] = new StudentInformation();
            sis[2].FirstName = "Harry";
            sis[2].LastName = "Potter";

            CourseInformation ci = new CourseInformation();
            ci.CourseName = "Programming with C#";
            ci.Students = sis;

            TeacherInformation ti = new TeacherInformation();
            ci.Teacher = ti;

            DegreeInformation di = new DegreeInformation();
            di.DegreeName = "Bachelor of Science";
            di.Courses = new CourseInformation[1];
            di.Courses[0] = ci;

            UProgramInformation upi = new UProgramInformation();
            upi.ProgramName = "Information Technology";
            upi.Degrees = new DegreeInformation[1];
            upi.Degrees[0] = di;

            Console.WriteLine("The {0} program contains the {1} degree\n", upi.ProgramName, upi.Degrees[0].DegreeName);
            DegreeInformation tempDeg = upi.Degrees[0];
            Console.WriteLine("The {0} degree contains the course {1}\n", tempDeg.DegreeName, tempDeg.Courses[0].CourseName);
            CourseInformation tempCourse = tempDeg.Courses[0];
            Console.WriteLine("The {0} course contains {1} student(s)", tempCourse.CourseName, tempCourse.Students.Length);
        }
    }
}
