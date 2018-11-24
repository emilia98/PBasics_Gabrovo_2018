using System;

namespace _06.Travelling
{
    class Travelling
    {
        static void Main()
        {
            while(true)
            {
                string command = Console.ReadLine();
                
                // Въведения от нас вход може да бъде или командата End, или името на дестинацията, която Ани иска да посети
                if(command == "End")
                {
                    break;
                }

                string destination = command;
                double budget = double.Parse(Console.ReadLine());
                // Спестените пари
                double moneySaved = 0;

                /* Никъде не сме казали, че парите са цяло число
                 * 
                int budget = int.Parse(Console.ReadLine());
                // Спестените пари
                int moneySaved = 0;
                */

                while (moneySaved < budget)
                {
                    // Сумата, която ще добавим към вече спестените пари
                    double money = double.Parse(Console.ReadLine());
                    // int money = int.Parse(Console.ReadLine());

                    moneySaved += money;
                }

                // Щом сме излезли от вътрешния цикъл, значи сме спестили
                // достатъчно пари за посещаване на дадената дестинация.
                // Затова печатаме съобщение
                Console.WriteLine($"Going to {destination}!");
            }
        }
    }
}