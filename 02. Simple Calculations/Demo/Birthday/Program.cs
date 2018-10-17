using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Birthday
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            double inputPercent = double.Parse(Console.ReadLine());

            double v = a * b * c;
            double liters = v / 1000;
            double percent = inputPercent / 100;
            
            double litersNeeded = liters * (1 - percent);
            Console.WriteLine($"{litersNeeded:F3}");
        }
    }
}
