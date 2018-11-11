using System;

namespace _06.Cake
{
    class Cake
    {
        static void Main()
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int totalPieces = width * length;
            int piecesLeft = totalPieces;
            int piecesNeeded = 0;

            while(true)
            {
                string input = Console.ReadLine();
                
                // Ако сме въвели STOP, излизаме от цикъла
                if (input == "STOP")
                {
                    break;
                }

                // Ако не сме въвели STOP, можем да парснем входа към число
                int piecesTaken = int.Parse(input);
                
                if (piecesTaken > piecesLeft)
                {
                    piecesNeeded = piecesTaken - piecesLeft;
                    piecesLeft = 0;
                    break;
                }

                piecesLeft -= piecesTaken;
            }

            if(piecesLeft > 0)
            {
                Console.WriteLine($"{piecesLeft} pieces are left.");
            }
            else
            {
                Console.WriteLine($"No more cake left! You need {piecesNeeded} pieces more.");
            }
        }
    }
}