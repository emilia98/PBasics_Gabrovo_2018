using System;

namespace _03.CurrencyConverter
{
    class CurrencyConverter
    {
        static void Main()
        {
            decimal toConvert = decimal.Parse(Console.ReadLine());
            string inputCurrency = Console.ReadLine();
            string outputCurrency = Console.ReadLine();

            decimal result = 0m;
            decimal toBGN = 0m;

            if (inputCurrency == "BGN")
            {
                toBGN = toConvert;
            }
            else if (inputCurrency == "USD")
            {
                toBGN = toConvert * 1.79549m;
            }
            else if (inputCurrency == "EUR")
            {
                toBGN = toConvert * 1.95583m;
            }
            else if (inputCurrency == "GBP")
            {
                toBGN = toConvert * 2.53405m;
            }

            if (outputCurrency == "BGN")
            {
                result = toBGN;
            }
            else if (outputCurrency == "USD")
            {
                result = toBGN / 1.79549m;
            }
            else if (outputCurrency == "EUR")
            {
                 result = toBGN / 1.95583m;
            }
            else if(outputCurrency == "GBP")
            {
                 result = toBGN / 2.53405m;
            }

            Console.WriteLine($"{Math.Round(result, 2)} {outputCurrency}");
        }
    }
}