using System;

namespace _05.TimePlus15Minutes
{
    class TimePlus15Minutes
    {
        static void Main()
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int newMinutes = minutes + 15;
            int newHours = hours;

            if(newMinutes >= 60)
            {
                newHours++;
                newMinutes = newMinutes - 60;
            }

            if(newHours > 23)
            {
                // newHours = 24 - newHours;
                newHours = 0;
            }
            
            if(newMinutes < 10)
            {
                Console.WriteLine($"{newHours}:0{newMinutes}");
            }
            else
            {
                Console.WriteLine($"{newHours}:{newMinutes}");
            }
        }
    }
}
