using System;

namespace _03.EvenPowersOf2_2
{
    class EvenPowersOf2_2
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int power = 0; power <= n; power++)
            {
                // Math.Pow(x, y)
                // x -> числото, което искаме да повдигнем на някаква степен
                // y -> степента

                // Трябва да проверим дали степента е четно число
                if (power % 2 == 0)
                {
                    Console.WriteLine(Math.Pow(2, power));
                }
            }
        }
    }
}