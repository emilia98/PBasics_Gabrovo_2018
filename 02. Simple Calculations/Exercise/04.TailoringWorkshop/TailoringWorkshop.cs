using System;

namespace _04.TailoringWorkshop
{
    class TailoringWorkshop
    {
        static void Main()
        {
            int tablesCount = int.Parse(Console.ReadLine());
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());

            // Общата площ на покривките
            double tableClothsArea = tablesCount * (length + 2 * 0.30) * (width + 2 * 0.30);
            // Общата площ на каретата
            double checkedClothsArea = tablesCount * (length / 2) * (length / 2);

            // Намираме каква е общата цена на покривките в ДОЛАРИ (общата им площ * цената за един квадратен метър)
            decimal totalPriceOfTableCloths = (decimal)tableClothsArea * 7.00m;
            // Намираме каква е общата цена на каретата в ДОЛАРИ (общата им площ * цената за един квадратен метър)
            decimal totalPriceOfCheckedCloths = (decimal)checkedClothsArea * 9.00m;

            decimal totalPriceInDollars = totalPriceOfTableCloths + totalPriceOfCheckedCloths;
            decimal totalPriceInLeva = totalPriceInDollars * 1.85m;

            Console.WriteLine($"{totalPriceInDollars:f2} USD");
            Console.WriteLine($"{totalPriceInLeva:f2} BGN");
        }
    }
}