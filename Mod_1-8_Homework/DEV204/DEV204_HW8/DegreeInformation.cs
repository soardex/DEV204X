﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV204_HW8
{
    class DegreeInformation
    {
        public string DegreeName { get; set; }
        public int CreditsRequired { get; set; }
        public CourseInformation[] Courses { get; set; }

        public DegreeInformation(string name)
        {
            DegreeName = name;
        }

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
}
