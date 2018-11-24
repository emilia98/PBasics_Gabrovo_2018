using System;

namespace _03.GameStatistics
{
    class GameStatistics
    {
        static void Main()
        {
            // минути
            int minutes = int.Parse(Console.ReadLine());
            // име на играч
            string playerName = Console.ReadLine();

            // ПЪРВИ РЕД ОТ ИЗХОДА
            if (minutes == 0)
            {
                Console.WriteLine("Match has just began!");
            }
            else if (minutes < 45)
            {
                Console.WriteLine("First half time.");
            }
            else if (minutes >= 45)
            {
                Console.WriteLine("Second half time.");
            }
            
            // ВТОРИ РЕД
            // -> Ако минутите са между 1 и 10 включително:
            if (minutes >= 1 && minutes <= 10)
            {
                Console.WriteLine($"{playerName} missed a penalty.");

                // --> Ако същевременно минутите са четно число, да се отпечата:
                if (minutes % 2 == 0)
                {
                    Console.WriteLine($"{playerName} was injured after the penalty.");
                }
            }
            // -> Ако минутите са по-големи от 10 и по-малки или равни на 35:
            else if (minutes > 10 && minutes <= 35)
            {
                Console.WriteLine($"{playerName} received yellow card.");

                // --> Ако същевременно минутите са нечетно число, да се отпечата:
                if (minutes % 2 == 1)
                {
                    Console.WriteLine($"{playerName} got another yellow card.");
                }
            }
            // Ако минутите са по-големи от 35 и по-малки от 45:
            // ??? "<" ili "<="
            else if (minutes > 35 && minutes < 45)
            {
                Console.WriteLine($"{playerName} SCORED A GOAL !!!");
            }
            // -> Ако минутите са по-големи от 45 и по-малки или равни на 55.
            // ??? ">" ili ">="
            else if (minutes > 45 && minutes <= 55)
            {
                Console.WriteLine($"{playerName} got a freekick.");

                // --> Ако същевременно минутите са четно число, да се отпечата:
                if (minutes % 2 == 0)
                {
                    Console.WriteLine($"{playerName} missed the freekick.");
                }
            }
            // Ако минутите са по-големи от 55 и по-малки или равни на 80.
            else if(minutes > 55 && minutes <= 80)
            {
                Console.WriteLine($"{playerName} missed a shot from corner.");

                // --> Ако същевременно минутите са нечетно число, да се отпечата:
                if(minutes % 2 == 1)
                {
                    Console.WriteLine($"{playerName} has been changed with another player.");
                }
            }
            // -> Ако минутите са по-големи от 80 и по-малки или равни на 90:
            else if(minutes > 80 && minutes <= 90)
            {
                Console.WriteLine($"{playerName} SCORED A GOAL FROM PENALTY !!!");
            }
        }
    }
}