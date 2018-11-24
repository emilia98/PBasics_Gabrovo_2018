using System;

namespace _01.StadiumIncome
{
    class StadiumIncome
    {
        static void Main()
        {
            int sectorsCount = int.Parse(Console.ReadLine());
            int stadiumCapacity = int.Parse(Console.ReadLine());
            double ticketPrice = double.Parse(Console.ReadLine());

            // приходите от един сектор се сформират от произведението на капацитета на стадиона и цената на един билет, делено на броя сектори. 
            double incomePerSector = (stadiumCapacity * ticketPrice) / sectorsCount;
            double totalIncomes = stadiumCapacity * ticketPrice;

            // Парите за благотворителност ще са равни на една осма от
            // -> разликата между общата печалба и 75% от прихода за един сектор. 
            double charityMoney = (totalIncomes - 0.75 * incomePerSector) / 8;
            
            // Резултатът да се ФОРМАТИРА до втория знак след десетичната запетая.
            Console.WriteLine($"Total income - {totalIncomes:f2} BGN");
            Console.WriteLine($"Money for charity - {charityMoney:f2} BGN");
        }
    }
}