using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.BestPlayer
{
    class BestPlayer
    {
        static void Main(string[] args)
        {
            // Променлива, в която ще пазим името на най-добрия играч
            string bestPlayerName = "";
            // Променлива, в която ще пазим колко са головете на най-добрия играч
            int bestPlayerGoals = int.MinValue;

            while(true)
            {
                string command = Console.ReadLine();

                if(command == "END")
                {
                    break;
                }

                string playerName = command;
                int goalsScored = int.Parse(Console.ReadLine());
                
                // Проверяваме дали головете на текущия най-добър играч са 
                // по-малко или равно на головете на играча, който сме
                // въвели сега.
                if(bestPlayerGoals < goalsScored)
                {
                    // Променяме името на най-добрия играч; Заменяме го с името на текущия играч
                    bestPlayerName = playerName;
                    // Променяме стойността на вкараните голове от най-добрия играч; Заменяме я със стойността на вкараните голове от текущия играч
                    bestPlayerGoals = goalsScored;
                }

                // ДАЛИ ТОЗИ ИГРАЧ Е НОВИЯТ НАЙ-ДОБЪР ИГРАЧ??
                // Ако футболистът е вкарал 10 или повече гола, програмата трябва да спре.
                if (goalsScored >= 10)
                {
                    break;
                }
            }

            Console.WriteLine($"{bestPlayerName} is the best player!");
            
            if(bestPlayerGoals >= 3)
            {
                Console.WriteLine($"He has scored {bestPlayerGoals} goals and made a hat-trick !!!");
            }
            else
            {
                Console.WriteLine($"He has scored {bestPlayerGoals} goals.");
            }
        }
    }
}