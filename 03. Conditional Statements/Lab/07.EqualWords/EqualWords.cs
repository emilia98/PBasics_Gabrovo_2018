using System;

namespace _07.EqualWords
{
    class EqualWords
    {
        static void Main()
        {
            string wordA = Console.ReadLine();
            string wordB = Console.ReadLine();

            wordA = wordA.ToLower();
            wordB = wordB.ToLower();

            if (wordA.Equals(wordB))
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
