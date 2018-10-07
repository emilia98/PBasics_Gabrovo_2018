using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00.READ
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse("3.99");

            // Четем вход от клавиатурата
            double y = double.Parse(Console.ReadLine());
            int a = (int)(x);
            Console.WriteLine(a);
        }
    }
}
