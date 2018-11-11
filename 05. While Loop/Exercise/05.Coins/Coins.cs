using System;

namespace _05.Coins
{
    class Coins
    {
        static void Main()
        {
            double st = double.Parse(Console.ReadLine());
            int totalCoins = 0;

            int money = (int)(st * 100);
            while (money > 0)
            {
                // Колко пъти се съдържат 200 стотинки (2 лева) в сумата
                if (money / 200 > 0)
                {
                    money -= 200;
                    totalCoins++;
                }
                // Колко пъти се съдържат 100 стотинки (1 лев) в сумата
                else if (money / 100 > 0)
                {
                    money -= 100;
                    totalCoins++;
                }
                // Колко пъти се съдържат 50 стотинки в сумата
                else if (money / 50 > 0)
                {
                    money -= 50;
                    totalCoins++;
                }
                else if (money / 20 > 0)
                {
                    money -= 20;
                    totalCoins++;
                }
                else if (money / 10 > 0)
                {
                    money -= 10;
                    totalCoins++;
                }
                else if (money / 5 > 0)
                {
                    money -= 5;
                    totalCoins++;
                }
                else if (money / 2 > 0)
                {
                    money -= 2;
                    totalCoins++;
                }
                else if (money / 1 > 0)
                {
                    money -= 1;
                    totalCoins++;
                }
            }

            Console.WriteLine(totalCoins);
        }
    }
}