using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maths
{
    class Program
    {
        static void Main(string[] args)
        {
            double up = Math.Ceiling(23.45);
         
            double down = Math.Floor(45.67);

            // Console.WriteLine(Math.Ceiling(23.0));
            // Console.WriteLine(Math.Floor(23.0));

            Console.WriteLine(Math.Round(1.235, 2));
            Console.WriteLine(Math.Round(1.599993, 3));
            Console.WriteLine(Math.Round(1.25, 1));

            Console.WriteLine($"{1.599993}");
            Console.WriteLine($"{1.599993:C1}");
            Console.WriteLine($"{1000.599993:C2}");
            Console.WriteLine($"{1.599993:C3}");

            Console.WriteLine($"{1000.599993:F2}");
            Console.WriteLine($"{1000.599993:N2}");

        }
    }
}
