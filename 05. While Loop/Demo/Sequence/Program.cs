﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2 * predishnoChislo + 1
            int n = int.Parse(Console.ReadLine());
            int previous = 1;
            int newValue = 2 * previous + 1;

            Console.WriteLine(1);

            while(newValue <= n)
            {
                Console.WriteLine(newValue);

                // Старата стойност на израза (oldValue)
                int oldValue = newValue;
                // Променяме стойността на previous да стане равна 
                // на старата стойност на израза
                previous = oldValue;
                // Образуваме нова стойност, която да бъде бъде 
                // пресметната по формулата
                newValue = 2 * oldValue + 1;
            }

        }
    }
}
