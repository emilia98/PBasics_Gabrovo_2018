using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double sum = 0;

            // Въвеждаме n на брой числа
            for(int counter = 1; counter <= n; counter++)
            {
                double number = double.Parse(Console.ReadLine());

                // sum = sum + number;
                sum += number;
                
            }
            Console.WriteLine("Sum = " + sum);
        }
    }
}
