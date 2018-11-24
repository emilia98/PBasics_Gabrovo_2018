using System;

namespace _06.Substitute
{
    class Program
    {
        static void Main(string[] args)
        {
            // K - началото на интервала за първото число от първия номер – цифра в интервала [0..8]
            int k = int.Parse(Console.ReadLine());
            // L - началото на интервала за второто число от първия номер – цифра в интервала [9..0]
            int l = int.Parse(Console.ReadLine());
            // M - началото на интервала за първото число от втория номер – цифра в интервала [0..8]
            int m = int.Parse(Console.ReadLine());
            // N - началото на интервала за второто число от втория номер – цифра в интервала [9..0]
            int n = int.Parse(Console.ReadLine());

            // Направените смени до момента
            int subsMade = 0;
            for(int i1 = k; i1 <= 8; i1++)
            {
                for(int i2 = 9; i2 >= l; i2--)
                {
                    for(int i3 = m; i3 <= 8; i3++)
                    {
                        for (int i4 = 9; i4 >= n; i4--)
                        {
                            // {i1}{i2} - {i3}{i4}
                            // 79 - 89
                            // първото число от номера трябва да бъде четно, а второто нечетно. 

                            if ((i1 % 2 == 0 && i2 % 2 == 1) &&
                                (i3 % 2 == 0 && i4 % 2 == 1))
                            {
                                // subsMade++; - НЕ Е ВЯРНО

                                // {i1}{i2} - {i3}{i4}
                                if (i1 == i3 && i2 == i4)
                                {
                                    Console.WriteLine($"Cannot change the same player.");
                                }
                                else
                                {
                                    subsMade++;
                                    Console.WriteLine($"{i1}{i2} - {i3}{i4}");
                                }
                            }

                            // Ако сме достигнали лимита от смени, излизаме от цикъла
                            /*
                            if (subsMade == 6)
                            {
                                break;
                            }
                            */
                            if (subsMade == 6)
                            {
                                return;
                            }
                        }

                        /*
                        if (subsMade == 6)
                        {
                            break;
                        }*/
                    }
                    /*
                    if (subsMade == 6)
                    {
                        break;
                    }*/
                }
                /*
                if (subsMade == 6)
                {
                    break;
                }*/
            }

            // Console.WriteLine("HEHEHEHEHE");
            // for(int i1 = )
            // [k-8] -> 1
            // [l-0]
            // [m-8]
            // [n-0]
        }
    }
}
