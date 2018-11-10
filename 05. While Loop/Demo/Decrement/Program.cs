using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decrement
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 2;
            Console.WriteLine(--a); // 1
            Console.WriteLine(a); // 1

            int b = -5;
            Console.WriteLine(b--); // -5
            Console.WriteLine(b); // -6
            
            int c = a--;
            Console.WriteLine(c); // 1
            Console.WriteLine(a); // 0
            
            int d = --b;
            Console.WriteLine(d); // -7
            Console.WriteLine(b); // -7
        }
    }
}
