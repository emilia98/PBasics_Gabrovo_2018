using System;

namespace _09.OperationsBetweenNumbers
{
    class Operations
    {
        static void Main()
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            char sign = char.Parse(Console.ReadLine());

            if(sign == '/' || sign == '%')
            {
                if(n2 == 0)
                {
                    Console.WriteLine($"Cannot divide {n1} by zero");
                }
                else
                {
                    double result = 0;
                    string formatedResult = "";

                    if(sign == '/')
                    {
                        result = n1 * 1.0 / n2;
                        formatedResult = String.Format("{0:f2}", result);
                    }
                    else if(sign == '%')
                    {
                        result = n1 % n2;
                        formatedResult = result.ToString();
                    }

                    Console.WriteLine($"{n1} {sign} {n2} = {formatedResult}");
                }
            }
            else if(sign == '+' || sign == '-' || sign == '*')
            {
                double result = 0;
                string resultType = "";

                if(sign == '+')
                {
                    result = n1 + n2;
                }
                else if(sign == '-')
                {
                    result = n1 - n2;
                }
                else if(sign == '*')
                {
                    result = n1 * n2;
                }


                if(result % 2 == 0)
                {
                    resultType = "even";
                }
                else
                {
                    resultType = "odd";
                }

                Console.WriteLine($"{n1} {sign} {n2} = {result} - {resultType}");
            }
        }
    }
}