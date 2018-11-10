using System;

namespace _07.OddEvenSum
{
    class OddEvenSum
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int sumEvens = 0; // сума на числата на четни позиции
            int sumOdds = 0; // сума на числата на нечетни позиции

            for (int counter = 1; counter <= n; counter++)
            {
                int num = int.Parse(Console.ReadLine());

                if (counter % 2 == 0)
                {
                    // Когато имаме четна позиция
                    sumEvens = sumEvens + num;
                }
                else
                {
                    // Когато имаме НЕчетна позиция
                    sumOdds = sumOdds + num;
                }
            }

            int diff = Math.Abs(sumEvens - sumOdds);

            if (diff == 0)
            {
                // Двете суми са равни
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {sumEvens}");
            }
            else
            {
                // Двете суми НЕ са равни
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {diff}");
            }
        }
    }
}
