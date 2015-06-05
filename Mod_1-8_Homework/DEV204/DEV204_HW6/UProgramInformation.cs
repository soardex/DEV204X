using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV204_HW6
{
    class UProgramInformation
    {
        public string ProgramName { get; set; }
        public string DepartmentHead { get; set; }
        public DegreeInformation[] Degrees { get; set; }

        public void PrintData()
        {
            Console.WriteLine("University Program Information Registry");
            Console.WriteLine(
                "Program Name: ...................... {0}\n" +
                "Department Head: ................... {1}\n",
                ProgramName,
                DepartmentHead);
        }
    }
}
