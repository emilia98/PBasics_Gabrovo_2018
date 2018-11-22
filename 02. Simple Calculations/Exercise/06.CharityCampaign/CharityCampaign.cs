using System;

namespace _06.CharityCampaign
{
    class CharityCampaign
    {
        static void Main()
        {
            int days = int.Parse(Console.ReadLine());
            int bakersCount = int.Parse(Console.ReadLine());
            int cakes = int.Parse(Console.ReadLine());
            int wafers = int.Parse(Console.ReadLine());
            int pancakes = int.Parse(Console.ReadLine());

            // Намираме какво количество торти, гофрети и палачинки е правено за ден
            int cakesPerDay = cakes * bakersCount;
            int wafersPerDay = wafers * bakersCount;
            int pancakesPerDay = pancakes * bakersCount;

            // Намираме по колко пари е правил всеки тип сладкарско изделие за един ден
            decimal moneyPerDay_cakes = cakesPerDay * 45;
            decimal moneyPerDay_wafers = wafersPerDay * 5.80m;
            decimal moneyPerDay_pancakes = pancakesPerDay * 3.20m;

            decimal totalMoneyFromCakes = moneyPerDay_cakes * days;
            decimal totalMoneyFromWafers = moneyPerDay_wafers * days;
            decimal totalMoneyFromPancakes = moneyPerDay_pancakes * days;

            decimal totalMoney = totalMoneyFromCakes + totalMoneyFromWafers + totalMoneyFromPancakes;
            // Не трябва да умножаваме така: (1 / 8), защото този израз връща като резултат 0
            decimal expenses = totalMoney * (1.0m / 8);
            
            // Намираме чистата печалба, като от всички спечелени пари изваждаме разходите
            decimal moneyEarned = totalMoney - expenses;
            Console.WriteLine($"{moneyEarned:f2}");
        }
    }
}