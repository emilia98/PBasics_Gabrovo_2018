using System;

namespace _03.SumNumbers
{
    class SumNumbers
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            double sum = 0;
            
            for (int counter = 1; counter <= n; counter++)
            {
                double number = double.Parse(Console.ReadLine());
                sum += number;
            }
            Console.WriteLine(sum);
        }
    }
}