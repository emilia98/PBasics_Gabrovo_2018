﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string wordA = Console.ReadLine();
            string wordB = Console.ReadLine();

            wordA = wordA.ToLower();
            wordB = wordB.ToLower();

            if (wordA.Equals(wordB))
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
