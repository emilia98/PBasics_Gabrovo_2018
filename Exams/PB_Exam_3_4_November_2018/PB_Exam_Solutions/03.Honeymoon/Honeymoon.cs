using System;

namespace _03.Honeymoon
{
    class Honeymoon
    {
        static void Main()
        {
            decimal budget = decimal.Parse(Console.ReadLine());
            string city = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            int discount = 0;

            decimal pricePerNight = 0;
            decimal pricePerFlight = 0;

            if(city == "Cairo")
            {
                pricePerNight = 250;
                pricePerFlight = 600;
            }
            else if (city == "Paris")
            {
                pricePerNight = 150;
                pricePerFlight = 350;
            }
            else if (city == "Lima")
            {
                pricePerNight = 400;
                pricePerFlight = 850;
            }
            else if (city == "New York")
            {
                pricePerNight = 300;
                pricePerFlight = 650;
            }
            else if (city == "Tokyo")
            {
                pricePerNight = 350;
                pricePerFlight = 700;
            }

            if (nights >= 1 && nights <= 4)
            {
                if(city == "Cairo" || city == "New York")
                {
                    discount = 3;
                }
            }
            else if(nights >= 5 && nights <= 9)
            {
                if(city == "Cairo" || city == "New York")
                {
                    discount = 5;
                }
                else if(city == "Paris")
                {
                    discount = 7;
                }
            }
            else if(nights >= 10 && nights <= 24)
            {
                if(city == "Cairo")
                {
                    discount = 10;
                }
                else if(city == "New York" || city == "Paris" || city == "Tokyo")
                {
                    discount = 12;
                }
            }
            else if(nights >= 25 && nights <= 49)
            {
                if (city == "Cairo" || city == "Tokyo")
                {
                    discount = 17;
                }
                else if (city == "New York" || city == "Lima")
                {
                    discount = 19;
                }
                else if (city == "Paris")
                {
                    discount = 22;
                }
            }
            else if(nights >= 50)
            {
                discount = 30;
            }

            decimal totalPrice = pricePerNight * nights * 2 + pricePerFlight;
            decimal finalPrice = totalPrice - totalPrice * (discount / 100.0m);
            
            if(finalPrice <= budget)
            {
                decimal moneyLeft = budget - finalPrice;
                Console.WriteLine($"Yes! You have {moneyLeft:f2} leva left.");
            }
            else
            {
                decimal moreMoneyNeeded = finalPrice - budget;
                Console.WriteLine($"Not enough money! You need {moreMoneyNeeded:f2} leva.");
            }
        }
    }
}