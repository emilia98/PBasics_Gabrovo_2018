using System;

namespace _06.AccountBalance
{
    class AccountBalance
    {
        static void Main()
        {
            int payment = int.Parse(Console.ReadLine());
            int counter = 1; // broqch na payment
            decimal balance = 0;

            while (counter <= payment)
            {
                decimal income = decimal.Parse(Console.ReadLine());

                if (income < 0)
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