using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Priority
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());

            /*
             (x >= 100 && x <= 200) || x == 0
             x >= 100 && (x <= 200 || x == 0)
             */
            if ( (x >= 100 && x <= 200) || x == 0)
            {
                Console.WriteLine("HERE");
            }
        }
    }
}
