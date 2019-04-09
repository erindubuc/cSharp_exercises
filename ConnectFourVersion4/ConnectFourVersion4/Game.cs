using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectFourVersion4
{
    public class Game
    {
        public char gamePiece;

        public char[,] GetPositionOfGameMove(int height, int width)
        {
            char[,] movePosition = new char[height, width];
            return movePosition;
        }

        public void DropPiece(char[,] movePosition)
        {
            Console.WriteLine("Please enter a number between 1 and 7: ");
            int dropColumn = Convert.ToInt32(Console.ReadLine()) - 1;
            int rowHeight = movePosition.GetLength(0) - 1;

            gamePiece = (movePosition[rowHeight, dropColumn] != 'X') ? 'X' : 'O';
        }
    }
}
