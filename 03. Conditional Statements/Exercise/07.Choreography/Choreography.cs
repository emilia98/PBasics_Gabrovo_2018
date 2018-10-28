using System;

namespace _07.Choreography
{
    class Choreography
    {
        static void Main()
        {
            int steps = int.Parse(Console.ReadLine());
            int dancers = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());

            double stepsPerDay = steps / days;
            // Някаква странна логика
            // А трябва да закръглим и до следващото по-голямо цяло число (разсъждения от обяснението)
            double stepsPerDayPercent = Math.Ceiling(((stepsPerDay / steps) * 100));
            double percentStepsPerDancer = (stepsPerDayPercent / dancers);
            
            if(stepsPerDayPercent <= 13)
            {
                Console.WriteLine($"Yes, they will succeed in that goal! {percentStepsPerDancer:f2}%.");
            }
            else
            {
                Console.WriteLine($"No, They will not succeed in that goal! Required {percentStepsPerDancer:f2}% steps to be learned per day.");
            }
        }
    }
}