using System;

namespace _03.GreaterNumber
{
    class GreaterNumber
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int max = int.MinValue;

            if (a > b)
            {
                max = a;
            }
            else
            {
                max = b;
            }

            Console.WriteLine($"Greater number: {max}");
        }
    }
}