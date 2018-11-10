using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberSequence
{
    class Program
    {
        static void Main()
        {
            string text = Console.ReadLine();
            int max = int.MinValue;
            int min = int.MaxValue;

            while(text != "END")
            {
                // Parsvame text
                int num = int.Parse(text);
                // Proverqvame dali e nai-golqmo ili nai-malko
                if(num >= max)
                {
                    max = num;
                }
                
                if(num <= min)
                {
                    min = num;
                }
                // Vyvejdame nov text
                text = Console.ReadLine();
            }
            Console.WriteLine($"Max number: {max}");
            Console.WriteLine($"Min number: {min}");
        }
    }
}
