using System;

namespace _03.Graduation_2._0
{
    class Graduation_20
    {
        static void Main()
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
