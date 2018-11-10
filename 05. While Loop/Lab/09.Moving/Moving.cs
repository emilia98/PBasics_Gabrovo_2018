using System;

namespace _09.Moving
{
    class Moving
    {
        static void Main()
        {
            double width = double.Parse(Console.ReadLine());
            double length = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double freeSpace = width * length * height;
            double boxVolume = 1 * 1 * 1;
            bool hasEnoughFreeSpace = true;

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "Done")
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
            
            if (hasEnoughFreeSpace)
            {
                Console.WriteLine($"{freeSpace} Cubic meters left.");
            }

            else
            {
                Console.WriteLine($"No more free space! You need {Math.Abs(freeSpace)} Cubic meters more.");
            }
        }
    }
}