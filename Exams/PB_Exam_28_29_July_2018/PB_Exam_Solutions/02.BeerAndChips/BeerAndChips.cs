using System;

namespace _02.BeerAndChips
{
    class BeerAndChips
    {
        static void Main()
        {
            // името на футболният фен 
            string fanName = Console.ReadLine();
            // бюджета
            double budget = double.Parse(Console.ReadLine());
            // брой бутилки бира
            int bottlesCount = int.Parse(Console.ReadLine());
            // брой пакети чипс 
            int packagesCount = int.Parse(Console.ReadLine());
            
            // Цената на една бира е 1.20 лв
            double allBeersPrice = 1.20 * bottlesCount;
            // цената на един пакет чипс е равна на 45% от общата стойност на закупените бири закръглена до по-голямо число.
            // Floor => pod
            // Ceiling => tavan
            
            double oneChipsPackagePrice = 0.45 * allBeersPrice;

            // Цена на всички пакети чипс
            double allChipsPrice = Math.Ceiling(packagesCount * oneChipsPackagePrice);
            double moneySpent = allBeersPrice + allChipsPrice;

            /*
             * Резултатът да се форматира до втория знак след десетичната запетая.
            */

            // Ако бюджетът е достатъчен
            if (moneySpent <= budget)
            {
                // Парите, които са останали, се изчисляват по следния начин: от бюджета вадим похарчените пари 
                double moneyLeft = budget - moneySpent;
                Console.WriteLine($"{fanName} bought a snack and has {moneyLeft:f2} leva left.");
            }
            // Ако бюджетът НЕ е достатъчен
            else
            {
                double moreMoneyNeeded = moneySpent - budget;
                Console.WriteLine($"{fanName} needs {moreMoneyNeeded:f2} more leva!");
            }
        }
    }
}