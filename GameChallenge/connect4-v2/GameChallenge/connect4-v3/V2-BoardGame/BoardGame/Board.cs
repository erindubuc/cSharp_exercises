using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGame
{
    public class Board
    {
        private int _height;
        private int _width;

        public Board()
        {
            _height = 6;
            _width = 7;

            DrawBoard(_height, _width);
        }


        public void DrawBoard(int height, int width)
        {
            DrawTopBorder(width);

            for (var i = 0; i < height; i++)
                DrawCells(width);
        }

        public void DrawTopBorder(int width)
        {
            for (var i = 0; i < width; i++)
                Console.Write("+--");
            Console.WriteLine("+");
        }

        public void DrawCells(int width)
        {
            int j;

            Console.Write("|  ");
            for (j = 0; j < width; j++)
                Console.Write("|  ");

            if (j == width)
            {
                Console.WriteLine();
                for (var i = 0; i < width; i++)
                    Console.Write("+--");
            }

            Console.Write("+\n");
        }

        /*
        public static bool IsHeightAndWidthValid(int height, int width)
        {

            return height > 2 && height <= 30 && width > 2 && width <= 30;
        }
        */
    }    
}
