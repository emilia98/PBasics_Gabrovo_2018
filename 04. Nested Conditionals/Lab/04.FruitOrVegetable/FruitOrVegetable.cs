using System;

namespace _04.FruitOrVegetable
{
    class FruitOrVegetable
    {
        static void Main()
        {
            string word = Console.ReadLine();

            if (word == "banana" ||
                word == "apple" ||
                word == "kiwi" ||
                word == "cherry" ||
                word == "lemon" ||
                word == "grapes")
            {
                Console.WriteLine("fruit");
            }
            else if (word == "tomato" ||
                    word == "cucumber" ||
                    word == "pepper" ||
                    word == "carrot")
            {
                Console.WriteLine("vegetable");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}