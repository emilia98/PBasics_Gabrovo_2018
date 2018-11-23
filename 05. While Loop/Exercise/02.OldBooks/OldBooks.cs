using System;

namespace _02.OldBooks
{
    class OldBooks
    {
        static void Main()
        {
            string favouriteTitle = Console.ReadLine();
            int libraryCapacity = int.Parse(Console.ReadLine());

            int booksChecked = 0;
            bool hasFound = false;

            while (true)
            {
                string currentBook = Console.ReadLine();
                
                if (currentBook == favouriteTitle)
                {
                    hasFound = true;
                    break;
                }

                booksChecked++;
                if (booksChecked == libraryCapacity)
                {
                    break;
                }
            }

            if (hasFound == true)
            {
                Console.WriteLine($"You checked {booksChecked} books and found it.");
            }
            else
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {booksChecked} books.");
            }

        }
    }
}