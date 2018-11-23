using System;

namespace _02.WeddingParty
{
    class WeddingParty
    {
        static void Main()
        {
            int guestsCount = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            // Намираме бюджетът, от който се нуждаят за партито
            int budgedNeeded = guestsCount * 20;

            // Ако необходимият бюджет стигне (по-малък е или равен на дадения бюджет), то печатаме някакво съобщение и правим още няколко изчисления 
            if (budgedNeeded <= budget)
            {
                // Намираме колко пари са ни останали
                decimal moneyLeft = budget - budgedNeeded;
                // Намираме колко пари ще отидат за фоерверки => 40 % от останалите пари
                decimal moneyForFireworks = moneyLeft * 0.40m;
                // Намираме колко пари ще отидат за дарения
                decimal moneyForDonations = moneyLeft - moneyForFireworks;

                Console.WriteLine($"Yes! {Math.Round(moneyForFireworks)} lv are for fireworks and {Math.Round(moneyForDonations)} lv are for donation. ");
            }
            // Ако необходимият бюджет НЕ стигне, печатаме друго съобщение
            else
            {
                decimal moneyMore = budgedNeeded - budget;
                // Не е необходимо да закръгляме, защото винаги ще получим цяло число
                Console.WriteLine($"They won't have enough money to pay the covert. They will need {moneyMore} lv more.");
            }
        }
    }
}