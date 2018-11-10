using System;

namespace _10.HotelRoom
{
    class HotelRoom
    {
        static void Main()
        {
            string month = Console.ReadLine();
            int nightsCount = int.Parse(Console.ReadLine());

            decimal apartmentPrice = 0;
            decimal studioPrice = 0;

            if(month == "May" || month == "October")
            {
                apartmentPrice = 65 * nightsCount;
                studioPrice = 50 * nightsCount;
            }
            else if(month == "June" || month == "September")
            {
                apartmentPrice = 68.70m * nightsCount;
                studioPrice = 75.20m * nightsCount;
            }
            else if (month == "July" || month == "August")
            {
                apartmentPrice = 77 * nightsCount;
                studioPrice = 76 * nightsCount;
            }

            if(nightsCount > 7 && nightsCount <= 14)
            {
                if (month == "May" || month == "October")
                {
                    studioPrice = studioPrice - (0.05m * studioPrice);
                }
            }
            else if(nightsCount > 14)
            {
                apartmentPrice = apartmentPrice - (0.10m * apartmentPrice);

                if (month == "May" || month == "October")
                {
                    studioPrice = studioPrice - 0.30m * studioPrice;
                }
                else if (month == "June" || month == "September")
                {
                    studioPrice = studioPrice - 0.20m * studioPrice;
                }
            }

            Console.WriteLine($"Apartment: {apartmentPrice:f2} lv.");
            Console.WriteLine($"Studio: {studioPrice:f2} lv.");
        }
    }
}
