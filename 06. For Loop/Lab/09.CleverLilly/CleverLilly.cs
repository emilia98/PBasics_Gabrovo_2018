using System;

namespace _09.CleverLilly
{
    class CleverLilly
    {
        static void Main()
        {
            int age = int.Parse(Console.ReadLine());
            decimal washingMachinePrice = decimal.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());
            
            int toysCount = 0;
            decimal money = 10;
            decimal collectedMoney = 0;

            // От първия ѝ рожден ден до текущата и възраст, ние трябва да:
            // -> колко играчки е получила
            for(int bday = 1; bday <= age; bday++)
            {
                if(bday % 2 == 0)
                {
                    collectedMoney = collectedMoney + money - 1;
                    money = money + 10;
                }
                // Ако текущия ѝ рожден ден е НЕЧЕТНО число
                else
                {
                    // Тя получава по ЕДНА играчка
                    toysCount++;
                }

            }

            // Пари, получени от продажбата на играчките
            decimal totalMoneyFromToys = toysCount * toyPrice;
            // Всички пари
            decimal totalMoney = collectedMoney + totalMoneyFromToys;

            if (totalMoney >= washingMachinePrice)
            {
                decimal diff = totalMoney - washingMachinePrice;
                Console.WriteLine($"Yes! {diff:f2}");
            }
            else
            {
                decimal diff = washingMachinePrice - totalMoney;
                Console.WriteLine($"No! {diff:f2}");
            }

            /*
            decimal diff = Math.Abs(totalMoney - washingMachinePrice);

            if (totalMoney >= washingMachinePrice)
            {
                Console.WriteLine($"Yes! {diff:f2}");
            }
            else
            {
                Console.WriteLine($"No! {diff:f2}");
            }
            */
        }
    }
}