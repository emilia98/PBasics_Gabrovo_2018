using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Even_Odd_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            // Console.WriteLine(9 % 2);
            if (num % 2 == 0)
            {
                Console.WriteLine("even");
            }
            
            else if(num % 2 == 1 || num % 2 == -1)
            {
                Console.WriteLine("odd");
            }
            /*
            else
            {
                
            }
            */
        }
    }
}
