using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConnectFourVersion4
{
    class Board
    {

        public static void Main(string[] args)
        {

            Console.WriteLine("Enter height of board between 2 and 30: ");
            int height = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Enter width of board between 2 and 30");
            int width = Convert.ToInt32(Console.ReadLine());


            if (height < 2 || height > 30)
            {
                Console.WriteLine("Please enter a valid height");
            }
            if (width < 2 || width > 30)
            {
                Console.WriteLine("Please enter a valid width");
            }

            GameBoard board = new GameBoard(height, width);
            board.DrawBoard(height, width);

            Game myGame = new Game();
            char[,] gameMove = myGame.GetPositionOfGameMove(height, width);

            myGame.DropPiece(gameMove);
            board.DisplayBoardAfterMove(myGame.gamePiece);

        }







    }
}