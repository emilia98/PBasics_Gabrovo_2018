using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combinations
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            int counter = 0;
            for(int a = 0; a <= n; a++)
            {
                for(int b = 0; b <= n; b++)
                {
                    for(int c = 0; c <= n; c++)
                    {
                        for(int d = 0; d <= n; d++)
                        {
                            for(int e = 0; e <= n; e++)
                            {
                                // Сумираме текущите стойности
                                // на всяка от променливите a, b, c, d и е
                                int sum = a + b + c + d + e;

                                if(sum == n)
                                {
                                    counter++;
                                }
                            }
                        }
                    }
                }
            }

            Console.WriteLine(counter);
        }
    }
}
