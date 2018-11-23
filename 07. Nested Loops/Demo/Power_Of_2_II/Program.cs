using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Power_Of_2_II
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            // int result = 1; 
            // 0, 2, 4
            for (int power = 0; power <= n; power += 2)
            {

                Console.WriteLine(Math.Pow(2, power));
                //if (power % 2 == 0)
                //{

                // }

            }
        }
    }
}
