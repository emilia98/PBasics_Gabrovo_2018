using System;

namespace _03.EvenPowersOf2
{
    class EvenPowersOf2
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            
            // 0, 2, 4, ...
            for (int power = 0; power <= n; power += 2)
            {
                Console.WriteLine(Math.Pow(2, power));
            }
        }
    }
}