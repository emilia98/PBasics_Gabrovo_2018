using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            double area = 0;

            if (type == "square")
            {
                double a = double.Parse(Console.ReadLine());
                area = a * a;
            }
            else if(type == "rectangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                area = a * b;
            }
            else if(type == "circle")
            {
                double r = double.Parse(Console.ReadLine());
                // area = Math.PI * Math.Pow(r, 2);
                area = Math.PI * r * r;
            }
            else if(type == "triangle")
            {
                double a = double.Parse(Console.ReadLine());
                double ha = double.Parse(Console.ReadLine());
                area = a * ha / 2;
            }


            Console.WriteLine($"{Math.Round(area, 3)}");
        }
    }
}
