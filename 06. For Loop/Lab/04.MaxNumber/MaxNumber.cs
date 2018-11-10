using System;

namespace _04.MaxNumber
{
    class MaxNumber
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int max = int.MinValue;
            // int min = int.MinValue;

            // Console.WriteLine("Max = " + int.MaxValue);

            // Console.WriteLine("Min = " + int.MinValue);
            
            for(int counter = 1; counter <= n; counter++)
            {
                int num = int.Parse(Console.ReadLine());

                // Ако текущо въведеното число е по-голямо
                // от най-голямо запазено до момента число,
                // ние трябва да променим стойността на това
                // най-голямо число. 
                // Новата стойност на max е num.
                if(num > max)
                {
                    max = num;
                }
            }

            // Печатаме най-голямото намерено число
            Console.WriteLine(max);
        }
    }
}