using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greeting
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            string firstName = "Pesho";
            string secondName = "Peshov";
            int age = 15;

            Console.WriteLine("I'm Pesho Peshov - 15 years old.");
            Console.WriteLine("I'm {0} {1} - {2} years old.", firstName, secondName, age);
            Console.WriteLine("I'm {0} {1} - {2} years old.", secondName, firstName, age);

           // Console.WriteLine("I'm {1} {0} - {-2} years old.", secondName, firstName, age);

            // Console.WriteLine("I'm {1} {0} - {3} years old.", secondName, firstName, age);
            
            Console.WriteLine();
            Console.WriteLine($"Hello, {name}!");
            // Console.WriteLine("Hello, {0} {1}!", name);
            Console.WriteLine("Hello, " + name + "!");
            // BETTER PRACTICE THAN
            // Console.WriteLine(String.Format("Hello, {0}, {1}!", name));

            /*
            int? x = null;
            Console.WriteLine("Hello, {0}!", x);
            */
        }
    }
}
