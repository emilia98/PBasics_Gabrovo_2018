using System;

namespace _01.WeddingHall
{
    class WeddingHall
    {
        static void Main()
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double barSide = double.Parse(Console.ReadLine());

            // Намираме площта на залата
            double hallArea = length * width;
            // Намираме площта, която заема бара
            double barArea = barSide * barSide;
            // Намираме площта, заемана от дансинга
            double dancingArea = hallArea * 0.19;
            
            // Намираме свободната площ
            double freeArea = hallArea - (barArea + dancingArea);

            // Намираме колко гости могат да се съберат върху дансинга
            // Необходимо е кастването към int, защото поради някаква причина
            // Math.Ceiling() връща стойност от тип double. И все пак
            // броят на гостите е цяло число
            int guestsCount = (int)Math.Ceiling(freeArea / 3.2);
            Console.WriteLine(guestsCount);
        }
    }
}