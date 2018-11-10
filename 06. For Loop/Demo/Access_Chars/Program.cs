using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Pesho";
            // Дължина = броя символи

            int symbolsCount = text.Length;
            int lastSymbolPosition = symbolsCount - 1;

            for (int index = 0; index <= lastSymbolPosition; index++)
            {
                Console.WriteLine($"{index} -> {text[index]}");
            }
        }
    }
}
