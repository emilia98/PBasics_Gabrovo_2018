using System;

namespace _01.GreatestCommonDiviser_2
{
    class GreatestCommonDiviser_2
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int min = Math.Min(a, b);
            int gcd = 1;

            while (min > 1)
            {
                if (a % min == 0 && b % min == 0)
                {
                    gcd = min;
                    break;
                }
                min--;
            }

            Console.WriteLine(gcd);
        }
    }
}