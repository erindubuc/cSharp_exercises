using System;

namespace GameChallenge
{
    public class BoardGame
    {
        public int heightOfBoard;
        public int widthOfBoard;

        public void DrawBlankSpacesInCell(int widthOfBoard)
        {    
            for (int cells = 1; cells < widthOfBoard; cells++)
                Console.Write("     |");

            Console.WriteLine("     |");
        }

        public void DrawBottomLinesOfCell(int widthOfBoard)
        {
            for (int cells = 1; cells < widthOfBoard; cells++)
                Console.Write("_____|");

            Console.WriteLine("_____|");
        }

        public void DrawGameBoard(int widthOfBoard, int heightOfBoard)
        {
            for (int cells = 0; cells < heightOfBoard; cells++)
            {
                DrawBlankSpacesInCell(widthOfBoard);
                DrawBlankSpacesInCell(widthOfBoard);
                DrawBottomLinesOfCell(widthOfBoard);
            }
        } 
    }  
}
