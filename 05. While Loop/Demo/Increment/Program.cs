using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Increment
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            Console.WriteLine(++a); // 2
            Console.WriteLine(a); // 2
            // a = a + 1;

            int b = 5;
            Console.WriteLine(b++); // 5
            Console.WriteLine(b); // 6

            int c = b++;
            Console.WriteLine(c);
            Console.WriteLine(b);

            int d = ++a;
            Console.WriteLine(d); // 3
            Console.WriteLine(a); // 3
        }
    }
}
