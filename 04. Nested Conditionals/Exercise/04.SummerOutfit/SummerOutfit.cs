using System;

namespace _04.SummerOutfit
{
    class SummerOutfit
    {
        static void Main()
        {
            int temperature = int.Parse(Console.ReadLine());
            string partOfDay = Console.ReadLine();

            string outfit = "";
            string shoes = "";
            
            if(temperature >= 10 && temperature <= 18)
            {
                if(partOfDay == "Morning")
                {
                    outfit = "Sweatshirt";
                    shoes = "Sneakers";
                }
                // Можем да комбинираме по този начин, за да избегнем повтарянето на код
                else if (partOfDay == "Afternoon" || partOfDay == "Evening")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
                /*
                else if (partOfDay == "Evening")
                {
                    outfit = "Shirt";
                    outfit = "Moccasins";
                }
                */
            }
            else if (temperature > 18 && temperature <= 24)
            {
                if (partOfDay == "Morning")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
                else if (partOfDay == "Afternoon")
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                }
                if (partOfDay == "Evening")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
            }
            else if (temperature > 24)
            {
                if (partOfDay == "Morning")
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                }
                else if (partOfDay == "Afternoon")
                {
                    outfit = "Swim Suit";
                    shoes = "Barefoot";
                }
                if (partOfDay == "Evening")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
            }
            Console.WriteLine($"It's {temperature} degrees, get your {outfit} and {shoes}.");
        }
    }
}