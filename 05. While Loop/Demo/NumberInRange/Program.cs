using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.Write("Enter a number in the range [1...100]: ");
            int number = int.Parse(Console.ReadLine());

            // Dokato vyvedenoto chislo
            // e  < 1 ili > 100
            // vyvjedaite i pechataite
            // number >= 1 && number <= 100
            while(number < 1 || number > 100)
            {
                Console.WriteLine("Invalid number!");
               // Console.Write("Enter a number in the range [1...100]: ");
                number = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"The number is: {number}");
        }
    }
}
