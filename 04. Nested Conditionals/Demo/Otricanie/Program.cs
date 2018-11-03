using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otricanie
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(!false); // true
            Console.WriteLine(!true); // false
            bool isValid = (n > 10) && (n % 2 == 0);

            /*
            if(isValid == false)
            {
               
            }
            */
            // false -> !false = true
            if(!isValid)
            {
                Console.WriteLine("Nevalidno chislo");
            }
        }
    }
}
