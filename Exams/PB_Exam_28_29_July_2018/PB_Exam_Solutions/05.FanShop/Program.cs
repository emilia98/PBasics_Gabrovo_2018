using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.FanShop
{
    class Program
    {
        static void Main(string[] args)
        {
            // Бюджет
            int budget = int.Parse(Console.ReadLine());
            // n
            int n = int.Parse(Console.ReadLine());

            int totalSum = 0;
            // Въртим цикъл, който ще въвежда N реда
            for(int lineCounter = 1; lineCounter <= n; lineCounter++)
            {
                // При всяко завъртане на цикъл, трябва да прочитаме по един предмет
                string item = Console.ReadLine();

                if(item == "hoodie")
                {
                    totalSum += 30;
                }
                else if(item == "keychain")
                {
                    totalSum += 4;
                }
                else if(item == "T-shirt")
                {
                    totalSum += 20;
                }
                else if(item == "flag")
                {
                    totalSum += 15;
                }
                else if(item == "sticker")
                {
                    totalSum += 1;
                }
            }

            // Ако бюджетът му е по-голям или равен на сумата от предметите:
            // БЮДЖЕТЪТ Е ДОСТАТЪЧЕН
            if(budget >= totalSum)
            {
                int moneyLeft = budget - totalSum;
                Console.WriteLine($"You bought {n} items and left with {moneyLeft} lv.");
            }
            // БЮДЖЕТЪТ НЕ Е ДОСТАТЪЧЕН
            else
            {
                int moreMoneyNeeded = totalSum - budget;
                Console.WriteLine($"Not enough money, you need {moreMoneyNeeded} more lv.");
            }
        }
    }
}