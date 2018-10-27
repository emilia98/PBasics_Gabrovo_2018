using System;

namespace _10.ToyShop
{
    class Program
    {
        static void Main()
        {
            const decimal puzzlePrice = 2.60m;
            const decimal dollPrice = 3m;
            const decimal teddyBearPrice = 4.10m;
            const decimal minionPrice = 8.20m;
            const decimal truckPrice = 2.0m;

            decimal tripPrice = decimal.Parse(Console.ReadLine());
            decimal puzzles = decimal.Parse(Console.ReadLine());
            decimal dolls = decimal.Parse(Console.ReadLine());
            decimal bears = decimal.Parse(Console.ReadLine());
            decimal minions = decimal.Parse(Console.ReadLine());
            decimal trucks = decimal.Parse(Console.ReadLine());

            decimal profit =
                (puzzlePrice * puzzles)
                + (dollPrice * dolls)
                + (teddyBearPrice * bears) +
                +(minionPrice * minions)
                + (truckPrice * trucks);
            decimal allToysCount = puzzles + dolls + bears + minions + trucks;
            
            if (allToysCount >= 50)
            {
                profit = profit - (profit * 0.25m);
            }
            
            profit = profit - (profit * 0.10m);

            decimal result = Math.Abs(profit - tripPrice);

            if (profit >= tripPrice)
            {
                Console.WriteLine($"Yes! {result:f2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {result:f2} lv needed.");
            }
        }
    }
}
