using System;

namespace _07.AlcoholMarket
{
    class AlcoholMarket
    {
        static void Main()
        {
            decimal whiskeyPrice = decimal.Parse(Console.ReadLine());
            double beerQuantity = double.Parse(Console.ReadLine());
            double wineQuantity = double.Parse(Console.ReadLine());
            double rakiyaQuantity = double.Parse(Console.ReadLine());
            double whiskeyQuantity = double.Parse(Console.ReadLine());

           
            decimal rakiyaPrice = whiskeyPrice / 2;
            // winePrice = rakiyaPrice - rakiyaPrice * 0.4m
            decimal winePrice = rakiyaPrice * 0.6m;
            // beerPrice = rakiyaPrice - rakiyaPrice * 0.8m
            decimal beerPrice = rakiyaPrice * 0.2m;
            
            decimal totalMoneyForWine = winePrice * (decimal)wineQuantity;
            decimal totalMoneyForBeer = beerPrice * (decimal)beerQuantity;
            decimal totalMoneyForRakiya = rakiyaPrice * (decimal)rakiyaQuantity;
            decimal totalMoneyForWhiskey = whiskeyPrice * (decimal)whiskeyQuantity;

            decimal total = totalMoneyForBeer + totalMoneyForRakiya + totalMoneyForWhiskey + totalMoneyForWine;

            // Парите, ФОРМАТИРАНИ до втория знак след десетичната запетайка
            Console.WriteLine($"{total:f2}");
        }
    }
}