using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graduation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int grade = 1;
            double sum = 0;

            while (grade <= 12)
            {
                double mark = double.Parse(Console.ReadLine());
                if (mark >= 4)
                {
                    sum += mark;
                    grade++;
                }
            }


            //Console.WriteLine($"Grade={grade}");
            double average = sum / 12;
            Console.WriteLine($"{name} graduated. Average grade: {average:F2}");

        }
    }
}