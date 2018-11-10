using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graduation2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int grade = 1;
            double sum = 0;
            bool izkluchenLiE = false;

            while (grade <= 12)
            {
                double mark = double.Parse(Console.ReadLine());

                if(mark < 4)
                {
                    izkluchenLiE = true;
                    break; 
                }
                else
                {
                    sum += mark;
                    grade++;
                }
            }

            if(izkluchenLiE)
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
