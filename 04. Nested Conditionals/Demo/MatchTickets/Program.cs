using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string category = Console.ReadLine();
            int peopleCount = int.Parse(Console.ReadLine());
            
            double forTransport = 0;
            if(peopleCount >= 1 && peopleCount <= 4)
            {
                forTransport = (budget * 0.75);
            }
            else if(peopleCount >= 5 && peopleCount <= 9)
            {
                forTransport = (budget * 0.6);
            }
            else if(peopleCount >= 10 && peopleCount <= 24)
            {
                forTransport = (budget * 0.5);
            }
            else if(peopleCount >= 25 && peopleCount <= 49)
            {
                forTransport = (budget * 0.4);
            }
            else if(peopleCount >= 50)
            {
                forTransport = (budget * 0.25);
            }

            double moneyLeft = budget - forTransport;
            double moneyForTicket = 0;

            if(category == "VIP")
            {
                moneyForTicket = 499.99;
            }
            else if(category == "Normal")
            {
                moneyForTicket = 249.99;
            }

            double moneyForAllTickets = moneyForTicket * peopleCount;
            // Ако парите, които са ни останали, след 
            // покриването на транспортине разходи,
            // са достатъчни за закупуване на билет,
            // печатаме неолходимото съобщение
            if(moneyLeft >= moneyForAllTickets)
            {
                Console.WriteLine($"Yes! You have {(moneyLeft - moneyForAllTickets):f2} leva left.");
            }
            // Ако парите не ни достигат, печатаме 
            // колко още са ни нужни, за да закупим желаното количество билети за всеки запалянко
            else
            {
                Console.WriteLine($"Not enough money! You need {(moneyForAllTickets - moneyLeft):f2} leva.");
            }
        }
    }
}
