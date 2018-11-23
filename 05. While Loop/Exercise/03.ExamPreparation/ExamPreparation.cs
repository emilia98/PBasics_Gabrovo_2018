using System;

namespace _03.ExamPreparation
{
    class ExamPreparation
    {
        static void Main()
        {
            int notEnoughs = int.Parse(Console.ReadLine());
            int gradesCount = 0;
            int poorGrades = 0;
            string lastSolvedProblem = "";
            int gradesSum = 0;
            bool tooManyPoorGrades = false;

            while(true)
            {
                string command = Console.ReadLine();

                if(command == "Enough")
                {
                    break;
                }

                string problemName = command;
                int currentGrade = int.Parse(Console.ReadLine());

                lastSolvedProblem = problemName;
                gradesCount++;
                gradesSum += currentGrade;

                if (currentGrade <= 4)
                {
                    poorGrades++;
                }

                if(poorGrades == notEnoughs)
                {
                    tooManyPoorGrades = true;
                    break;
                }
            }

            if(tooManyPoorGrades == true)
            {
                Console.WriteLine($"You need a break, {poorGrades} poor grades.");
            }
            else
            {
                double average = gradesSum * 1.0 / gradesCount;
                Console.WriteLine($"Average score: {average:f2}");
                Console.WriteLine($"Number of problems: {gradesCount}");
                Console.WriteLine($"Last problem: {lastSolvedProblem}");
            }
        }
    }
}