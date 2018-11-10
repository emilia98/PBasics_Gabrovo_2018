using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_While
{
    class Program
    {
        static void Main(string[] args)
        {
            // int x = int.Parse(Console.ReadLine());
            int number = 1;
            while(number <= 100)
            {
                // Console.WriteLine(number++);
                // Console.WriteLine(number);
                // number++;
                Console.WriteLine(++number);
                // ++number;
                // number += 1;
            }
        }
    }
}
