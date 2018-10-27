using System;

namespace _05.PasswordGuess
{
    class PasswordGuess
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string password = "s3cr3t!P@ssw0rd";

            if(input == password)
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}
