using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int magicNumber = int.Parse(Console.ReadLine());

            // Първата цифра не може да е  0, затова започваме от 1
            for(int c1 = 1; c1 <= 9; c1++)
            {
                for(int c2 = 0; c2 <= 9; c2++)
                {
                    for(int c3 = 0; c3 <= 9; c3++)
                    {
                        for(int c4 = 0; c4 <= 9; c4++)
                        {
                            for(int c5 = 0; c5 <= 9; c5++)
                            {
                                for(int c6 = 0; c6 <= 9; c6++)
                                {
                                    int product = c1 * c2 * c3 * c4 * c5 * c6;

                                    if(product == magicNumber)
                                    {
                                        Console.Write($"{c1}{c2}{c3}{c4}{c5}{c6} ");
                                    }
                                }
                            }
                        }
                    }
                }
            }

            Console.WriteLine();
        }
    }
}
