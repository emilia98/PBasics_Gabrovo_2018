using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Balance
{
    class Program
    {
        static void Main(string[] args)
        {
            int vnoski = int.Parse(Console.ReadLine());
            int counter = 1; // broqch na vnoski
            decimal balance = 0;

            while(counter <= vnoski)
            {
                decimal income = decimal.Parse(Console.ReadLine());

                if(income < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }

                Console.WriteLine($"Increase: {income:f2}");
                balance += income;
                counter++;
            }

            Console.WriteLine($"Total: {balance:f2}");
        }
    }
}
