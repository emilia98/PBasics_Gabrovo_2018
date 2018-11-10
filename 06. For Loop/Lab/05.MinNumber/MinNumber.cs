using System;

namespace _05.MinNumber
{
    class MinNumber
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int min = int.MaxValue;

            for(int counter = 1; counter <= n;counter++)
            {
                int num = int.Parse(Console.ReadLine());

                // Ако текущо въведеното число е по-малко
                // от най-малкото запазено до момента число,
                // ние трябва да променим стойността на това
                // най-малко число. 
                // Новата стойност на min е num.
                if (num < min)
                {
                    min = num;
                }
            }

            Console.WriteLine(min);
        }
    }
}