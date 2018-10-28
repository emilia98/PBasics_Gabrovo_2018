using System;

namespace _04.MetricsConverter
{
    class MetricsConverter
    {
        static void Main()
        {
            const double millimeters = 1000;
            const double centimeters = 100;
            const double miles = 0.000621371192;
            const double inches = 39.3700787;
            const double kilometers = 0.001;
            const double feet = 3.2808399;
            const double yards = 1.0936133;

            double number = double.Parse(Console.ReadLine());
            string metric_1 = Console.ReadLine();
            string metric_2 = Console.ReadLine();

            double result = number;

            if(metric_1 == "m")
            {
                // като превърнем метър към метър, получаваме самото число
                result = number;
            }
            else if(metric_1 == "mm")
            {
                result = number / millimeters;
            }
            else if (metric_1 == "cm")
            {
                result = number / centimeters;
            }
            else if (metric_1 == "mi")
            {
                result = number / miles;
            }
            else if (metric_1 == "in")
            {
                result = number / inches;
            }
            else if (metric_1 == "km")
            {
                result = number / kilometers;
            }
            else if (metric_1 == "ft")
            {
                result = number / feet;
            }
            else if (metric_1 == "yd")
            {
                result = number / yards;
            }

            if (metric_2 == "m")
            {
                // като превърнем метър към метър, получаваме самото число
                result = result;
            }
            else if (metric_2 == "mm")
            {
                result = result * millimeters;
            }
            else if (metric_2 == "cm")
            {
                result = result * centimeters;
            }
            else if (metric_2 == "mi")
            {
                result = result * miles;
            }
            else if (metric_2 == "in")
            {
                result = result * inches;
            }
            else if (metric_2 == "km")
            {
                result = result * kilometers;
            }
            else if (metric_2 == "ft")
            {
                result = result * feet;
            }
            else if (metric_2 == "yd")
            {
                result = result * yards;
            }

            Console.WriteLine($"{result:f8}");
        }
    }
}
