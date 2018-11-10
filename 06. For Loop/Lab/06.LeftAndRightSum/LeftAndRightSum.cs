using System;

namespace _06.LeftAndRightSum
{
    class LeftAndRightSum
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            // Ще пазим сумата на числата от първия for
            int leftSum = 0;
            // Ще пазим сумата на числата от втория for
            int rightSum = 0;

            // Лява сума
            for(int counter = 1; counter <= n; counter++)
            {
                int num = int.Parse(Console.ReadLine());
                leftSum = leftSum + num;
            }
            
            // Дясна сума
            for (int counter = 1; counter <= n; counter++)
            {
                int num = int.Parse(Console.ReadLine());
                rightSum = rightSum + num;
            }

            // Проверяваме дали двете суми са равни
            if(leftSum == rightSum)
            {
                Console.WriteLine($"Yes, sum = {leftSum}");
            }
            else
            {
                // 
                int difference = Math.Abs(leftSum - rightSum);
                Console.WriteLine($"No, diff = {difference}");
            }
            // Console.WriteLine(leftSum);
            //Console.WriteLine(rightSum);
        }
    }
}