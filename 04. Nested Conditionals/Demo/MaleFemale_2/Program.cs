using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaleFemale_2
{
    class Program
    {
        static void Main()
        {
            double age = double.Parse(Console.ReadLine());
            char gender = char.Parse(Console.ReadLine());

            if (age < 16)
            {
                if (gender == 'f')
                {
                    Console.WriteLine("Miss");
                }
                else
                {
                    Console.WriteLine("Master");
                }
                
            }
            else
            {
                if (gender == 'f')
                {
                    Console.WriteLine("Ms.");
                }
                else
                {
                    Console.WriteLine("Mr.");
                }
            }
        }
    }
}
