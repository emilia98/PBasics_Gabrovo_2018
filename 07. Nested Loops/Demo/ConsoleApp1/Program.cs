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
            
            int c1 = 1;
            
           // int c3 = 1;
            int c4 = 1;
            int c5 = 1;
            int c6 = 1;

           // 49 * 49
            //  6/49 => 1->49

            while (c1 <= 49)
            {
                int c2 = 1;
                while (c2 <= 49)
                {
                    int c3 = 1;

                    while(c3 <= 49)
                    {
                        Console.WriteLine($"{c1} {c2} {c3}");
                        c3++;
                    }
                   
                    // c2++;
                }
                c1++;
            }

            // Console.WriteLine(c2);
        }
    }
}
