using System;

namespace _08.Journey
{
    class Journey
    {
        static void Main()
        {
            decimal budget = decimal.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string destination = "";
            string stayType = "";
            decimal moneySpend = 0;
            
            if(budget <= 100)
            {
                destination = "Bulgaria";

                if(season == "summer")
                {
                    stayType = "Camp";
                    moneySpend = 0.30m * budget;
                }
                else if(season == "winter")
                {
                    stayType = "Hotel";
                    moneySpend = 0.70m * budget;
                }
            }
            else if(budget > 100 && budget <= 1000)
            {
                destination = "Balkans";

                if (season == "summer")
                {
                    stayType = "Camp";
                    moneySpend = 0.40m * budget;
                }
                else if (season == "winter")
                {
                    stayType = "Hotel";
                    moneySpend = 0.80m * budget;
                }
            }
            else
            {
                destination = "Europe";
                moneySpend = 0.90m * budget;
                stayType = "Hotel";
            }

            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{stayType} - {moneySpend:f2}");
        }
    }
}