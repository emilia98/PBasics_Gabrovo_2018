using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyShop
{
    class Program
    {
        static void Main(string[] args)
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
                + (minionPrice * minions)
                + (truckPrice * trucks);
            decimal allToysCount = puzzles + dolls + bears + minions + trucks;

            // Console.WriteLine(profit);
            // Console.WriteLine(allToysCount);

            // Console.WriteLine(profit * 25 /100 );
            if(allToysCount >= 50)
            {
                profit = profit - (profit * 0.25m);
            }

            // Console.WriteLine(profit);
            profit = profit - (profit * 0.10m);
            // Console.WriteLine(profit);

            decimal result = Math.Abs(profit - tripPrice);
            if(profit >= tripPrice)
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
