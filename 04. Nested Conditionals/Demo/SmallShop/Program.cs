using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string productName = Console.ReadLine();
            string town = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            double totalPrice = 0;

            if(productName == "coffee")
            {
                if(town == "Sofia")
                {
                    totalPrice = 0.5 * quantity;
                }
                else if(town == "Plovdiv")
                {
                    totalPrice = 0.4 * quantity;
                }
                else if(town == "Varna")
                {
                    totalPrice = 0.45 * quantity;
                }
            }
            else if(productName == "water")
            {
                if (town == "Sofia")
                {
                    totalPrice = 0.8 * quantity;
                }
                else if (town == "Plovdiv")
                {
                    totalPrice = 0.7 * quantity;
                }
                else if (town == "Varna")
                {
                    totalPrice = 0.7 * quantity;
                }
            }
            else if(productName == "beer")
            {
                if (town == "Sofia")
                {
                    totalPrice = 1.2 * quantity;
                }
                else if (town == "Plovdiv")
                {
                    totalPrice = 1.15 * quantity;
                }
                else if (town == "Varna")
                {
                    totalPrice = 1.1 * quantity;
                }
            }
            else if (productName == "sweets")
            {
                if (town == "Sofia")
                {
                    totalPrice = 1.45 * quantity;
                }
                else if (town == "Plovdiv")
                {
                    totalPrice = 1.3 * quantity;
                }
                else if (town == "Varna")
                {
                    totalPrice = 1.35 * quantity;
                }
            }
            else if (productName == "peanuts")
            {
                if (town == "Sofia")
                {
                    totalPrice = 1.6 * quantity;
                }
                else if (town == "Plovdiv")
                {
                    totalPrice = 1.5 * quantity;
                }
                else if (town == "Varna")
                {
                    totalPrice = 1.55 * quantity;
                }
            }

            Console.WriteLine(totalPrice);
        }
    }
}
