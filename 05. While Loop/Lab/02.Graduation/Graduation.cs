using System;

namespace _02.Graduation
{
    class Graduation
    {
        static void Main()
        {
            string name = Console.ReadLine();
            int grade = 1;
            double sum = 0;

            // Докато Pesho не е достигнал до 12-ти клас
            // ние ще въвеждаме някакви стойности (неговия успех)
            while (grade <= 12)
            {
                // Console.WriteLine($"Grade = {grade}");
                // Ще се променя всеки път, в който
                // влезем в тялото на while
                double mark = double.Parse(Console.ReadLine());

                if (mark >= 4)
                {
                    sum += mark;
                    grade++;
                }
                else
                {
                    // grade = grade;
                }
            }

            double average = sum / 12;
            Console.WriteLine($"{name} graduated. Average grade: {average:f2}");
        }
    }
}