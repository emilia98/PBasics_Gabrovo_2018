using System;

namespace _03.Volleyball
{
    class Volleyball
    {
        static void Main()
        {
            string yearType = Console.ReadLine();
            int holidaysCount = int.Parse(Console.ReadLine());
            int weekendsAtHome = int.Parse(Console.ReadLine());

            int weekendsAtSofia = 48 - weekendsAtHome;
            int gamesAtHome = weekendsAtHome;
            double gamesAtHolidays = holidaysCount * (2.0 / 3);

            // Test this:
            // Console.WriteLine(2 / 3);
            // Console.WriteLine(3 / 4);
            double gamesAtSofia = weekendsAtSofia * (3.0 / 4);
            double totalGames = gamesAtHome + gamesAtSofia + gamesAtHolidays;

            if(yearType == "leap")
            {
                totalGames = totalGames + totalGames * 0.15;
            }

            Console.WriteLine(Math.Truncate(totalGames));
        }
    }
}
