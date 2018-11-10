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
            int i = 1;
            int j = 0;
            while (true)
            {
                string action = Console.ReadLine();
                decimal money = decimal.Parse(Console.ReadLine());
                if (action == "spend")
                {
                    j++;
                    got = got - money;
                    if (got < 0)
                        got = 0;
                }
                else if (action == "save")
                {
                    // Нулирай брояча, който следи колко последователни дни сме харчили пари
                    j = 0;
                    //j--;
                    got = got + money;
                   // if (j < 0)
                    //    j = 0;
                }
                if (got >= holiday)
                {
                    Console.WriteLine($"You saved the money for {i} days.");
                    break;
                }
                if (j == 5)
                {
                    Console.WriteLine("You can't save the money.");
                    Console.WriteLine(i);
                    break;
                }
                i++;
            }
        }
    }
}