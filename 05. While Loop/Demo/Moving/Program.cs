using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double length = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double freeSpace = width * length * height;
            double boxVolume = 1 * 1 * 1;
            bool hasEnoughFreeSpace = true;
            
            while(true)
            {
                string command = Console.ReadLine();

                if(command == "Done")
                {
                    break;
                }

                int boxes = int.Parse(command);
                double total = boxVolume * boxes; // obemyt, koito zaemat tezi kashoni

                freeSpace -= total;

                if (freeSpace < 0)
                {
                    hasEnoughFreeSpace = false;
                    break;
                }
            }
            
            // Ako svobodnoto mqsto e stignalo
            if(hasEnoughFreeSpace)
            {
                Console.WriteLine($"{freeSpace} Cubic meters left.");
            }
            // Ako svobodnoto mqsto NE e stignalo
            else
            {
                Console.WriteLine($"No more free space! You need {Math.Abs(freeSpace)} Cubic meters more.");
            }
            /*
            Console.WriteLine(freeSpace);
            
            
            if(freeSpace < 0)
            {
               
            }
            else
            {
                
            }*/
        }
    }
}