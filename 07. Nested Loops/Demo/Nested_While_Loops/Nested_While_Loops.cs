using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nested_While_Loops
{
    class Nested_While_Loops
    {
        static void Main()
        {
            int i = 0;
            int a = 3;
            
            int b = 5;
            
            while(i < a)
            {
                Console.WriteLine($"i = {i}");

                int j = 0;
                while (j < b)
                {
                    Console.WriteLine($"  == j = {j}");
                    j++;
                }
                i++;
            }
            \

        }
    }
}
