using System;

namespace _01.ExcellentResult
{
    class ExcellentResult
    {
        static void Main()
        {
            double grade = double.Parse(Console.ReadLine());

            if (grade >= 5.5)
            {
                Console.WriteLine("Excellent!");
            }
        }
    }
}
