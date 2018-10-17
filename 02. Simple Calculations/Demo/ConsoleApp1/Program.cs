using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            // Разширен начин
            string sideAsString = Console.ReadLine();
            int a = int.Parse(sideAsString);

            // Съкратен начин
           //  int a1 = int.Parse(Console.ReadLine());

            int area = a * a;
            // Console.WriteLine(area);
            // Console.WriteLine(a * a);
            
            // int vol = a * a * a; 
            int volume = area * a;
            */

            string symbol = Console.ReadLine();
            // char asChar = char.Parse(symbol);
            char asChar = symbol[0];
            Console.WriteLine(symbol.GetType());
            Console.WriteLine(asChar.GetType());
        }
    }
}
