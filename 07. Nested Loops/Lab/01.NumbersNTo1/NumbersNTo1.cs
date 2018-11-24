using System;

namespace _01.NumbersNTo1
{
    class NumbersNTo1
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = n; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}