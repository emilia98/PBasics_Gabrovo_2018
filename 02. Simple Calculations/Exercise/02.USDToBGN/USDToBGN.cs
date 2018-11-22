using System;

namespace _02.USDToBGN
{
    class USDToBGN
    {
        static void Main()
        {
            // Въвеждаме доларите, които трябва да превърнем
            decimal usd = decimal.Parse(Console.ReadLine());
            decimal bgn = usd * 1.79549m;
            // ЗАКРЪГЛЯМЕ, НЕ форматираме
            Console.WriteLine($"{Math.Round(bgn, 2)} BGN");
        }
    }
}