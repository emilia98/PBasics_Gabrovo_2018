using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_7
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.Write(i + " ");

                int lastDigit = i % 10;

                if (lastDigit == 5)
                {
                    break;
                }
            }

        }
    }
}
