using System;

namespace _07.NameWars
{
    class NameWars
    {
        static void Main()
        {
            string command = Console.ReadLine();

            int maxSum = int.MinValue;
            string bestName = "";

            while (command != "STOP")
            {
                // Пазим името в някаква променлива (само за улеснение)
                string name = command;

                // Колко символа има даденото име
                int nameLength = name.Length;
                int sum = 0;

                // Индекс на Последен символ = дължина на стринга - 1;
                int lastIndex = nameLength - 1;

                // Трябва да обходим всеки символ от името, което сме въвели
                for (int index = 0; index <= lastIndex; index++)
                {
                    // Така се взема символа на дадения индекс от стринга
                    char symbol = name[index];

                    sum += (int)symbol;
                }

                // Използвайки крайната стойност на намерената сума:
                // Ако имаме две имена със сума, равна на максимална сума, кое име пазим
                // -> първото въведено или второто въведено
                if (sum > maxSum)
                {
                    // Трябва да присвоим нова стойност на bestName
                    bestName = name;
                    // Присвояваме нова стойност на maxSum
                    maxSum = sum;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"Winner is {bestName} - {maxSum}!");
        }
    }
}