using System;

namespace _06.TicketCombination
{
    class Program
    {
        static void Main(string[] args)
        {
            int combinationNumber = int.Parse(Console.ReadLine());

            int generatedCombinations = 0;
            // string 

            for(char i1 = 'B'; i1 <= 'L'; i1++)
            {
                // Ако е с четен ASCII код, можем да генерираме комбинация
                if((int)i1 % 2 == 0)
                {
                    //Символът f е след a => ще намаляме
                    for(char i2 = 'f'; i2 >= 'a'; i2--)
                    {
                        for(char i3 = 'A'; i3 <= 'C'; i3++)
                        {
                            for(int i4 = 1; i4 <= 10; i4++)
                            {
                                for(int i5 = 10; i5 >= 1; i5--)
                                {
                                    // Console.WriteLine($"{i1}{i2}{i3}{i4}{i5}");
                                    // Увеличаваме броя на генерираните комбинации
                                    generatedCombinations++;

                                    // Проверяваме дали сме стигнали до желаната комбинация 
                                    if(generatedCombinations == combinationNumber)
                                    {
                                        int prize = 0;

                                        prize = (int)i1 + (int)i2 + (int)i3 + i4 + i5;
                                        Console.WriteLine($"Ticket combination: {i1}{i2}{i3}{i4}{i5}");
                                        Console.WriteLine($"Prize: {prize} lv.");
                                        break;
                                    }

                                }
                                if (generatedCombinations == combinationNumber)
                                {
                                    break;
                                }
                            }
                            if (generatedCombinations == combinationNumber)
                            {
                                break;
                            }
                        }
                        if (generatedCombinations == combinationNumber)
                        {
                            break;
                        }
                    }
                    if (generatedCombinations == combinationNumber)
                    {
                        break;
                    }
                }
            }
        }
    }
}