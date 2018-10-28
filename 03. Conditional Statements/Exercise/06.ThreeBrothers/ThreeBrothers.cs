using System;

namespace _06.ThreeBrothers
{
    class ThreeBrothers
    {
        static void Main()
        {
            double timeOfA = double.Parse(Console.ReadLine());
            double timeOfB = double.Parse(Console.ReadLine());
            double timeOfC = double.Parse(Console.ReadLine());
            double timeForFishing = double.Parse(Console.ReadLine());

            double productivity_A = 1 / timeOfA;
            double productivity_B = 1 / timeOfB;
            double productivity_C = 1 / timeOfC;

            double totalProductivity = productivity_A + productivity_B + productivity_C;
            double timeForWork = 1 / totalProductivity;
            double timeForBreak = timeForWork * 0.15;

            double totalTime = timeForWork + timeForBreak;

            // Console.WriteLine($"Cleaning time: {Math.Round(totalTime, 2)}");
            Console.WriteLine($"Cleaning time: {totalTime:f2}");

            if (totalTime < timeForFishing)
            {
                // резултатът трябва да е закръглен до следващото по-малко цяло число
                double timeLeft = Math.Floor(timeForFishing - totalTime);
                Console.WriteLine($"Yes, there is a surprise - time left -> {timeLeft} hours.");
            }
            else
            {
                // резултатът трябва да е закръглен до следващото по-голямо цяло число
                double timeNeeded = Math.Ceiling(totalTime - timeForFishing);
                Console.WriteLine($"No, there isn't a surprise - shortage of time -> {timeNeeded} hours.");
            }
        }
    }
}