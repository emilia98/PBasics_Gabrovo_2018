using System;

namespace _08.VowelsSum
{
    class VowelsSum
    {
        static void Main()
        {
            string text = Console.ReadLine();

            int symbolsCount = text.Length; // дължина на текста
            int lastIndex = symbolsCount - 1;
            int sum = 0;

            for (int index = 0; index <= lastIndex; index++)
            {
                // За всеки смвол от дадения текст, проверяваме
                // дали е гласна буква. Ако е гласна буква,
                // добавяме нейната стойност според дадената таблица
                // към сумата.
                char currentSymbol = text[index]; // Текущия символ, който стои зад дадения index
                
                if(currentSymbol == 'a')
                {
                    sum = sum + 1;
                }
                else if(currentSymbol == 'e')
                {
                    sum = sum + 2;
                }
                else if(currentSymbol == 'i')
                {
                    sum = sum + 3;
                }
                else if(currentSymbol == 'o')
                {
                    sum = sum + 4;
                }
                else if(currentSymbol == 'u')
                {
                    sum = sum + 5;
                }
            }
            Console.WriteLine(sum);
        }
    }
}