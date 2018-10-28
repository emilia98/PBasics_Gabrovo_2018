using System;

namespace _01.SumSeconds
{
    class SumSeconds
    {
        static void Main()
        {
            int time_1 = int.Parse(Console.ReadLine());
            int time_2 = int.Parse(Console.ReadLine());
            int time_3 = int.Parse(Console.ReadLine());

            int totalSeconds = time_1 + time_2 + time_3;

            int minutes = totalSeconds / 60;
            int seconds = totalSeconds % 60;

            
            if(seconds < 10)
            {
                Console.WriteLine($"{minutes}:0{seconds}");
            }
            else
            {
                Console.WriteLine($"{minutes}:{seconds}");
            }
        }
    }
}
