using System;

namespace _04.Vacantion
{
    class Vacantion
    {
        static void Main()
        {
            decimal moneyForVacantion = decimal.Parse(Console.ReadLine());
            decimal balance = decimal.Parse(Console.ReadLine());

            int daysSpending = 0;
            int totalDays = 0;

            while(true)
            {
                string action = Console.ReadLine();
                decimal sum = decimal.Parse(Console.ReadLine());

                totalDays++;

                if(action == "spend")
                {
                    daysSpending++;

                    balance -= sum;

                    // Ако текущия баланс на Джеси е под 0 след като е
                    // похарчила дадената сума, ние го правим 
                    // да е равен на 0.
                    if(balance < 0)
                    {
                        balance = 0;
                    }
                }
                else if(action == "save")
                {
                    daysSpending = 0;
                    balance += sum;
                }

                if(daysSpending == 5)
                {
                    break;
                }
                
                if(balance >= moneyForVacantion)
                {
                    break;
                }
            }

            if(balance >= moneyForVacantion)
            {
                Console.WriteLine($"You saved the money for {totalDays} days.");
            }
            else
            {
                Console.WriteLine($"You can't save the money.");
                Console.WriteLine(totalDays);
            }
        }
    }
}