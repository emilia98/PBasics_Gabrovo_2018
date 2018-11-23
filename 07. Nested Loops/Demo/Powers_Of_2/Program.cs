using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Powers_Of_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for(int power = 0; power <= n; power++)
            {
                // Math.Pow(x, y)
                // x -> числото, което искаме да повдигнем на някаква степен
                // y -> степента

                // Трябва да проверим дали степента е четно число
                if(power % 2 == 0)
                {
                    Console.WriteLine(Math.Pow(2, power));
                }
               
            }
        }
    }
}
