using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            double b = 4.5;

            var result1 = (double)a - b;
            var result2 = a - (int)b; 

            Console.WriteLine(result1);
            Console.WriteLine(result2);


        }
    }
}