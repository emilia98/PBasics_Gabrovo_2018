using System;

namespace _02.BonusScore
{
    class BonusScore
    {
        static void Main()
        {
            int score = int.Parse(Console.ReadLine());
            double bonusScore = 0;

            if(score <= 100)
            {
                bonusScore = 5;
            }
            else if(score > 100 && score <= 1000)
            {
                bonusScore = (0.2 * score);
            }
            else if(score > 1000)
            {
                bonusScore = (0.1 * score);
            }
            
            // Проверка дали числото е четно
            if(score % 2 == 0)
            {
                bonusScore += 1;
            }

            // Последна цифра се взема с (числото % 10)
            else if(score % 10 == 5)
            {
                bonusScore += 2;
            }

            /* NOTE: Числото НЕ може да е едновременно четно и да завършва на 5. */
            double finalResult = score + bonusScore;
            Console.WriteLine(bonusScore);
            Console.WriteLine(finalResult);
        }
    }
}
