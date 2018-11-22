using System;

namespace _01._2DRectangleArea
{
    class RectangleArea
    {
        static void Main()
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            // Дължината на правоъгълника се намира като вземем 
            // x на едната точка и x на другата точка
            // и ги извадим. Тъй като не знаем коя точка се намира
            // по-надясно, за да намерим дължината, вземаме намерената разлика по модул
            double length = Math.Abs(x1 - x2);
            // Аналогично и за ширината
            double width = Math.Abs(y1 - y2);
            
            // Намираме лицето
            double area = length * width;
            // Намираме периметъра
            double perimeter = 2 * length + 2 * width; // 2 * (length + width);

            Console.WriteLine(area);
            Console.WriteLine(perimeter);
        }
    }
}