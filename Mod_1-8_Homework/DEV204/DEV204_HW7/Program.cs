using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV204_HW7
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentInformation student1 = new StudentInformation("John", "Harvard");
            student1.Grades.Push(80);
            student1.Grades.Push(60);
            student1.Grades.Push(85);

            StudentInformation student2 = new StudentInformation("Tom", "Riddles");
            student2.Grades.Push(85);
            student2.Grades.Push(90);
            student2.Grades.Push(87);

            StudentInformation student3 = new StudentInformation("Harry", "Potter");
            student3.Grades.Push(81);
            student3.Grades.Push(60);
            student3.Grades.Push(75);

            /// as of .NET 4.5 the one i'm using the ArrayList is deprecated and been replaced by
            /// List<T>
            CourseInformation ci = new CourseInformation("Programming with C#");
            ci.Students.Add(student1);
            ci.Students.Add(student2);
            ci.Students.Add(student3);

            Console.WriteLine("List of enrolled students for the course of {0}", ci.CourseName);
            ci.ListStudents();
        }
    }
}
