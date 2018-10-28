using System;

namespace _09.WorldSwimmingRecord
{
    class WorldSwimmingRecord
    {
        static void Main()
        {
            double record = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double timePerMeter = double.Parse(Console.ReadLine());

            double time = distance * timePerMeter;
            double delay = (int)(distance / 15) * 12.5;
            double totalTime = time + delay;

            if(totalTime < record)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {totalTime:f2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {totalTime - record:f2} seconds slower.");
            }
        }
    }
}
