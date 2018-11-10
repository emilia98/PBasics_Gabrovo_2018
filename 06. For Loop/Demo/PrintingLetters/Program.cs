using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintingLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            for(char letter = 'a'; letter <= 'z'; letter++)
            {
                Console.WriteLine(letter);
            }*/
            for(int i = 97; i <= 122; i++)
            {
                Console.WriteLine((char)i);
            }
        }
    }
}
