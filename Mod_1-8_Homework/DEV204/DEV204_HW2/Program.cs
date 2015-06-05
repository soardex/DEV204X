using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV204_HW2
{
    class Program
    {
        static void PrintColumn(int index, string odd, string even)
        {
            if (index % 2 == 0)
            {
                Console.Write(odd);
            }
            else
            {
                if (index != 7)
                {
                    Console.Write(even);
                }
                else
                {
                    Console.WriteLine(even);
                }
            }
        }

        static void Main(string[] args)
        {
            int rowSize = 8;
            int colSize = 8;

            for (int i = 0; i < rowSize; i++)
            {
                for (int j = 0; j < colSize; j++)
                {
                    if (i % 2 == 0)
                    {
                        PrintColumn(j, "X", "O");
                    }
                    else
                    {
                        PrintColumn(j, "O", "X");
                    }
                }
            }
        }
    }
}
