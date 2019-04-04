using System;

namespace GameChallenge
{
    public class Board
    {
        private int widthOfBoard;
        private int heightOfBoard;

        public int WidthOfBoard { get => widthOfBoard; set => widthOfBoard = value; }
        public int HeightOfBoard { get => heightOfBoard; set => heightOfBoard = value; }

        public Board()
        {
            WidthOfBoard = 7;
            HeightOfBoard = 6;
            Board[,] board = new Board [7, 6];
        }

        public void DrawBlankSpacesInCell()
        {    
            for (int cells = 1; cells < WidthOfBoard; cells++)
                Console.Write("     |");

            Console.WriteLine("     |");
        }

        public void DrawBottomLinesOfCell()
        {
            for (int cells = 1; cells < WidthOfBoard; cells++)
                Console.Write("_____|");

            Console.WriteLine("_____|");
        }

        public void DrawGameBoard()
        {
            for (int cells = 0; cells < HeightOfBoard; cells++)
            {
                DrawBlankSpacesInCell();
                DrawBlankSpacesInCell();
                DrawBottomLinesOfCell();
            }
        } 
    }  
}
