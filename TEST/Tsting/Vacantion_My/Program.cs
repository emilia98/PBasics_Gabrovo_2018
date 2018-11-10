using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal holiday = decimal.Parse(Console.ReadLine());
            decimal got = decimal.Parse(Console.ReadLine());
            //int i = 1;
            //int j = 0;

            int currentDay = 1;
            int daysInRow = 1;
            while (true)
            {
                string action = Console.ReadLine();
                decimal money = decimal.Parse(Console.ReadLine());

                if (action == "spend")
                {
                    daysInRow++;
                    got = got - money;
                    if (got < 0)
                    {
                        got = 0;
                    }
                }
                else if (action == "save")
                {
                    daysInRow = 1;
                    got = got + money;
                }

                if (daysInRow == 5)
                {
                    Console.WriteLine("You can't save the money.");
                    Console.WriteLine(currentDay);
                    break;
                }

                if (got >= holiday)
                {
                    Console.WriteLine($"You saved the money for {currentDay} days.");
                    break;
                }
                
                currentDay++;
            }
        }
    }
}