using System;

namespace _05.Walking
{
    class Program
    {
        static void Main()
        {
            int totalSteps = 0;
            bool hasGoneHome = false;

            while (true)
            {
                string input = Console.ReadLine();

                if(input == "Going home")
                {
                    // int stepsToHome = int.Parse(Console.ReadLine());
                    // totalSteps += stepsToHome;
                    hasGoneHome = true;
                    continue;
                    

                   //  break;
                    // continue;
                    // break;
                }

                int steps = int.Parse(input);
                totalSteps += steps;

                if (totalSteps >= 10000)
                {
                    Console.WriteLine("Goal reached! Good job!");
                    break;
                }

                if(hasGoneHome)
                {
                    int stepsLeftToDo = 10000 - totalSteps;
                    Console.WriteLine($"{stepsLeftToDo} more steps to reach goal.");
                    break;
                }

            }
        }
    }
}