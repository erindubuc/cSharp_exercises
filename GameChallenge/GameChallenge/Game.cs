using System;

namespace GameChallenge
{
    public class Game
    {
        //public int[,] grid;
        public int height;
        public int width;

        public void DrawBlankRow(int width)
        {    
            for (int i = 1; i < width; i++)
                Console.Write("     |");

            Console.WriteLine("     ");
        }

        public void DrawLineRow(int width)
        {
            for (int i = 1; i < width; i++)
                Console.Write("_____|");

            Console.WriteLine("_____");
        }

        public void DrawBoard(int width, int height)
        {
            for (int i = 0; i < height; i++)
            {
                DrawBlankRow(width);
                DrawBlankRow(width);
                DrawLineRow(width);
            }
        } 
    }  
}
