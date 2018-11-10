using System;

namespace _07.WaterDispenser
{
    class WaterDispenser
    {
        static void Main()
        {
            int capacity = int.Parse(Console.ReadLine());
            int waterFilled = 0;
            int taps = 0;

            while (waterFilled < capacity)
            {
                string command = Console.ReadLine();

                if(command == "Easy")
                {
                    waterFilled += 50;
                }
                else if(command == "Medium")
                {
                    waterFilled += 100;
                }
                else if(command == "Hard")
                {
                    waterFilled += 200;
                }
                taps++;
            }

            if(waterFilled == capacity)
            {
                Console.WriteLine($"The dispenser has been tapped {taps} times.");
            }
            else
            {
                Console.WriteLine($"{waterFilled - capacity}ml has been spilled.");
            }
        }
    }
}