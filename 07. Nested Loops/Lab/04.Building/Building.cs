using System;

namespace _04.Building
{
    class Building
    {
        static void Main()
        {
            /*
             -> четен етаж - офиси (O)
             -> нечетен етаж - апартаменти (A)
             -> последен етаж - големи апартаменти (L)
             */

            int floors = int.Parse(Console.ReadLine());
            int flatCount = int.Parse(Console.ReadLine());

            // Ще пази типа на даденото помещение - F, L, O
            char letter;
            // Въртим етажите - Запчоваме от най-горния и стигаме до 1-вия етаж
            for (int i = floors; i >= 1; i--)
            {
                // i -> текущ етаж

                // Проверяваме дали текущия етаж е последния етаж
                if (i == floors)
                {
                    // На последния етаж сме в момента
                    letter = 'L';
                }
                else
                {
                    if (i % 2 == 0)
                    {
                        letter = 'O';
                    }
                    else
                    {
                        letter = 'A';
                    }
                }

                // Взема номерата на помещенията на дадения етаж
                for (int j = 0; j <= flatCount - 1; j++)
                {
                    Console.Write($"{letter}{i}{j} ");
                }
                Console.WriteLine();
            }
        }
    }
}