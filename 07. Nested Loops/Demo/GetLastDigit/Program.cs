using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetLastDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 20; i <= 30; i++)
            {
                Console.WriteLine($"{i} => {i % 10}");
            }

        }
    }
}
