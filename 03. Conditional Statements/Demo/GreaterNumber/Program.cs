using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreaterNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int max = int.MinValue;

            if(a > b)
            {
                max = a;
            }
            else
            {
                max = b;
            }

            Console.WriteLine($"Greater number: {max}");
        }
    }
}
