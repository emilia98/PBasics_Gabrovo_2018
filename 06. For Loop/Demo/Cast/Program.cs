using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cast
{
    class Program
    {
        static void Main(string[] args)
        {
            // int -> char (neobhodimo e kastvane)
            char a = (char)67;
            // char -> int  (NE e neobhodimo)
            int b = '#';
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}
