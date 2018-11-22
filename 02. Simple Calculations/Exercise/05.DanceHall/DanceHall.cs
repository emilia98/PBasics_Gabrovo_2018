using System;

namespace _05.DanceHall
{
    class DanceHall
    {
        static void Main()
        {
            // Въвеждаме дължините на страните в метри
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            // Въвеждаме страната на гардероба в метри
            double wardrobeSide = double.Parse(Console.ReadLine());

            // Намираме дължините в сантиметри на всяка една от страните на залата
            double lengthInCm = length * 100;
            double widthInCm = width * 100;

            // Намираме дължините в сантиметри на страната на гардероба
            double wardrobeSizeInCm = wardrobeSide * 100;

            // Намираме площта на залата
            double hallArea = lengthInCm * widthInCm;
            // Намираме площта на гардероба
            double wardrobeArea = wardrobeSizeInCm * wardrobeSizeInCm;
            // Намираме площта, която пейката заема
            double benchArea = hallArea / 10;

            // Намираме колко свободно място остава
            double freeSpace = hallArea - (wardrobeArea + benchArea);

            // Намираме от колко място се нуждае всеки един танцьор
            double dancerNeededSpace = 40 + 7000;
            
            // Намираме броя танцьори, които може залата да побере
            int totalDancers = (int)(freeSpace / dancerNeededSpace);

            Console.WriteLine(totalDancers);
        }
    }
}