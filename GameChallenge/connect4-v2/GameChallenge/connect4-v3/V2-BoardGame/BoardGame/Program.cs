using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGame
{

    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.Write("Height of board: ");
            int height = Convert.ToInt32(Console.ReadLine());

            Console.Write("Width of board: ");
            int width = Convert.ToInt32(Console.ReadLine());
            */

            //Board board = new Board();
            ConnectFourGame game = new ConnectFourGame();
            while (ConnectFourGame.MovesCounter < 42)
            {
                Console.WriteLine("Enter an x-coordinate from 0-6");
                int xCoordinate = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Enter a y-coordinate from 0-5");
                int yCoordinate = Int32.Parse(Console.ReadLine());

                game.ApplyMove(xCoordinate, yCoordinate);

                Console.WriteLine();
            }

            Console.ReadLine();
        }
        /*
        private static string GetPrintableChar()
        {
            State stateOfCoordinate = BoardGame.State
        }
        */

    }
}
