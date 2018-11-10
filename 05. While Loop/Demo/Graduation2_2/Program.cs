using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graduation2_2
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

                if (mark < 4)
                {
                    break;
                }
                else
                {
                    sum += mark;
                    grade++;
                }
            }

            if (grade < 12)
            {
                Console.WriteLine($"{name} has been excluded at {grade} grade");
            }
            else
            {
                double average = sum / 12;
                Console.WriteLine($"{name} graduated. Average grade: {average}");
            }
        }
    }
}
