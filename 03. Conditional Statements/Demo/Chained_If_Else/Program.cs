using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chained_If_Else
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            
            */

            double grade = double.Parse(Console.ReadLine());

            if (grade >= 5.5 && grade <= 6)
            {
                Console.WriteLine("Excellent");
            }
            else if(grade >= 4.5 && grade < 5.5)
            {
                Console.WriteLine("Mnogo dobyr");
            }
            else if (grade >= 3.5 && grade < 4.5)
            {
                Console.WriteLine("Dobyr");
            }
            else if (grade >= 3 && grade < 3.5)
            {
                Console.WriteLine("Sreden");
            }
            else if(grade < 3 && grade >= 2)
            {
                Console.WriteLine("Slab");
            }
            else
            {
                Console.WriteLine("Invalid Grade");
            }

           
        }
    }
}
