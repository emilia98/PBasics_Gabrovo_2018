using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualWords_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string wordA = Console.ReadLine();
            string wordB = Console.ReadLine();

            wordA = wordA.ToUpper();
            wordB = wordB.ToUpper();

            if (wordA == wordB)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
