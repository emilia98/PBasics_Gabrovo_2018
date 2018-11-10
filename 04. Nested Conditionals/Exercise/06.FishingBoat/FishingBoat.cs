using System;

namespace _06.FishingBoat
{
    class FishingBoat
    {
        static void Main()
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishers = int.Parse(Console.ReadLine());

            double rental = 0;

            if(season == "Spring")
            {
                rental = 3000;
            }
            else if(season == "Summer" || season == "Autumn")
            {
                rental = 4200;
            }
            else if(season == "Winter")
            {
                rental = 2600;
            }

            if(fishers <= 6)
            {
                rental = rental - 0.10 * rental;
            }
            else if(fishers > 6 && fishers <= 11)
            {
                rental = rental - 0.15 * rental;
            }
            else
            {
                rental = rental - 0.25 * rental;
            }

            if(fishers % 2 == 0  && season != "Autumn")
            {
                rental = rental - 0.05 * rental;
            }
            
            if(rental <= budget)
            {
                Console.WriteLine($"Yes! You have {budget - rental:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {rental - budget:f2} leva.");
            }
        }
    }
}