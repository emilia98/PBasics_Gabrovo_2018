using System;

namespace _08.CookieFactory
{
    class CookieFactory
    {
        static void Main()
        {
            int batchesCount = int.Parse(Console.ReadLine());
            int baked = 0;

            // Създаваме 3 променливи, всяка от които ще отговаря дали 
            // дадена основна състава присъства в сместа
            // Началната стойност на всяка е false, т.е по подразбиране
            // тези съставки липсват, но при тяхното добаване, стойността от 
            // false
            bool hasFlour = false;
            bool hasEggs = false;
            bool hasSugar = false;

            while (baked < batchesCount)
            {
                while (true)
                {
                    string command = Console.ReadLine();

                    // Текстът, който сме въвели от клавиатурата може да бъде
                    // или командата Bake!, или някоя от съставките
                    if (command == "Bake!")
                    {
                        break;
                    }

                    string ingredient = command;

                    // Проверяваме дали текущата съставка е някоя от основните три.
                    // Ако е така, променяме наличността на тази съставка - от false става на true
                    if (ingredient == "flour")
                    {
                        hasFlour = true;
                    }
                    else if (ingredient == "eggs")
                    {
                        hasEggs = true;
                    }
                    else if (ingredient == "sugar")
                    {
                        hasSugar = true;
                    }
                }

                // Ако всички основни съставки присъстват в сместа, можем да я опечем
                if (hasFlour == true && hasEggs == true && hasSugar == true)
                {
                    // Увеличаваме брояча на опечените смеси.
                    baked++;
                    // Опекли сме сместа, вече можем да "нулираме" стойностите
                    // на основните съставки и да започнем подготовката на нова смес
                    hasFlour = false;
                    hasEggs = false;
                    hasSugar = false;
                    Console.WriteLine($"Baking batch number {baked}...");
                }
                else
                {
                    Console.WriteLine("The batter should contain flour, eggs and sugar!");
                }
            }
        }
    }
}